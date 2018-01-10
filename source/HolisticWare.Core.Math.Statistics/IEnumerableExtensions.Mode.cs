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
        public static List<ushort> Mode(this IEnumerable<ushort> x)
        {
            IEnumerable<KeyValuePair<ushort, uint>> frequencies = x.Frequencies();

            List<ushort> modes = new List<ushort>();

            uint occurences = frequencies.FirstOrDefault().Value;

            foreach (KeyValuePair<ushort, uint> kvp in frequencies)
            {
                if (occurences == kvp.Value)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static List<short> Mode(this IEnumerable<short> x)
        {
            IEnumerable<KeyValuePair<short, uint>> frequencies = x.Frequencies();

            List<short> modes = new List<short>();

            uint occurences = frequencies.FirstOrDefault().Value;

            foreach (KeyValuePair<short, uint> kvp in frequencies)
            {
                if (occurences == kvp.Value)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static List<int> Mode(this IEnumerable<int> x)
        {
            IEnumerable<KeyValuePair<int, uint>> frequencies = x.Frequencies();

            List<int> modes = new List<int>();

            uint occurences = frequencies.FirstOrDefault().Value;

            foreach (KeyValuePair<int, uint> kvp in frequencies)
            {
                if (occurences == kvp.Value)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static List<uint> Mode(this IEnumerable<uint> x)
        {
            IEnumerable<KeyValuePair<uint, uint>> frequencies = x.Frequencies();

            List<uint> modes = new List<uint>();

            uint occurences = frequencies.FirstOrDefault().Value;

            foreach (KeyValuePair<uint, uint> kvp in frequencies)
            {
                if (occurences == kvp.Value)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static List<long> Mode(this IEnumerable<long> x)
        {
            IEnumerable<KeyValuePair<long, uint>> frequencies = x.Frequencies();

            List<long> modes = new List<long>();

            uint occurences = frequencies.FirstOrDefault().Value;

            foreach(KeyValuePair<long, uint> kvp in frequencies)
            {
                if (occurences == kvp.Value)
                {
                    modes.Add(kvp.Key);   
                }
            }

            return modes;
        }

        public static List<ulong> Mode(this IEnumerable<ulong> x)
        {
            IEnumerable<KeyValuePair<ulong, uint>> frequencies = x.Frequencies();

            List<ulong> modes = new List<ulong>();

            uint occurences = frequencies.FirstOrDefault().Value;

            foreach (KeyValuePair<ulong, uint> kvp in frequencies)
            {
                if (occurences == kvp.Value)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static List<float> Mode(this IEnumerable<float> x)
        {
            IEnumerable<KeyValuePair<float, uint>> frequencies = x.Frequencies();

            List<float> modes = new List<float>();

            uint occurences = frequencies.FirstOrDefault().Value;

            foreach (KeyValuePair<float, uint> kvp in frequencies)
            {
                if (occurences == kvp.Value)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static List<double> Mode(this IEnumerable<double> x)
        {
            IEnumerable<KeyValuePair<double, uint>> frequencies = x.Frequencies();

            List<double> modes = new List<double>();

            uint occurences = frequencies.FirstOrDefault().Value;

            foreach (KeyValuePair<double, uint> kvp in frequencies)
            {
                if (occurences == kvp.Value)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static List<decimal> Mode(this IEnumerable<decimal> x)
        {
            IEnumerable<KeyValuePair<decimal, uint>> frequencies = x.Frequencies();

            List<decimal> modes = new List<decimal>();

            uint occurences = frequencies.FirstOrDefault().Value;

            foreach (KeyValuePair<decimal, uint> kvp in frequencies)
            {
                if (occurences == kvp.Value)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }
   }
}
