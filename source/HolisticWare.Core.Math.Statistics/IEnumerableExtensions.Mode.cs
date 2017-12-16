using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Mode_(statistics)"/> 
    public static class IEnumerableExtensionsFrequency
    {
        public static uint Mode(this IEnumerable<ushort> x)
        {
            IEnumerable<KeyValuePair<ushort, uint>> frequencies = x.Frequencies();

            uint mode = frequencies.FirstOrDefault().Value;

            return mode;
        }

        public static uint Mode(this IEnumerable<short> x)
        {
            IEnumerable<KeyValuePair<short, uint>> frequencies = x.Frequencies();

            uint mode = frequencies.FirstOrDefault().Value;

            return mode;
        }

        public static uint Mode(this IEnumerable<int> x)
        {
            IEnumerable<KeyValuePair<int, uint>> frequencies = x.Frequencies();

            uint mode = frequencies.FirstOrDefault().Value;

            return mode;
        }

        public static uint Mode(this IEnumerable<uint> x)
        {
            IEnumerable<KeyValuePair<uint, uint>> frequencies = x.Frequencies();

            uint mode = frequencies.FirstOrDefault().Value;

            return mode;
        }

        public static uint Mode(this IEnumerable<long> x)
        {
            IEnumerable<KeyValuePair<long, uint>> frequencies = x.Frequencies();

            uint mode = frequencies.FirstOrDefault().Value;

            return mode;
        }

        public static uint Mode(this IEnumerable<ulong> x)
        {
            IEnumerable<KeyValuePair<ulong, uint>> frequencies = x.Frequencies();

            uint mode = frequencies.FirstOrDefault().Value;

            return mode;
        }

        public static uint Mode(this IEnumerable<float> x)
        {
            IEnumerable<KeyValuePair<float, uint>> frequencies = x.Frequencies();

            uint mode = frequencies.FirstOrDefault().Value;

            return mode;
        }

        public static uint Mode(this IEnumerable<double> x)
        {
            IEnumerable<KeyValuePair<double, uint>> frequencies = x.Frequencies();

            uint mode = frequencies.FirstOrDefault().Value;

            return mode;
        }

        public static uint Mode(this IEnumerable<decimal> x)
        {
            IEnumerable<KeyValuePair<decimal, uint>> frequencies = x.Frequencies();

            uint mode = frequencies.FirstOrDefault().Value;

            return mode;
        }

   }
}
