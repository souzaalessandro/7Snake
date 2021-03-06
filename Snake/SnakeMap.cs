﻿// 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SevenSnake
{
    public class SnakeMap
    {

        public List<string[]> Map;

        public readonly List<SnakeCell> MapCells;

        public SnakeMap()
        {
            MapCells = new List<SnakeCell>();
        }

        public void BuildMapCell()
        {
            MapCells.Clear();
            for (var i = 0; i < Map.Count; i++)
            {
                for (var j = 0; j < Map[i].Length; j++)
                {
                    var cell = new SnakeCell(this) { Line = i, Colunm = j, Value = Convert.ToInt16(Map[i][j]) };
                    MapCells.Add(cell);
                }
            }
        }

        public void LoadMap(string fileName)
        {

            if (!File.Exists(fileName))
                throw new FileNotFoundException("Please check name file or file exists in informed path");

            Map = File.ReadAllLines(fileName)
                    .Select(ln => ln.Split(';'))
                    .ToList();

        }

    }
}