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

namespace Kriptoloji_Şifreleme_Algoritmaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calıstirma();
            pictureBox1.Visible = false;
        }

        void calıstirma()
        {
            pictureBox1.Visible = true;
           
            sezar1.resetle();
            sezar1.Hide();

            afinne1.resetle();
            afinne1.Hide();

            atbash1.resetle();
            atbash1.Hide();

            yalancıAsalSayı1.resetle();
            yalancıAsalSayı1.Hide();

            polybius1.resetle();
            polybius1.Hide();

            vigenere1.resetle();
            vigenere1.Hide();

            permütasyon1.resetle();
            permütasyon1.Hide();

            frekansAnalizi1.resetle();
            frekansAnalizi1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, 45);
            calıstirma();
            yalancıAsalSayı1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, 93);
            calıstirma();
            afinne1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, 141);
            calıstirma();
            sezar1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calıstirma();
            pictureBox1.Location = new Point(0, 189);
            polybius1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calıstirma();
            pictureBox1.Location = new Point(0, 237);
            permütasyon1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calıstirma();
            System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(Application.ExecutablePath) + @"\RSASifrelemesi.pyw");
            pictureBox1.Location = new Point(0, 285);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calıstirma();
            pictureBox1.Location = new Point(0, 333);
            atbash1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calıstirma();
            pictureBox1.Location = new Point(0, 381);
            vigenere1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calıstirma();
            pictureBox1.Location = new Point(0, 429);
            System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(Application.ExecutablePath) + @"\Diffie-Helmann.pyw");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calıstirma();
            pictureBox1.Location = new Point(0, 477);
            frekansAnalizi1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
