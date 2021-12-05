using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_CameronReeceHanger_20125973
{
    class Shop //Question 2.5
    {
        Weapon[] WeaponArray = new Weapon[3];
        Random RandWeapon = new Random();
        Character Buyer = new Character();

        public Shop(Character Buyer)
        {
            for (int i = 0; i < WeaponArray.Length; i++)
            {
                WeaponArray[i] = RandWeapon;
            }
        }

        private Weapon RandomWeapon()
        {
           int randnum = RandWeapon.Next(1, 5);
            if (randnum == 1)
            {
                return Dagger;
            }
            else if (randnum == 2)
            {
                return Longsword;
            }
            else if(randnum == 3)
            {
                return Longbow;
            }
            else if(randnum == 4)
            {
                return Rifle;
            }
        }

        public bool CanBuy(int num)
        {

        }

        public void Buy(int num)
        {

        }

        public string DisplayWeapon(int num)
        {
            return "Buy WeaponType (X Gold)";
        }

    }
}
