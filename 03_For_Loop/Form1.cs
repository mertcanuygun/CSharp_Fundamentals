using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_For_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            double odds = 0;
            double evens = 0;

            for (int i = 0; i <= 25; i++)
            {
                if (i % 2 == 0)
                {
                    evens = Math.Pow(i, 2) + evens;
                    listBox2.Items.Add($"{i} x {i} = {(Math.Pow(i, 2))}");
                }
                else
                {
                    odds = Math.Pow(i, 2) + odds;
                    listBox1.Items.Add($"{i} x {i} = {(Math.Pow(i, 2))}");
                }
            }
            MessageBox.Show($"Sum of the squares of odd numbers: {odds}\n Sum of the squares of even numbers: {evens}");
        }
    }
}
