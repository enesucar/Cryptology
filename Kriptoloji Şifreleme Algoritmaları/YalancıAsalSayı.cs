using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Kriptoloji_Şifreleme_Algoritmaları
{
    public partial class YalancıAsalSayı : UserControl
    {
        public YalancıAsalSayı()
        {
            InitializeComponent();
        }

        char ayir;
        int ksay = 0;
        int bsay = 0;
        int b = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (b > 0)
            {
                richTextBox2.Text = "";
            }
            else
                b++;
            ArrayList harfayarla = new ArrayList();
            string kelime = richTextBox1.Text;
            int anahtar1 = (int)numericUpDown1.Value;
            int anahtar2 = (int)numericUpDown2.Value;
            int sayac = 0;
            int say = 0;

            for (int i = 2; i < anahtar1; i++)
                if (anahtar1 % i == 0)
                    sayac++;

            for (int i = 2; i < anahtar2; i++)
                if (anahtar2 % i == 0)
                    sayac++;

            if (anahtar1 < 2 || anahtar2 < 2)
                MessageBox.Show("Lütfen anahtar kısmına asal değerler giriniz.", "Anahtar Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (sayac > 0)
                MessageBox.Show("Lütfen anahtar kısmına asal değerler giriniz.", "Anahtar Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (sayac == 0)
            {
                foreach (char a in kelime)
                {
                    ayir = a;
                    AlfabeHarfKarsiligi();

                    if (ksay > 0)
                    {
                        if (say % 2 == 0)
                        {
                            for (int i = anahtar1; i > 0; i--)
                            {
                                ksay--;
                                if (ksay == 0)
                                    ksay = 29;
                            }
                            say++;

                        }
                        else
                        {
                            for (int i = anahtar2; i > 0; i--)
                            {
                                ksay--;
                                if (ksay == 0)
                                    ksay = 29;
                            }
                            say++;
                        }

                    }
                    else if (bsay > 0)
                    {
                        if (say % 2 == 0)
                        {
                            for (int i = anahtar1; i > 0; i--)
                            {
                                bsay--;
                                if (bsay == 0)
                                    bsay = 29;

                            }
                            say++;
                        }
                        else
                        {
                            for (int i = anahtar2; i > 0; i--)
                            {
                                bsay--;
                                if (bsay == 0)
                                    bsay = 29;
                            }
                            say++;
                        }
                    }
                    AlfabeSayiKarsiligi();
                    richTextBox2.Text += ayir;
                    bsay = 0;
                    ksay = 0;

                }



            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (b > 0)
            {
                richTextBox2.Text = "";
            }
            else
                b++;

            ArrayList harfayarla = new ArrayList();
            string kelime = richTextBox1.Text;
            int anahtar1 = (int)numericUpDown1.Value;
            int anahtar2 = (int)numericUpDown2.Value;
            int sayac = 0;
            int say = 0;
            int toplam = 0;

            for (int i = 2; i < anahtar1; i++)
                if (anahtar1 % i == 0)
                    sayac++;

            for (int i = 2; i < anahtar2; i++)
                if (anahtar2 % i == 0)
                    sayac++;

            if (anahtar1 < 2 || anahtar2 < 2)
                MessageBox.Show("Lütfen anahtar kısmına asal değerler giriniz.", "Anahtar Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (sayac > 0)
                MessageBox.Show("Lütfen anahtar kısmına asal değerler giriniz.", "Anahtar Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (sayac == 0)
            {


                foreach (char a in kelime)
                {
                    ayir = a;
                    AlfabeHarfKarsiligi();

                    if (ksay > 0)
                    {
                        if (say % 2 == 0)
                        {
                            toplam = (anahtar1 + ksay) % 29;

                            if (toplam == 0)
                                toplam = 29;

                            ksay = toplam;
                            say++;

                        }
                        else
                        {
                            toplam = (anahtar2 + ksay) % 29;

                            if (toplam == 0)
                                toplam = 29;

                            ksay = toplam;
                            say++;
                        }
                    }
                    if (bsay > 0)
                    {
                        if (say % 2 == 0)
                        {
                            toplam = (anahtar1 + bsay) % 29;

                            if (toplam == 0)
                                toplam = 29;

                            bsay = toplam;
                            say++;

                        }
                        else
                        {
                            toplam = (anahtar2 + bsay) % 29;

                            if (toplam == 0)
                                toplam = 29;

                            bsay = toplam;
                            say++;
                        }
                    }

                    AlfabeSayiKarsiligi();
                    richTextBox2.Text += ayir;
                    ksay = 0;
                    bsay = 0;
                    toplam = 0;

                }
            }

        }

        public void AlfabeSayiKarsiligi()
        {

            if (ksay == 1)
                ayir = 'a';
            if (bsay == 1)
                ayir = 'A';

            if (ksay == 2)
                ayir = 'b';
            if (bsay == 2)
                ayir = 'B';

            if (ksay == 3)
                ayir = 'c';
            if (bsay == 3)
                ayir = 'C';

            if (ksay == 4)
                ayir = 'ç';
            if (bsay == 4)
                ayir = 'Ç';

            if (ksay == 5)
                ayir = 'd';
            if (bsay == 5)
                ayir = 'D';

            if (ksay == 6)
                ayir = 'e';
            if (bsay == 6)
                ayir = 'E';

            if (ksay == 7)
                ayir = 'f';
            if (bsay == 7)
                ayir = 'F';

            if (ksay == 8)
                ayir = 'g';
            if (bsay == 8)
                ayir = 'G';

            if (ksay == 9)
                ayir = 'ğ';
            if (bsay == 9)
                ayir = 'Ğ';

            if (ksay == 10)
                ayir = 'h';
            if (bsay == 10)
                ayir = 'H';

            if (ksay == 11)
                ayir = 'ı';
            if (bsay == 11)
                ayir = 'I';

            if (ksay == 12)
                ayir = 'i';
            if (bsay == 12)
                ayir = 'İ';

            if (ksay == 13)
                ayir = 'j';
            if (bsay == 13)
                ayir = 'J';

            if (ksay == 14)
                ayir = 'k';
            if (bsay == 14)
                ayir = 'K';

            if (ksay == 15)
                ayir = 'l';
            if (bsay == 15)
                ayir = 'L';

            if (ksay == 16)
                ayir = 'm';
            if (bsay == 16)
                ayir = 'M';

            if (ksay == 17)
                ayir = 'n';
            if (bsay == 17)
                ayir = 'N';

            if (ksay == 18)
                ayir = 'o';
            if (bsay == 18)
                ayir = 'O';

            if (ksay == 19)
                ayir = 'ö';
            if (bsay == 19)
                ayir = 'Ö';

            if (ksay == 20)
                ayir = 'p';
            if (bsay == 20)
                ayir = 'P';

            if (ksay == 21)
                ayir = 'r';
            if (bsay == 21)
                ayir = 'R';

            if (ksay == 22)
                ayir = 's';
            if (bsay == 22)
                ayir = 'S';

            if (ksay == 23)
                ayir = 'ş';
            if (bsay == 23)
                ayir = 'Ş';

            if (ksay == 24)
                ayir = 't';
            if (bsay == 24)
                ayir = 'T';

            if (ksay == 25)
                ayir = 'u';
            if (bsay == 25)
                ayir = 'U';

            if (ksay == 26)
                ayir = 'ü';
            if (bsay == 26)
                ayir = 'Ü';

            if (ksay == 27)
                ayir = 'v';
            if (bsay == 27)
                ayir = 'V';

            if (ksay == 28)
                ayir = 'y';
            if (bsay == 28)
                ayir = 'Y';

            if (ksay == 29)
                ayir = 'z';
            if (bsay == 29)
                ayir = 'Z';






        }

        public void AlfabeHarfKarsiligi()
        {
            if (ayir == 'a')
                ksay = 1;
            if (ayir == 'A')
                bsay = 1;

            if (ayir == 'b')
                ksay = 2;
            if (ayir == 'B')
                bsay = 2;

            if (ayir == 'c')
                ksay = 3;
            if (ayir == 'C')
                bsay = 3;

            if (ayir == 'ç')
                ksay = 4;
            if (ayir == 'Ç')
                bsay = 4;

            if (ayir == 'd')
                ksay = 5;
            if (ayir == 'D')
                bsay = 5;

            if (ayir == 'e')
                ksay = 6;
            if (ayir == 'E')
                bsay = 6;

            if (ayir == 'f')
                ksay = 7;
            if (ayir == 'F')
                bsay = 7;


            if (ayir == 'g')
                ksay = 8;
            if (ayir == 'G')
                bsay = 8;

            if (ayir == 'ğ')
                ksay = 9;
            if (ayir == 'Ğ')
                bsay = 9;

            if (ayir == 'h')
                ksay = 10;
            if (ayir == 'H')
                bsay = 10;

            if (ayir == 'ı')
                ksay = 11;
            if (ayir == 'I')
                bsay = 11;


            if (ayir == 'i')
                ksay = 12;
            if (ayir == 'İ')
                bsay = 12;


            if (ayir == 'j')
                ksay = 13;
            if (ayir == 'J')
                bsay = 13;

            if (ayir == 'k')
                ksay = 14;
            if (ayir == 'K')
                bsay = 14;

            if (ayir == 'l')
                ksay = 15;
            if (ayir == 'L')
                bsay = 15;


            if (ayir == 'm')
                ksay = 16;
            if (ayir == 'M')
                bsay = 16;


            if (ayir == 'n')
                ksay = 17;
            if (ayir == 'N')
                bsay = 17;

            if (ayir == 'o')
                ksay = 18;
            if (ayir == 'O')
                bsay = 18;

            if (ayir == 'ö')
                ksay = 19;
            if (ayir == 'Ö')
                bsay = 19;

            if (ayir == 'p')
                ksay = 20;
            if (ayir == 'P')
                bsay = 20;

            if (ayir == 'r')
                ksay = 21;
            if (ayir == 'R')
                bsay = 21;

            if (ayir == 's')
                ksay = 22;
            if (ayir == 'S')
                bsay = 22;

            if (ayir == 'ş')
                ksay = 23;
            if (ayir == 'Ş')
                bsay = 23;

            if (ayir == 't')
                ksay = 24;
            if (ayir == 'T')
                bsay = 24;

            if (ayir == 'u')
                ksay = 25;
            if (ayir == 'U')
                bsay = 25;

            if (ayir == 'ü')
                ksay = 26;
            if (ayir == 'Ü')
                bsay = 26;

            if (ayir == 'v')
                ksay = 27;
            if (ayir == 'V')
                bsay = 27;


            if (ayir == 'y')
                ksay = 28;
            if (ayir == 'Y')
                bsay = 28;


            if (ayir == 'z')
                ksay = 29;
            if (ayir == 'Z')
                bsay = 29;

        }

        public void resetle()
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;

        }
    }
}
