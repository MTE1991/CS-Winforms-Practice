namespace WFDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 36);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 71);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 115);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 2;
            label3.Text = "Designation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 151);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 3;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 188);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 4;
            label5.Text = "Semester";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(205, 149);
            numericUpDown1.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(205, 186);
            numericUpDown2.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(180, 31);
            numericUpDown2.TabIndex = 6;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(205, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 31);
            textBox3.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(205, 253);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CSE", "ICT", "ES" });
            comboBox1.Location = new Point(207, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 33);
            comboBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 337);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BUP ITC Membership Info Form";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Button button1;
        private ComboBox comboBox1;
    }
}
