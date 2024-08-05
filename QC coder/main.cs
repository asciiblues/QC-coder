using Microsoft.Win32;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            button3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox2.Image = barcode.Draw(richTextBox1.Text, 20);
            button3.Show();
       }

        private void button2_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(richTextBox1.Text, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);
            pictureBox1.Image = qrCode.GetGraphic(20);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = ("JPEG image |*.jpeg");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("You're not save the JPEG image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("File has saved to " + saveFileDialog2.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog2.Filter = ("JPEG image |*.jpeg");
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("You're not save the JPEG image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("File has saved to " + saveFileDialog2.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportToPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog3.Filter = ("PNG image |*.png");
            if (saveFileDialog3.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("You're not save the PNG image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("File has saved to " + saveFileDialog3.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportToBMPToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog4.Filter = ("BMP image |*.bmp");
            if (saveFileDialog4.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("You're not save the BMP image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("File has saved to " + saveFileDialog4.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportToTIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog5.Filter = ("TIFF image |*.tiff");
            if (saveFileDialog5.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("You're not save the TIFF image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("File has saved to " + saveFileDialog5.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportToPNGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog6.Filter = ("PNG image |*.png");
            if (saveFileDialog6.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("You're not save the PNG image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("File has saved to " + saveFileDialog6.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportToBMPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog7.Filter = ("BMP image |*.bmp");
            if (saveFileDialog7.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("You're not save the BMP image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("File has saved to " + saveFileDialog7.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportToTIFFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog8.Filter = ("TIFF image |*.tiff");
            if (saveFileDialog8.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("You're not save the TIFF image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("File has saved to " + saveFileDialog8.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
