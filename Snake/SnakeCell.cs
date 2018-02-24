// 

using System;
using System.CodeDom;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace Snake
{
    public class SnakeCell
    {
        private readonly SnakeMap _snakeMap;
        public int Line;
        public int Colunm;
        public string Value;
        
        public SnakeCell(SnakeMap map)
        {
            _snakeMap = map;
            
        }

        static SnakeCell ReturnCell(int lin, int col,SnakeMap map)
        {
            return (map.MapCells.FirstOrDefault(cl => cl.Colunm == col && cl.Line == lin));
        }

        public SnakeCell CellTop()
        {
            return ReturnCell(Line-1,Colunm,_snakeMap);
        }
        public SnakeCell CellBotton()
        {
            return ReturnCell(Line+1, Colunm, _snakeMap);
        }
        public SnakeCell CellLeft()
        {
            return ReturnCell(Line, Colunm-1, _snakeMap);
        }
        public SnakeCell CellRight()
        {
            return ReturnCell(Line, Colunm+1, _snakeMap);
        }

    }
}