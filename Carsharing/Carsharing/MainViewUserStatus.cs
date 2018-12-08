using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing
{
	internal partial class MainViewUserStatus : UserControl
	{
        Booking openBooking;

        internal MainViewUserStatus()
		{
			InitializeComponent();
            UpdateForm();
		}

		private void buttonUserEdit_Click(object sender, EventArgs e)
		{
			new EditDataView(FormController.CurrentCustomer).ShowDialog();
		}

		private void buttonUserDelete_Click(object sender, EventArgs e)
		{
			if (Feedback.AskOwnCustomerDelete() == DialogResult.Yes)
			{
				if (DBController.DeleteUserFromDB(FormController.CurrentCustomer))
				{
					Feedback.SuccessOwnCustomerDelete();
					FormController.MainView.Close();
				}
				else
				{
					Feedback.ErrorDatabaseCustomersDelete();
				}
			}
		}

        internal void UpdateForm()
        {
            labelWelcome.Text = "Willkommen " + FormController.CurrentCustomer.ToString();
            watermarkTextBoxEndMileage.Watermark = "Stand in Km";
            // GroupBox to show current booking is invisible at default
            groupBoxCurrentBooking.Visible = false;

            // load booking information
            loadBookingData();
        }

        /// <summary>
        /// Fills the labels in the groupBox with information about the booking.
        /// </summary>
        /// <param name="b">The open booking to display its information.</param>
        private void showCurrentBookingInformation(Booking b)
        {
            labelBasePriceText.Text = b.Vehicle.BasicPrice.ToString() + " €";
            labelCarText.Text = b.Vehicle.Brand + ", " + b.Vehicle.Model;
            labelNumberplateText.Text = b.Vehicle.NumberPlate;
            labelPriceMinText.Text = b.Vehicle.PricePerMinute.ToString() + " €";
            labelPricePerKilometreText.Text = b.Vehicle.PricePerKilometre.ToString() + " €";
            labelStartMileageText.Text = b.StartMileage.ToString() + " km";
            labelStartTimeText.Text = b.StartTime.ToString();
        }

        private void buttonCloseCurrentBooking_Click(object sender, EventArgs e)
        {
            double userInput;
            // Check if the user input in the textbox is valid
            if (Double.TryParse(watermarkTextBoxEndMileage.Text, out userInput) && userInput >= openBooking.StartMileage)
            {
                // Close the booking locally
                openBooking.Close(DateTime.Now, userInput);
                // Close the booking in the database
                if(DBController.CloseBookingInDB(openBooking))
                {
                    Feedback.SuccessCloseBooking(openBooking.CalculateCost());
                    groupBoxCurrentBooking.Visible = false;
                }
                else
                {
                    Feedback.ErrorDatabaseConnection();
                }
            }
            else
            {
                Feedback.ErrorInvalidEndMileageInput();
                watermarkTextBoxEndMileage.Text = "";
            }
        }


        private void loadBookingData()
        {
            // check if the customer has an open booking to display
            bool hasOpenBooking;
            if (DBController.CheckOpenBookingsCustomer(FormController.CurrentCustomer, out hasOpenBooking))
            {
                if (hasOpenBooking)
                {
                    // Turn the GroupBox visible
                    groupBoxCurrentBooking.Visible = true;

                    // Now fetch the open booking from the database to show it on screen

                    if (DBController.GetOpenBookingOfCustomer(FormController.CurrentCustomer, out openBooking))
                    {
                        showCurrentBookingInformation(openBooking);
                    }
                    else
                    {
                        Feedback.ErrorDatabaseConnection();
                    }
                }
            }
            else
            {
                Feedback.ErrorDatabaseConnection();
            }
        }
    }
}
