using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollinsLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Name: Chris Collins
         * Due Date: 2022-11-17
         * This program tests data validation and new controls */
        private void ResetTrip()
        {
            //Function Comment Header
            /* Name: ResetTrip
             * Sent:
             * Returned:
             * This function performs a reset */

            grTripInfo.Visible = false;
            lblPrice.Text = "";
            txtPeople.Clear();
            txtPeople.Focus();
            radCuba.Checked = true;
            radCredit.Checked = true;
        }

        private void SetFlight()
        {
            //Function Comment Header
            /* Name: SetFlight
             * Sent:
             * Returned:
             * This function checks the Flight Included checkbox for Cuba and Mexico radio button 
             * selections and unchecks for Florida radio button selection*/

            if (!radFlorida.Checked)
                chkFlight.Checked = true;
            else
                chkFlight.Checked = false;
        }

        private void DisplayMsg(string dspMessage, string dspTitle)
        {
            //Function Comment Header
            /* Name: DisplayMsg
             * Sent: 2 strings (message, title)
             * Returned:
             * This function displays a messagebox with a message and title*/

            MessageBox.Show(dspMessage, dspTitle, MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Calling reset function
            ResetTrip();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Calling reset function
            ResetTrip();
        }

        private void radCuba_CheckedChanged(object sender, EventArgs e)
        {
            //Calling function to check in trip location selection includes flight
            SetFlight();
        }

        private void radFlorida_CheckedChanged(object sender, EventArgs e)
        {
            //Calling function to check in trip location selection includes flight
            SetFlight();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            //Declare constants and variables
            const double MEXICOPERSON = 2300.89;
            const double PRICEPERSON = 2150.50;
            const double DISCOUNT = 0.10;
            double price = 0;
            string agent = "Chris Collins";
            int applyDis = "Cash Discount Applied";


            //Validate integer that was entered
            int people;
           //test txtbox, if int, returns true and converts
            bool goodData = int.TryParse(txtPeople.Text, out people);
            //test if not an integer
            if (!goodData)
            {
               //Call message box function
                string dspMessage = "People must be a whole number";
                string dspTitle = "Input Error";
                DisplayMsg(dspMessage, dspTitle);
                //Select data typed in People textbox
                txtPeople.Focus();
                txtPeople.SelectAll();
            }

            else if (people < 1 || people > 10)
            {
                //Call message box function
                string dspMessage = "People must be between 1-10";
                string dspTitle = "Input Error";
                DisplayMsg(dspMessage, dspTitle);
                //Select data typed in People textbox
                txtPeople.Focus();
                txtPeople.SelectAll();
            }

            else
                if (radCash.Checked == true && radMexico.Checked == true)
            {
                //Calculate price of trip
                price = people * MEXICOPERSON - ((people * MEXICOPERSON) * DISCOUNT);
                //Display the price in label in currency format
                lblPrice.Text = price.ToString("c");
                grBook.Enabled = false;
                //Display trip information in now-visible label
                grTripInfo.Visible = true;
                lblDisplay.Text = "Booked by " + agent + "\n\nPeople: " + people.ToString("d2") + 
                    "\nLocation: MEXICO\n"+ applyDis +"\nFlight Included" + "\nPrice: " +
                    price.ToString("c");
            }
                else if (radCredit.Checked == true && radMexico.Checked == true)
            {
                //Calculate price of trip
                price = people * MEXICOPERSON;
                lblPrice.Text = price.ToString("c");
                grBook.Enabled = false;
                grTripInfo.Visible = true;
                lblDisplay.Text = "Booked by " + agent + "\n\nPeople: " + people.ToString("d2") +
                    "\nLocation: MEXICO\nFlight Included" + "\nPrice: " +
                    price.ToString("c");
            }
                else if (radCash.Checked == true && radCuba.Checked == true)
            {
                //Calculate price of trip
                price = people * PRICEPERSON - ((people * PRICEPERSON) * DISCOUNT);
                lblPrice.Text = price.ToString("c");
                grBook.Enabled = false;
                grTripInfo.Visible = true;
                lblDisplay.Text = "Booked by " + agent + "\n\nPeople: " + people.ToString("d2") +
                    "\nLocation: CUBA\n"+ applyDis +"\nFlight Included" + "\nPrice: " +
                    price.ToString("c");
            }
                else if (radCredit.Checked == true && radCuba.Checked == true)
            {
                //Calculate price of trip
                price = people * PRICEPERSON;
                lblPrice.Text = price.ToString("c");
                grBook.Enabled = false;
                grTripInfo.Visible = true;
                lblDisplay.Text = "Booked by " + agent + "\n\nPeople: " + people.ToString("d2") +
                    "\nLocation: CUBA\nFlight Included" + "\nPrice: " +
                    price.ToString("c");
            }
                else if (radCash.Checked == true && radFlorida.Checked == true)
            {
                //Calculate price of trip
                price = people * PRICEPERSON - ((people * PRICEPERSON) * DISCOUNT);
                lblPrice.Text = price.ToString("c");
                grBook.Enabled = false;
                grTripInfo.Visible = true;
                lblDisplay.Text = "Booked by " + agent + "\n\nPeople: " + people.ToString("d2") +
                    "\nLocation: FLORIDA\n" + applyDis + "\nPrice: " +
                    price.ToString("c");
            }
                else if (radCredit.Checked == true && radFlorida.Checked == true)
            {
                //Calculate price of trip
                price = people * PRICEPERSON;
                lblPrice.Text = price.ToString("c");
                grBook.Enabled = false;
                grTripInfo.Visible = true;
                lblDisplay.Text = "Booked by " + agent + "\n\nPeople: " + people.ToString("d2") +
                    "\nLocation: FLORIDA" + "\nPrice: " +
                    price.ToString("c");
            }
            //If 1 or 3 people, display message box
            switch (people)
            {
                case 1: 
                case 3:
                    string dspMessage = "Special when booking single or triple. \n" +
                        "BOGO Special - Call 555-1212 to receive another person free!";
                    string dspTitle = "Limited Time Offer";
                    DisplayMsg(dspMessage, dspTitle);
                    break;

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string dspMessage = "Trip booked an paid\nPrice: " + lblPrice.Text;
            string dspTitle = "Confirmation Email Sent";
            DisplayMsg(dspMessage dspTitle);
            grBook.Enabled = true;
            ResetTrip();
        }
    }
}
