using System;

namespace Turn_Based_COMBAT_
{
    class Combat
    {
        public void StrangeManFight()
        {
            StrangeMan strangeman = new StrangeMan();
            Character character = new Character();
            strangeman.isturn = true;
            int Round = 0; // sets the round variable

            Console.Clear();
            Utilities.writeRead($"You vs the Strange Man!");


            while (character.IsAlive() || strangeman.IsAlive()) // ! is an logical negation operator that states the value of the boolean; || is a conditional logic operator, if one of the two booleans are true then it is true, until one is false
            {
                Round++;
                Utilities.writeRead($"Round: {Round}");
                if (strangeman.isturn)
                {
                    Random rnd = new Random();
                    float chance = rnd.Next(1);
                    var target = 0.9f;


                    Utilities.writeRead("The strange man attacks you! ");

                    if (chance > target)
                    {
                        character.hp -= (strangeman.attack * 2) * (100 - character.defense) / 100;
                        Console.WriteLine($"Critical Hit for {(strangeman.attack * 2) * (100 - character.defense) / 100} damage!");
                    }
                    else
                    {
                        character.hp -= strangeman.attack * (100 - character.defense) / 100;
                        Console.WriteLine($"Hit for {strangeman.attack * (100 - character.defense) / 100} damage!");
                    }
                    Utilities.writeRead($"Your Hp: {character.hp}");
                    strangeman.isturn = false;
                    character.isturn = true;
                }
                if (character.isturn)
                {

                    string turnChoice;
                    Random rnd = new Random();
                    float chance = rnd.Next(1);
                    var target = 0.9f;


                    Console.WriteLine("Its your turn! What would you like to do?");
                    Console.WriteLine("1. attack");
                    Console.WriteLine("2. run");
                    Console.WriteLine("3. examine area");
                    Console.Write("Choice :");
                    turnChoice = Console.ReadLine().ToLower();

                    switch (turnChoice)
                    {
                        case "1":
                        case "attack":
                            Utilities.writeRead("You attack the strange man!");

                            if (chance > target)
                            {
                                strangeman.hp -= (character.attack * 2) * (100 - strangeman.defense) / 100;
                                Console.WriteLine($"Critical Hit for {(character.attack * 2) * (100 - strangeman.defense) / 100} damage!");
                            }
                            else
                            {
                                strangeman.hp -= character.attack * (100 - strangeman.defense) / 100;
                                Console.WriteLine($"Hit for {character.attack * (100 - strangeman.defense) / 100} damage!");
                            }
                            break;

                        case "2":
                        case "run":
                            Utilities.writeRead("You have no where to run!");
                            break;
                        case "3":
                        case "examine area":
                        case "examine":
                            Examine examine = new Examine();
                            examine.examineArea();
                            break;




                    }
                }

            }
        }
    }

}

