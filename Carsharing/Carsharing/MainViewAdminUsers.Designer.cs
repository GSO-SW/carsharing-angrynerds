namespace Carsharing
{
	partial class MainViewAdminUsers
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
			this.buttonUserDelete = new CustomControl.RoundButton();
			this.buttonUserEdit = new CustomControl.RoundButton();
			this.listUser = new System.Windows.Forms.ListBox();
			this.buttonRefresh = new CustomControl.RoundButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtCountry = new System.Windows.Forms.Label();
			this.labelCountry = new System.Windows.Forms.Label();
			this.checkAdmin = new System.Windows.Forms.CheckBox();
			this.txtCity = new System.Windows.Forms.Label();
			this.labelCity = new System.Windows.Forms.Label();
			this.txtPLZ = new System.Windows.Forms.Label();
			this.labelPLZ = new System.Windows.Forms.Label();
			this.txtHouse = new System.Windows.Forms.Label();
			this.labelHouse = new System.Windows.Forms.Label();
			this.txtStreet = new System.Windows.Forms.Label();
			this.labelStreet = new System.Windows.Forms.Label();
			this.txtBirth = new System.Windows.Forms.Label();
			this.labelBirth = new System.Windows.Forms.Label();
			this.labelAdmin = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.Label();
			this.labelPhone = new System.Windows.Forms.Label();
			this.txtLastname = new System.Windows.Forms.Label();
			this.labelLastname = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonUserDelete
			// 
			this.buttonUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonUserDelete.FlatAppearance.BorderSize = 0;
			this.buttonUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUserDelete.Location = new System.Drawing.Point(591, 544);
			this.buttonUserDelete.Name = "buttonUserDelete";
			this.buttonUserDelete.Size = new System.Drawing.Size(150, 28);
			this.buttonUserDelete.TabIndex = 8;
			this.buttonUserDelete.Text = "Nutzer löschen";
			this.buttonUserDelete.UseVisualStyleBackColor = false;
			this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
			// 
			// buttonUserEdit
			// 
			this.buttonUserEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonUserEdit.FlatAppearance.BorderSize = 0;
			this.buttonUserEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUserEdit.Location = new System.Drawing.Point(747, 544);
			this.buttonUserEdit.Name = "buttonUserEdit";
			this.buttonUserEdit.Size = new System.Drawing.Size(150, 28);
			this.buttonUserEdit.TabIndex = 7;
			this.buttonUserEdit.Text = "Nutzer bearbeiten";
			this.buttonUserEdit.UseVisualStyleBackColor = false;
			this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEdit_Click);
			// 
			// listUser
			// 
			this.listUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.listUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listUser.Dock = System.Windows.Forms.DockStyle.Left;
			this.listUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listUser.FormattingEnabled = true;
			this.listUser.ItemHeight = 20;
			this.listUser.Location = new System.Drawing.Point(0, 0);
			this.listUser.Name = "listUser";
			this.listUser.Size = new System.Drawing.Size(245, 575);
			this.listUser.TabIndex = 9;
			this.listUser.SelectedIndexChanged += new System.EventHandler(this.listUser_SelectedIndexChanged);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonRefresh.FlatAppearance.BorderSize = 0;
			this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRefresh.Location = new System.Drawing.Point(251, 544);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(94, 28);
			this.buttonRefresh.TabIndex = 10;
			this.buttonRefresh.Text = "Aktualisieren";
			this.buttonRefresh.UseVisualStyleBackColor = false;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.txtCountry);
			this.panel1.Controls.Add(this.labelCountry);
			this.panel1.Controls.Add(this.checkAdmin);
			this.panel1.Controls.Add(this.txtCity);
			this.panel1.Controls.Add(this.labelCity);
			this.panel1.Controls.Add(this.txtPLZ);
			this.panel1.Controls.Add(this.labelPLZ);
			this.panel1.Controls.Add(this.txtHouse);
			this.panel1.Controls.Add(this.labelHouse);
			this.panel1.Controls.Add(this.txtStreet);
			this.panel1.Controls.Add(this.labelStreet);
			this.panel1.Controls.Add(this.txtBirth);
			this.panel1.Controls.Add(this.labelBirth);
			this.panel1.Controls.Add(this.labelAdmin);
			this.panel1.Controls.Add(this.txtPhone);
			this.panel1.Controls.Add(this.labelPhone);
			this.panel1.Controls.Add(this.txtLastname);
			this.panel1.Controls.Add(this.labelLastname);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.labelName);
			this.panel1.Controls.Add(this.txtEmail);
			this.panel1.Controls.Add(this.labelEmail);
			this.panel1.Location = new System.Drawing.Point(245, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(655, 535);
			this.panel1.TabIndex = 11;
			// 
			// txtCountry
			// 
			this.txtCountry.AutoSize = true;
			this.txtCountry.BackColor = System.Drawing.Color.White;
			this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCountry.Location = new System.Drawing.Point(26, 412);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(105, 19);
			this.txtCountry.TabIndex = 245;
			this.txtCountry.Text = "----------------";
			// 
			// labelCountry
			// 
			this.labelCountry.AutoSize = true;
			this.labelCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelCountry.Location = new System.Drawing.Point(25, 390);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.Size = new System.Drawing.Size(39, 19);
			this.labelCountry.TabIndex = 244;
			this.labelCountry.Text = "Land";
			// 
			// checkAdmin
			// 
			this.checkAdmin.AutoSize = true;
			this.checkAdmin.Enabled = false;
			this.checkAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkAdmin.Location = new System.Drawing.Point(508, 23);
			this.checkAdmin.Name = "checkAdmin";
			this.checkAdmin.Size = new System.Drawing.Size(15, 14);
			this.checkAdmin.TabIndex = 243;
			this.checkAdmin.UseVisualStyleBackColor = true;
			// 
			// txtCity
			// 
			this.txtCity.AutoSize = true;
			this.txtCity.BackColor = System.Drawing.Color.White;
			this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCity.Location = new System.Drawing.Point(26, 371);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(105, 19);
			this.txtCity.TabIndex = 64;
			this.txtCity.Text = "----------------";
			// 
			// labelCity
			// 
			this.labelCity.AutoSize = true;
			this.labelCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelCity.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelCity.Location = new System.Drawing.Point(25, 349);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(41, 19);
			this.labelCity.TabIndex = 63;
			this.labelCity.Text = "Stadt";
			// 
			// txtPLZ
			// 
			this.txtPLZ.AutoSize = true;
			this.txtPLZ.BackColor = System.Drawing.Color.White;
			this.txtPLZ.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPLZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPLZ.Location = new System.Drawing.Point(26, 330);
			this.txtPLZ.Name = "txtPLZ";
			this.txtPLZ.Size = new System.Drawing.Size(105, 19);
			this.txtPLZ.TabIndex = 62;
			this.txtPLZ.Text = "----------------";
			// 
			// labelPLZ
			// 
			this.labelPLZ.AutoSize = true;
			this.labelPLZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPLZ.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPLZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPLZ.Location = new System.Drawing.Point(25, 308);
			this.labelPLZ.Name = "labelPLZ";
			this.labelPLZ.Size = new System.Drawing.Size(77, 19);
			this.labelPLZ.TabIndex = 61;
			this.labelPLZ.Text = "Postleitzahl";
			// 
			// txtHouse
			// 
			this.txtHouse.AutoSize = true;
			this.txtHouse.BackColor = System.Drawing.Color.White;
			this.txtHouse.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtHouse.Location = new System.Drawing.Point(26, 289);
			this.txtHouse.Name = "txtHouse";
			this.txtHouse.Size = new System.Drawing.Size(105, 19);
			this.txtHouse.TabIndex = 60;
			this.txtHouse.Text = "----------------";
			// 
			// labelHouse
			// 
			this.labelHouse.AutoSize = true;
			this.labelHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelHouse.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelHouse.Location = new System.Drawing.Point(25, 267);
			this.labelHouse.Name = "labelHouse";
			this.labelHouse.Size = new System.Drawing.Size(92, 19);
			this.labelHouse.TabIndex = 59;
			this.labelHouse.Text = "Hausnummer";
			// 
			// txtStreet
			// 
			this.txtStreet.AutoSize = true;
			this.txtStreet.BackColor = System.Drawing.Color.White;
			this.txtStreet.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtStreet.Location = new System.Drawing.Point(26, 248);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.Size = new System.Drawing.Size(105, 19);
			this.txtStreet.TabIndex = 58;
			this.txtStreet.Text = "----------------";
			// 
			// labelStreet
			// 
			this.labelStreet.AutoSize = true;
			this.labelStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelStreet.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelStreet.Location = new System.Drawing.Point(25, 226);
			this.labelStreet.Name = "labelStreet";
			this.labelStreet.Size = new System.Drawing.Size(48, 19);
			this.labelStreet.TabIndex = 57;
			this.labelStreet.Text = "Straße";
			// 
			// txtBirth
			// 
			this.txtBirth.AutoSize = true;
			this.txtBirth.BackColor = System.Drawing.Color.White;
			this.txtBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtBirth.Location = new System.Drawing.Point(26, 207);
			this.txtBirth.Name = "txtBirth";
			this.txtBirth.Size = new System.Drawing.Size(105, 19);
			this.txtBirth.TabIndex = 56;
			this.txtBirth.Text = "----------------";
			// 
			// labelBirth
			// 
			this.labelBirth.AutoSize = true;
			this.labelBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelBirth.Location = new System.Drawing.Point(25, 185);
			this.labelBirth.Name = "labelBirth";
			this.labelBirth.Size = new System.Drawing.Size(78, 19);
			this.labelBirth.TabIndex = 55;
			this.labelBirth.Text = "Geburtstag";
			// 
			// labelAdmin
			// 
			this.labelAdmin.AutoSize = true;
			this.labelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelAdmin.Location = new System.Drawing.Point(453, 21);
			this.labelAdmin.Name = "labelAdmin";
			this.labelAdmin.Size = new System.Drawing.Size(49, 19);
			this.labelAdmin.TabIndex = 51;
			this.labelAdmin.Text = "Admin";
			// 
			// txtPhone
			// 
			this.txtPhone.AutoSize = true;
			this.txtPhone.BackColor = System.Drawing.Color.White;
			this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPhone.Location = new System.Drawing.Point(26, 166);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(105, 19);
			this.txtPhone.TabIndex = 50;
			this.txtPhone.Text = "----------------";
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPhone.Location = new System.Drawing.Point(25, 144);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(104, 19);
			this.labelPhone.TabIndex = 49;
			this.labelPhone.Text = "Telefonnummer";
			// 
			// txtLastname
			// 
			this.txtLastname.AutoSize = true;
			this.txtLastname.BackColor = System.Drawing.Color.White;
			this.txtLastname.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtLastname.Location = new System.Drawing.Point(26, 125);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(105, 19);
			this.txtLastname.TabIndex = 48;
			this.txtLastname.Text = "----------------";
			// 
			// labelLastname
			// 
			this.labelLastname.AutoSize = true;
			this.labelLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelLastname.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelLastname.Location = new System.Drawing.Point(25, 103);
			this.labelLastname.Name = "labelLastname";
			this.labelLastname.Size = new System.Drawing.Size(74, 19);
			this.labelLastname.TabIndex = 47;
			this.labelLastname.Text = "Nachname";
			// 
			// txtName
			// 
			this.txtName.AutoSize = true;
			this.txtName.BackColor = System.Drawing.Color.White;
			this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtName.Location = new System.Drawing.Point(27, 84);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(105, 19);
			this.txtName.TabIndex = 46;
			this.txtName.Text = "----------------";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelName.Location = new System.Drawing.Point(26, 62);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(64, 19);
			this.labelName.TabIndex = 45;
			this.labelName.Text = "Vorname";
			// 
			// txtEmail
			// 
			this.txtEmail.AutoSize = true;
			this.txtEmail.BackColor = System.Drawing.Color.White;
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtEmail.Location = new System.Drawing.Point(26, 43);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(105, 19);
			this.txtEmail.TabIndex = 44;
			this.txtEmail.Text = "----------------";
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelEmail.Location = new System.Drawing.Point(25, 21);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(41, 19);
			this.labelEmail.TabIndex = 43;
			this.labelEmail.Text = "Email";
			// 
			// MainViewAdminUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.listUser);
			this.Controls.Add(this.buttonUserDelete);
			this.Controls.Add(this.buttonUserEdit);
			this.Name = "MainViewAdminUsers";
			this.Size = new System.Drawing.Size(900, 575);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private CustomControl.RoundButton buttonUserDelete;
		private CustomControl.RoundButton buttonUserEdit;
		private System.Windows.Forms.ListBox listUser;
		private CustomControl.RoundButton buttonRefresh;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label txtCity;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.Label txtPLZ;
		private System.Windows.Forms.Label labelPLZ;
		private System.Windows.Forms.Label txtHouse;
		private System.Windows.Forms.Label labelHouse;
		private System.Windows.Forms.Label txtStreet;
		private System.Windows.Forms.Label labelStreet;
		private System.Windows.Forms.Label txtBirth;
		private System.Windows.Forms.Label labelBirth;
		private System.Windows.Forms.Label labelAdmin;
		private System.Windows.Forms.Label txtPhone;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Label txtLastname;
		private System.Windows.Forms.Label labelLastname;
		private System.Windows.Forms.Label txtName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label txtEmail;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.CheckBox checkAdmin;
		private System.Windows.Forms.Label txtCountry;
		private System.Windows.Forms.Label labelCountry;
	}
}
