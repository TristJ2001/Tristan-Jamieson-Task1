using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Q 2.6
    class Hero : Character
    {
        string valid;
        MovementEnum HMove;
        public Hero(int X, int Y, TileType TileT, int HP, int MaxHP, int Damage, TileType[] vision, MovementEnum move) : base(X, Y, TileT, HP, MaxHP, 2, vision, move)
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
            if (random1 == 0)
            {
                HMove = MovementEnum.North;
            }
            else if (random1 == 1)
            {
                HMove = MovementEnum.South;
            }
            else if (random1 == 2)
            {
                HMove = MovementEnum.East;
            }
            else if (random1 == 3)
            {
                HMove = MovementEnum.West;
            }
            else
            {
                HMove = MovementEnum.NoMovement;
            }

            return HMove;
        }

        public override string ToString()
        {
            return $"Player Stats:\n HP: {HP}/{MaxHP}\n Damage: {Damage}\n [{X}, {Y})";
        }
    }
}
