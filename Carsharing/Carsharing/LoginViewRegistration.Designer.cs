namespace Carsharing
{
	partial class LoginViewRegistration
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonRegistration = new CustomControl.RoundButton();
			this.buttonCancel = new CustomControl.RoundButton();
			this.txtName = new CustomControl.WatermarkTextBox();
			this.txtLastName = new CustomControl.WatermarkTextBox();
			this.txtEmail = new CustomControl.WatermarkTextBox();
			this.txtPassword = new CustomControl.WatermarkTextBox();
			this.txtPassword2 = new CustomControl.WatermarkTextBox();
			this.txtBirthDate = new CustomControl.WatermarkTextBox();
			this.txtPhoneNumber = new CustomControl.WatermarkTextBox();
			this.txtStreet = new CustomControl.WatermarkTextBox();
			this.txtHouseNumber = new CustomControl.WatermarkTextBox();
			this.txtPlz = new CustomControl.WatermarkTextBox();
			this.txtCity = new CustomControl.WatermarkTextBox();
			this.txtCountry = new CustomControl.WatermarkTextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// buttonRegistration
			// 
			this.buttonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonRegistration.FlatAppearance.BorderSize = 0;
			this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRegistration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRegistration.Location = new System.Drawing.Point(87, 305);
			this.buttonRegistration.Name = "buttonRegistration";
			this.buttonRegistration.Size = new System.Drawing.Size(350, 31);
			this.buttonRegistration.TabIndex = 13;
			this.buttonRegistration.Text = "Registrieren";
			this.buttonRegistration.UseVisualStyleBackColor = false;
			this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonCancel.FlatAppearance.BorderSize = 0;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCancel.Location = new System.Drawing.Point(87, 360);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(350, 31);
			this.buttonCancel.TabIndex = 14;
			this.buttonCancel.Text = "Abbrechen";
			this.buttonCancel.UseVisualStyleBackColor = false;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtName.Location = new System.Drawing.Point(87, 29);
			this.txtName.Name = "txtName";
			this.txtName.Password = false;
			this.txtName.Size = new System.Drawing.Size(172, 22);
			this.txtName.TabIndex = 16;
			this.txtName.Watermark = "Vorname";
			this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtLastName.Location = new System.Drawing.Point(265, 29);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Password = false;
			this.txtLastName.Size = new System.Drawing.Size(172, 22);
			this.txtLastName.TabIndex = 28;
			this.txtLastName.Watermark = "Nachname";
			this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtEmail.Location = new System.Drawing.Point(87, 57);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Password = false;
			this.txtEmail.Size = new System.Drawing.Size(350, 22);
			this.txtEmail.TabIndex = 29;
			this.txtEmail.Watermark = "E-Mail-Adresse";
			this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtPassword.Location = new System.Drawing.Point(87, 85);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Password = true;
			this.txtPassword.Size = new System.Drawing.Size(172, 22);
			this.txtPassword.TabIndex = 30;
			this.txtPassword.Watermark = "Passwort";
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txtPassword2
			// 
			this.txtPassword2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtPassword2.Location = new System.Drawing.Point(265, 85);
			this.txtPassword2.Name = "txtPassword2";
			this.txtPassword2.Password = true;
			this.txtPassword2.Size = new System.Drawing.Size(172, 22);
			this.txtPassword2.TabIndex = 31;
			this.txtPassword2.Watermark = "Passwort bestätigen";
			this.txtPassword2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txtBirthDate
			// 
			this.txtBirthDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtBirthDate.Location = new System.Drawing.Point(87, 154);
			this.txtBirthDate.Name = "txtBirthDate";
			this.txtBirthDate.Password = false;
			this.txtBirthDate.Size = new System.Drawing.Size(350, 22);
			this.txtBirthDate.TabIndex = 33;
			this.txtBirthDate.Watermark = "Geburtsdatum (dd/mm/yyyy)";
			this.txtBirthDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtPhoneNumber.Location = new System.Drawing.Point(87, 126);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Password = false;
			this.txtPhoneNumber.Size = new System.Drawing.Size(350, 22);
			this.txtPhoneNumber.TabIndex = 32;
			this.txtPhoneNumber.Watermark = "Telefonnummer";
			this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txtStreet
			// 
			this.txtStreet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtStreet.Location = new System.Drawing.Point(87, 197);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.Password = false;
			this.txtStreet.Size = new System.Drawing.Size(267, 22);
			this.txtStreet.TabIndex = 34;
			this.txtStreet.Watermark = "Straße";
			this.txtStreet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txtHouseNumber
			// 
			this.txtHouseNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHouseNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtHouseNumber.Location = new System.Drawing.Point(360, 197);
			this.txtHouseNumber.Name = "txtHouseNumber";
			this.txtHouseNumber.Password = false;
			this.txtHouseNumber.Size = new System.Drawing.Size(77, 22);
			this.txtHouseNumber.TabIndex = 35;
			this.txtHouseNumber.Watermark = "Haus Nr.";
			this.txtHouseNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txtPlz
			// 
			this.txtPlz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtPlz.Location = new System.Drawing.Point(87, 225);
			this.txtPlz.MaxLength = 5;
			this.txtPlz.Name = "txtPlz";
			this.txtPlz.Password = false;
			this.txtPlz.Size = new System.Drawing.Size(72, 22);
			this.txtPlz.TabIndex = 36;
			this.txtPlz.Watermark = "PLZ";
			this.txtPlz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txtCity
			// 
			this.txtCity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtCity.Location = new System.Drawing.Point(165, 225);
			this.txtCity.Name = "txtCity";
			this.txtCity.Password = false;
			this.txtCity.Size = new System.Drawing.Size(272, 22);
			this.txtCity.TabIndex = 37;
			this.txtCity.Watermark = "Stadt";
			this.txtCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txtCountry
			// 
			this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtCountry.Location = new System.Drawing.Point(87, 253);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Password = false;
			this.txtCountry.Size = new System.Drawing.Size(350, 22);
			this.txtCountry.TabIndex = 38;
			this.txtCountry.Watermark = "Land";
			this.txtCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Location = new System.Drawing.Point(87, 347);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(350, 1);
			this.panel2.TabIndex = 39;
			// 
			// LoginViewRegistration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.txtCountry);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtPlz);
			this.Controls.Add(this.txtHouseNumber);
			this.Controls.Add(this.txtStreet);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.txtBirthDate);
			this.Controls.Add(this.txtPassword2);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonRegistration);
			this.Name = "LoginViewRegistration";
			this.Size = new System.Drawing.Size(525, 425);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CustomControl.RoundButton buttonRegistration;
		private CustomControl.RoundButton buttonCancel;
		private CustomControl.WatermarkTextBox txtName;
		private CustomControl.WatermarkTextBox txtLastName;
		private CustomControl.WatermarkTextBox txtEmail;
		private CustomControl.WatermarkTextBox txtPassword;
		private CustomControl.WatermarkTextBox txtPassword2;
		private CustomControl.WatermarkTextBox txtBirthDate;
		private CustomControl.WatermarkTextBox txtPhoneNumber;
		private CustomControl.WatermarkTextBox txtStreet;
		private CustomControl.WatermarkTextBox txtHouseNumber;
		private CustomControl.WatermarkTextBox txtPlz;
		private CustomControl.WatermarkTextBox txtCity;
		private CustomControl.WatermarkTextBox txtCountry;
		private System.Windows.Forms.Panel panel2;
	}
}
