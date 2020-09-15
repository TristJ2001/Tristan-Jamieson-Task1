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

        public Enemy(int X, int Y, int HP, int Damage, char Symbol) : base(X, Y, 'E')
        {
            this.hp = HP;
            this.damage = Damage;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} at [{X}, {Y}] ({Damage})";
        }
    }
}
