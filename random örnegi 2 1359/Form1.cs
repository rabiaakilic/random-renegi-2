using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_örnegi_2_1359
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbNotlar.Items.Clear();
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                int puan = rnd.Next(0,100);
                lbNotlar.Items.Add(puan);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kaldı = 0, duz = 0 ,tesekur = 0,takdir = 0;

            for (int i = 0; i < lbNotlar.Items.Count; i++)
            {
                int puan = Convert.ToInt32(lbNotlar.Items[i]);//i.sıradaki notu alır.

                if (puan < 50)
                {
                    kaldı++;
                }
                else if (puan >= 50 && puan < 80)
                {
                    duz++;
                }
                else if (puan >= 80 && puan < 90)
                {
                    tesekur++;
                }
                else
                {
                    takdir++;
                }

            }
            lblKalan.Text = " Kalan öğrenci sayısı: " + Convert.ToString(kaldı);
            lblDuz.Text = "Düz geçen öğrenci sayısı: " + Convert.ToString(duz);
            lblTaktir.Text = "Takdir sayısı: " + Convert.ToString(takdir);
            lblTesekur.Text = "Teşekkür sayısı: " + Convert.ToString(tesekur);
        }
    }
} 

