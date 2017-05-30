using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var space = n - 1;
            var spacePlus = 1;

            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(new string(' ', space));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                space--;
            }

            for (int c = n - 1; c >= 0; c--)
            {
                Console.Write(new string(' ', spacePlus));
                for (int f = 0; f < c; f++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                spacePlus++;
            }
        }
    }
}
