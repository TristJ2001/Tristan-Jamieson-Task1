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
    // Q 3.1
    class Map
    {
        Tile[,] gameMap;
        public Tile[,] GameMap
        {
            get
            {
                return gameMap;
            }
        }

        Hero player;
        public Hero Player
        {
            get
            {
                return player;
            }
        }

        Enemy[] enemies;
        public Enemy[] Enemies
        {
            get
            {
                return enemies;
            }
        }

        int width;
        public int Width
        {
            get
            {
                return width;
            }
        }

        int height;
        public int Height
        {
            get
            {
                return height;
            }
        }

        Random rand = new Random();

        // Q 3.2
        public Map(int minHeight, int maxHeight, int minWidth, int maxWidth, int numEnemies)
        {
            int height = rand.Next(minHeight, maxHeight);
            int width = rand.Next(minWidth, maxWidth);

            gameMap = new Tile[width, height];

            this.height = height;
            this.width = width;

            enemies = new Enemy[numEnemies];

            // fill game map with empty tiles
            for (int i = 0; i < gameMap.GetLength(0); i++)
            {
                for (int j = 0; j < gameMap.GetLength(1); j++)
                {
                    gameMap[i, j] = new EmptyTile(i, j);
                }
            }

            // border map with obstacles
            for (int x = 0; x < gameMap.GetLength(0); x++)
            {
                // Left Row
                gameMap[x, 0] = new Obstacle(x, 0);
                // Right Row
                gameMap[x, gameMap.GetLength(1) - 1] = new Obstacle(x, gameMap.GetLength(1) - 1);  
            }
            
            for (int y = 0; y < gameMap.GetLength(1); y++)
            {
                // Top Row
                gameMap[0, y] = new Obstacle(0, y);
                // Bottom Row
                gameMap[gameMap.GetLength(0) - 1, y] = new Obstacle(gameMap.GetLength(0) - 1, y);
            }

                Create(TileType.Hero);

            for (int z = 0; z < enemies.Length; z++)
            {
                enemies[z] = (Enemy)Create(TileType.Enemy);
            }

            UpdateVision();
        }

        public void UpdateVision()
        {

        }

        private Tile Create(TileType type)
        {
            int X = rand.Next(1, gameMap.GetLength(0));
            int Y = rand.Next(1, gameMap.GetLength(1));

            while (gameMap[X, Y].TileT != TileType.EmptyTile)
            {
              X = rand.Next(1, gameMap.GetLength(0));
              Y = rand.Next(1, gameMap.GetLength(1));
            }
            if(type == TileType.Hero)
            {
                gameMap[X, Y] = new Hero(X, Y, 20);
            }
            else if(type == TileType.Enemy)
            {
                gameMap[X, Y] = new Goblin(X, Y); 
            }

            return gameMap[X, Y];
        }
    }
}
