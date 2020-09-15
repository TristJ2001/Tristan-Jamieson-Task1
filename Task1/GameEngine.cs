using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Q 3.3
    class GameEngine
    {
        private Map mapVariable;
        public Map MapVariable
        {
            get
            {
                return mapVariable;
            }
        }

        public GameEngine()
        {
           mapVariable = new Map(5, 15, 5, 15, 5);
        }

        public bool MovePlayer(MovementEnum direction)
        {
            if (direction == MovementEnum.North)
            {
                return true;
            }
            else if (direction == MovementEnum.South)
            {
                return true;
            }
            else if (direction == MovementEnum.West)
            {
                return true;
            }
            else if (direction == MovementEnum.East)
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
