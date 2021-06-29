using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_Based_COMBAT_
{
    // Getters and setters are used to declare or obtain values of usually private variables
    interface BaseEntity //base class that other entities inherit // interface
    {
        float hp
        {
            get;
            set;
        }
        int attack
        {
            get;
            set;
        }
        int defense
        {
            get;
            set;
        }

        bool isturn
        {
            get;
            set;
        }
    }
}
