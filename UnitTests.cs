using Microsoft.VisualStudio.TestTools.UnitTesting;
using NamedNumbers;

namespace NamedNumbersTest
{
    [TestClass]
    public class UnitTests
    {
        private string errorMessage = "FAILURE, INPUT DATA IS WRONG";
        [TestMethod]
        public void EmptyInput()
        {
            string input = "";
            string expectedOutput = errorMessage;
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void OnlyALetter()
        {
            string input = "a";
            string expectedOutput = errorMessage;
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void ALetterInDecimalPlace()
        {
            string input = "1.b";
            string expectedOutput = errorMessage;
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void NegativeNumber()
        {
            string input = "-1";
            string expectedOutput = errorMessage;
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void DecimalValueTooLarge()
        {
            string input = "1.100";
            string expectedOutput = errorMessage;
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void NegativeDecimalValue()
        {
            string input = "1.-10";
            string expectedOutput = errorMessage;
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void TooLargeNumber()
        {
            string input = "1000000";
            string expectedOutput = errorMessage;
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void OneDollarOneCent1()
        {
            string input = "1.01";
            string expectedOutput = "ONE DOLLAR AND ONE CENT";
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void OneDollarOneCent2()
        {
            string input = "1.1";
            string expectedOutput = "ONE DOLLAR AND ONE CENT";
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void TwoDollarsTwoCents()
        {
            string input = "2.2";
            string expectedOutput = "TWO DOLLARS AND TWO CENTS";
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void MaxValue()
        {
            string input = "999999.99";
            string expectedOutput = "NINE HUNDRED AND NINETY NINE THOUSAND NINE HUNDRED AND NINETY NINE DOLLARS AND NINETY NINE CENTS";
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void Zero()
        {
            string input = "0";
            string expectedOutput = "ZERO DOLLARS AND ZERO CENTS";
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void FourteenDollarsFiftyCents()
        {
            string input = "14.50";
            string expectedOutput = "FOURTEEN DOLLARS AND FIFTY CENTS";
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void FortySevenDollarsFiftyCents()
        {
            string input = "47.50";
            string expectedOutput = "FORTY SEVEN DOLLARS AND FIFTY CENTS";
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void FiveDollars()
        {
            string input = "5";
            string expectedOutput = "FIVE DOLLARS AND ZERO CENTS";
            string result = Program.DecimalToWord(input);
            Assert.AreEqual(expectedOutput, result);
        }

    }
}
