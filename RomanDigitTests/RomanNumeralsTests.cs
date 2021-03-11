using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanDigit;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanDigit.Tests
{
    [TestClass()]
    public class RomanNumeralsTests
    {
        [TestMethod()]
        public void RomanToIntTest()
        {
            string s = "CMXCIX";
            int result = 999;

            int actual = RomanNumerals.RomanToInt(s);

            Assert.AreEqual(result, actual);
        }
    }
}