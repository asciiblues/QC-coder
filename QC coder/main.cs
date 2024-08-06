using Microsoft.Win32;
using QRCoder;
using Spire.Pdf.Graphics;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
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
            button5.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button7.Hide();
            button6.Hide();button8.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button5.Show();
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox2.Image = barcode.Draw(richTextBox1.Text, 20);
            button3.Show();
            button5.Show();
            button6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(richTextBox1.Text, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);
            pictureBox1.Image = qrCode.GetGraphic(5);
            button4.Show();
            button7.Show();
            button8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = ("JPEG image |*.jpeg");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("File has saved to " + saveFileDialog1.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You're not save the JPEG image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
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
                MessageBox.Show("File has saved to " + saveFileDialog2.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You're not save the JPEG image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                MessageBox.Show("File has saved to " + saveFileDialog3.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You're not save the PNG image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void exportToBMPToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog4.Filter = ("BMP image |*.bmp");
            if (saveFileDialog4.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("File has saved to " + saveFileDialog4.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You're not save the BMP image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void exportToTIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog5.Filter = ("TIFF image |*.tiff");
            if (saveFileDialog5.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("File has saved to " + saveFileDialog5.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You're not save the TIFF image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void exportToPNGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog6.Filter = ("PNG image |*.png");
            if (saveFileDialog6.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("File has saved to " + saveFileDialog6.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You're not save the PNG image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void exportToBMPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog7.Filter = ("BMP image |*.bmp");
            if (saveFileDialog7.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("File has saved to " + saveFileDialog7.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You're not save the BMP image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void exportToTIFFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog8.Filter = ("TIFF image |*.tiff");
            if (saveFileDialog8.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("File has saved to " + saveFileDialog8.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You're not save the TIFF image", "Image not svaed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += PRIPAG1;
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print(); 
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void PRIPAG1(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.DrawToBitmap(bitmap, new Rectangle(0,0,pictureBox2.Width, pictureBox2.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
            bitmap.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            printDocument2.PrintPage += PRIPAG2;
            printDialog2.Document = printDocument1;
            if (printDialog2.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
        }

        private void PRIPAG2(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bitmap, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
            bitmap.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog9.Filter = ("Pdf file |*.pdf");
            if (saveFileDialog9.ShowDialog() == DialogResult.OK)
            {
                //Create a PdfDocument object

                PdfDocument doc = new PdfDocument();
                //Set the margins
                doc.PageSettings.SetMargins(0);
                //Load an Image
                Image image = pictureBox2.Image;

                //Get the image width and height
                
            float width = image.PhysicalDimension.Width;
                
            float height = image.PhysicalDimension.Height;




                //Add a page of the same size as the image

                PdfPageBase page = doc.Pages.Add(new SizeF(width, height));





                //Create a PdfImage object based on the image

                PdfImage pdfImage = PdfImage.FromImage(image);
                



            //Draw image at (0, 0) of the page
            page.Canvas.DrawImage(pdfImage, 0, 0, pdfImage.Width, pdfImage.Height);

                //Save to PDF
                doc.SaveToFile(saveFileDialog9.FileName);
            }
            else { MessageBox.Show("File is not saved", "File not saved", MessageBoxButtons.OK, MessageBoxIcon.Information);  }
          
            


        }

        private void button8_Click(object sender, EventArgs e)
        {
            saveFileDialog10.Filter = ("Pdf file |*.pdf");
            if (saveFileDialog10.ShowDialog() == DialogResult.OK)
            {
                //Create a PdfDocument object

                PdfDocument doc = new PdfDocument();
                //Set the margins
                doc.PageSettings.SetMargins(0);
                //Load an Image
                Image image = pictureBox1.Image;

                //Get the image width and height

                float width = image.PhysicalDimension.Width;

                float height = image.PhysicalDimension.Height;




                //Add a page of the same size as the image

                PdfPageBase page = doc.Pages.Add(new SizeF(width, height));





                //Create a PdfImage object based on the image

                PdfImage pdfImage = PdfImage.FromImage(image);




                //Draw image at (0, 0) of the page
                page.Canvas.DrawImage(pdfImage, 0, 0, pdfImage.Width, pdfImage.Height);

                //Save to PDF
                doc.SaveToFile(saveFileDialog10.FileName);
            }
            else { MessageBox.Show("File is not saved", "File not saved", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}

