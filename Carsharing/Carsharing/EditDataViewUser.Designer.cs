namespace Carsharing
{
	partial class EditDataViewUser
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
			this.txtCountry = new CustomControl.WatermarkTextBox();
			this.txtCity = new CustomControl.WatermarkTextBox();
			this.txtPlz = new CustomControl.WatermarkTextBox();
			this.txtHouseNumber = new CustomControl.WatermarkTextBox();
			this.txtStreet = new CustomControl.WatermarkTextBox();
			this.txtPhoneNumber = new CustomControl.WatermarkTextBox();
			this.txtBirthDate = new CustomControl.WatermarkTextBox();
			this.txtEmail = new CustomControl.WatermarkTextBox();
			this.txtLastName = new CustomControl.WatermarkTextBox();
			this.txtName = new CustomControl.WatermarkTextBox();
			this.buttonAccept = new CustomControl.RoundButton();
			this.checkAdmin = new System.Windows.Forms.CheckBox();
			this.labelAdmin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtCountry
			// 
			this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtCountry.Location = new System.Drawing.Point(87, 250);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Password = false;
			this.txtCountry.Size = new System.Drawing.Size(350, 25);
			this.txtCountry.TabIndex = 53;
			this.txtCountry.Watermark = "Land";
			// 
			// txtCity
			// 
			this.txtCity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtCity.Location = new System.Drawing.Point(165, 222);
			this.txtCity.Name = "txtCity";
			this.txtCity.Password = false;
			this.txtCity.Size = new System.Drawing.Size(272, 25);
			this.txtCity.TabIndex = 52;
			this.txtCity.Watermark = "Stadt";
			// 
			// txtPlz
			// 
			this.txtPlz.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtPlz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtPlz.Location = new System.Drawing.Point(87, 222);
			this.txtPlz.Name = "txtPlz";
			this.txtPlz.Password = false;
			this.txtPlz.Size = new System.Drawing.Size(72, 25);
			this.txtPlz.TabIndex = 51;
			this.txtPlz.Watermark = "PLZ";
			// 
			// txtHouseNumber
			// 
			this.txtHouseNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtHouseNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtHouseNumber.Location = new System.Drawing.Point(360, 194);
			this.txtHouseNumber.Name = "txtHouseNumber";
			this.txtHouseNumber.Password = false;
			this.txtHouseNumber.Size = new System.Drawing.Size(77, 25);
			this.txtHouseNumber.TabIndex = 50;
			this.txtHouseNumber.Watermark = "Haus Nr.";
			// 
			// txtStreet
			// 
			this.txtStreet.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtStreet.Location = new System.Drawing.Point(87, 194);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.Password = false;
			this.txtStreet.Size = new System.Drawing.Size(267, 25);
			this.txtStreet.TabIndex = 49;
			this.txtStreet.Watermark = "Straße";
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtPhoneNumber.Location = new System.Drawing.Point(87, 123);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Password = false;
			this.txtPhoneNumber.Size = new System.Drawing.Size(350, 25);
			this.txtPhoneNumber.TabIndex = 47;
			this.txtPhoneNumber.Watermark = "Telefonnummer";
			// 
			// txtBirthDate
			// 
			this.txtBirthDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtBirthDate.Location = new System.Drawing.Point(87, 151);
			this.txtBirthDate.Name = "txtBirthDate";
			this.txtBirthDate.Password = false;
			this.txtBirthDate.Size = new System.Drawing.Size(350, 25);
			this.txtBirthDate.TabIndex = 48;
			this.txtBirthDate.Watermark = "Geburtsdatum (dd/mm/yyyy)";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtEmail.Location = new System.Drawing.Point(87, 71);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Password = false;
			this.txtEmail.Size = new System.Drawing.Size(350, 25);
			this.txtEmail.TabIndex = 44;
			this.txtEmail.Watermark = "E-Mail-Adresse";
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtLastName.Location = new System.Drawing.Point(265, 43);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Password = false;
			this.txtLastName.Size = new System.Drawing.Size(172, 25);
			this.txtLastName.TabIndex = 43;
			this.txtLastName.Watermark = "Zuname";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtName.Location = new System.Drawing.Point(87, 43);
			this.txtName.Name = "txtName";
			this.txtName.Password = false;
			this.txtName.Size = new System.Drawing.Size(172, 25);
			this.txtName.TabIndex = 42;
			this.txtName.Watermark = "Vorname";
			// 
			// buttonAccept
			// 
			this.buttonAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonAccept.FlatAppearance.BorderSize = 0;
			this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAccept.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.buttonAccept.Location = new System.Drawing.Point(87, 348);
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.Size = new System.Drawing.Size(350, 31);
			this.buttonAccept.TabIndex = 41;
			this.buttonAccept.Text = "Kunden bearbeiten";
			this.buttonAccept.UseVisualStyleBackColor = false;
			this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
			// 
			// checkAdmin
			// 
			this.checkAdmin.AutoSize = true;
			this.checkAdmin.Checked = true;
			this.checkAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkAdmin.Location = new System.Drawing.Point(138, 296);
			this.checkAdmin.Name = "checkAdmin";
			this.checkAdmin.Size = new System.Drawing.Size(15, 14);
			this.checkAdmin.TabIndex = 245;
			this.checkAdmin.UseVisualStyleBackColor = true;
			// 
			// labelAdmin
			// 
			this.labelAdmin.AutoSize = true;
			this.labelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelAdmin.ForeColor = System.Drawing.Color.Black;
			this.labelAdmin.Location = new System.Drawing.Point(83, 294);
			this.labelAdmin.Name = "labelAdmin";
			this.labelAdmin.Size = new System.Drawing.Size(49, 19);
			this.labelAdmin.TabIndex = 244;
			this.labelAdmin.Text = "Admin";
			// 
			// EditDataViewUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.checkAdmin);
			this.Controls.Add(this.labelAdmin);
			this.Controls.Add(this.txtCountry);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtPlz);
			this.Controls.Add(this.txtHouseNumber);
			this.Controls.Add(this.txtStreet);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.txtBirthDate);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.buttonAccept);
			this.Name = "EditDataViewUser";
			this.Size = new System.Drawing.Size(525, 425);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CustomControl.WatermarkTextBox txtCountry;
		private CustomControl.WatermarkTextBox txtCity;
		private CustomControl.WatermarkTextBox txtPlz;
		private CustomControl.WatermarkTextBox txtHouseNumber;
		private CustomControl.WatermarkTextBox txtStreet;
		private CustomControl.WatermarkTextBox txtPhoneNumber;
		private CustomControl.WatermarkTextBox txtBirthDate;
		private CustomControl.WatermarkTextBox txtEmail;
		private CustomControl.WatermarkTextBox txtLastName;
		private CustomControl.WatermarkTextBox txtName;
		private CustomControl.RoundButton buttonAccept;
		private System.Windows.Forms.CheckBox checkAdmin;
		private System.Windows.Forms.Label labelAdmin;
	}
}
