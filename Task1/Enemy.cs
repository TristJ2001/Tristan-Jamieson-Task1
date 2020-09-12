using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Q 2.4
    abstract class Enemy : Character
    {
        protected Random rand = new Random();

        public Enemy(int X, int Y, TileType TileT, int HP, int MaxHP, int Damage, Tile[] vision, MovementEnum move) : base(X, Y, TileT, HP, MaxHP, Damage, vision, move)
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

        public override string ToString()
        {
            return $"{this.GetType().Name} at [{X}, {Y}] ({Damage})";
        }
    }
}
