using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class SevenSnake
    {
        private readonly SnakeMap _snakeMap;

        public SnakeMap SnakeMap => _snakeMap;

        public SevenSnake(SnakeMap snakeMap)
        {
            _snakeMap = snakeMap;
        }
        public void LoadFile(string snakeFileMap)
        {
           _snakeMap.LoadMap(snakeFileMap);
        }

        
    }
}
