namespace QC_coder
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBarcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToBMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTIFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dQRCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToPNGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToBMPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTIFFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog4 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog5 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog6 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog7 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog8 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 217);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter text here :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Location = new System.Drawing.Point(205, 282);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(583, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preview :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Location = new System.Drawing.Point(205, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "🌟 Get 1D Barcode  🌟";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(383, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "🌟 Get 2D QR code  🌟";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkKhaki;
            this.button3.Location = new System.Drawing.Point(561, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "🖼️ EXPORT 1D BRACODE TO IMAGE 🖼️";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button4.Location = new System.Drawing.Point(205, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 36);
            this.button4.TabIndex = 11;
            this.button4.Text = "🖼️ EXPORT 2D QR CODE TO IMAGE 🖼️";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXPORTToolStripMenuItem,
            this.cLOSEToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // eXPORTToolStripMenuItem
            // 
            this.eXPORTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBarcodeToolStripMenuItem,
            this.dQRCodeToolStripMenuItem});
            this.eXPORTToolStripMenuItem.Name = "eXPORTToolStripMenuItem";
            this.eXPORTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eXPORTToolStripMenuItem.Text = "EXPORT";
            // 
            // dBarcodeToolStripMenuItem
            // 
            this.dBarcodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToPNGToolStripMenuItem,
            this.exportToBMPToolStripMenuItem,
            this.exportToTIFFToolStripMenuItem});
            this.dBarcodeToolStripMenuItem.Name = "dBarcodeToolStripMenuItem";
            this.dBarcodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dBarcodeToolStripMenuItem.Text = "1D barcode";
            // 
            // exportToPNGToolStripMenuItem
            // 
            this.exportToPNGToolStripMenuItem.Name = "exportToPNGToolStripMenuItem";
            this.exportToPNGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToPNGToolStripMenuItem.Text = "Export to PNG";
            this.exportToPNGToolStripMenuItem.Click += new System.EventHandler(this.exportToPNGToolStripMenuItem_Click);
            // 
            // exportToBMPToolStripMenuItem
            // 
            this.exportToBMPToolStripMenuItem.Name = "exportToBMPToolStripMenuItem";
            this.exportToBMPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToBMPToolStripMenuItem.Text = "Export to BMP";
            this.exportToBMPToolStripMenuItem.Click += new System.EventHandler(this.exportToBMPToolStripMenuItem_Click);
            // 
            // exportToTIFFToolStripMenuItem
            // 
            this.exportToTIFFToolStripMenuItem.Name = "exportToTIFFToolStripMenuItem";
            this.exportToTIFFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToTIFFToolStripMenuItem.Text = "Export to TIFF";
            this.exportToTIFFToolStripMenuItem.Click += new System.EventHandler(this.exportToTIFFToolStripMenuItem_Click);
            // 
            // dQRCodeToolStripMenuItem
            // 
            this.dQRCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToPNGToolStripMenuItem1,
            this.exportToBMPToolStripMenuItem1,
            this.exportToTIFFToolStripMenuItem1});
            this.dQRCodeToolStripMenuItem.Name = "dQRCodeToolStripMenuItem";
            this.dQRCodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dQRCodeToolStripMenuItem.Text = "2D QR code";
            // 
            // exportToPNGToolStripMenuItem1
            // 
            this.exportToPNGToolStripMenuItem1.Name = "exportToPNGToolStripMenuItem1";
            this.exportToPNGToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exportToPNGToolStripMenuItem1.Text = "Export to PNG";
            this.exportToPNGToolStripMenuItem1.Click += new System.EventHandler(this.exportToPNGToolStripMenuItem1_Click);
            // 
            // exportToBMPToolStripMenuItem1
            // 
            this.exportToBMPToolStripMenuItem1.Name = "exportToBMPToolStripMenuItem1";
            this.exportToBMPToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exportToBMPToolStripMenuItem1.Text = "Export to BMP";
            this.exportToBMPToolStripMenuItem1.Click += new System.EventHandler(this.exportToBMPToolStripMenuItem1_Click);
            // 
            // exportToTIFFToolStripMenuItem1
            // 
            this.exportToTIFFToolStripMenuItem1.Name = "exportToTIFFToolStripMenuItem1";
            this.exportToTIFFToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exportToTIFFToolStripMenuItem1.Text = "Export to TIFF";
            this.exportToTIFFToolStripMenuItem1.Click += new System.EventHandler(this.exportToTIFFToolStripMenuItem1_Click);
            // 
            // cLOSEToolStripMenuItem
            // 
            this.cLOSEToolStripMenuItem.Name = "cLOSEToolStripMenuItem";
            this.cLOSEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cLOSEToolStripMenuItem.Text = "CLOSE";
            this.cLOSEToolStripMenuItem.Click += new System.EventHandler(this.cLOSEToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QC coder project";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBarcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToPNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToBMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToTIFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dQRCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToPNGToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToBMPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToTIFFToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cLOSEToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog8;
    }
}