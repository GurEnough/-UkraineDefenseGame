using System;
using System.Drawing;

namespace UkraineDefense.Engine
{
    class GameOver
    {
        static public bool isGameOver = false;
        static public void DrawGameOverScreen(Graphics g)
        {
            g.DrawString($"ГРА ЗАВЕРШЕНА \n Час: { Convert.ToInt32(Time.GetMinutes())}:{Time.GetSeconds()}", new Font("Stencil", 25),
                new SolidBrush(Color.Red), Render.Resolution.X / 2 - 100, Render.Resolution.Y / 2 - 100);
        }
    }
}
