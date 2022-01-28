using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_ForEach_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sehirler = { "İstanbul", "Londra", "Moskova", "Los Angeles", "Amsterdam", "Madrid", "Cape Town", "Kuala Lumpur", "Düsseldorf", "Prag" };

        private void btn_start_Click(object sender, EventArgs e)
        {
            string name = string.Empty;
            int longest = 0;
            foreach (string sehir in sehirler)
            {
                if (sehir.Replace(" ","").Length > longest)
                {
                    longest = sehir.Replace(" ","").Length;
                    name = sehir; 
                }
            }
            listBox1.Items.AddRange(sehirler);
            MessageBox.Show($"Longest city name is '{name}' with {longest} characters");
        }

        private void btn_example2_Click(object sender, EventArgs e)
        {
            string name = string.Empty;
            int shortest = 50;
            foreach (string sehir in sehirler)
            {
                if (sehir.Replace(" ", "").Length < shortest)
                {
                    shortest = sehir.Replace(" ", "").Length;
                    name = sehir;
                }
            }
            listBox1.Items.AddRange(sehirler);
            MessageBox.Show($"Shortest city name is '{name}' with {shortest} characters");
        }
    }
}
