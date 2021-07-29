using System;
using System.Collections.Generic;
using Raylib_cs;

namespace Minesweeper
{
    public class GameMaster
    {
        private Mine[,] board;

        public GameMaster(int gridsizeX, int GridsizeY)
        {
            board = new Mine[gridsizeX, GridsizeY];

            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    board[x, y] = new Mine(x , y);
                }
            }
        }

        public void DrawAll()
        {
            Raylib.BeginDrawing();
            
            Raylib.ClearBackground(Color.BLUE);
                
            foreach (Mine item in board)
            {
                item.Draw();
            }
            Raylib.EndDrawing();
        }
    }
}
