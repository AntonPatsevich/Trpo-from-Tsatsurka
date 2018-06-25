using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitL
{
    class Program
    {
        static string[] lastdigit = new string[10]{ "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        static string[] allteen = new string[10] { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] allten = new string[10] { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string[] more = new string[6] { "", "Thousand", "Million", "Billion", "Trillion", "Quadrillion" };

        static string UnderHundred(int num)
        {
            string output = "";

            if (num >= 100)
            {
                output += lastdigit[num / 100] + " Hundred ";
                num %= 100;
            }

            if (num >= 11 && num <= 19)
            {
                output += allteen[num - 10] + " ";
            }
            else if (num >= 20 || num == 10)
            {
                output += allten[num / 10] + " ";
                num %= 10;
            }

            if (num >= 1 && num <= 9)
            {
                output += lastdigit[num] + " ";
            }

            return output;
        }

        static string TranslateNumber(long num)
        {
            if (num == 0)
            {
                return "Zero";
            }
            else if (num < 0)
            {
                return "Negative " + TranslateNumber(-1 * num);
            }
            int index = 0;
            string output = "";

            while (num > 0)
            {
                if (num % 1000 != 0)
                {
                    output = UnderHundred((int)(num % 1000)) + more[index] + " " + output;
                }
                num /= 1000;
                ++index;
            }

            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input the number: ");
            long num = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(TranslateNumber(num));
            Console.ReadKey();
        }
    }
}
