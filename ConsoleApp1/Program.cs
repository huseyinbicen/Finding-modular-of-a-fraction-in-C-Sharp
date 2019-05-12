using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// The problem is what is the result of 77/9 % 17 = ??  
        /// So, 77/9 Mod 17 = ??
        /// Numerator = 77
        /// Denominator = 9
        /// Mod = 17
        /// </summary>
        static void Main(string[] args)
        {
            
            Console.WriteLine(FractionalMod(77, 9, 17)); 
            Console.ReadKey();
        }

        public static int FractionalMod(int Numerator, int Denominator, int Mod)
        {
            int r = 0;
            
            for (int i = 1; i < 100; i++)
            {
                if ((Numerator + i * Mod)%Denominator == 0)
                {
                    Numerator += i * Mod;
                    Console.WriteLine("Value of i = " + i);
                    break;
                }
            }
            Numerator /= Denominator;
            r = Numerator % Mod;
            return r;
        }
    }
}
