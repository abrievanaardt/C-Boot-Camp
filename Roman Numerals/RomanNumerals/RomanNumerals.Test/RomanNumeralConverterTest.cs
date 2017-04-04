using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class RomanNumeralConverterTest
    {
        [TestMethod]
        public void ConvertTo1()
        {
            long arab = RomanNumeralConverter.Convert("I");
            Assert.AreEqual(1, arab);
        }

        [TestMethod]
        public void ConvertTo2()
        {
            long arab = RomanNumeralConverter.Convert("II");
            Assert.AreEqual(2, arab);
        }

        [TestMethod]
        public void ConvertTo3()
        {
            long arab = RomanNumeralConverter.Convert("III");
            Assert.AreEqual(3, arab);
        }

        [TestMethod]
        public void ConvertTo4()
        {
            long arab = RomanNumeralConverter.Convert("IV");
            Assert.AreEqual(4, arab);
        }

        [TestMethod]
        public void ConvertTo5()
        {
            long arab = RomanNumeralConverter.Convert("V");
            Assert.AreEqual(5, arab);
        }

        [TestMethod]
        public void ConvertTo6()
        {
            long arab = RomanNumeralConverter.Convert("VI");
            Assert.AreEqual(6, arab);
        }

        [TestMethod]
        public void ConvertTo7()
        {
            long arab = RomanNumeralConverter.Convert("VII");
            Assert.AreEqual(7, arab);
        }

        [TestMethod]
        public void ConvertTo8()
        {
            long arab = RomanNumeralConverter.Convert("VIII");
            Assert.AreEqual(8, arab);
        }

        [TestMethod]
        public void ConvertTo9()
        {
            long arab = RomanNumeralConverter.Convert("IX");
            Assert.AreEqual(9, arab);
        }

        [TestMethod]
        public void ConvertTo10()
        {
            long arab = RomanNumeralConverter.Convert("X");
            Assert.AreEqual(10, arab);
        }

        [TestMethod]
        public void ConvertTo11()
        {
            long arab = RomanNumeralConverter.Convert("XI");
            Assert.AreEqual(11, arab);
        }

        [TestMethod]
        public void ConvertTo19()
        {
            long arab = RomanNumeralConverter.Convert("XIX");
            Assert.AreEqual(19, arab);
        }

        [TestMethod]
        public void ConvertTo49()
        {
            long arab = RomanNumeralConverter.Convert("IL");
            Assert.AreEqual(49, arab);
        }

        [TestMethod]
        public void ConvertTo51()
        {
            long arab = RomanNumeralConverter.Convert("LI");
            Assert.AreEqual(51, arab);
        }

        [TestMethod]
        public void ConvertTo88()
        {
            long arab = RomanNumeralConverter.Convert("LXXXVIII");
            Assert.AreEqual(88, arab);
        }

        [TestMethod]
        public void ConvertTo1580()
        {
            long arab = RomanNumeralConverter.Convert("MDLXXX");
            Assert.AreEqual(1580, arab);
        }

    }
}
