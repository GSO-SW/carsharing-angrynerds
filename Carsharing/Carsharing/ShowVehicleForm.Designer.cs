namespace Carsharing
{
	partial class ShowVehicleForm
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
			this.vehicleListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.maxTankFillingLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.brandLabel = new System.Windows.Forms.Label();
			this.modelLabel = new System.Windows.Forms.Label();
			this.mileageLabel = new System.Windows.Forms.Label();
			this.numberPlateLabel = new System.Windows.Forms.Label();
			this.constrYearLabel = new System.Windows.Forms.Label();
			this.regLabel = new System.Windows.Forms.Label();
			this.gearLabel = new System.Windows.Forms.Label();
			this.powerLabel = new System.Windows.Forms.Label();
			this.lastMaintLabel = new System.Windows.Forms.Label();
			this.tankFillingLabel = new System.Windows.Forms.Label();
			this.coordLabel = new System.Windows.Forms.Label();
			this.bookingButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// vehicleListBox
			// 
			this.vehicleListBox.FormattingEnabled = true;
			this.vehicleListBox.Location = new System.Drawing.Point(12, 12);
			this.vehicleListBox.Name = "vehicleListBox";
			this.vehicleListBox.Size = new System.Drawing.Size(193, 420);
			this.vehicleListBox.TabIndex = 0;
			this.vehicleListBox.SelectedIndexChanged += new System.EventHandler(this.vehicleListBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(211, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Marke:";
			// 
			// maxTankFillingLabel
			// 
			this.maxTankFillingLabel.AutoSize = true;
			this.maxTankFillingLabel.Location = new System.Drawing.Point(330, 275);
			this.maxTankFillingLabel.Name = "maxTankFillingLabel";
			this.maxTankFillingLabel.Size = new System.Drawing.Size(10, 13);
			this.maxTankFillingLabel.TabIndex = 2;
			this.maxTankFillingLabel.Text = "-";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(211, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Modell:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(211, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Kilometerstand:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(211, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Kennzeichen:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(211, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Baujahr:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(211, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Erstzulassung:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(211, 171);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Schaltart:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(211, 197);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "Leistung:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(211, 223);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 13);
			this.label9.TabIndex = 12;
			this.label9.Text = "Letzte Wartung:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(211, 249);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(106, 13);
			this.label10.TabIndex = 13;
			this.label10.Text = "aktuelle Tankfüllung:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(211, 275);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(113, 13);
			this.label11.TabIndex = 14;
			this.label11.Text = "Maximale Tankfüllung:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(211, 327);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 13);
			this.label12.TabIndex = 15;
			this.label12.Text = "Koordinaten:";
			// 
			// brandLabel
			// 
			this.brandLabel.AutoSize = true;
			this.brandLabel.Location = new System.Drawing.Point(330, 15);
			this.brandLabel.Name = "brandLabel";
			this.brandLabel.Size = new System.Drawing.Size(10, 13);
			this.brandLabel.TabIndex = 16;
			this.brandLabel.Text = "-";
			// 
			// modelLabel
			// 
			this.modelLabel.AutoSize = true;
			this.modelLabel.Location = new System.Drawing.Point(330, 41);
			this.modelLabel.Name = "modelLabel";
			this.modelLabel.Size = new System.Drawing.Size(10, 13);
			this.modelLabel.TabIndex = 17;
			this.modelLabel.Text = "-";
			// 
			// mileageLabel
			// 
			this.mileageLabel.AutoSize = true;
			this.mileageLabel.Location = new System.Drawing.Point(330, 67);
			this.mileageLabel.Name = "mileageLabel";
			this.mileageLabel.Size = new System.Drawing.Size(10, 13);
			this.mileageLabel.TabIndex = 18;
			this.mileageLabel.Text = "-";
			// 
			// numberPlateLabel
			// 
			this.numberPlateLabel.AutoSize = true;
			this.numberPlateLabel.Location = new System.Drawing.Point(330, 93);
			this.numberPlateLabel.Name = "numberPlateLabel";
			this.numberPlateLabel.Size = new System.Drawing.Size(10, 13);
			this.numberPlateLabel.TabIndex = 19;
			this.numberPlateLabel.Text = "-";
			// 
			// constrYearLabel
			// 
			this.constrYearLabel.AutoSize = true;
			this.constrYearLabel.Location = new System.Drawing.Point(330, 119);
			this.constrYearLabel.Name = "constrYearLabel";
			this.constrYearLabel.Size = new System.Drawing.Size(10, 13);
			this.constrYearLabel.TabIndex = 20;
			this.constrYearLabel.Text = "-";
			// 
			// regLabel
			// 
			this.regLabel.AutoSize = true;
			this.regLabel.Location = new System.Drawing.Point(330, 145);
			this.regLabel.Name = "regLabel";
			this.regLabel.Size = new System.Drawing.Size(10, 13);
			this.regLabel.TabIndex = 21;
			this.regLabel.Text = "-";
			// 
			// gearLabel
			// 
			this.gearLabel.AutoSize = true;
			this.gearLabel.Location = new System.Drawing.Point(330, 171);
			this.gearLabel.Name = "gearLabel";
			this.gearLabel.Size = new System.Drawing.Size(10, 13);
			this.gearLabel.TabIndex = 22;
			this.gearLabel.Text = "-";
			// 
			// powerLabel
			// 
			this.powerLabel.AutoSize = true;
			this.powerLabel.Location = new System.Drawing.Point(330, 197);
			this.powerLabel.Name = "powerLabel";
			this.powerLabel.Size = new System.Drawing.Size(10, 13);
			this.powerLabel.TabIndex = 23;
			this.powerLabel.Text = "-";
			// 
			// lastMaintLabel
			// 
			this.lastMaintLabel.AutoSize = true;
			this.lastMaintLabel.Location = new System.Drawing.Point(330, 223);
			this.lastMaintLabel.Name = "lastMaintLabel";
			this.lastMaintLabel.Size = new System.Drawing.Size(10, 13);
			this.lastMaintLabel.TabIndex = 24;
			this.lastMaintLabel.Text = "-";
			// 
			// tankFillingLabel
			// 
			this.tankFillingLabel.AutoSize = true;
			this.tankFillingLabel.Location = new System.Drawing.Point(330, 249);
			this.tankFillingLabel.Name = "tankFillingLabel";
			this.tankFillingLabel.Size = new System.Drawing.Size(10, 13);
			this.tankFillingLabel.TabIndex = 25;
			this.tankFillingLabel.Text = "-";
			// 
			// coordLabel
			// 
			this.coordLabel.AutoSize = true;
			this.coordLabel.Location = new System.Drawing.Point(330, 327);
			this.coordLabel.Name = "coordLabel";
			this.coordLabel.Size = new System.Drawing.Size(10, 13);
			this.coordLabel.TabIndex = 26;
			this.coordLabel.Text = "-";
			// 
			// bookingButton
			// 
			this.bookingButton.Enabled = false;
			this.bookingButton.Location = new System.Drawing.Point(397, 396);
			this.bookingButton.Name = "bookingButton";
			this.bookingButton.Size = new System.Drawing.Size(75, 23);
			this.bookingButton.TabIndex = 27;
			this.bookingButton.Text = "Buchen";
			this.bookingButton.UseVisualStyleBackColor = true;
			// 
			// ShowVehicleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bookingButton);
			this.Controls.Add(this.coordLabel);
			this.Controls.Add(this.tankFillingLabel);
			this.Controls.Add(this.lastMaintLabel);
			this.Controls.Add(this.powerLabel);
			this.Controls.Add(this.gearLabel);
			this.Controls.Add(this.regLabel);
			this.Controls.Add(this.constrYearLabel);
			this.Controls.Add(this.numberPlateLabel);
			this.Controls.Add(this.mileageLabel);
			this.Controls.Add(this.modelLabel);
			this.Controls.Add(this.brandLabel);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.maxTankFillingLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.vehicleListBox);
			this.Name = "ShowVehicleForm";
			this.Text = "CreateBookingForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox vehicleListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label maxTankFillingLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label brandLabel;
		private System.Windows.Forms.Label modelLabel;
		private System.Windows.Forms.Label mileageLabel;
		private System.Windows.Forms.Label numberPlateLabel;
		private System.Windows.Forms.Label constrYearLabel;
		private System.Windows.Forms.Label regLabel;
		private System.Windows.Forms.Label gearLabel;
		private System.Windows.Forms.Label powerLabel;
		private System.Windows.Forms.Label lastMaintLabel;
		private System.Windows.Forms.Label tankFillingLabel;
		private System.Windows.Forms.Label coordLabel;
		private System.Windows.Forms.Button bookingButton;
	}
}