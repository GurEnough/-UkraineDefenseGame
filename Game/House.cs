﻿using System.Drawing;

namespace UkraineDefense.Game
{
    class House : Transform, IGameObject
    {
        bool isBreak = false;        
        public House(int x, int y, int sx, int sy)
        {
            SetPosition(new Vector(x, y));
            SetSize(new Vector(sx, sy));
        }
        public void Break() => isBreak = true;
        public bool IsBreak => isBreak;
        public void Draw(Graphics g) => g.DrawImage(isBreak ? Resources.GetFrame("HouseBreak") : Resources.GetFrame("House"),
            Position.X, Position.Y, Size.X, Size.Y);
    }
}
