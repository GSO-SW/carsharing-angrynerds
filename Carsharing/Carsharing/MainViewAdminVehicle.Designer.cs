namespace Carsharing
{
	partial class MainViewAdminVehicle
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
			this.buttonVehicleDelete = new CustomControl.RoundButton();
			this.buttonVehicleEdit = new CustomControl.RoundButton();
			this.buttonVehicleAdd = new CustomControl.RoundButton();
			this.listVehicle = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// buttonVehicleDelete
			// 
			this.buttonVehicleDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonVehicleDelete.FlatAppearance.BorderSize = 0;
			this.buttonVehicleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonVehicleDelete.Location = new System.Drawing.Point(453, 544);
			this.buttonVehicleDelete.Name = "buttonVehicleDelete";
			this.buttonVehicleDelete.Rounded = 0;
			this.buttonVehicleDelete.Size = new System.Drawing.Size(144, 28);
			this.buttonVehicleDelete.TabIndex = 5;
			this.buttonVehicleDelete.Text = "Fahrzeug löschen";
			this.buttonVehicleDelete.UseVisualStyleBackColor = false;
			// 
			// buttonVehicleEdit
			// 
			this.buttonVehicleEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonVehicleEdit.FlatAppearance.BorderSize = 0;
			this.buttonVehicleEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonVehicleEdit.Location = new System.Drawing.Point(603, 544);
			this.buttonVehicleEdit.Name = "buttonVehicleEdit";
			this.buttonVehicleEdit.Rounded = 0;
			this.buttonVehicleEdit.Size = new System.Drawing.Size(144, 28);
			this.buttonVehicleEdit.TabIndex = 4;
			this.buttonVehicleEdit.Text = "Fahrzeug bearbeiten";
			this.buttonVehicleEdit.UseVisualStyleBackColor = false;
			// 
			// buttonVehicleAdd
			// 
			this.buttonVehicleAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonVehicleAdd.FlatAppearance.BorderSize = 0;
			this.buttonVehicleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonVehicleAdd.Location = new System.Drawing.Point(753, 544);
			this.buttonVehicleAdd.Name = "buttonVehicleAdd";
			this.buttonVehicleAdd.Rounded = 0;
			this.buttonVehicleAdd.Size = new System.Drawing.Size(144, 28);
			this.buttonVehicleAdd.TabIndex = 3;
			this.buttonVehicleAdd.Text = "Fahrzeug hinzufügen";
			this.buttonVehicleAdd.UseVisualStyleBackColor = false;
			this.buttonVehicleAdd.Click += new System.EventHandler(this.buttonAddVehicle_Click);
			// 
			// listVehicle
			// 
			this.listVehicle.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.listVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listVehicle.FormattingEnabled = true;
			this.listVehicle.Location = new System.Drawing.Point(0, 0);
			this.listVehicle.Name = "listVehicle";
			this.listVehicle.Size = new System.Drawing.Size(216, 520);
			this.listVehicle.TabIndex = 7;
			// 
			// MainViewAdminVehicle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.listVehicle);
			this.Controls.Add(this.buttonVehicleDelete);
			this.Controls.Add(this.buttonVehicleEdit);
			this.Controls.Add(this.buttonVehicleAdd);
			this.Name = "MainViewAdminVehicle";
			this.Size = new System.Drawing.Size(900, 575);
			this.Load += new System.EventHandler(this.AdminVehicles_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private CustomControl.RoundButton buttonVehicleAdd;
		private CustomControl.RoundButton buttonVehicleEdit;
		private CustomControl.RoundButton buttonVehicleDelete;
		private System.Windows.Forms.ListBox listVehicle;
	}
}
