using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSnake
{
    public class SnakeGame
    {
        private readonly SnakeMap _snakeMap;

        public SnakeMap SnakeMap => _snakeMap;

        public SnakeGame(SnakeMap snakeMap)
        {
            _snakeMap = snakeMap;
        }
        public void LoadFile(string snakeFileMap)
        {
           _snakeMap.LoadMap(snakeFileMap);
        }

        
    }
}
