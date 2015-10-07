/*
*Copyright 2015 Pixedar
*
*Licensed under the Apache License, Version 2.0 (the "License");
*you may not use this file except in compliance with the License.
*You may obtain a copy of the License at
*
*http://www.apache.org/licenses/LICENSE-2.0
*
*Unless required by applicable law or agreed to in writing, software
*distributed under the License is distributed on an "AS IS" BASIS,
*WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*See the License for the specific language governing permissions and
*limitations under the License.
 */
namespace AudioRange
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage outputPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.Label chooseDeviceLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.TrackBar opacityTrackBar;
        private System.Windows.Forms.Label VoltLabel;
        private System.Windows.Forms.TextBox maxVoltageText;
        private System.Windows.Forms.Label maxoutputVoltageLabel;
        private System.Windows.Forms.Label dB;
        private System.Windows.Forms.TabPage GuiPage;
        private System.Windows.Forms.TextBox sensitivityText;
        private System.Windows.Forms.Label sensitivityLabel;
        private System.Windows.Forms.Label Om;
        private System.Windows.Forms.TextBox impemendanceText;
        private System.Windows.Forms.Label impemendanceLabel;
        private System.Windows.Forms.PictureBox currentVolume;
        private System.Windows.Forms.NotifyIcon icon;
        private System.Windows.Forms.CheckBox usb;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.CheckBox overlayKeyLabel;
        private System.Windows.Forms.Label hotkeyChange;
        private System.Windows.Forms.Label ShiftLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hotKeyNotify;
        private System.Windows.Forms.Label hotKeyConfirm;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar warningVolumeTrackBar;
        private System.Windows.Forms.Label warningVolumeLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label overlayLabel;
        private System.Windows.Forms.Label averangeVolumeLabel;
        private System.Windows.Forms.Label soundVolumeLabel;
        private System.Windows.Forms.Label warningVolumeDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox averangeCheckBox;
        private System.Windows.Forms.CheckBox volumeAsOverlayCheckBox;
        private System.Windows.Forms.CheckBox warningCheckBox;
        private System.Windows.Forms.ToolTip DecibelsToolTip;
        private System.Windows.Forms.Panel outputGeneralStatisticsGraph;
        private System.Windows.Forms.Timer StatisticsTimer;
        private System.Windows.Forms.PictureBox arrow;
        private AudioRange.DoubleBufferedPanel volumeProgressBar;
        private System.Windows.Forms.Panel borederBackground;
        private System.Windows.Forms.PictureBox exitOnBorder;
        private System.Windows.Forms.PictureBox borderIcon;
        private System.Windows.Forms.Label borderTitle;
        private System.Windows.Forms.PictureBox minimalizeOnBorder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label generalStatisticsLabel;
        private AudioRange.DoubleBufferedPanel generalStatisticsGraph;
        private AudioRange.DoubleBufferedPanel weeklyStatisticsGraph;
        private System.Windows.Forms.Panel maxVolumeStatisticsBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label maxAverangeVolumeStatisticLabel;
        private System.Windows.Forms.Label maxAverangeNoiseLabel;
        private System.Windows.Forms.Panel maxPeakNoise;
        public System.Windows.Forms.Label maxCurrentVolumeStatisticLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label weeklyStatisticsLabel;
        private System.Windows.Forms.Label maxPeakNoiseLabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label mon;
        private System.Windows.Forms.Label tue;
        private System.Windows.Forms.Label wed;
        private System.Windows.Forms.Label thu;
        private System.Windows.Forms.Label fri;
        private System.Windows.Forms.Label sat;
        private System.Windows.Forms.Label sun;
        private System.Windows.Forms.Button resetStatisticsButton;
        private System.Windows.Forms.Timer statisticsAnimation;
        private System.Windows.Forms.PictureBox maxVolume;
        private System.Windows.Forms.Label currentVolumeLabel;
        private System.Windows.Forms.Label maxVolumeLabel;
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.progressBar1 = new System.Windows.Forms.ProgressBar();
        	this.devicesComboBox = new System.Windows.Forms.ComboBox();
        	this.mainTimer = new System.Windows.Forms.Timer(this.components);
        	this.tabControl1 = new System.Windows.Forms.TabControl();
        	this.outputPage = new System.Windows.Forms.TabPage();
        	this.currentVolumeLabel = new System.Windows.Forms.Label();
        	this.maxVolumeLabel = new System.Windows.Forms.Label();
        	this.currentVolume = new System.Windows.Forms.PictureBox();
        	this.maxVolume = new System.Windows.Forms.PictureBox();
        	this.volumeProgressBar = new AudioRange.DoubleBufferedPanel();
        	this.outputGeneralStatisticsGraph = new System.Windows.Forms.Panel();
        	this.arrow = new System.Windows.Forms.PictureBox();
        	this.label17 = new System.Windows.Forms.Label();
        	this.label16 = new System.Windows.Forms.Label();
        	this.label15 = new System.Windows.Forms.Label();
        	this.label14 = new System.Windows.Forms.Label();
        	this.label13 = new System.Windows.Forms.Label();
        	this.label12 = new System.Windows.Forms.Label();
        	this.label11 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.soundVolumeLabel = new System.Windows.Forms.Label();
        	this.volumeLabel = new System.Windows.Forms.Label();
        	this.chooseDeviceLabel = new System.Windows.Forms.Label();
        	this.GuiPage = new System.Windows.Forms.TabPage();
        	this.warningCheckBox = new System.Windows.Forms.CheckBox();
        	this.volumeAsOverlayCheckBox = new System.Windows.Forms.CheckBox();
        	this.averangeCheckBox = new System.Windows.Forms.CheckBox();
        	this.warningVolumeDb = new System.Windows.Forms.Label();
        	this.hotKeyNotify = new System.Windows.Forms.Label();
        	this.overlayKeyLabel = new System.Windows.Forms.CheckBox();
        	this.hotKeyConfirm = new System.Windows.Forms.Label();
        	this.warningVolumeTrackBar = new System.Windows.Forms.TrackBar();
        	this.hotkeyChange = new System.Windows.Forms.Label();
        	this.warningVolumeLabel = new System.Windows.Forms.Label();
        	this.ShiftLabel = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.warningLabel = new System.Windows.Forms.Label();
        	this.overlayLabel = new System.Windows.Forms.Label();
        	this.averangeVolumeLabel = new System.Windows.Forms.Label();
        	this.label10 = new System.Windows.Forms.Label();
        	this.colorLabel = new System.Windows.Forms.Label();
        	this.opacityLabel = new System.Windows.Forms.Label();
        	this.intervalTextBox = new System.Windows.Forms.TextBox();
        	this.opacityTrackBar = new System.Windows.Forms.TrackBar();
        	this.redLabel = new System.Windows.Forms.Label();
        	this.intervalLabel = new System.Windows.Forms.Label();
        	this.blackLabel = new System.Windows.Forms.Label();
        	this.settingsPage = new System.Windows.Forms.TabPage();
        	this.label19 = new System.Windows.Forms.Label();
        	this.label18 = new System.Windows.Forms.Label();
        	this.usb = new System.Windows.Forms.CheckBox();
        	this.Om = new System.Windows.Forms.Label();
        	this.impemendanceText = new System.Windows.Forms.TextBox();
        	this.impemendanceLabel = new System.Windows.Forms.Label();
        	this.dB = new System.Windows.Forms.Label();
        	this.sensitivityText = new System.Windows.Forms.TextBox();
        	this.sensitivityLabel = new System.Windows.Forms.Label();
        	this.VoltLabel = new System.Windows.Forms.Label();
        	this.maxVoltageText = new System.Windows.Forms.TextBox();
        	this.maxoutputVoltageLabel = new System.Windows.Forms.Label();
        	this.aboutPage = new System.Windows.Forms.TabPage();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.icon = new System.Windows.Forms.NotifyIcon(this.components);
        	this.DecibelsToolTip = new System.Windows.Forms.ToolTip(this.components);
        	this.minimalizeOnBorder = new System.Windows.Forms.PictureBox();
        	this.exitOnBorder = new System.Windows.Forms.PictureBox();
        	this.label24 = new System.Windows.Forms.Label();
        	this.label25 = new System.Windows.Forms.Label();
        	this.label26 = new System.Windows.Forms.Label();
        	this.label27 = new System.Windows.Forms.Label();
        	this.generalStatisticsGraph = new AudioRange.DoubleBufferedPanel();
        	this.StatisticsTimer = new System.Windows.Forms.Timer(this.components);
        	this.borederBackground = new System.Windows.Forms.Panel();
        	this.borderTitle = new System.Windows.Forms.Label();
        	this.borderIcon = new System.Windows.Forms.PictureBox();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.resetStatisticsButton = new System.Windows.Forms.Button();
        	this.sun = new System.Windows.Forms.Label();
        	this.sat = new System.Windows.Forms.Label();
        	this.fri = new System.Windows.Forms.Label();
        	this.thu = new System.Windows.Forms.Label();
        	this.wed = new System.Windows.Forms.Label();
        	this.tue = new System.Windows.Forms.Label();
        	this.mon = new System.Windows.Forms.Label();
        	this.weeklyStatisticsLabel = new System.Windows.Forms.Label();
        	this.maxPeakNoiseLabel = new System.Windows.Forms.Label();
        	this.maxPeakNoise = new System.Windows.Forms.Panel();
        	this.maxCurrentVolumeStatisticLabel = new System.Windows.Forms.Label();
        	this.pictureBox3 = new System.Windows.Forms.PictureBox();
        	this.maxAverangeNoiseLabel = new System.Windows.Forms.Label();
        	this.maxVolumeStatisticsBar = new System.Windows.Forms.Panel();
        	this.maxAverangeVolumeStatisticLabel = new System.Windows.Forms.Label();
        	this.pictureBox2 = new System.Windows.Forms.PictureBox();
        	this.weeklyStatisticsGraph = new AudioRange.DoubleBufferedPanel();
        	this.generalStatisticsLabel = new System.Windows.Forms.Label();
        	this.statisticsAnimation = new System.Windows.Forms.Timer(this.components);
        	this.tabControl1.SuspendLayout();
        	this.outputPage.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.currentVolume)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.maxVolume)).BeginInit();
        	this.outputGeneralStatisticsGraph.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
        	this.GuiPage.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.warningVolumeTrackBar)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
        	this.settingsPage.SuspendLayout();
        	this.aboutPage.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.minimalizeOnBorder)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.exitOnBorder)).BeginInit();
        	this.borederBackground.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.borderIcon)).BeginInit();
        	this.panel2.SuspendLayout();
        	this.maxPeakNoise.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
        	this.maxVolumeStatisticsBar.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// progressBar1
        	// 
        	this.progressBar1.ForeColor = System.Drawing.Color.Chartreuse;
        	this.progressBar1.Location = new System.Drawing.Point(7, 98);
        	this.progressBar1.Name = "progressBar1";
        	this.progressBar1.Size = new System.Drawing.Size(258, 10);
        	this.progressBar1.TabIndex = 0;
        	this.progressBar1.Visible = false;
        	// 
        	// devicesComboBox
        	// 
        	this.devicesComboBox.BackColor = System.Drawing.SystemColors.Window;
        	this.devicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.devicesComboBox.FormattingEnabled = true;
        	this.devicesComboBox.Location = new System.Drawing.Point(6, 35);
        	this.devicesComboBox.Name = "devicesComboBox";
        	this.devicesComboBox.Size = new System.Drawing.Size(258, 24);
        	this.devicesComboBox.TabIndex = 1;
        	// 
        	// mainTimer
        	// 
        	this.mainTimer.Enabled = true;
        	this.mainTimer.Interval = 10;
        	this.mainTimer.Tick += new System.EventHandler(this.MainTimerTick);
        	// 
        	// tabControl1
        	// 
        	this.tabControl1.Controls.Add(this.outputPage);
        	this.tabControl1.Controls.Add(this.GuiPage);
        	this.tabControl1.Controls.Add(this.settingsPage);
        	this.tabControl1.Controls.Add(this.aboutPage);
        	this.tabControl1.Location = new System.Drawing.Point(0, 33);
        	this.tabControl1.Name = "tabControl1";
        	this.tabControl1.SelectedIndex = 0;
        	this.tabControl1.Size = new System.Drawing.Size(287, 310);
        	this.tabControl1.TabIndex = 3;
        	// 
        	// outputPage
        	// 
        	this.outputPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        	this.outputPage.Controls.Add(this.currentVolumeLabel);
        	this.outputPage.Controls.Add(this.maxVolumeLabel);
        	this.outputPage.Controls.Add(this.currentVolume);
        	this.outputPage.Controls.Add(this.maxVolume);
        	this.outputPage.Controls.Add(this.volumeProgressBar);
        	this.outputPage.Controls.Add(this.outputGeneralStatisticsGraph);
        	this.outputPage.Controls.Add(this.label17);
        	this.outputPage.Controls.Add(this.label16);
        	this.outputPage.Controls.Add(this.label15);
        	this.outputPage.Controls.Add(this.label14);
        	this.outputPage.Controls.Add(this.label13);
        	this.outputPage.Controls.Add(this.label12);
        	this.outputPage.Controls.Add(this.label11);
        	this.outputPage.Controls.Add(this.label1);
        	this.outputPage.Controls.Add(this.soundVolumeLabel);
        	this.outputPage.Controls.Add(this.volumeLabel);
        	this.outputPage.Controls.Add(this.chooseDeviceLabel);
        	this.outputPage.Controls.Add(this.devicesComboBox);
        	this.outputPage.Controls.Add(this.progressBar1);
        	this.outputPage.Location = new System.Drawing.Point(4, 25);
        	this.outputPage.Name = "outputPage";
        	this.outputPage.Padding = new System.Windows.Forms.Padding(3);
        	this.outputPage.Size = new System.Drawing.Size(279, 281);
        	this.outputPage.TabIndex = 0;
        	this.outputPage.Text = "Output";
        	this.outputPage.UseVisualStyleBackColor = true;
        	// 
        	// currentVolumeLabel
        	// 
        	this.currentVolumeLabel.Location = new System.Drawing.Point(139, 129);
        	this.currentVolumeLabel.Name = "currentVolumeLabel";
        	this.currentVolumeLabel.Size = new System.Drawing.Size(103, 17);
        	this.currentVolumeLabel.TabIndex = 27;
        	this.currentVolumeLabel.Text = "current volume";
        	// 
        	// maxVolumeLabel
        	// 
        	this.maxVolumeLabel.Location = new System.Drawing.Point(21, 129);
        	this.maxVolumeLabel.Name = "maxVolumeLabel";
        	this.maxVolumeLabel.Size = new System.Drawing.Size(85, 17);
        	this.maxVolumeLabel.TabIndex = 26;
        	this.maxVolumeLabel.Text = "max volume";
        	// 
        	// currentVolume
        	// 
        	this.currentVolume.Image = ((System.Drawing.Image)(resources.GetObject("currentVolume.Image")));
        	this.currentVolume.Location = new System.Drawing.Point(247, 129);
        	this.currentVolume.Name = "currentVolume";
        	this.currentVolume.Size = new System.Drawing.Size(15, 15);
        	this.currentVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        	this.currentVolume.TabIndex = 25;
        	this.currentVolume.TabStop = false;
        	this.currentVolume.Click += new System.EventHandler(this.CurrentVolumeClick);
        	// 
        	// maxVolume
        	// 
        	this.maxVolume.Image = ((System.Drawing.Image)(resources.GetObject("maxVolume.Image")));
        	this.maxVolume.Location = new System.Drawing.Point(0, 129);
        	this.maxVolume.Name = "maxVolume";
        	this.maxVolume.Size = new System.Drawing.Size(15, 15);
        	this.maxVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        	this.maxVolume.TabIndex = 1;
        	this.maxVolume.TabStop = false;
        	this.maxVolume.Click += new System.EventHandler(this.MaxVolumeClick);
        	// 
        	// volumeProgressBar
        	// 
        	this.volumeProgressBar.BackColor = System.Drawing.SystemColors.Control;
        	this.volumeProgressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.volumeProgressBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        	this.volumeProgressBar.Location = new System.Drawing.Point(7, 98);
        	this.volumeProgressBar.Name = "volumeProgressBar";
        	this.volumeProgressBar.Size = new System.Drawing.Size(258, 10);
        	this.volumeProgressBar.TabIndex = 24;
        	this.volumeProgressBar.Paint += new System.Windows.Forms.PaintEventHandler(this.VolumeProgressBarPaint);
        	// 
        	// outputGeneralStatisticsGraph
        	// 
        	this.outputGeneralStatisticsGraph.Controls.Add(this.arrow);
        	this.outputGeneralStatisticsGraph.Location = new System.Drawing.Point(6, 160);
        	this.outputGeneralStatisticsGraph.Name = "outputGeneralStatisticsGraph";
        	this.outputGeneralStatisticsGraph.Size = new System.Drawing.Size(259, 88);
        	this.outputGeneralStatisticsGraph.TabIndex = 23;
        	this.outputGeneralStatisticsGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.OutputGeneralStatisticsGraphPaint);
        	this.outputGeneralStatisticsGraph.MouseEnter += new System.EventHandler(this.OutputGeneralStatisticsGraphMouseEnter);
        	this.outputGeneralStatisticsGraph.MouseLeave += new System.EventHandler(this.OutputGeneralStatisticsGraphMouseLeave);
        	// 
        	// arrow
        	// 
        	this.arrow.Image = ((System.Drawing.Image)(resources.GetObject("arrow.Image")));
        	this.arrow.Location = new System.Drawing.Point(222, 16);
        	this.arrow.Name = "arrow";
        	this.arrow.Size = new System.Drawing.Size(34, 45);
        	this.arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.arrow.TabIndex = 0;
        	this.arrow.TabStop = false;
        	this.arrow.Visible = false;
        	this.arrow.Click += new System.EventHandler(this.ArrowClick);
        	this.arrow.MouseEnter += new System.EventHandler(this.ArrowMouseEnter);
        	this.arrow.MouseLeave += new System.EventHandler(this.ArrowMouseLeave);
        	// 
        	// label17
        	// 
        	this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label17.Location = new System.Drawing.Point(202, 265);
        	this.label17.Name = "label17";
        	this.label17.Size = new System.Drawing.Size(40, 13);
        	this.label17.TabIndex = 22;
        	this.label17.Text = ">100db";
        	this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// label16
        	// 
        	this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label16.Location = new System.Drawing.Point(131, 265);
        	this.label16.Name = "label16";
        	this.label16.Size = new System.Drawing.Size(54, 10);
        	this.label16.TabIndex = 21;
        	this.label16.Text = "70-100db";
        	this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// label15
        	// 
        	this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label15.Location = new System.Drawing.Point(65, 265);
        	this.label15.Name = "label15";
        	this.label15.Size = new System.Drawing.Size(44, 13);
        	this.label15.TabIndex = 20;
        	this.label15.Text = "40-70db";
        	this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// label14
        	// 
        	this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label14.Location = new System.Drawing.Point(2, 265);
        	this.label14.Name = "label14";
        	this.label14.Size = new System.Drawing.Size(40, 13);
        	this.label14.TabIndex = 19;
        	this.label14.Text = "0-40db";
        	this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// label13
        	// 
        	this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label13.ForeColor = System.Drawing.Color.DarkRed;
        	this.label13.Location = new System.Drawing.Point(195, 248);
        	this.label13.Name = "label13";
        	this.label13.Size = new System.Drawing.Size(55, 17);
        	this.label13.TabIndex = 18;
        	this.label13.Text = "DANGER";
        	this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.DecibelsToolTip.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
        	// 
        	// label12
        	// 
        	this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label12.ForeColor = System.Drawing.Color.Goldenrod;
        	this.label12.Location = new System.Drawing.Point(120, 248);
        	this.label12.Name = "label12";
        	this.label12.Size = new System.Drawing.Size(72, 17);
        	this.label12.TabIndex = 17;
        	this.label12.Text = "VERY LOUD";
        	this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.DecibelsToolTip.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
        	// 
        	// label11
        	// 
        	this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label11.ForeColor = System.Drawing.Color.Gold;
        	this.label11.Location = new System.Drawing.Point(52, 248);
        	this.label11.Name = "label11";
        	this.label11.Size = new System.Drawing.Size(72, 17);
        	this.label11.TabIndex = 16;
        	this.label11.Text = "MODERATE";
        	this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.DecibelsToolTip.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
        	// 
        	// label1
        	// 
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label1.ForeColor = System.Drawing.Color.SeaGreen;
        	this.label1.Location = new System.Drawing.Point(0, 248);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(46, 17);
        	this.label1.TabIndex = 15;
        	this.label1.Text = "FAINT";
        	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.DecibelsToolTip.SetToolTip(this.label1, "Longer exposure to average noise of 30-40 db,does not cause hearing loss.\r\nExampl" +
		"es:\r\n- a pin dropping 10Db,\r\n- ticking watch 20Db\r\n- whisper 30Db\r\n\r\n");
        	// 
        	// soundVolumeLabel
        	// 
        	this.soundVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.soundVolumeLabel.Location = new System.Drawing.Point(80, 72);
        	this.soundVolumeLabel.Name = "soundVolumeLabel";
        	this.soundVolumeLabel.Size = new System.Drawing.Size(122, 23);
        	this.soundVolumeLabel.TabIndex = 13;
        	this.soundVolumeLabel.Text = "Sound volume";
        	this.soundVolumeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// volumeLabel
        	// 
        	this.volumeLabel.Location = new System.Drawing.Point(39, 111);
        	this.volumeLabel.Name = "volumeLabel";
        	this.volumeLabel.Size = new System.Drawing.Size(189, 23);
        	this.volumeLabel.TabIndex = 12;
        	this.volumeLabel.Text = "0 Db";
        	this.volumeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// chooseDeviceLabel
        	// 
        	this.chooseDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.chooseDeviceLabel.Location = new System.Drawing.Point(65, 9);
        	this.chooseDeviceLabel.Name = "chooseDeviceLabel";
        	this.chooseDeviceLabel.Size = new System.Drawing.Size(142, 23);
        	this.chooseDeviceLabel.TabIndex = 4;
        	this.chooseDeviceLabel.Text = "Choose device";
        	this.chooseDeviceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// GuiPage
        	// 
        	this.GuiPage.AutoScrollMargin = new System.Drawing.Size(0, 100);
        	this.GuiPage.Controls.Add(this.warningCheckBox);
        	this.GuiPage.Controls.Add(this.volumeAsOverlayCheckBox);
        	this.GuiPage.Controls.Add(this.averangeCheckBox);
        	this.GuiPage.Controls.Add(this.warningVolumeDb);
        	this.GuiPage.Controls.Add(this.hotKeyNotify);
        	this.GuiPage.Controls.Add(this.overlayKeyLabel);
        	this.GuiPage.Controls.Add(this.hotKeyConfirm);
        	this.GuiPage.Controls.Add(this.warningVolumeTrackBar);
        	this.GuiPage.Controls.Add(this.hotkeyChange);
        	this.GuiPage.Controls.Add(this.warningVolumeLabel);
        	this.GuiPage.Controls.Add(this.ShiftLabel);
        	this.GuiPage.Controls.Add(this.label3);
        	this.GuiPage.Controls.Add(this.warningLabel);
        	this.GuiPage.Controls.Add(this.overlayLabel);
        	this.GuiPage.Controls.Add(this.averangeVolumeLabel);
        	this.GuiPage.Controls.Add(this.label10);
        	this.GuiPage.Controls.Add(this.colorLabel);
        	this.GuiPage.Controls.Add(this.opacityLabel);
        	this.GuiPage.Controls.Add(this.intervalTextBox);
        	this.GuiPage.Controls.Add(this.opacityTrackBar);
        	this.GuiPage.Controls.Add(this.redLabel);
        	this.GuiPage.Controls.Add(this.intervalLabel);
        	this.GuiPage.Controls.Add(this.blackLabel);
        	this.GuiPage.Location = new System.Drawing.Point(4, 25);
        	this.GuiPage.Name = "GuiPage";
        	this.GuiPage.Padding = new System.Windows.Forms.Padding(3);
        	this.GuiPage.Size = new System.Drawing.Size(279, 281);
        	this.GuiPage.TabIndex = 3;
        	this.GuiPage.Text = "  GUI";
        	this.GuiPage.UseVisualStyleBackColor = true;
        	// 
        	// warningCheckBox
        	// 
        	this.warningCheckBox.Location = new System.Drawing.Point(0, 220);
        	this.warningCheckBox.Name = "warningCheckBox";
        	this.warningCheckBox.Size = new System.Drawing.Size(162, 24);
        	this.warningCheckBox.TabIndex = 26;
        	this.warningCheckBox.Text = "enable/disable";
        	this.warningCheckBox.UseVisualStyleBackColor = true;
        	this.warningCheckBox.Click += new System.EventHandler(this.WarningCheckBoxClick);
        	// 
        	// volumeAsOverlayCheckBox
        	// 
        	this.volumeAsOverlayCheckBox.Location = new System.Drawing.Point(0, 100);
        	this.volumeAsOverlayCheckBox.Name = "volumeAsOverlayCheckBox";
        	this.volumeAsOverlayCheckBox.Size = new System.Drawing.Size(162, 24);
        	this.volumeAsOverlayCheckBox.TabIndex = 25;
        	this.volumeAsOverlayCheckBox.Text = "enable/disable";
        	this.volumeAsOverlayCheckBox.UseVisualStyleBackColor = true;
        	this.volumeAsOverlayCheckBox.Click += new System.EventHandler(this.VolumeAsOverlayCheckBoxClick);
        	// 
        	// averangeCheckBox
        	// 
        	this.averangeCheckBox.Location = new System.Drawing.Point(0, 27);
        	this.averangeCheckBox.Name = "averangeCheckBox";
        	this.averangeCheckBox.Size = new System.Drawing.Size(176, 24);
        	this.averangeCheckBox.TabIndex = 24;
        	this.averangeCheckBox.Text = "enable/disable";
        	this.averangeCheckBox.UseVisualStyleBackColor = true;
        	this.averangeCheckBox.Click += new System.EventHandler(this.AverangeCheckBoxClick);
        	// 
        	// warningVolumeDb
        	// 
        	this.warningVolumeDb.Location = new System.Drawing.Point(231, 246);
        	this.warningVolumeDb.Name = "warningVolumeDb";
        	this.warningVolumeDb.Size = new System.Drawing.Size(42, 23);
        	this.warningVolumeDb.TabIndex = 23;
        	this.warningVolumeDb.Text = "0 Db";
        	// 
        	// hotKeyNotify
        	// 
        	this.hotKeyNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.hotKeyNotify.Location = new System.Drawing.Point(179, 152);
        	this.hotKeyNotify.Name = "hotKeyNotify";
        	this.hotKeyNotify.Size = new System.Drawing.Size(77, 13);
        	this.hotKeyNotify.TabIndex = 16;
        	this.hotKeyNotify.Text = "click to change";
        	this.hotKeyNotify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	this.hotKeyNotify.Visible = false;
        	// 
        	// overlayKeyLabel
        	// 
        	this.overlayKeyLabel.Location = new System.Drawing.Point(0, 125);
        	this.overlayKeyLabel.Name = "overlayKeyLabel";
        	this.overlayKeyLabel.Size = new System.Drawing.Size(138, 24);
        	this.overlayKeyLabel.TabIndex = 12;
        	this.overlayKeyLabel.Text = "overlay hot key:";
        	this.overlayKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
        	this.overlayKeyLabel.UseVisualStyleBackColor = true;
        	this.overlayKeyLabel.CheckedChanged += new System.EventHandler(this.OverlayKeyLabelCheckedChanged);
        	// 
        	// hotKeyConfirm
        	// 
        	this.hotKeyConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.hotKeyConfirm.Location = new System.Drawing.Point(179, 152);
        	this.hotKeyConfirm.Name = "hotKeyConfirm";
        	this.hotKeyConfirm.Size = new System.Drawing.Size(77, 13);
        	this.hotKeyConfirm.TabIndex = 17;
        	this.hotKeyConfirm.Text = "click to confirm";
        	this.hotKeyConfirm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	this.hotKeyConfirm.Visible = false;
        	// 
        	// warningVolumeTrackBar
        	// 
        	this.warningVolumeTrackBar.AutoSize = false;
        	this.warningVolumeTrackBar.BackColor = System.Drawing.SystemColors.Window;
        	this.warningVolumeTrackBar.Location = new System.Drawing.Point(54, 246);
        	this.warningVolumeTrackBar.Maximum = 100;
        	this.warningVolumeTrackBar.Name = "warningVolumeTrackBar";
        	this.warningVolumeTrackBar.Size = new System.Drawing.Size(180, 24);
        	this.warningVolumeTrackBar.TabIndex = 22;
        	this.warningVolumeTrackBar.TickFrequency = 0;
        	this.warningVolumeTrackBar.Scroll += new System.EventHandler(this.WarningVolumeTrackBarScroll);
        	// 
        	// hotkeyChange
        	// 
        	this.hotkeyChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.hotkeyChange.Enabled = false;
        	this.hotkeyChange.Location = new System.Drawing.Point(205, 126);
        	this.hotkeyChange.Name = "hotkeyChange";
        	this.hotkeyChange.Size = new System.Drawing.Size(21, 21);
        	this.hotkeyChange.TabIndex = 13;
        	this.hotkeyChange.Click += new System.EventHandler(this.HotkeyChangeClick);
        	// 
        	// warningVolumeLabel
        	// 
        	this.warningVolumeLabel.Location = new System.Drawing.Point(0, 247);
        	this.warningVolumeLabel.Name = "warningVolumeLabel";
        	this.warningVolumeLabel.Size = new System.Drawing.Size(62, 23);
        	this.warningVolumeLabel.TabIndex = 21;
        	this.warningVolumeLabel.Text = "volume";
        	// 
        	// ShiftLabel
        	// 
        	this.ShiftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.ShiftLabel.Enabled = false;
        	this.ShiftLabel.Location = new System.Drawing.Point(144, 124);
        	this.ShiftLabel.Name = "ShiftLabel";
        	this.ShiftLabel.Size = new System.Drawing.Size(50, 23);
        	this.ShiftLabel.TabIndex = 14;
        	this.ShiftLabel.Text = "Shift ";
        	this.ShiftLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// label3
        	// 
        	this.label3.Enabled = false;
        	this.label3.Location = new System.Drawing.Point(193, 125);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(11, 23);
        	this.label3.TabIndex = 15;
        	this.label3.Text = "+";
        	// 
        	// warningLabel
        	// 
        	this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.warningLabel.Location = new System.Drawing.Point(36, 203);
        	this.warningLabel.Name = "warningLabel";
        	this.warningLabel.Size = new System.Drawing.Size(189, 23);
        	this.warningLabel.TabIndex = 19;
        	this.warningLabel.Text = "Warning";
        	this.warningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// overlayLabel
        	// 
        	this.overlayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.overlayLabel.Location = new System.Drawing.Point(36, 83);
        	this.overlayLabel.Name = "overlayLabel";
        	this.overlayLabel.Size = new System.Drawing.Size(189, 23);
        	this.overlayLabel.TabIndex = 18;
        	this.overlayLabel.Text = "Volume as overlay";
        	this.overlayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// averangeVolumeLabel
        	// 
        	this.averangeVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.averangeVolumeLabel.Location = new System.Drawing.Point(65, 3);
        	this.averangeVolumeLabel.Name = "averangeVolumeLabel";
        	this.averangeVolumeLabel.Size = new System.Drawing.Size(146, 23);
        	this.averangeVolumeLabel.TabIndex = 17;
        	this.averangeVolumeLabel.Text = "Averange volume";
        	this.averangeVolumeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// label10
        	// 
        	this.label10.Location = new System.Drawing.Point(88, 152);
        	this.label10.Name = "label10";
        	this.label10.Size = new System.Drawing.Size(10, 23);
        	this.label10.TabIndex = 16;
        	this.label10.Text = "/";
        	// 
        	// colorLabel
        	// 
        	this.colorLabel.Location = new System.Drawing.Point(0, 152);
        	this.colorLabel.Name = "colorLabel";
        	this.colorLabel.Size = new System.Drawing.Size(48, 23);
        	this.colorLabel.TabIndex = 13;
        	this.colorLabel.Text = "color:";
        	// 
        	// opacityLabel
        	// 
        	this.opacityLabel.Location = new System.Drawing.Point(0, 175);
        	this.opacityLabel.Name = "opacityLabel";
        	this.opacityLabel.Size = new System.Drawing.Size(62, 23);
        	this.opacityLabel.TabIndex = 11;
        	this.opacityLabel.Text = "opacity";
        	// 
        	// intervalTextBox
        	// 
        	this.intervalTextBox.CausesValidation = false;
        	this.intervalTextBox.Location = new System.Drawing.Point(114, 54);
        	this.intervalTextBox.MaxLength = 7;
        	this.intervalTextBox.Name = "intervalTextBox";
        	this.intervalTextBox.Size = new System.Drawing.Size(65, 22);
        	this.intervalTextBox.TabIndex = 8;
        	this.intervalTextBox.TextChanged += new System.EventHandler(this.IntervalTextBoxTextChanged);
        	// 
        	// opacityTrackBar
        	// 
        	this.opacityTrackBar.AutoSize = false;
        	this.opacityTrackBar.BackColor = System.Drawing.SystemColors.Window;
        	this.opacityTrackBar.Location = new System.Drawing.Point(54, 175);
        	this.opacityTrackBar.Maximum = 100;
        	this.opacityTrackBar.Name = "opacityTrackBar";
        	this.opacityTrackBar.Size = new System.Drawing.Size(180, 24);
        	this.opacityTrackBar.TabIndex = 10;
        	this.opacityTrackBar.TickFrequency = 0;
        	this.opacityTrackBar.Value = 50;
        	this.opacityTrackBar.Scroll += new System.EventHandler(this.OpacityTrackBarScroll);
        	// 
        	// redLabel
        	// 
        	this.redLabel.Location = new System.Drawing.Point(101, 152);
        	this.redLabel.Name = "redLabel";
        	this.redLabel.Size = new System.Drawing.Size(45, 23);
        	this.redLabel.TabIndex = 15;
        	this.redLabel.Text = "red";
        	this.redLabel.Click += new System.EventHandler(this.RedLabelClick);
        	// 
        	// intervalLabel
        	// 
        	this.intervalLabel.Location = new System.Drawing.Point(0, 54);
        	this.intervalLabel.Name = "intervalLabel";
        	this.intervalLabel.Size = new System.Drawing.Size(121, 23);
        	this.intervalLabel.TabIndex = 5;
        	this.intervalLabel.Text = "interval(n*10ms):";
        	// 
        	// blackLabel
        	// 
        	this.blackLabel.Location = new System.Drawing.Point(45, 152);
        	this.blackLabel.Name = "blackLabel";
        	this.blackLabel.Size = new System.Drawing.Size(45, 23);
        	this.blackLabel.TabIndex = 14;
        	this.blackLabel.Text = "black";
        	this.blackLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
        	this.blackLabel.Click += new System.EventHandler(this.BlackLabelClick);
        	// 
        	// settingsPage
        	// 
        	this.settingsPage.Controls.Add(this.label19);
        	this.settingsPage.Controls.Add(this.label18);
        	this.settingsPage.Controls.Add(this.usb);
        	this.settingsPage.Controls.Add(this.Om);
        	this.settingsPage.Controls.Add(this.impemendanceText);
        	this.settingsPage.Controls.Add(this.impemendanceLabel);
        	this.settingsPage.Controls.Add(this.dB);
        	this.settingsPage.Controls.Add(this.sensitivityText);
        	this.settingsPage.Controls.Add(this.sensitivityLabel);
        	this.settingsPage.Controls.Add(this.VoltLabel);
        	this.settingsPage.Controls.Add(this.maxVoltageText);
        	this.settingsPage.Controls.Add(this.maxoutputVoltageLabel);
        	this.settingsPage.Location = new System.Drawing.Point(4, 25);
        	this.settingsPage.Name = "settingsPage";
        	this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
        	this.settingsPage.Size = new System.Drawing.Size(279, 281);
        	this.settingsPage.TabIndex = 1;
        	this.settingsPage.Text = "Settings";
        	this.settingsPage.UseVisualStyleBackColor = true;
        	// 
        	// label19
        	// 
        	this.label19.Enabled = false;
        	this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label19.Location = new System.Drawing.Point(0, 218);
        	this.label19.Name = "label19";
        	this.label19.Size = new System.Drawing.Size(275, 52);
        	this.label19.TabIndex = 21;
        	this.label19.Text = " You can check these informations in your headphones specyfication.";
        	this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// label18
        	// 
        	this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label18.Location = new System.Drawing.Point(33, 25);
        	this.label18.Name = "label18";
        	this.label18.Size = new System.Drawing.Size(209, 23);
        	this.label18.TabIndex = 20;
        	this.label18.Text = "Headphones settings";
        	this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// usb
        	// 
        	this.usb.Checked = true;
        	this.usb.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.usb.Location = new System.Drawing.Point(1, 155);
        	this.usb.Name = "usb";
        	this.usb.Size = new System.Drawing.Size(159, 24);
        	this.usb.TabIndex = 11;
        	this.usb.Text = "usb headphones";
        	this.usb.UseVisualStyleBackColor = true;
        	this.usb.CheckedChanged += new System.EventHandler(this.UsbCheckedChanged);
        	// 
        	// Om
        	// 
        	this.Om.Location = new System.Drawing.Point(224, 129);
        	this.Om.Name = "Om";
        	this.Om.Size = new System.Drawing.Size(51, 23);
        	this.Om.TabIndex = 8;
        	this.Om.Text = "(Ohm)";
        	// 
        	// impemendanceText
        	// 
        	this.impemendanceText.Location = new System.Drawing.Point(186, 126);
        	this.impemendanceText.MaxLength = 3;
        	this.impemendanceText.Name = "impemendanceText";
        	this.impemendanceText.Size = new System.Drawing.Size(32, 22);
        	this.impemendanceText.TabIndex = 7;
        	this.impemendanceText.Text = "32";
        	this.impemendanceText.TextChanged += new System.EventHandler(this.ImpemendanceTextTextChanged);
        	// 
        	// impemendanceLabel
        	// 
        	this.impemendanceLabel.Location = new System.Drawing.Point(1, 129);
        	this.impemendanceLabel.Name = "impemendanceLabel";
        	this.impemendanceLabel.Size = new System.Drawing.Size(188, 23);
        	this.impemendanceLabel.TabIndex = 6;
        	this.impemendanceLabel.Text = "Headphone impemendance:";
        	// 
        	// dB
        	// 
        	this.dB.Location = new System.Drawing.Point(195, 97);
        	this.dB.Name = "dB";
        	this.dB.Size = new System.Drawing.Size(38, 23);
        	this.dB.TabIndex = 5;
        	this.dB.Text = "(Db)";
        	// 
        	// sensitivityText
        	// 
        	this.sensitivityText.Location = new System.Drawing.Point(157, 94);
        	this.sensitivityText.MaxLength = 3;
        	this.sensitivityText.Name = "sensitivityText";
        	this.sensitivityText.Size = new System.Drawing.Size(32, 22);
        	this.sensitivityText.TabIndex = 7;
        	this.sensitivityText.Text = "112";
        	this.sensitivityText.TextChanged += new System.EventHandler(this.SensitivityTextTextChanged);
        	// 
        	// sensitivityLabel
        	// 
        	this.sensitivityLabel.Location = new System.Drawing.Point(1, 94);
        	this.sensitivityLabel.Name = "sensitivityLabel";
        	this.sensitivityLabel.Size = new System.Drawing.Size(188, 23);
        	this.sensitivityLabel.TabIndex = 3;
        	this.sensitivityLabel.Text = "Headphone sensitivity:";
        	// 
        	// VoltLabel
        	// 
        	this.VoltLabel.Location = new System.Drawing.Point(248, 58);
        	this.VoltLabel.Name = "VoltLabel";
        	this.VoltLabel.Size = new System.Drawing.Size(27, 23);
        	this.VoltLabel.TabIndex = 2;
        	this.VoltLabel.Text = "(V)";
        	// 
        	// maxVoltageText
        	// 
        	this.maxVoltageText.ForeColor = System.Drawing.SystemColors.WindowText;
        	this.maxVoltageText.Location = new System.Drawing.Point(210, 58);
        	this.maxVoltageText.MaxLength = 4;
        	this.maxVoltageText.Name = "maxVoltageText";
        	this.maxVoltageText.Size = new System.Drawing.Size(32, 22);
        	this.maxVoltageText.TabIndex = 1;
        	this.maxVoltageText.Text = "1,4";
        	this.maxVoltageText.TextChanged += new System.EventHandler(this.MaxVoltageTextTextChanged);
        	// 
        	// maxoutputVoltageLabel
        	// 
        	this.maxoutputVoltageLabel.Location = new System.Drawing.Point(1, 58);
        	this.maxoutputVoltageLabel.Name = "maxoutputVoltageLabel";
        	this.maxoutputVoltageLabel.Size = new System.Drawing.Size(241, 23);
        	this.maxoutputVoltageLabel.TabIndex = 0;
        	this.maxoutputVoltageLabel.Text = "Max sound card output voltage:";
        	// 
        	// aboutPage
        	// 
        	this.aboutPage.Controls.Add(this.label6);
        	this.aboutPage.Controls.Add(this.label5);
        	this.aboutPage.Controls.Add(this.label4);
        	this.aboutPage.Controls.Add(this.pictureBox1);
        	this.aboutPage.Location = new System.Drawing.Point(4, 25);
        	this.aboutPage.Name = "aboutPage";
        	this.aboutPage.Padding = new System.Windows.Forms.Padding(3);
        	this.aboutPage.Size = new System.Drawing.Size(279, 281);
        	this.aboutPage.TabIndex = 2;
        	this.aboutPage.Text = "About";
        	this.aboutPage.UseVisualStyleBackColor = true;
        	// 
        	// label6
        	// 
        	this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label6.Location = new System.Drawing.Point(117, 211);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(51, 23);
        	this.label6.TabIndex = 3;
        	this.label6.Text = "2015";
        	this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// label5
        	// 
        	this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.Location = new System.Drawing.Point(174, 251);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(107, 23);
        	this.label5.TabIndex = 2;
        	this.label5.Text = "by Pixedar";
        	// 
        	// label4
        	// 
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label4.Location = new System.Drawing.Point(75, 188);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(132, 23);
        	this.label4.TabIndex = 1;
        	this.label4.Text = "AudioRange";
        	this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(0, 0);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(281, 185);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        	this.pictureBox1.TabIndex = 0;
        	this.pictureBox1.TabStop = false;
        	// 
        	// icon
        	// 
        	this.icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
        	this.icon.BalloonTipText = "now I\'m here";
        	this.icon.Icon = ((System.Drawing.Icon)(resources.GetObject("icon.Icon")));
        	this.icon.Text = "AudioRange";
        	this.icon.Visible = true;
        	this.icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.IconMouseDoubleClick);
        	// 
        	// DecibelsToolTip
        	// 
        	this.DecibelsToolTip.AutoPopDelay = 20000;
        	this.DecibelsToolTip.InitialDelay = 1;
        	this.DecibelsToolTip.ReshowDelay = 1;
        	this.DecibelsToolTip.Tag = "";
        	// 
        	// minimalizeOnBorder
        	// 
        	this.minimalizeOnBorder.Image = ((System.Drawing.Image)(resources.GetObject("minimalizeOnBorder.Image")));
        	this.minimalizeOnBorder.Location = new System.Drawing.Point(158, 0);
        	this.minimalizeOnBorder.Name = "minimalizeOnBorder";
        	this.minimalizeOnBorder.Size = new System.Drawing.Size(58, 28);
        	this.minimalizeOnBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.minimalizeOnBorder.TabIndex = 25;
        	this.minimalizeOnBorder.TabStop = false;
        	this.DecibelsToolTip.SetToolTip(this.minimalizeOnBorder, "minimalize to system tray");
        	this.minimalizeOnBorder.Click += new System.EventHandler(this.MinimalizeOnBorderClick);
        	this.minimalizeOnBorder.MouseEnter += new System.EventHandler(this.MinimalizeOnBorderMouseEnter);
        	this.minimalizeOnBorder.MouseLeave += new System.EventHandler(this.MinimalizeOnBorderMouseLeave);
        	// 
        	// exitOnBorder
        	// 
        	this.exitOnBorder.BackColor = System.Drawing.Color.White;
        	this.exitOnBorder.Image = ((System.Drawing.Image)(resources.GetObject("exitOnBorder.Image")));
        	this.exitOnBorder.Location = new System.Drawing.Point(222, 0);
        	this.exitOnBorder.Name = "exitOnBorder";
        	this.exitOnBorder.Size = new System.Drawing.Size(58, 28);
        	this.exitOnBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.exitOnBorder.TabIndex = 0;
        	this.exitOnBorder.TabStop = false;
        	this.DecibelsToolTip.SetToolTip(this.exitOnBorder, "exit");
        	this.exitOnBorder.Click += new System.EventHandler(this.ExitOnBorderClick);
        	this.exitOnBorder.MouseEnter += new System.EventHandler(this.ExitOnBorderMouseEnter);
        	this.exitOnBorder.MouseLeave += new System.EventHandler(this.ExitOnBorderMouseLeave);
        	// 
        	// label24
        	// 
        	this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label24.ForeColor = System.Drawing.Color.SeaGreen;
        	this.label24.Location = new System.Drawing.Point(35, 154);
        	this.label24.Name = "label24";
        	this.label24.Size = new System.Drawing.Size(46, 17);
        	this.label24.TabIndex = 25;
        	this.label24.Text = "FAINT";
        	this.DecibelsToolTip.SetToolTip(this.label24, "Longer exposure to average noise of 30-40 db,does not cause hearing loss.\r\nExampl" +
		"es:\r\n- a pin dropping 10Db,\r\n- ticking watch 20Db\r\n- whisper 30Db\r\n\r\n");
        	// 
        	// label25
        	// 
        	this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label25.ForeColor = System.Drawing.Color.Gold;
        	this.label25.Location = new System.Drawing.Point(87, 154);
        	this.label25.Name = "label25";
        	this.label25.Size = new System.Drawing.Size(72, 17);
        	this.label25.TabIndex = 25;
        	this.label25.Text = "MODERATE";
        	this.DecibelsToolTip.SetToolTip(this.label25, resources.GetString("label25.ToolTip"));
        	// 
        	// label26
        	// 
        	this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label26.ForeColor = System.Drawing.Color.Goldenrod;
        	this.label26.Location = new System.Drawing.Point(154, 154);
        	this.label26.Name = "label26";
        	this.label26.Size = new System.Drawing.Size(72, 17);
        	this.label26.TabIndex = 25;
        	this.label26.Text = "VERY LOUD";
        	this.DecibelsToolTip.SetToolTip(this.label26, resources.GetString("label26.ToolTip"));
        	// 
        	// label27
        	// 
        	this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.label27.ForeColor = System.Drawing.Color.DarkRed;
        	this.label27.Location = new System.Drawing.Point(227, 154);
        	this.label27.Name = "label27";
        	this.label27.Size = new System.Drawing.Size(55, 18);
        	this.label27.TabIndex = 25;
        	this.label27.Text = "DANGER";
        	this.DecibelsToolTip.SetToolTip(this.label27, "Longer exposure to average noise of over 140db may cause instant serious hearing " +
		"damage.\r\nExamples:\r\n- shotgun 170Db,\r\n- rocket engine 180Db,\r\n- vulcan explosion" +
		" 200 Db.\r\n");
        	// 
        	// generalStatisticsGraph
        	// 
        	this.generalStatisticsGraph.Location = new System.Drawing.Point(39, 33);
        	this.generalStatisticsGraph.Name = "generalStatisticsGraph";
        	this.generalStatisticsGraph.Size = new System.Drawing.Size(296, 118);
        	this.generalStatisticsGraph.TabIndex = 1;
        	this.DecibelsToolTip.SetToolTip(this.generalStatisticsGraph, "General statistic are updated with 60s delay\r\n\r\n");
        	this.generalStatisticsGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.GeneralStatisticsGraphPaint);
        	// 
        	// StatisticsTimer
        	// 
        	this.StatisticsTimer.Enabled = true;
        	this.StatisticsTimer.Interval = 60000;
        	this.StatisticsTimer.Tick += new System.EventHandler(this.StatisticsTimerTick);
        	// 
        	// borederBackground
        	// 
        	this.borederBackground.BackColor = System.Drawing.Color.White;
        	this.borederBackground.Controls.Add(this.minimalizeOnBorder);
        	this.borederBackground.Controls.Add(this.borderTitle);
        	this.borederBackground.Controls.Add(this.borderIcon);
        	this.borederBackground.Controls.Add(this.exitOnBorder);
        	this.borederBackground.Location = new System.Drawing.Point(0, 0);
        	this.borederBackground.Name = "borederBackground";
        	this.borederBackground.Size = new System.Drawing.Size(280, 32);
        	this.borederBackground.TabIndex = 25;
        	this.borederBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorederBackgroundMouseDown);
        	this.borederBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorederBackgroundMouseMove);
        	this.borederBackground.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BorederBackgroundMouseUp);
        	// 
        	// borderTitle
        	// 
        	this.borderTitle.Location = new System.Drawing.Point(27, 6);
        	this.borderTitle.Name = "borderTitle";
        	this.borderTitle.Size = new System.Drawing.Size(98, 20);
        	this.borderTitle.TabIndex = 26;
        	this.borderTitle.Text = "Audio Range";
        	this.borderTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderTitleMouseDown);
        	this.borderTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorderTitleMouseMove);
        	this.borderTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BorderTitleMouseUp);
        	// 
        	// borderIcon
        	// 
        	this.borderIcon.Image = ((System.Drawing.Image)(resources.GetObject("borderIcon.Image")));
        	this.borderIcon.Location = new System.Drawing.Point(0, 4);
        	this.borderIcon.Name = "borderIcon";
        	this.borderIcon.Size = new System.Drawing.Size(24, 21);
        	this.borderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.borderIcon.TabIndex = 25;
        	this.borderIcon.TabStop = false;
        	// 
        	// panel2
        	// 
        	this.panel2.BackColor = System.Drawing.Color.White;
        	this.panel2.Controls.Add(this.resetStatisticsButton);
        	this.panel2.Controls.Add(this.sun);
        	this.panel2.Controls.Add(this.sat);
        	this.panel2.Controls.Add(this.fri);
        	this.panel2.Controls.Add(this.thu);
        	this.panel2.Controls.Add(this.wed);
        	this.panel2.Controls.Add(this.tue);
        	this.panel2.Controls.Add(this.mon);
        	this.panel2.Controls.Add(this.label27);
        	this.panel2.Controls.Add(this.label26);
        	this.panel2.Controls.Add(this.label25);
        	this.panel2.Controls.Add(this.label24);
        	this.panel2.Controls.Add(this.weeklyStatisticsLabel);
        	this.panel2.Controls.Add(this.maxPeakNoiseLabel);
        	this.panel2.Controls.Add(this.maxPeakNoise);
        	this.panel2.Controls.Add(this.maxAverangeNoiseLabel);
        	this.panel2.Controls.Add(this.maxVolumeStatisticsBar);
        	this.panel2.Controls.Add(this.weeklyStatisticsGraph);
        	this.panel2.Controls.Add(this.generalStatisticsGraph);
        	this.panel2.Controls.Add(this.generalStatisticsLabel);
        	this.panel2.Location = new System.Drawing.Point(286, 2);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(599, 334);
        	this.panel2.TabIndex = 26;
        	// 
        	// resetStatisticsButton
        	// 
        	this.resetStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.resetStatisticsButton.ForeColor = System.Drawing.Color.LightGray;
        	this.resetStatisticsButton.Location = new System.Drawing.Point(281, 8);
        	this.resetStatisticsButton.Name = "resetStatisticsButton";
        	this.resetStatisticsButton.Size = new System.Drawing.Size(75, 30);
        	this.resetStatisticsButton.TabIndex = 33;
        	this.resetStatisticsButton.Text = "Reset";
        	this.resetStatisticsButton.UseVisualStyleBackColor = true;
        	this.resetStatisticsButton.Click += new System.EventHandler(this.ResetStatisticsButtonClick);
        	this.resetStatisticsButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.ResetStatisticsButtonDragEnter);
        	this.resetStatisticsButton.DragLeave += new System.EventHandler(this.ResetStatisticsButtonDragLeave);
        	// 
        	// sun
        	// 
        	this.sun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.sun.Location = new System.Drawing.Point(244, 314);
        	this.sun.Name = "sun";
        	this.sun.Size = new System.Drawing.Size(42, 17);
        	this.sun.TabIndex = 32;
        	this.sun.Text = "Sun";
        	// 
        	// sat
        	// 
        	this.sat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.sat.Location = new System.Drawing.Point(213, 314);
        	this.sat.Name = "sat";
        	this.sat.Size = new System.Drawing.Size(42, 17);
        	this.sat.TabIndex = 31;
        	this.sat.Text = "Sat";
        	// 
        	// fri
        	// 
        	this.fri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.fri.Location = new System.Drawing.Point(183, 314);
        	this.fri.Name = "fri";
        	this.fri.Size = new System.Drawing.Size(42, 17);
        	this.fri.TabIndex = 30;
        	this.fri.Text = "Fri";
        	// 
        	// thu
        	// 
        	this.thu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.thu.Location = new System.Drawing.Point(149, 314);
        	this.thu.Name = "thu";
        	this.thu.Size = new System.Drawing.Size(42, 17);
        	this.thu.TabIndex = 29;
        	this.thu.Text = "Thu";
        	// 
        	// wed
        	// 
        	this.wed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.wed.Location = new System.Drawing.Point(111, 314);
        	this.wed.Name = "wed";
        	this.wed.Size = new System.Drawing.Size(42, 17);
        	this.wed.TabIndex = 28;
        	this.wed.Text = "Wed";
        	// 
        	// tue
        	// 
        	this.tue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.tue.Location = new System.Drawing.Point(72, 314);
        	this.tue.Name = "tue";
        	this.tue.Size = new System.Drawing.Size(40, 17);
        	this.tue.TabIndex = 27;
        	this.tue.Text = "Tue";
        	// 
        	// mon
        	// 
        	this.mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.mon.Location = new System.Drawing.Point(29, 314);
        	this.mon.Name = "mon";
        	this.mon.Size = new System.Drawing.Size(41, 17);
        	this.mon.TabIndex = 26;
        	this.mon.Text = "Mon";
        	// 
        	// weeklyStatisticsLabel
        	// 
        	this.weeklyStatisticsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.weeklyStatisticsLabel.Location = new System.Drawing.Point(66, 177);
        	this.weeklyStatisticsLabel.Name = "weeklyStatisticsLabel";
        	this.weeklyStatisticsLabel.Size = new System.Drawing.Size(196, 20);
        	this.weeklyStatisticsLabel.TabIndex = 5;
        	this.weeklyStatisticsLabel.Text = "Weekly statistics";
        	this.weeklyStatisticsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        	// 
        	// maxPeakNoiseLabel
        	// 
        	this.maxPeakNoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.maxPeakNoiseLabel.Location = new System.Drawing.Point(388, 183);
        	this.maxPeakNoiseLabel.Name = "maxPeakNoiseLabel";
        	this.maxPeakNoiseLabel.Size = new System.Drawing.Size(196, 23);
        	this.maxPeakNoiseLabel.TabIndex = 4;
        	this.maxPeakNoiseLabel.Text = "Max peak noise";
        	this.maxPeakNoiseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// maxPeakNoise
        	// 
        	this.maxPeakNoise.Controls.Add(this.maxCurrentVolumeStatisticLabel);
        	this.maxPeakNoise.Controls.Add(this.pictureBox3);
        	this.maxPeakNoise.Location = new System.Drawing.Point(440, 236);
        	this.maxPeakNoise.Name = "maxPeakNoise";
        	this.maxPeakNoise.Size = new System.Drawing.Size(92, 85);
        	this.maxPeakNoise.TabIndex = 3;
        	this.maxPeakNoise.Paint += new System.Windows.Forms.PaintEventHandler(this.MaxPeakNoisePaint);
        	// 
        	// maxCurrentVolumeStatisticLabel
        	// 
        	this.maxCurrentVolumeStatisticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.maxCurrentVolumeStatisticLabel.Location = new System.Drawing.Point(26, 29);
        	this.maxCurrentVolumeStatisticLabel.Name = "maxCurrentVolumeStatisticLabel";
        	this.maxCurrentVolumeStatisticLabel.Size = new System.Drawing.Size(40, 28);
        	this.maxCurrentVolumeStatisticLabel.TabIndex = 3;
        	this.maxCurrentVolumeStatisticLabel.Text = "57";
        	this.maxCurrentVolumeStatisticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// pictureBox3
        	// 
        	this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
        	this.pictureBox3.Location = new System.Drawing.Point(0, 0);
        	this.pictureBox3.Name = "pictureBox3";
        	this.pictureBox3.Size = new System.Drawing.Size(92, 85);
        	this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox3.TabIndex = 2;
        	this.pictureBox3.TabStop = false;
        	// 
        	// maxAverangeNoiseLabel
        	// 
        	this.maxAverangeNoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.maxAverangeNoiseLabel.Location = new System.Drawing.Point(388, 15);
        	this.maxAverangeNoiseLabel.Name = "maxAverangeNoiseLabel";
        	this.maxAverangeNoiseLabel.Size = new System.Drawing.Size(196, 20);
        	this.maxAverangeNoiseLabel.TabIndex = 3;
        	this.maxAverangeNoiseLabel.Text = "Max averange noise";
        	this.maxAverangeNoiseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// maxVolumeStatisticsBar
        	// 
        	this.maxVolumeStatisticsBar.Controls.Add(this.maxAverangeVolumeStatisticLabel);
        	this.maxVolumeStatisticsBar.Controls.Add(this.pictureBox2);
        	this.maxVolumeStatisticsBar.Location = new System.Drawing.Point(440, 66);
        	this.maxVolumeStatisticsBar.Name = "maxVolumeStatisticsBar";
        	this.maxVolumeStatisticsBar.Size = new System.Drawing.Size(92, 85);
        	this.maxVolumeStatisticsBar.TabIndex = 2;
        	this.maxVolumeStatisticsBar.Paint += new System.Windows.Forms.PaintEventHandler(this.MaxVolumeStatisticsBarPaint);
        	// 
        	// maxAverangeVolumeStatisticLabel
        	// 
        	this.maxAverangeVolumeStatisticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.maxAverangeVolumeStatisticLabel.Location = new System.Drawing.Point(26, 29);
        	this.maxAverangeVolumeStatisticLabel.Name = "maxAverangeVolumeStatisticLabel";
        	this.maxAverangeVolumeStatisticLabel.Size = new System.Drawing.Size(40, 28);
        	this.maxAverangeVolumeStatisticLabel.TabIndex = 1;
        	this.maxAverangeVolumeStatisticLabel.Text = "57";
        	this.maxAverangeVolumeStatisticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// pictureBox2
        	// 
        	this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
        	this.pictureBox2.Location = new System.Drawing.Point(0, 0);
        	this.pictureBox2.Name = "pictureBox2";
        	this.pictureBox2.Size = new System.Drawing.Size(92, 85);
        	this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox2.TabIndex = 0;
        	this.pictureBox2.TabStop = false;
        	// 
        	// weeklyStatisticsGraph
        	// 
        	this.weeklyStatisticsGraph.Location = new System.Drawing.Point(39, 195);
        	this.weeklyStatisticsGraph.Name = "weeklyStatisticsGraph";
        	this.weeklyStatisticsGraph.Size = new System.Drawing.Size(296, 118);
        	this.weeklyStatisticsGraph.TabIndex = 2;
        	this.weeklyStatisticsGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.WeeklyStatisticsGraphPaint);
        	// 
        	// generalStatisticsLabel
        	// 
        	this.generalStatisticsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.generalStatisticsLabel.Location = new System.Drawing.Point(66, 15);
        	this.generalStatisticsLabel.Name = "generalStatisticsLabel";
        	this.generalStatisticsLabel.Size = new System.Drawing.Size(196, 17);
        	this.generalStatisticsLabel.TabIndex = 0;
        	this.generalStatisticsLabel.Text = "General statistics";
        	this.generalStatisticsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// statisticsAnimation
        	// 
        	this.statisticsAnimation.Interval = 10;
        	this.statisticsAnimation.Tick += new System.EventHandler(this.StatisticsAnimationTick);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(280, 337);
        	this.Controls.Add(this.panel2);
        	this.Controls.Add(this.borederBackground);
        	this.Controls.Add(this.tabControl1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "MainForm";
        	this.Text = "AudioRange";
        	this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
        	this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
        	this.tabControl1.ResumeLayout(false);
        	this.outputPage.ResumeLayout(false);
        	this.outputPage.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.currentVolume)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.maxVolume)).EndInit();
        	this.outputGeneralStatisticsGraph.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.arrow)).EndInit();
        	this.GuiPage.ResumeLayout(false);
        	this.GuiPage.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.warningVolumeTrackBar)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).EndInit();
        	this.settingsPage.ResumeLayout(false);
        	this.settingsPage.PerformLayout();
        	this.aboutPage.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.minimalizeOnBorder)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.exitOnBorder)).EndInit();
        	this.borederBackground.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.borderIcon)).EndInit();
        	this.panel2.ResumeLayout(false);
        	this.maxPeakNoise.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
        	this.maxVolumeStatisticsBar.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        	this.ResumeLayout(false);

        }

    }
}
