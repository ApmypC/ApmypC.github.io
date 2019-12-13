using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Circle : Figure
    {
        public int R { get; set; }
        public Circle(int r)
        {
            R = r;
        }
        public override double Perimeter()
        {
            return Math.PI * 2 * R;
        }
        public override double Square()
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public override void Print()
        {
            Console.WriteLine("\nОкружность\nРадиус: {0}", R);
            Console.WriteLine("Площадь: {0}, Периметер: {1}", Perimeter(), Square());
        } 
    }
}
