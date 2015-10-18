﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;

namespace Vidka.Core.Ops
{
	public enum OpResultCode {
		/// <summary>
		/// Op is not yet finished
		/// </summary>
		Incomplete = 0,
		OK = 1,
		FileNotFound = 2,
		OtherError = 3
	}
	public class OpBaseClass
	{
		//protected const string ffmpegPath = @"C:\Users\Mikhail\Desktop\tools\ffmpeg";
		//protected const string FfmpegExecutable = ffmpegPath + @"\bin\ffmpeg.exe";
		//protected const string FfprobeExecutable = ffmpegPath + @"\bin\ffprobe.exe";

		public const string FfmpegExecutable = "ffmpeg";
        public const string FfprobeExecutable = "ffprobe";
        public const string MencoderExecutable = "mencoder";
        public const string MplayerExecutable = "mplayer";
        public const string VirtualDubExecutable = "VirtualDub";
		protected const string TmpFolderName = "tmp";

		public OpBaseClass()
		{
			ResultCode = OpResultCode.Incomplete;
			ErrorMessage2 = null;
		}

		protected string TempFolder { get { return VidkaIO.GetFileFromThisAppDirectory(TmpFolderName); } }

		protected void MakeSureTmpFolderExists() {
			if (!Directory.Exists(TempFolder))
				Directory.CreateDirectory(TempFolder);
		}

		protected void runProcessRememberError(Process process) {
			try {
				process.Start();
				process.WaitForExit();// Waits here for the process to exit.
			}
			catch (Win32Exception ex) {
				if (ex.NativeErrorCode == 2)
					ResultCode = OpResultCode.FileNotFound;
				else {
					ResultCode = OpResultCode.OtherError;
					ErrorMessage = ex.Message;
				}
			}
			catch (Exception ex) {
				ResultCode = OpResultCode.OtherError;
				ErrorMessage = ex.Message;
			}
		}

		public OpResultCode ResultCode { get; protected set; }
		public string ErrorMessage { get; protected set; }
		public string ErrorMessage2 { get; protected set; }
	}
}
