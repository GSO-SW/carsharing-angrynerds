namespace Carsharing
{
	partial class AddVehicleForm
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
			this.labelNumberPlate = new System.Windows.Forms.Label();
			this.textNumberPlate = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textMileage = new System.Windows.Forms.TextBox();
			this.labelMileage = new System.Windows.Forms.Label();
			this.labelLastMaintenance = new System.Windows.Forms.Label();
			this.labelTankFilling = new System.Windows.Forms.Label();
			this.textPosition = new System.Windows.Forms.TextBox();
			this.labelPosition = new System.Windows.Forms.Label();
			this.labelAvailable = new System.Windows.Forms.Label();
			this.textBrand = new System.Windows.Forms.TextBox();
			this.labelBrand = new System.Windows.Forms.Label();
			this.textModel = new System.Windows.Forms.TextBox();
			this.labelModel = new System.Windows.Forms.Label();
			this.textPower = new System.Windows.Forms.TextBox();
			this.labelPower = new System.Windows.Forms.Label();
			this.labelConstructionYear = new System.Windows.Forms.Label();
			this.textGearShift = new System.Windows.Forms.TextBox();
			this.labelGearShift = new System.Windows.Forms.Label();
			this.labelMaxTankFilling = new System.Windows.Forms.Label();
			this.labelBasicPrice = new System.Windows.Forms.Label();
			this.labelPriceKilometre = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonAbort = new System.Windows.Forms.Button();
			this.dateTimeLastMaintenance = new System.Windows.Forms.DateTimePicker();
			this.checkAvailable = new System.Windows.Forms.CheckBox();
			this.dateTimeConstructionYear = new System.Windows.Forms.DateTimePicker();
			this.labelTitle = new System.Windows.Forms.Label();
			this.textMileage2 = new System.Windows.Forms.TextBox();
			this.labelPoint1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textMaxTankFilling2 = new System.Windows.Forms.TextBox();
			this.textMaxTankFilling = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBasicPrice2 = new System.Windows.Forms.TextBox();
			this.textBasicPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textPricePerKilometre2 = new System.Windows.Forms.TextBox();
			this.textPricePerKilometre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textPricePerMinute2 = new System.Windows.Forms.TextBox();
			this.textPricePerMinute = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textTankFilling2 = new System.Windows.Forms.TextBox();
			this.textTankFilling = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelNumberPlate
			// 
			this.labelNumberPlate.AutoSize = true;
			this.labelNumberPlate.Location = new System.Drawing.Point(28, 75);
			this.labelNumberPlate.Name = "labelNumberPlate";
			this.labelNumberPlate.Size = new System.Drawing.Size(70, 13);
			this.labelNumberPlate.TabIndex = 0;
			this.labelNumberPlate.Text = "Number plate";
			// 
			// textNumberPlate
			// 
			this.textNumberPlate.Location = new System.Drawing.Point(139, 75);
			this.textNumberPlate.Name = "textNumberPlate";
			this.textNumberPlate.Size = new System.Drawing.Size(100, 20);
			this.textNumberPlate.TabIndex = 1;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(437, 74);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// textMileage
			// 
			this.textMileage.Location = new System.Drawing.Point(139, 101);
			this.textMileage.Name = "textMileage";
			this.textMileage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textMileage.Size = new System.Drawing.Size(59, 20);
			this.textMileage.TabIndex = 4;
			this.textMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber);
			// 
			// labelMileage
			// 
			this.labelMileage.AutoSize = true;
			this.labelMileage.Location = new System.Drawing.Point(28, 101);
			this.labelMileage.Name = "labelMileage";
			this.labelMileage.Size = new System.Drawing.Size(44, 13);
			this.labelMileage.TabIndex = 3;
			this.labelMileage.Text = "Mileage";
			// 
			// labelLastMaintenance
			// 
			this.labelLastMaintenance.AutoSize = true;
			this.labelLastMaintenance.Location = new System.Drawing.Point(28, 127);
			this.labelLastMaintenance.Name = "labelLastMaintenance";
			this.labelLastMaintenance.Size = new System.Drawing.Size(91, 13);
			this.labelLastMaintenance.TabIndex = 5;
			this.labelLastMaintenance.Text = "Last maintenance";
			// 
			// labelTankFilling
			// 
			this.labelTankFilling.AutoSize = true;
			this.labelTankFilling.Location = new System.Drawing.Point(28, 153);
			this.labelTankFilling.Name = "labelTankFilling";
			this.labelTankFilling.Size = new System.Drawing.Size(58, 13);
			this.labelTankFilling.TabIndex = 7;
			this.labelTankFilling.Text = "Tank filling";
			// 
			// textPosition
			// 
			this.textPosition.Location = new System.Drawing.Point(139, 179);
			this.textPosition.Name = "textPosition";
			this.textPosition.Size = new System.Drawing.Size(100, 20);
			this.textPosition.TabIndex = 10;
			// 
			// labelPosition
			// 
			this.labelPosition.AutoSize = true;
			this.labelPosition.Location = new System.Drawing.Point(28, 179);
			this.labelPosition.Name = "labelPosition";
			this.labelPosition.Size = new System.Drawing.Size(44, 13);
			this.labelPosition.TabIndex = 9;
			this.labelPosition.Text = "Position";
			// 
			// labelAvailable
			// 
			this.labelAvailable.AutoSize = true;
			this.labelAvailable.Location = new System.Drawing.Point(28, 205);
			this.labelAvailable.Name = "labelAvailable";
			this.labelAvailable.Size = new System.Drawing.Size(50, 13);
			this.labelAvailable.TabIndex = 11;
			this.labelAvailable.Text = "Available";
			// 
			// textBrand
			// 
			this.textBrand.Location = new System.Drawing.Point(139, 231);
			this.textBrand.Name = "textBrand";
			this.textBrand.Size = new System.Drawing.Size(100, 20);
			this.textBrand.TabIndex = 14;
			// 
			// labelBrand
			// 
			this.labelBrand.AutoSize = true;
			this.labelBrand.Location = new System.Drawing.Point(28, 231);
			this.labelBrand.Name = "labelBrand";
			this.labelBrand.Size = new System.Drawing.Size(35, 13);
			this.labelBrand.TabIndex = 13;
			this.labelBrand.Text = "Brand";
			// 
			// textModel
			// 
			this.textModel.Location = new System.Drawing.Point(139, 257);
			this.textModel.Name = "textModel";
			this.textModel.Size = new System.Drawing.Size(100, 20);
			this.textModel.TabIndex = 16;
			// 
			// labelModel
			// 
			this.labelModel.AutoSize = true;
			this.labelModel.Location = new System.Drawing.Point(28, 257);
			this.labelModel.Name = "labelModel";
			this.labelModel.Size = new System.Drawing.Size(36, 13);
			this.labelModel.TabIndex = 15;
			this.labelModel.Text = "Model";
			// 
			// textPower
			// 
			this.textPower.Location = new System.Drawing.Point(139, 283);
			this.textPower.Name = "textPower";
			this.textPower.Size = new System.Drawing.Size(100, 20);
			this.textPower.TabIndex = 18;
			this.textPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber);
			// 
			// labelPower
			// 
			this.labelPower.AutoSize = true;
			this.labelPower.Location = new System.Drawing.Point(28, 283);
			this.labelPower.Name = "labelPower";
			this.labelPower.Size = new System.Drawing.Size(37, 13);
			this.labelPower.TabIndex = 17;
			this.labelPower.Text = "Power";
			// 
			// labelConstructionYear
			// 
			this.labelConstructionYear.AutoSize = true;
			this.labelConstructionYear.Location = new System.Drawing.Point(28, 309);
			this.labelConstructionYear.Name = "labelConstructionYear";
			this.labelConstructionYear.Size = new System.Drawing.Size(89, 13);
			this.labelConstructionYear.TabIndex = 19;
			this.labelConstructionYear.Text = "Construction year";
			// 
			// textGearShift
			// 
			this.textGearShift.Location = new System.Drawing.Point(139, 335);
			this.textGearShift.Name = "textGearShift";
			this.textGearShift.Size = new System.Drawing.Size(100, 20);
			this.textGearShift.TabIndex = 22;
			// 
			// labelGearShift
			// 
			this.labelGearShift.AutoSize = true;
			this.labelGearShift.Location = new System.Drawing.Point(28, 335);
			this.labelGearShift.Name = "labelGearShift";
			this.labelGearShift.Size = new System.Drawing.Size(52, 13);
			this.labelGearShift.TabIndex = 21;
			this.labelGearShift.Text = "Gear shift";
			// 
			// labelMaxTankFilling
			// 
			this.labelMaxTankFilling.AutoSize = true;
			this.labelMaxTankFilling.Location = new System.Drawing.Point(28, 361);
			this.labelMaxTankFilling.Name = "labelMaxTankFilling";
			this.labelMaxTankFilling.Size = new System.Drawing.Size(77, 13);
			this.labelMaxTankFilling.TabIndex = 23;
			this.labelMaxTankFilling.Text = "Max tank filling";
			// 
			// labelBasicPrice
			// 
			this.labelBasicPrice.AutoSize = true;
			this.labelBasicPrice.Location = new System.Drawing.Point(28, 387);
			this.labelBasicPrice.Name = "labelBasicPrice";
			this.labelBasicPrice.Size = new System.Drawing.Size(59, 13);
			this.labelBasicPrice.TabIndex = 25;
			this.labelBasicPrice.Text = "Basic price";
			// 
			// labelPriceKilometre
			// 
			this.labelPriceKilometre.AutoSize = true;
			this.labelPriceKilometre.Location = new System.Drawing.Point(28, 413);
			this.labelPriceKilometre.Name = "labelPriceKilometre";
			this.labelPriceKilometre.Size = new System.Drawing.Size(84, 13);
			this.labelPriceKilometre.TabIndex = 27;
			this.labelPriceKilometre.Text = "Price / kilometre";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(28, 439);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(73, 13);
			this.label15.TabIndex = 29;
			this.label15.Text = "Price / minute";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(497, 826);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 31;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonAbort
			// 
			this.buttonAbort.Location = new System.Drawing.Point(416, 826);
			this.buttonAbort.Name = "buttonAbort";
			this.buttonAbort.Size = new System.Drawing.Size(75, 23);
			this.buttonAbort.TabIndex = 32;
			this.buttonAbort.Text = "Abort";
			this.buttonAbort.UseVisualStyleBackColor = true;
			this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
			// 
			// dateTimeLastMaintenance
			// 
			this.dateTimeLastMaintenance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeLastMaintenance.Location = new System.Drawing.Point(139, 127);
			this.dateTimeLastMaintenance.Name = "dateTimeLastMaintenance";
			this.dateTimeLastMaintenance.Size = new System.Drawing.Size(100, 20);
			this.dateTimeLastMaintenance.TabIndex = 33;
			// 
			// checkAvailable
			// 
			this.checkAvailable.AutoSize = true;
			this.checkAvailable.Location = new System.Drawing.Point(224, 208);
			this.checkAvailable.Name = "checkAvailable";
			this.checkAvailable.Size = new System.Drawing.Size(15, 14);
			this.checkAvailable.TabIndex = 34;
			this.checkAvailable.UseVisualStyleBackColor = true;
			// 
			// dateTimeConstructionYear
			// 
			this.dateTimeConstructionYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimeConstructionYear.Location = new System.Drawing.Point(139, 309);
			this.dateTimeConstructionYear.Name = "dateTimeConstructionYear";
			this.dateTimeConstructionYear.ShowUpDown = true;
			this.dateTimeConstructionYear.Size = new System.Drawing.Size(100, 20);
			this.dateTimeConstructionYear.TabIndex = 35;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(31, 24);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(90, 20);
			this.labelTitle.TabIndex = 36;
			this.labelTitle.Text = "Add vehicle";
			// 
			// textMileage2
			// 
			this.textMileage2.Location = new System.Drawing.Point(217, 101);
			this.textMileage2.Name = "textMileage2";
			this.textMileage2.Size = new System.Drawing.Size(22, 20);
			this.textMileage2.TabIndex = 37;
			this.textMileage2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber2);
			// 
			// labelPoint1
			// 
			this.labelPoint1.AutoSize = true;
			this.labelPoint1.Location = new System.Drawing.Point(201, 104);
			this.labelPoint1.Name = "labelPoint1";
			this.labelPoint1.Size = new System.Drawing.Size(10, 13);
			this.labelPoint1.TabIndex = 38;
			this.labelPoint1.Text = ".";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(201, 364);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 13);
			this.label1.TabIndex = 41;
			this.label1.Text = ".";
			// 
			// textMaxTankFilling2
			// 
			this.textMaxTankFilling2.Location = new System.Drawing.Point(217, 361);
			this.textMaxTankFilling2.Name = "textMaxTankFilling2";
			this.textMaxTankFilling2.Size = new System.Drawing.Size(22, 20);
			this.textMaxTankFilling2.TabIndex = 40;
			this.textMaxTankFilling2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber2);
			// 
			// textMaxTankFilling
			// 
			this.textMaxTankFilling.Location = new System.Drawing.Point(139, 361);
			this.textMaxTankFilling.Name = "textMaxTankFilling";
			this.textMaxTankFilling.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textMaxTankFilling.Size = new System.Drawing.Size(59, 20);
			this.textMaxTankFilling.TabIndex = 39;
			this.textMaxTankFilling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(201, 390);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(10, 13);
			this.label2.TabIndex = 44;
			this.label2.Text = ".";
			// 
			// textBasicPrice2
			// 
			this.textBasicPrice2.Location = new System.Drawing.Point(217, 387);
			this.textBasicPrice2.Name = "textBasicPrice2";
			this.textBasicPrice2.Size = new System.Drawing.Size(22, 20);
			this.textBasicPrice2.TabIndex = 43;
			this.textBasicPrice2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber2);
			// 
			// textBasicPrice
			// 
			this.textBasicPrice.Location = new System.Drawing.Point(139, 387);
			this.textBasicPrice.Name = "textBasicPrice";
			this.textBasicPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBasicPrice.Size = new System.Drawing.Size(59, 20);
			this.textBasicPrice.TabIndex = 42;
			this.textBasicPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(201, 416);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(10, 13);
			this.label3.TabIndex = 47;
			this.label3.Text = ".";
			// 
			// textPricePerKilometre2
			// 
			this.textPricePerKilometre2.Location = new System.Drawing.Point(217, 413);
			this.textPricePerKilometre2.Name = "textPricePerKilometre2";
			this.textPricePerKilometre2.Size = new System.Drawing.Size(22, 20);
			this.textPricePerKilometre2.TabIndex = 46;
			this.textPricePerKilometre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber2);
			// 
			// textPricePerKilometre
			// 
			this.textPricePerKilometre.Location = new System.Drawing.Point(139, 413);
			this.textPricePerKilometre.Name = "textPricePerKilometre";
			this.textPricePerKilometre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textPricePerKilometre.Size = new System.Drawing.Size(59, 20);
			this.textPricePerKilometre.TabIndex = 45;
			this.textPricePerKilometre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(201, 442);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 13);
			this.label4.TabIndex = 50;
			this.label4.Text = ".";
			// 
			// textPricePerMinute2
			// 
			this.textPricePerMinute2.Location = new System.Drawing.Point(217, 439);
			this.textPricePerMinute2.Name = "textPricePerMinute2";
			this.textPricePerMinute2.Size = new System.Drawing.Size(22, 20);
			this.textPricePerMinute2.TabIndex = 49;
			this.textPricePerMinute2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber2);
			// 
			// textPricePerMinute
			// 
			this.textPricePerMinute.Location = new System.Drawing.Point(139, 439);
			this.textPricePerMinute.Name = "textPricePerMinute";
			this.textPricePerMinute.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textPricePerMinute.Size = new System.Drawing.Size(59, 20);
			this.textPricePerMinute.TabIndex = 48;
			this.textPricePerMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(201, 156);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(10, 13);
			this.label5.TabIndex = 53;
			this.label5.Text = ".";
			// 
			// textTankFilling2
			// 
			this.textTankFilling2.Location = new System.Drawing.Point(217, 153);
			this.textTankFilling2.Name = "textTankFilling2";
			this.textTankFilling2.Size = new System.Drawing.Size(22, 20);
			this.textTankFilling2.TabIndex = 52;
			this.textTankFilling2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber2);
			// 
			// textTankFilling
			// 
			this.textTankFilling.Location = new System.Drawing.Point(139, 153);
			this.textTankFilling.Name = "textTankFilling";
			this.textTankFilling.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textTankFilling.Size = new System.Drawing.Size(59, 20);
			this.textTankFilling.TabIndex = 51;
			this.textTankFilling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnlyNumber);
			// 
			// AddVehicleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 861);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textTankFilling2);
			this.Controls.Add(this.textTankFilling);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textPricePerMinute2);
			this.Controls.Add(this.textPricePerMinute);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textPricePerKilometre2);
			this.Controls.Add(this.textPricePerKilometre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBasicPrice2);
			this.Controls.Add(this.textBasicPrice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textMaxTankFilling2);
			this.Controls.Add(this.textMaxTankFilling);
			this.Controls.Add(this.labelPoint1);
			this.Controls.Add(this.textMileage2);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.dateTimeConstructionYear);
			this.Controls.Add(this.checkAvailable);
			this.Controls.Add(this.dateTimeLastMaintenance);
			this.Controls.Add(this.buttonAbort);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.labelPriceKilometre);
			this.Controls.Add(this.labelBasicPrice);
			this.Controls.Add(this.labelMaxTankFilling);
			this.Controls.Add(this.textGearShift);
			this.Controls.Add(this.labelGearShift);
			this.Controls.Add(this.labelConstructionYear);
			this.Controls.Add(this.textPower);
			this.Controls.Add(this.labelPower);
			this.Controls.Add(this.textModel);
			this.Controls.Add(this.labelModel);
			this.Controls.Add(this.textBrand);
			this.Controls.Add(this.labelBrand);
			this.Controls.Add(this.labelAvailable);
			this.Controls.Add(this.textPosition);
			this.Controls.Add(this.labelPosition);
			this.Controls.Add(this.labelTankFilling);
			this.Controls.Add(this.labelLastMaintenance);
			this.Controls.Add(this.textMileage);
			this.Controls.Add(this.labelMileage);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textNumberPlate);
			this.Controls.Add(this.labelNumberPlate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AddVehicleForm";
			this.Text = "AddVehicleForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelNumberPlate;
		private System.Windows.Forms.TextBox textNumberPlate;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textMileage;
		private System.Windows.Forms.Label labelMileage;
		private System.Windows.Forms.Label labelLastMaintenance;
		private System.Windows.Forms.Label labelTankFilling;
		private System.Windows.Forms.TextBox textPosition;
		private System.Windows.Forms.Label labelPosition;
		private System.Windows.Forms.Label labelAvailable;
		private System.Windows.Forms.TextBox textBrand;
		private System.Windows.Forms.Label labelBrand;
		private System.Windows.Forms.TextBox textModel;
		private System.Windows.Forms.Label labelModel;
		private System.Windows.Forms.TextBox textPower;
		private System.Windows.Forms.Label labelPower;
		private System.Windows.Forms.Label labelConstructionYear;
		private System.Windows.Forms.TextBox textGearShift;
		private System.Windows.Forms.Label labelGearShift;
		private System.Windows.Forms.Label labelMaxTankFilling;
		private System.Windows.Forms.Label labelBasicPrice;
		private System.Windows.Forms.Label labelPriceKilometre;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonAbort;
		private System.Windows.Forms.DateTimePicker dateTimeLastMaintenance;
		private System.Windows.Forms.CheckBox checkAvailable;
		private System.Windows.Forms.DateTimePicker dateTimeConstructionYear;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.TextBox textMileage2;
		private System.Windows.Forms.Label labelPoint1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textMaxTankFilling2;
		private System.Windows.Forms.TextBox textMaxTankFilling;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBasicPrice2;
		private System.Windows.Forms.TextBox textBasicPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textPricePerKilometre2;
		private System.Windows.Forms.TextBox textPricePerKilometre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textPricePerMinute2;
		private System.Windows.Forms.TextBox textPricePerMinute;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textTankFilling2;
		private System.Windows.Forms.TextBox textTankFilling;
	}
}