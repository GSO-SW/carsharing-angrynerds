using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Carsharing
{
	internal partial class MainViewUserStatus : UserControl
	{
		internal MainViewUserStatus()
		{
			InitializeComponent();
            UpdateForm();
		}

		private void buttonUserEdit_Click(object sender, EventArgs e)
		{
			new EditDataView(FormController.CurrentCustomer).ShowDialog();
			UpdateForm();
		}

		private void buttonUserDelete_Click(object sender, EventArgs e)
		{
			if (Feedback.AskOwnCustomerDelete() == DialogResult.Yes)
			{
				if (DBController.TryDeleteUser(FormController.CurrentCustomer))
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
			ShowCurrentBookingInformation();
			UpdateTable();
		}

        private void UpdateTable()
        {
            listBoxBooking.Items.Clear();
			if (!DBController.TryGetAllBookingsOfCustomer(FormController.CurrentCustomer, out List<Booking> bookings))
			{
				Feedback.ErrorDatabaseConnection();
				return;
			}
			listBoxBooking.Items.AddRange(bookings.ToArray());
		}

        /// <summary>
        /// Fills the labels in the groupBox with information about the booking.
        /// </summary>
        /// <param name="b">The open booking to display its information.</param>
        private void ShowCurrentBookingInformation(Booking b = null)
        {
            if (b != null)
            {
                labelBasePriceText.Text = b.Vehicle.BasicPrice.ToString() + " €";
                labelCarText.Text = b.Vehicle.Brand + ", " + b.Vehicle.Model;
                labelNumberplateText.Text = b.Vehicle.NumberPlate;
                labelPriceMinText.Text = b.Vehicle.PricePerMinute.ToString() + " €";
                labelPricePerKilometreText.Text = b.Vehicle.PricePerKilometre.ToString() + " €";
				labelTotalCostText.Text = b.CalculateCost().ToString("F2") + " €";
				labelStartTimeText.Text = b.StartTime.ToString();
				labelStartMileageText.Text = b.StartMileage.ToString() + " km";
				if (b.Open)
				{
					watermarkTextBoxEndMileage.Visible = true;
					watermarkTextBoxEndMileage.Enabled = true;
					labelEndMileageText.Visible = false;
					labelEndTimeText.Text = "----------------";
				}
				else
				{
					watermarkTextBoxEndMileage.Visible = false;
					watermarkTextBoxEndMileage.Enabled = false;
					labelEndMileageText.Visible = true;
					labelEndMileageText.Text = b.EndMileage.ToString()+ " km";
					labelEndTimeText.Text = b.EndTime.ToString();
				}

				buttonCloseCurrentBooking.Visible = b.Open;
			}
            else
            {
                labelBasePriceText.Text = "----------------";
                labelCarText.Text = "----------------";
                labelNumberplateText.Text = "----------------";
                labelPriceMinText.Text = "----------------";
                labelPricePerKilometreText.Text = "----------------";
                labelStartMileageText.Text = "----------------";
                labelStartTimeText.Text = "----------------";
                watermarkTextBoxEndMileage.ResetText();
                watermarkTextBoxEndMileage.ResetToWatermark();
                watermarkTextBoxEndMileage.Watermark = "Stand in Km";
				labelTotalCostText.Text = "----------------";
				watermarkTextBoxEndMileage.Visible = false;
				watermarkTextBoxEndMileage.Enabled = false;
				labelEndMileageText.Visible = true;
				labelEndMileageText.Text = "----------------";

				buttonCloseCurrentBooking.Visible = false;
            }
        }

        private void buttonCloseCurrentBooking_Click(object sender, EventArgs e)
        {
            // Check if the user input in the textbox is valid
            if (double.TryParse(watermarkTextBoxEndMileage.Text, out double userInput) && listBoxBooking.SelectedItem is Booking b && userInput >= b.StartMileage)
            {
                // Close the booking locally
                b.Close(DateTime.Now, userInput);
                // Close the booking in the database
                if(DBController.TryCloseBooking(b))
                {
                    Feedback.SuccessCloseBooking(b.CalculateCost());
					UpdateForm();
				}
                else
                {
                    Feedback.ErrorDatabaseConnection();
                }
            }
            else
            {
                Feedback.ErrorInvalidEndMileageInput();
            }
			
        }

		private void listBoxBooking_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxBooking.SelectedItem is Booking b)
			{
				ShowCurrentBookingInformation(b);
			}
			else
			{
				ShowCurrentBookingInformation();
			}
		}
	}
}
