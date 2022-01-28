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

            //Listing squares of odd and even numbers between 0 and 25 in listboxes. Then sending a messagebox contains that the sum of the squares of the numbers by their type.

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

        private void btn_example2_Click(object sender, EventArgs e)
        {

            //Listing the interval of numbers that given by the user. Then showing a message with the sum of those interval of numbers.

            double numbers = 0;

            if (txt_variable_1.Text == "" || txt_variable_2.Text == "")
            {
                MessageBox.Show("Please enter some numbers");
            }
            else
            {
              for (double i = Convert.ToInt32(txt_variable_1.Text); i <= Convert.ToInt32  (txt_variable_2.Text); i++)
              {
                  numbers += i;
                  listBox3.Items.Add(i);
              }
              MessageBox.Show($"Total of those numbers are = {numbers}");
            }
        }
    }
}
