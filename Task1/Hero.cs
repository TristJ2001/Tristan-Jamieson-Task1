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
        public Hero(int X, int Y, TileType TileT, int HP, int MaxHP, int Damage, Tile[] vision, MovementEnum move) : base(X, Y, TileT, HP, MaxHP, 2, vision, move)
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

        public override MovementEnum ReturnMove(Character.MovementEnum move)
        {
            // check vision!
            if (move == Character.MovementEnum.North)
            {
                if()
                HMove = MovementEnum.North;
            }
            else if (move == Character.MovementEnum.South)
            {
                HMove = MovementEnum.South;
            }
            else if (move == Character.MovementEnum.East)
            {
                HMove = MovementEnum.East;
            }
            else if (move == Character.MovementEnum.West)
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
