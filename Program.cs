using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Rectangle
    {
        private double width;
        private double height;
        public Rectangle() {
            width = 3.0;
            height = 1.5;
            Console.WriteLine("");
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            Console.WriteLine($"{width} {height}");
        }

        public Rectangle(Rectangle other)
        {
            this.width = other.width;
            this.height = other.height;
            Console.WriteLine("Конструктор копирования вызван.");
        }

        static Rectangle()
        {
            Console.WriteLine("Статический конструктор вызван.");
        }

        ~Rectangle()
        {
            Console.WriteLine("Деструктор вызван.");

        }
        public double GetArea() { 
            return width * height; 
        }

        public double GetPerimert() { 
            return 2*(width+height);
        }

        }
        internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle(4, 6);
            Rectangle rect3 = new Rectangle(rect2);

            Console.WriteLine($"rect1: Площадь = {rect1.GetArea()}, Периметр = {rect1.GetPerimert()}");
            Console.WriteLine($"rect3: Площадь = {rect2.GetArea()}, Периметр = {rect2.GetPerimert()}");
            Console.WriteLine($"rect3: Площадь = {rect3.GetArea()}, Периметр = {rect3.GetPerimert()}");   
        }
    }
}
