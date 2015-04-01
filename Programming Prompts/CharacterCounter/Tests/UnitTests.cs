using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterCounter;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        public Counter counter = new Counter();

        [TestMethod]
        public void WhenCounterIsPassedOneCharacterItShouldReturnCorrectDictionary()
        {
            Dictionary<Char, int> expected = new Dictionary<Char, int>();
            expected.Add('a', 1);

            Dictionary<Char, int> actual = counter.Count("a");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenCounterIsPassedTwoDifferentCharactersItShouldReturnCorrectDictionary()
        {
            Dictionary<Char, int> expected = new Dictionary<Char, int>();
            expected.Add('a', 1);
            expected.Add('b', 1);

            Dictionary<Char, int> actual = counter.Count("ab");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenCounterIsPassedThreeDifferentCharactersItShouldReturnCorrectDictionary()
        {
            Dictionary<Char, int> expected = new Dictionary<Char, int>();
            expected.Add('a', 1);
            expected.Add('b', 1);
            expected.Add('c', 1);

            Dictionary<Char, int> actual = counter.Count("cab");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenCounterIsPassedMultipleOfTheSameCharacterItShouldReturnCorrectDictionary()
        {
            Dictionary<Char, int> expected = new Dictionary<Char, int>();
            expected.Add('a', 2);

            Dictionary<Char, int> actual = counter.Count("aa");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenCounterIsPassedMultipleOfTheSameCharacterInDifferingCasesItShouldReturnCorrectDictionary()
        {
            Dictionary<Char, int> expected = new Dictionary<Char, int>();
            expected.Add('a', 4);

            Dictionary<Char, int> actual = counter.Count("aaAA");

            Assert.AreEqual(expected, actual);
        }
    }
}
