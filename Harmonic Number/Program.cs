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
           if (range == 0|| range < 0)
            {
                Console.WriteLine("Please enter non-zero number");
            }
            else
            {
                float result = 0;
                int n = range;
                for(float a = 1;a <= range; a++)
                {
                    result = result + 1 / a;
                    Console.WriteLine($"1/{a} + ");
                }
                Console.WriteLine("Harmonic Number upto the range "+ n +" is :" + result);
                        
            }
            

        }
        static void Main(string[] args)
        {
            Program.HarmonicNumber();
        }
    }
}
