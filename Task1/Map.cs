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

        Tile.TileType[,] gameMap = new Tile.TileType[0, 0];

        Hero player;

        Enemy[] enemies = new Enemy[5];

        int width;
        int height;

        public Map(int minHeight, int maxHeight, int minwWidth, int maxwidth, int numberEnemies)
        {
            int height = rand.Next(minHeight, maxHeight);
            int width = rand.Next(minwWidth, maxwidth);

            Tile.TileType[,] gameMap = new Tile.TileType[width, height];

            this.height = height;
            this.width = width;

            Enemy[] enemyArray = new Enemy[numberEnemies];

            // fill game map with empty tiles
            for (int i = 0; i < gameMap.GetLength(0); i++)
            {
                for (int j = 0; j < gameMap.GetLength(1); j++)
                {
                    gameMap[i, j] = Tile.TileType.EmptyTile;
                }
            }

            // border map with obstacles
            for (int x = 0; x < gameMap.GetLength(0); x++)
            {
                // Top Row
                gameMap[x, 0] = Tile.TileType.Obstacle;
                // Bottom Row
                gameMap[x, 10] = Tile.TileType.Obstacle;
                // Left Row
                gameMap[0, x] = Tile.TileType.Obstacle;
                // Right Row
                gameMap[10, x] = Tile.TileType.Obstacle;
            }

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
                int enemyX = rand.Next(1, gameMap.GetLength(0));
                int enemyY = rand.Next(1, gameMap.GetLength(1));

                while (gameMap[enemyX, enemyY] == Tile.TileType.Enemy || gameMap[enemyX, enemyY] == Tile.TileType.Obstacle)
                {
                    enemyX = rand.Next(1, gameMap.GetLength(0));
                    enemyY = rand.Next(1, gameMap.GetLength(1));
                }
                gameMap[enemyX, enemyY] = Tile.TileType.Enemy;

                Tile Enemy = new Tile(enemyX, enemyY, Tile.TileType.Enemy);
            }
            else if (type == Tile.TileType.Hero)
            {
                // place hero
                int heroX = rand.Next(1, gameMap.GetLength(0));
                int heroY = rand.Next(1, gameMap.GetLength(1));

                while (gameMap[heroX, heroY] == Tile.TileType.Enemy || gameMap[heroX, heroY] == Tile.TileType.Obstacle)
                {
                    heroX = rand.Next(1, gameMap.GetLength(0));
                    heroY = rand.Next(1, gameMap.GetLength(1));
                }
                gameMap[heroX, heroY] = Tile.TileType.Hero;
            }

            return ;
        }
    }
}
