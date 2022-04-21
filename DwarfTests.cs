﻿using lab6;
using Xunit;

namespace Test
{
    public class DwarfTests
    {
        [Fact]
        public void AllTheSame_Tests() // Все значения равны 0
        {
            int[] sortedArray = sort.Dwarf(Array.allTheSameArray);
            Assert.Equal(sortedArray, Array.allTheSameArray);
        }

        [Fact]
        public void From10To1_Tests() // От 10 до 1
        {
            int[] sortedArray = sort.Dwarf(Array.from10To1Array);
            Assert.Equal(sortedArray, Array.sorted1Array);
        }

        [Fact]
        public void AlreadySorted_Tests() // Уже отсортированный массив
        {
            int[] sortedArray = sort.Dwarf(Array.sorted1Array);
            Assert.Equal(sortedArray, Array.sorted1Array);
        }
    }
}
