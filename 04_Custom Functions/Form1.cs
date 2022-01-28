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

        //Creating a function to generate random 2 numbers for dice and listing them in the listbox1. Then sending a message whether winning or losing according to the number that have been given by the user.

        string rollingdice(int guess1, int guess2)
        {
            Random random = new Random();
            int[] dice = new int[2];


            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = random.Next(1, 7);
                listBox1.Items.Add(dice[i]);
            }
            if (guess1 > 7 || guess1 < 1 || guess2 > 7 || guess2 < 1)
            {
                listBox1.Visible = false;
                MessageBox.Show("Please enter your guesses correctly!");
            }
            else
            {
                if((guess1 == dice[0] || guess1 == dice[1]) && (guess2 == dice[0] || guess2 == dice[1]))
                {
                    listBox1.Visible = true;                  
                    MessageBox.Show("You WIN!!!");
                }
                else
                {
                    listBox1.Visible = true;
                    MessageBox.Show("Opps! Try Again!");
                }
            }
            return listBox1.Items.ToString();
        }

        //calling the function
        private void btn_RollDice_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(txt_firstGuess.Text);
            int second = Convert.ToInt32(txt_secondGuess.Text);
            rollingdice(first,second);
            listBox1.Items.Clear();
        }
    }
}
