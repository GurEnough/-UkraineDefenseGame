using System.Drawing;

namespace UkraineDefense
{
    interface IGameObject
    {
        void Draw(Graphics g);
        bool Colision(int x, int y);
    }
}
