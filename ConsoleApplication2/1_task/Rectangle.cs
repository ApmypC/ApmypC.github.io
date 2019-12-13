using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Rectangle : Figure
    {
        public int A { get; set; }
        public int B { get; set; }

        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public Rectangle()
        {

        }

        public override double Perimeter()
        {
            return 2 * A + 2 * B;
        }
        public override double Square()
        {
            return A * B;
        }
        public override void Print()
        {
            Console.WriteLine("\nПрямоугольник\nА равно: {0}, В равно: {1}", A, B);
            Console.WriteLine("Площадь: {0}, Периметер: {1}", Perimeter(), Square());
        }
    }
}
