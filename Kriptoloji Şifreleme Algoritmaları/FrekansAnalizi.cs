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
    public partial class FrekansAnalizi : UserControl
    {
        public FrekansAnalizi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            string metin = richTextBox1.Text.ToLower();
            string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
            int[] harflersay = new int[29];


            for (int i = 0; i < alfabe.Length; i++)
            {
                char harf = alfabe[i];
                int sayac = 0;

                for (int a = 0; a < metin.Length; a++)
                    if (metin[a] == harf)
                        sayac++;


                harflersay[i] = sayac;
            }

            for (int i = 0; i < harflersay.Length; i++)
            {
                if (harflersay[i] != 0)
                    listBox1.Items.Add(alfabe[i] + ": " + harflersay[i]);
            }

        }

        public void resetle()
        {
            richTextBox1.Text = "";
            listBox1.Items.Clear();
        }
    }
}

