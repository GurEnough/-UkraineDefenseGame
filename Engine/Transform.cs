namespace UkraineDefense
{
    class Transform // Клас для зберігання позицій і т.д.
    {
        Vector position;
        Vector size;
        public Vector Position => position;
        public Vector Size => size;
        public void SetPosition(Vector vector) => position = vector;

        public void AddPosition(Vector vector) => position = position + vector;
        public void SetSize(Vector vector) => size = vector;
        public bool Colision(int x, int y) => x > position.X && x < position.X + size.X && y > position.Y && y < position.Y + size.Y;  
    }
}
