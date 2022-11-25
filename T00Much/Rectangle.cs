using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Rectangle : Point, ISquare
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Rectangle(double side1, double side2, int x, int y, string color, condition condition) : base(x, y, color, condition)
        {
            Side1 = side1;
            Side2 = side2;
        }


        public void Square()
        {
            Console.WriteLine($"Площадь прямоугольника: {Side1 * Side2}");
        }
    }
}
