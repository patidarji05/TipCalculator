using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator4
{
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region   Number Method
        // Given the input to the textbox

        private void Zerobutton_Click(object sender, EventArgs e)
        {
            BilltextBox.Text += "0";
        }

        private void Dotbutton_Click(object sender, EventArgs e)
        {
            BilltextBox.Text += ".";
        }

        private void Onebutton_Click(object sender, EventArgs e)
        {
            BilltextBox.Text += "1";
        }

        private void Twobutton_Click(object sender, EventArgs e)
        {
            BilltextBox.Text += "2";
        }

        private void Threebutton_Click(object sender, EventArgs e)
        {
            BilltextBox.Text += "3";
        }

        private void Fourbutton_Click(object sender, EventArgs e)
        {
            BilltextBox.Text += "4";
        }

        private void Fivebutton_Click(object sender, EventArgs e)
        {
            BilltextBox.Text += "5";
        }

        private void Sixbutton_Click(object sender, EventArgs e)
        {
            BilltextBox.Text += "6";
        }

        private void Sevenbutton_Click(object sender, EventArgs e)
        {
            BilltextBox.Text += "7";
        }

        private void Eightbutton_Click(object sender, EventArgs e)
        {
            BilltextBox.Text += "8";
        }

        private void Ninebutton_Click(object sender, EventArgs e)
        {
            BilltextBox.Text += "9";
        }
        #endregion

        #region  Total Method
        
        private void Totalbutton_Click(object sender, EventArgs e)
        {
      
            try
            {
                double total, tip;
                int people;

                //tip% value store in tip
                tip = Int32.Parse(TipUpDown.Value.ToString());

                //No of person value store in people
                people = Int32.Parse(PersonUpDown.Value.ToString());

                // Bill value store in total
                total = Double.Parse(BilltextBox.Text);
                if (total > 0)
                {
                    // use for when user not enter the tip% and person value
                    if (tip == 0)
                    {
                        throw new ArithmeticException("You Not Enter  value of the Tip % .");
                    }
                    else if (people == 0)
                    {
                        throw new ArithmeticException("You Not Enter Value of The Number of People.");
                    }
                    else
                    {
                        // calculate total tip
                        tip = tip * total / 100;
                      
                        // calculate total amount
                        total += tip;

                        //  Calcualte per persion tip
                        PersontextBox.Text = "$" + (tip / people);

                        //calculate per persion total amount
                        TotaltextBox.Text = "$" + (total / people);
                    }

                }
                else
                {
                    throw new ArithmeticException("Plese Enter greather than Zero.");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Somethin Went Wrong");

            }
        }
        #endregion

        #region Delete Method
        /// <summary> 
        /// Delete the character to the right of the selection start of the user input text
        /// </summary>
        private void Delbutton_Click(object sender, EventArgs e)
        {
            // if we don't have a value to delete , return
            if (this.BilltextBox.Text.Length < this.BilltextBox.SelectionStart + 1)
                return;

            // remember selection start
            var selectionstart = this.BilltextBox.SelectionStart;

            //delete the character to the right of the selection
            BilltextBox.Text = this.BilltextBox.Text.Remove(this.BilltextBox.SelectionStart, 1);

        }
        #endregion


        #region  Reset Method
        /// <summary>
        /// clear the user input text
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="e">The event arguments</param>
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            //Clear the text from the user input text

            BilltextBox.Clear();
            PersontextBox.Clear();
            TotaltextBox.Clear();
            TipUpDown.Value = 0;
            PersonUpDown.Value = 0;
        }

        #endregion

        #region Exit Method
        
        /// <summary>
        /// to leave the application
        /// </summary>
       
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm If You Want To Exit.", "Sales Inventry System",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion


       

    }
}
