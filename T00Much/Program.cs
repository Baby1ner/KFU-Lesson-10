using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
namespace T00Much
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1");
            ACipher aCipher= new ACipher();
            Console.WriteLine(aCipher.encode());
            Console.WriteLine(aCipher.decode());
            
            BCipher bCipher = new BCipher();
            Console.WriteLine(bCipher.encode());
            Console.WriteLine(bCipher.decode());
            


            Console.WriteLine("Домашнее задание 1");
            Point point = new Point(3,4,"желтый",Figure.condition.invisible);
            Rectangle rectangle = new Rectangle(5, 8, 0, -3, "красный", Figure.condition.visibl);
            Circle circle = new Circle(15, 4, 6, "зеленый", Figure.condition.visibl);

            ((ISquare)circle).Square();
            ((ISquare)rectangle).Square();
        }
    }
}
