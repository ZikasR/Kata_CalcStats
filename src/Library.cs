using System;
using System.Linq;

namespace CalcStatsLibrary
{
    public class CalcStats
    {
        Stats stats;

        public CalcStats()
        {
            stats = new Stats();
        }

        delegate void Operator (int[] sequence, Stats stats); 

        public Stats CalculateStats(int[] sequence)
        {
            Operator o = Min;
            o += Max;
            o += NbrElements;
            o += Average;

            o(sequence, stats);

            return stats;    
        }

        static void Min(int[] sequence, Stats stats) => stats.Min = sequence.Min();

        static void Max(int[] sequence, Stats stats) => stats.Max = sequence.Max();

        static void NbrElements(int[] sequence, Stats stats) => stats.Count = sequence.Length;

        static void Average(int[] sequence, Stats stats) => stats.Average = Math.Round(((double)sequence.Sum() / sequence.Length), 2);
    }
}
