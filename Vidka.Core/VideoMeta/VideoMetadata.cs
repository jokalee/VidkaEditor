﻿//------------------------------------------------------------------------------
// <auto-generated>
//	 This code was generated by a tool.
//	 Runtime Version:4.0.30319.34014
//
//	 Changes to this file may cause incorrect behavior and will be lost if
//	 the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 
namespace Vidka.Core.VideoMeta {


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class tag {

		private string keyField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string key {
			get {
				return this.keyField;
			}
			set {
				this.keyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string value {
			get {
				return this.valueField;
			}
			set {
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class ffprobe {

		private object[] itemsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("format", typeof(ffprobeFormat), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("streams", typeof(ffprobeStreams), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("tag", typeof(tag))]
		public object[] Items {
			get {
				return this.itemsField;
			}
			set {
				this.itemsField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ffprobeFormat {

		private tag[] tagField;

		private string filenameField;

		private string nb_streamsField;

		private string nb_programsField;

		private string format_nameField;

		private string format_long_nameField;

		private string start_timeField;

		private string durationField;

		private string sizeField;

		private string bit_rateField;

		private string probe_scoreField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("tag")]
		public tag[] tag {
			get {
				return this.tagField;
			}
			set {
				this.tagField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string filename {
			get {
				return this.filenameField;
			}
			set {
				this.filenameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string nb_streams {
			get {
				return this.nb_streamsField;
			}
			set {
				this.nb_streamsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string nb_programs {
			get {
				return this.nb_programsField;
			}
			set {
				this.nb_programsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string format_name {
			get {
				return this.format_nameField;
			}
			set {
				this.format_nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string format_long_name {
			get {
				return this.format_long_nameField;
			}
			set {
				this.format_long_nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string start_time {
			get {
				return this.start_timeField;
			}
			set {
				this.start_timeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string duration {
			get {
				return this.durationField;
			}
			set {
				this.durationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string size {
			get {
				return this.sizeField;
			}
			set {
				this.sizeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string bit_rate {
			get {
				return this.bit_rateField;
			}
			set {
				this.bit_rateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string probe_score {
			get {
				return this.probe_scoreField;
			}
			set {
				this.probe_scoreField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ffprobeStreams {

		private ffprobeStreamsStream[] streamField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("stream", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ffprobeStreamsStream[] stream {
			get {
				return this.streamField;
			}
			set {
				this.streamField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ffprobeStreamsStream {

		private ffprobeStreamsStreamDisposition[] dispositionField;

		private tag[] tagField;

		private string indexField;

		private string codec_nameField;

		private string codec_long_nameField;

		private string profileField;

		private string codec_typeField;

		private string codec_time_baseField;

		private string codec_tag_stringField;

		private string codec_tagField;

		private string widthField;

		private string heightField;

		private string has_b_framesField;

		private string sample_aspect_ratioField;

		private string display_aspect_ratioField;

		private string pix_fmtField;

		private string levelField;

		private string chroma_locationField;

		private string is_avcField;

		private string nal_length_sizeField;

		private string r_frame_rateField;

		private string avg_frame_rateField;

		private string time_baseField;

		private string start_ptsField;

		private string start_timeField;

		private string duration_tsField;

		private string durationField;

		private string bit_rateField;

		private string bits_per_raw_sampleField;

		private string nb_framesField;

		private string sample_fmtField;

		private string sample_rateField;

		private string channelsField;

		private string channel_layoutField;

		private string bits_per_sampleField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("disposition", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ffprobeStreamsStreamDisposition[] disposition {
			get {
				return this.dispositionField;
			}
			set {
				this.dispositionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("tag")]
		public tag[] tag {
			get {
				return this.tagField;
			}
			set {
				this.tagField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string index {
			get {
				return this.indexField;
			}
			set {
				this.indexField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string codec_name {
			get {
				return this.codec_nameField;
			}
			set {
				this.codec_nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string codec_long_name {
			get {
				return this.codec_long_nameField;
			}
			set {
				this.codec_long_nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string profile {
			get {
				return this.profileField;
			}
			set {
				this.profileField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string codec_type {
			get {
				return this.codec_typeField;
			}
			set {
				this.codec_typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string codec_time_base {
			get {
				return this.codec_time_baseField;
			}
			set {
				this.codec_time_baseField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string codec_tag_string {
			get {
				return this.codec_tag_stringField;
			}
			set {
				this.codec_tag_stringField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string codec_tag {
			get {
				return this.codec_tagField;
			}
			set {
				this.codec_tagField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string width {
			get {
				return this.widthField;
			}
			set {
				this.widthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string height {
			get {
				return this.heightField;
			}
			set {
				this.heightField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string has_b_frames {
			get {
				return this.has_b_framesField;
			}
			set {
				this.has_b_framesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string sample_aspect_ratio {
			get {
				return this.sample_aspect_ratioField;
			}
			set {
				this.sample_aspect_ratioField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string display_aspect_ratio {
			get {
				return this.display_aspect_ratioField;
			}
			set {
				this.display_aspect_ratioField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string pix_fmt {
			get {
				return this.pix_fmtField;
			}
			set {
				this.pix_fmtField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string chroma_location {
			get {
				return this.chroma_locationField;
			}
			set {
				this.chroma_locationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string is_avc {
			get {
				return this.is_avcField;
			}
			set {
				this.is_avcField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string nal_length_size {
			get {
				return this.nal_length_sizeField;
			}
			set {
				this.nal_length_sizeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string r_frame_rate {
			get {
				return this.r_frame_rateField;
			}
			set {
				this.r_frame_rateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string avg_frame_rate {
			get {
				return this.avg_frame_rateField;
			}
			set {
				this.avg_frame_rateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string time_base {
			get {
				return this.time_baseField;
			}
			set {
				this.time_baseField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string start_pts {
			get {
				return this.start_ptsField;
			}
			set {
				this.start_ptsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string start_time {
			get {
				return this.start_timeField;
			}
			set {
				this.start_timeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string duration_ts {
			get {
				return this.duration_tsField;
			}
			set {
				this.duration_tsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string duration {
			get {
				return this.durationField;
			}
			set {
				this.durationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string bit_rate {
			get {
				return this.bit_rateField;
			}
			set {
				this.bit_rateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string bits_per_raw_sample {
			get {
				return this.bits_per_raw_sampleField;
			}
			set {
				this.bits_per_raw_sampleField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string nb_frames {
			get {
				return this.nb_framesField;
			}
			set {
				this.nb_framesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string sample_fmt {
			get {
				return this.sample_fmtField;
			}
			set {
				this.sample_fmtField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string sample_rate {
			get {
				return this.sample_rateField;
			}
			set {
				this.sample_rateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string channels {
			get {
				return this.channelsField;
			}
			set {
				this.channelsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string channel_layout {
			get {
				return this.channel_layoutField;
			}
			set {
				this.channel_layoutField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string bits_per_sample {
			get {
				return this.bits_per_sampleField;
			}
			set {
				this.bits_per_sampleField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ffprobeStreamsStreamDisposition {

		private string defaultField;

		private string dubField;

		private string originalField;

		private string commentField;

		private string lyricsField;

		private string karaokeField;

		private string forcedField;

		private string hearing_impairedField;

		private string visual_impairedField;

		private string clean_effectsField;

		private string attached_picField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string @default {
			get {
				return this.defaultField;
			}
			set {
				this.defaultField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string dub {
			get {
				return this.dubField;
			}
			set {
				this.dubField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string original {
			get {
				return this.originalField;
			}
			set {
				this.originalField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string comment {
			get {
				return this.commentField;
			}
			set {
				this.commentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string lyrics {
			get {
				return this.lyricsField;
			}
			set {
				this.lyricsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string karaoke {
			get {
				return this.karaokeField;
			}
			set {
				this.karaokeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string forced {
			get {
				return this.forcedField;
			}
			set {
				this.forcedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string hearing_impaired {
			get {
				return this.hearing_impairedField;
			}
			set {
				this.hearing_impairedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string visual_impaired {
			get {
				return this.visual_impairedField;
			}
			set {
				this.visual_impairedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string clean_effects {
			get {
				return this.clean_effectsField;
			}
			set {
				this.clean_effectsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string attached_pic {
			get {
				return this.attached_picField;
			}
			set {
				this.attached_picField = value;
			}
		}
	}
}