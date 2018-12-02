using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	public class Customer
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
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string EmailAddress
		{
			get { return emailAddress; }
			set { emailAddress = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public DateTime Birthday
		{
			get { return birthday; }
			set { birthday = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string Street
		{
			get { return street; }
			set { street = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string HouseNumber
		{
			get { return houseNumber; }
			set { houseNumber = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string PLZ
		{
			get { return plz; }
			set { plz = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string City
		{
			get { return city; }
			set { city = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string Country
		{
			get { return country; }
			set { country = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public bool IsAdmin
		{
			get { return isAdmin; }
			set { isAdmin = value; }
		}
		#endregion

		public Customer()
		{
			this.name = String.Empty;
			this.lastName = String.Empty;
			this.emailAddress = String.Empty;
			this.phoneNumber = String.Empty;
			this.password = String.Empty;
			this.birthday = new DateTime();
			this.street = String.Empty;
			this.houseNumber = String.Empty;
			this.plz = String.Empty;
			this.city = String.Empty;
			this.country = String.Empty;
			this.isAdmin = false;
		}

		public Customer(string name, string lastName, string emailAddress, string phoneNumber, string password, DateTime birthday, string street, string houseNumber, string plz, string city, string country, bool isAdmin)
		{
			this.name = name;
			this.lastName = lastName;
			this.emailAddress = emailAddress;
			this.phoneNumber = phoneNumber;
			this.password = password;
			this.birthday = birthday;
			this.street = street;
			this.houseNumber = houseNumber;
			this.plz = plz;
			this.city = city;
			this.country = country;
			this.isAdmin = isAdmin;
		}

		public override string ToString()
		{
			return lastName + ", " + name;
		}
	}
}
