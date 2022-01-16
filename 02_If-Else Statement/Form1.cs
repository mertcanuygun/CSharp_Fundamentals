using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_If_Else_Statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exchangecalc_Click(object sender, EventArgs e)
        {
            //Calculating exchange rates over fixed rates upon currency selection.

            string currency = cmb_exchangeCalc.SelectedItem.ToString();
            float amount = float.Parse(txt_exchangeAmount.Text);
            string message;

            if (currency.ToLower() == "euro")
            {
                message = ($"Amount is {Math.Round(amount / 15.43)}");
            }
            else if (currency.ToLower() == "dollar")
            {
                message = ($"Amount is {Math.Round(amount / 13.51)}");
            }  
            else if (currency.ToLower() == "pound")
            {
                message = ($"Amount is {Math.Round(amount / 18.49)}");
            }
            else if (currency.ToLower() == "yen")
            {
                message = ($"Amount is {Math.Round(amount / 0.11)}");
            }
            else if (currency.ToLower() == "swedish krona")
            {
                message = ($"Amount is {Math.Round(amount / 1.49)}");
            }
            else if (currency.ToLower() == "ruble")
            {
                message = ($"Amount is {Math.Round(amount / 0.17)}");
            }
            else if (currency.ToLower() == "franc")
            {
                message = ($"Amount is {Math.Round(amount / 14.79)}");
            }
            else
            {
                message = ("Wrong Input");
            }

            MessageBox.Show(message);
            
        }
    }
}
