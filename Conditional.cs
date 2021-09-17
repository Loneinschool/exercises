using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    public class Conditional
    {
        //opgave 1
        public int absoluteValue(int number)
        {
            if (number < 0)
            {
                return number * -1;
            } 
            else
            {
                return number;
            }
            //return Math.Abs(number);
            
        }

        //Opgave 2

        public int divisibleBy2Or3(int input1, int input2)
        {
            if ((input1 % 2 == 0 || input1 % 3 == 0) && (input2 % 2 == 0 || input2 % 3 == 0))
            {
                return input1 * input2;
            }
            else
            {
                return input1 + input2;
            }
        } 

        //Opgave 3
        public bool ifYearIsLeap(int year)
        {
            return DateTime.IsLeapYear(year);
            // Eller bare year % 4 == 0 i guessssss
        }

        //Opgave 4
        public bool isLonelyIsland(string msg)
        {
            // you wish
            return false;
        }

        //Opgave 5
        public bool ifConsistsOfUppercaseLetters(string msg)
        {
            if (msg.All(char.IsUpper))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Opgave 6
        public bool checkIfCountains3(int number)
        {
            while (number > 0)
            {
                if (number % 10 == 3)
                {
                    return true;
                }
                number = number / 10;
            }
            return false;
        }

    }
}
