using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	internal class Customer
	{
		#region Attributes
		private string name;
		private string lastName;
		private string emailAddress;
		private string phoneNumber;
		private string passwordHash;
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
		internal string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal string EmailAddress
		{
			get { return emailAddress; }
			set { emailAddress = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal string PasswordHash
		{
			get { return passwordHash; }
			set { passwordHash = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal DateTime Birthday
		{
			get { return birthday; }
			set { birthday = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal string Street
		{
			get { return street; }
			set { street = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal string HouseNumber
		{
			get { return houseNumber; }
			set { houseNumber = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal string PLZ
		{
			get { return plz; }
			set { plz = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal string City
		{
			get { return city; }
			set { city = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal string Country
		{
			get { return country; }
			set { country = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal bool IsAdmin
		{
			get { return isAdmin; }
			set { isAdmin = value; }
		}
		#endregion

		internal Customer(string name, string lastName, string emailAddress, string phoneNumber, string password, DateTime birthday, string street, string houseNumber, string plz, string city, string country, bool isAdmin)
		{
			this.name = name;
			this.lastName = lastName;
			this.emailAddress = emailAddress;
			this.phoneNumber = phoneNumber;
			this.passwordHash = password;
			this.birthday = birthday;
			this.street = street;
			this.houseNumber = houseNumber;
			this.plz = plz;
			this.city = city;
			this.country = country;
			this.isAdmin = isAdmin;
		}
	}
}
