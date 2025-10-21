namespace WinFormsLab1.net
{
    partial class Form2
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
            a = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.Location = new Point(619, 400);
            button1.Name = "button1";
            button1.Size = new Size(150, 38);
            button1.TabIndex = 0;
            button1.Text = "Закрити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { a });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(299, 433);
            dataGridView1.TabIndex = 1;
            // 
            // a
            // 
            a.HeaderText = "a";
            a.MinimumWidth = 6;
            a.Name = "a";
            a.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(472, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 25);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 3;
            label1.Text = "N=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 108);
            label2.Name = "label2";
            label2.Size = new Size(314, 20);
            label2.TabIndex = 4;
            label2.Text = "Найбільший елемент масиву та його індекс\r\n";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkKhaki;
            button2.Location = new Point(428, 66);
            button2.Name = "button2";
            button2.Size = new Size(213, 29);
            button2.TabIndex = 6;
            button2.Text = "Обрахунок";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn a;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}