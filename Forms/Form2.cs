using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        private Form mainForm;
        private Database database;
        private string type;
        private Shape object1;
        private int objectId;
        public Form2(Form form1, string type, int id)
        {
            InitializeComponent();
            mainForm = form1;
            this.type = type;
            database = new Database();
            if (type == "Triangle") object1 = database.GetTriangleById(id);
            else object1 = database.GetRectangleById(id);
            objectId = id;
            UpdateForm();
            UpdateCords();
        }
        private void UpdateCords()
        {
            cords.Text = "( " + object1.X.ToString() + " ; " + object1.Y.ToString() + " )";
        }
        private void UpdateForm()
        {
            if (object1 is Triangle triangle)
            {
                labelFirst.Text = "Сторона A";
                labelSecond.Text = "Сторона B";
                labelThird.Text = "Сторона C";
                labelFirst.Visible = true;
                labelSecond.Visible = true;
                labelThird.Visible = true;
                valueFirst.Visible = true;
                valueSecond.Visible = true;
                valueThird.Visible = true;
                valueFirst.Text = triangle.A.ToString();
                valueSecond.Text = triangle.B.ToString();
                valueThird.Text = triangle.C.ToString();
                button4.Text = "Является правильным?";
                button5.Text = "Является прямоугольным?";
            }
            else if (object1 is Rectangle rectangle)
            {
                labelFirst.Text = "Высота";
                labelSecond.Text = "Ширина";
                labelFirst.Visible = true;
                labelSecond.Visible = true;
                valueFirst.Text = rectangle.H.ToString();
                valueSecond.Text = rectangle.W.ToString();
                valueFirst.Visible = true;
                valueSecond.Visible = true;
                button4.Text = "Длина диагоналей";
                button5.Text = "Является квадратом?";
            }
            label7.BackColor = object1.Color;
            label2.Text = object1.Name;
            label3.Text = object1.Description;
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object1.SetRandomColor();
            if (object1 is Rectangle rectangle)
            {
                database.UpdateRectangle(objectId, rectangle);
            }
            else if (object1 is Triangle triangle)
            {
                database.UpdateTriangle(objectId, triangle);
            }
            label7.BackColor = object1.Color;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            object1.Moving("up", int.Parse(numericUpDown1.Value.ToString()));
            UpdateCords();
            if (object1 is Rectangle rectangle)
            {
                database.UpdateRectangle(objectId, rectangle);
            }
            else if (object1 is Triangle triangle)
            {
                database.UpdateTriangle(objectId, triangle);
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            object1.Moving("right", int.Parse(numericUpDown1.Value.ToString()));
            UpdateCords();
            if (object1 is Rectangle rectangle)
            {
                database.UpdateRectangle(objectId, rectangle);
            }
            else if (object1 is Triangle triangle)
            {
                database.UpdateTriangle(objectId, triangle);
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            object1.Moving("left", int.Parse(numericUpDown1.Value.ToString()));
            UpdateCords();
            if (object1 is Rectangle rectangle)
            {
                database.UpdateRectangle(objectId, rectangle);
            }
            else if (object1 is Triangle triangle)
            {
                database.UpdateTriangle(objectId, triangle);
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            object1.Moving("down", int.Parse(numericUpDown1.Value.ToString()));
            UpdateCords();
            if (object1 is Rectangle rectangle)
            {
                database.UpdateRectangle(objectId, rectangle);
            }
            else if (object1 is Triangle triangle)
            {
                database.UpdateTriangle(objectId, triangle);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (object1 is Rectangle rectangle)
            {
                MessageBox.Show("Площадь прямоугольника = " + rectangle.Area().ToString());
            }
            else if (object1 is Triangle triangle)
            {
                MessageBox.Show("Площадь треугольника = " + triangle.Area().ToString());
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (object1 is Rectangle rectangle)
            {
                MessageBox.Show("Периметр прямоугольника = " + rectangle.Perimeter().ToString());
            }
            else if (object1 is Triangle triangle)
            {
                MessageBox.Show("Периметр треугольника = "+triangle.Perimeter().ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (object1 is Rectangle rectangle)
            {
                MessageBox.Show("Длина диагонали прямоугольника = " + rectangle.GetDiagonales().ToString());
            }
            else if (object1 is Triangle triangle)
            {
                if (triangle.IsRegular()) MessageBox.Show("Треугольник правильный");
                else MessageBox.Show("Треугольник не правильный");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (object1 is Rectangle rectangle)
            {
                if (rectangle.IsSquare()) MessageBox.Show("Является квадратом");
                else MessageBox.Show("Не является квадратом");
            }
            else if (object1 is Triangle triangle)
            {
                if (triangle.IsRight()) MessageBox.Show("Треугольник прямоугольный");
                else MessageBox.Show("Треугольник не прямоугольный");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new Form3(this, objectId, type);
            this.Enabled = false;
            form.ShowDialog();
        }

        private void button7_EnabledChanged(object sender, EventArgs e)
        {
            if (type == "Rectangle") object1 = database.GetRectangleById(objectId);
            else object1 = database.GetTriangleById(objectId);
            UpdateForm();
        }
    }
}
