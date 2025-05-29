using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
{
    public partial class Form3 : Form
    {

        public Form2 form { get; set; }
        private Database database;
        private Color color;
        private int objId;
        private String type;

        public Form3(Form2 form, int objID, String type)
        {
            InitializeComponent();
            this.form = form;
            database = new Database();
            this.objId = objID;
            this.type = type;
            
            if (type == "Triangle")
            {
                label3.Text = "Сторона A";
                label4.Text = "Сторона B";
                label5.Text = "Сторона C";
                label5.Visible = true;
                numericUpDown2.Visible = true;
                textName.Text = database.GetTriangleById(objID).Name;
                textDescription.Text = database.GetTriangleById(objID).Description;
                numericUpDown2.Value = (database.GetTriangleById(objID) as Triangle).C;
                numericW.Value = (database.GetTriangleById(objID) as Triangle).B;
                numericH.Value = (database.GetTriangleById(objID) as Triangle).A;
            }
            else
            {
                label3.Text = "Высота";
                label4.Text = "Ширина";
                label5.Visible = false;
                numericUpDown2.Visible = false;
                textName.Text = database.GetRectangleById(objID).Name;
                textDescription.Text = database.GetRectangleById(objID).Description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if ((textName.Text == "") || (textDescription.Text == ""))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                if (type == "Triangle")
                {
                    Interface obj = new Triangle(color, 0, 0, textName.Text, textDescription.Text, int.Parse(numericW.Value.ToString()), int.Parse(numericH.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()));
                    database.UpdateTriangle(objId,obj as  Triangle);
                }
                else
                {
                    Interface obj = new Rectangle(color, 0, 0, textName.Text, textDescription.Text, int.Parse(numericW.Value.ToString()), int.Parse(numericH.Value.ToString()));
                    database.UpdateRectangle(objId, obj as Rectangle);
                }
                
                this.Close();
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            colorDialog.FullOpen = false;
            if (colorDialog.ShowDialog() == DialogResult.OK) { color = colorDialog.Color; }
            label6.BackColor = colorDialog.Color;
        }
    }
}
