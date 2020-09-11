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
        public Goblin(int X, int Y, TileType TileT, int HP, int MaxHP, int Damage, TileType[] vision, MovementEnum move) : base(X, Y, TileT, HP, 10, 1, vision, move)
        {
            this.X = X;
            this.Y = Y;
            this.TileT = TileT;
            this.HP = HP;
            this.MaxHP = MaxHP;
            this.Damage = Damage;
            this.vision = vision;
            this.move = move;

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
