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
    public partial class Form1 : Form
    {
        private Database database;
        public Form1()
        {
            InitializeComponent();
            database = new Database();
            UpdateTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            CreateForm form = new CreateForm(this);
            form.Show();
        }

        private void UpdateTable()
        {
            BindingSource source = new BindingSource();
            source.DataSource = database.GetShapes();
            dataGridView1.DataSource = source;
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) 
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                MessageBox.Show(row.Cells["Тип"].Value.ToString()+" удален!");
                if (row.Cells["Тип"].Value.ToString() == "Rectangle")
                {
                    database.DeleteRectangle(int.Parse(row.Cells["id"].Value.ToString()));
                }
                else
                {
                    database.DeleteTriangle(int.Parse(row.Cells["id"].Value.ToString()));
                }
                UpdateTable();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Form2 form2 = new Form2(this, row.Cells["Тип"].Value.ToString(), (int)row.Cells["id"].Value);
                form2.Show();
                this.Enabled = false;
            }
        }
    }
}
