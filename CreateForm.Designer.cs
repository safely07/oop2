namespace lab2
{
    partial class CreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numericW = new System.Windows.Forms.NumericUpDown();
            this.numericH = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(305, 395);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(131, 45);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Отмена";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(31, 163);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(123, 22);
            this.textName.TabIndex = 2;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(31, 207);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(123, 70);
            this.textDescription.TabIndex = 3;
            this.textDescription.TextChanged += new System.EventHandler(this.textDescription_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выбрать цвет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericW
            // 
            this.numericW.Location = new System.Drawing.Point(273, 163);
            this.numericW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericW.Name = "numericW";
            this.numericW.Size = new System.Drawing.Size(120, 22);
            this.numericW.TabIndex = 5;
            this.numericW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericW.ValueChanged += new System.EventHandler(this.numericW_ValueChanged);
            // 
            // numericH
            // 
            this.numericH.Location = new System.Drawing.Point(273, 203);
            this.numericH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericH.Name = "numericH";
            this.numericH.Size = new System.Drawing.Size(120, 22);
            this.numericH.TabIndex = 6;
            this.numericH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericH.ValueChanged += new System.EventHandler(this.numericH_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Описание";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Треугольник",
            "Прямоугольник"});
            this.comboBox1.Location = new System.Drawing.Point(149, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(273, 247);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Описание";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Описание";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Описание";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Текущий цвет";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 452);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericH);
            this.Controls.Add(this.numericW);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeButton);
            this.Name = "CreateForm";
            this.Text = "Create";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericW;
        private System.Windows.Forms.NumericUpDown numericH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}