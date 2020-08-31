using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        string CombineWords(string word1, string word2)
        {
            string result = word1 + word2;
            return result;
        }
        int SumTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
    
        void ChangeName(string oldName, string newName)
        {
            oldName = newName;
        }
            void PrintStats(string name, float playerHealth, int damage, int level, string role)
            {
                Console.WriteLine("\nPlayer Name: " + name);
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("Player Damage: " + damage);
                Console.WriteLine("Player level: " + level);
                Console.WriteLine("Player Role: " + role);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            int GetPlayerInput(string context, string choice1, string choice2)
            {
                Console.WriteLine(context);
                char input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    Console.WriteLine(choice1);
                    return 1;

                }
                else if (input == '2')
                {
                    Console.WriteLine(choice2);
                    return 2;
                }
                return 0;
            }
            public void Run()
            {
                string newWord = CombineWords("Peanut", "butter");
                bool gameOver = false;
                while (gameOver == false)
                {
                    //Used to store player health
                    float playerHealth = 100.0f;
                    //Used to heal the player
                    float healthRegen = 20;
                    //Stores whether the max level has been reached
                    bool maxLevelReached = false;
                    //Used to store player damage
                    int damage = 20;
                    int defense = 40;
                    //Represents player's current level
                    int level = 1;
                    //Used to store player's current role
                    string role = "peasant";

                    //Prints welcome message
                    Console.WriteLine("Hello traveler! What is your name?");
                    string name = Console.ReadLine();

                    //Asks the player to select a role from the given options
                    Console.WriteLine("Welcome " + name + "! " + "Please select a role");
                Console.WriteLine("[1] Knight Role");
                Console.WriteLine("[2] Wizard Role");

                    //Gets input from console, and updates player values to reflect new role.
                    char input = ' ';
                    Console.WriteLine();
                    while (input != '1' && input != '2')
                    {
                        input = Console.ReadKey().KeyChar;
                        if (input == '1')
                        {
                            playerHealth = 200;
                            role = "Knight";
                        }
                        else if (input == '2')
                        {
                            damage = 40;
                            role = "Wizard";
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                    }


                    //Prints player stats to the screen
                    PrintStats(name, playerHealth, damage, level, role);
                    ChangeName(name, "New Name");
                    PrintStats(name, playerHealth, damage, level, role);
                    Console.Clear();


                    //First decision
                    Console.WriteLine("You've been approached by a LOSER.");
                    Console.WriteLine("They offer you some candy.");
                    Console.WriteLine("Do you accept?");
                    Console.WriteLine("[1] Yes");
                    Console.WriteLine("[2] No");
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        playerHealth = 0;
                        damage = 500;
                        Console.WriteLine("\nYou just ate! You lose!");
                        gameOver = true;
                        break;
                    }
                    else if (input == '2')
                    {
                        Console.Clear();
                        Console.WriteLine();
                    string context = "You decline because you're not a LOSER. However, they want to kill you now.";

                        //Initialize enemy stats
                        int travelerHealth = 60;
                        int travelerDamage = 25;
                        while (playerHealth > 0 && travelerHealth > 0)
                        {
                            //Display player and enemy stats
                            //Player stats:
                            Console.WriteLine("\nPlayer Name: " + name);
                            Console.WriteLine("Player Health: " + playerHealth);
                            Console.WriteLine("Player Damage: " + damage);
                            Console.WriteLine("Player Level: " + level);
                            Console.WriteLine("Player Role: " + role);
                            //Enemy stats:
                            Console.WriteLine("\nTraveler: ");
                            Console.WriteLine("Traveler Health: " + travelerHealth);
                            Console.WriteLine("Traveler Damage: " + travelerDamage);
                            Console.WriteLine("Traveler Role: Potion Seller");
                            //Get input from player
                            int choice = GetPlayerInput(context, "You hit them with a mean right hook. The traveler took " + damage + " damage", "You raised your guard. Your shield took " + travelerDamage + " damage");
                            if (choice == 1)
                            {
                                travelerHealth -= damage;
                            }
                            else if (choice == 2)
                            {
                                defense -= travelerDamage;
                                Console.ReadKey();
                                continue;
                            }
                            else if (input == '3')
                            {
                                Console.WriteLine("Your dog bit them");
                            }

                            playerHealth -= travelerDamage;
                            Console.WriteLine("They punched in your face. You took " + travelerDamage + " damage");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You kept awkwardly stuttering and fumbling over your words.");
                        Console.WriteLine("The traveler became annoyed and decided to walk away.");
                        Console.WriteLine("You can hear them call you a weirdo under their breath.");
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();


                    string guess = " ";

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("You approach a door. On it is a riddle. It says: How much wood could a woodchuck chuck if a woodchuck could chuck wood?");
                        Console.WriteLine("You have " + (5 - i) + " tries remaining");
                        guess = Console.ReadLine();
                        if (guess == "Yes")
                        {
                            Console.WriteLine("You have answered correctly! The door slowly opens");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You hear a loud buzzing noise. You figure it must mean you are wrong.");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }


                    //second decision
                    Console.WriteLine("You've come to a crossroad.");
                    Console.WriteLine("There's a sign. Do you read it?");
                    Console.WriteLine("Press 1 for yes");
                    Console.WriteLine("Press 2 for no");
                    input = Console.ReadKey().KeyChar;
                    string direction = "none";
                    if (input == '1')
                    {
                        Console.Clear();
                        Console.WriteLine("The sign reads: 'To the west are The Far Lands. To the east is Death's Garden'");
                        Console.WriteLine("Which direction do you choose?");
                        Console.WriteLine("Press 1 for east");
                        Console.WriteLine("Press 2 for west");
                        input = Console.ReadKey().KeyChar;
                        if (input == '1')
                        {
                            direction = "east";
                        }
                        else if (input == '2')
                        {
                            direction = "west";
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input");
                        }
                    }
                    else if (input == '2')
                    {
                        Console.Clear();
                        Console.WriteLine("You ignored the sign and decided to trust your " + role + " instincts instead");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear()
                        ;
                        if (role == "Wizard")
                        {
                            direction = "east";
                        }
                        else if (role == "Knight")
                        {
                            direction = "west";
                        }
                        else
                        {
                            direction = "west";
                        }
                    }
                    if (direction == "west")
                    {












                    //Create ann application that gets the user's name along with an addititonal input.
                    //Print the user's name and input to the console along With their stats.
                    string color = "none";
                    string weapon = "none";
                    void PrintStats(string name, float hp, int hit, int lv, string color)
                    {
                        Console.WriteLine("\nPlayer Name: " + name);
                        Console.WriteLine("Player Health: " + hp);
                        Console.WriteLine("Player Damage: " + hit);
                        Console.WriteLine("Player Lv: " + lv);
                        Console.WriteLine("Player Weapon: " + weapon);
                        Console.WriteLine("Player Color: " + color);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }

                    //Typing Name
                    Console.WriteLine("Hello, and welcome to our organization. State your name.");
                    string protag = Console.ReadLine();

                    //Selecting weapon
                    Console.WriteLine("Hello " + protag + "." + " Please select a weapon.");
                    Console.WriteLine("[1] Sword");
                    Console.WriteLine("[2] Gun");
                    Console.WriteLine("[3] Axe");
                    Console.WriteLine("[4] Bo Staff");
                    Console.WriteLine("[5] None");
                    char selectWeapon = ' ';
                    while (selectWeapon != '1' && selectWeapon != '2' && selectWeapon != '3' && selectWeapon != '4' && selectWeapon != '5')
                    {
                        selectWeapon = Console.ReadKey().KeyChar;
                    }

                    if (selectWeapon == '1')
                    {
                        weapon = "sword";
                    }
                    else if (selectWeapon == '2')
                    {
                        weapon = "gun";
                    }
                    else if (selectWeapon == '3')
                    {
                        weapon = "axe";
                    }
                    else if (selectWeapon =='4')
                    {
                        weapon = "bo staff";
                    }
                    else
                    {
                        weapon = "none";
                    }

                    int hit = 10;
                    int def = 10;
                    int spd = 10;
                    int mp = 10;
                    int hp = 10;

                    //Picking your color
                    Console.WriteLine("Pick one of these colors");
                    Console.WriteLine("[1] Red");
                    Console.WriteLine("[2] Blue");
                    Console.WriteLine("[3] Green");
                    Console.WriteLine("[4] Yellow");
                    Console.WriteLine("[5] Pink");
                    char selectColor = ' ';
                    Console.WriteLine();
                    while (selectColor != '1' && selectColor != '2' && selectColor != '3' && selectColor != '4' && selectColor != '5')
                    {
                        selectColor = Console.ReadKey().KeyChar;
                    }

                    if (selectColor == '1')
                    {
                        hit = 20;
                        def = 10;
                        spd = 10;
                        mp = 10;
                        hp = 10;
                        color = "Red";
                    }
                    else if (selectColor == '2')
                    {
                        hit = 10;
                        def = 20;
                        spd = 10;
                        mp = 10;
                        hp = 10;
                        color = "Blue";
                    }
                    else if (selectColor == '3')
                    {
                        hit = 10;
                        def = 10;
                        spd = 20;
                        mp = 10;
                        hp = 10;
                        color = "Green";
                    }
                    else if (selectColor == '4')
                    {
                        hit = 10;
                        def = 10;
                        spd = 10;
                        mp = 20;
                        hp = 10;
                        color = "Yellow";
                    }
                    else if (selectColor == '5')
                    {
                        hit = 10;
                        def = 10;
                        spd = 10;
                        mp = 10;
                        hp = 20;
                        color = "Pink";
                    }

                    Console.WriteLine("Player Name: " + protag);
                    Console.WriteLine("Player Weapon: " + weapon);
                    int lv = 1;
                    Console.WriteLine("Lv: " + lv);
                    bool maxLevelReached2 = false;
                    bool ready2 = true;
                    float health2 = 50.0f;
                    float health2Regen = 2;

                    Console.WriteLine("You have been selected for the Rescue Squadron! You have been asigned the color " + color + ". " + "Welcome to have you along " + "! ");
                    Console.WriteLine("Hopefully you have gotten your mutator. It may sound dangerous, but don't worry. This device will give you the power to save people! ");
                    Console.WriteLine("With your special power of " + color + ", " + "you will be a massive asset to the team! Now Let's get straight to training and see how good you are in combat!");
                    Console.Clear();
                    Console.WriteLine("A training dummy appeared before you. What is your first action?");
                    int dummyHealth = 6;
                    int dummyDamage = 2;
                    Console.WriteLine("[1] Punch");
                    Console.WriteLine("[2] Kick");
                    Console.WriteLine("[3] Use Weapon ");
                    char selectAction = ' ';

                    //Making play pick action
                    while (selectAction != '1' && selectAction != '2' && selectAction != '3')
                    {
                        selectAction = Console.ReadKey().KeyChar;
                        if (selectAction == '1')
                        {
                            Console.WriteLine("You punched the dummy in the head!");
                        }
                        else if (selectAction == '2')
                        {
                            Console.WriteLine("You kicked the dummy in the ribs!");
                        }

                        else if (selectAction == '3')
                            Console.WriteLine("You hit the dummy with your " + weapon + " !");
                    }
                    //Dunny attacks
                    Console.WriteLine("The Dummy retaliates! You took " + dummyDamage + " damage!");
                    Console.Clear();
                    //Second turn
                    Console.WriteLine("[1] Punch");
                    Console.WriteLine("[2] Kick");
                    Console.WriteLine("[3] Use Weapon ");
                    while (selectAction != '1' && selectAction != '2' && selectAction != '3')
                    {
                        selectAction = Console.ReadKey().KeyChar;
                        if (selectAction == '1')
                        {
                            Console.WriteLine("You punched the dummy in the head! The dummy is defeated!");
                        }
                        else if (selectAction == '2')
                        {
                            Console.WriteLine("You kicked the dummy in the ribs! The dummy is defeated"!);
                        }

                        else if (selectAction == '3')
                            Console.WriteLine("You hit the dummy with your " + weapon + " !" + "The dummy is defeated!");
                    }
                    Console.Write("Exellent job! You really let that dummy have it!");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();

                    //Rescue Exercise
                    Console.WriteLine("Now let's get on with the rescue exercise.");
                    Console.WriteLine("There is a monster wrecking havoc upon the city! It is your job to evacuate the people!");
                    Console.WriteLine("[1] F");




                }
            }

            }
        }
    }


