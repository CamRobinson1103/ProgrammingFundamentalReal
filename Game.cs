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
        void PrintStats(string name, float playerHealth, int damage, int level, string role)
        {

            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Player level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public void Run()
        {
            string newWord = CombineWords("Peanut", "butter");
            bool gameOver = false;
            while (gameOver == false)
            {
                //This variable is used to store health
                float playerHealth = 100.0f;
                //This value is used to heal player
                float healthRegen = 20;
                bool maxLevelReached = false;
                int damage = 20;
                int defence = 40;
                int level = 1;
                bool ready = true;
                int MP = 100;
                string role = "loser";


                //This is the welcome message
                Console.WriteLine("Hello, peasant. What dou art nameth?");
                string name = Console.ReadLine();

                //This is the class selection
                Console.WriteLine("Welcome " + name + " ! " + "Please select a class");
                Console.WriteLine("[1] Knight class");
                Console.WriteLine("[2] Wizard class");
                char input = ' ';
                Console.WriteLine();
                while (input != '1' && input != '2')
                {
                    input = Console.ReadKey().KeyChar;
                    if (input == '2')
                    {
                        playerHealth = 200;
                        role = "Knight";
                    }
                    else if (input == '1')
                    {
                        damage = 40;
                        role = "Wizard";
                        MP = 200;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }

                }


                //This is the Character Display
                Console.Clear();




                //First decision
                Console.WriteLine("You have been approached by a LOSER.");
                Console.WriteLine("They have offered you candy.");
                Console.WriteLine("Do you accept?");
                Console.WriteLine("[1] Yes");
                Console.WriteLine("[2] No");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    playerHealth = 0;
                    Console.WriteLine("You took the candy and die. You lose!!");
                    gameOver = true;
                    break;
                }
                else if (input == '2')
                {
                    Console.WriteLine("You didn't take the candy because you're not a LOSER! However, now he wants to kill you!");
                    //Battle Sequence
                    int loserHealth = 60;
                    int loserDamage = 25;
                    while (playerHealth > 0 && loserHealth > 0);
                    {
                        
                        //Enemy Stats
                        Console.WriteLine("\nLoser");
                        Console.WriteLine("Loser Health " + loserHealth);
                        Console.WriteLine("Loser Damage " + loserDamage);
                        Console.WriteLine("Loser Role: Candy Dandy");
                        Console.Write("MP: " + MP);
                        //Commands
                        Console.WriteLine("What is your Move?");
                        Console.WriteLine("[1] Attack");
                        Console.WriteLine("[2] Defend");
                        input = Console.ReadKey().KeyChar;
                        if (input == '1')
                        {
                            loserHealth -= damage;
                            Console.WriteLine("You slap their face with your gauntlet!");
                        }
                        else if (input == '2')
                        {
                            defence -= loserDamage;
                            Console.WriteLine("You raised your guard. Your shield took " + loserDamage + " damage");
                            Console.ReadKey();
                        }
                    }
                }


            }
            //for loop example
            Console.WriteLine("You approached a door. On it is a riddle. It says: How much wood could a woodchuck chuck if a woodchuck could chuck wood?");
            string guess = " ";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("You have " + (5 - i) + " tries remaining");
                guess = Console.ReadLine();
                if (guess == "Yes")
                {
                    Console.WriteLine("You have answered correctly! The door slowly opens.");
                    Console.ReadKey();
                    break;

                }
                else
                {
                    Console.WriteLine("You hear a loud buzzing noise. You figure it must mean you said the wrong answer.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }




            //Create ann application that gets the user's name along with an addititonal input.
            //Print the user's name and input to the console along With their stats.
            string color = "none";
            Console.WriteLine("Hello, and welcome to our organization. State your name.");
            string protag = Console.ReadLine();
            Console.WriteLine("Hello " + protag + "." + " Tell me your favorite weapon.");
            string weapon = Console.ReadLine();
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
            char select = ' ';
            Console.WriteLine();
            while (select != '1' && select != '2' && select != '3' && select != '4' && select != '5')
            {
                select = Console.ReadKey().KeyChar;
            }

            if (select == '1')
            {
                hit = 20;
                def = 10;
                spd = 10;
                mp = 10;
                hp = 10;
                color = "Red";
            }
            else if (select == '2')
            {
                hit = 10;
                def = 20;
                spd = 10;
                mp = 10;
                hp = 10;
                color = "Blue";
            }
            else if (select == '3')
            {
                hit = 10;
                def = 10;
                spd = 20;
                mp = 10;
                hp = 10;
                color = "Green";
            }
            else if (select == '4')
            {
                hit = 10;
                def = 10;
                spd = 10;
                mp = 20;
                hp = 10;
                color = "Yellow";
            }
            else if (select == '5')
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

            //Making play pick action
            while (select != '1' && select != '2' && select != '3')
            {
                select = Console.ReadKey().KeyChar;
                if (select == '1')
                {
                    Console.WriteLine("You punched the dummy in the head!");
                }
                else if (select == '2')
                {
                    Console.WriteLine("You kicked the dummy in the ribs!");
                }

                else if (select == '3')
                    Console.WriteLine("You hit the dummy with your " + weapon + " !");
            }
            //Dunny attacks
            Console.WriteLine("The Dummy retaliates! You took " + dummyDamage + " damage!");
            Console.Clear();
            //Second turn
            Console.WriteLine("[1] Punch");
            Console.WriteLine("[2] Kick");
            Console.WriteLine("[3] Use Weapon ");
            while (select != '1' && select != '2' && select != '3')
            {
                select = Console.ReadKey().KeyChar;
                if (select == '1')
                {
                    Console.WriteLine("You punched the dummy in the head! The dummy is defeated!");
                }
                else if (select == '2')
                {
                    Console.WriteLine("You kicked the dummy in the ribs! The dummy is defeated"!);
                }

                else if (select == '3')
                    Console.WriteLine("You hit the dummy with your " + weapon + " !" + "The dummy is defeated!");
            }
            Console.Write("Exellent job! You really let that dummy have it!");
        






        }










      
    }
}
