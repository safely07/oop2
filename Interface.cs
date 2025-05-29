using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public interface Interface
    {
        Color Color { get; set; }
        int X { get; set; }
        int Y { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        double Perimeter();
        double Area();
        void Moving(string direction, int step);
        void SetRandomColor();
    }
}
