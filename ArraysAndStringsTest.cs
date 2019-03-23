using System;
using Xunit;

namespace Ctci
{
    public class ArraysAndStringsTest
    {
        ArraysAndStrings arraysAndStrings;

        public ArraysAndStringsTest(){
            arraysAndStrings = new ArraysAndStrings();
        }

        // 1.1
        [Theory]
        [InlineData("abcd", true)]
        [InlineData("Ragnar", false)]
        public void IsUniqueTheory(string test, bool expected)
        {
            var actual = arraysAndStrings.IsUnique(test);

            Assert.Equal(expected, actual);
        }

        // 1.2
        [Theory]
        [InlineData("abc", "bca", true)]
        [InlineData("racecar", "aaccerr", true)]
        [InlineData("Game of Thrones", "Vikings", false)]
        public void CheckPermutationTheory(string first, string second, bool expected){
            var actual = arraysAndStrings.CheckPermutation(first, second);

            Assert.Equal(expected, actual);
        }

        // 1.3
        [Theory]
        [InlineData("Mr John Smith    ", 13, "Mr%20John%20Smith")]
        public void URLifyTest(string sentence, int length, string expected){
            char[] input = sentence.ToCharArray();
            arraysAndStrings.URLify(input, length);

            string actual = String.Join("", input);
            
            Assert.Equal(expected, actual);
        }

        // 1.4
        [Theory]
        [InlineData("Tact Coa", true)]
        [InlineData("racecar", true)]
        [InlineData("Targaryan", false)]
        public void PalindromePermutationTest(string permutation, bool expected){
            bool actual = arraysAndStrings.PalindromePermutation(permutation);

            Assert.Equal(expected, actual);
        }
    }
}

