namespace Carsharing
{
	partial class ManageUserForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.customerListBox = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.telLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.lnameLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.countryLabel = new System.Windows.Forms.Label();
			this.cityLabel = new System.Windows.Forms.Label();
			this.PLZlabel = new System.Windows.Forms.Label();
			this.houseNumberLabel = new System.Windows.Forms.Label();
			this.streetLabel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.editButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// customerListBox
			// 
			this.customerListBox.DisplayMember = "EmailAddress";
			this.customerListBox.FormattingEnabled = true;
			this.customerListBox.Location = new System.Drawing.Point(12, 12);
			this.customerListBox.Name = "customerListBox";
			this.customerListBox.Size = new System.Drawing.Size(177, 420);
			this.customerListBox.Sorted = true;
			this.customerListBox.TabIndex = 0;
			this.customerListBox.SelectedIndexChanged += new System.EventHandler(this.customerListBox_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.telLabel);
			this.groupBox1.Controls.Add(this.emailLabel);
			this.groupBox1.Controls.Add(this.lnameLabel);
			this.groupBox1.Controls.Add(this.nameLabel);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.birthDatePicker);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(195, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(593, 275);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kundeninformationen";
			// 
			// telLabel
			// 
			this.telLabel.AutoSize = true;
			this.telLabel.Location = new System.Drawing.Point(136, 109);
			this.telLabel.Name = "telLabel";
			this.telLabel.Size = new System.Drawing.Size(0, 13);
			this.telLabel.TabIndex = 42;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(136, 83);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(0, 13);
			this.emailLabel.TabIndex = 41;
			// 
			// lnameLabel
			// 
			this.lnameLabel.AutoSize = true;
			this.lnameLabel.Location = new System.Drawing.Point(136, 57);
			this.lnameLabel.Name = "lnameLabel";
			this.lnameLabel.Size = new System.Drawing.Size(0, 13);
			this.lnameLabel.TabIndex = 40;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(136, 31);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(0, 13);
			this.nameLabel.TabIndex = 39;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.countryLabel);
			this.groupBox2.Controls.Add(this.cityLabel);
			this.groupBox2.Controls.Add(this.PLZlabel);
			this.groupBox2.Controls.Add(this.houseNumberLabel);
			this.groupBox2.Controls.Add(this.streetLabel);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(9, 158);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(467, 106);
			this.groupBox2.TabIndex = 38;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Adresse";
			// 
			// countryLabel
			// 
			this.countryLabel.AutoSize = true;
			this.countryLabel.Location = new System.Drawing.Point(130, 75);
			this.countryLabel.Name = "countryLabel";
			this.countryLabel.Size = new System.Drawing.Size(0, 13);
			this.countryLabel.TabIndex = 37;
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(226, 49);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(0, 13);
			this.cityLabel.TabIndex = 36;
			// 
			// PLZlabel
			// 
			this.PLZlabel.AutoSize = true;
			this.PLZlabel.Location = new System.Drawing.Point(130, 49);
			this.PLZlabel.Name = "PLZlabel";
			this.PLZlabel.Size = new System.Drawing.Size(0, 13);
			this.PLZlabel.TabIndex = 35;
			// 
			// houseNumberLabel
			// 
			this.houseNumberLabel.AutoSize = true;
			this.houseNumberLabel.Location = new System.Drawing.Point(417, 22);
			this.houseNumberLabel.Name = "houseNumberLabel";
			this.houseNumberLabel.Size = new System.Drawing.Size(0, 13);
			this.houseNumberLabel.TabIndex = 34;
			// 
			// streetLabel
			// 
			this.streetLabel.AutoSize = true;
			this.streetLabel.Location = new System.Drawing.Point(130, 22);
			this.streetLabel.Name = "streetLabel";
			this.streetLabel.Size = new System.Drawing.Size(0, 13);
			this.streetLabel.TabIndex = 33;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Straße:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(339, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Hausnummer:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 75);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(34, 13);
			this.label11.TabIndex = 16;
			this.label11.Text = "Land:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(185, 49);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 15;
			this.label10.Text = "Stadt:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 49);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Postleitzahl:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 135);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 13);
			this.label6.TabIndex = 36;
			this.label6.Text = "Geburtsdatum:";
			// 
			// birthDatePicker
			// 
			this.birthDatePicker.Enabled = false;
			this.birthDatePicker.Location = new System.Drawing.Point(139, 132);
			this.birthDatePicker.Name = "birthDatePicker";
			this.birthDatePicker.Size = new System.Drawing.Size(200, 20);
			this.birthDatePicker.TabIndex = 29;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 34;
			this.label3.Text = "E-Mail-Adresse:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 13);
			this.label4.TabIndex = 35;
			this.label4.Text = "Telefonnummer:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 33;
			this.label2.Text = "Nachname:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 32;
			this.label1.Text = "Vorname:";
			// 
			// editButton
			// 
			this.editButton.Enabled = false;
			this.editButton.Location = new System.Drawing.Point(195, 293);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(75, 23);
			this.editButton.TabIndex = 3;
			this.editButton.Text = "Bearbeiten";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// ManageUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 444);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.customerListBox);
			this.Name = "ManageUserForm";
			this.Text = "Kunden verwalten";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox customerListBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker birthDatePicker;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lnameLabel;
		private System.Windows.Forms.Label telLabel;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Label cityLabel;
		private System.Windows.Forms.Label PLZlabel;
		private System.Windows.Forms.Label houseNumberLabel;
		private System.Windows.Forms.Label streetLabel;
		private System.Windows.Forms.Label countryLabel;
		private System.Windows.Forms.Button editButton;
	}
}