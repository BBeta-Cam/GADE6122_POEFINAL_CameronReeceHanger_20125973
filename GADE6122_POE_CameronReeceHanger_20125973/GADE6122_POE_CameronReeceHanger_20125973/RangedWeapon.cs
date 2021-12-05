using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_CameronReeceHanger_20125973
{
    class RangedWeapon //Question 2.3
    {

        public enum Types {
        Rifle, 
        Longbow,
        }

        public override int Range() //public overriden range
        {
            return 1;
        }

        public RangedWeapon(Types)
        {
            //public bool Rifle = false;
            //public bool Longbow = false;

            //if(Types.Equals("Rifle"))
            //{
            //  Rifle = true;
            //}
            // else if(Types.Equals("Longbow"))
            //{
            //  Longbow = true;
            //}

            Rifle.typeString = "Rifle";
            Rifle.durability = 3;
            Rifle.range = 3;
            Rifle.damage = 5;
            Rifle.cost = 7;

            Longbow.typeString = "Longbow";
            Longbow.durability = 4;
            Longbow.range = 2;
            Longbow.damage = 4;
            Longbow.cost = 6;
        }

    }
}
