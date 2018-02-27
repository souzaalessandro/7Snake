// 

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SevenSnake
{
    public class Snake
    {

        public List<SnakeCell> Cells;

        public Snake()
        {
            Cells = new List<SnakeCell>();

        }


        public void EatCell(SnakeCell snakeCell)
        {
            if (snakeCell.EatSnake)
                return;

            snakeCell.EatSnake = true;
            Cells.Add(snakeCell);

            var arooundOrdered = snakeCell.AroundCells.OrderBy(col => col.Value).ToList();

            foreach (var cell in arooundOrdered)
            {
                if (Cells.Count == 7)
                    break;

                if (cell.Value < snakeCell.Value || cell.EatSnake)
                    continue;
               
                EatCell(cell);
            }

            if (Cells.Count >= 7) return;

            snakeCell.EatSnake = false;
            Cells.Remove(snakeCell);

        }
    }
}