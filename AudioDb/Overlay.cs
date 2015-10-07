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
using System.Drawing;
using System.Windows.Forms;

namespace AudioRange
{

    public partial class Overlay : Form
    {
        public Overlay()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            this.Location = new Point(20, 20);
        }
        void Timer1Tick(object sender, EventArgs e)
        {
            this.Opacity = (float)(MainForm.opacity / 100f);
            if (MainForm.output >= 0)
            {
                volume.Text = ((int)(MainForm.output)).ToString();
                bar.Width = (int)((MainForm.output / MainForm.maximum) * 120);
            }
            if (MainForm.color == true)
            {
                volume.ForeColor = Color.Red;
                brush.Color = Color.Red;
            }
            else
            {
                volume.ForeColor = Color.Black;
                brush.Color = Color.Black;
            }
            voulmeBar.Invalidate();

        }
        void ProgressBar1Click(object sender, EventArgs e)
        {

        }
        Rectangle bar = new Rectangle(0, 0, 0, 10);
        SolidBrush brush = new SolidBrush(Color.Black);
        void VoulmeBarPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(brush, bar);
        }
    }
}
