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
        public void Data03()
        {
            List<double> x3 = new List<double>
            {
            };

            double x3_average = x3.Average();
            Assert.AreEqual(x3_average, 63.77, 0.01);

            double x3_standard_deviation = x3.StandardDeviationSample();
            Assert.AreEqual(x3_standard_deviation, 17.63, 0.01);

            List<double> d2 = new List<double>();

            for (int i = 0; i < x1.Count; i++)
            {
                d2.Add(x2[i] - x1[i]);
            }

            double d2_average = d2.Average();
            Assert.AreEqual(d2_average, 5.0, 0.01);

            double d2_standard_deviation = d2.StandardDeviationSample();
            Assert.AreEqual(d2_standard_deviation, 0.0, 0.01);

            return;
        }
    }
}
