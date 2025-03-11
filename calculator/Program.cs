// See https://aka.ms/new-console-template for more information
//using Calculator_new;
using calculator;
using static System.Net.Mime.MediaTypeNames;


Console.WriteLine("Hello, World!");
calculator.Tests.GivenEmptyString_WhenCalculating_ThenReturnZero();
calculator.Tests.GivenSingleNumber_WhenCalculating_ThenReturnNumber();
calculator.Tests.GivenTwoNumbersSeparatedByComma_WhenCalculating_ThenReturnTheirSum();
calculator.Tests.GivenTwoNumbersSeparatedByNewline_WhenCalculating_ThenReturnTheirSum();
calculator.Tests.GivenThreeNumbersSeparatedByCommaOrNewline_WhenCalculating_ThenReturnTheirSum();
calculator.Tests.GivenNegativeNumber_WhenCalculating_ThenThrowException();
calculator.Tests.GivenNumbersGreaterThan1000_WhenCalculating_ThenIgnoreThem();
calculator.Tests.GivenCustomDelimiter_WhenCalculating_ThenReturnSum();
//calculator.Tests.GivenMultiCharacterDelimiter_WhenCalculating_ThenReturnSum();