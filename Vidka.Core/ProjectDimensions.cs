﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vidka.Core.Model;

namespace Vidka.Core
{
	public class ProjectDimensions
	{
		private const float PIXEL_PER_FRAME = 1f; // a nice default zoom
		private const float ZOOM_CHANGE_FACTOR = 2.0f;

		// environment
		private VidkaProj proj;
		private int ScrollbarWidth;
		private int FloatPlayerWidth;

		// vertical subdivisions
		private ProjectDimensionsTimeline[] timelines;
		private ProjectDimensionsTimeline tlMain, tlMainEasing, tlOriginal, tlAudios;
		private int tlAxisHeight;

		// horizontal frame
		// TODO: save these values in a editor pref file so that next time the program is open, the same zoom is there
		private float zoom = 1;
		private int totalWidth, scrollx;

		public ProjectDimensions(VidkaProj proj) {
			this.proj = proj;
			init();
		}

		private void init()
		{
			tlOriginal = new ProjectDimensionsTimeline(0, 25, ProjectDimensionsTimelineType.Original) { yHalfway = 15 };
			//tlMain = new ProjectDimensionsTimeline(30, 70, ProjectDimensionsTimelineType.Main) { yHalfway = 55 };
            tlMain = new ProjectDimensionsTimeline(40, 65, ProjectDimensionsTimelineType.Main) { yHalfway = 55 };
            tlMainEasing = new ProjectDimensionsTimeline(65, 72, ProjectDimensionsTimelineType.MainEases);
			tlAudios = new ProjectDimensionsTimeline(75, 90, ProjectDimensionsTimelineType.Audios);
            timelines = new ProjectDimensionsTimeline[] { tlOriginal, tlMain, tlMainEasing, tlAudios };
			tlAxisHeight = 6;
		}

		public void setProj(VidkaProj proj) {
			this.proj = proj;
		}

		public void setNewDimensions(int floatPlayerWidth, int scrollbarWidth) {
			this.ScrollbarWidth = scrollbarWidth;
			this.FloatPlayerWidth = floatPlayerWidth;
		}

		#region ============================== frame of view =============================================

		public void setScroll(int x) {
			scrollx = x;
		}

		/// <summary>
		/// This changes scrollx and projectWidth
		/// </summary>
		internal void ZoomIn(int mouseX, int width) {
			changeZoom(ZOOM_CHANGE_FACTOR, mouseX, width);
		}
		/// <summary>
		/// This changes scrollx and projectWidth
		/// </summary>
		internal void ZoomOut(int mouseX, int width) {
			if (totalWidth < width)
				return;
			changeZoom(1f / ZOOM_CHANGE_FACTOR, mouseX, width);
		}
		/// <summary>
		/// This changes scrollx and projectWidth
		/// </summary>
		private void changeZoom(float factor, int mouseX, int width) {
			zoom *= factor;
			var prevWidth = totalWidth;
			totalWidth = recalculateProjectWidth();

			// update scroll to still be pointing to mouse
			var mouseXAbs1 = scrollx + mouseX; // before zoom
			var mouseXAbs2 = mouseXAbs1 * factor; // after zoom
			scrollx += (int)(mouseXAbs2 - mouseXAbs1);
			if (scrollx < 0)
				scrollx = 0;
			if (factor < 1f && totalWidth < width)
				scrollx = 0;
		}

		private int recalculateProjectWidth()
		{
			var totalFrameVideo = proj.GetTotalLengthOfVideoClipsFrame();
			var totalFrameAudio = proj.GetTotalLengthOfAudioClipsFrame();
			//var totalSec = totalSecVideo; // can we just return video?
			var totalFrame = Math.Max(totalFrameVideo, totalFrameAudio);
			return convert_FrameToAbsX(totalFrame) + 1000;
		}

		public int getTotalWidthPixels() {
			return totalWidth;
		}

		public int getTotalWidthPixelsForceRecalc() {
			totalWidth = recalculateProjectWidth();
			return totalWidth;
		}

		/// <summary>
		/// used to grab the new scroll after a zoom operation and set it in the UI
		/// </summary>
		public int getCurrentScrollX() {
			return scrollx;
		}

		#endregion

		#region ============================== collision =============================================

		public ProjectDimensionsTimelineType collision_whatTimeline(int y, int h)
		{
			lastCollision_succeeded = false;
            lastCollision_easeSide = TrimDirection.None;
            var y100 = 100f * y / h;
			var answer = timelines.FirstOrDefault(ttt => (y100 >= ttt.y1100 && y100 <= ttt.y2100));
			if (answer == null)
				return ProjectDimensionsTimelineType.None;
			lastCollision_y1 = answer.y1100 * h / 100;
			lastCollision_y2 = answer.y2100 * h / 100;
			return answer.Type;
		}

		public VidkaClipVideoAbstract collision_main(int x)
		{
			lastCollision_succeeded = false;
            lastCollision_easeSide = TrimDirection.None;
			long frameTotal = 0;
			foreach (var ccc in proj.ClipsVideo)
			{
				if (lastCollision_succeeded = calculateCollision_proj(x, frameTotal, ccc.LengthFrameCalc))
					return ccc;
				frameTotal += ccc.LengthFrameCalc;
			}
			return null;
		}

        public VidkaClipVideoAbstract collision_mainEases(int x)
        {
            lastCollision_succeeded = false;
            lastCollision_easeSide = TrimDirection.None;
            long frameTotal = 0;
            foreach (var ccc in proj.ClipsVideo)
            {
                if (ccc.EasingLeft > 0)
                    if (lastCollision_succeeded = calculateCollision_proj(x, frameTotal - ccc.EasingLeft, ccc.EasingLeft)) {
                        lastCollision_easeSide = TrimDirection.Left;
                        return ccc;
                    }
                if (ccc.EasingRight > 0)
                    if (lastCollision_succeeded = calculateCollision_proj(x, frameTotal + ccc.LengthFrameCalc, ccc.EasingRight)) {
                        lastCollision_easeSide = TrimDirection.Right;
                        return ccc;
                    }
                frameTotal += ccc.LengthFrameCalc;
            }
            return null;
        }

		public VidkaClipAudio collision_audio(int x)
		{
			lastCollision_succeeded = false;
            lastCollision_easeSide = TrimDirection.None;
            VidkaClipAudio lastAudioClipCollision = null;
			foreach (var ccc in proj.ClipsAudio)
			{
                if (lastCollision_succeeded = calculateCollision_proj(x, ccc.FrameOffset, ccc.LengthFrameCalc))
                    lastAudioClipCollision = ccc;
			}
            return lastAudioClipCollision;
		}

		/// <summary>
		/// this returns just the bool because the collision choice is the one clip
		/// But calling this prepares the lastCollision_? variables
		/// </summary>
		public bool collision_original_one(int x, int w, long totalLengthFrames, long start, long end)
		{
			lastCollision_x1 = convert_Frame2ScreenX_OriginalTimeline(start, totalLengthFrames, w);
			lastCollision_x2 = convert_Frame2ScreenX_OriginalTimeline(end, totalLengthFrames, w);
			//lastCollision_succeeded = (x >= lastCollision_x1) && (x <= lastCollision_x2);
			var frameX = convert_ScreenX2Frame_OriginalTimeline(x, totalLengthFrames, w);
			lastCollision_succeeded = (frameX >= start) && (frameX < end);
			return lastCollision_succeeded;
		}

		public VidkaClip collision_original_all(int x, int w, IEnumerable<VidkaClip> clips)
		{
            var allResults = clips.Where(clip => collision_original_one(x, w, clip.FileLengthFrames, clip.FrameStartNoEase, clip.FrameEndNoEase));
			if (allResults.Count() <= 1)
				return allResults.FirstOrDefault();
			var sampleClip = allResults.FirstOrDefault(); // should never be null!
			var maxStart = allResults.Select(clip => clip.FrameStart).Max();
			var minEnd = allResults.Select(clip => clip.FrameEnd).Min();
			var frameX = convert_ScreenX2Frame_OriginalTimeline(x, sampleClip.FileLengthFrames, w);
			var index = (int)(allResults.Count() * (frameX - maxStart) / (minEnd - maxStart));
			var finalChoice = allResults.Skip(index).FirstOrDefault();
			//var finalChoice = allResults
			//	.OrderBy(clip => collision_original_all_choiceWeight(clip, frameX, maxStart, minEnd))
			//	.FirstOrDefault();
            lastCollision_x1 = convert_Frame2ScreenX_OriginalTimeline(finalChoice.FrameStartNoEase, finalChoice.FileLengthFrames, w);
            lastCollision_x2 = convert_Frame2ScreenX_OriginalTimeline(finalChoice.FrameEndNoEase, finalChoice.FileLengthFrames, w);
			
			lastCollision_succeeded = true;
			return finalChoice;
		}

		//private double collision_original_all_choiceWeight(VidkaClip clip, long frameX, long maxStart, long minEnd)
		//{
		//	double lenRange = minEnd - maxStart;
		//	return clip.LengthFrameCalc / lenRange + (minEnd - frameX) / lenRange;
		//}

		/// <summary>
		/// Common collision helper.
		/// Calculates collision with objects relative to entire project timeline
		/// (as opped to "original" which has its own measure system)
		/// </summary>
		private bool calculateCollision_proj(int x, long frameStart, long frameLength)
		{
			lastCollision_x1 = this.convert_Frame2ScreenX(frameStart);
			lastCollision_x2 = this.convert_Frame2ScreenX(frameStart + frameLength);
			return x >= lastCollision_x1 && x <= lastCollision_x2;
		}

		// the following are used after collision_? calls to recycle the values we just calculated
		
		/// <summary>
		/// Will be true if lastCollision_* coordinates are valid, otherwise there had been no collision
		/// </summary>
		public bool lastCollision_succeeded { get; private set; }
        public int lastCollision_x1 { get; private set; }
		public int lastCollision_x2 { get; private set; }
		public int lastCollision_y1 { get; private set; }
		public int lastCollision_y2 { get; private set; }
        public TrimDirection lastCollision_easeSide { get; private set; }

		#endregion

		#region ============================== rendering ===========================================

		/// <summary>
		/// Converts frames to seconds
		/// </summary>
		public double FrameToSec(int frame) {
			return frame / proj.FrameRate;
		}
		/// <summary>
		/// Converts seconds to frames
		/// </summary>
		public int SecToFrame(double sec) {
			return (int)(sec * proj.FrameRate);
		}

		public int getScreenX1_video(VidkaClipVideoAbstract vclip)
		{
			long frameTotal = 0;
			foreach (var ccc in proj.ClipsVideo) {
				if (ccc == vclip)
					break;
				frameTotal += ccc.LengthFrameCalc;
			}
			return convert_Frame2ScreenX(frameTotal);
		}

		//public int getScreenX1(VidkaClip clip) {
		//	return proj.ClipsAudio.Contains(clip)//todo
		//			? (IEnumerable<VidkaClip>)proj.ClipsAudio
		//			: (IEnumerable<VidkaClip>)proj.ClipsVideo;
		//}

		/// <summary>
		/// just for one point
		/// </summary>
		public bool isEvenOnTheScreen(long frame, int w) {
			var screenX = convert_Frame2ScreenX(frame);
			return screenX >= 0 && screenX < w;
		}

		/// <summary>
		/// the screen is too zoomed-in and neither of the bounds of the clip {}
		/// are not within our view [] but the middle is... {----[___]-}
		/// </summary>
		public bool isFromEastToWest(long frameStart, long frameEnd, int w) {
			var screenX1 = convert_Frame2ScreenX(frameStart);
			var screenX2 = convert_Frame2ScreenX(frameEnd);
			return screenX1 <= 0 && screenX2 >= w;
		}

		/// <summary>
		/// for an actual event with start and finish (in frames)
		/// </summary>
		public bool isEvenOnTheScreen(long fStart, long fEnd, int w) {
			return isEvenOnTheScreen(fStart, w)
				|| isEvenOnTheScreen(fEnd, w)
				|| isFromEastToWest(fStart, fEnd, w);
		}

		public int getY_original1(int h) {
			return h * tlOriginal.y1100 / 100;
		}
		public int getY_original2(int h) {
			return h * tlOriginal.y2100 / 100;
		}
		public int getY_original_half(int h) {
			return h * tlOriginal.yHalfway / 100;
		}
		public int getY_main1(int h) {
			return h * tlMain.y1100 / 100;
		}
		public int getY_main2(int h) {
			return h * tlMain.y2100 / 100;
		}
		public int getY_main_half(int h) {
			return h * tlMain.yHalfway / 100;
		}
        public int getY_main_easing1(int h) {
			return h * tlMainEasing.y1100 / 100;
		}
        public int getY_main_easing2(int h) {
			return h * tlMainEasing.y2100 / 100;
		}
		public int getY_audio1(int h) {
			return h * tlAudios.y1100 / 100;
		}
		public int getY_audio2(int h) {
			return h * tlAudios.y2100 / 100;
		}
		public int getY_timeAxisHeight(int h) {
			return h * tlAxisHeight / 100;
		}

		#endregion

		#region ============================== converters ===========================================

		/// <summary>
		/// Converts frame to x-coordinate (absolute)
		/// </summary>
		public int convert_FrameToAbsX(long frame) {
			return (int)(frame * PIXEL_PER_FRAME * zoom);
		}

		/// <summary>
		/// Converts frame to x-coordinate on screen
		/// </summary>
		public int convert_Frame2ScreenX(long frame) {
			return convert_FrameToAbsX(frame) - scrollx;
		}

		/// <summary>
		/// Converts x-coordinate (on screen!!!) to frame
		/// </summary>
		public long convert_ScreenX2Frame(int x) {
			return (long)((x + scrollx) / PIXEL_PER_FRAME / zoom);
		}

		/// <summary>
		/// Converts x-coordinate (on screen!!!) to frame on the original timeline
		/// </summary>
		public long convert_ScreenX2Frame_OriginalTimeline(int x, long lengthFile, int screenW) {
			return (long)(lengthFile * x / screenW);
		}

		/// <summary>
		/// Converts frmae to x-coordinate (on screen!!!) on the original timeline
		/// </summary>
		public int convert_Frame2ScreenX_OriginalTimeline(long frame, long lengthFile, int screenW) {
			return (int)((float)screenW * frame / lengthFile);
		}

        /// <summary>
        /// Converts sec to x-coordinate (on screen!!!) on the original timeline
        /// </summary>
        public int convert_Sec2ScreenX_OriginalTimeline(double sec, long lengthFile, int screenW) {
            return convert_Frame2ScreenX_OriginalTimeline(SecToFrame(sec), lengthFile, screenW);
        }

		/// <summary>
		/// Converts x-coordinate (absolute) to frame.
		/// Used in deltaX --> nFrames conversion
		/// </summary>
		public long convert_AbsX2Frame(int x)
		{
			return (long)((x) / PIXEL_PER_FRAME / zoom);
		}

		public float convert_AbsX2Seconds(int x) {
			return (float)((x) / PIXEL_PER_FRAME / zoom / proj.FrameRate);
		}

		/// <summary>
		/// Converts second to x-coordinate (absolute). Used for draing Axis when fps is not a round int (29.9)
		/// </summary>
		public int convert_SecToAbsX(double sec) {
			return (int)(proj.SecToFrameDouble(sec) * PIXEL_PER_FRAME * zoom);
		}

		/// <summary>
		/// Converts second to x-coordinate on screen. Used for draing Axis when fps is not a round int (29.9)
		/// </summary>
		public int convert_Sec2ScreenX(double sec) {
			return convert_SecToAbsX(sec) - scrollx;
		}

		/// <summary>
		/// Converts x-coordinate (on screen!!!) to second
		/// </summary>
		//public double convert_ScreenX2Sec(int x) {
		//	return (x + scrollx) / PIXEL_PER_SEC / zoom;
		//}

		#endregion

		#region ============================== miscellaneous ===========================================

		/// <summary>
		/// Returns index of the clip before which the draggy should be inserted had it been dropped
		/// </summary>
		public int GetVideoClipDraggyShoveIndex(EditorDraggy draggy)
		{
			if (draggy.Mode != EditorDraggyMode.VideoTimeline)
				return -1;
			//long draggyFrameLeft = convert_ScreenX2Frame(draggy.MouseX - draggy.MouseXOffset);
			long draggyFrameLeft = convert_ScreenX2Frame(draggy.MouseX);
			long totalFrames = 0;
			int index = 0;
			foreach (var clip in proj.ClipsVideo)
			{
				if (totalFrames + clip.LengthFrameCalc / 2 >= draggyFrameLeft)
					return index;
				totalFrames += clip.LengthFrameCalc;
				index++;
			}
			return index;
		}

		#endregion




	}
}
