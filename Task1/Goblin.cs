using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Q 2.5
     class Goblin : Enemy
    {
        MovementEnum GMove;
        //check vision for valid movement
        string valid;
        public Goblin(int X, int Y) : base(X, Y, 10, 1, 'G')
        {
            
        }

        public override MovementEnum ReturnMove(MovementEnum move = 0)
        {
           int random1 = rand.Next(0, 5);
            // check vision!
            if(random1 == 0)
            {
                GMove = MovementEnum.North;
            }else if(random1 == 1)
            {
                GMove = MovementEnum.South;
            }else if(random1 == 2)
            {
                GMove = MovementEnum.East;
            }else if(random1 == 3){
                GMove = MovementEnum.West;
            }
            else
            {
                GMove = MovementEnum.NoMovement;
            }

            return GMove;
        }
    }
}
