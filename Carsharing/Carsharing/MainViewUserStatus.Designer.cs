namespace Carsharing
{
	partial class MainViewUserStatus
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonUserEdit = new CustomControl.RoundButton();
			this.buttonUserDelete = new CustomControl.RoundButton();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(3, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(59, 13);
			this.labelTitle.TabIndex = 1;
			this.labelTitle.Text = "UserStatus";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(208, 182);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// buttonUserEdit
			// 
			this.buttonUserEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonUserEdit.FlatAppearance.BorderSize = 0;
			this.buttonUserEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUserEdit.Location = new System.Drawing.Point(775, 3);
			this.buttonUserEdit.Name = "buttonUserEdit";
			this.buttonUserEdit.Rounded = 0;
			this.buttonUserEdit.Size = new System.Drawing.Size(122, 28);
			this.buttonUserEdit.TabIndex = 5;
			this.buttonUserEdit.Text = "Profil bearbeiten";
			this.buttonUserEdit.UseVisualStyleBackColor = false;
			this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEdit_Click);
			// 
			// buttonUserDelete
			// 
			this.buttonUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonUserDelete.FlatAppearance.BorderSize = 0;
			this.buttonUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUserDelete.Location = new System.Drawing.Point(775, 37);
			this.buttonUserDelete.Name = "buttonUserDelete";
			this.buttonUserDelete.Rounded = 0;
			this.buttonUserDelete.Size = new System.Drawing.Size(122, 28);
			this.buttonUserDelete.TabIndex = 6;
			this.buttonUserDelete.Text = "Profil löschen";
			this.buttonUserDelete.UseVisualStyleBackColor = false;
			this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
			// 
			// MainViewUserStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.buttonUserDelete);
			this.Controls.Add(this.buttonUserEdit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelTitle);
			this.Name = "MainViewUserStatus";
			this.Size = new System.Drawing.Size(900, 575);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label label1;
		private CustomControl.RoundButton buttonUserEdit;
		private CustomControl.RoundButton buttonUserDelete;
	}
}
