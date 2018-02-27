using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
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


        public void Play(Snake snake)
        {

            var maxColumn = GetMaxColumnSnakeMap();

            for (int i = 0; i < maxColumn; i++)
            {
                var cellsColumn = _snakeMap.MapCells.Where(col => col.Colunm == i).ToList();

                foreach (var snakeCell in cellsColumn)
                {
                    snake.EatCell(snakeCell);

                    if ( snake.Cells.Count == 7)
                        return;
                }
            }
           
            
        }

        private int GetMaxColumnSnakeMap()
        {
            var maxColumn = _snakeMap.MapCells.Max(x => x.Colunm);
            return maxColumn;

        }
    }
}
