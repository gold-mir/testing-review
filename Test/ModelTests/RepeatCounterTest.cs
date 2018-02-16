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
    }
}
