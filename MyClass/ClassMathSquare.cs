using System;

namespace MyClass
{
    /// <summary>
    /// Класс площадь примитивов
    /// </summary>
    public class ClassMathSquare
    {
        /// <summary>
        /// Площадь произвольного треугольника по Формуле Герона
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        public double ST(double a, double b, double c)
        {
            double p = (a + b + c) / 2; // находим полупериметр
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 1);
        }
        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        public double SQ(double a, double b) { return a * b; }
        /// <summary>
        /// Площадь круга по радиусу
        /// </summary>
        /// <param name="a">Радиус а</param>
        public double SC(double a) { return Math.Round(Math.PI * Math.Pow(a, 2), 1); }
    }
    /// <summary>
    /// Класс по собственному усмотрению
    /// </summary>
    public class ClassCustom
    {
        /// <summary>
        /// Классическая задача из Алгебры
        /// </summary>
        /// <returns>Скорость в метрах в минуту</returns>
        /// <param name="a">Время в минутах</param>
        /// <param name="b">Расстояние в метрах</param>
        public double Alg(double a, double b) { return Math.Round(b / a, 2); }
        /// <summary>
        /// Задача по физике
        /// </summary>
        /// <returns>Сопротивление удлинителя из меди</returns>
        /// <param name="a">Длинна удлинителя в м</param>
        /// <param name="b">Диаметр медного провода мм</param>
        public double Amp(double a, double b)
        {
            return Math.Round(8 * 17 * Math.Pow(10, -9) * a / (Math.PI * Math.Pow(b * Math.Pow(10, -3), 2)), 2);
        }
        /// <summary>
        /// Rgbs to hex.
        /// </summary>
        /// <returns>The to hex.</returns>
        /// <param name="r">The red component.</param>
        /// <param name="g">The green component.</param>
        /// <param name="b">The blue component.</param>
        public int RgbToHex(int r, int g, int b)
        {
            //int a = 0x10;//16
            return Convert.ToInt32(r.ToString("X2") + g.ToString("X2") + b.ToString("X2"), 16);
        }
        /// <summary>
        /// Mults the string.
        /// </summary>
        /// <returns>The string.</returns>
        /// <param name="a">The string.</param>
        /// <param name="b">The value of strings.</param>
        public string MultStr(string a, int b)
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder();
            for (int i = 0; i < b; i++)
                str.Append(a);
            return str.ToString();
        }
    }
}
