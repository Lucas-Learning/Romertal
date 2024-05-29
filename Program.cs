using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Romertal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input;
                Console.WriteLine("1-Rom til Int\n2-Int til Rom\n3-Quit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Skriv et romartal");
                        string roman1 = Console.ReadLine().ToUpper();
                        Console.WriteLine(Roman.RomanToInteger(roman1));
                        break;
                    case "2":
                        Console.WriteLine("Skriv et tal");
                        string str1 = Console.ReadLine();
                        int tal1 = Convert.ToInt32(str1);
                        Console.WriteLine(Roman.ToRoman(tal1));
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
