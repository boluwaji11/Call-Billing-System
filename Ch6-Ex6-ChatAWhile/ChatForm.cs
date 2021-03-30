//Developer: Oyewumi, Boluwaji
//Course: MIS 5315 – Spring 2021
//Assignment: Ch6-Ex6-ChatAWhile
//Description: This program allows a user to enter an area code and the length of time for a call in minutes, and then display the total cost of the call.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6_Ex6_ChatAWhile
{
    public partial class ChatForm : Form
    {
        // Fields to hold the area codes and per-mintes rate arrays
        private int[] areaCode = new int[] {262,414,608,715,815,920};
        private double[] perMinRate = new double[] {0.07,0.10,0.05,0.16,0.24,0.14};

        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            // Set Default Values
            txtAreaCode.Text = "262";
            txtCallLength.Text = "60";

            // Clear Output Panel
            pnlOutput.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Declare the variables
            int pos;
            double totalCost = 0;
            double length;  // Placeholder variable for input validation

            // Input Validations
            if(txtAreaCode.Text == "" || txtCallLength.Text == "")
            {
                MessageBox.Show("Enter the missing value(s)",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtAreaCode.Focus();
                return; 
            }

            if (!int.TryParse(txtAreaCode.Text, out pos))
            {
                MessageBox.Show("Enter a valid Area Code",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                txtAreaCode.Focus();
                txtAreaCode.SelectAll();
                return;
            }
            
            if (!double.TryParse(txtCallLength.Text, out length))
            {
                MessageBox.Show("Enter a valid call length in minutes",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                txtCallLength.Focus();
                txtCallLength.SelectAll();
                return;
            }


            // Get the position of the Area Code in the array
            pos = Array.IndexOf(areaCode, Convert.ToInt32(txtAreaCode.Text));

            // Display Area Code and Length of call
            lblAreaCodeLength.Text = "Area Code: " + txtAreaCode.Text + "\n"
                                + "For a " + txtCallLength.Text + "-minutes call, the total cost is:";

            // Display total cost of call
            if(pos>=0)
            {
                totalCost = perMinRate[pos] * Convert.ToDouble(txtCallLength.Text);
                lblTotalCost.Text = totalCost.ToString("C");

            }
            else
            {
                MessageBox.Show("We do not currently serve this area code.\n\n Please enter area code within coverage.",
                    "Out of Coverage",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            pnlOutput.Visible = true;
        }

        //TextChange Event Handler
        private void AllTextboxes_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox tb = (TextBox)sender;
                pnlOutput.Visible = false;
            }
        }
    }
}
