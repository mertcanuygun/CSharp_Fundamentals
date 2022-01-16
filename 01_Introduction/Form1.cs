using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Introduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dairehesapla_Click(object sender, EventArgs e)
        {
            double yaricap = Convert.ToDouble(txt_yaricap.Text);
            double pi = 3.14;
            double cevre = 2 * pi * yaricap;
            double alan = pi * (yaricap * yaricap);


            lbl_cevresi.Text = Math.Round(cevre).ToString();
            lbl_alani.Text = Math.Round(alan).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float ilk_terim = float.Parse(txt_ilkterim.Text);
            float son_terim = float.Parse(txt_sonterim.Text);
            float artis = float.Parse(txt_artismikt.Text);

            float terim_sayisi = (son_terim - ilk_terim) / artis + 1;
            MessageBox.Show($"Terim Sayısı={terim_sayisi}");

        }
    }
}
