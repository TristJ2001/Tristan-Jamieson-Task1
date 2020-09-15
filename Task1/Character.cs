using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Q 2.2
    public abstract class Character : Tile
    {
        protected int hp;
        public int HP
        {
            get
            {
                return hp;
            }
        }

        protected char symbol;
        public char Symbol
        {
            get
            {
                return symbol;
            }
        }

        protected int maxHP;
        public int MaxHP
        {
            get
            {
                return maxHP;
            }
        }

        protected int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
        }

        protected Tile[] vision = new Tile[4];
        public Tile[] Vision
        {
            get
            {
                return vision;
            }
        }

        protected MovementEnum move;

        // Q 2.3
        public Character(int X, int Y, char Symbol) : base(X, Y)
        {
            this.symbol = Symbol;
        }

        public virtual void Attack(char Target)
        {

        }

        public bool isDead()
        {
            if(HP <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange(char Target)
        {
            //placekeeper
            return false;
        }

        private int DistanceTo(char target)
        {
            // placekeeper
            return 0;
        }

        public void Move(MovementEnum move)
        {
            if(move == MovementEnum.North)
            {
                x = x - 1;
            }
            else if(move == MovementEnum.South)
            {
                x = x + 1;
            }
            else if(move == MovementEnum.East)
            {
                y = y + 1;
            }
            else if(move == MovementEnum.West)
            {
                y = y - 1;
            }
        }

        public abstract MovementEnum ReturnMove(MovementEnum move = 0);

        public abstract override string ToString();
    
    }
    public enum MovementEnum
    {
        North,
        South,
        East,
        West,
        NoMovement
    }
}
