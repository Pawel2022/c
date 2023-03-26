using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            bool q = true;
            if (x <= 1)
            {
                q = false;
            }
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    q = false;
                    break;
                }
            }
            Console.WriteLine($"Jest liczba pierwsza");
            Console.ReadKey();

        }

    }
}
