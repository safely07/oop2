namespace lab2
{
    partial class Form3
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericH = new System.Windows.Forms.NumericUpDown();
            this.numericW = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericW)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Текущий цвет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Описание";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(250, 213);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 25;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Название";
            // 
            // numericH
            // 
            this.numericH.Location = new System.Drawing.Point(250, 169);
            this.numericH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericH.Name = "numericH";
            this.numericH.Size = new System.Drawing.Size(120, 22);
            this.numericH.TabIndex = 22;
            this.numericH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericW
            // 
            this.numericW.Location = new System.Drawing.Point(250, 129);
            this.numericW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericW.Name = "numericW";
            this.numericW.Size = new System.Drawing.Size(120, 22);
            this.numericW.TabIndex = 21;
            this.numericW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 48);
            this.button2.TabIndex = 20;
            this.button2.Text = "Выбрать цвет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(8, 173);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(123, 70);
            this.textDescription.TabIndex = 19;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(8, 129);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(123, 22);
            this.textName.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(282, 361);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(131, 45);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Отмена";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 433);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericH);
            this.Controls.Add(this.numericW);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeButton);
            this.Name = "Form3";
            this.Text = "Изменить";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericH;
        private System.Windows.Forms.NumericUpDown numericW;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeButton;
    }
}