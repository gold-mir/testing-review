using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.Models;

namespace Application.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void CheckEqual_ReturnsTrueOnExactlyEqualInput()
        {
            Assert.IsTrue(RepeatCounter.CheckEqual("Kitten", "Kitten"));
            Assert.IsFalse(RepeatCounter.CheckEqual("Kitten", "Puppy"));
        }

        [TestMethod]
        public void CheckEqual_IsCaseInsensitive()
        {
            Assert.IsTrue(RepeatCounter.CheckEqual("kitten", "KIttEn"));
        }

        [TestMethod]
        public void CheckEqual_IgnoresNonLetters()
        {
            Assert.IsTrue(RepeatCounter.CheckEqual("Kitten!!!", "Kitten."));
        }

        [TestMethod]
        public void CheckEqual_ReturnsFalseOnBadOrEmptyInput()
        {
            Assert.IsFalse(RepeatCounter.CheckEqual("", ""));
            Assert.IsFalse(RepeatCounter.CheckEqual("123", "123"));
        }

        [TestMethod]
        public void GetWordCount_CountsWordInstances()
        {
            Assert.AreEqual(RepeatCounter.GetWordCount("I have three cute kittens. Kittens are totally adorable!", "kittens"), 2);
        }

        [TestMethod]
        public void GetWordCount_ErrorsOnBadInput()
        {
           Assert.AreEqual(RepeatCounter.GetWordCount("1 2 3+45 1 16", "1"), -1);
        }
    }
}
