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

        [Test()]
        public void Mode01()
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

            double x1_average = x1.Average();
            Assert.AreEqual(x1_average, 58.77, 0.001);

            double x1_standard_deviation = x1.StandardDeviationSample();
            Assert.AreEqual(x1_standard_deviation, 17.63, 0.001);

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

            double x2_average = x1.Average();
            Assert.AreEqual(x2_average, 63.77, 0.001);

            double x2_standard_deviation = x1.StandardDeviationSample();
            Assert.AreEqual(x1_standard_deviation, 17.63, 0.001);


            return;
        }

    }
}
