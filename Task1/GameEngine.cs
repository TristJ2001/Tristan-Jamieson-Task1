using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Task1
{
    class GameEngine : Form1
    {
        private Map map;
        
        public Map GetMapMapVariable
        {
            get
            {
                return map;
            }
        }

        public GameEngine(bool upIsClicked, bool downIsClicked, bool leftIsClicked, bool rightIsClicked) : base (upIsClicked, downIsClicked, leftIsClicked, rightIsClicked)
        {
            map = new Map(5, 15, 5, 15, 5);
        }

        public bool MovePlayer(Character.MovementEnum direction)
        {
            if(direction == Character.MovementEnum.North)
            {
                return true;
            }
            else if(direction == Character.MovementEnum.South)
            {
                return true;
            }
            else if (direction == Character.MovementEnum.West)
            {
                return true;
            }
            else if (direction == Character.MovementEnum.East)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
