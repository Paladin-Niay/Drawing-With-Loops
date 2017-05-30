using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var space = n + 1;
            
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ', space));
                for (int j = 0; j < i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                space--;
            }
        }
    }
}
