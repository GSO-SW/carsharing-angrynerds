namespace Carsharing
{
	partial class LoginView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelName = new System.Windows.Forms.Label();
			this.pictureLogo = new System.Windows.Forms.PictureBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.accountLogin1 = new Carsharing.LoginViewLogin();
			this.accountRegistration1 = new Carsharing.LoginViewRegistration();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.panel1.Controls.Add(this.labelName);
			this.panel1.Controls.Add(this.pictureLogo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(275, 425);
			this.panel1.TabIndex = 10;
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
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonCancel.FlatAppearance.BorderSize = 0;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.Location = new System.Drawing.Point(775, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(25, 25);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.panel3.Controls.Add(this.buttonCancel);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(800, 25);
			this.panel3.TabIndex = 9;
			// 
			// accountLogin1
			// 
			this.accountLogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.accountLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.accountLogin1.Location = new System.Drawing.Point(275, 25);
			this.accountLogin1.Name = "accountLogin1";
			this.accountLogin1.Size = new System.Drawing.Size(525, 425);
			this.accountLogin1.TabIndex = 10;
			// 
			// accountRegistration1
			// 
			this.accountRegistration1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.accountRegistration1.Location = new System.Drawing.Point(275, 25);
			this.accountRegistration1.Name = "accountRegistration1";
			this.accountRegistration1.Size = new System.Drawing.Size(525, 425);
			this.accountRegistration1.TabIndex = 11;
			// 
			// UserStartView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.accountLogin1);
			this.Controls.Add(this.accountRegistration1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UserStartView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserLoginView";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureLogo;
		private System.Windows.Forms.Label labelName;
		private LoginViewLogin accountLogin1;
		private LoginViewRegistration accountRegistration1;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Panel panel3;
	}
}