using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTwoNumbers
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pop up message box displaying programmer 
            MessageBox.Show("Matthew Vaughan\n\nAdd any two numbers\nyou wish to add!");
        }

        /// <summary>
        /// Exit Handlers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit out of the program
            this.Close();
        }

        /// <summary>
        /// Calculate Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare the values to store the user inputs
            double
                value1,
                value2;

            //Store the users inputs from the textboxes
            value1 = double.Parse(txtNum1.Text);
            value2 = double.Parse(txtNum2.Text);

            //Display the values added via the add method in the sum textbox
            txtSum.Text = ($"{Add(value1, value2)}");
        }

        /// <summary>
        /// Adding Method
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        static double Add(double value1, double value2)
        {
            //Return parameters sum
            return value1 + value2;
        } 
    }
}
