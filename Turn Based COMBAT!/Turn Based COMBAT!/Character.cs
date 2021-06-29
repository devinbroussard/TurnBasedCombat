using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_Based_COMBAT_
{
    class Character : BaseEntity
    {

        private string _name = "";
        public string Name { get => _name; set => _name = value; }
        public Character(int Attack, int Defense, float Hp, bool isTurn)
        {
            attack = Attack;
            defense = Defense;
            hp = Hp;
            isturn = isTurn;

        }

        public Character()
        {
            attack = 20;
            defense = 10;
            hp = 100;
            isturn = false;

        }

        public int attack { get; set; }
        public int defense { get; set; }
        public float hp { get; set; }
        public bool isturn { get; set; }

        public bool IsAlive()
        {
            if (hp > 0)
                return true;
            else
                return false;
        }
    }
}
