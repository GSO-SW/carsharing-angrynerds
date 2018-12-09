namespace Carsharing
{
	partial class MainView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			this.panel3 = new System.Windows.Forms.Panel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureLogo = new System.Windows.Forms.PictureBox();
			this.buttonUsers = new System.Windows.Forms.Button();
			this.buttonBooking = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.buttonVehicles = new System.Windows.Forms.Button();
			this.panelSelect = new System.Windows.Forms.Panel();
			this.buttonStatus = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.panel3.Controls.Add(this.buttonCancel);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1100, 25);
			this.panel3.TabIndex = 10;
			this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
			this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
			this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonCancel.FlatAppearance.BorderSize = 0;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.Location = new System.Drawing.Point(1075, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(25, 25);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.panel1.Controls.Add(this.pictureLogo);
			this.panel1.Controls.Add(this.buttonUsers);
			this.panel1.Controls.Add(this.buttonBooking);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.buttonVehicles);
			this.panel1.Controls.Add(this.panelSelect);
			this.panel1.Controls.Add(this.buttonStatus);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 575);
			this.panel1.TabIndex = 11;
			this.panel1.Tag = "1";
			// 
			// pictureLogo
			// 
			this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
			this.pictureLogo.Location = new System.Drawing.Point(5, 6);
			this.pictureLogo.Name = "pictureLogo";
			this.pictureLogo.Size = new System.Drawing.Size(192, 128);
			this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureLogo.TabIndex = 6;
			this.pictureLogo.TabStop = false;
			// 
			// buttonUsers
			// 
			this.buttonUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonUsers.FlatAppearance.BorderSize = 0;
			this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUsers.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonUsers.Location = new System.Drawing.Point(15, 530);
			this.buttonUsers.Name = "buttonUsers";
			this.buttonUsers.Size = new System.Drawing.Size(182, 40);
			this.buttonUsers.TabIndex = 4;
			this.buttonUsers.Text = "Nutzer";
			this.buttonUsers.UseVisualStyleBackColor = false;
			this.buttonUsers.Click += new System.EventHandler(this.buttonStatus_Click);
			// 
			// buttonBooking
			// 
			this.buttonBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonBooking.FlatAppearance.BorderSize = 0;
			this.buttonBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBooking.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonBooking.Location = new System.Drawing.Point(15, 180);
			this.buttonBooking.Name = "buttonBooking";
			this.buttonBooking.Size = new System.Drawing.Size(182, 40);
			this.buttonBooking.TabIndex = 3;
			this.buttonBooking.Text = "Buchung";
			this.buttonBooking.UseVisualStyleBackColor = false;
			this.buttonBooking.Click += new System.EventHandler(this.buttonStatus_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(15, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(165, 40);
			this.button3.TabIndex = 2;
			this.button3.Text = "Home";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// buttonVehicles
			// 
			this.buttonVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonVehicles.FlatAppearance.BorderSize = 0;
			this.buttonVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonVehicles.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonVehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonVehicles.Location = new System.Drawing.Point(15, 490);
			this.buttonVehicles.Name = "buttonVehicles";
			this.buttonVehicles.Size = new System.Drawing.Size(182, 40);
			this.buttonVehicles.TabIndex = 1;
			this.buttonVehicles.Text = "Fuhrpark";
			this.buttonVehicles.UseVisualStyleBackColor = false;
			this.buttonVehicles.Click += new System.EventHandler(this.buttonStatus_Click);
			// 
			// panelSelect
			// 
			this.panelSelect.BackColor = System.Drawing.Color.Black;
			this.panelSelect.Location = new System.Drawing.Point(5, 140);
			this.panelSelect.Name = "panelSelect";
			this.panelSelect.Size = new System.Drawing.Size(10, 40);
			this.panelSelect.TabIndex = 0;
			// 
			// buttonStatus
			// 
			this.buttonStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(72)))));
			this.buttonStatus.FlatAppearance.BorderSize = 0;
			this.buttonStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStatus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonStatus.Location = new System.Drawing.Point(15, 140);
			this.buttonStatus.Name = "buttonStatus";
			this.buttonStatus.Size = new System.Drawing.Size(182, 40);
			this.buttonStatus.TabIndex = 0;
			this.buttonStatus.Text = "Status";
			this.buttonStatus.UseVisualStyleBackColor = false;
			this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(1100, 600);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainView";
			this.Load += new System.EventHandler(this.MainView_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonStatus;
		private System.Windows.Forms.Panel panelSelect;
		private System.Windows.Forms.Button buttonUsers;
		private System.Windows.Forms.Button buttonBooking;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button buttonVehicles;
		private System.Windows.Forms.PictureBox pictureLogo;
		private MainViewUserBooking userBooking1;
		private MainViewUserStatus userStatus1;
		private MainViewAdminUsers adminUsers1;
		private MainViewAdminVehicle adminVehicles1;
	}
}