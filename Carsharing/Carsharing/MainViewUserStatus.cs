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
		internal MainViewUserStatus()
		{
			InitializeComponent();
			labelWelcome.Text = "Willkommen " + FormController.CurrentCustomer.ToString();
            // GroupBox to show current booking is invisible at default
            groupBoxCurrentBooking.Visible = false;

            // check if the customer has an open booking to display
            bool hasOpenBooking;
            if(DBController.CheckOpenBookingsCustomer(FormController.CurrentCustomer, out hasOpenBooking))
            {
                if(hasOpenBooking)
                {
                    // Turn the GroupBox visible
                    groupBoxCurrentBooking.Visible = true;

                    // Now fetch the open booking from the database to show it on screen
                    Booking openBooking;
                    if(DBController.GetOpenBookingOfCustomer(FormController.CurrentCustomer, out openBooking))
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

        /// <summary>
        /// Fills the labels in the groupBox with information about the booking.
        /// </summary>
        /// <param name="b">The open booking to display its information.</param>
        private void showCurrentBookingInformation(Booking b)
        {
            labelBasePriceText.Text = b.Vehicle.BasicPrice.ToString();
            labelCarText.Text = b.Vehicle.Brand + ", " + b.Vehicle.Model;
            labelNumberplateText.Text = b.Vehicle.NumberPlate;
            labelPriceMinText.Text = b.Vehicle.PricePerMinute.ToString() + " €";
            labelPricePerKilometreText.Text = b.Vehicle.PricePerKilometre.ToString() + " €";
            labelStartMileageText.Text = b.StartMileage.ToString();
            labelStartTimeText.Text = b.StartTime.ToString();
        }
    }
}
