using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//using NUnit.Framework;

namespace calculator
{
    // [TestFixture]
    public class Tests
    {
        // Given-When-Then: Test for an empty string input.
        //[Test]
        public static void GivenEmptyString_WhenCalculating_ThenReturnZero()
        {
            // Given
            string input = "";
            int expected_result = 0;

            // When
            var result = Calculator.Calculate(input);

            // Then
            Debug.Assert(Equals(expected_result, result));
        }

        public static void GivenSingleNumber_WhenCalculating_ThenReturnNumber()
        {
            // Given
            string input = "5";
            int expected_result = 5;

            // When
            var result = Calculator.Calculate(input);

            // Then
            Debug.Assert(result == expected_result);
        }
        public static void GivenTwoNumbersSeparatedByComma_WhenCalculating_ThenReturnTheirSum()
        {
            // Given
            string input = "3,4";
            int expected_result = 7;

            // When
            var result = Calculator.Calculate(input);

            // Then
            Debug.Assert(result == expected_result);
        }

        public static void GivenTwoNumbersSeparatedByNewline_WhenCalculating_ThenReturnTheirSum()
        {
            // Given
            string input = "3\n4";
            int expected_result = 7;

            // When
            var result = Calculator.Calculate(input);

            // Then
            Debug.Assert(result == expected_result);
        }

        public static void GivenThreeNumbersSeparatedByCommaOrNewline_WhenCalculating_ThenReturnTheirSum()
        {
            // Given
            string inputComma = "1,2,3";
            int expectedCommaResult = 6;

            string inputNewline = "1\n2\n3";
            int expectedNewlineResult = 6;

            string inputMixed = "1,2\n3";
            int expectedMixedResult = 6;

            // When
            var resultComma = Calculator.Calculate(inputComma);
            var resultNewline = Calculator.Calculate(inputNewline);
            var resultMixed = Calculator.Calculate(inputMixed);

            // Then
            Debug.Assert(resultComma == expectedCommaResult);
            Debug.Assert(resultNewline == expectedNewlineResult);
            Debug.Assert(resultMixed == expectedMixedResult);
        }

        public static void GivenNegativeNumber_WhenCalculating_ThenThrowException()
        {
            try
            {
                // Given
                string input = "-3,4";

                // When
                Calculator.Calculate(input);

                // Then
                Debug.Assert(false, "Expected an exception to be thrown for negative numbers.");
            }
            catch (ArgumentException ex)
            {
                Debug.Assert(ex.Message == "Negative numbers are not allowed.");
            }
        }

        public static void GivenNumbersGreaterThan1000_WhenCalculating_ThenIgnoreThem()
        {
            // Given
            string input = "2,1001,6";
            int expectedResult = 8;

            // When
            var result = Calculator.Calculate(input);

            // Then
            Debug.Assert(result == expectedResult, $"Expected {expectedResult} but got {result}");
        }

        public static void GivenCustomDelimiter_WhenCalculating_ThenReturnSum()
        {
            // Given
            string input = "@@1@2@3";
            int expectedResult = 6;

            // When
            var result = Calculator.Calculate(input);

            // Then
            Debug.Assert(result == expectedResult, $"Expected {expectedResult} but got {result}");
        }

        public static void GivenMultiCharacterDelimiter_WhenCalculating_ThenReturnSum()
        {
            // Given
            string input = "[###]1###2###3";
            int expectedResult = 6;

            // When
            var result = Calculator.Calculate(input);

            // Then
            Debug.Assert(result == expectedResult, $"Expected {expectedResult} but got {result}");
        }
    }
}