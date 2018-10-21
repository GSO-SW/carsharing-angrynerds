using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	class Customer
	{
		#region Attributes
		private string name;
		private string lastName;
		private string emailAddress;
		private string phoneNumber;
		private string password;
		private DateTime birthday;
		private string street;
		private string houseNumber;
		private string plz;
		private string city;
		private string country;
		private bool isAdmin;
		#endregion

		#region Propeties
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public string EmailAddress
		{
			get { return emailAddress; }
			set { emailAddress = value; }
		}

		public string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public DateTime Birthday
		{
			get { return birthday; }
			set { birthday = value; }
		}

		public string Street
		{
			get { return street; }
			set { street = value; }
		}

		public string HouseNumber
		{
			get { return houseNumber; }
			set { houseNumber = value; }
		}

		public string PLZ
		{
			get { return plz; }
			set { plz = value; }
		}

		public string City
		{
			get { return city; }
			set { city = value; }
		}

		public string Country
		{
			get { return country; }
			set { country = value; }
		}

		public bool IsAdmin
		{
			get { return isAdmin; }
			set { isAdmin = value; }
		}
		#endregion
	}
}
