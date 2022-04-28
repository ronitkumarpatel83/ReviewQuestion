using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic_Number
{
    internal class Program
    {
        public static void HarmonicNumber()
        {
            Console.WriteLine("Welcome to Harmonic Number Program");
            Console.WriteLine("Please enter the range : ");
            int range = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (int i = 1; i < range; i++)
            {
                result = (1/(Convert.ToDouble(i)));
                if(i == range)
                {
                    Console.WriteLine($"1/{i} = ");
                }
                else
                {
                    Console.WriteLine($"1/{i} + ");
                }
            }
            Console.WriteLine("The sum is = " + result);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program.HarmonicNumber();
        }
    }
}
