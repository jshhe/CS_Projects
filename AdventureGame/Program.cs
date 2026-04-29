using System;

namespace TextAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAppRunning = true;
            Random random = new Random();

            while (isAppRunning)
            {
                int health = 100;
                bool hasKey = false;
                bool hasMap = false;
                bool isCurrentGameActive = true;

                Console.WriteLine("Game Starts");

                while (isCurrentGameActive)
                {
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1. Enter Forest");
                    Console.WriteLine("2. Go To Beach");
                    Console.WriteLine("3. Check Inventory");
                    
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("\nYou entered the Forest.");
                        Console.WriteLine("Monkey Attack!");

                        int damage = random.Next(10, 41);
                        health = health - damage;
                        
                        Console.WriteLine($"You took {damage} damage! Current Health: {health}");

                        if (health <= 0)
                        {
                            Console.WriteLine("\nGame Over");
                            Console.WriteLine("Try again? (Y/N)");
                            string retry = Console.ReadLine().ToUpper();

                            if (retry == "Y" || retry == "YES")
                            {
                                isCurrentGameActive = false; 
                            }
                            else if (retry == "N" || retry == "NO")
                            {

                                isCurrentGameActive = false;
                                isAppRunning = false;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid input. Exiting game.");
                                isCurrentGameActive = false;
                                isAppRunning = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou survived the attack. What is your next move?");
                            Console.WriteLine("1. Hide in Cave");
                            Console.WriteLine("2. Player Attack");
                            
                            string forestAction = Console.ReadLine();

                            if (forestAction == "1")
                            {
                                Console.WriteLine("\nHide in Cave, Found a Key, Added to the Inventory.");
                                hasKey = true;
                            }
                            else if (forestAction == "2")
                            {
                                Console.WriteLine("\nPlayer Attack, Monkey drops the Map, Added to the Inventory.");
                                hasMap = true;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid choice. You did nothing and walked away.");
                            }
                        }
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("\nGo To Beach, Found a locked Chest.");

                        if (hasKey == true)
                        {
                            Console.WriteLine("\nYou used the Key to open the chest.");
                            Console.WriteLine("You Win!");
                            isCurrentGameActive = false;
                            isAppRunning = false;
                        }
                        else if (hasKey == false)
                        {
                            Console.WriteLine("\nYou don't have a key to open this chest. Returning back.");
                        }
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("\nChecking Inventory:");
                        
                        if (hasKey == false && hasMap == false)
                        {
                            Console.WriteLine("Your inventory is empty.");
                        }
                        
                        if (hasKey == true)
                        {
                            Console.WriteLine("Item: Key");
                        }
                        
                        if (hasMap == true)
                        {
                            Console.WriteLine("Item: Map (No actual use in this adventure)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid choice. Please enter 1, 2, or 3.");
                    }
                }
            }

            Console.WriteLine("\nExit");
        }
    }
}