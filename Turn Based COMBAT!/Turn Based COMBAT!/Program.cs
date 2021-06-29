using System;

namespace Turn_Based_COMBAT_
{
    class Program
    { 
        public static void Main(string[] args)
        {
            Stages stages = new Stages();
            stages.GameStart();
            stages.FirstStage();

        }
    }
}
