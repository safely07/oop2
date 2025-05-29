using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public class Triangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle(Color color, int x, int y, string name, string description, int a, int b, int c) : base(color,x,y,name,description)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Perimeter()
        {
            return A+B+C;
        }
        public override double Area()
        {
            double p = Perimeter()/2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public bool IsRegular() { return (A == B)&&(B == C); }
        public bool IsRight() 
        {
            int max = Math.Max(A, Math.Max(B,C));
            int side1 = Math.Min(A, Math.Min(B,C));
            int side2 = (A + B + C) - max - side1;
            return (max * max == side1 * side1 + side2 * side2);
        }
    }
}
