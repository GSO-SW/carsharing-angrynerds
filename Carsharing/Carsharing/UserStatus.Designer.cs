namespace Carsharing
{
	partial class UserStatus
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
			this.labelCustomer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelCustomer
			// 
			this.labelCustomer.AutoSize = true;
			this.labelCustomer.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCustomer.Location = new System.Drawing.Point(900, 0);
			this.labelCustomer.Name = "labelCustomer";
			this.labelCustomer.Size = new System.Drawing.Size(0, 22);
			this.labelCustomer.TabIndex = 0;
			// 
			// UserStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.labelCustomer);
			this.Name = "UserStatus";
			this.Size = new System.Drawing.Size(900, 575);
			this.Load += new System.EventHandler(this.UserStatus_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCustomer;
	}
}
