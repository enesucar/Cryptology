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
    public partial class Atbash : UserControl
    {
        public Atbash()
        {
            InitializeComponent();
        }


        char ayir;
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (sayac > 0)
            {
                richTextBox2.Text = "";
            }
            else
                sayac++;
            string kelime = richTextBox1.Text;

            foreach (char a in kelime)
            {
                ayir = a;
                HarfDönüstür();
                richTextBox2.Text += ayir;
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
            string kelime = richTextBox1.Text;

            foreach (char a in kelime)
            {
                ayir = a;
                HarfDönüstür();
                richTextBox2.Text += ayir;
            }
        }
        private void HarfDönüstür()
        {
            if (ayir == 'a')  // a
                ayir = 'z';
            else if (ayir == 'A')
                ayir = 'Z';

            else if (ayir == 'b') // b
                ayir = 'y';
            else if (ayir == 'B')
                ayir = 'Y';

            else if (ayir == 'c') // c
                ayir = 'v';
            else if (ayir == 'C')
                ayir = 'V';

            else if (ayir == 'ç') // ç
                ayir = 'ü';
            else if (ayir == 'Ç')
                ayir = 'Ü';

            else if (ayir == 'd') // d
                ayir = 'u';
            else if (ayir == 'D')
                ayir = 'U';

            else if (ayir == 'e') // e
                ayir = 't';
            else if (ayir == 'E')
                ayir = 'T';

            else if (ayir == 'f') // f
                ayir = 'ş';
            else if (ayir == 'F')
                ayir = 'Ş';

            else if (ayir == 'g') // g
                ayir = 's';
            else if (ayir == 'G')
                ayir = 'S';

            else if (ayir == 'ğ') // ğ
                ayir = 'r';
            else if (ayir == 'Ğ')
                ayir = 'R';

            else if (ayir == 'h') // h
                ayir = 'p';
            else if (ayir == 'H')
                ayir = 'P';

            else if (ayir == 'ı') // ı
                ayir = 'ö';
            else if (ayir == 'I')
                ayir = 'Ö';

            else if (ayir == 'i') // i
                ayir = 'o';
            else if (ayir == 'İ')
                ayir = 'O';

            else if (ayir == 'j') // j
                ayir = 'n';
            else if (ayir == 'J')
                ayir = 'N';

            else if (ayir == 'k') // k
                ayir = 'm';
            else if (ayir == 'K')
                ayir = 'M';

            else if (ayir == 'l') // l
                ayir = 'l';
            else if (ayir == 'L')
                ayir = 'L';

            else if (ayir == 'm') // m
                ayir = 'k';
            else if (ayir == 'M')
                ayir = 'K';

            else if (ayir == 'n') // n
                ayir = 'j';
            else if (ayir == 'N')
                ayir = 'J';

            else if (ayir == 'o') // o 
                ayir = 'i';
            else if (ayir == 'O')
                ayir = 'İ';

            else if (ayir == 'ö') // ö
                ayir = 'ı';
            else if (ayir == 'Ö')
                ayir = 'I';

            else if (ayir == 'p') // p
                ayir = 'h';
            else if (ayir == 'P')
                ayir = 'H';

            else if (ayir == 'r') // r
                ayir = 'ğ';
            else if (ayir == 'R')
                ayir = 'Ğ';

            else if (ayir == 's') // s
                ayir = 'g';
            else if (ayir == 'S')
                ayir = 'G';

            else if (ayir == 'ş') // ş
                ayir = 'f';
            else if (ayir == 'Ş')
                ayir = 'F';

            else if (ayir == 't') // t
                ayir = 'e';
            else if (ayir == 'T')
                ayir = 'E';

            else if (ayir == 'u') // u
                ayir = 'd';
            else if (ayir == 'U')
                ayir = 'D';

            else if (ayir == 'ü') // ü
                ayir = 'ç';
            else if (ayir == 'Ü')
                ayir = 'Ç';

            else if (ayir == 'v') // v
                ayir = 'c';
            else if (ayir == 'V')
                ayir = 'C';

            else if (ayir == 'y') // y
                ayir = 'b';
            else if (ayir == 'Y')
                ayir = 'B';

            else if (ayir == 'z') //  z
                ayir = 'a';
            else if (ayir == 'Z')
                ayir = 'A';


        }


        public void resetle()
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

    }
}
