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
    /*
    * Avernage class, is used to calculate averange volume
    */
    public class Averange
    {

        public int timerCount = 0;
        //c
        public double[] avTab;
        //s 101
        public int scalar;

        public Averange(int sc)
        {
            scalar = sc;
            avTab = new double[scalar];
        }


        public int averange(double input)
        {

            if (timerCount > scalar - 1)
            {
                avTab = new double[scalar];
                timerCount = 0;
            }
            avTab[timerCount] = input;
            timerCount++;

            double averange = 0;
            for (int i = 0; i < scalar - 1; i++)
            {
                averange += avTab[i];

            }
            averange = averange / timerCount;
            return (int)averange;

        }

    }
}
