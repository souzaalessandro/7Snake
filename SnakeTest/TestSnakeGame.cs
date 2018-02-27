using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using SevenSnake;

namespace SnakeTest
{
    [TestFixture]
    public class TestSnakeGame
    {
        const string fileName = "D:\\SnakeFile\\SnakeTestFile.CSV";
        [Test]
        public void TestLoadFile()
        {
            var map = new SnakeMap();
            var snake = new SnakeGame(map);
            snake.LoadFile(fileName);
            Assert.IsTrue(snake.SnakeMap.Map.Count>0, "Not load SnakeMap");
        }

        [SetUp]
        public void Setup()
        {
            if (!File.Exists(fileName))
            {
                CreateSnakeFile();
            }

        }

        private static void CreateSnakeFile()
        {
            using (var snakeFile = File.CreateText(fileName))
            {
                snakeFile.WriteLine("227;191;234;67;43;13;48;211;253;243");
                snakeFile.WriteLine("36; 95; 229; 209; 49; 230; 46; 16; 190; 49");
                snakeFile.WriteLine("206; 130; 85; 67; 104; 93; 128; 243; 38; 173");
                snakeFile.WriteLine("234; 82; 191; 153; 170; 99; 124; 60; 12; 31");
                snakeFile.WriteLine("192; 9; 24; 127; 183; 241; 139; 3; 2; 1");
                snakeFile.WriteLine("93; 200; 66; 16; 189; 42; 209; 4; 215; 4");
                snakeFile.WriteLine("182; 141; 153; 64; 229; 55; 115; 5; 6; 187");
                snakeFile.WriteLine("133; 241; 35; 255; 126; 39; 110; 147; 7; 241");
                snakeFile.WriteLine("2; 202; 191; 159; 223; 128; 154; 109; 6; 200");
                snakeFile.WriteLine("173; 44; 163; 196; 159; 232; 135; 159; 117; 175");

                snakeFile.Close();
            }
        }

        [Test]
        public void TestReadCells()
        {
            var map = new SnakeMap();
            var snake = new SnakeGame(map);
            snake.LoadFile(fileName);
            snake.SnakeMap.BuildMapCell();
            Assert.IsTrue(snake.SnakeMap.MapCells.Count > 0, "Not load Cell SnakeMap");

        }

        [Test]
        public void TestShareCell()
        {
          
            var map = new SnakeMap();
            var snakeGame = new SnakeGame(map);
            snakeGame.LoadFile(fileName);
            snakeGame.SnakeMap.BuildMapCell();
            var snake1 = new Snake();
            snakeGame.Play(snake1);
            Assert.IsTrue(snake1.Cells.Count==7 ,"Falhou na busca 1");
            var snake2 = new Snake();
            snakeGame.Play(snake2);
            Assert.IsTrue(snake2.Cells.Count == 7, "Falhou na busca 2");


        }

        [Test]
        public void TestPlayGame()
        {
           throw new NotImplementedException();
        }


    }
}
