namespace _13_14_Odev
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniDosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textDüzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.textDüzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaAçToolStripMenuItem,
            this.yeniDosyaToolStripMenuItem,
            this.dosyaKaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "Dosya";
            // 
            // dosyaAçToolStripMenuItem
            // 
            this.dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            this.dosyaAçToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dosyaAçToolStripMenuItem.Text = "Dosya Aç";
            this.dosyaAçToolStripMenuItem.Click += new System.EventHandler(this.dosya_ac);
            // 
            // yeniDosyaToolStripMenuItem
            // 
            this.yeniDosyaToolStripMenuItem.Name = "yeniDosyaToolStripMenuItem";
            this.yeniDosyaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yeniDosyaToolStripMenuItem.Text = "Yeni Dosya";
            this.yeniDosyaToolStripMenuItem.Click += new System.EventHandler(this.yeni_dosya_click);
            // 
            // dosyaKaydetToolStripMenuItem
            // 
            this.dosyaKaydetToolStripMenuItem.Name = "dosyaKaydetToolStripMenuItem";
            this.dosyaKaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dosyaKaydetToolStripMenuItem.Text = "Dosya Kaydet";
            this.dosyaKaydetToolStripMenuItem.Click += new System.EventHandler(this.dosya_kaydet);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farkli_kaydet_click);
            // 
            // textDüzenToolStripMenuItem
            // 
            this.textDüzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkDüzenleToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.textDüzenToolStripMenuItem.Name = "textDüzenToolStripMenuItem";
            this.textDüzenToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.textDüzenToolStripMenuItem.Text = "Text / Düzen";
            // 
            // renkDüzenleToolStripMenuItem
            // 
            this.renkDüzenleToolStripMenuItem.Name = "renkDüzenleToolStripMenuItem";
            this.renkDüzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.renkDüzenleToolStripMenuItem.Text = "Renk Düzenle";
            this.renkDüzenleToolStripMenuItem.Click += new System.EventHandler(this.renk_duzenle_click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Font / Size";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.font_size_click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(420, 327);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Değiştir";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(318, 25);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 6;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(155, 418);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(75, 23);
            this.btncikis.TabIndex = 7;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 453);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniDosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textDüzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

