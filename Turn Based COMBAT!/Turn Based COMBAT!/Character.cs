using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_Based_COMBAT_
{
    class Character : BaseEntity
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public float hp { get; set; }
        public bool active { get; set; }

        public Character(string Name, int Attack, int Defense, float Hp, bool Active)
        {
            attack = Attack;
            defense = Defense;
            hp = Hp;
            active = Active;
            name = Name;
        }

        public bool IsAlive()
        {
            if (hp > 0)
                return true;
            else
                return false;
        }

        public void fight(BaseEntity otherEntity)
        {
            Utilities.writeRead($"{name}'s turn, fighting {otherEntity.name}!");
            Console.WriteLine($"{name} attack {otherEntity.name}!");
            otherEntity.hp -= attack * (100 - otherEntity.defense) / 100;
            Console.WriteLine($"Hit for {attack * (100 - otherEntity.defense) / 100}");
            if (otherEntity.hp < 0) otherEntity.hp = 0;
            Utilities.writeRead($"{otherEntity.name}'s Hp: {otherEntity.hp}.");
        }
    }
}
