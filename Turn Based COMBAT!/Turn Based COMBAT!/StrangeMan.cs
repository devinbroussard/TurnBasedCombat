using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_Based_COMBAT_
{
    class StrangeMan : BaseEntity
    {
        private string _name = "Strange Man";
        public string Name { get => _name; set => _name = value; }

        public StrangeMan(int Attack, int Defense, float Hp, bool isTurn)
        {
            attack = Attack;
            defense = Defense;
            hp = Hp;
            isturn = isTurn;
        }

        public StrangeMan()
        {
            attack = 15;
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
