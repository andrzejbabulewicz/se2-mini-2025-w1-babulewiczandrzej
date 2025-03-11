using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            char customDelimiter = ',';


            if (input.Length > 2 && input[0] == input[1])
            {
                customDelimiter = input[0];
                input = input.Substring(2);
            }



            var delimiters = new[] { customDelimiter, '\n' };
            var numbers = input.Split(delimiters, StringSplitOptions.None);
            int sum = 0;

            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int num))
                {
                    if (num < 0)
                    {
                        throw new ArgumentException("Negative numbers are not allowed.");
                    }
                    if (num <= 1000)
                    {
                        sum += num;
                    }
                }
            }

            return sum;
        }
    }


}

