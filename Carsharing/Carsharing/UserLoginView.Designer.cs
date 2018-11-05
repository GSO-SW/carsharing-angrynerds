namespace Carsharing
{
	partial class UserLoginView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginView));
			this.buttonCancel = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelName = new System.Windows.Forms.Label();
			this.pictureLogo = new System.Windows.Forms.PictureBox();
			this.txtPassword = new CustomControl.WatermarkTextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtEmail = new CustomControl.WatermarkTextBox();
			this.buttonRegister = new CustomControl.RoundButton();
			this.buttonLogin = new CustomControl.RoundButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatAppearance.BorderSize = 0;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.Location = new System.Drawing.Point(773, 2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(21, 21);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.panel1.Controls.Add(this.labelName);
			this.panel1.Controls.Add(this.pictureLogo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(275, 450);
			this.panel1.TabIndex = 1;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(53, 263);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(178, 36);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Instant Car";
			// 
			// pictureLogo
			// 
			this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
			this.pictureLogo.Location = new System.Drawing.Point(28, 92);
			this.pictureLogo.Name = "pictureLogo";
			this.pictureLogo.Size = new System.Drawing.Size(220, 161);
			this.pictureLogo.TabIndex = 0;
			this.pictureLogo.TabStop = false;
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtPassword.Location = new System.Drawing.Point(380, 163);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Password = true;
			this.txtPassword.Size = new System.Drawing.Size(332, 26);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.Watermark = "Passwort";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Location = new System.Drawing.Point(380, 269);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(332, 1);
			this.panel2.TabIndex = 7;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.panel3.Controls.Add(this.buttonCancel);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(800, 26);
			this.panel3.TabIndex = 9;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.txtEmail.Location = new System.Drawing.Point(380, 122);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Password = false;
			this.txtEmail.Size = new System.Drawing.Size(332, 26);
			this.txtEmail.TabIndex = 10;
			this.txtEmail.Watermark = "E-Mail";
			// 
			// buttonRegister
			// 
			this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonRegister.FlatAppearance.BorderSize = 0;
			this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRegister.Location = new System.Drawing.Point(380, 286);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Rounded = 0;
			this.buttonRegister.Size = new System.Drawing.Size(332, 31);
			this.buttonRegister.TabIndex = 8;
			this.buttonRegister.Text = "Registrieren";
			this.buttonRegister.UseVisualStyleBackColor = false;
			this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
			// 
			// buttonLogin
			// 
			this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonLogin.FlatAppearance.BorderSize = 0;
			this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.Location = new System.Drawing.Point(380, 222);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Rounded = 0;
			this.buttonLogin.Size = new System.Drawing.Size(332, 31);
			this.buttonLogin.TabIndex = 6;
			this.buttonLogin.Text = "Anmelden";
			this.buttonLogin.UseVisualStyleBackColor = false;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// UserLoginView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.buttonRegister);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UserLoginView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserLoginView";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Panel panel1;
		private CustomControl.WatermarkTextBox txtPassword;
		private System.Windows.Forms.PictureBox pictureLogo;
		private CustomControl.RoundButton buttonLogin;
		private System.Windows.Forms.Panel panel2;
		private CustomControl.RoundButton buttonRegister;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Panel panel3;
		private CustomControl.WatermarkTextBox txtEmail;
	}
}