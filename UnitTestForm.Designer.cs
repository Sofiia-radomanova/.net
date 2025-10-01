namespace WinFormsLab1.net
{
    partial class UnitTestForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            rez2 = new Label();
            rez1 = new Label();
            label4 = new Label();
            button1 = new Button();
            c1 = new TextBox();
            b1 = new TextBox();
            a1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            rez3 = new Label();
            label5 = new Label();
            button2 = new Button();
            b2 = new TextBox();
            a2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(369, 293);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rez2);
            tabPage1.Controls.Add(rez1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(c1);
            tabPage1.Controls.Add(b1);
            tabPage1.Controls.Add(a1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(361, 260);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Завдання 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rez2
            // 
            rez2.AutoSize = true;
            rez2.Location = new Point(112, 203);
            rez2.Name = "rez2";
            rez2.Size = new Size(0, 20);
            rez2.TabIndex = 9;
            // 
            // rez1
            // 
            rez1.AutoSize = true;
            rez1.Location = new Point(119, 202);
            rez1.Name = "rez1";
            rez1.Size = new Size(0, 20);
            rez1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 201);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "Результат:";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(40, 153);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 6;
            button1.Text = "Розрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // c1
            // 
            c1.Location = new Point(63, 109);
            c1.Name = "c1";
            c1.Size = new Size(125, 27);
            c1.TabIndex = 5;
            // 
            // b1
            // 
            b1.Location = new Point(63, 68);
            b1.Name = "b1";
            b1.Size = new Size(125, 27);
            b1.TabIndex = 4;
            b1.TextChanged += textBox2_TextChanged;
            // 
            // a1
            // 
            a1.Location = new Point(63, 32);
            a1.Name = "a1";
            a1.Size = new Size(125, 27);
            a1.TabIndex = 3;
            a1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 107);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 2;
            label3.Text = "c =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "b =";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "a =";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rez3);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(b2);
            tabPage2.Controls.Add(a2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(361, 260);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Завдання 2";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // rez3
            // 
            rez3.AutoSize = true;
            rez3.Location = new Point(109, 138);
            rez3.Name = "rez3";
            rez3.Size = new Size(0, 20);
            rez3.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 138);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 15;
            label5.Text = "Результат:";
            // 
            // button2
            // 
            button2.Location = new Point(48, 90);
            button2.Name = "button2";
            button2.Size = new Size(106, 29);
            button2.TabIndex = 14;
            button2.Text = "Розрахувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // b2
            // 
            b2.Location = new Point(66, 51);
            b2.Name = "b2";
            b2.Size = new Size(125, 27);
            b2.TabIndex = 12;
            b2.TextChanged += textBox5_TextChanged;
            // 
            // a2
            // 
            a2.Location = new Point(66, 15);
            a2.Name = "a2";
            a2.Size = new Size(125, 27);
            a2.TabIndex = 11;
            a2.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 90);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 51);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 9;
            label7.Text = "b =";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 15);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 8;
            label8.Text = "a =";
            // 
            // button3
            // 
            button3.Location = new Point(12, 311);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 1;
            button3.Text = "Закрити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UnitTestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 379);
            Controls.Add(button3);
            Controls.Add(tabControl1);
            Name = "UnitTestForm";
            Text = "UnitTestForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Label label4;
        private Button button1;
        private TextBox c1;
        private TextBox b1;
        private TextBox a1;
        private Label label5;
        private Button button2;
        private TextBox b2;
        private TextBox a2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button3;
        private Label rez1;
        private Label rez2;
        private Label rez3;
    }
}