using System;
using Raylib_cs;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Raylib.InitWindow(500,500, "MineSweeper");
            GameMaster gameMaster = new GameMaster(15, 15);

            while(!Raylib.WindowShouldClose())
            {
                
                
                gameMaster.DrawAll();
            }
            
        }
    }
}
