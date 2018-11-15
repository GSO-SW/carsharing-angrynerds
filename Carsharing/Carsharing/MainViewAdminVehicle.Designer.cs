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
			this.labelTitle = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.numberPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(3, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(71, 13);
			this.labelTitle.TabIndex = 1;
			this.labelTitle.Text = "AdminVehicle";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberPlate,
            this.brand,
            this.model,
            this.available});
			this.dataGridView1.Location = new System.Drawing.Point(3, 49);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(443, 523);
			this.dataGridView1.TabIndex = 2;
			// 
			// numberPlate
			// 
			this.numberPlate.HeaderText = "Nummernschild";
			this.numberPlate.Name = "numberPlate";
			this.numberPlate.ReadOnly = true;
			// 
			// brand
			// 
			this.brand.HeaderText = "Marke";
			this.brand.Name = "brand";
			this.brand.ReadOnly = true;
			// 
			// model
			// 
			this.model.HeaderText = "Modell";
			this.model.Name = "model";
			this.model.ReadOnly = true;
			// 
			// available
			// 
			this.available.HeaderText = "Verfügbarkeit";
			this.available.Name = "available";
			this.available.ReadOnly = true;
			// 
			// MainViewAdminVehicle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.labelTitle);
			this.Name = "MainViewAdminVehicle";
			this.Size = new System.Drawing.Size(900, 575);
			this.Load += new System.EventHandler(this.AdminVehicles_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberPlate;
		private System.Windows.Forms.DataGridViewTextBoxColumn brand;
		private System.Windows.Forms.DataGridViewTextBoxColumn model;
		private System.Windows.Forms.DataGridViewCheckBoxColumn available;
	}
}
