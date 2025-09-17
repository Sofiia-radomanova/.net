using WinFormsLab1.net.class_lab1;

namespace WinFormsLab1.net
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabul tabul = new Tabul();

            double xn, xk, a, h;

            xn = Convert.ToDouble(this.textBox1.Text);
            xk = Convert.ToDouble(this.textBox2.Text);
            h = Convert.ToDouble(this.textBox3.Text);
            a = Convert.ToDouble(this.textBox4.Text);

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            tabul.tab(xn, xk, a, h);

            for (int i = 0; i < tabul.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tabul.xy[i, 0], 2).ToString(),
                    Math.Round(tabul.xy[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);
            }
        }

        private void одновимірнийМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void двовимірнийМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
