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
                Console.WriteLine("WItaj w grze. Twoim celem będzie zebranie 1000 pkt rozwoju");
                Console.WriteLine("Wybiesz swoja klase");
                Console.WriteLine("Mag - 1 ||| Wojownik - 2");
                string inp = Console.ReadLine();
                if (inp == "1")
                {
                    int[] k = { 100, 35, 50, 30 };
                    return k;
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
            Console.WriteLine($"|||1 - udaj sie na walke ||| 2 - wydaj punkty rozwoju ||| 3 - czary");
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
                    Console.WriteLine("Umierasz");
                    break;
                }
                Thread.Sleep(900);
                Console.WriteLine($"Walka twoje_zycie {gracz[0]} dostjesz {pokemon[1]} bijesz {gracz[1]}");
            }
            gracz[3] += pokemon[3];
            return gracz;
        }
    }

    public class upgrade
    {
        public static int[] up(int[] postac)
        {
            Console.WriteLine("Co chcesz poprawic?");
            Console.WriteLine("1 - upgrade sily pkt 50 ||| 2 - woda swiecona pkt 50 ||| dowolny klawisz - koniec");

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


        public static int[] tesc(int[] postac)
        {
            if (postac[3] >= 50)
            {
                Console.WriteLine("Sila zwiekszyl sie o 5 wydajesz 50 pkt rozwoju");
                postac[3] -= 50;
                postac[1] += 3;
            }
            else
            {
                Console.WriteLine("Brak pkt rozwoju");
            }
            return postac;
        }

        public static int[] kremovka(int[] postac)
        {
            if (postac[3] >= 50)
            {
                Console.WriteLine("Twoja swieta moc zwieksza sie o 5 wydajesz 50 pkt rozwoju");
                postac[3] -= 50;
                postac[2] += 5;
            }
            else
            {
                Console.WriteLine("Brak pkt rozwoju");
            }
            return postac;
        }
    }
    internal class Magia
    {
        public static int[] czary(int[] postac, int maxhp, int maxmana)
        {
            Console.WriteLine("1 - leczenie,2 - bogactwo");
            string inp = Console.ReadLine();
            switch (inp)
            {
                case "1":
                    return leczenie(postac, maxhp, maxmana);
                case "2":
                    return bogactwo(postac, maxmana);
                default:
                    return postac;
            }
        }
        public static int[] leczenie(int[] postac, int maxhp, int maxmana)
        {
            if (postac[2] >= 25)
            {
                postac[0] = maxhp;
                postac[2] -= 50;
                Console.WriteLine("Jestes w pelni uleczony");
                return postac;
            }
            else
            {
                Console.WriteLine("Brak manny");
            }

            return postac;
        }
        public static int[] bogactwo(int[] postac, int maxmana)
        {
            if (postac[2] >= 50)
            {
                postac[3] += 250;
                postac[2] -= 50;
                Console.WriteLine("Dodano 250 pkt");
                return postac;
            }
            else
            {
                Console.WriteLine("Brak manny");
            }
            return postac;
        }
        internal class Wreszsciegra
        {
            static void Main(string[] args)
            {
                int[] postac = Postac.wyborpostaci();
                int tura = 0;

                int maxhp = postac[0];
                int maxmana = postac[2];

                while (Postac.czyzywy(postac))
                {
                    Informacja.informacje(postac, tura);
                    string inp = Console.ReadLine();
                    switch (inp)
                    {
                        case "1":
                            Console.WriteLine("Pojedynek");
                            Pokemony.akcja(postac);
                            break;
                        case "2":
                            upgrade.up(postac);
                            Console.WriteLine("Upgrade");
                            break;
                        case "3":
                            Console.WriteLine("Czary");
                            Magia.czary(postac,maxhp,maxmana);
                            break;
                        default:
                            Console.WriteLine("Taka komenda nie istnieje");
                            break;
                    }
                    tura += 1;
                    if (postac[3] > 500)
                    {
                        Console.WriteLine("Gratulacje!!! Ukonczyles ta wspaniala gre");
                        Console.WriteLine("Zachecam do ponownego zagrania");
                        Console.ReadKey();
                    }
                }

                Console.WriteLine("Zgnieło Ci się");
                Console.WriteLine($"Twoje wyniki to: pkt rozwoju {postac[3]}, tury {tura}");
                Console.ReadKey();
            }
        }

    }
}