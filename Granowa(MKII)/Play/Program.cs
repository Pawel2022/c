using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using project.project;
using static project.Character;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to");
            Thread.Sleep(1000);
            Character.DisplayMortalKombatLogo();
            Thread.Sleep(1000);
            Character.Komb();
            Thread.Sleep(1000);
            Character.II();

            int numPlayers = 1; // Domyślnie ustawiamy tryb singleplayer
            int[] characterChoices = new int[numPlayers];
            int round = 0;
            int[] rounds = { 0, 0 };

            Console.WriteLine("Choose game mode:");
            Console.WriteLine("1 - Singleplayer");
            Console.WriteLine("2 - Multiplayer");

            int gameModeChoice;
            if (int.TryParse(Console.ReadLine(), out gameModeChoice))
            {
                if (gameModeChoice == 2)
                {
                    numPlayers = 2; // Jeśli wybrano multiplayer, ustawiamy liczbę graczy na 2
                    characterChoices = new int[numPlayers];

                    for (int i = 0; i < numPlayers; i++)
                    {

                        characterChoices[i] = CharacterSelection.ChooseCharacter();
                    }

                    while (true)
                    {
                        MultiplayerBattle.MultiplayerFight(characterChoices, round, ref rounds);
                        rounds[0] = 0;
                        rounds[1] = 0;

                        Console.WriteLine("Want to play again? 1 - yes, 2 - no.");
                        int choice = int.Parse(Console.ReadLine());

                        if (choice == 2)
                        {
                            Console.WriteLine("Thank you for playing multiplayer.");
                            break;
                        }
                    }
                }
                else if (gameModeChoice == 1)
                {
                    characterChoices[0] = CharacterSelection.ChooseCharacter();

                    while (true)
                    {
                        Battle.Fight(characterChoices[0], round, ref rounds);
                        rounds[0] = 0;
                        rounds[1] = 0;

                        Console.WriteLine("Want to play again? 1 - yes, 2 - no.");
                        int choice = int.Parse(Console.ReadLine());

                        if (choice == 2)
                        {
                            Console.WriteLine("Thank you for playing singleplayer.");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1 for Singleplayer or 2 for Multiplayer.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number (1 or 2).");
            }
        }
    }
}

