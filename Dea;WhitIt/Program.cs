using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dea_WhitIt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', 2 * n) + 
                new string(' ', n) + new string ('*', 2 * n));
            char specialSymbol = ' ';
            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 1) / 2 - 1)
                {
                    specialSymbol = '|';
                }

                Console.Write("*" + new string('/', 2 * n - 2) + "*");
                Console.Write(new string(specialSymbol, n));
                Console.WriteLine("*" + new string('/', 2 * n - 2) + "*");
                specialSymbol = ' ';
            }

            Console.WriteLine(new string('*', 2 * n) +
                new string(' ', n) + new string('*', 2 * n));
            
        }
    }
}
