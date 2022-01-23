using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Custom_Functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creating a function to generate random 2 numbers for dice and listing them in the listbox1.

        string rollingdice()
        {
            Random random = new Random();
            int[] dice = new int[2];


            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = random.Next(1, 7);
                listBox1.Items.Add(dice[i]);
            }
            return listBox1.Items.ToString();
        }

        //calling the function
        private void btn_RollDice_Click(object sender, EventArgs e)
        {
            rollingdice();
        }
    }
}
