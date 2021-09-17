﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LineLengths
{
    class Lines
    {
        public void CompareLengths(double l1x1, double l1x2, double l1y1, double l1y2,
                              double l2x1, double l2x2, double l2y1, double l2y2)
        {
            double line1Length = Math.Sqrt(Math.Pow(l1x2 - l1x1, 2) + Math.Pow(l1y2 - l1y1, 2));
            double line2Length = Math.Sqrt(Math.Pow(l2x2 - l2x1, 2) + Math.Pow(l2y2 - l2y1, 2));
            switch (line1Length.CompareTo(line2Length))
            {
                case 0:
                    Console.WriteLine("Both lines are of equal length.");
                    break;
                case 1:
                    Console.WriteLine("Line1 is of more length than Line2.");
                    break;
                default:
                    Console.WriteLine("Line2 is of more length than Line1.");
                    break;
            }
        }
    }
}
