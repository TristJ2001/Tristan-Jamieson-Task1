using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Q 2.1
     public abstract class Tile
    {
        protected int X;
        protected int Y;
        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
            Obstacle,
            EmptyTile
        }

        protected TileType TileT;

        protected Tile(int X, int Y,  TileType TileT)
        {
            this.X = X;
            this.Y = Y;
            this.TileT = TileT;
        }
    }
}
