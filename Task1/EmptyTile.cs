using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Q 2.1
    class EmptyTile : Tile
    {
        public EmptyTile(int X, int Y) : base(X, Y)
        {
            tileT = TileType.EmptyTile;
        }
    }
}
