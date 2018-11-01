namespace Carsharing
{
	partial class ManageUserForm
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
			this.components = new System.ComponentModel.Container();
			this.customerListBox = new System.Windows.Forms.ListBox();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// customerListBox
			// 
			this.customerListBox.FormattingEnabled = true;
			this.customerListBox.Location = new System.Drawing.Point(12, 12);
			this.customerListBox.Name = "customerListBox";
			this.customerListBox.Size = new System.Drawing.Size(177, 420);
			this.customerListBox.TabIndex = 0;
			this.customerListBox.SelectedIndexChanged += new System.EventHandler(this.customerListBox_SelectedIndexChanged);
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataSource = typeof(Carsharing.Customer);
			// 
			// ManageUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.customerListBox);
			this.Name = "ManageUserForm";
			this.Text = "Kunden verwalten";
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox customerListBox;
		private System.Windows.Forms.BindingSource customerBindingSource;
	}
}