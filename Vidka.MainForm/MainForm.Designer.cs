﻿namespace Vidka.MainForm
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleFastModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereIsThisClipUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleTextClipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentFrameStillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildAuxillaryFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteAllNonlockedClipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearShuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOnGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereIsTheCurrentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereIsTheCurrentFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.associatevidkaFilesWithThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.vidkaFastPreviewPlayer = new Vidka.Components.VidkaFastPreviewPlayer();
            this.videoShitbox = new Vidka.Components.VideoShitbox();
            this.vidkaPreviewPlayer = new Vidka.Components.VidkaPreviewPlayer();
            this.checkForErrorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.opsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToVideoToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 48);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(478, 46);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(478, 46);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(478, 46);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(478, 46);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(475, 6);
            // 
            // exportToVideoToolStripMenuItem
            // 
            this.exportToVideoToolStripMenuItem.Name = "exportToVideoToolStripMenuItem";
            this.exportToVideoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+E";
            this.exportToVideoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exportToVideoToolStripMenuItem.Size = new System.Drawing.Size(478, 46);
            this.exportToVideoToolStripMenuItem.Text = "Export to video";
            this.exportToVideoToolStripMenuItem.Click += new System.EventHandler(this.exportToVideoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(475, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(478, 46);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleConsoleToolStripMenuItem,
            this.toggleFastModeToolStripMenuItem,
            this.whereIsThisClipUsedToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(94, 48);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toggleConsoleToolStripMenuItem
            // 
            this.toggleConsoleToolStripMenuItem.Name = "toggleConsoleToolStripMenuItem";
            this.toggleConsoleToolStripMenuItem.ShortcutKeyDisplayString = "O";
            this.toggleConsoleToolStripMenuItem.Size = new System.Drawing.Size(451, 46);
            this.toggleConsoleToolStripMenuItem.Text = "Toggle Console";
            this.toggleConsoleToolStripMenuItem.Click += new System.EventHandler(this.toggleConsoleToolStripMenuItem_Click);
            // 
            // toggleFastModeToolStripMenuItem
            // 
            this.toggleFastModeToolStripMenuItem.Name = "toggleFastModeToolStripMenuItem";
            this.toggleFastModeToolStripMenuItem.ShortcutKeyDisplayString = "P";
            this.toggleFastModeToolStripMenuItem.Size = new System.Drawing.Size(451, 46);
            this.toggleFastModeToolStripMenuItem.Text = "Toggle Fast Preview";
            this.toggleFastModeToolStripMenuItem.Click += new System.EventHandler(this.toggleFastModeToolStripMenuItem_Click);
            // 
            // whereIsThisClipUsedToolStripMenuItem
            // 
            this.whereIsThisClipUsedToolStripMenuItem.Name = "whereIsThisClipUsedToolStripMenuItem";
            this.whereIsThisClipUsedToolStripMenuItem.ShortcutKeyDisplayString = "W";
            this.whereIsThisClipUsedToolStripMenuItem.Size = new System.Drawing.Size(451, 46);
            this.whereIsThisClipUsedToolStripMenuItem.Text = "Where is this clip used?";
            this.whereIsThisClipUsedToolStripMenuItem.Click += new System.EventHandler(this.whereIsThisClipUsedToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleTextClipToolStripMenuItem,
            this.currentFrameStillToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(104, 48);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // simpleTextClipToolStripMenuItem
            // 
            this.simpleTextClipToolStripMenuItem.Name = "simpleTextClipToolStripMenuItem";
            this.simpleTextClipToolStripMenuItem.Size = new System.Drawing.Size(331, 46);
            this.simpleTextClipToolStripMenuItem.Text = "Simple text clip";
            this.simpleTextClipToolStripMenuItem.Click += new System.EventHandler(this.simpleTextClipToolStripMenuItem_Click);
            // 
            // currentFrameStillToolStripMenuItem
            // 
            this.currentFrameStillToolStripMenuItem.Name = "currentFrameStillToolStripMenuItem";
            this.currentFrameStillToolStripMenuItem.Size = new System.Drawing.Size(331, 46);
            this.currentFrameStillToolStripMenuItem.Text = "Current frame still";
            this.currentFrameStillToolStripMenuItem.Click += new System.EventHandler(this.currentFrameStillToolStripMenuItem_Click);
            // 
            // opsToolStripMenuItem
            // 
            this.opsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rebuildAuxillaryFilesToolStripMenuItem,
            this.checkForErrorsToolStripMenuItem,
            this.toolStripSeparator3,
            this.deleteAllNonlockedClipsToolStripMenuItem,
            this.linearShuffleToolStripMenuItem});
            this.opsToolStripMenuItem.Name = "opsToolStripMenuItem";
            this.opsToolStripMenuItem.Size = new System.Drawing.Size(84, 48);
            this.opsToolStripMenuItem.Text = "Ops";
            // 
            // rebuildAuxillaryFilesToolStripMenuItem
            // 
            this.rebuildAuxillaryFilesToolStripMenuItem.Name = "rebuildAuxillaryFilesToolStripMenuItem";
            this.rebuildAuxillaryFilesToolStripMenuItem.Size = new System.Drawing.Size(451, 46);
            this.rebuildAuxillaryFilesToolStripMenuItem.Text = "Rebuild auxillary files";
            this.rebuildAuxillaryFilesToolStripMenuItem.Click += new System.EventHandler(this.rebuildAuxillaryFilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(448, 6);
            // 
            // deleteAllNonlockedClipsToolStripMenuItem
            // 
            this.deleteAllNonlockedClipsToolStripMenuItem.Name = "deleteAllNonlockedClipsToolStripMenuItem";
            this.deleteAllNonlockedClipsToolStripMenuItem.Size = new System.Drawing.Size(451, 46);
            this.deleteAllNonlockedClipsToolStripMenuItem.Text = "Delete all non-locked clips";
            this.deleteAllNonlockedClipsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllNonlockedClipsToolStripMenuItem_Click);
            // 
            // linearShuffleToolStripMenuItem
            // 
            this.linearShuffleToolStripMenuItem.Name = "linearShuffleToolStripMenuItem";
            this.linearShuffleToolStripMenuItem.Size = new System.Drawing.Size(451, 46);
            this.linearShuffleToolStripMenuItem.Text = "Linear shuffle (by filename)";
            this.linearShuffleToolStripMenuItem.Click += new System.EventHandler(this.linearShuffleToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOnGithubToolStripMenuItem,
            this.whereIsTheCurrentFileToolStripMenuItem,
            this.whereIsTheCurrentFileToolStripMenuItem1,
            this.associatevidkaFilesWithThisToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(92, 48);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewOnGithubToolStripMenuItem
            // 
            this.viewOnGithubToolStripMenuItem.Name = "viewOnGithubToolStripMenuItem";
            this.viewOnGithubToolStripMenuItem.Size = new System.Drawing.Size(514, 46);
            this.viewOnGithubToolStripMenuItem.Text = "View on Github";
            this.viewOnGithubToolStripMenuItem.Click += new System.EventHandler(this.viewOnGithubToolStripMenuItem_Click);
            // 
            // whereIsTheCurrentFileToolStripMenuItem
            // 
            this.whereIsTheCurrentFileToolStripMenuItem.Name = "whereIsTheCurrentFileToolStripMenuItem";
            this.whereIsTheCurrentFileToolStripMenuItem.Size = new System.Drawing.Size(514, 46);
            this.whereIsTheCurrentFileToolStripMenuItem.Text = "Where is the current project?";
            this.whereIsTheCurrentFileToolStripMenuItem.Click += new System.EventHandler(this.whereIsTheCurrentFileToolStripMenuItem_Click);
            // 
            // whereIsTheCurrentFileToolStripMenuItem1
            // 
            this.whereIsTheCurrentFileToolStripMenuItem1.Name = "whereIsTheCurrentFileToolStripMenuItem1";
            this.whereIsTheCurrentFileToolStripMenuItem1.Size = new System.Drawing.Size(514, 46);
            this.whereIsTheCurrentFileToolStripMenuItem1.Text = "Where is the current media file?";
            this.whereIsTheCurrentFileToolStripMenuItem1.Click += new System.EventHandler(this.whereIsTheCurrentFileToolStripMenuItem1_Click);
            // 
            // associatevidkaFilesWithThisToolStripMenuItem
            // 
            this.associatevidkaFilesWithThisToolStripMenuItem.Name = "associatevidkaFilesWithThisToolStripMenuItem";
            this.associatevidkaFilesWithThisToolStripMenuItem.Size = new System.Drawing.Size(514, 46);
            this.associatevidkaFilesWithThisToolStripMenuItem.Text = "Associate .vidka files with this";
            this.associatevidkaFilesWithThisToolStripMenuItem.Click += new System.EventHandler(this.associatevidkaFilesWithThisToolStripMenuItem_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(1373, 525);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(613, 533);
            this.txtConsole.TabIndex = 3;
            this.txtConsole.Text = "";
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // vidkaFastPreviewPlayer
            // 
            this.vidkaFastPreviewPlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.vidkaFastPreviewPlayer.Location = new System.Drawing.Point(1195, 140);
            this.vidkaFastPreviewPlayer.Name = "vidkaFastPreviewPlayer";
            this.vidkaFastPreviewPlayer.Size = new System.Drawing.Size(407, 252);
            this.vidkaFastPreviewPlayer.TabIndex = 4;
            // 
            // videoShitbox
            // 
            this.videoShitbox.AllowDrop = true;
            this.videoShitbox.AutoScroll = true;
            this.videoShitbox.BackColor = System.Drawing.Color.White;
            this.videoShitbox.Location = new System.Drawing.Point(15, 71);
            this.videoShitbox.Margin = new System.Windows.Forms.Padding(6);
            this.videoShitbox.Name = "videoShitbox";
            this.videoShitbox.Size = new System.Drawing.Size(935, 678);
            this.videoShitbox.TabIndex = 2;
            // 
            // vidkaPreviewPlayer
            // 
            this.vidkaPreviewPlayer.Location = new System.Drawing.Point(1352, 102);
            this.vidkaPreviewPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.vidkaPreviewPlayer.Name = "vidkaPreviewPlayer";
            this.vidkaPreviewPlayer.Size = new System.Drawing.Size(634, 417);
            this.vidkaPreviewPlayer.TabIndex = 1;
            // 
            // checkForErrorsToolStripMenuItem
            // 
            this.checkForErrorsToolStripMenuItem.Name = "checkForErrorsToolStripMenuItem";
            this.checkForErrorsToolStripMenuItem.Size = new System.Drawing.Size(451, 46);
            this.checkForErrorsToolStripMenuItem.Text = "Check for errors";
            this.checkForErrorsToolStripMenuItem.Click += new System.EventHandler(this.checkForErrorsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.vidkaFastPreviewPlayer);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.videoShitbox);
            this.Controls.Add(this.vidkaPreviewPlayer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private Components.VidkaPreviewPlayer vidkaPreviewPlayer;
		private Components.VideoShitbox videoShitbox;
		private System.Windows.Forms.RichTextBox txtConsole;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private Components.VidkaFastPreviewPlayer vidkaFastPreviewPlayer;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exportToVideoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toggleConsoleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toggleFastModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewOnGithubToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem whereIsTheCurrentFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem opsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteAllNonlockedClipsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem linearShuffleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem associatevidkaFilesWithThisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem whereIsThisClipUsedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem whereIsTheCurrentFileToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem simpleTextClipToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rebuildAuxillaryFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem currentFrameStillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForErrorsToolStripMenuItem;
	}
}

