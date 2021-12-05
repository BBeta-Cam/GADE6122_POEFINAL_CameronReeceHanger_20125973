using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_CameronReeceHanger_20125973
{
    class MeleeWeapon //Question 2.2
    {
        public enum Types
        {
            dagger,
            longsword,
        }


        public override int Range() //public overriden range
        {
            return 1;
        }

        public MeleeWeapon(Types, _X, _Y) //constructor
        {
            //public bool dagger = false;
            //public bool longsword = false;

            //if(Types.Equals("Dagger"))
            //{
            //  dagger = true;
            //}
            // else if(Types.Equals("Longsword"))
            //{
            //  longsword = true;
            //}

            dagger.typeString = "Dagger";
            dagger.durability = 10;
            dagger.damage = 3;
            dagger.cost = 3;

            longsword.typeString = "Longsword";
            longsword.durability = 6;
            longsword.damage = 4;
            longsword.cost = 5;

        }
        
    }
}
