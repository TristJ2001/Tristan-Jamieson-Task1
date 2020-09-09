using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Q 2.2
    public abstract class Character : Tile
    {
       // int X;
       // int Y;
       // TileType TyleT;

        protected int HP;
        protected int MaxHP;
        protected int Damage;
        TileType[] vision = new TileType[4];

        public enum MovementEnum
        {
            North,
            South,
            East,
            West,
            NoMovement
        }

        protected MovementEnum move;

        // Q 2.3
        public Character(int X, int Y, TileType TileT, int HP, int MaxHP, int Damage, TileType[] vision, MovementEnum move) : base(X, Y, TileT)
        {
            this.HP = HP;
            this.MaxHP = MaxHP;
            this.Damage = Damage;
            this.vision = vision;
            this.move = move;
        }

        public virtual void Attack(char Target)
        {

        }

        public bool isDead()
        {
            //placekeeper
            return false;
        }

        public virtual bool CheckRange(char Target)
        {
            //placekeeper
            return false;
        }

        private int DistanceTo(char target)
        {
            //placekeeper
            return 0;
        }

        public void Move(MovementEnum move)
        {

        }

        public abstract MovementEnum ReturnMove(MovementEnum move = 0);

        public abstract override ToString()
        {

        }
      
        
    }
}
