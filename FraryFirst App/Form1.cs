using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private Random rnd;
        private string diceFileLog = "diceFile.log";


        public Form1()
        {
            InitializeComponent();
        }
        // Inclass assignment 7
        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult buttonSelected;

            buttonSelected = MessageBox.Show("Do you really want to quit?", "Exiting...",
                MessageBoxButtons.YesNo);
            if (buttonSelected == DialogResult.Yes)
            {
                this.Close();
            }

        }
        

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int minNum = 1;
            int maxNum =0;

            //input


            // for tryparse decaration needs to be on a separate statement 
            //generally your declarations should be at the begiining of the procedure
            //   int dice1, dice2;
            int numDice;

            bool numValid;
            int total = 0;
            double dollarsPerPoint = 10;
            double moneyWon = 0;
            int curDie = 0;

            StreamWriter sw;


       
            // In class Assignment 4
            numValid = int.TryParse(txtNumDice.Text, out numDice);

           

           // Inclass assignment 5
            if (numValid )
            {
   
                // Inclass assignment 7
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
                sw = File.AppendText(diceFileLog);

                for (int i = 0; i < numDice; i++)
                {
                    curDie = rnd.Next(minNum, maxNum+1);
                    total = total + curDie;
                    lstOut.Items.Add("Current Die rolled is: " + curDie);
                    sw.WriteLine("Current Die rolled is: " + curDie);
                }
                lstOut.Items.Add("Total is " + total);
                sw.WriteLine("Total is " + total);
                //Processing

             

                moneyWon = total * dollarsPerPoint;

                    lstOut.Items.Add("Amount of money per point is " + dollarsPerPoint.ToString("C"));
                sw.WriteLine("Amount of money per point is " + dollarsPerPoint.ToString("C"));
                /* C for currency, D for date and T for time */

                // Output

                lstOut.Items.Add("Total = " + total.ToString("N0"));
               
                    lstOut.Items.Add("The amount of money won is " + moneyWon.ToString("C"));

                sw.WriteLine("The amount of money won is " + moneyWon.ToString("C"));
                sw.Close();

                btnClear.Focus();
                } else
                {
                    lstOut.Items.Add("At least one of the dice is out of range");
                }

        //    }// end of if
        /*
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
        */
              

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumDice.Clear();
          //  txtDice2.Clear();   
            lstOut.Items.Clear();
            txtNumDice.Focus();
            // added for ICA 6
            rdo6Sided.Checked = true;
        }

        // Inclass assignment 6
        private void rdo6Sided_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo6Sided.Checked)
            {
                sides = sixSided;
            }
                
        }

        private void rdo10Sidded_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo10Sided.Checked)
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

        // added for ICA 6
        private void Form1_Load(object sender, EventArgs e)
        {
            // creates the random object along with the random numbers 
            rnd = new Random();
            rdo6Sided.Checked = true;

         
        }
    }
}
