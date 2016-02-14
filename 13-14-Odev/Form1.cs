using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _13_14_Odev
{
    public partial class Form1 : Form
    {
        string aranankelime = "";
        string metin = "";
        bool deger = false;
        string yaz = "";
        public Form1()
        {
            InitializeComponent();
        }

        private bool Bul()
        {
            deger = false;
            aranankelime = textBox1.Text;
            metin = richTextBox1.Text;
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;

            if (!string.IsNullOrEmpty(metin.Trim()) && !string.IsNullOrEmpty(aranankelime.Trim()))
            {
                if (metin.Length >= aranankelime.Length)
                {
                    if (metin.Contains(aranankelime))
                    {
                        for (int i = 0; i < metin.Length - aranankelime.Length + 1; i++)
                        {
                            if (metin.Substring(i, aranankelime.Length) == aranankelime)
                            {
                                richTextBox1.Select(i, aranankelime.Length);
                                richTextBox1.SelectionColor = Color.Red;
                                deger = true;
                            }
                        }
                    }
                }
            }

            return deger;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Bul();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (deger)
            {
                if (!string.IsNullOrEmpty(textBox2.Text.Trim()))
                {
                    DialogResult result = MessageBox.Show("Değiştirmek istediğinizden emin misiniz?", "Confirmation", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        richTextBox1.Text = richTextBox1.Text.Replace(textBox1.Text, textBox2.Text);
                    }                  
                }

                else
                {
                    MessageBox.Show("İkinci alana bir ifade girmediniz.");
                }                                     
            }

            else
            {
                MessageBox.Show(string.Format("'{0}' ifadesi metin içerisinde bulunamadı!", textBox1.Text));
            }
        }   
        private void dosya_ac(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Tüm dosyalar(.*)|*.*| Zengin Metin Belgesi(*.rtf)|*.rtf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String filePath = openFileDialog1.FileName;
                if (Path.GetExtension(filePath) == ".rtf")
                {
                    yaz = filePath;
                    StreamReader rd = new StreamReader(filePath);
                    richTextBox1.Rtf = rd.ReadToEnd();
                    rd.Close();
                }

                else
                {
                    MessageBox.Show("Dosya uzantısı .rtf olmalıdır.");
                }                                                         
            }
        }

        private void dosya_kaydet(object sender, EventArgs e)
        {
            yaz = "varsayilan.rtf";
            StreamWriter sy = new StreamWriter(yaz);
            sy.Write(richTextBox1.Rtf);
            sy.Close();
        }

        private void yeni_dosya_click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void farkli_kaydet_click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Tüm dosyalar(.*)|*.*| Zengin Metin Belgesi(*.rtf)|*.rtf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String path = saveFileDialog1.FileName;
                StreamWriter yaz = new StreamWriter(path);
                yaz.Write(richTextBox1.Rtf);
                yaz.Close();
            }
        }

        private void renk_duzenle_click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;                
            }
        }

        private void font_size_click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
