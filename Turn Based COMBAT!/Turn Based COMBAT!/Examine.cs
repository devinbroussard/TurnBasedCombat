using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_Based_COMBAT_
{
    class Examine
    {
        public void examineArea()
        {
            Character character = new Character();
            Random random = new Random();
            float item = random.Next(2);

            switch (item)
            {
                case 0:
                    Console.WriteLine("You picked up a stone off the ground.");
                    character.attack = character.attack + 8;
                    Utilities.writeRead("Your attack has been increased!");
                    break;
                case 1:
                    Utilities.writeRead("You look around, but you find nothing!");
                    break;
                case 2:
                    Console.WriteLine("You find some cloth!");
                    Utilities.writeRead("You used the cloth to bandage yourself");
                    character.hp = character.hp + 10;
                    Console.WriteLine("You Hp was increased!");
                    Utilities.writeRead($"New Hp: {character.hp}");
                    break;
            }
        }
    }
}
