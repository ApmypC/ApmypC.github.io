using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Triangle : Rectangle
    {
        public int C { get; set; }
        public Triangle(int a, int b, int c): base(a, b)
        {
            C = c;
        }
        public override double Perimeter()
        {
            return A + B + C;
        }
        public override double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt((p * (p - A) * (p - B) * (p - C)));
        }
        public override void Print()
        {
            Console.WriteLine("\nТреугольник\nА равно: {0}, В равно: {1}, C равно: {2}", A, B, C);
            Console.WriteLine("Площадь: {0}, Периметер: {1}", Perimeter(), Square());
        }

    }
}
