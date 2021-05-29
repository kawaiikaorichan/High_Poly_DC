﻿namespace SADXModManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboTextLanguage = new System.Windows.Forms.ComboBox();
            this.comboVoiceLanguage = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pauseWhenInactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.disableCDCheckCheckBox = new System.Windows.Forms.CheckBox();
            this.screenNumComboBox = new System.Windows.Forms.ComboBox();
            this.stretchFullscreenCheckBox = new System.Windows.Forms.CheckBox();
            this.forceAspectRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.windowedFullscreenCheckBox = new System.Windows.Forms.CheckBox();
            this.verticalResolution = new System.Windows.Forms.NumericUpDown();
            this.horizontalResolution = new System.Windows.Forms.NumericUpDown();
            this.buttonRefreshModList = new System.Windows.Forms.Button();
            this.modDescription = new System.Windows.Forms.Label();
            this.modListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAndPlayButton = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.configEditorButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.configureModButton = new System.Windows.Forms.Button();
            this.modBottomButton = new System.Windows.Forms.Button();
            this.modTopButton = new System.Windows.Forms.Button();
            this.buttonNewMod = new System.Windows.Forms.Button();
            this.modDownButton = new System.Windows.Forms.Button();
            this.modUpButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.codesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox_WindowMode = new System.Windows.Forms.GroupBox();
            this.checkWindowResize = new System.Windows.Forms.CheckBox();
            this.customWindowSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.maintainWindowAspectRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.windowHeight = new System.Windows.Forms.NumericUpDown();
            this.windowWidth = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Visuals = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkScaleHud = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboFmvFill = new System.Windows.Forms.ComboBox();
            this.comboFog = new System.Windows.Forms.ComboBox();
            this.comboBackgroundFill = new System.Windows.Forms.ComboBox();
            this.comboClip = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboFramerate = new System.Windows.Forms.ComboBox();
            this.forceMipmappingCheckBox = new System.Windows.Forms.CheckBox();
            this.forceTextureFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox_Display = new System.Windows.Forms.GroupBox();
            this.comboResolutionPreset = new System.Windows.Forms.ComboBox();
            this.radioWindowMode = new System.Windows.Forms.RadioButton();
            this.checkVsync = new System.Windows.Forms.CheckBox();
            this.radioFullscreen = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox_SoundVolume = new System.Windows.Forms.GroupBox();
            this.labelVoiceVol = new System.Windows.Forms.Label();
            this.labelMusicVol = new System.Windows.Forms.Label();
            this.trackBarVoiceVol = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBarMusicVol = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox_SoundConfig = new System.Windows.Forms.GroupBox();
            this.checkMusic = new System.Windows.Forms.CheckBox();
            this.checkSound = new System.Windows.Forms.CheckBox();
            this.check3DSound = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.installURLHandlerButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonCheckForUpdates = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkUpdateModsStartup = new System.Windows.Forms.CheckBox();
            this.numericUpdateFrequency = new System.Windows.Forms.NumericUpDown();
            this.comboUpdateFrequency = new System.Windows.Forms.ComboBox();
            this.checkUpdateStartup = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.consoleCheckBox = new System.Windows.Forms.CheckBox();
            this.screenCheckBox = new System.Windows.Forms.CheckBox();
            this.fileCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.modContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalResolution)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox_WindowMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth)).BeginInit();
            this.groupBox_Visuals.SuspendLayout();
            this.groupBox_Display.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox_SoundVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVoiceVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicVol)).BeginInit();
            this.groupBox_SoundConfig.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateFrequency)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.modContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 13);
            label3.TabIndex = 0;
            label3.Text = "Screen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(140, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(12, 13);
            label1.TabIndex = 7;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(219, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(12, 13);
            label2.TabIndex = 13;
            label2.Text = "x";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(this.comboTextLanguage);
            groupBox2.Controls.Add(this.comboVoiceLanguage);
            groupBox2.Controls.Add(this.label9);
            groupBox2.Controls.Add(this.label8);
            groupBox2.Controls.Add(this.pauseWhenInactiveCheckBox);
            groupBox2.Controls.Add(this.disableCDCheckCheckBox);
            groupBox2.Location = new System.Drawing.Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(390, 88);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Misc.";
            // 
            // comboTextLanguage
            // 
            this.comboTextLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTextLanguage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboTextLanguage.FormattingEnabled = true;
            this.comboTextLanguage.Items.AddRange(new object[] {
            "Japanese",
            "English",
            "French",
            "Spanish",
            "German"});
            this.comboTextLanguage.Location = new System.Drawing.Point(125, 57);
            this.comboTextLanguage.Name = "comboTextLanguage";
            this.comboTextLanguage.Size = new System.Drawing.Size(97, 21);
            this.comboTextLanguage.TabIndex = 7;
            this.toolTip.SetToolTip(this.comboTextLanguage, "Text language at startup. Loading a save file overrides this.");
            // 
            // comboVoiceLanguage
            // 
            this.comboVoiceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVoiceLanguage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboVoiceLanguage.FormattingEnabled = true;
            this.comboVoiceLanguage.Items.AddRange(new object[] {
            "Japanese",
            "English"});
            this.comboVoiceLanguage.Location = new System.Drawing.Point(11, 57);
            this.comboVoiceLanguage.Name = "comboVoiceLanguage";
            this.comboVoiceLanguage.Size = new System.Drawing.Size(98, 21);
            this.comboVoiceLanguage.TabIndex = 6;
            this.toolTip.SetToolTip(this.comboVoiceLanguage, "Voice language at startup. Loading a save file overrides this.");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Text language:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Voice language:";
            // 
            // pauseWhenInactiveCheckBox
            // 
            this.pauseWhenInactiveCheckBox.AutoSize = true;
            this.pauseWhenInactiveCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pauseWhenInactiveCheckBox.Location = new System.Drawing.Point(125, 19);
            this.pauseWhenInactiveCheckBox.Name = "pauseWhenInactiveCheckBox";
            this.pauseWhenInactiveCheckBox.Size = new System.Drawing.Size(135, 18);
            this.pauseWhenInactiveCheckBox.TabIndex = 1;
            this.pauseWhenInactiveCheckBox.Text = "Pause When Inactive";
            this.toolTip.SetToolTip(this.pauseWhenInactiveCheckBox, "Uncheck to allow the game to run in the background.");
            this.pauseWhenInactiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // disableCDCheckCheckBox
            // 
            this.disableCDCheckCheckBox.AutoSize = true;
            this.disableCDCheckCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.disableCDCheckCheckBox.Location = new System.Drawing.Point(6, 19);
            this.disableCDCheckCheckBox.Name = "disableCDCheckCheckBox";
            this.disableCDCheckCheckBox.Size = new System.Drawing.Size(119, 18);
            this.disableCDCheckCheckBox.TabIndex = 0;
            this.disableCDCheckCheckBox.Text = "Disable CD Check";
            this.toolTip.SetToolTip(this.disableCDCheckCheckBox, "Allows you to run the game without the disc.");
            this.disableCDCheckCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 49);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 13);
            label5.TabIndex = 17;
            label5.Text = "Resolution:";
            // 
            // screenNumComboBox
            // 
            this.screenNumComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screenNumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screenNumComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.screenNumComboBox.FormattingEnabled = true;
            this.screenNumComboBox.Items.AddRange(new object[] {
            "All Screens"});
            this.screenNumComboBox.Location = new System.Drawing.Point(56, 19);
            this.screenNumComboBox.Name = "screenNumComboBox";
            this.screenNumComboBox.Size = new System.Drawing.Size(315, 21);
            this.screenNumComboBox.TabIndex = 1;
            this.toolTip.SetToolTip(this.screenNumComboBox, "The screen to put the game on.");
            this.screenNumComboBox.SelectedIndexChanged += new System.EventHandler(this.screenNumComboBox_SelectedIndexChanged);
            // 
            // stretchFullscreenCheckBox
            // 
            this.stretchFullscreenCheckBox.AutoSize = true;
            this.stretchFullscreenCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stretchFullscreenCheckBox.Location = new System.Drawing.Point(104, 97);
            this.stretchFullscreenCheckBox.Name = "stretchFullscreenCheckBox";
            this.stretchFullscreenCheckBox.Size = new System.Drawing.Size(108, 18);
            this.stretchFullscreenCheckBox.TabIndex = 3;
            this.stretchFullscreenCheckBox.Text = "Scale to Screen";
            this.toolTip.SetToolTip(this.stretchFullscreenCheckBox, "Coupled with Borderless Fullscreen, you can downsample the game from resolutions " +
        "higher than your screen supports.");
            this.stretchFullscreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // forceAspectRatioCheckBox
            // 
            this.forceAspectRatioCheckBox.AutoSize = true;
            this.forceAspectRatioCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.forceAspectRatioCheckBox.Location = new System.Drawing.Point(226, 73);
            this.forceAspectRatioCheckBox.Name = "forceAspectRatioCheckBox";
            this.forceAspectRatioCheckBox.Size = new System.Drawing.Size(141, 18);
            this.forceAspectRatioCheckBox.TabIndex = 10;
            this.forceAspectRatioCheckBox.Text = "Force 4:3 Aspect Ratio";
            this.forceAspectRatioCheckBox.UseVisualStyleBackColor = true;
            this.forceAspectRatioCheckBox.CheckedChanged += new System.EventHandler(this.forceAspectRatioCheckBox_CheckedChanged);
            // 
            // windowedFullscreenCheckBox
            // 
            this.windowedFullscreenCheckBox.AutoSize = true;
            this.windowedFullscreenCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.windowedFullscreenCheckBox.Location = new System.Drawing.Point(9, 97);
            this.windowedFullscreenCheckBox.Name = "windowedFullscreenCheckBox";
            this.windowedFullscreenCheckBox.Size = new System.Drawing.Size(81, 18);
            this.windowedFullscreenCheckBox.TabIndex = 2;
            this.windowedFullscreenCheckBox.Text = "Borderless";
            this.toolTip.SetToolTip(this.windowedFullscreenCheckBox, "Enables borderless fullscreen mode.\r\nYou have to enable fullscreen mode for it to" +
        " work.");
            this.windowedFullscreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // verticalResolution
            // 
            this.verticalResolution.Location = new System.Drawing.Point(157, 47);
            this.verticalResolution.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.verticalResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.verticalResolution.Name = "verticalResolution";
            this.verticalResolution.Size = new System.Drawing.Size(62, 20);
            this.verticalResolution.TabIndex = 8;
            this.verticalResolution.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.verticalResolution.ValueChanged += new System.EventHandler(this.verticalResolution_ValueChanged);
            // 
            // horizontalResolution
            // 
            this.horizontalResolution.Location = new System.Drawing.Point(72, 47);
            this.horizontalResolution.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.horizontalResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.horizontalResolution.Name = "horizontalResolution";
            this.horizontalResolution.Size = new System.Drawing.Size(62, 20);
            this.horizontalResolution.TabIndex = 6;
            this.horizontalResolution.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.horizontalResolution.ValueChanged += new System.EventHandler(this.horizontalResolution_ValueChanged);
            // 
            // buttonRefreshModList
            // 
            this.buttonRefreshModList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefreshModList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRefreshModList.Location = new System.Drawing.Point(6, 288);
            this.buttonRefreshModList.Name = "buttonRefreshModList";
            this.buttonRefreshModList.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshModList.TabIndex = 3;
            this.buttonRefreshModList.Text = "&Refresh";
            this.buttonRefreshModList.UseVisualStyleBackColor = true;
            this.buttonRefreshModList.Click += new System.EventHandler(this.buttonRefreshModList_Click);
            // 
            // modDescription
            // 
            this.modDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modDescription.Location = new System.Drawing.Point(6, 317);
            this.modDescription.Name = "modDescription";
            this.modDescription.Size = new System.Drawing.Size(390, 60);
            this.modDescription.TabIndex = 6;
            this.modDescription.Text = "Description: No mod selected.";
            // 
            // modListView
            // 
            this.modListView.AllowDrop = true;
            this.modListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modListView.CheckBoxes = true;
            this.modListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.modListView.FullRowSelect = true;
            this.modListView.HideSelection = false;
            this.modListView.Location = new System.Drawing.Point(6, 6);
            this.modListView.Name = "modListView";
            this.modListView.Size = new System.Drawing.Size(361, 276);
            this.modListView.TabIndex = 0;
            this.modListView.UseCompatibleStateImageBehavior = false;
            this.modListView.View = System.Windows.Forms.View.Details;
            this.modListView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.modListView_ItemCheck);
            this.modListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.modListView_ItemDrag);
            this.modListView.SelectedIndexChanged += new System.EventHandler(this.modListView_SelectedIndexChanged);
            this.modListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.modListView_DragDrop);
            this.modListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.modListView_DragEnter);
            this.modListView.DragOver += new System.Windows.Forms.DragEventHandler(this.modListView_DragOver);
            this.modListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modListView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Version";
            this.columnHeader3.Width = 75;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveButton.Location = new System.Drawing.Point(88, 412);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 22);
            this.saveButton.TabIndex = 102;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAndPlayButton
            // 
            this.saveAndPlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveAndPlayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveAndPlayButton.Location = new System.Drawing.Point(4, 412);
            this.saveAndPlayButton.Name = "saveAndPlayButton";
            this.saveAndPlayButton.Size = new System.Drawing.Size(78, 22);
            this.saveAndPlayButton.TabIndex = 101;
            this.saveAndPlayButton.Text = "Save && &Play";
            this.saveAndPlayButton.UseVisualStyleBackColor = true;
            this.saveAndPlayButton.Click += new System.EventHandler(this.saveAndPlayButton_Click);
            // 
            // installButton
            // 
            this.installButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.installButton.AutoSize = true;
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.installButton.Location = new System.Drawing.Point(168, 412);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(80, 22);
            this.installButton.TabIndex = 103;
            this.installButton.Text = "Install loader";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // configEditorButton
            // 
            this.configEditorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.configEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.configEditorButton.Location = new System.Drawing.Point(276, 412);
            this.configEditorButton.Name = "configEditorButton";
            this.configEditorButton.Size = new System.Drawing.Size(128, 22);
            this.configEditorButton.TabIndex = 104;
            this.configEditorButton.Text = "&Config Editor (vanilla)";
            this.toolTip.SetToolTip(this.configEditorButton, "Edit vanilla SADX configuration.\r\nThese settings will be used by the game when th" +
        "e Mod Loader is disabled.");
            this.configEditorButton.UseVisualStyleBackColor = true;
            this.configEditorButton.Click += new System.EventHandler(this.configEditorButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.configureModButton);
            this.tabPage1.Controls.Add(this.modBottomButton);
            this.tabPage1.Controls.Add(this.modTopButton);
            this.tabPage1.Controls.Add(this.buttonNewMod);
            this.tabPage1.Controls.Add(this.buttonRefreshModList);
            this.tabPage1.Controls.Add(this.modDescription);
            this.tabPage1.Controls.Add(this.modDownButton);
            this.tabPage1.Controls.Add(this.modUpButton);
            this.tabPage1.Controls.Add(this.modListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mods";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // configureModButton
            // 
            this.configureModButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.configureModButton.Enabled = false;
            this.configureModButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.configureModButton.Location = new System.Drawing.Point(87, 288);
            this.configureModButton.Name = "configureModButton";
            this.configureModButton.Size = new System.Drawing.Size(75, 23);
            this.configureModButton.TabIndex = 9;
            this.configureModButton.Text = "Configure...";
            this.configureModButton.UseVisualStyleBackColor = true;
            this.configureModButton.Click += new System.EventHandler(this.configureModButton_Click);
            // 
            // modBottomButton
            // 
            this.modBottomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modBottomButton.AutoSize = true;
            this.modBottomButton.Enabled = false;
            this.modBottomButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modBottomButton.Location = new System.Drawing.Point(369, 114);
            this.modBottomButton.Name = "modBottomButton";
            this.modBottomButton.Size = new System.Drawing.Size(29, 29);
            this.modBottomButton.TabIndex = 8;
            this.modBottomButton.Text = "⤓";
            this.modBottomButton.UseVisualStyleBackColor = true;
            this.modBottomButton.Click += new System.EventHandler(this.modBottomButton_Click);
            // 
            // modTopButton
            // 
            this.modTopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modTopButton.AutoSize = true;
            this.modTopButton.Enabled = false;
            this.modTopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modTopButton.Location = new System.Drawing.Point(369, 6);
            this.modTopButton.Name = "modTopButton";
            this.modTopButton.Size = new System.Drawing.Size(29, 29);
            this.modTopButton.TabIndex = 7;
            this.modTopButton.Text = "⤒";
            this.modTopButton.UseVisualStyleBackColor = true;
            this.modTopButton.Click += new System.EventHandler(this.modTopButton_Click);
            // 
            // buttonNewMod
            // 
            this.buttonNewMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewMod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNewMod.Location = new System.Drawing.Point(292, 288);
            this.buttonNewMod.Name = "buttonNewMod";
            this.buttonNewMod.Size = new System.Drawing.Size(75, 23);
            this.buttonNewMod.TabIndex = 5;
            this.buttonNewMod.Text = "&New...";
            this.buttonNewMod.UseVisualStyleBackColor = true;
            this.buttonNewMod.Click += new System.EventHandler(this.buttonNewMod_Click);
            // 
            // modDownButton
            // 
            this.modDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modDownButton.AutoSize = true;
            this.modDownButton.Enabled = false;
            this.modDownButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modDownButton.Location = new System.Drawing.Point(369, 78);
            this.modDownButton.Name = "modDownButton";
            this.modDownButton.Size = new System.Drawing.Size(29, 29);
            this.modDownButton.TabIndex = 2;
            this.modDownButton.Text = "↓";
            this.modDownButton.UseVisualStyleBackColor = true;
            this.modDownButton.Click += new System.EventHandler(this.modDownButton_Click);
            // 
            // modUpButton
            // 
            this.modUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modUpButton.AutoSize = true;
            this.modUpButton.Enabled = false;
            this.modUpButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modUpButton.Location = new System.Drawing.Point(369, 42);
            this.modUpButton.Name = "modUpButton";
            this.modUpButton.Size = new System.Drawing.Size(29, 29);
            this.modUpButton.TabIndex = 1;
            this.modUpButton.Text = "↑";
            this.modUpButton.UseVisualStyleBackColor = true;
            this.modUpButton.Click += new System.EventHandler(this.modUpButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.codesCheckedListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(402, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Codes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // codesCheckedListBox
            // 
            this.codesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codesCheckedListBox.FormattingEnabled = true;
            this.codesCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.codesCheckedListBox.Name = "codesCheckedListBox";
            this.codesCheckedListBox.Size = new System.Drawing.Size(402, 380);
            this.codesCheckedListBox.TabIndex = 0;
            this.codesCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.codesCheckedListBox_ItemCheck);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.groupBox_WindowMode);
            this.tabPage3.Controls.Add(this.groupBox_Visuals);
            this.tabPage3.Controls.Add(this.groupBox_Display);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(402, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Graphics";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox_WindowMode
            // 
            this.groupBox_WindowMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_WindowMode.Controls.Add(this.checkWindowResize);
            this.groupBox_WindowMode.Controls.Add(this.customWindowSizeCheckBox);
            this.groupBox_WindowMode.Controls.Add(this.maintainWindowAspectRatioCheckBox);
            this.groupBox_WindowMode.Controls.Add(this.windowHeight);
            this.groupBox_WindowMode.Controls.Add(this.windowWidth);
            this.groupBox_WindowMode.Controls.Add(label2);
            this.groupBox_WindowMode.Location = new System.Drawing.Point(6, 133);
            this.groupBox_WindowMode.Name = "groupBox_WindowMode";
            this.groupBox_WindowMode.Size = new System.Drawing.Size(390, 75);
            this.groupBox_WindowMode.TabIndex = 3;
            this.groupBox_WindowMode.TabStop = false;
            this.groupBox_WindowMode.Text = "Window mode";
            // 
            // checkWindowResize
            // 
            this.checkWindowResize.AutoSize = true;
            this.checkWindowResize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkWindowResize.Location = new System.Drawing.Point(6, 48);
            this.checkWindowResize.Name = "checkWindowResize";
            this.checkWindowResize.Size = new System.Drawing.Size(120, 18);
            this.checkWindowResize.TabIndex = 16;
            this.checkWindowResize.Text = "Resizable Window";
            this.toolTip.SetToolTip(this.checkWindowResize, "Allows the window to be resized and dynamically adjusts resolution to match.");
            this.checkWindowResize.UseVisualStyleBackColor = true;
            // 
            // customWindowSizeCheckBox
            // 
            this.customWindowSizeCheckBox.AutoSize = true;
            this.customWindowSizeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customWindowSizeCheckBox.Location = new System.Drawing.Point(6, 20);
            this.customWindowSizeCheckBox.Name = "customWindowSizeCheckBox";
            this.customWindowSizeCheckBox.Size = new System.Drawing.Size(135, 18);
            this.customWindowSizeCheckBox.TabIndex = 11;
            this.customWindowSizeCheckBox.Text = "Custom Window Size:";
            this.toolTip.SetToolTip(this.customWindowSizeCheckBox, "Allows you to specify a fixed size for the window in windowed mode.");
            this.customWindowSizeCheckBox.UseVisualStyleBackColor = true;
            this.customWindowSizeCheckBox.CheckedChanged += new System.EventHandler(this.customWindowSizeCheckBox_CheckedChanged);
            // 
            // maintainWindowAspectRatioCheckBox
            // 
            this.maintainWindowAspectRatioCheckBox.AutoSize = true;
            this.maintainWindowAspectRatioCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.maintainWindowAspectRatioCheckBox.Location = new System.Drawing.Point(151, 48);
            this.maintainWindowAspectRatioCheckBox.Name = "maintainWindowAspectRatioCheckBox";
            this.maintainWindowAspectRatioCheckBox.Size = new System.Drawing.Size(136, 18);
            this.maintainWindowAspectRatioCheckBox.TabIndex = 15;
            this.maintainWindowAspectRatioCheckBox.Text = "Maintain Aspect Ratio";
            this.toolTip.SetToolTip(this.maintainWindowAspectRatioCheckBox, "Forces the window\'s aspect ratio to match the current custom resolution\'s.");
            this.maintainWindowAspectRatioCheckBox.UseVisualStyleBackColor = true;
            this.maintainWindowAspectRatioCheckBox.CheckedChanged += new System.EventHandler(this.maintainWindowAspectRatioCheckBox_CheckedChanged);
            // 
            // windowHeight
            // 
            this.windowHeight.Location = new System.Drawing.Point(237, 19);
            this.windowHeight.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.windowHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.windowHeight.Name = "windowHeight";
            this.windowHeight.Size = new System.Drawing.Size(62, 20);
            this.windowHeight.TabIndex = 14;
            this.windowHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.windowHeight.ValueChanged += new System.EventHandler(this.windowHeight_ValueChanged);
            // 
            // windowWidth
            // 
            this.windowWidth.Location = new System.Drawing.Point(151, 19);
            this.windowWidth.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.windowWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.windowWidth.Name = "windowWidth";
            this.windowWidth.Size = new System.Drawing.Size(62, 20);
            this.windowWidth.TabIndex = 12;
            this.windowWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // groupBox_Visuals
            // 
            this.groupBox_Visuals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Visuals.Controls.Add(this.label7);
            this.groupBox_Visuals.Controls.Add(this.checkScaleHud);
            this.groupBox_Visuals.Controls.Add(this.label6);
            this.groupBox_Visuals.Controls.Add(this.comboFmvFill);
            this.groupBox_Visuals.Controls.Add(this.comboFog);
            this.groupBox_Visuals.Controls.Add(this.comboBackgroundFill);
            this.groupBox_Visuals.Controls.Add(this.comboClip);
            this.groupBox_Visuals.Controls.Add(this.label10);
            this.groupBox_Visuals.Controls.Add(this.label11);
            this.groupBox_Visuals.Controls.Add(this.label12);
            this.groupBox_Visuals.Controls.Add(this.comboFramerate);
            this.groupBox_Visuals.Controls.Add(this.forceMipmappingCheckBox);
            this.groupBox_Visuals.Controls.Add(this.forceTextureFilterCheckBox);
            this.groupBox_Visuals.Location = new System.Drawing.Point(6, 214);
            this.groupBox_Visuals.Name = "groupBox_Visuals";
            this.groupBox_Visuals.Size = new System.Drawing.Size(390, 158);
            this.groupBox_Visuals.TabIndex = 1;
            this.groupBox_Visuals.TabStop = false;
            this.groupBox_Visuals.Text = "Visuals";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "FMV fill mode:";
            // 
            // checkScaleHud
            // 
            this.checkScaleHud.AutoSize = true;
            this.checkScaleHud.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkScaleHud.Location = new System.Drawing.Point(226, 68);
            this.checkScaleHud.Name = "checkScaleHud";
            this.checkScaleHud.Size = new System.Drawing.Size(81, 18);
            this.checkScaleHud.TabIndex = 0;
            this.checkScaleHud.Text = "UI Scaling";
            this.toolTip.SetToolTip(this.checkScaleHud, "Enable scaling for UI elements (recommended).");
            this.checkScaleHud.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Background fill mode:";
            // 
            // comboFmvFill
            // 
            this.comboFmvFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFmvFill.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboFmvFill.FormattingEnabled = true;
            this.comboFmvFill.Items.AddRange(new object[] {
            "Stretch [Default]",
            "Fit",
            "Fill"});
            this.comboFmvFill.Location = new System.Drawing.Point(128, 130);
            this.comboFmvFill.Name = "comboFmvFill";
            this.comboFmvFill.Size = new System.Drawing.Size(121, 21);
            this.comboFmvFill.TabIndex = 4;
            // 
            // comboFog
            // 
            this.comboFog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboFog.FormattingEnabled = true;
            this.comboFog.Items.AddRange(new object[] {
            "Auto",
            "Emulation"});
            this.comboFog.Location = new System.Drawing.Point(96, 71);
            this.comboFog.Name = "comboFog";
            this.comboFog.Size = new System.Drawing.Size(121, 21);
            this.comboFog.TabIndex = 11;
            this.toolTip.SetToolTip(this.comboFog, "Sets fog mode. Recommended: Auto\r\nOnly set to emulation if you have an archaic vi" +
        "deo card from\r\nbefore 2003.");
            // 
            // comboBackgroundFill
            // 
            this.comboBackgroundFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBackgroundFill.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBackgroundFill.FormattingEnabled = true;
            this.comboBackgroundFill.Items.AddRange(new object[] {
            "Stretch [Default]",
            "Fit",
            "Fill"});
            this.comboBackgroundFill.Location = new System.Drawing.Point(128, 103);
            this.comboBackgroundFill.Name = "comboBackgroundFill";
            this.comboBackgroundFill.Size = new System.Drawing.Size(121, 21);
            this.comboBackgroundFill.TabIndex = 2;
            // 
            // comboClip
            // 
            this.comboClip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClip.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboClip.FormattingEnabled = true;
            this.comboClip.Items.AddRange(new object[] {
            "High (best)",
            "Low",
            "Lowest"});
            this.comboClip.Location = new System.Drawing.Point(96, 44);
            this.comboClip.Name = "comboClip";
            this.comboClip.Size = new System.Drawing.Size(121, 21);
            this.comboClip.TabIndex = 10;
            this.toolTip.SetToolTip(this.comboClip, "Sets detail level. Recommended: High.\r\nAt lower detail level the game skips drawi" +
        "ng distant\r\nobjects, disables some effects and pauses some animations.");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Fog emulation:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Detail level:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Frame rate:";
            // 
            // comboFramerate
            // 
            this.comboFramerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFramerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboFramerate.FormattingEnabled = true;
            this.comboFramerate.Items.AddRange(new object[] {
            "60 FPS",
            "30 FPS",
            "15 FPS"});
            this.comboFramerate.Location = new System.Drawing.Point(96, 17);
            this.comboFramerate.Name = "comboFramerate";
            this.comboFramerate.Size = new System.Drawing.Size(121, 21);
            this.comboFramerate.TabIndex = 9;
            this.toolTip.SetToolTip(this.comboFramerate, "Sets the target framerate. Recommended: 60 FPS.\r\nHigher framerate is recommended " +
        "for smoother gameplay.");
            // 
            // forceMipmappingCheckBox
            // 
            this.forceMipmappingCheckBox.AutoSize = true;
            this.forceMipmappingCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.forceMipmappingCheckBox.Location = new System.Drawing.Point(226, 20);
            this.forceMipmappingCheckBox.Name = "forceMipmappingCheckBox";
            this.forceMipmappingCheckBox.Size = new System.Drawing.Size(119, 18);
            this.forceMipmappingCheckBox.TabIndex = 1;
            this.forceMipmappingCheckBox.Text = "Force Mipmapping";
            this.toolTip.SetToolTip(this.forceMipmappingCheckBox, "Generates mipmaps for all textures that don\'t have them.");
            this.forceMipmappingCheckBox.UseVisualStyleBackColor = true;
            // 
            // forceTextureFilterCheckBox
            // 
            this.forceTextureFilterCheckBox.AutoSize = true;
            this.forceTextureFilterCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.forceTextureFilterCheckBox.Location = new System.Drawing.Point(226, 44);
            this.forceTextureFilterCheckBox.Name = "forceTextureFilterCheckBox";
            this.forceTextureFilterCheckBox.Size = new System.Drawing.Size(137, 18);
            this.forceTextureFilterCheckBox.TabIndex = 0;
            this.forceTextureFilterCheckBox.Text = "Force Texture Filtering";
            this.toolTip.SetToolTip(this.forceTextureFilterCheckBox, "Smooths scaled UI textures by changing the filter method from Point to Linear.");
            this.forceTextureFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox_Display
            // 
            this.groupBox_Display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Display.Controls.Add(this.comboResolutionPreset);
            this.groupBox_Display.Controls.Add(this.radioWindowMode);
            this.groupBox_Display.Controls.Add(label5);
            this.groupBox_Display.Controls.Add(this.checkVsync);
            this.groupBox_Display.Controls.Add(this.radioFullscreen);
            this.groupBox_Display.Controls.Add(this.stretchFullscreenCheckBox);
            this.groupBox_Display.Controls.Add(label3);
            this.groupBox_Display.Controls.Add(this.screenNumComboBox);
            this.groupBox_Display.Controls.Add(this.forceAspectRatioCheckBox);
            this.groupBox_Display.Controls.Add(this.horizontalResolution);
            this.groupBox_Display.Controls.Add(this.windowedFullscreenCheckBox);
            this.groupBox_Display.Controls.Add(label1);
            this.groupBox_Display.Controls.Add(this.verticalResolution);
            this.groupBox_Display.Location = new System.Drawing.Point(6, 6);
            this.groupBox_Display.Name = "groupBox_Display";
            this.groupBox_Display.Size = new System.Drawing.Size(390, 121);
            this.groupBox_Display.TabIndex = 0;
            this.groupBox_Display.TabStop = false;
            this.groupBox_Display.Text = "Display";
            // 
            // comboResolutionPreset
            // 
            this.comboResolutionPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboResolutionPreset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboResolutionPreset.FormattingEnabled = true;
            this.comboResolutionPreset.Items.AddRange(new object[] {
            "640x480",
            "800x600",
            "1024x768",
            "1152x864",
            "1280x960",
            "1280x1024",
            "Native",
            "1/2x Native",
            "2x Native",
            "720p",
            "1080p",
            "4K"});
            this.comboResolutionPreset.Location = new System.Drawing.Point(226, 46);
            this.comboResolutionPreset.Name = "comboResolutionPreset";
            this.comboResolutionPreset.Size = new System.Drawing.Size(145, 21);
            this.comboResolutionPreset.TabIndex = 18;
            this.toolTip.SetToolTip(this.comboResolutionPreset, "Allows you to select pre-set values for the resolution.");
            this.comboResolutionPreset.SelectedIndexChanged += new System.EventHandler(this.comboResolutionPreset_SelectedIndexChanged);
            // 
            // radioWindowMode
            // 
            this.radioWindowMode.AutoSize = true;
            this.radioWindowMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioWindowMode.Location = new System.Drawing.Point(104, 73);
            this.radioWindowMode.Name = "radioWindowMode";
            this.radioWindowMode.Size = new System.Drawing.Size(99, 18);
            this.radioWindowMode.TabIndex = 1;
            this.radioWindowMode.Text = "Window mode";
            this.radioWindowMode.UseVisualStyleBackColor = true;
            // 
            // checkVsync
            // 
            this.checkVsync.AutoSize = true;
            this.checkVsync.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkVsync.Location = new System.Drawing.Point(226, 97);
            this.checkVsync.Name = "checkVsync";
            this.checkVsync.Size = new System.Drawing.Size(100, 18);
            this.checkVsync.TabIndex = 4;
            this.checkVsync.Text = "Enable V-sync";
            this.toolTip.SetToolTip(this.checkVsync, "Limit the game\'s framerate by the monitor refresh rate.");
            this.checkVsync.UseVisualStyleBackColor = true;
            // 
            // radioFullscreen
            // 
            this.radioFullscreen.AutoSize = true;
            this.radioFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioFullscreen.Location = new System.Drawing.Point(9, 73);
            this.radioFullscreen.Name = "radioFullscreen";
            this.radioFullscreen.Size = new System.Drawing.Size(79, 18);
            this.radioFullscreen.TabIndex = 0;
            this.radioFullscreen.Text = "Fullscreen";
            this.radioFullscreen.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox_SoundVolume);
            this.tabPage5.Controls.Add(this.groupBox_SoundConfig);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(402, 380);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sound";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox_SoundVolume
            // 
            this.groupBox_SoundVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_SoundVolume.Controls.Add(this.labelVoiceVol);
            this.groupBox_SoundVolume.Controls.Add(this.labelMusicVol);
            this.groupBox_SoundVolume.Controls.Add(this.trackBarVoiceVol);
            this.groupBox_SoundVolume.Controls.Add(this.label13);
            this.groupBox_SoundVolume.Controls.Add(this.trackBarMusicVol);
            this.groupBox_SoundVolume.Controls.Add(this.label14);
            this.groupBox_SoundVolume.Location = new System.Drawing.Point(6, 77);
            this.groupBox_SoundVolume.Name = "groupBox_SoundVolume";
            this.groupBox_SoundVolume.Size = new System.Drawing.Size(390, 114);
            this.groupBox_SoundVolume.TabIndex = 3;
            this.groupBox_SoundVolume.TabStop = false;
            this.groupBox_SoundVolume.Text = "Volume";
            // 
            // labelVoiceVol
            // 
            this.labelVoiceVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVoiceVol.AutoSize = true;
            this.labelVoiceVol.Location = new System.Drawing.Point(359, 67);
            this.labelVoiceVol.Name = "labelVoiceVol";
            this.labelVoiceVol.Size = new System.Drawing.Size(25, 13);
            this.labelVoiceVol.TabIndex = 7;
            this.labelVoiceVol.Text = "100";
            // 
            // labelMusicVol
            // 
            this.labelMusicVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMusicVol.AutoSize = true;
            this.labelMusicVol.Location = new System.Drawing.Point(359, 21);
            this.labelMusicVol.Name = "labelMusicVol";
            this.labelMusicVol.Size = new System.Drawing.Size(25, 13);
            this.labelMusicVol.TabIndex = 6;
            this.labelMusicVol.Text = "100";
            // 
            // trackBarVoiceVol
            // 
            this.trackBarVoiceVol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVoiceVol.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarVoiceVol.Location = new System.Drawing.Point(89, 65);
            this.trackBarVoiceVol.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarVoiceVol.Maximum = 100;
            this.trackBarVoiceVol.Name = "trackBarVoiceVol";
            this.trackBarVoiceVol.Size = new System.Drawing.Size(267, 45);
            this.trackBarVoiceVol.TabIndex = 5;
            this.trackBarVoiceVol.TickFrequency = 10;
            this.trackBarVoiceVol.Value = 100;
            this.trackBarVoiceVol.ValueChanged += new System.EventHandler(this.trackBarVoiceVol_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Music volume:";
            // 
            // trackBarMusicVol
            // 
            this.trackBarMusicVol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarMusicVol.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarMusicVol.LargeChange = 10;
            this.trackBarMusicVol.Location = new System.Drawing.Point(89, 18);
            this.trackBarMusicVol.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarMusicVol.Maximum = 100;
            this.trackBarMusicVol.Name = "trackBarMusicVol";
            this.trackBarMusicVol.Size = new System.Drawing.Size(267, 45);
            this.trackBarMusicVol.TabIndex = 4;
            this.trackBarMusicVol.TickFrequency = 10;
            this.trackBarMusicVol.Value = 100;
            this.trackBarMusicVol.ValueChanged += new System.EventHandler(this.trackBarMusicVol_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Voice volume:";
            // 
            // groupBox_SoundConfig
            // 
            this.groupBox_SoundConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_SoundConfig.Controls.Add(this.checkMusic);
            this.groupBox_SoundConfig.Controls.Add(this.checkSound);
            this.groupBox_SoundConfig.Controls.Add(this.check3DSound);
            this.groupBox_SoundConfig.Location = new System.Drawing.Point(6, 6);
            this.groupBox_SoundConfig.Name = "groupBox_SoundConfig";
            this.groupBox_SoundConfig.Size = new System.Drawing.Size(390, 65);
            this.groupBox_SoundConfig.TabIndex = 2;
            this.groupBox_SoundConfig.TabStop = false;
            this.groupBox_SoundConfig.Text = "Sound";
            // 
            // checkMusic
            // 
            this.checkMusic.AutoSize = true;
            this.checkMusic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkMusic.Location = new System.Drawing.Point(122, 42);
            this.checkMusic.Name = "checkMusic";
            this.checkMusic.Size = new System.Drawing.Size(96, 18);
            this.checkMusic.TabIndex = 2;
            this.checkMusic.Text = "Enable Music";
            this.checkMusic.UseVisualStyleBackColor = true;
            // 
            // checkSound
            // 
            this.checkSound.AutoSize = true;
            this.checkSound.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkSound.Location = new System.Drawing.Point(6, 42);
            this.checkSound.Name = "checkSound";
            this.checkSound.Size = new System.Drawing.Size(104, 18);
            this.checkSound.TabIndex = 1;
            this.checkSound.Text = "Enable Sounds";
            this.checkSound.UseVisualStyleBackColor = true;
            // 
            // check3DSound
            // 
            this.check3DSound.AutoSize = true;
            this.check3DSound.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.check3DSound.Location = new System.Drawing.Point(6, 19);
            this.check3DSound.Name = "check3DSound";
            this.check3DSound.Size = new System.Drawing.Size(116, 18);
            this.check3DSound.TabIndex = 0;
            this.check3DSound.Text = "Enable 3D Sound";
            this.toolTip.SetToolTip(this.check3DSound, "Enable or disable surround sound.");
            this.check3DSound.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.installURLHandlerButton);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(402, 380);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Options";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // installURLHandlerButton
            // 
            this.installURLHandlerButton.AutoSize = true;
            this.installURLHandlerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.installURLHandlerButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.installURLHandlerButton.Location = new System.Drawing.Point(6, 247);
            this.installURLHandlerButton.Name = "installURLHandlerButton";
            this.installURLHandlerButton.Size = new System.Drawing.Size(113, 22);
            this.installURLHandlerButton.TabIndex = 3;
            this.installURLHandlerButton.Text = "Install URL Handler";
            this.installURLHandlerButton.UseVisualStyleBackColor = true;
            this.installURLHandlerButton.Click += new System.EventHandler(this.installURLHandlerButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.buttonCheckForUpdates);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.checkUpdateModsStartup);
            this.groupBox4.Controls.Add(this.numericUpdateFrequency);
            this.groupBox4.Controls.Add(this.comboUpdateFrequency);
            this.groupBox4.Controls.Add(this.checkUpdateStartup);
            this.groupBox4.Location = new System.Drawing.Point(6, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 90);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Updates";
            // 
            // buttonCheckForUpdates
            // 
            this.buttonCheckForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCheckForUpdates.Location = new System.Drawing.Point(259, 55);
            this.buttonCheckForUpdates.Name = "buttonCheckForUpdates";
            this.buttonCheckForUpdates.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckForUpdates.TabIndex = 5;
            this.buttonCheckForUpdates.Text = "Check Now";
            this.buttonCheckForUpdates.UseVisualStyleBackColor = true;
            this.buttonCheckForUpdates.Click += new System.EventHandler(this.buttonCheckForUpdates_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Frequency:";
            // 
            // checkUpdateModsStartup
            // 
            this.checkUpdateModsStartup.AutoSize = true;
            this.checkUpdateModsStartup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkUpdateModsStartup.Location = new System.Drawing.Point(133, 19);
            this.checkUpdateModsStartup.Name = "checkUpdateModsStartup";
            this.checkUpdateModsStartup.Size = new System.Drawing.Size(141, 18);
            this.checkUpdateModsStartup.TabIndex = 1;
            this.checkUpdateModsStartup.Text = "Check mods on startup";
            this.checkUpdateModsStartup.UseVisualStyleBackColor = true;
            // 
            // numericUpdateFrequency
            // 
            this.numericUpdateFrequency.Location = new System.Drawing.Point(133, 57);
            this.numericUpdateFrequency.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpdateFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpdateFrequency.Name = "numericUpdateFrequency";
            this.numericUpdateFrequency.Size = new System.Drawing.Size(120, 20);
            this.numericUpdateFrequency.TabIndex = 4;
            this.numericUpdateFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboUpdateFrequency
            // 
            this.comboUpdateFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUpdateFrequency.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboUpdateFrequency.FormattingEnabled = true;
            this.comboUpdateFrequency.Items.AddRange(new object[] {
            "Always",
            "Hours",
            "Days",
            "Weeks"});
            this.comboUpdateFrequency.Location = new System.Drawing.Point(6, 56);
            this.comboUpdateFrequency.Name = "comboUpdateFrequency";
            this.comboUpdateFrequency.Size = new System.Drawing.Size(121, 21);
            this.comboUpdateFrequency.TabIndex = 3;
            this.comboUpdateFrequency.SelectedIndexChanged += new System.EventHandler(this.comboUpdateFrequency_SelectedIndexChanged);
            // 
            // checkUpdateStartup
            // 
            this.checkUpdateStartup.AutoSize = true;
            this.checkUpdateStartup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkUpdateStartup.Location = new System.Drawing.Point(6, 19);
            this.checkUpdateStartup.Name = "checkUpdateStartup";
            this.checkUpdateStartup.Size = new System.Drawing.Size(113, 18);
            this.checkUpdateStartup.TabIndex = 0;
            this.checkUpdateStartup.Text = "Check on startup";
            this.checkUpdateStartup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.consoleCheckBox);
            this.groupBox1.Controls.Add(this.screenCheckBox);
            this.groupBox1.Controls.Add(this.fileCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 42);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debug Messages";
            // 
            // consoleCheckBox
            // 
            this.consoleCheckBox.AutoSize = true;
            this.consoleCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.consoleCheckBox.Location = new System.Drawing.Point(6, 19);
            this.consoleCheckBox.Name = "consoleCheckBox";
            this.consoleCheckBox.Size = new System.Drawing.Size(70, 18);
            this.consoleCheckBox.TabIndex = 0;
            this.consoleCheckBox.Text = "Console";
            this.toolTip.SetToolTip(this.consoleCheckBox, "Shows a console and displays debug messages.");
            this.consoleCheckBox.UseVisualStyleBackColor = true;
            // 
            // screenCheckBox
            // 
            this.screenCheckBox.AutoSize = true;
            this.screenCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.screenCheckBox.Location = new System.Drawing.Point(76, 19);
            this.screenCheckBox.Name = "screenCheckBox";
            this.screenCheckBox.Size = new System.Drawing.Size(66, 18);
            this.screenCheckBox.TabIndex = 1;
            this.screenCheckBox.Text = "Screen";
            this.toolTip.SetToolTip(this.screenCheckBox, "Displays debug messages ingame.");
            this.screenCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileCheckBox
            // 
            this.fileCheckBox.AutoSize = true;
            this.fileCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fileCheckBox.Location = new System.Drawing.Point(142, 19);
            this.fileCheckBox.Name = "fileCheckBox";
            this.fileCheckBox.Size = new System.Drawing.Size(48, 18);
            this.fileCheckBox.TabIndex = 2;
            this.fileCheckBox.Text = "File";
            this.toolTip.SetToolTip(this.fileCheckBox, "Logs debug messages to mods/SADXModLoader.log");
            this.fileCheckBox.UseVisualStyleBackColor = true;
            // 
            // modContextMenu
            // 
            this.modContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.modContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.checkForUpdatesToolStripMenuItem,
            this.verifyToolStripMenuItem,
            this.forceUpdateToolStripMenuItem,
            this.uninstallToolStripMenuItem,
            this.toolStripMenuItem3,
            this.developerToolStripMenuItem});
            this.modContextMenu.Name = "modContextMenu";
            this.modContextMenu.Size = new System.Drawing.Size(171, 148);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openFolderToolStripMenuItem.Text = "Open folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // verifyToolStripMenuItem
            // 
            this.verifyToolStripMenuItem.Name = "verifyToolStripMenuItem";
            this.verifyToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.verifyToolStripMenuItem.Text = "Verify integrity";
            this.verifyToolStripMenuItem.Click += new System.EventHandler(this.verifyToolStripMenuItem_Click);
            // 
            // forceUpdateToolStripMenuItem
            // 
            this.forceUpdateToolStripMenuItem.Name = "forceUpdateToolStripMenuItem";
            this.forceUpdateToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.forceUpdateToolStripMenuItem.Text = "Force update";
            this.forceUpdateToolStripMenuItem.Click += new System.EventHandler(this.forceUpdateToolStripMenuItem_Click);
            // 
            // uninstallToolStripMenuItem
            // 
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.uninstallToolStripMenuItem.Text = "Uninstall";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.uninstallToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 6);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateManifestToolStripMenuItem});
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.developerToolStripMenuItem.Text = "Developer";
            // 
            // generateManifestToolStripMenuItem
            // 
            this.generateManifestToolStripMenuItem.Name = "generateManifestToolStripMenuItem";
            this.generateManifestToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.generateManifestToolStripMenuItem.Text = "Generate manifest";
            this.generateManifestToolStripMenuItem.Click += new System.EventHandler(this.generateManifestToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 462);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.configEditorButton);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.saveAndPlayButton);
            this.Controls.Add(this.saveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(424, 501);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "SADX Mod Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalResolution)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox_WindowMode.ResumeLayout(false);
            this.groupBox_WindowMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth)).EndInit();
            this.groupBox_Visuals.ResumeLayout(false);
            this.groupBox_Visuals.PerformLayout();
            this.groupBox_Display.ResumeLayout(false);
            this.groupBox_Display.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox_SoundVolume.ResumeLayout(false);
            this.groupBox_SoundVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVoiceVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicVol)).EndInit();
            this.groupBox_SoundConfig.ResumeLayout(false);
            this.groupBox_SoundConfig.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateFrequency)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.modContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView modListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAndPlayButton;
		private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.NumericUpDown horizontalResolution;
        private System.Windows.Forms.NumericUpDown verticalResolution;
        private System.Windows.Forms.Button configEditorButton;
        private System.Windows.Forms.Label modDescription;
		private System.Windows.Forms.Button buttonRefreshModList;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.CheckedListBox codesCheckedListBox;
		private System.Windows.Forms.CheckBox windowedFullscreenCheckBox;
		private System.Windows.Forms.Button buttonNewMod;
		private System.Windows.Forms.CheckBox forceAspectRatioCheckBox;
		private System.Windows.Forms.CheckBox stretchFullscreenCheckBox;
		private System.Windows.Forms.ComboBox screenNumComboBox;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.GroupBox groupBox_Display;
		private System.Windows.Forms.CheckBox forceMipmappingCheckBox;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.CheckBox forceTextureFilterCheckBox;
		private System.Windows.Forms.CheckBox customWindowSizeCheckBox;
		private System.Windows.Forms.NumericUpDown windowWidth;
		private System.Windows.Forms.NumericUpDown windowHeight;
		private System.Windows.Forms.CheckBox maintainWindowAspectRatioCheckBox;
		private System.Windows.Forms.Button modDownButton;
		private System.Windows.Forms.Button modUpButton;
		private System.Windows.Forms.CheckBox checkVsync;
		private System.Windows.Forms.CheckBox checkScaleHud;
		private System.Windows.Forms.ContextMenuStrip modContextMenu;
		private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generateManifestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox consoleCheckBox;
		private System.Windows.Forms.CheckBox screenCheckBox;
		private System.Windows.Forms.CheckBox fileCheckBox;
		private System.Windows.Forms.CheckBox pauseWhenInactiveCheckBox;
		private System.Windows.Forms.CheckBox disableCDCheckCheckBox;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkUpdateModsStartup;
		private System.Windows.Forms.NumericUpDown numericUpdateFrequency;
		private System.Windows.Forms.ComboBox comboUpdateFrequency;
		private System.Windows.Forms.CheckBox checkUpdateStartup;
		private System.Windows.Forms.GroupBox groupBox_Visuals;
		private System.Windows.Forms.Button buttonCheckForUpdates;
		private System.Windows.Forms.ToolStripMenuItem verifyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem forceUpdateToolStripMenuItem;
		private System.Windows.Forms.CheckBox checkWindowResize;
		private System.Windows.Forms.ComboBox comboResolutionPreset;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboFmvFill;
		private System.Windows.Forms.ComboBox comboBackgroundFill;
		private System.Windows.Forms.Button installURLHandlerButton;
		private System.Windows.Forms.Button modBottomButton;
		private System.Windows.Forms.Button modTopButton;
		private System.Windows.Forms.Button configureModButton;
		private System.Windows.Forms.ComboBox comboTextLanguage;
		private System.Windows.Forms.ComboBox comboVoiceLanguage;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox_WindowMode;
		private System.Windows.Forms.RadioButton radioWindowMode;
		private System.Windows.Forms.RadioButton radioFullscreen;
		private System.Windows.Forms.ComboBox comboFog;
		private System.Windows.Forms.ComboBox comboClip;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox comboFramerate;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.GroupBox groupBox_SoundVolume;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox_SoundConfig;
		private System.Windows.Forms.CheckBox checkMusic;
		private System.Windows.Forms.CheckBox checkSound;
		private System.Windows.Forms.CheckBox check3DSound;
        private System.Windows.Forms.TrackBar trackBarVoiceVol;
        private System.Windows.Forms.TrackBar trackBarMusicVol;
        private System.Windows.Forms.Label labelVoiceVol;
        private System.Windows.Forms.Label labelMusicVol;
    }
}