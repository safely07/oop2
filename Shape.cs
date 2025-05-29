using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public abstract class Shape : Interface
    {
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Shape(Color color, int x, int y, string name, string description)
        {
            this.Color = color;
            this.X = x;
            this.Y = y;
            this.Name = name;
            this.Description = description;
        }

        public void SetRandomColor()
        {
            Random random = new Random();
            this.Color = Color.FromArgb(random.Next(0,255), random.Next(0, 255), random.Next(0, 255));
        }
        public void Moving(string direction, int step)
        {
            if (direction == "up") this.Y += step;
            else if (direction == "left") this.X -= step;
            else if (direction=="right") this.X += step;
            else if (direction=="down") this.Y -= step;
        }
        public abstract double Area();
        public abstract double Perimeter();

    }
}
