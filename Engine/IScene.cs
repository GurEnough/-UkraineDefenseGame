using System.Drawing;

namespace UkraineDefense.Engine
{
    interface IScene
    {
        void DrawBack(Graphics g, int x, int y);
        void DrawObjects(Graphics g);

    }
}
