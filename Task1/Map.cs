using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Map
    {
        Random rand = new Random();

        Tile.TileType[,] TileArray = new Tile.TileType[0, 0];

        Hero player;

        Enemy[] enemies = new Enemy[0];

        int width;
        int height;

        public void BoarderMapAndPopulate()
        {
            for (int i = 0; i < TileArray.GetLength(0); i++)
            {
                for (int j = 0; j < TileArray.GetLength(1); j++)
                {
                    TileArray[i, j] = Tile.TileType.EmptyTile;
                }
            }

            // Border Map with Obstacles
            for (int x = 0; x < TileArray.GetLength(0); x++)
            {
                // Top Row
                TileArray[x, 0] = Tile.TileType.Obstacle;
                // Bottom Row
                TileArray[x, 10] = Tile.TileType.Obstacle;
                // Left Row
                TileArray[0, x] = Tile.TileType.Obstacle;
                // Right Row
                TileArray[10, x] = Tile.TileType.Obstacle;
            }

        }

        public void PositionHero()
        {
            int random1 = rand.Next(1, TileArray.GetLength(0));
            int random2 = rand.Next(1, TileArray.GetLength(1));


            TileArray[random1, random2] = Tile.TileType.Hero;
        }

        public Map(int minHeight, int maxHeight, int minwWidth, int maxwidth, int numberEnemies)
        {
            int height = rand.Next(minHeight, maxHeight);
            int width = rand.Next(minwWidth, maxwidth);

            Tile[,] gameMap = new Tile[width, height];

            this.height = height;
            this.width = width;

            Enemy[] enemyArray = new Enemy[numberEnemies];

            Create(Tile.TileType.Hero);

            for (int z = 0; z < enemyArray.Length; z++)
            {
                enemyArray[z] = (Enemy)Create(Tile.TileType.Enemy);
            }

            UpdateVision();
        }

        public void UpdateVision()
        {

        }

        private Tile Create(Tile.TileType type)
        {
            int X;
            int Y;

            if (type == Tile.TileType.Enemy)
            {
                // place enemy
                int enemyX = rand.Next(1, TileArray.GetLength(0));
                int enemyY = rand.Next(1, TileArray.GetLength(1));

                while (TileArray[enemyX, enemyY] == Tile.TileType.Enemy)
                {
                    enemyX = rand.Next(1, TileArray.GetLength(0));
                    enemyY = rand.Next(1, TileArray.GetLength(1));
                }
                TileArray[enemyX, enemyY] = Tile.TileType.Enemy;
            }
            else if (type == Tile.TileType.Hero)
            {
                // place hero
                int heroX = rand.Next(1, TileArray.GetLength(0));
                int heroY = rand.Next(1, TileArray.GetLength(1));

                while (TileArray[heroX, heroY] == Tile.TileType.Enemy)
                {
                    heroX = rand.Next(1, TileArray.GetLength(0));
                    heroY = rand.Next(1, TileArray.GetLength(1));
                }
                TileArray[heroX, heroY] = Tile.TileType.Hero;
            }

            //return 
        }
    }
}
