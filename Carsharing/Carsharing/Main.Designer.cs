namespace Carsharing
{
	partial class Main
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

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.userRegButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.userDeleteButton = new System.Windows.Forms.Button();
			this.editCustomerButton = new System.Windows.Forms.Button();
			this.buttonAddVehicle = new System.Windows.Forms.Button();
			this.roundedButton1 = new CustomControl.RoundedButton();
			this.roundButton1 = new CustomControl.RoundButton();
			this.SuspendLayout();
			// 
			// userRegButton
			// 
			this.userRegButton.Location = new System.Drawing.Point(41, 39);
			this.userRegButton.Name = "userRegButton";
			this.userRegButton.Size = new System.Drawing.Size(75, 23);
			this.userRegButton.TabIndex = 0;
			this.userRegButton.Text = "Registrieren";
			this.userRegButton.UseVisualStyleBackColor = true;
			this.userRegButton.Click += new System.EventHandler(this.userRegButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(152, 39);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 1;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// userDeleteButton
			// 
			this.userDeleteButton.Location = new System.Drawing.Point(41, 68);
			this.userDeleteButton.Name = "userDeleteButton";
			this.userDeleteButton.Size = new System.Drawing.Size(89, 23);
			this.userDeleteButton.TabIndex = 2;
			this.userDeleteButton.Text = "Delete Account";
			this.userDeleteButton.UseVisualStyleBackColor = true;
			this.userDeleteButton.Click += new System.EventHandler(this.userDeleteButton_Click);
			// 
			// editCustomerButton
			// 
			this.editCustomerButton.Location = new System.Drawing.Point(152, 68);
			this.editCustomerButton.Name = "editCustomerButton";
			this.editCustomerButton.Size = new System.Drawing.Size(89, 23);
			this.editCustomerButton.TabIndex = 3;
			this.editCustomerButton.Text = "Edit Account";
			this.editCustomerButton.UseVisualStyleBackColor = true;
			this.editCustomerButton.Click += new System.EventHandler(this.editCustomerButton_Click);
			// 
			// buttonAddVehicle
			// 
			this.buttonAddVehicle.Location = new System.Drawing.Point(397, 39);
			this.buttonAddVehicle.Name = "buttonAddVehicle";
			this.buttonAddVehicle.Size = new System.Drawing.Size(138, 23);
			this.buttonAddVehicle.TabIndex = 0;
			this.buttonAddVehicle.Text = "Fahrzeug hinzufügen";
			this.buttonAddVehicle.UseVisualStyleBackColor = true;
			this.buttonAddVehicle.Click += new System.EventHandler(this.button1_Click);
			// 
			// roundedButton1
			// 
			this.roundedButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.roundedButton1.FlatAppearance.BorderSize = 0;
			this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.roundedButton1.Location = new System.Drawing.Point(198, 168);
			this.roundedButton1.Name = "roundedButton1";
			this.roundedButton1.Rounded = 0;
			this.roundedButton1.Size = new System.Drawing.Size(367, 29);
			this.roundedButton1.TabIndex = 4;
			this.roundedButton1.Text = "roundedButton1";
			this.roundedButton1.UseVisualStyleBackColor = false;
			// 
			// roundButton1
			// 
			this.roundButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.roundButton1.FlatAppearance.BorderSize = 0;
			this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.roundButton1.Location = new System.Drawing.Point(198, 223);
			this.roundButton1.Name = "roundButton1";
			this.roundButton1.Rounded = 0;
			this.roundButton1.Size = new System.Drawing.Size(367, 32);
			this.roundButton1.TabIndex = 5;
			this.roundButton1.Text = "roundButton1";
			this.roundButton1.UseVisualStyleBackColor = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.roundButton1);
			this.Controls.Add(this.roundedButton1);
			this.Controls.Add(this.editCustomerButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.userRegButton);
			this.Controls.Add(this.userDeleteButton);
			this.Controls.Add(this.buttonAddVehicle);
			this.DoubleBuffered = true;
			this.Name = "Main";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button userRegButton;
        private System.Windows.Forms.Button userDeleteButton;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button editCustomerButton;
		private System.Windows.Forms.Button buttonAddVehicle;
		private CustomControl.RoundedButton roundedButton1;
		private CustomControl.RoundButton roundButton1;
	}
}

