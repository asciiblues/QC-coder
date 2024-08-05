using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QC_coder
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            richTextBox1.Hide();
            label1.Hide();
            label2.Hide();
            pictureBox1.Hide();pictureBox2.
                Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Show();
            label1.Show();
            label2.Show();
            pictureBox1.Show(); pictureBox2.
                Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Show();
            label1.Show();
            label2.Show();
            pictureBox1.Show(); pictureBox2.
                Show();
        }
    }
}
