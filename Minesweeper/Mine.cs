using System;
using System.Collections.Generic;
using System.Numerics;
using Raylib_cs;

namespace Minesweeper
{
    public class Mine
    {
        static int spacing = 25;
        Vector2 position = new Vector2();
        public int bombsNear{get; private set;}
        public bool isBomb {get; private set;}
        Rectangle hitbox;
        public Mine(int x , int y)
        {
            position = new Vector2(x, y);
            hitbox = new Rectangle((int)position.X * spacing , (int)position.Y * spacing, 20, 20);
        }

        public void Draw()
        {
            Raylib.DrawRectangleRec(hitbox, Color.GRAY);
        }
    }
}
