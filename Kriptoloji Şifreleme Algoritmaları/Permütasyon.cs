using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kriptoloji_Şifreleme_Algoritmaları
{
    public partial class Permütasyon : UserControl
    {
        public Permütasyon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text = "";

                // bool tanımlamarı
                bool anahtardaaynirakamlarvarmi = true;
                bool anahtarınuzunluğundanbüyükrakamvarmı = true;

                // değişken tanımlamaları
                string metin = richTextBox1.Text;
                long anahtarl = long.Parse(textBox1.Text);
                string anahtars = textBox1.Text;
                string sadeceharflimetin = "";




                for (int i = 0; i < metin.Length; i++)
                {
                    int a = ((int)metin[i]);
                    char b = metin[i];
                    if ((a >= 65 && a <= 90) || (a >= 97 && a <= 122) || b == 'ç' || b == 'ğ' || b == 'ı' || b == 'j' || b == 'o' || b == 'ş' || b == 'ü' || b == 'u' || b == 'Ç' || b == 'Ğ' || b == 'İ' || b == 'J' || b == 'Ö' || b == 'Ş' || b == 'Ü' || b == 'U')
                        sadeceharflimetin += metin[i];
                }

                if (sadeceharflimetin.Length % anahtars.Length > 0)
                {
                    int a = sadeceharflimetin.Length % anahtars.Length;
                    a = anahtars.Length - a;

                    for (int i = 0; i < a; i++)
                    {
                        sadeceharflimetin += 'a';
                        richTextBox1.Text += 'a';
                        metin += 'a';
                    }
                }





                for (int i = 0; i < anahtars.Length; i++) // Anahtarda ayni rakamlar bulunamaz.
                {
                    for (int a = 0; a < anahtars.Length; a++)
                    {
                        if (anahtars[a] == '0')
                            anahtardaaynirakamlarvarmi = false;
                        else if (i == a)
                            continue;
                        else if (anahtars[i] == anahtars[a])
                        {
                            anahtardaaynirakamlarvarmi = false;
                            break;
                        }
                    }
                }

                if (anahtardaaynirakamlarvarmi == false)
                {
                    MessageBox.Show("Anahtarınızda aynı rakamlar veya 0 bulunamaz!", "Anahtarlama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (anahtardaaynirakamlarvarmi)
                {

                    for (int i = 0; i < anahtars.Length; i++)
                    {
                        int tek = Convert.ToInt32(anahtars[i].ToString());

                        if (tek > anahtars.Length)
                            anahtarınuzunluğundanbüyükrakamvarmı = false;
                    }

                    if (anahtarınuzunluğundanbüyükrakamvarmı == false)
                    {
                        MessageBox.Show("Anahtarınızın uzunluğundan büyük bir rakam bulunmakta!", "Anahtarlama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        char[,] harfayir = new char[sadeceharflimetin.Length / anahtars.Length, anahtars.Length];

                        int g = 0;
                        for (int i = 0; i < sadeceharflimetin.Length / anahtars.Length; i++)
                        {
                            for (int s = 0; s < anahtars.Length; s++)
                            {
                                harfayir[i, s] = sadeceharflimetin[g];
                                g++;
                            }
                        }

                        int sol = 0;
                        int sag = 0;
                        for (int i = 0; i < metin.Length; i++)
                        {
                            char b = metin[i];
                            int a = ((int)metin[i]);


                            if (b == '\n')
                                richTextBox2.Text += '\n'.ToString();
                            else if ((b != 'a' && b != 'b' && b != 'c' && b != 'ç' && b != 'd' && b != 'e' && b != 'f' && b != 'g' && b != 'ğ' && b != 'h' && b != 'ı' && b != 'i' && b != 'j' && b != 'k' && b != 'l' && b != 'm' && b != 'n' && b != 'o' && b != 'ö' && b != 'p' && b != 'r' && b != 's' && b != 'ş' && b != 't' && b != 'u' && b != 'ü' && b != 'v' && b != 'y' && b != 'z' && b != 'q' && b != 'w' && b != 'x' && b != 'w' && b != 'Q' && b != 'W' && b != 'X' && b != 'A' && b != 'B' && b != 'C' && b != 'Ç' && b != 'D' && b != 'E' && a != 'F' && b != 'G' && b != 'Ğ' && b != 'H' && b != 'I' && b != 'İ' && b != 'J' && b != 'K' && b != 'L' && b != 'M' && b != 'N' && b != 'O' && b != 'Ö' && b != 'P' && b != 'R' && b != 'S' && b != 'Ş' && b != 'T' && b != 'U' && b != 'Ü' && b != 'V' && b != 'Y' && b != 'Z'))
                            {
                                richTextBox2.Text += b.ToString();
                            }
                            else
                            {
                                if (anahtars.Length == sag)
                                {
                                    sag = 0;
                                    sol++;
                                }

                                char f = anahtars[sag];

                                int d = Int32.Parse(f.ToString());

                                richTextBox2.Text += harfayir[sol, d - 1];
                                sag++;
                            }
                            a = 0;

                        }

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen doğru değerleri giriniz.", "Değer Girme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
            catch (Exception f)
            {
                MessageBox.Show("Bir hata meydana geldi.\nHata: " + f, "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text = "";
                bool anahtardaaynirakamlarvarmi = true;
                bool anahtarınuzunluğundanbüyükrakamvarmı = true;
                // değişken tanımlamaları
                string metin = richTextBox1.Text;
                long anahtarl = long.Parse(textBox1.Text);
                string anahtars = textBox1.Text;

                string sadeceharflimetin = "";

                for (int i = 0; i < metin.Length; i++)
                {
                    int a = ((int)metin[i]);
                    char b = metin[i];
                    if ((a >= 65 && a <= 90) || (a >= 97 && a <= 122) || b == 'ç' || b == 'ğ' || b == 'ı' || b == 'j' || b == 'o' || b == 'ş' || b == 'ü' || b == 'u' || b == 'Ç' || b == 'Ğ' || b == 'İ' || b == 'J' || b == 'Ö' || b == 'Ş' || b == 'Ü' || b == 'U')
                        sadeceharflimetin += metin[i];
                } // özel karakterler yok.

                if (sadeceharflimetin.Length % anahtars.Length > 0)
                {
                    int a = sadeceharflimetin.Length % anahtars.Length;
                    a = anahtars.Length - a;

                    for (int i = 0; i < a; i++)
                    {
                        sadeceharflimetin += 'a';
                        richTextBox1.Text += 'a';
                        metin += 'a';
                    }
                } // anahtara bölünmezse a harfi ekleniyor.

                for (int i = 0; i < anahtars.Length; i++) // Anahtarda ayni rakamlar bulunamaz.
                {
                    for (int a = 0; a < anahtars.Length; a++)
                    {
                        if (anahtars[a] == '0')
                            anahtardaaynirakamlarvarmi = false;
                        else if (i == a)
                            continue;
                        else if (anahtars[i] == anahtars[a])
                        {
                            anahtardaaynirakamlarvarmi = false;
                            break;
                        }
                    }
                }

                if (anahtardaaynirakamlarvarmi == false)
                {
                    MessageBox.Show("Anahtarınızda aynı rakamlar veya 0 bulunamaz!", "Anahtarlama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (anahtardaaynirakamlarvarmi)
                {

                    for (int i = 0; i < anahtars.Length; i++)
                    {
                        int tek = Convert.ToInt32(anahtars[i].ToString());

                        if (tek > anahtars.Length)
                            anahtarınuzunluğundanbüyükrakamvarmı = false;
                    }
                }
                if (anahtarınuzunluğundanbüyükrakamvarmı == false)
                {
                    MessageBox.Show("Anahtarınızın uzunluğundan büyük bir rakam bulunmakta!", "Anahtarlama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    char[,] harfayir = new char[sadeceharflimetin.Length / anahtars.Length, anahtars.Length];

                    int g = 0;
                    for (int i = 0; i < sadeceharflimetin.Length / anahtars.Length; i++)
                    {
                        for (int s = 0; s < anahtars.Length; s++)
                        {
                            int ayir = (Convert.ToInt32(anahtars[s].ToString()));
                            ayir--;
                            harfayir[i, ayir] = sadeceharflimetin[g];
                            g++;
                        }
                    }

                    int sol = 0;
                    int sag = 0;
                    for (int i = 0; i < metin.Length; i++)
                    {
                        char b = metin[i];
                        int a = ((int)metin[i]);


                        if (b == '\n')
                            richTextBox2.Text += '\n'.ToString();
                        else if ((b != 'a' && b != 'b' && b != 'c' && b != 'ç' && b != 'd' && b != 'e' && b != 'f' && b != 'g' && b != 'ğ' && b != 'h' && b != 'ı' && b != 'i' && b != 'j' && b != 'k' && b != 'l' && b != 'm' && b != 'n' && b != 'o' && b != 'ö' && b != 'p' && b != 'r' && b != 's' && b != 'ş' && b != 't' && b != 'u' && b != 'ü' && b != 'v' && b != 'y' && b != 'z' && b != 'q' && b != 'w' && b != 'x' && b != 'w' && b != 'Q' && b != 'W' && b != 'X' && b != 'A' && b != 'B' && b != 'C' && b != 'Ç' && b != 'D' && b != 'E' && a != 'F' && b != 'G' && b != 'Ğ' && b != 'H' && b != 'I' && b != 'İ' && b != 'J' && b != 'K' && b != 'L' && b != 'M' && b != 'N' && b != 'O' && b != 'Ö' && b != 'P' && b != 'R' && b != 'S' && b != 'Ş' && b != 'T' && b != 'U' && b != 'Ü' && b != 'V' && b != 'Y' && b != 'Z'))
                        {
                            richTextBox2.Text += b.ToString();
                        }
                        else
                        {
                            if (anahtars.Length == sag)
                            {
                                sag = 0;
                                sol++;
                            }




                            richTextBox2.Text += harfayir[sol, sag];
                            sag++;
                        }
                        a = 0;



                    }
                }



            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen doğru değerleri giriniz.", "Değer Girme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
            catch (Exception f)
            {
                MessageBox.Show("Bir hata meydana geldi.\nHata: " + f, "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
        }


        public void resetle()
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            textBox1.Text = "";
        }
    }
}
