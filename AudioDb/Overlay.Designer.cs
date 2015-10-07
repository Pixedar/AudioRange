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
using System.Drawing;
using System.Windows.Forms;
namespace AudioRange
{
    partial class Overlay
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Timer timer1;
        private AudioRange.DoubleBufferedPanel voulmeBar;

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
            this.volume = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.voulmeBar = new AudioRange.DoubleBufferedPanel();
            this.SuspendLayout();
            // 
            // volume
            // 
            this.volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.volume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volume.Location = new System.Drawing.Point(37, 0);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(88, 31);
            this.volume.TabIndex = 0;
            this.volume.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // voulmeBar
            // 
            this.voulmeBar.BackColor = System.Drawing.SystemColors.Control;
            this.voulmeBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voulmeBar.Location = new System.Drawing.Point(1, 34);
            this.voulmeBar.Name = "voulmeBar";
            this.voulmeBar.Size = new System.Drawing.Size(160, 14);
            this.voulmeBar.TabIndex = 2;
            this.voulmeBar.Paint += new System.Windows.Forms.PaintEventHandler(this.VoulmeBarPaint);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(163, 50);
            this.Controls.Add(this.voulmeBar);
            this.Controls.Add(this.volume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Overlay";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DarkGreen;
            this.ResumeLayout(false);

        }
    }
}
