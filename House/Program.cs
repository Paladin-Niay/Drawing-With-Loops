using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starsCnt = 2;

            if (n % 2 == 1)
            {
                Console.WriteLine(new string('-', n/2) + "*" + new string('-', n/2 ));
                starsCnt++;
            }
            for (int i = 0; i < n / 2; i++)
            {

                Console.Write(new string('-', n / 2 -1 -i));
                Console.Write(new string('*', starsCnt + 2 * i));
                Console.WriteLine(new string('-', n / 2 -1 -i));
            }

            for (int c = 0; c < n / 2; c++)
            {
                Console.WriteLine("|" + new string('*', n - 2) + "|");
            }
        }
    }
}
