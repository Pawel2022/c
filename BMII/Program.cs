using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Waga = kg");
            double waga = double.Parse(Console.ReadLine());
            Console.WriteLine("Wzrost = cm");
            double wzrost = double.Parse(Console.ReadLine());
            switch (waga, wzrost) {
        }
            double BMI = waga / wzrost * wzrost;
            if (16 > BMI)
            {
                Console.WriteLine($"{BMI} wygłodzenie");
            }
            else if (16 <= BMI && BMI <= 16.99)
            {
                Console.WriteLine($"{BMI} wychudzenie");
            }
            else if (17 <= BMI && BMI <= 18.49)
            {
                Console.WriteLine($"{BMI} niedowaga");
            }
            else if (18.5 <= BMI && BMI <= 24.99)
            {
                Console.WriteLine($"{BMI} prawidłowa waga");
            }
            else if (25 <= BMI && BMI <= 29.99)
            {
                Console.WriteLine($"{BMI} nadwaga");
            }
            else if (30 <= BMI && BMI <= 34.99)
            {
                Console.WriteLine($"{BMI} I stopień otyłości");
            }
            else if (35 <= BMI && BMI <= 39.99)
            {
                Console.WriteLine($"{BMI} II stopień otyłości");
            }
            else if (40 <= BMI)
            {
                Console.WriteLine($"{BMI}  otyłość skrajna");
            }
            Console.ReadKey();
        }

        }
    }
