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
    public partial class Polybius : UserControl
    {
        public Polybius()
        {
            InitializeComponent();
        }

        char harf;
        int sayi;
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (sayac > 0)
            {
                richTextBox2.Text = "";
            }
            else
                sayac++;
            richTextBox2.Text = "";
            string kelime = richTextBox1.Text;
            int kelimeuzunluk = kelime.Length;
            int say = 0;

            int sayisay = 0;
            foreach (char item in kelime)
            {
                char a = item;
                int b = ((int)a);

                if (b >= 49 && b <= 57)
                {
                    sayisay++;
                }

            }

            if (sayisay > 0)
                MessageBox.Show("Şifre oluşturulurken sayı girilmemeli!", "Anahtarlama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                foreach (char a in kelime)
                {
                    sayi = 0;
                    harf = a;
                    HarfiSayiyaDönüstür();

                    if (harf == '\n')
                    {

                        richTextBox2.Text = richTextBox2.Text.Substring(0, richTextBox2.TextLength - 1);
                        richTextBox2.Text += a;
                        say = 0;
                    }
                    else if (kelimeuzunluk == 1 && (sayi > 10 && sayi < 56))
                    {
                        say = 0;

                        richTextBox2.Text += (sayi);
                    }
                    else if (kelimeuzunluk > 0 && (sayi > 10 && sayi < 56))
                    {
                        richTextBox2.Text += (sayi + "-");
                        say = 0;
                    }
                    else if (harf == ' ')

                    {

                        if (say == 0)
                        {
                            richTextBox2.Text = richTextBox2.Text.Substring(0, richTextBox2.TextLength - 1);
                        }
                        say++;
                        richTextBox2.Text += " ";
                    }


                    kelimeuzunluk--;
                    sayi = 0;
                    say = 0;
                }
            }
        }

        string al = "";
        private void button2_Click(object sender, EventArgs e)
        {

            if (sayac > 0)
            {
                richTextBox2.Text = "";
            }
            else
                sayac++;

            string kelime = richTextBox1.Text;
            int say = 0;
            int kac = 0;
            richTextBox2.Text = "";


            foreach (char a in kelime)
            {
                say++;
                kac++;
                al += a.ToString();


                if (a == '1' || a == '2' || a == '3' || a == '4' || a == '5')
                {
                    if (say == 2)
                    {
                        SayiyiHarfeDonüstür();
                        say = 0;
                        al = "";
                    }



                }

                else if (a == 'a' || a == 'b' || a == 'c' || a == 'd' || a == 'e' || a == 'f' || a == 'g' || a == 'h' || a == 'ı' || a == 'j' || a == 'k' || a == 'l' || a == 'm' || a == 'n' || a == 'o' || a == 'p' || a == 'q' || a == 'r' || a == 's' || a == 't' || a == 'u' || a == 'v' || a == 'w' || a == 'x' || a == 'y' || a == 'z')
                {
                    richTextBox1.Text = "";
                    kac++;
                    richTextBox2.Text = "";
                    MessageBox.Show("Şifreli metinde lütfen harf girmeyiniz.", "Şifreli Metni Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                }

                else if (a == '\n')
                {
                    richTextBox2.Text += "\n";
                    say--;
                    al = "";
                }
                else if (a == ' ')
                {
                    richTextBox2.Text += " ";
                    say--;
                    al = "";
                }
                else if (a == '-')
                {

                    say--;
                    al = "";

                }
                else if ((int)a > 53 || (int)a < 49)
                {
                    richTextBox1.Text = "";
                    richTextBox2.Text = "";
                    MessageBox.Show("Lütfen doğru şifreleyiniz.", "Şifreli Metni Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            if (kac == 1)
                MessageBox.Show("Lütfen eksik değer girmeyiniz.", "Şifreli Metni Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

            al = "";
        }
        public void SayiyiHarfeDonüstür()
        {
            if (al == "11")
                richTextBox2.Text += 'a';
            if (al == "12")
                richTextBox2.Text += 'b';
            if (al == "13")
                richTextBox2.Text += 'c';
            if (al == "14")
                richTextBox2.Text += 'd';
            if (al == "15")
                richTextBox2.Text += 'e';
            if (al == "21")
                richTextBox2.Text += 'f';
            if (al == "22")
                richTextBox2.Text += 'g';
            if (al == "23")
                richTextBox2.Text += 'h';
            if (al == "24")
                richTextBox2.Text += "ı/j";
            if (al == "25")
                richTextBox2.Text += 'k';
            if (al == "31")
                richTextBox2.Text += 'l';
            if (al == "32")
                richTextBox2.Text += 'm';
            if (al == "33")
                richTextBox2.Text += 'n';
            if (al == "34")
                richTextBox2.Text += 'o';
            if (al == "35")
                richTextBox2.Text += 'p';
            if (al == "41")
                richTextBox2.Text += 'q';
            if (al == "42")
                richTextBox2.Text += 'r';
            if (al == "43")
                richTextBox2.Text += 's';
            if (al == "44")
                richTextBox2.Text += 't';
            if (al == "45")
                richTextBox2.Text += 'u';
            if (al == "51")
                richTextBox2.Text += 'v';
            if (al == "52")
                richTextBox2.Text += 'w';
            if (al == "53")
                richTextBox2.Text += 'x';
            if (al == "54")
                richTextBox2.Text += 'y';
            if (al == "55")
                richTextBox2.Text += 'z';

        }
        public void HarfiSayiyaDönüstür()
        {
            if (harf == 'a' || harf == 'A')
                sayi = 11;

            if (harf == 'b' || harf == 'B')
                sayi = 12;

            if (harf == 'c' || harf == 'C')
                sayi = 13;

            if (harf == 'd' || harf == 'D')
                sayi = 14;

            if (harf == 'e' || harf == 'E')
                sayi = 15;

            if (harf == 'f' || harf == 'F')
                sayi = 21;

            if (harf == 'g' || harf == 'G')
                sayi = 22;

            if (harf == 'H' || harf == 'h')
                sayi = 23;


            if (harf == 'i' || harf == 'I' || harf == 'j' || harf == 'J')
                sayi = 24;

            if (harf == 'k' || harf == 'K')
                sayi = 25;

            if (harf == 'l' || harf == 'L')
                sayi = 31;

            if (harf == 'm' || harf == 'M')
                sayi = 32;

            if (harf == 'n' || harf == 'N')
                sayi = 33;

            if (harf == 'o' || harf == 'O')
                sayi = 34;

            if (harf == 'p' || harf == 'P')
                sayi = 35;

            if (harf == 'q' || harf == 'Q')
                sayi = 41;

            if (harf == 'r' || harf == 'R')
                sayi = 42;

            if (harf == 's' || harf == 'S')
                sayi = 43;

            if (harf == 't' || harf == 'T')
                sayi = 44;

            if (harf == 'u' || harf == 'U')
                sayi = 45;

            if (harf == 'v' || harf == 'V')
                sayi = 51;

            if (harf == 'w' || harf == 'W')
                sayi = 52;

            if (harf == 'x' || harf == 'X')
                sayi = 53;

            if (harf == 'y' || harf == 'Y')
                sayi = 54;

            if (harf == 'z' || harf == 'Z')
                sayi = 55;
        }


        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            richTextBox2.Text = " ";
        }


        public void resetle()
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }
    }
}
