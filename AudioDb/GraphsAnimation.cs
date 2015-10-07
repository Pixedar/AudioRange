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

namespace AudioRange
{

    public static class GraphsAnimation
    {
        public static int gAnimation = 20;
        public static int dAnimation = 0;
        public static int m1Animation = 68;
        public static int m2Animation = 68;
        public static int m1lAnimation = 0;
        public static int m2lAnimation = 0;

        private static bool start = true;

        private static double sum;
        private static double allDays;



        public static void animation(this MainForm m)
        {

            sum = m.faintStatistics + m.moderateStatistics + m.veryLoudStatistics + m.dangerStatistics;
            allDays = m.days[0] + m.days[1] + m.days[2] + m.days[3] + m.days[4] + m.days[5] + m.days[6];

            if (allDays == 0)
            {
                allDays = 1;
            }
            if (sum == 0)
            {
                sum = 1;
            }
            if (start)
            {
                configure(m);
                start = false;
            }
            gAnimation--;
            dAnimation--;
            m1Animation--;
            m2Animation--;
            m1lAnimation--;
            m2lAnimation--;

            m.g1.Y = (int)(92 - (((m.faintStatistics / sum) * 92) - gAnimation));
            m.g2.Y = (int)(92 - (((m.moderateStatistics / sum) * 92) - gAnimation));
            m.g3.Y = (int)(92 - (((m.veryLoudStatistics / sum) * 92) - gAnimation));
            m.g4.Y = (int)(92 - (((m.dangerStatistics / sum) * 92) - gAnimation));




            m.w1.Y = (int)(92 - ((((double)m.days[0] / allDays) * 70) - dAnimation));
            m.w2.Y = (int)(92 - ((((double)m.days[1] / allDays) * 70) - dAnimation));
            m.w3.Y = (int)(92 - ((((double)m.days[2] / allDays) * 70) - dAnimation));
            m.w4.Y = (int)(92 - ((((double)m.days[3] / allDays) * 70) - dAnimation));
            m.w5.Y = (int)(92 - ((((double)m.days[4] / allDays) * 70) - dAnimation));
            m.w6.Y = (int)(92 - ((((double)m.days[5] / allDays) * 70) - dAnimation));
            m.w7.Y = (int)(92 - ((((double)m.days[6] / allDays) * 70) - dAnimation));

            m.m1.Y = (int)(68 - ((double)((double)m.maxAverangeVolume / (double)MainForm.maximum)) * 68 + m1Animation);
            m.m2.Y = (int)(68 - ((double)((double)m.maxCurrentVolume / (double)MainForm.maximum)) * 68 + m2Animation);


            if (m1lAnimation <= 0)
            {
                m1lAnimation = 0;
            }
            if (m2lAnimation <= 0)
            {
                m2lAnimation = 0;
            }
            if (m1Animation <= 0)
            {
                m1Animation = 0;
                m1lAnimation = 0;
            }
            if (m2Animation <= 0)
            {
                m2Animation = 0;
                m2lAnimation = 0;
            }
            if (gAnimation <= 0)
            {
                gAnimation = 0;
            }
            if (dAnimation <= 0)
            {
                dAnimation = 0;
            }
            m.maxAverangeVolumeStatisticLabel.Text = (m.maxAverangeVolume - m1lAnimation).ToString();
            m.maxCurrentVolumeStatisticLabel.Text = (m.maxCurrentVolume - m2lAnimation).ToString();

        }
        public static void configure(this MainForm m)
        {
            sum = m.faintStatistics + m.moderateStatistics + m.veryLoudStatistics + m.dangerStatistics;
            allDays = m.days[0] + m.days[1] + m.days[2] + m.days[3] + m.days[4] + m.days[5] + m.days[6];
            if (allDays == 0)
            {
                allDays = 1;
            }
            if (sum == 0)
            {
                sum = 1;
            }


            if (m.faintStatistics > m.moderateStatistics && m.faintStatistics > m.veryLoudStatistics && m.faintStatistics > m.dangerStatistics)
            {
                gAnimation = (int)(((((double)m.faintStatistics / (double)sum) * 92))) / 2;
            }
            else if (m.moderateStatistics > m.faintStatistics && m.moderateStatistics > m.veryLoudStatistics && m.moderateStatistics > m.dangerStatistics)
            {
                gAnimation = (int)(((((double)m.moderateStatistics / (double)sum) * 92))) / 2;
            }
            else if (m.veryLoudStatistics > m.faintStatistics && m.veryLoudStatistics > m.moderateStatistics && m.veryLoudStatistics > m.dangerStatistics)
            {
                gAnimation = (int)(((((double)m.veryLoudStatistics / (double)sum) * 92))) / 2;
            }
            else if (m.dangerStatistics > m.faintStatistics && m.dangerStatistics > m.moderateStatistics && m.dangerStatistics > m.veryLoudStatistics)
            {
                gAnimation = (int)(((((double)m.dangerStatistics / (double)sum) * 92))) / 2;
            }
            else
            {
                gAnimation = 25;
            }


            for (int f = 0; f < 7; f++)
            {
                if (dAnimation < (int)(((double)m.days[f] / (double)allDays) * 70))
                {
                    dAnimation = (int)(((double)m.days[f] / (double)allDays) * 70) / 2;
                }
            }

            if (dAnimation == 0)
            {
                dAnimation = 10;
            }
            m1Animation = (int)(((double)((double)m.maxAverangeVolume / (double)MainForm.maximum)) * 68);
            m2Animation = (int)(((double)((double)m.maxCurrentVolume / (double)MainForm.maximum)) * 68);

            m1lAnimation = m.maxAverangeVolume;
            m2lAnimation = m.maxCurrentVolume;

        }

    }
}
