using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        Validation Validation = new Validation();

        [TestMethod]
        public void TestSentence1()
        {
            bool valid = Validation.ValidateSentence("The quick brown fox said \"hello Mr lazy dog\".");

            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void TestSentence2()
        {
            bool valid = Validation.ValidateSentence("The quick brown fox said hello Mr lazy dog.");

            Assert.IsTrue(valid);
        }
        [TestMethod]
        public void TestSentence3()
        {
            bool valid = Validation.ValidateSentence("One lazy dog is too few, 13 is too many.");

            Assert.IsTrue(valid);
        }
        [TestMethod]
        public void TestSentence4()
        {
            bool valid = Validation.ValidateSentence("One lazy dog is too few, thirteen is too many.");

            Assert.IsTrue(valid);
        }
        [TestMethod]
        public void TestSentence5()
        {
            bool valid = Validation.ValidateSentence("How many \"lazy dogs\" are there?");

            Assert.IsTrue(valid);
        }
        [TestMethod]
        public void TestSentence6()
        {
            bool valid = Validation.ValidateSentence("The quick brown fox said \"hello Mr. lazy dog\".");

            Assert.IsFalse(valid);
        }
        [TestMethod]
        public void TestSentence7()
        {
            bool valid = Validation.ValidateSentence("the quick brown fox said hello Mr lazy dog.");

            Assert.IsFalse(valid);
        }
        [TestMethod]
        public void TestSentence8()
        {
            bool valid = Validation.ValidateSentence("\"The quick brown fox said \"hello Mr. lazy dog\".");

            Assert.IsFalse(valid);
        }
        [TestMethod]
        public void TestSentence9()
        {
            bool valid = Validation.ValidateSentence("One lazy dog is too few, 12 is too many.");

            Assert.IsFalse(valid);
        }

        [TestMethod]
        public void TestSentence10()
        {
            bool valid = Validation.ValidateSentence("Are there 11, 12, or 13 lazy dogs?");

            Assert.IsFalse(valid);
        }
        [TestMethod]
        public void TestSentence11()
        {
            bool valid = Validation.ValidateSentence("There is no punctuation in this sentence");

            Assert.IsFalse(valid);
        }
    }


}
