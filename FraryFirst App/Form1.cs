using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FraryFirst_App
{
    public partial class Form1 : Form
    {


        //This is the object based on the second form 

        //  SettingsForm sf = new SettingsForm();

        public SettingsForm sf;
        
        private string sides = "";
        private const string sixSided = "6 Sided";
        private const string tenSided = "10 Sided";
        private const string twentySided = "20 sided";
        private Random rnd;
        private string diceFileLog = "diceFilelog.txt";


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
            //ICA 8
            // store the current time in curTime
            DateTime curTime = DateTime.Now;


            int minNum = 1;
            int maxNum = 0;
            int numDice;

            bool numValid;
            int total = 0;
            // This value now refers to the value in the settings Form
            double dollarsPerPoint = sf.DollarsPerPoint;

            double moneyWon = 0;
            int curDie = 0;

            /* This is how you decalre a stream writer which will allow you to write to a file */
                   StreamWriter sw;
            
            //Input
            // In class Assignment 4
            numValid = int.TryParse(txtNumDice.Text, out numDice);

            //Processing

            // Inclass assignment 5
            if (numValid)
            {

                // Inclass assignment 7
                switch (sides)
                {
                    case sixSided:
                        maxNum = 6;
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
                //OPen the log file
                sw = File.AppendText(diceFileLog);
                sw.WriteLine("******** Transaction Began at " + curTime.ToString("d") + 
                                " at " + curTime.ToString("T") + " ********");
                for (int i = 0; i < numDice; i++)
                {
                    curDie = rnd.Next(minNum, maxNum + 1);
                    total = total + curDie;
                    // since I am not saving curDie I have to output it here 
                    lstOut.Items.Add("Current Die rolled is: " + curDie);
                    sw.WriteLine("Current Die rolled is: " + curDie);
                }            

                moneyWon = total * dollarsPerPoint;


                // Output
                lstOut.Items.Add("Amount of money per point is " + dollarsPerPoint.ToString("C"));
                sw.WriteLine("Amount of money per point is " + dollarsPerPoint.ToString("C"));
                /* C for currency, D for date and T for time */

              

                lstOut.Items.Add("Total = " + total.ToString("N0"));

                lstOut.Items.Add("The amount of money won is " + moneyWon.ToString("C"));

                sw.WriteLine("Total is " + total.ToString("N0"));
                sw.WriteLine("The amount of money won is " + moneyWon.ToString("C"));
                sw.Close();

                // this is not required for preoject it is just a demo of the timedate to string methods
                lstOut.Items.Add("curTime.ToString(\"D\") " + curTime.ToString("D"));
                lstOut.Items.Add("curTime.ToString(\"d\") " + curTime.ToString("d"));
                lstOut.Items.Add("curTime.ToString(\"T\") " + curTime.ToString("T"));
                lstOut.Items.Add("curTime.ToString(\"t\") " + curTime.ToString("t"));
                lstOut.Items.Add("curTime.ToString(\"G\") " + curTime.ToString("G"));
                lstOut.Items.Add("curTime.ToString(\"g\") " + curTime.ToString("g"));
                btnClear.Focus();
            }
            else // Number of dice is not valid
            {
                lstOut.Items.Add("The number of dice must be a whole number");
            }




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
            bool fileGood = false;
            // declares the streamreadr variable
            StreamReader sr;
            // creates the random object along with the random numbers 
            rnd = new Random();
            // set the delut radio button to be checked
            rdo6Sided.Checked = true;

            // this is so form2 doesn't get created until Form1 is completely created
            sf = new SettingsForm();
            do
            {
                // get the values from the file and set the form 2 properties
                try
                {
                    // open the file to read it
                    sr = File.OpenText(sf.ConfigValues);
                    fileGood = true;    
                    // anything read from a text file is a string
                   // string temp = ;
                    double dpp;
                    //validate the value just read in
                    bool dppValid = double.TryParse(sr.ReadLine(),
                        out dpp);
                    if (dppValid)
                    {
                        // if valid then save value to the property
                        sf.DollarsPerPoint = dpp;

                    }
                    else
                    {
                        // not doing anything here yet
                    }


                    sr.Close();

                }
                catch (FileNotFoundException ex)
                {
                    string msg = ex.Message + " Please enter a new file.";
                    //   lstOut.Items.Add(msg);
                    MessageBox.Show(msg, "File not Found");
                    // allows the user to pick a file
                    openFileDialog1.ShowDialog(this);
                    //filename get put in openFileDialog1.Filename
                    sf.ConfigValues = openFileDialog1.FileName;
                } //End of catch
            } while (!fileGood);  // end of do 

        } // end of form1 load event

        private void setDollarsPerPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sf.Show();
        }
    }
}
