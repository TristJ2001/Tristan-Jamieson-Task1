using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Q 2.1
     class Obstacle : Tile
    {
        public Obstacle(int X, int Y) : base(X, Y)
        {
            tileT = TileType.Obstacle;
        }
    }
}
