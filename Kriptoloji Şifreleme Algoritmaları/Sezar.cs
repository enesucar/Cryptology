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
    public partial class Sezar : UserControl
    {
        public Sezar()
        {
            InitializeComponent();
        }

        


        static int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (sayac > 0)
            {
                richTextBox2.Text = "";
            }
            else
                sayac++;


            int anahtar = Convert.ToInt32(numericUpDown1.Text);
            string replace = richTextBox1.Text;
            foreach (var a in richTextBox1.Text)
            {
                ayir = a;
                AlfabeHarfKarsiligi();

                if (ksay > 0)
                {
                    ktoplam = (ksay + anahtar) % 29;

                    if (ktoplam == 0)
                        ayir = 'z';
                }

                else if (bsay > 0)
                {
                    btoplam = (bsay + anahtar) % 29;

                    if (btoplam == 0)
                        ayir = 'z';
                }

                AlfabeSayiKarsiligi();
                richTextBox2.Text += ayir;

                ksay = 0;
                bsay = 0;
                btoplam = 0;
                ktoplam = 0;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac > 0)
            {
                richTextBox2.Text = "";
            }
            else
                sayac++;
            int anahtar = Convert.ToInt32(numericUpDown1.Text);
            string replace = richTextBox1.Text;

            anahtar = anahtar % 29;
            foreach (var a in richTextBox1.Text)
            {
                ayir = a;
                AlfabeHarfKarsiligi();



                if (bsay > 0)
                {
                    for (int i = anahtar; i > 0; i--)
                    {
                        bsay--;
                        if (bsay == 0)
                            bsay = 29;
                    }
                    btoplam = bsay;
                }
                else if (ksay > 0)
                {
                    for (int i = anahtar; i > 0; i--)
                    {
                        ksay--;

                        if (ksay == 0)
                            ksay = 29;


                    }
                    ktoplam = ksay;
                }

                AlfabeSayiKarsiligi();
                richTextBox2.Text += ayir;

                ksay = 0;
                bsay = 0;
                btoplam = 0;
                ktoplam = 0;

            }
        }
        int ksay;
        int bsay;
        int ktoplam;
        int btoplam;
        char ayir;
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
        public void AlfabeSayiKarsiligi()
        {

            if (ktoplam == 1)
                ayir = 'a';
            if (btoplam == 1)
                ayir = 'A';

            if (ktoplam == 2)
                ayir = 'b';
            if (btoplam == 2)
                ayir = 'B';

            if (ktoplam == 3)
                ayir = 'c';
            if (btoplam == 3)
                ayir = 'C';

            if (ktoplam == 4)
                ayir = 'ç';
            if (btoplam == 4)
                ayir = 'Ç';

            if (ktoplam == 5)
                ayir = 'd';
            if (btoplam == 5)
                ayir = 'D';

            if (ktoplam == 6)
                ayir = 'e';
            if (btoplam == 6)
                ayir = 'E';

            if (ktoplam == 7)
                ayir = 'f';
            if (btoplam == 7)
                ayir = 'F';

            if (ktoplam == 8)
                ayir = 'g';
            if (btoplam == 8)
                ayir = 'G';

            if (ktoplam == 9)
                ayir = 'ğ';
            if (btoplam == 9)
                ayir = 'Ğ';

            if (ktoplam == 10)
                ayir = 'h';
            if (btoplam == 10)
                ayir = 'H';

            if (ktoplam == 11)
                ayir = 'ı';
            if (btoplam == 11)
                ayir = 'I';

            if (ktoplam == 12)
                ayir = 'i';
            if (btoplam == 12)
                ayir = 'İ';

            if (ktoplam == 13)
                ayir = 'j';
            if (btoplam == 13)
                ayir = 'J';

            if (ktoplam == 14)
                ayir = 'k';
            if (btoplam == 14)
                ayir = 'K';

            if (ktoplam == 15)
                ayir = 'l';
            if (btoplam == 15)
                ayir = 'L';

            if (ktoplam == 16)
                ayir = 'm';
            if (btoplam == 16)
                ayir = 'M';

            if (ktoplam == 17)
                ayir = 'n';
            if (btoplam == 17)
                ayir = 'N';

            if (ktoplam == 18)
                ayir = 'o';
            if (btoplam == 18)
                ayir = 'O';

            if (ktoplam == 19)
                ayir = 'ö';
            if (btoplam == 19)
                ayir = 'Ö';

            if (ktoplam == 20)
                ayir = 'p';
            if (btoplam == 20)
                ayir = 'P';

            if (ktoplam == 21)
                ayir = 'r';
            if (btoplam == 21)
                ayir = 'R';

            if (ktoplam == 22)
                ayir = 's';
            if (btoplam == 22)
                ayir = 'S';

            if (ktoplam == 23)
                ayir = 'ş';
            if (btoplam == 23)
                ayir = 'Ş';

            if (ktoplam == 24)
                ayir = 't';
            if (btoplam == 24)
                ayir = 'T';

            if (ktoplam == 25)
                ayir = 'u';
            if (btoplam == 25)
                ayir = 'U';

            if (ktoplam == 26)
                ayir = 'ü';
            if (btoplam == 26)
                ayir = 'Ü';

            if (ktoplam == 27)
                ayir = 'v';
            if (btoplam == 27)
                ayir = 'V';

            if (ktoplam == 28)
                ayir = 'y';
            if (btoplam == 28)
                ayir = 'Y';

            if (ktoplam == 29)
                ayir = 'z';
            if (btoplam == 29)
                ayir = 'Z';

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }

        public void resetle()
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            numericUpDown1.Value = 3;
        }

        
    }
}
