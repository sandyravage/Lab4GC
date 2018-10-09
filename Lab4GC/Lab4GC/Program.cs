using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4GC
{
    class Program
    {
        static void Main(string[] args)
        { 
            while (true)
            {
                long integer = 0;
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter an integer: ");
                try
                {
                    integer = long.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("How in the world do you square something that isn't a number, bro?");
                    continue;
                }
                catch(Exception)
                {
                    Console.WriteLine("Dude. Why.");
                    continue;
                }
                Console.WriteLine("Number   Squared   Cubed");
                Console.WriteLine("======   =======   =====");

                for (long i = 0; i <= integer; i++)
                {
                    Console.WriteLine("{0,-8:0} {1,-9:0} {2,-15:0}", i, i * i, i * i * i);
                }
            please:
                string Continue;
                Console.WriteLine("Continue? (y/n)");
                Continue = Console.ReadLine();
                if (Continue == "n")
                {
                    break;
                }
                else if (Continue == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Must you try my patience?");
                    goto please;
                }
            }
        }
    }
}
