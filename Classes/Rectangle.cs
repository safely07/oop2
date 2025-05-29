using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2
{
    public class Rectangle : Shape
    {
        public int H { get; set; }
        public int W { get; set; }
        public Rectangle(Color color, int x, int y, string name, string description, int h, int w) : base(color, x, y, name, description)
        {
            H = h;
            W = w;
        }

        public override double Perimeter()
        {
            return W * 2 + H * 2;
        }
        public override double Area()
        {
            return H * W;
        }
        public double GetDiagonales()
        {
            return Math.Sqrt(H * H + W * W);
        }
        public bool IsSquare()
        {
            return (H == W);
        }
    }
}
