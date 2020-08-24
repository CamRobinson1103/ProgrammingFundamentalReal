using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
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
                Console.WriteLine("Press 1 for Knight class");
                Console.WriteLine("Press 2 for Wizard class");
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
                Console.WriteLine("They have offered you 'candy.' ");
                Console.WriteLine("Dou you accept?");
                Console.WriteLine("Press 1 for yes");
                Console.WriteLine("Press 2 for no");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    playerHealth = 0;
                    damage = 500;
                    Console.WriteLine("You took the candy and dies. You lose!!");
                    gameOver = true;
                    break;
                }
                else if (input == '2')
                {
                    Console.WriteLine("You didn't take the candy because you're not a LOSER! however, now he wants to kill you!");
                    int loserHealth = 60;
                    int loserDamage = 25;
                    while (playerHealth > 0 && loserHealth > 0);
                    {
                        Console.WriteLine("Player Name: " + name);
                        Console.WriteLine("Player Health: " + playerHealth);
                        Console.WriteLine("Player level: " + level);
                        Console.WriteLine("Player Role: " + role);
                        //Enemy Stats
                        Console.WriteLine("\nLoser");
                        Console.WriteLine("Loser Health " + loserHealth);
                        Console.WriteLine("Loser Damage " + loserDamage);
                        Console.WriteLine("Loser Role: Candy Dandy");
                        Console.Write("MP: " + MP);
                        //Commands
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
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You continue your journry onward......somewhere.");
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
            Console.WriteLine("Hi there fella! State your name!");
            string protag = Console.ReadLine();
            Console.WriteLine("Well hi there " + protag + "!" + " Tell me your favorite weapon.");
            string weapon = Console.ReadLine();
            int hit = 10;
            int def = 10;
            int spd = 10;
            int mp = 10;
            int hp = 10;

            //Picking your color
            Console.WriteLine("Pick one of these colors");
            Console.WriteLine("Press 1 for Red");
            Console.WriteLine("Press 2 for Blue");
            Console.WriteLine("Press 3 for Green");
            Console.WriteLine("Press 4 for Yellow");
            Console.WriteLine("Press 5 for Pink");
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
            Console.WriteLine("A training dummy appeared before you. What is your first action?");
            Console.WriteLine("[1] Punch");
            Console.WriteLine("[2] Kick");
            Console.WriteLine("[3] Use Weapon ");

            //Making play pick action
            while (select != '1' && select != '2' && select != '3')
            {
                select = Console.ReadKey().KeyChar;
                if (select == '1')
                {
                    Console.WriteLine("You punched the dummy in the head");
                }
                else if (select == '2')
                {
                    Console.WriteLine("You kicked the dummy in the ribs");
                }

                else if (select == '3')
                    Console.WriteLine("You hit the dummy with your " + weapon + " .");



            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }











        }
    }
}
