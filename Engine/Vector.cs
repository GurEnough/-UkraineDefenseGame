﻿namespace UkraineDefense
{
    class Vector
    {
        int x;
        int y;
        public Vector() // Ініціалізація
        {
            this.x = 0;
            this.y = 0;
        }
        public Vector(int x, int y) //Перегрузка ініціалізації
        {
            this.x = x;
            this.y = y;
        }
        public int X => x; // Отримуємо координати
        public int Y => y;

        public static Vector operator +(Vector a, Vector b) => new Vector(a.x+b.x,a.y+b.y);
        public static Vector operator -(Vector a, Vector b) => new Vector(a.x - b.x, a.y - b.y);

    }
}
