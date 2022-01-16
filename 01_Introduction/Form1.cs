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

        private void btn_circleCalc_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txt_radius.Text);
            double pi = 3.14;
            double perimeter = 2 * pi * radius;
            double area = pi * (radius * radius);


            lbl_perimeter.Text = Math.Round(perimeter).ToString();
            lbl_area.Text = Math.Round(area).ToString();
        }

        private void btn_calcNumberOfTerms_Click(object sender, EventArgs e)
        {

            //Calculating number of terms

            float first_term = float.Parse(txt_firstTerm.Text);
            float last_term = float.Parse(txt_lastTerm.Text);
            float common_diff = float.Parse(txt_commonDiff.Text);

            float number_of_terms = (last_term - first_term) / common_diff + 1;
            MessageBox.Show($"Number of Terms ={number_of_terms}");

        }
    }
}
