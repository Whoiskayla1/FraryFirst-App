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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public string ConfigValues = "CfgValues.txt";

        // Property where dollars per point  value is stored
        public double DollarsPerPoint
        {
            get
            {
                return dollarsPerPoint;
            }
            set
            {

                dollarsPerPoint = value;
                if (dollarsPerPoint <= 0)
                {
                    dollarsPerPoint = 0;
                }
            }
        }
        //variable
        private double dollarsPerPoint;
        private void SettingsForm_Load(object sender, EventArgs e)
        {
          
            // Read in value from file


            // then set it to the text box
            txtDollarPP.Text = dollarsPerPoint.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            string dpp = txtDollarPP.Text;
            bool ddpValid = double.TryParse(dpp, out dollarsPerPoint);
            if (ddpValid )

            {
                // save value to file
                sw = File.CreateText(ConfigValues);
                sw.WriteLine(DollarsPerPoint.ToString());

                sw.Close();



                // then hide the form
                this.Hide();
            }
            
        }
    }
}
