using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project
{

    internal class Character
    {
        public static void DisplayMortalKombatLogo()
        {
            Console.WriteLine(" _    _   ____   ____  _____   __     _");
            Console.WriteLine("|  \\/  | /    \\ | _  \\|__ __| /_ \\   | |");
            Console.WriteLine("| |\\/| ||  /\\  || - _/  | |  //_\\ \\  | |");
            Console.WriteLine("| |  | ||  \\/  ||   \\   | | / ___  \\ | |__");
            Console.WriteLine("|_|  |_| \\____/ |_|\\_\\  |_|/_/   \\__\\|____|");
        }
        public static void Komb()
        {
            Console.WriteLine(" _  __  ____   _    _  ____     __    _____");
            Console.WriteLine("| |/ / /    \\ |  \\/  || _  \\   /_ \\  |__ __|");
            Console.WriteLine("|   / |  /\\  || |\\/| || - _/  //_\\ \\   | |");
            Console.WriteLine("|   \\ |  \\/  || |  | || _  \\ / ___  \\  | |");
            Console.WriteLine("|_|\\_\\ \\____/ |_|  |_||____//_/   \\__\\ |_|");
        }
        public static void II()
        {
            Console.WriteLine("________    ________");
            Console.WriteLine("  |  |        |  |");
            Console.WriteLine("  |  |        |  |");
            Console.WriteLine("  |  |        |  |");
            Console.WriteLine("  |  |        |  |");
            Console.WriteLine("--------    --------");
        }

        internal class CharacterSelection
        {
            public static int ChooseCharacter()
            {
                Console.WriteLine("Choose your character:");
                Console.WriteLine("_____________________________________________________________________");
                Console.WriteLine("|             |              |               |            |            |");
                Console.WriteLine("|1 - Sub-Zero | 2 - Scorpion | 3 - Liu Kang  | 4 - Raiden | 5 - Kitana |");
                Console.WriteLine("|             |              |               |            |            |");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("|             |            |             |                 |          |");
                Console.WriteLine("| 6 - Mileena | 7 - Baraka | 8 - Sindel  | 9 - Shang Tsung | 10 - Kan |");
                Console.WriteLine("|             |            |             |                 |          |");
                Console.WriteLine("----------------------------------------------------------------------");

                while (true)
                {
                    int choice;
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        if (choice == 1)
                        {
                            Console.WriteLine("\tYou chose Sub-Zero!");
                            return 1;
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("\tYou chose Scorpion!");
                            return 2;
                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine("\tYou chose Liu Kang!");
                            return 3;
                        }
                        else if (choice == 4)
                        {
                            Console.WriteLine("\tYou chose Raiden!");
                            return 4;
                        }
                        else if (choice == 5)
                        {
                            Console.WriteLine("\tYou chose Kitana!");
                            return 5;
                        }
                        else if (choice == 6)
                        {
                            Console.WriteLine("\tYou chose Mileena!");
                            return 6;
                        }
                        else if (choice == 7)
                        {
                            Console.WriteLine("\tYou chose Baraka!");
                            return 7;
                        }
                        else if (choice == 8)
                        {
                            Console.WriteLine("\tYou chose Sindel!");
                            return 8;
                        }
                        else if (choice == 9)
                        {
                            Console.WriteLine("\tYou chose Shang Tsung!");
                            return 9;
                        }
                        else if (choice == 10)
                        {
                            Console.WriteLine("\tYou chose Kano!");
                            return 10;
                        }
                        else
                        {
                            Console.WriteLine("You chose the wrong button.");
                            HandleInvalidChoice();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
            }
            private static void HandleInvalidChoice()
            {
                Console.WriteLine("The selected function does not exist.");
            }
        }

        internal class Enemy
        {
            public static string GetRandomEnemy()
            {
                Random random = new Random();
                int enemyNumber = random.Next(1, 11);

                if (enemyNumber == 1)
                {
                    return "Mileena";
                }
                else if (enemyNumber == 2)
                {
                    return "Baraka";
                }
                else if (enemyNumber == 3)
                {
                    return "Sindel";
                }
                else if (enemyNumber == 4)
                {
                    return "Raiden";
                }
                else if (enemyNumber == 5)
                {
                    return "Kitana";
                }
                else if (enemyNumber == 6)
                {
                    return "Sub-Zero";
                }
                else if (enemyNumber == 7)
                {
                    return "Scorpion";
                }
                else if (enemyNumber == 8)
                {
                    return "Liu Kang";
                }
                else if (enemyNumber == 9)
                {
                    return "Shang Tsung";
                }
                else
                {
                    return "Kano";
                }
            }
        }


        internal class Battle
        {
            public static void Fight(int characterChoice, int round, ref int[] rounds)
            {
                string enemyName = Enemy.GetRandomEnemy();
                Console.WriteLine($"You're fighting with {enemyName}.");

                while (round < 3)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"\tRound {round + 1}");
                    Thread.Sleep(1000);
                    Console.WriteLine("\tFIGHT!");

                    Thread.Sleep(1000);
                    Console.WriteLine("\tChoose your attack.");
                    Console.WriteLine("1 - basic attack | 2 - special ability | 3 - Power Strike");


                    int[] player = { 100, 0 };
                    int[] enemy = { 100, 0 };
                    Random random = new Random();

                    while (enemy[0] > 0 && player[0] > 0)
                    {
                        while (true)
                        {
                            int choice = int.Parse(Console.ReadLine());

                            if (choice == 1)
                            {
                                int playerDamage = random.Next(10, 20);
                                int playerChargingPoints = random.Next(20, 30);
                                int enemyChargingPoints = random.Next(20, 30);

                                enemy[0] -= playerDamage;
                                enemy[1] += enemyChargingPoints;
                                player[1] += playerChargingPoints;
                                Console.WriteLine($"Your health: {player[0]}, Enemy's health: {enemy[0]}, Your charging points: {player[1]}");
                                break;
                            }
                            else if (choice == 2 && player[1] >= 100)
                            {
                                int specialAbilityDamage = random.Next(35, 45);
                                int enemyChargingPoints = random.Next(20, 30);

                                enemy[0] -= specialAbilityDamage;
                                enemy[1] += enemyChargingPoints;
                                player[1] = 0;
                                Thread.Sleep(1000);
                                Console.WriteLine("You used your special ability!");
                                Thread.Sleep(1000);
                                Console.WriteLine($"Your health: {player[0]}, Enemy's health: {enemy[0]}, Your charging points: {player[1]}");
                                break;
                            }
                            else if (characterChoice == 3 && choice == 3 && player[1] >= 50)
                            {
                                int fireballDamage = random.Next(15, 25);
                                int enemyChargingPoints = random.Next(20, 30);

                                enemy[0] -= fireballDamage;
                                enemy[1] += enemyChargingPoints;
                                player[1] -= 50;
                                Thread.Sleep(1000);
                                Console.WriteLine("Liu Kang used Fireball!");
                                Thread.Sleep(1000);
                                Console.WriteLine($"Your health: {player[0]}, Enemy's health: {enemy[0]}, Your charging points: {player[1]}");
                                break;
                            }
                            else if (characterChoice == 1 && choice == 3 && player[1] >= 50)
                            {
                                int iceBlastDamage = random.Next(15, 25);
                                int enemyChargingPoints = random.Next(20, 30);

                                enemy[0] -= iceBlastDamage;
                                enemy[1] += enemyChargingPoints;
                                player[1] -= 50;
                                Thread.Sleep(1000);
                                Console.WriteLine("Sub-Zero used Ice Blast!");
                                Thread.Sleep(1000);
                                Console.WriteLine($"Your health: {player[0]}, Enemy's health: {enemy[0]}, Your charging points: {player[1]}");
                                break;
                            }

                            else if (choice == 3 && player[1] >= 50)
                            {
                                int powerStrikeDamage = random.Next(25, 35);
                                int enemyChargingPoints = random.Next(20, 30);

                                enemy[0] -= powerStrikeDamage;
                                enemy[1] += enemyChargingPoints;
                                player[1] -= 50;
                                Thread.Sleep(1000);
                                Console.WriteLine("You used Power Strike!");
                                Thread.Sleep(1000);
                                Console.WriteLine($"Your health: {player[0]}, Enemy's health: {enemy[0]}, Your charging points: {player[1]}");
                                break;
                            }

                            else
                            {
                                Console.WriteLine("You don't have enough points to use this ability.");
                            }
                        }

                        if (enemy[0] <= 0)
                        {
                            rounds[0] += 1;
                            round += 1;
                            Console.WriteLine($"{rounds[0]} : {rounds[1]}");
                            break;
                        }
                        else if (player[0] <= 0)
                        {
                            rounds[1] += 1;
                            round += 1;
                            Console.WriteLine($"{rounds[0]} : {rounds[1]}");
                            break;
                        }

                        Thread.Sleep(1000);
                        Console.WriteLine("Enemy's turn.");
                        Thread.Sleep(1000);

                        while (true)
                        {
                            int enemyChoice = random.Next(1, 3);

                            if (enemyChoice == 1)
                            {
                                int enemyDamage = random.Next(10, 20);
                                int playerChargingPoints = random.Next(20, 30);
                                int enemyChargingPoints = random.Next(20, 30);

                                player[0] -= enemyDamage;
                                player[1] += playerChargingPoints;
                                enemy[1] += enemyChargingPoints;
                                Console.WriteLine($"Your health: {player[0]}, Enemy's health: {enemy[0]}, Your charging points: {player[1]}");
                                break;
                            }
                            else if (enemyChoice == 2 && enemy[1] >= 100)
                            {
                                int playerChargingPoints = random.Next(20, 30);
                                int specialAbilityDamage = random.Next(35, 45);

                                player[0] -= specialAbilityDamage;
                                player[1] += playerChargingPoints;
                                enemy[1] = 0;
                                Thread.Sleep(1000);
                                Console.WriteLine("Enemy used special ability!");
                                Thread.Sleep(1000);
                                Console.WriteLine($"Your health: {player[0]}, Enemy's health: {enemy[0]}, Your charging points: {player[1]}");
                                break;
                            }
                        }

                        if (enemy[0] <= 0)
                        {
                            rounds[0] += 1;
                            round += 1;
                            Console.WriteLine($"{rounds[0]} : {rounds[1]}");
                            break;
                        }
                        else if (player[0] <= 0)
                        {
                            rounds[1] += 1;
                            round += 1;
                            Console.WriteLine($"{rounds[0]} : {rounds[1]}");
                            break;
                        }
                    }
                }

                if (rounds[0] > rounds[1])
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("YOU WON!");
                    Thread.Sleep(1000);
                }
            }
        }
        internal class GameMenu
        {
            public static int ShowMenu()
            {
                Console.WriteLine("Game Over");
                Console.WriteLine("1 - Play Again");
                Console.WriteLine("2 - Exit");

                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        if (choice == 1)
                        {
                            return 1; // Wybór ponownej rozgrywki
                        }
                        else if (choice == 2)
                        {
                            return 2; // Wyjście z gry
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please enter 1 to play again or 2 to exit.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number (1 or 2).");
                    }
                }
            }
        }
        internal class GameDifficulty
        {
            public static int ChooseDifficulty()
            {
                Console.WriteLine("Choose the game difficulty:");
                Console.WriteLine("1 - Easy");
                Console.WriteLine("2 - Normal");
                Console.WriteLine("3 - Hard");

                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        if (choice >= 1 && choice <= 3)
                        {
                            return choice;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please enter 1 for Easy, 2 for Normal, or 3 for Hard.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number (1, 2, or 3).");
                    }
                }
            }
        }
    }
    namespace project
    {
        internal class MultiplayerBattle
        {
            public static void MultiplayerFight(int[] characterChoices, int round, ref int[] rounds)
            {
                string[] playerNames = new string[2];
                for (int i = 0; i < 2; i++)
                {
                    Console.Write($"Enter the name for Player {i + 1}: ");
                    playerNames[i] = Console.ReadLine();
                }

                Console.WriteLine($"Player 1: {playerNames[0]} vs. Player 2: {playerNames[1]}");

                while (round < 3)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"\tRound {round + 1}");
                    Thread.Sleep(1000);
                    Console.WriteLine("\tFIGHT!");

                    Thread.Sleep(1000);
                    Console.WriteLine("\tChoose your attack.");
                    Console.WriteLine("1 - basic attack | 2 - special ability | 3 - Power Strike");

                    int[][] players = new int[2][];
                    for (int i = 0; i < 2; i++)
                    {
                        players[i] = new int[] { 100, 0 };
                    }

                    Random random = new Random();

                    while (players[0][0] > 0 && players[1][0] > 0)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            while (true)
                            {
                                int choice = int.Parse(Console.ReadLine());

                                if (choice == 1)
                                {
                                    int playerDamage = random.Next(10, 20);
                                    int playerChargingPoints = random.Next(20, 30);

                                    players[1 - i][0] -= playerDamage;
                                    players[i][1] += playerChargingPoints;

                                    Console.WriteLine($"{playerNames[i]}'s health: {players[i][0]}, {playerNames[1 - i]}'s health: {players[1 - i][0]}, {playerNames[i]}'s charging points: {players[i][1]}");
                                    break;
                                }
                                else if (choice == 2 && players[i][1] >= 100)
                                {
                                    int specialAbilityDamage = random.Next(35, 45);

                                    players[1 - i][0] -= specialAbilityDamage;
                                    players[i][1] = 0;

                                    Console.WriteLine($"{playerNames[i]} used special ability!");
                                    Console.WriteLine($"{playerNames[i]}'s health: {players[i][0]}, {playerNames[1 - i]}'s health: {players[1 - i][0]}, {playerNames[i]}'s charging points: {players[i][1]}");
                                    break;
                                }
                                else if (choice == 3 && players[i][1] >= 50)
                                {
                                    int powerStrikeDamage = random.Next(25, 35);

                                    players[1 - i][0] -= powerStrikeDamage;
                                    players[i][1] -= 50;

                                    Console.WriteLine($"{playerNames[i]} used Power Strike!");
                                    Console.WriteLine($"{playerNames[i]}'s health: {players[i][0]}, {playerNames[1 - i]}'s health: {players[1 - i][0]}, {playerNames[i]}'s charging points: {players[i][1]}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"{playerNames[i]} doesn't have enough points to use this ability.");
                                }
                            }
                        }

                        if (players[0][0] <= 0)
                        {
                            rounds[1]++;
                            round++;
                            Console.WriteLine($"{playerNames[1]} wins the round!");
                            Console.WriteLine($"{rounds[0]} : {rounds[1]}");
                            break;
                        }
                        else if (players[1][0] <= 0)
                        {
                            rounds[0]++;
                            round++;
                            Console.WriteLine($"{playerNames[0]} wins the round!");
                            Console.WriteLine($"{rounds[0]} : {rounds[1]}");
                            break;
                        }
                    }
                }

                if (rounds[0] > rounds[1])
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"{playerNames[0]} WINS!");
                    Thread.Sleep(1000);
                }
                else if (rounds[0] < rounds[1])
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"{playerNames[1]} WINS!");
                    Thread.Sleep(1000);
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("It's a DRAW!");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
