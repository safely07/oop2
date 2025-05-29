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
    public partial class CreateForm : Form
    {
        
        public Form Form1 { get; set; }
        private Database database;
        private Color color;

        public CreateForm(Form form1)
        {
            InitializeComponent();
            Form1 = form1;
            database = new Database();
            comboBox1.SelectedIndex = 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textName.Text == "")|| (textDescription.Text == ""))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    database.CreateTriangle(color.ToArgb(), 0, 0, textName.Text, textDescription.Text, int.Parse(numericW.Value.ToString()), int.Parse(numericH.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()));
                }
                else
                {
                    database.CreateRectangle(color.ToArgb(), 0, 0, textName.Text, textDescription.Text, int.Parse(numericW.Value.ToString()), int.Parse(numericH.Value.ToString()));
                }
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                label3.Text = "Сторона A";
                label4.Text = "Сторона B";
                label5.Text = "Сторона C";
                label5.Visible = true;
                numericUpDown2.Visible = true;
            }
            else
            {
                label3.Text = "Высота";
                label4.Text = "Ширина";
                label5.Visible = false;
                numericUpDown2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            colorDialog.FullOpen = false;
            if (colorDialog.ShowDialog()==DialogResult.OK) { color = colorDialog.Color; }
            label6.BackColor = colorDialog.Color;
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericW_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericH_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
