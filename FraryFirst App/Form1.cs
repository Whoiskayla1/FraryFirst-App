using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FraryFirst_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //input
            //  txtDice1.Text = "1";
            txtDice2.ForeColor = Color.CadetBlue;

            int dice1 = int.Parse(txtDice1.Text);
            int dice2 = int.Parse(txtDice2.Text);
            int total = 0;
            total = dice1 + dice2;
            lstOut.Items.Add("Dice 1 is " + txtDice1.Text);
            lstOut.Items.Add("Dice 2 is " + txtDice2.Text);
            //generally I don't want you to combine your processing and output
            double d1p = 0;
            double d2p = 0;
            d1p = (double) dice1 / total;
            d2p = (double)dice2 / total;
            /* C for currency, D for date and T for time */

            lstOut.Items.Add("Total = " + total.ToString("N0"));
            lstOut.Items.Add(d1p.ToString("P"));
            lstOut.Items.Add(d2p.ToString("P"));
            btnClear.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDice1.Clear();
            txtDice2.Clear();   
            lstOut.Items.Clear();
            txtDice1.Focus();
        }
    }
}
