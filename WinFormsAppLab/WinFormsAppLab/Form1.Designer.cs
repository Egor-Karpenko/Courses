namespace WinFormsAppLab
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
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Тип товару";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 27);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Blue-Ray", "Online" });
            comboBox1.Location = new Point(12, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(314, 28);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Назва";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Режисер";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 27);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 7;
            label4.Text = "Рік";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(314, 27);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 222);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 9;
            label5.Text = "Актор на головну роль";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 245);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(314, 27);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 275);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "Вартість";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 298);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(314, 27);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 328);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 13;
            label7.Text = "Метод доставки";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 351);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 27);
            textBox6.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 381);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 15;
            label8.Text = "Метод оплати";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 404);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(314, 27);
            textBox7.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(12, 437);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 16;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(169, 437);
            button2.Name = "button2";
            button2.Size = new Size(157, 29);
            button2.TabIndex = 17;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(169, 472);
            button3.Name = "button3";
            button3.Size = new Size(157, 29);
            button3.TabIndex = 19;
            button3.Text = "Додати";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 472);
            button4.Name = "button4";
            button4.Size = new Size(157, 29);
            button4.TabIndex = 18;
            button4.Text = "Видалити";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 516);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Каталог товарів інтернет-магазину";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}