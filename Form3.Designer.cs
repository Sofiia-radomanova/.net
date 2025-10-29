namespace WinFormsLab1.net
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.Location = new Point(607, 398);
            button1.Name = "button1";
            button1.Size = new Size(163, 40);
            button1.TabIndex = 0;
            button1.Text = "закрити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(519, 426);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 21);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 2;
            label1.Text = "N=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(560, 58);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 3;
            label2.Text = "M=";
            // 
            // button2
            // 
            button2.Location = new Point(558, 90);
            button2.Name = "button2";
            button2.Size = new Size(193, 32);
            button2.TabIndex = 4;
            button2.Text = "Обрахунок";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(605, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(605, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 27);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(561, 143);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "Сума";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 183);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 8;
            label4.Text = "Добуток";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
    }
}