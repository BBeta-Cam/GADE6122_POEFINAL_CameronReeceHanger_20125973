using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_CameronReeceHanger_20125973
{
    class Leader : Enemy  //Question 2.4
    {
        private Tile LeadersTarget;

        private Tile LEADERSTARGET
        {
            get { return LeadersTarget; }
            set { LeadersTarget = value; }
        }

        public Leader(_X, _Y)
        {
            Leader.HP = 20;
            Leader.Damage = 2;
        }

        public override MovementEnum ReturnMove(MovementEnum CharacterMove = MovementEnum.NoMovement)
        {
            if (CheckIfMoveValid(Leader))
            {
                return MovementEnum.Up;
            }
            else return MovementEnum.NoMovement;
        }

    }
}
