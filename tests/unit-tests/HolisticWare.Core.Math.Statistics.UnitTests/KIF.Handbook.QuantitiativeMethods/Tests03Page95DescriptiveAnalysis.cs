// /*
//    Copyright (c) 2017-12
//
//    moljac
//    Test.cs
//
//    Permission is hereby granted, free of charge, to any person
//    obtaining a copy of this software and associated documentation
//    files (the "Software"), to deal in the Software without
//    restriction, including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following
//    conditions:
//
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// */
using NUnit.Framework;
using System;

using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;
using System.Collections;

namespace UnitTests.HolisticWare.Core.Math.Statistics
{
    public partial class Tests03Page95DescriptiveAnalysis
    {
        List<double> x1 = new List<double>
            {
                82.61,
                93.51,
                78.46,
                55.14,
                49.65,
                45.82,
                50.21,
                51.65,
                69.45,
                57.32,
                35.62,
                47.95,
                33.65,
                52.69,
                77.95,
            };

        [Test()]
        public void Data00()
        {
            double x1_average = x1.Average();
            Assert.AreEqual(x1_average, 58.77, 0.01);

            double x1_standard_deviation = x1.StandardDeviationSample();
            Assert.AreEqual(x1_standard_deviation, 17.63, 0.01);

            double x1_min = x1.Min();
            Assert.AreEqual(x1_min, 33.65, 0.01);

            double x1_max = x1.Max();
            Assert.AreEqual(x1_max, 93.51, 0.01);

            return;
        }

        [Test()]
        public void Data01()
        {
            List<double> x2 = new List<double>
            {
                87.61,
                98.51,
                83.46,
                60.14,
                54.65,
                50.82,
                55.21,
                56.65,
                74.45,
                62.32,
                40.62,
                52.95,
                38.65,
                57.69,
                82.95,
            };

            double x2_average = x2.Average();
            Assert.AreEqual(x2_average, 63.77, 0.01);

            double x2_standard_deviation = x2.StandardDeviationSample();
            Assert.AreEqual(x2_standard_deviation, 17.63, 0.01);

            double x2_min = x2.Min();
            Assert.AreEqual(x2_min, 38.65, 0.01);

            double x2_max = x2.Max();
            Assert.AreEqual(x2_max, 98.51, 0.01);

            List<double> d1 = new List<double>();

            for(int i = 0; i < x1.Count; i++)
            {
                d1.Add(x2[i] - x1[i]);
            }

            double d1_average = d1.Average();
            Assert.AreEqual(d1_average, 5.0, 0.01);

            double d1_standard_deviation = d1.StandardDeviationSample();
            Assert.AreEqual(d1_standard_deviation, 0.0, 0.01);

            return;
        }

        [Test()]
        public void Data02()
        {
            List<double> x3 = new List<double>
            {
                83.98,
                94.31,
                80.62,
                56.36,
                57.47,
                51.19,
                56.54,
                60.91,
                74.45,
                67.00,
                44.56,
                53.24,
                39.51,
                57.64,
                80.21,
            };

            double x3_average = x3.Average();
            Assert.AreEqual(x3_average, 63.86, 0.01);

            double x3_standard_deviation = x3.StandardDeviationSample();
            Assert.AreEqual(x3_standard_deviation, 15.67, 0.01);

            double x3_min = x3.Min();
            Assert.AreEqual(x3_min, 39.51, 0.01);

            double x3_max = x3.Max();
            Assert.AreEqual(x3_max, 94.31, 0.01);

            List<double> d2 = new List<double>();

            for (int i = 0; i < x1.Count; i++)
            {
                d2.Add(x3[i] - x1[i]);
            }

            double d2_average = d2.Average();
            Assert.AreEqual(d2_average, 5.08, 0.01);

            double d2_standard_deviation = d2.StandardDeviationSample();
            Assert.AreEqual(d2_standard_deviation, 3.01, 0.01);

            return;
        }

        [Test()]
        public void Data03()
        {
            List<double> x4 = new List<double>
            {
                85.65,
                94.62,
                83.65,
                59.84,
                52.34,
                51.26,
                61.24,
                57.95,
                80.65,
                61.53,
                37.45,
                58.31,
                33.95,
                64.25,
                82.21,
            };

            double x4_average = x4.Average();
            Assert.AreEqual(x4_average, 64.32, 0.01);

            double x4_standard_deviation = x4.StandardDeviationSample();
            Assert.AreEqual(x4_standard_deviation, 17.73, 0.01);

            double x4_min = x4.Min();
            Assert.AreEqual(x4_min, 33.95, 0.01);

            double x4_max = x4.Max();
            Assert.AreEqual(x4_max, 94.62, 0.01);

            List<double> d4 = new List<double>();

            for (int i = 0; i < x1.Count; i++)
            {
                d4.Add(x4[i] - x1[i]);
            }

            double d4_average = d4.Average();
            Assert.AreEqual(d4_average, 5.54, 0.01);

            double d4_standard_deviation = d4.StandardDeviationSample();
            Assert.AreEqual(d4_standard_deviation, 3.79, 0.01);

            return;
        }


    }
}
