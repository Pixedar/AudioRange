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

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using NAudio.CoreAudioApi;

namespace AudioRange
{
    public partial class MainForm : Form
    {

        private double sensitivity = 112.0;
        private double maxOutputVoltage = 1.4;
        private double impedance = 32.0;
        private double spl;

        public static int maximum;
        public static double output;
        public static bool color = false;
        public static int opacity = 50;


        private int warningVolume = 0;
        private Averange averangeVolume;
        private Overlay overlay;
        private Warning warning;



        private bool newAverange = true;
        private bool hotKey = false;
        private bool hotKeyClick = false;
        private bool overlayState = true;
        private bool averangeState = true;
        private bool warningIsEnabled = false;
        private bool averangeIsEnbled = false;
        private bool deviceIsSelected = false;
        private bool currentVolumeIsEnabled = true;
        private bool maxVolumeIsSelectedEnabled = false;
        private bool usbHeadphones = true;


        public double faintStatistics = 0;
        public double moderateStatistics = 0;
        public double veryLoudStatistics = 0;
        public double dangerStatistics = 0;
        public int statistics;
        public int[] days = new int[7];
        public DateTime date = DateTime.Today;
        public bool resetWeekly = false;
        public int weeklyFaint = 0;
        public int weeklyModerate = 0;
        public int weeklyVeryLoud = 0;
        public int weeklyDanger = 0;
        public int lastDay = 1;
        public int maxAverangeVolume = 0;
        public int maxCurrentVolume = 0;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        private Keys key;

        private Averange statisticAverange;
        public MainForm()
        {

            InitializeComponent();
            this.MaximizeBox = false;
            setMaximum(maxOutputVoltage);
            initlializeSettings();


            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);


            devicesComboBox.Items.AddRange(devices.ToArray());

            devicesComboBox.SelectedIndex = 0;


            warningVolumeTrackBar.Maximum = maximum;

        }

        void setMaximum(double maxVoltage)
        {
            if (maxVoltage > 0 && maxVoltage != null)
            {
                maximum = (int)(20.0f * (Math.Log10((sensitivity * (maxVoltage * (2.0 / impedance)) * maxVoltage) / 0.00002)));
            }

        }

        private void MainTimerTick(object sender, EventArgs e)
        {
            if (devicesComboBox.SelectedItem != null)
            {
                if (deviceIsSelected == false)
                {
                    enableComponents();
                }

                MMDevice device = (MMDevice)devicesComboBox.SelectedItem;


                calculateVolume(device);
                updateComponenets();


            }
            if (panelMouselEntered == true || arrowMouseEntered == true)
            {
                arrow.Visible = true;
            }
            else if (panelMouselEntered == false && arrowMouseEntered == false)
            {
                arrow.Visible = false;
            }


            if (arrowCicked == true)
            {
                this.Size = new Size(new Point(650, 274));
            }
            else
            {
                this.Size = new Size(new Point(210, 274));
            }

        }

        void IntervalTextBoxTextChanged(object sender, EventArgs e)
        {
            if (intervalTextBox.Text != "")
            {
                intervalTextBox.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        void OpacityTrackBarScroll(object sender, EventArgs e)
        {
            opacity = opacityTrackBar.Value;
        }

        void MaxVoltageTextTextChanged(object sender, EventArgs e)
        {
            try
            {
                maxOutputVoltage = Convert.ToDouble(maxVoltageText.Text);
                maxVoltageText.BackColor = Color.FromArgb(255, 255, 255);
                setMaximum(maxOutputVoltage);
                maxVolumeStatisticsBar.Invalidate();
                maxPeakNoise.Invalidate();
            }
            catch (FormatException)
            {
                maxVoltageText.BackColor = Color.FromArgb(243, 135, 135);
            }

        }

        void SensitivityTextTextChanged(object sender, EventArgs e)
        {
            try
            {
                sensitivity = Convert.ToDouble(sensitivityText.Text);
                sensitivityText.BackColor = Color.FromArgb(255, 255, 255);

                setMaximum(maxOutputVoltage);
                maxVolumeStatisticsBar.Invalidate();
                maxPeakNoise.Invalidate();
            }
            catch (FormatException)
            {
                sensitivityText.BackColor = Color.FromArgb(243, 135, 135);
            }
        }

        void ImpemendanceTextTextChanged(object sender, EventArgs e)
        {
            try
            {
                impedance = Convert.ToDouble(impemendanceText.Text);
                impemendanceText.BackColor = Color.FromArgb(255, 255, 255);
                setMaximum(maxOutputVoltage);
                maxVolumeStatisticsBar.Invalidate();
                maxPeakNoise.Invalidate();
            }
            catch (FormatException)
            {
                impemendanceText.BackColor = Color.FromArgb(243, 135, 135);
            }
        }

        Bitmap radioButoonEnabled = new Bitmap("icons//radioButtonSelected.png");
        Bitmap radioButoonDisbaled = new Bitmap("icons//radioButtonNotSelected.png");
        void CurrentVolumeClick(object sender, EventArgs e)
        {
            if (deviceIsSelected)
            {
                averangeCheckBox.Enabled = true;
                intervalLabel.Enabled = true;
                intervalTextBox.Enabled = true;
            }
            currentVolumeIsEnabled = true;
            maxVolumeIsSelectedEnabled = false;
            maxVolume.Image = radioButoonDisbaled;
            //  currentVolume.Checked = true;
            currentVolume.Image = radioButoonEnabled;
        }

        void MaxVolumeClick(object sender, EventArgs e)
        {
            averangeCheckBox.Enabled = false;
            intervalLabel.Enabled = false;
            intervalTextBox.Enabled = false;

            currentVolumeIsEnabled = false;
            maxVolumeIsSelectedEnabled = true;
            //     currentVolume.Checked = false;
            currentVolume.Image = radioButoonDisbaled;
            maxVolume.Image = radioButoonEnabled;
        }

        void IconMouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;

        }
        void MainFormSizeChanged(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                icon.Visible = true;
                icon.ShowBalloonTip(500);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                this.Show();
                icon.Visible = false;

            }
        }


        void UsbCheckedChanged(object sender, EventArgs e)
        {
            if (usbHeadphones == true)
            {
                usbHeadphones = false;
            }
            else
            {
                usbHeadphones = true;
            }
        }
        void HotkeyChangeClick(object sender, EventArgs e)
        {
            if (hotKeyClick == false)
            {
                hotkeyChange.BackColor = Color.FromArgb(200, 200, 200);
                hotKeyNotify.Visible = false;
                hotKeyConfirm.Visible = true;
                hotKeyClick = true;
            }
            else
            {
                hotkeyChange.BackColor = Color.FromArgb(255, 255, 255);
                RegisterHotKey(this.Handle, 0, (int)KeyModifier.Shift, key.GetHashCode());
                hotKeyClick = false;
                hotKeyNotify.Visible = true;
                hotKeyConfirm.Visible = false;

            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                if (hotKey == true && deviceIsSelected == true)
                {
                    if (overlayState == true)
                    {
                        opacityTrackBar.Enabled = true;
                        overlayState = false;
                        volumeAsOverlayCheckBox.Checked = true;
                        opacityLabel.Enabled = true;
                        colorLabel.Enabled = true;
                        blackLabel.Enabled = true;
                        redLabel.Enabled = true;
                        label10.Enabled = true;
                        overlay = new Overlay();
                        overlay.Show();
                    }
                    else if (overlayState == false)
                    {
                        opacityTrackBar.Enabled = false;
                        volumeAsOverlayCheckBox.Checked = false;
                        opacityLabel.Enabled = false;
                        overlayState = true;
                        colorLabel.Enabled = false;
                        blackLabel.Enabled = false;
                        redLabel.Enabled = false;
                        label10.Enabled = false;
                        overlay.Dispose();
                    }
                }

            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (hotKey == true && hotKeyClick == true)
            {
                key = keyData;
                hotkeyChange.Text = keyData.ToString();

                return false;
            }
            return false;
        }
        void OverlayKeyLabelCheckedChanged(object sender, EventArgs e)
        {
            if (hotKey == false)
            {
                ShiftLabel.Enabled = true;
                label3.Enabled = true;
                hotkeyChange.Enabled = true;
                hotKeyNotify.Visible = true;
                hotKey = true;

            }
            else
            {

                ShiftLabel.Enabled = false;
                label3.Enabled = false;
                hotkeyChange.Enabled = false;
                hotKeyNotify.Visible = false;
                hotKey = false;

            }

        }
        void MainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter settings = new System.IO.StreamWriter("settings.txt");

            settings.WriteLine(maxOutputVoltage);
            settings.WriteLine(sensitivity);
            settings.WriteLine(impedance);
            settings.WriteLine(hotKey);
            settings.WriteLine(key);
            settings.WriteLine(usbHeadphones);
            settings.WriteLine(currentVolumeIsEnabled);
            settings.WriteLine(faintStatistics);
            settings.WriteLine(moderateStatistics);
            settings.WriteLine(veryLoudStatistics);

            settings.WriteLine(weeklyFaint);
            settings.WriteLine(weeklyModerate);
            settings.WriteLine(weeklyVeryLoud);
            settings.WriteLine(days[0]);
            settings.WriteLine(days[1]);
            settings.WriteLine(days[2]);
            settings.WriteLine(days[3]);
            settings.WriteLine(days[4]);
            settings.WriteLine(days[5]);
            settings.WriteLine(days[6]);
            settings.WriteLine(lastDay);
            settings.WriteLine(maxAverangeVolume);
            settings.WriteLine(maxCurrentVolume);
            settings.WriteLine(resetWeekly);
            settings.WriteLine(dangerStatistics);
            settings.WriteLine(weeklyDanger);
            settings.Close();
        }

        void RedLabelClick(object sender, EventArgs e)
        {
            blackLabel.ForeColor = Color.Gray;
            redLabel.ForeColor = Color.Black;
            color = true;
        }
        void BlackLabelClick(object sender, EventArgs e)
        {
            redLabel.ForeColor = Color.Gray;
            blackLabel.ForeColor = Color.Black;
            color = false;
        }
        void AverangeCheckBoxClick(object sender, EventArgs e)
        {
            if (intervalTextBox.Text != "")
            {
                if (averangeState == true)
                {
                    intervalTextBox.Enabled = false;
                    averangeState = false;
                    averangeIsEnbled = true;
                    intervalLabel.Enabled = false;
                }
                else if (averangeState == false)
                {
                    intervalTextBox.Enabled = true;
                    averangeCheckBox.Checked = false;
                    averangeIsEnbled = false;
                    averangeState = true;
                    intervalLabel.Enabled = true;
                }
            }
            else
            {
                averangeCheckBox.Checked = false;
                intervalTextBox.BackColor = impemendanceText.BackColor = Color.FromArgb(243, 135, 135);
            }

        }
        void VolumeAsOverlayCheckBoxClick(object sender, EventArgs e)
        {
            if (overlayState == true)
            {
                blackLabel.Enabled = true;
                redLabel.Enabled = true;
                colorLabel.Enabled = true;
                label10.Enabled = true;
                opacityTrackBar.Enabled = true;
                opacityLabel.Enabled = true;
                overlayState = false;
                overlay = new Overlay();
                overlay.Show();
            }
            else if (overlayState == false)
            {
                blackLabel.Enabled = false;
                redLabel.Enabled = false;
                colorLabel.Enabled = false;
                label10.Enabled = false;
                opacityTrackBar.Enabled = false;
                opacityLabel.Enabled = false;
                volumeAsOverlayCheckBox.Checked = false;
                overlayState = true;
                overlay.Dispose();
            }

        }
        void WarningCheckBoxClick(object sender, EventArgs e)
        {
            if (warningIsEnabled == false)
            {
                warningIsEnabled = true;
                warning = new Warning();
                warningVolumeLabel.Enabled = true;
                warningVolumeDb.Enabled = true;
                warningVolumeTrackBar.Enabled = true;
                warningIsEnabled = true;

                blackLabel.Enabled = false;
                redLabel.Enabled = false;
                colorLabel.Enabled = false;
                label10.Enabled = false;
                opacityTrackBar.Enabled = false;
                opacityLabel.Enabled = false;
                volumeAsOverlayCheckBox.Checked = false;
                overlayState = true;
                if (overlay != null)
                {
                    overlay.Dispose();
                }


            }
            else
            {
                warningVolumeLabel.Enabled = false;
                warningVolumeDb.Enabled = false;
                warningVolumeTrackBar.Enabled = false;
                warningIsEnabled = false;
                warning.Dispose();
            }
        }
        void WarningVolumeTrackBarScroll(object sender, EventArgs e)
        {
            warningVolume = warningVolumeTrackBar.Value;
            warningVolumeDb.Text = warningVolumeTrackBar.Value.ToString() + " Db";
        }


        private Rectangle d1 = new Rectangle(0, 70, 24, 80);
        private Rectangle d2 = new Rectangle(50, 70, 24, 80);
        private Rectangle d3 = new Rectangle(100, 70, 24, 80);
        private Rectangle d4 = new Rectangle(150, 70, 24, 80);
        void OutputGeneralStatisticsGraphPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.SeaGreen, d1);
            e.Graphics.FillRectangle(Brushes.Gold, d2);
            e.Graphics.FillRectangle(Brushes.Goldenrod, d3);
            e.Graphics.FillRectangle(Brushes.DarkRed, d4);
        }

        public Rectangle g1 = new Rectangle(0, 92, 24, 95);
        public Rectangle g2 = new Rectangle(50, 92, 24, 95);
        public Rectangle g3 = new Rectangle(100, 92, 24, 95);
        public Rectangle g4 = new Rectangle(150, 92, 24, 95);

        void GeneralStatisticsGraphPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.SeaGreen, g1);
            e.Graphics.FillRectangle(Brushes.Gold, g2);
            e.Graphics.FillRectangle(Brushes.Goldenrod, g3);
            e.Graphics.FillRectangle(Brushes.DarkRed, g4);
        }


        public Rectangle w1 = new Rectangle(0, 20, 15, 95);
        public Rectangle w2 = new Rectangle(30, 40, 15, 95);
        public Rectangle w3 = new Rectangle(60, 70, 15, 95);
        public Rectangle w4 = new Rectangle(85, 50, 15, 95);
        public Rectangle w5 = new Rectangle(110, 35, 15, 95);
        public Rectangle w6 = new Rectangle(135, 29, 15, 95);
        public Rectangle w7 = new Rectangle(160, 18, 15, 95);
        void WeeklyStatisticsGraphPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Teal, w1);
            e.Graphics.FillRectangle(Brushes.Teal, w2);
            e.Graphics.FillRectangle(Brushes.Teal, w3);
            e.Graphics.FillRectangle(Brushes.Teal, w4);
            e.Graphics.FillRectangle(Brushes.Teal, w5);
            e.Graphics.FillRectangle(Brushes.Teal, w6);
            e.Graphics.FillRectangle(Brushes.Teal, w7);
        }

        public Rectangle m1 = new Rectangle(0, 0, 100, 100);
        void MaxVolumeStatisticsBarPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, m1);
        }
        public Rectangle m2 = new Rectangle(0, 0, 100, 100);
        void MaxPeakNoisePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, m2);
        }
        void StatisticsTimerTick(object sender, EventArgs e)
        {
            if (statistics <= 40 && statistics > 1)
            {
                faintStatistics++;
                weeklyFaint++;
            }
            else if (statistics > 40 && statistics <= 70)
            {
                moderateStatistics++;
                weeklyModerate++;
            }
            else if (statistics > 70 && statistics <= 100)
            {
                veryLoudStatistics++;
                weeklyVeryLoud++;
            }
            else if (statistics > 100)
            {
                dangerStatistics++;
                weeklyDanger++;
            }
            double sum = faintStatistics + moderateStatistics + veryLoudStatistics + dangerStatistics;
            if (sum == 0)
            {
                sum = 1;
            }
            if (statistics > maxAverangeVolume)
            {
                maxAverangeVolume = statistics;
                //  int m1t = (int)(68 - ((double)((double)maxAverangeVolume / (double)maximum)) * 68);
                int m1t = (int)(68 - ((double)maxAverangeVolume / (double)maximum) * 68);
                m1.Y = m1t;
                maxVolumeStatisticsBar.Invalidate();
                maxAverangeVolumeStatisticLabel.Text = maxAverangeVolume.ToString();

            }

            //            d1.Y = (int)(70 - (((double)faintStatistics / sum) * 70));
            //            d2.Y = (int)(70 - (((double)moderateStatistics / sum) * 70));
            //            d3.Y = (int)(70 - (((double)veryLoudStatistics /sum) * 70));
            //            g1.Y = (int)(92 - (((double)faintStatistics / sum) * 92));
            //            g2.Y = (int)(92 - (((double)moderateStatistics / sum) * 92));
            //            g3.Y = (int)(92 - (((double)veryLoudStatistics / sum) * 92));
            d1.Y = (int)(70 - ((faintStatistics / sum) * 70));
            d2.Y = (int)(70 - ((moderateStatistics / sum) * 70));
            d3.Y = (int)(70 - ((veryLoudStatistics / sum) * 70));
            d4.Y = (int)(70 - ((dangerStatistics / sum) * 70));

            g1.Y = (int)(92 - ((faintStatistics / sum) * 92));
            g2.Y = (int)(92 - ((moderateStatistics / sum) * 92));
            g3.Y = (int)(92 - ((veryLoudStatistics / sum) * 92));
            g4.Y = (int)(92 - ((dangerStatistics / sum) * 70));
            statisticAverange.timerCount = 0;
            statisticAverange.avTab = new double[621];
            outputGeneralStatisticsGraph.Invalidate();
            generalStatisticsGraph.Invalidate();
        }


        Rectangle volumeBar = new Rectangle(0, 0, 0, 8);
        void VolumeProgressBarPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, volumeBar);
        }

        bool panelMouselEntered = false;
        bool arrowMouseEntered = false;
        bool arrowCicked = false;
        Bitmap openArrow = new Bitmap("icons//openArrow.png");
        Bitmap exitArrow = new Bitmap("icons//exitArrow.png");
        void ArrowMouseEnter(object sender, EventArgs e)
        {
            panelMouselEntered = true;
        }
        void ArrowMouseLeave(object sender, EventArgs e)
        {
            panelMouselEntered = false;
        }

        void OutputGeneralStatisticsGraphMouseEnter(object sender, EventArgs e)
        {
            arrowMouseEntered = true;
        }
        void OutputGeneralStatisticsGraphMouseLeave(object sender, EventArgs e)
        {
            arrowMouseEntered = false;
        }

        void ArrowClick(object sender, EventArgs e)
        {
            if (arrowCicked == false)
            {
                arrowCicked = true;
                arrow.Image = exitArrow;
                GraphsAnimation.configure(this);
                statisticsAnimation.Enabled = true;
            }
            else
            {
                arrowCicked = false;
                arrow.Image = openArrow;
            }
        }


        Bitmap exitEnabled = new Bitmap("icons//exitEnable.png");
        Bitmap exitDisable = new Bitmap("icons//exitDisabled.png");
        Bitmap minimalizeDisable = new Bitmap("icons//minimalizeDisabled.png");
        Bitmap minimalizeEnable = new Bitmap("icons//minimalizeEnabled.png");
        void ExitOnBorderMouseEnter(object sender, EventArgs e)
        {
            exitOnBorder.Image = exitEnabled;
        }
        void ExitOnBorderMouseLeave(object sender, EventArgs e)
        {
            exitOnBorder.Image = exitDisable;
        }
        void MinimalizeOnBorderMouseEnter(object sender, EventArgs e)
        {
            minimalizeOnBorder.Image = minimalizeEnable;
        }
        void MinimalizeOnBorderMouseLeave(object sender, EventArgs e)
        {
            minimalizeOnBorder.Image = minimalizeDisable;
        }
        void ExitOnBorderClick(object sender, EventArgs e)
        {
            this.Close();
        }
        void MinimalizeOnBorderClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int x = 0;
        int y = 0;
        bool borederMouseDown = false;

        void BorederBackgroundMouseDown(object sender, MouseEventArgs e)
        {

            x = e.X;
            y = e.Y;
            borederMouseDown = true;


        }
        void BorederBackgroundMouseMove(object sender, MouseEventArgs e)
        {
            if (borederMouseDown == true && (this.Location.X + e.X - x) > 0 && (this.Location.Y + e.Y - y) > 0)
            {
                this.Location = new Point(this.Location.X + e.X - x, this.Location.Y + e.Y - y);
            }


        }
        void BorederBackgroundMouseUp(object sender, MouseEventArgs e)
        {
            borederMouseDown = false;
        }
        void BorderTitleMouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            borederMouseDown = true;
        }
        void BorderTitleMouseUp(object sender, MouseEventArgs e)
        {
            borederMouseDown = false;
        }
        void BorderTitleMouseMove(object sender, MouseEventArgs e)
        {
            if (borederMouseDown == true && (this.Location.X + e.X - x) > 0 && (this.Location.Y + e.Y - y) > 0)
            {
                this.Location = new Point(this.Location.X + e.X - x, this.Location.Y + e.Y - y);
            }
        }
        void BorderIconMouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            borederMouseDown = true;
        }
        void BorderIconMouseUp(object sender, MouseEventArgs e)
        {
            borederMouseDown = false;
        }
        void BorderIconMouseMove(object sender, MouseEventArgs e)
        {
            if (borederMouseDown == true && (this.Location.X + e.X - x) > 0 && (this.Location.Y + e.Y - y) > 0)
            {
                this.Location = new Point(this.Location.X + e.X - x, this.Location.Y + e.Y - y);
            }
        }

        void ResetStatisticsButtonClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This option will reset your statistics. Are you sure?", "Reset", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                maxAverangeVolume = 0;
                maxCurrentVolume = 0;
                faintStatistics = 0;
                moderateStatistics = 0;
                veryLoudStatistics = 0;
                dangerStatistics = 0;
                days = new int[7];
                resetWeekly = false;
                weeklyFaint = 0;
                weeklyModerate = 0;
                weeklyVeryLoud = 0;
                lastDay = (int)(date.DayOfWeek);
                d1.Y = 70;
                d2.Y = 70;
                d3.Y = 70;
                d4.Y = 70;
                g1.Y = 92;
                g2.Y = 92;
                g3.Y = 92;
                g4.Y = 92;
                w1.Y = 92;
                w2.Y = 92;
                w3.Y = 92;
                w4.Y = 92;
                w5.Y = 92;
                w6.Y = 92;
                w7.Y = 92;
                m1.Y = 68;
                m2.Y = 68;
                statisticAverange.timerCount = 0;
                statisticAverange.avTab = new double[621];
                StatisticsTimer.Stop();
                StatisticsTimer.Start();
                maxAverangeVolumeStatisticLabel.Text = "0";
                maxCurrentVolumeStatisticLabel.Text = "0";
                maxVolumeStatisticsBar.Invalidate();
                maxPeakNoise.Invalidate();
                outputGeneralStatisticsGraph.Invalidate();
                generalStatisticsGraph.Invalidate();
                weeklyStatisticsGraph.Invalidate();
            }
        }
        void ResetStatisticsButtonDragEnter(object sender, DragEventArgs e)
        {
            resetStatisticsButton.ForeColor = Color.Black;
        }
        void ResetStatisticsButtonDragLeave(object sender, EventArgs e)
        {
            resetStatisticsButton.ForeColor = Color.LightGray;
        }



        void StatisticsAnimationTick(object sender, EventArgs e)
        {
            GraphsAnimation.animation(this);
            generalStatisticsGraph.Invalidate();
            weeklyStatisticsGraph.Invalidate();
            maxPeakNoise.Invalidate();
            maxVolumeStatisticsBar.Invalidate();
            if (GraphsAnimation.gAnimation == 0 && GraphsAnimation.dAnimation == 0 && GraphsAnimation.m1Animation == 0
              && GraphsAnimation.m2Animation == 0)
            {
                statisticsAnimation.Enabled = false;
            }
        }

        void initlializeSettings()
        {
            statisticAverange = new Averange(621);
            averangeCheckBox.Enabled = false;
            volumeAsOverlayCheckBox.Enabled = false;
            intervalLabel.Enabled = false;
            intervalTextBox.Enabled = false;
            //	progressBar1.Enabled = false;
            volumeLabel.Enabled = false;
            opacityLabel.Enabled = false;
            opacityTrackBar.Enabled = false;
            deviceIsSelected = false;
            blackLabel.Enabled = false;
            redLabel.Enabled = false;
            colorLabel.Enabled = false;
            label10.Enabled = false;
            overlayKeyLabel.Enabled = false;
            warningCheckBox.Enabled = false;
            warningVolumeDb.Enabled = false;
            warningVolumeLabel.Enabled = false;
            warningVolumeTrackBar.Enabled = false;
            redLabel.ForeColor = Color.Gray;
            blackLabel.ForeColor = Color.Black;


            try
            {
                using (StreamReader sr = new StreamReader("settings.txt"))
                {
                    maxOutputVoltage = Convert.ToDouble(sr.ReadLine());
                    maxVoltageText.Text = maxOutputVoltage.ToString();
                    sensitivity = Convert.ToDouble(sr.ReadLine());
                    sensitivityText.Text = sensitivity.ToString();
                    impedance = Convert.ToDouble(sr.ReadLine());
                    impemendanceText.Text = impedance.ToString();
                    hotKey = Convert.ToBoolean(sr.ReadLine());
                    if (hotKey)
                    {
                        overlayKeyLabel.Checked = true;
                        ShiftLabel.Enabled = true;
                        label3.Enabled = true;
                        hotkeyChange.Enabled = true;
                        hotKeyNotify.Visible = true;
                        hotKey = true;
                    }

                    TypeConverter converter = TypeDescriptor.GetConverter(typeof(Keys));
                    key = (Keys)converter.ConvertFromString(sr.ReadLine());

                    hotkeyChange.Text = key.ToString();
                    RegisterHotKey(this.Handle, 0, (int)KeyModifier.Shift, key.GetHashCode());
                    usbHeadphones = Convert.ToBoolean(sr.ReadLine());

                    if (!usbHeadphones)
                    {
                        usb.Checked = false;
                        usbHeadphones = false;
                    }
                    currentVolumeIsEnabled = Convert.ToBoolean(sr.ReadLine());
                    if (currentVolumeIsEnabled)
                    {
                        //  currentVolume.Checked = true;
                        //  maxVolumeRadioButton.Checked = false;
                        currentVolume.Image = radioButoonEnabled;
                        maxVolume.Image = radioButoonDisbaled;
                    }
                    else
                    {
                        // maxVolumeRadioButton.Checked = true;
                        maxVolume.Image = radioButoonEnabled;
                        currentVolume.Image = radioButoonDisbaled;
                        // currentVolume.Checked = false;
                    }

                    faintStatistics = Convert.ToDouble(sr.ReadLine());
                    moderateStatistics = Convert.ToDouble(sr.ReadLine());
                    veryLoudStatistics = Convert.ToDouble(sr.ReadLine());

                    weeklyFaint = Convert.ToInt32(sr.ReadLine());
                    weeklyModerate = Convert.ToInt32(sr.ReadLine());
                    weeklyVeryLoud = Convert.ToInt32(sr.ReadLine());

                    days[0] = Convert.ToInt32(sr.ReadLine());
                    days[1] = Convert.ToInt32(sr.ReadLine());
                    days[2] = Convert.ToInt32(sr.ReadLine());
                    days[3] = Convert.ToInt32(sr.ReadLine());
                    days[4] = Convert.ToInt32(sr.ReadLine());
                    days[5] = Convert.ToInt32(sr.ReadLine());
                    days[6] = Convert.ToInt32(sr.ReadLine());
                    lastDay = Convert.ToInt32(sr.ReadLine());

                    maxAverangeVolume = Convert.ToInt32(sr.ReadLine());
                    maxCurrentVolume = Convert.ToInt32(sr.ReadLine());
                    resetWeekly = Convert.ToBoolean(sr.ReadLine());
                    dangerStatistics = Convert.ToDouble(sr.ReadLine());
                    weeklyDanger = Convert.ToInt32(sr.ReadLine());

                    double sum = faintStatistics + moderateStatistics + veryLoudStatistics + dangerStatistics;
                    if (sum == 0)
                    {
                        sum = 1;
                    }
                    d1.Y = (int)(70 - ((faintStatistics / sum) * 70));
                    d2.Y = (int)(70 - ((moderateStatistics / sum) * 70));
                    d3.Y = (int)(70 - ((veryLoudStatistics / sum) * 70));
                    d4.Y = (int)(70 - ((dangerStatistics / sum) * 70));

                    g1.Y = (int)(92 - ((faintStatistics / sum) * 92));
                    g2.Y = (int)(92 - ((moderateStatistics / sum) * 92));
                    g3.Y = (int)(92 - ((veryLoudStatistics / sum) * 92));
                    g4.Y = (int)(70 - ((dangerStatistics / sum) * 70));
                    statisticAverange.timerCount = 0;
                    statisticAverange.avTab = new double[621];
                    outputGeneralStatisticsGraph.Invalidate();
                    generalStatisticsGraph.Invalidate();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Settings failed");
            }



            if ((int)(date.DayOfWeek) != lastDay)
            {
                weeklyFaint = 0;
                weeklyModerate = 0;
                weeklyVeryLoud = 0;
                lastDay = (int)(date.DayOfWeek);
            }
            if ((int)(date.DayOfWeek) == 1)
            {
                if (resetWeekly == true)
                {
                    days = new int[7];
                    resetWeekly = false;
                }
                days[0] = (weeklyFaint + weeklyModerate + weeklyVeryLoud + weeklyDanger) / 4;
            }
            else if ((int)(date.DayOfWeek) == 2)
            {
                days[1] = (weeklyFaint + weeklyModerate + weeklyVeryLoud + weeklyDanger) / 4;
            }
            else if ((int)(date.DayOfWeek) == 3)
            {
                days[2] = (weeklyFaint + weeklyModerate + weeklyVeryLoud + weeklyDanger) / 4;
            }
            else if ((int)(date.DayOfWeek) == 4)
            {
                days[3] = (weeklyFaint + weeklyModerate + weeklyVeryLoud + weeklyDanger) / 4;
            }
            else if ((int)(date.DayOfWeek) == 5)
            {
                days[4] = (weeklyFaint + weeklyModerate + weeklyVeryLoud + weeklyDanger) / 4;
            }
            else if ((int)(date.DayOfWeek) == 6)
            {
                days[5] = (weeklyFaint + weeklyModerate + weeklyVeryLoud + weeklyDanger) / 4;
            }
            else if ((int)(date.DayOfWeek) == 0)
            {
                days[6] = (weeklyFaint + weeklyModerate + weeklyVeryLoud + weeklyDanger) / 4;
                resetWeekly = true;
            }
            int allDays = days[0] + days[1] + days[2] + days[3] + days[4] + days[5] + days[6];
            if (allDays == 0)
            {
                allDays = 1;
            }
            w1.Y = (int)(92 - ((double)days[0] / (double)allDays) * 70);
            w2.Y = (int)(92 - ((double)days[1] / (double)allDays) * 70);
            w3.Y = (int)(92 - ((double)days[2] / (double)allDays) * 70);
            w4.Y = (int)(92 - ((double)days[3] / (double)allDays) * 70);
            w5.Y = (int)(92 - ((double)days[4] / (double)allDays) * 70);
            w6.Y = (int)(92 - ((double)days[5] / (double)allDays) * 70);
            w7.Y = (int)(92 - ((double)days[6] / (double)allDays) * 70);
            weeklyStatisticsGraph.Invalidate();

            switch ((int)date.DayOfWeek)
            {
                case 1: mon.Font = new Font(mon.Font, FontStyle.Bold); break;
                case 2: tue.Font = new Font(mon.Font, FontStyle.Bold); break;
                case 3: wed.Font = new Font(mon.Font, FontStyle.Bold); break;
                case 4: thu.Font = new Font(mon.Font, FontStyle.Bold); break;
                case 5: fri.Font = new Font(mon.Font, FontStyle.Bold); break;
                case 6: sat.Font = new Font(mon.Font, FontStyle.Bold); break;
                case 0: sun.Font = new Font(mon.Font, FontStyle.Bold); break;
            }

            int m1t = (int)(68 - ((double)maxAverangeVolume / (double)maximum) * 68);
            int m2t = (int)(68 - ((double)maxCurrentVolume / (double)maximum) * 68);
            m1.Y = m1t;
            m2.Y = m2t;
            maxAverangeVolumeStatisticLabel.Text = maxAverangeVolume.ToString();
            maxCurrentVolumeStatisticLabel.Text = maxCurrentVolume.ToString();
            maxVolumeStatisticsBar.Invalidate();
            maxPeakNoise.Invalidate();


            ShiftLabel.Enabled = false;
            label3.Enabled = false;
            hotkeyChange.Enabled = false;
            hotKeyNotify.Enabled = false;
        }

        void enableComponents()
        {
            averangeCheckBox.Enabled = true;
            volumeAsOverlayCheckBox.Enabled = true;
            intervalLabel.Enabled = true;
            intervalTextBox.Enabled = true;
            volumeLabel.Enabled = true;
            overlayKeyLabel.Enabled = true;
            ShiftLabel.Enabled = true;
            label3.Enabled = true;
            hotkeyChange.Enabled = true;
            hotKeyNotify.Enabled = true;
            warningCheckBox.Enabled = true;
            deviceIsSelected = true;
        }

        void calculateVolume(MMDevice device)
        {
            double peak;
            if (currentVolumeIsEnabled == true)
            {
                if (usbHeadphones)
                {
                    peak = device.AudioMeterInformation.MasterPeakValue;
                }
                else
                {
                    peak = device.AudioMeterInformation.MasterPeakValue * device.AudioEndpointVolume.MasterVolumeLevelScalar;
                }

            }
            else
            {
                peak = device.AudioEndpointVolume.MasterVolumeLevelScalar;
            }
            double voltage;
            if (usbHeadphones)
            {
                //	voltage = maxOutputVoltage * (peak * peak);
                voltage = maxOutputVoltage * peak;
            }
            else
            {
                //	voltage = maxOutputVoltage * (peak * peak);
                voltage = maxOutputVoltage * peak;
            }

            double pa = (sensitivity * (voltage * (2.0 / impedance)) * voltage);
            spl = 20.0f * (Math.Log10(pa / 0.00002f));
        }

        void updateComponenets()
        {
            if (spl >= 0)
            {

                if (averangeIsEnbled && intervalTextBox.Text != "")
                {

                    try
                    {
                        if (newAverange == true)
                        {
                            averangeVolume = new Averange(Convert.ToInt32(intervalTextBox.Text));
                            newAverange = false;
                        }
                        intervalTextBox.BackColor = Color.FromArgb(255, 255, 255);

                        intervalTextBox.Enabled = false;
                        output = averangeVolume.averange(spl);
                        volumeLabel.Text = averangeVolume.averange(spl).ToString();

                        volumeBar.Width = averangeVolume.averange(spl) * 193 / maximum;
                        volumeProgressBar.Invalidate();
                    }
                    catch (FormatException)
                    {
                        intervalTextBox.BackColor = Color.FromArgb(243, 135, 135);
                    }

                    if (warningIsEnabled && averangeVolume.averange(spl) > warningVolume && overlayState == true)
                    {
                        warning.Show();
                    }
                    else if (warning != null)
                    {
                        warning.Hide();
                    }



                }
                else if (averangeIsEnbled == false)
                {

                    newAverange = true;
                    output = spl;
                    volumeLabel.Text = (Math.Round(spl, 1)).ToString() + " Db";
                    volumeBar.Width = (int)((spl / maximum) * 193);

                    if (spl > maxCurrentVolume && currentVolumeIsEnabled == true)
                    {
                        maxCurrentVolume = (int)spl;
                        int m2t = (int)(68 - ((double)((double)maxCurrentVolume / (double)maximum)) * 68);
                        m2.Y = m2t;
                        maxPeakNoise.Invalidate();
                        maxCurrentVolumeStatisticLabel.Text = maxCurrentVolume.ToString();

                    }


                    if (warningIsEnabled && (int)spl > warningVolume && overlayState == true)
                    {
                        warning.Show();
                    }
                    else if (warning != null)
                    {
                        warning.Hide();
                    }
                }

                if (currentVolumeIsEnabled == true)
                {
                    statistics = statisticAverange.averange(spl);
                }

                volumeProgressBar.Invalidate();



            }
            else
            {

                if (averangeIsEnbled == false)
                {
                    output = 0;
                    volumeBar.Width = 0;
                    volumeProgressBar.Invalidate();
                    volumeLabel.Text = "0 Db";
                    if (warning != null)
                    {
                        warning.Hide();
                    }
                }
            }
        }




    }
}




