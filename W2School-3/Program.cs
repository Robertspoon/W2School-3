using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2School_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Bitches = false;
            bool mentallyIll = true;
            int x = 63;
            int y = 727;
            string result = (x < 23) ? "I need immediate medical atention." : "You suck dick :3.";

            //Console.WriteLine("Enter your name: ");
           // string Name = Console.ReadLine();
           // Console.WriteLine("Your lame ass name: " + Name);
           // Console.ReadKey(true);

            Console.WriteLine("Do i get bitches?: " + Bitches);
            Console.WriteLine("Am i mentally ill?: " + mentallyIll);
            Console.WriteLine(x < y);
            Console.WriteLine(y == 727);
            Console.WriteLine(y == 728);


            // if/else/else if statements

           // if (x > y)
            {
            //  Console.WriteLine("I need immediate medical atention");
            }
           // else if (x < 727)
            {
           //   Console.WriteLine("I hate you die :)");
            }
           //else
            {
            //  Console.WriteLine("You suck dick :3");
            }

            Console.WriteLine(result);


            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the weekend!");
                    break;
            }

            

            Console.ReadKey(true);

        }
    }
}
