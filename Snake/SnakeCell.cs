// 

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace SevenSnake
{
    public class SnakeCell
    {
        private readonly SnakeMap _snakeMap;
        private List<SnakeCell> _AroundCells;
        public int Line;
        public int Colunm;
        public int Value;
        public bool EatSnake;
        public List<SnakeCell> AroundCells {
            get
            {
                if (_AroundCells != null) return _AroundCells;

                _AroundCells = new List<SnakeCell>();
                AddAroundCells();

                return _AroundCells;
            }
        }

        private void AddAroundCells()
        {
            if (CellLeft() != null)
                _AroundCells.Add(CellLeft());

            if (CellBotton() != null)
                _AroundCells.Add(CellBotton());

            if (CellRight() != null)
                _AroundCells.Add(CellRight());

            if (CellTop() != null)
                _AroundCells.Add(CellTop());
        }

        public SnakeCell(SnakeMap map)
        {
            _snakeMap = map;
            
        }

        static SnakeCell ReturnCell(int lin, int col, SnakeMap map)
        {
            return (map.MapCells.FirstOrDefault(cl => cl.Colunm == col && cl.Line == lin));
        }

        public SnakeCell CellTop()
        {
            return ReturnCell(Line - 1, Colunm, _snakeMap);
        }
        public SnakeCell CellBotton()
        {
            return ReturnCell(Line + 1, Colunm, _snakeMap);
        }
        public SnakeCell CellLeft()
        {
            return ReturnCell(Line, Colunm - 1, _snakeMap);
        }
        public SnakeCell CellRight()
        {
            return ReturnCell(Line, Colunm + 1, _snakeMap);
        }

    }
}