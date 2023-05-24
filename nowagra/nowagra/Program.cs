using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nowagra
{
    internal class Postac
    {

        public static int[] wyborpostaci()
        {
            while (true)
            {
                Console.WriteLine("Rydzyk - 1 ||| Dres - 2");
                string inp = Console.ReadLine();
                if (inp == "1")
                {
                    int[] m = { 100, 50, 400, 30 };
                    return m;
                }
                else if (inp == "2")
                {
                    int[] w = { 150, 35, 0, 30 };
                    return w;
                }
                else
                {
                    Console.WriteLine("Brak takiej klasy");
                }
            }
        }
        public static bool czyzywy(int[] postac)
        {
            if (postac[0] <= 0)
                return false;
            return true;
        }
    }

    internal class Informacja
    {
        public static void informacje(int[] postac, int staty)
        {
            Console.WriteLine($"wynik - {staty}");
            Console.WriteLine($"Twoje życie {postac[0]} atak {postac[1]} mana {postac[2]}  punkt_rozwoju {postac[3]}");
            Console.WriteLine($"|||1 - udaj sie na walke ||| 2 - wydaj punkty rozwoju |||");
            Thread.Sleep(900);
        }
    }

    internal class Pokemony
    {

        public static int[] generatorzlotetarasy()
        {
            Random rnd = new Random();
            int[] nowypoke = new int[4];
            for (int i = 0; i < nowypoke.Length; i++)
            {
                nowypoke[i] = rnd.Next(20, 30);
            }
            return nowypoke;
        }
        public static int[] akcja(int[] gracz)
        {
            Console.WriteLine("Spotykasz stwora");
            int[] pokemon = generatorzlotetarasy();
            while (pokemon[0] > 0)
            {
                gracz[0] -= pokemon[1];
                pokemon[0] -= gracz[1];
                if (gracz[0] <= 0)
                {
                    Console.WriteLine("Wywalasz się z rowerka");
                    break;
                }
                Thread.Sleep(900);
                Console.WriteLine($"Walka twoje_zycie {gracz[0]} dostjesz {pokemon[1]} bijesz {gracz[1]}");
            }
            gracz[3] += pokemon[3];
            return gracz;
        }
    }

    internal class Wreszsciegra
    {
        static void Main(string[] args)
        {
            int[] character = Postac.wyborpostaci();
            int round = 0;

            int maxhp = character[0];
            int maxmana = character[2];

            while (Postac.czyzywy(character))
            {
                Informacja.informacje(character, round);
                string inp = Console.ReadLine();
                switch (inp)
                {
                    case "1":
                        Console.WriteLine("Pojedynek");
                        Pokemony.akcja(character);
                        break;
                    case "2":
                        upgrade.up(character);
                        Console.WriteLine("Upgrade");
                        break;
                    default:
                        Console.WriteLine("Taka komenda nie istnieje");
                        break;
                }
                round += 1;
            }

            Console.WriteLine("Zgnieło Ci się");
            Console.ReadKey();
        }
    }

    public class upgrade
    {
        public static int[] up(int[] postac)
        {
            Console.WriteLine("C chcesz poprawic?");
            Console.WriteLine("1 - upgrade sily pkt ||| 2 - woda swiecona pkt ||| dowolny klawisz - koniec");

            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return tesc(postac);
                case 2:
                    return kremovka(postac);
            }
            Console.WriteLine("Kończe ulepszanie");
            return postac;
        }


        public static int[] tesc(int[] character)
        {
            if (character[3] >= 50)
            {
                Console.WriteLine("Sila zwiekszyl sie o 5 wydajesz 50 pkt rozwoju");
                character[3] -= 50;
                character[1] += 3;
            }
            else
            {
                Console.WriteLine("Brak pkt rozwoju");
            }
            return character;
        }

        public static int[] kremovka(int[] character)
        {
            if (character[3] >= 50)
            {
                Console.WriteLine("Twoja swieta moc zwieksza sie o 5 wydajesz 50 pkt rozwoju");
                character[3] -= 50;
                character[2] += 5;
            }
            else
            {
                Console.WriteLine("Brak pkt rozwoju");
            }
            return character;
        }
    }


}