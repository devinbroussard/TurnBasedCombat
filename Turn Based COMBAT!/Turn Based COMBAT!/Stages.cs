using System;

namespace Turn_Based_COMBAT_
{
    class Stages
    {
        public string CurrentStage;
        public Character character;
        public StrangeMan strangeman;
        public Stages()
        {
            strangeman = new StrangeMan(40, 10, 100, true);
            character = new Character("", 60, 10, 100, false);
        }

        public void GameOver()
        {
            string gameoverChoice;
            Utilities.writeRead("Game Over!");
            Console.WriteLine("Press enter to give up, or write'restart' to try again!");
            gameoverChoice = Console.ReadLine().ToLower();
            if (!(gameoverChoice == "restart"))
            {
                Program.Main();
            }
            else
            {

            }
        }

        public void startGame()
        {
            Console.WriteLine("What is your name?");
            character.name = Console.ReadLine();
            Utilities.writeRead($"Okay, {character.name}, press enter to begin!");

            //always grab the active entities turn
            //call fight on them
            //grab unactive entity and fight them
            //set the active to nonactive, and nonactive to active
            //do this on loop until someone is dead
            while (strangeman.IsAlive() && character.IsAlive())
            {
                if (strangeman.active)
                {
                    strangeman.fight(character);
                    strangeman.active = false;
                    character.active = true;
                }

                if (character.active)
                {
                    character.fight(strangeman);
                    character.active = false;
                    strangeman.active = true;
                }
            }

            if (strangeman.IsAlive())
            {
                Utilities.writeRead($"{strangeman.name} won!");
            }  
            if (character.IsAlive())
            {
                Utilities.writeRead($"{character.name} won!");
            }
        }
    }
}

