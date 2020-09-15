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
        public Hero(int X, int Y, int HP) : base(X, Y, 'H')
        {
            tileT = TileType.Hero;
            this.hp = HP;
            this.maxHP = HP;
            damage = 2;
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            // check vision!
            if (move == MovementEnum.North)
            {
                HMove = MovementEnum.North;
            }
            else if (move == MovementEnum.South)
            {
                HMove = MovementEnum.South;
            }
            else if (move == MovementEnum.East)
            {
                HMove = MovementEnum.East;
            }
            else if (move == MovementEnum.West)
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
            return $"Player Stats:\n HP: {HP}/{MaxHP}\n Damage: {Damage}\n [{X}, {Y}]";
        }
    }
}
