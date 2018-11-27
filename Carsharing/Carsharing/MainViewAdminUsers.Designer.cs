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
			this.SuspendLayout();
			// 
			// buttonUserDelete
			// 
			this.buttonUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonUserDelete.FlatAppearance.BorderSize = 0;
			this.buttonUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUserDelete.Location = new System.Drawing.Point(453, 544);
			this.buttonUserDelete.Name = "buttonUserDelete";
			this.buttonUserDelete.Rounded = 0;
			this.buttonUserDelete.Size = new System.Drawing.Size(144, 28);
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
			this.buttonUserEdit.Location = new System.Drawing.Point(603, 544);
			this.buttonUserEdit.Name = "buttonUserEdit";
			this.buttonUserEdit.Rounded = 0;
			this.buttonUserEdit.Size = new System.Drawing.Size(144, 28);
			this.buttonUserEdit.TabIndex = 7;
			this.buttonUserEdit.Text = "Nutzer bearbeiten";
			this.buttonUserEdit.UseVisualStyleBackColor = false;
			this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEdit_Click);
			// 
			// MainViewAdminUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.buttonUserDelete);
			this.Controls.Add(this.buttonUserEdit);
			this.Name = "MainViewAdminUsers";
			this.Size = new System.Drawing.Size(900, 575);
			this.ResumeLayout(false);

		}

		#endregion
		private CustomControl.RoundButton buttonUserDelete;
		private CustomControl.RoundButton buttonUserEdit;
	}
}
