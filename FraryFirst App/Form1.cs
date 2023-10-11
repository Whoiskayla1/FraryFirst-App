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
        private string sides = "";
        private const string sixSided = "6 Sided";
        private const string tenSided = "10 Sided";
        private const string twentySided = "20 sided";
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
            int minNum = 1;
            int maxNum =0;

            //input
            //  txtDice1.Text = "1";

            // for tryparse decaration needs to be on a separate statement 
            //generally your declarations should be at the begiining of the procedure
            int dice1, dice2;
            bool d1Valid, d2Valid;
            int total = 0;
            double d1p = 0;
            double d2p = 0;
            double dollarsPerPoint = 10;
            double moneyWon = 0;
            txtDice2.ForeColor = Color.CadetBlue;
            /*
             * Changing parse to tryparse
                        int dice1 = int.Parse(txtDice1.Text);
                        int dice2 = int.Parse(txtDice2.Text);
            */

          //  dice1 = 5;

            d1Valid = int.TryParse(txtDice1.Text, out dice1);
            d2Valid = int.TryParse(txtDice2.Text, out dice2);

            if (d1Valid && d2Valid)
            {
                switch (sides)
                {
                    case sixSided:
                        maxNum= 6;
                        break;
                    case tenSided:
                        maxNum = 10;
                        break;
                    case twentySided:
                        maxNum = 20;
                        break;
                    default:
                        lstOut.Items.Add("this shouldn't happen");
                        break;

                }
                if (dice1 >= minNum && dice1 <= maxNum &&
                    dice2 >= minNum && dice2 <= maxNum)
                {
                    //Processing

                    total = dice1 + dice2;
                    //generally I don't want you to combine your processing and output

                    d1p = (double)dice1 / total;
                    d2p = (double)dice2 / total;

                    moneyWon = total * dollarsPerPoint;

                    lstOut.Items.Add("Dice 1 is " + dice1.ToString("N0"));
                    lstOut.Items.Add("Dice 2 is " + dice2.ToString("N0"));
                    lstOut.Items.Add("Amount of money per point is " + dollarsPerPoint.ToString("C"));

                    /* C for currency, D for date and T for time */

                    // Output

                    lstOut.Items.Add("Total = " + total.ToString("N0"));
                    lstOut.Items.Add(d1p.ToString("P"));
                    lstOut.Items.Add(d2p.ToString("P"));
                    lstOut.Items.Add("The amount of money won is " + moneyWon.ToString("C"));


                    btnClear.Focus();
                } else
                {
                    lstOut.Items.Add("At least one of the dice is out of range");
                }

            }// end of if
            else
            {
                if (!d1Valid)
                {
                    lstOut.Items.Add("Dice 1 input is invalid");
                }
                if (!d2Valid) {

                    lstOut.Items.Add("Dice 2 input is invalid");
                }
                
            }

              

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDice1.Clear();
            txtDice2.Clear();   
            lstOut.Items.Clear();
            txtDice1.Focus();
        }

        private void rdo6Sided_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo6Sided.Checked)
            {
                sides = sixSided;
            }
                
        }

        private void rdo10Sidded_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo10Sidded.Checked)
            {
                sides = tenSided;
            }
        }

        private void rdo20Sided_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo20Sided.Checked)
            {
                sides = twentySided;
            }
        }
    }
}
