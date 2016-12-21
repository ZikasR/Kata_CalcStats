using System;
using Xunit;
using CalcStatsLibrary;

namespace CalcStatsTests
{

    public class Tests
    {

        Stats stats;

        public Tests()
        {
            int[] sequence = new int[] { 6, 9, 15, -2, 92, 11 };
            CalcStats calcStats = new CalcStats();
            stats = calcStats.CalculateStats(sequence);
        }  


        [Fact]
        public void Given_the_sequence_the_min_should_be_minus_2() 
        {
            Assert.Equal(-2, stats.Min);
        }

        [Fact]
        public void Given_the_sequence_the_max_should_be_92()
        {
            Assert.Equal(92, stats.Max);            
        }

        [Fact]
        public void Given_the_sequence_the_number_of_elements_should_be_6()
        {
            Assert.Equal(6, stats.Count);
        }

        [Fact]
        public void Given_the_sequence_the_avergae_should_be_21_point_83()
        {
            Assert.Equal(21.83d, stats.Average);
        }
    }
}
