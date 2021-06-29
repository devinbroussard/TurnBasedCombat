using System;

namespace Turn_Based_COMBAT_
{
    class Stages
    {
        public void GameStart()
        {
            Character character = new Character();
            Console.WriteLine("This is the beginning of a text-based adventure game.");
            Console.WriteLine("What is your name?");
            character.Name = Console.ReadLine();
            Console.WriteLine($"Okay, {character.Name}, press enter to start your adventure.");
            Console.ReadLine();
        }

        public void FirstStage()
        {
            Combat combat = new Combat();
            string choice;
            Console.WriteLine("You awaken in a forest. The sun is setting, you are thirsty, and it is getting dark. What do you do?");
            Console.WriteLine("1. seek out help");
            Console.WriteLine("2. look for water");
            Console.WriteLine("3. build a shelter");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "seek out help":
                case "seek":
                    Console.WriteLine("You walk down the forest path seeking out help.");
                    Utilities.writeRead("You shout for help and your voice echoes through the area.");
                    Console.WriteLine("Eventually you reach a wall created by a cliffside.");
                    Utilities.writeRead("Birds fly over head and wild animal noises surround you.");
                    Console.WriteLine("A strange-looking man appears through the bushes.");
                    Utilities.writeRead("He yells at you in a strange language, and then charges you.");
                    Utilities.writeRead("There is no escape, you must defend yourself.");
                    combat.StrangeManFight();
                    break;
            }
        }
    }
}

