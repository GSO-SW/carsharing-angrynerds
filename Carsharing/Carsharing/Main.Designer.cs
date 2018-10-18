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
            this.userDeleteButton = new System.Windows.Forms.Button();
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
            // userDeleteButton
            // 
            this.userDeleteButton.Location = new System.Drawing.Point(41, 68);
            this.userDeleteButton.Name = "userDeleteButton";
            this.userDeleteButton.Size = new System.Drawing.Size(89, 23);
            this.userDeleteButton.TabIndex = 1;
            this.userDeleteButton.Text = "Delete Account";
            this.userDeleteButton.UseVisualStyleBackColor = true;
            this.userDeleteButton.Click += new System.EventHandler(this.userDeleteButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userDeleteButton);
            this.Controls.Add(this.userRegButton);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button userRegButton;
        private System.Windows.Forms.Button userDeleteButton;
    }
}

