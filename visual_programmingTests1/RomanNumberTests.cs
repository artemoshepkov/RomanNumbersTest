using Microsoft.VisualStudio.TestTools.UnitTesting;
using visual_programming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_programming.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest_WhenNumberLessThanMinValue()
        {
            ushort numberLessThanPossibleInterval = 0;

            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(numberLessThanPossibleInterval));
        }

        [TestMethod()]
        public void RomanNumberTest_WhenNumberMoreThanMaxValue()
        {
            ushort numberMoreThanPossibleInterval = 4000;

            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(numberMoreThanPossibleInterval));
        }


        [TestMethod()]
        public void ToStringTest_NumberLyingOnLeftBorder()
        {
            ushort numberLyingOnLeftBorder = 1;
            string expected = "I";
            var romanNumber = new RomanNumber(numberLyingOnLeftBorder);

            Assert.AreEqual(expected, romanNumber.ToString());
        }

        [TestMethod()]
        public void ToStringTest_NumberLyingOnRightBorder()
        {
            ushort numberLyingOnRightBorder = 3999;
            string expected = "MMMCMXCIX";
            var romanNumber = new RomanNumber(numberLyingOnRightBorder);

            Assert.AreEqual(expected, romanNumber.ToString());
        }

        [TestMethod()]
        public void ToStringTest_NumberLyingOnMiddle()
        {
            ushort numberLyingOnLeftBorder = 2000;
            string expected = "MM";
            var romanNumber = new RomanNumber(numberLyingOnLeftBorder);

            Assert.AreEqual(expected, romanNumber.ToString());
        }


        [TestMethod()]
        public void CloneTest_ComparisonValues()
        {
            ushort number = 15; // any number
            string expected = "XV";
            RomanNumber romanNumber = new RomanNumber(number);
            RomanNumber cloneRomanNumber = (RomanNumber)romanNumber.Clone();

            Assert.AreEqual(expected, cloneRomanNumber.ToString());
        }

        [TestMethod()]
        public void CloneTest_ComparisonLinks()
        {
            ushort number = 15; // any number
            RomanNumber romanNumber = new RomanNumber(number);
            RomanNumber cloneRomanNumber = (RomanNumber)romanNumber.Clone();

            Assert.AreNotSame(romanNumber, cloneRomanNumber);
        }


        [TestMethod()]
        public void CompareToTest_ValuesAreEqual()
        {
            ushort number = 10; // any number
            int expected = 0;
            RomanNumber firstRomanNumber = new RomanNumber(number);
            RomanNumber secondRomanNumber = new RomanNumber(number);

            Assert.AreEqual(expected, firstRomanNumber.CompareTo(secondRomanNumber));
        }

        [TestMethod()]
        public void CompareToTest_ValuesAreNotEqual()
        {
            ushort firstNumber = 100; // any number
            ushort secondNumber = 10; // any number
            int expected = firstNumber - secondNumber;
            RomanNumber firstRomanNumber = new RomanNumber(firstNumber);
            RomanNumber secondRomanNumber = new RomanNumber(secondNumber);

            Assert.AreEqual(expected, firstRomanNumber.CompareTo(secondRomanNumber));
        }

        [TestMethod()]
        public void CompareToTest_SecondValueIsNotRomanNumber()
        {
            ushort number = 10;
            RomanNumber firstRomanNumber = new RomanNumber(number);
            int secondNumber = 5;

            Assert.ThrowsException<RomanNumberException>(() => firstRomanNumber.CompareTo(secondNumber));
        }


        [TestMethod()]
        public void OperatorPlusTest_OneOfRomanNumbersEqualNull()
        {
            RomanNumber romanNumber = new RomanNumber(10);

            Assert.ThrowsException<RomanNumberException>(() => romanNumber + null);
        }

        [TestMethod()]
        public void OperatorPlusTest_SumRomanNumbersMoreThanMaxValue()
        {
            ushort firstNumber = 3999;
            ushort secondNumber = 1; 
            RomanNumber testOperationRomanNum1 = new RomanNumber(firstNumber);
            RomanNumber testOperationRomanNum2 = new RomanNumber(secondNumber);

            Assert.ThrowsException<RomanNumberException>(() => testOperationRomanNum1 + testOperationRomanNum2);
        }

        [TestMethod()]
        public void OperatorPlusTest()
        {
            ushort firstNumber = 10; // any number
            ushort secondNumber = 5; // any number
            string expected = "XV";
            RomanNumber testOperationRomanNum1 = new RomanNumber(firstNumber);
            RomanNumber testOperationRomanNum2 = new RomanNumber(secondNumber);

            RomanNumber resault = testOperationRomanNum1 + testOperationRomanNum2;

            Assert.AreEqual(expected, resault.ToString());

        }


        [TestMethod()]
        public void OperatorSubTest_OneOfRomanNumbersEqualNull()
        {
            RomanNumber romanNumber = new RomanNumber(10);

            Assert.ThrowsException<RomanNumberException>(() => romanNumber - null);
        }

        [TestMethod()]
        public void OperatorSubTest_RomanNumbersEqual()
        {
            ushort firstNumber = 200;
            ushort secondNumber = 200;
            RomanNumber testOperationRomanNum1 = new RomanNumber(firstNumber);
            RomanNumber testOperationRomanNum2 = new RomanNumber(secondNumber);

            Assert.ThrowsException<RomanNumberException>(() => testOperationRomanNum1 - testOperationRomanNum2);
        }

        [TestMethod()]
        public void OperatorSubTest_FirstRomanNumbersLestThanSecond()
        {
            ushort firstNumber = 10;
            ushort secondNumber = 200;
            RomanNumber testOperationRomanNum1 = new RomanNumber(firstNumber);
            RomanNumber testOperationRomanNum2 = new RomanNumber(secondNumber);

            Assert.ThrowsException<RomanNumberException>(() => testOperationRomanNum1 - testOperationRomanNum2);
        }

        [TestMethod()]
        public void OperatorSubTest()
        {
            ushort firstNumber = 10; // any number
            ushort secondNumber = 5; // any number
            string expected = "V";
            RomanNumber testOperationRomanNum1 = new RomanNumber(firstNumber);
            RomanNumber testOperationRomanNum2 = new RomanNumber(secondNumber);

            RomanNumber resault = testOperationRomanNum1 - testOperationRomanNum2;

            Assert.AreEqual(expected, resault.ToString());
        }


        [TestMethod()]
        public void OperatorMultiplyTest_OneOfRomanNumbersEqualNull()
        {
            RomanNumber romanNumber = new RomanNumber(10);

            Assert.ThrowsException<ArgumentNullException>(() => romanNumber * null);
        }

        [TestMethod()]
        public void OperatorMultiplyTest_MultiplyRomanNumbersMoreThanMaxValue()
        {
            ushort firstNumber = 500;
            ushort secondNumber = 10;
            RomanNumber testOperationRomanNum1 = new RomanNumber(firstNumber);
            RomanNumber testOperationRomanNum2 = new RomanNumber(secondNumber);

            Assert.ThrowsException<RomanNumberException>(() => testOperationRomanNum1 * testOperationRomanNum2);
        }

        [TestMethod()]
        public void OperatorMultiplyTest()
        {
            ushort firstNumber = 10; // any number
            ushort secondNumber = 5; // any number
            string expected = "L";
            RomanNumber testOperationRomanNum1 = new RomanNumber(firstNumber);
            RomanNumber testOperationRomanNum2 = new RomanNumber(secondNumber);

            RomanNumber resault = testOperationRomanNum1 * testOperationRomanNum2;

            Assert.AreEqual(expected, resault.ToString());
        }

                
        [TestMethod()]
        public void OperatorDivTest_OneOfRomanNumbersEqualNull()
        {
            RomanNumber romanNumber = new RomanNumber(10);

            Assert.ThrowsException<ArgumentNullException>(() => romanNumber / null);
        }

        [TestMethod()]
        public void OperatorDivTest_FirstRomanNumbersLessThanSecond()
        {
            ushort firstNumber = 5;
            ushort secondNumber = 10;
            RomanNumber testOperationRomanNum1 = new RomanNumber(firstNumber);
            RomanNumber testOperationRomanNum2 = new RomanNumber(secondNumber);

            Assert.ThrowsException<RomanNumberException>(() => testOperationRomanNum1 / testOperationRomanNum2);
        }

        [TestMethod()]
        public void OperatorDivTest()
        {
            ushort firstNumber = 10; // any number
            ushort secondNumber = 5; // any number
            string expected = "II";
            RomanNumber testOperationRomanNum1 = new RomanNumber(firstNumber);
            RomanNumber testOperationRomanNum2 = new RomanNumber(secondNumber);

            RomanNumber resault = testOperationRomanNum1 / testOperationRomanNum2;

            Assert.AreEqual(expected, resault.ToString());
        }
    }
}