using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2._2_task
{
    class Line: Function
    {
        public int A { get; set; }
        public int B { get; set; }
        public int X { get; set; }
        public Line(int a, int b, int x)
        {
            A = a;
            B = b;
            X = x;
        }
        public override int Calc()
        {
            return A * X + B;
        }
        public override void Print()
        {
            Console.WriteLine("");
        }
    }
}
