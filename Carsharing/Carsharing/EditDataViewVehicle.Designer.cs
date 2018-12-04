namespace Carsharing
{
	partial class EditDataViewVehicle
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
			this.buttonAccept = new CustomControl.RoundButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.txtPriceMin = new System.Windows.Forms.TextBox();
			this.labelPriceMin = new System.Windows.Forms.Label();
			this.txtPriceKilo = new System.Windows.Forms.TextBox();
			this.labelPriceKilo = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.comboGear = new System.Windows.Forms.ComboBox();
			this.comboFuel = new System.Windows.Forms.ComboBox();
			this.dateTimeLastMaintenance = new System.Windows.Forms.DateTimePicker();
			this.comboBrand = new System.Windows.Forms.ComboBox();
			this.txtSeats = new System.Windows.Forms.TextBox();
			this.txtFuelCon = new System.Windows.Forms.TextBox();
			this.txtPosY = new System.Windows.Forms.TextBox();
			this.txtMaxTankFilling = new System.Windows.Forms.TextBox();
			this.txtPosX = new System.Windows.Forms.TextBox();
			this.txtTankFilling = new System.Windows.Forms.TextBox();
			this.txtNumberplate = new System.Windows.Forms.TextBox();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.txtPower = new System.Windows.Forms.TextBox();
			this.txtReg = new System.Windows.Forms.TextBox();
			this.txtConstructionYear = new System.Windows.Forms.TextBox();
			this.txtMileage = new System.Windows.Forms.TextBox();
			this.labelPosX = new System.Windows.Forms.Label();
			this.labelFuelCon = new System.Windows.Forms.Label();
			this.labelFuel = new System.Windows.Forms.Label();
			this.labelSeats = new System.Windows.Forms.Label();
			this.labelLastMaint = new System.Windows.Forms.Label();
			this.labelPosY = new System.Windows.Forms.Label();
			this.labelTankFilling = new System.Windows.Forms.Label();
			this.labelMaxTankFilling = new System.Windows.Forms.Label();
			this.labelPower = new System.Windows.Forms.Label();
			this.labelGear = new System.Windows.Forms.Label();
			this.labelReg = new System.Windows.Forms.Label();
			this.labelConstructionYear = new System.Windows.Forms.Label();
			this.labelMileage = new System.Windows.Forms.Label();
			this.labelNumberplate = new System.Windows.Forms.Label();
			this.labelModel = new System.Windows.Forms.Label();
			this.labelBrand = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.checkSmoker = new System.Windows.Forms.CheckBox();
			this.label22 = new System.Windows.Forms.Label();
			this.checkWinter = new System.Windows.Forms.CheckBox();
			this.label23 = new System.Windows.Forms.Label();
			this.checkHeatedSeat = new System.Windows.Forms.CheckBox();
			this.label24 = new System.Windows.Forms.Label();
			this.checkESP = new System.Windows.Forms.CheckBox();
			this.label25 = new System.Windows.Forms.Label();
			this.checkABS = new System.Windows.Forms.CheckBox();
			this.label26 = new System.Windows.Forms.Label();
			this.checkNavigationDevice = new System.Windows.Forms.CheckBox();
			this.label27 = new System.Windows.Forms.Label();
			this.checkCDPlayer = new System.Windows.Forms.CheckBox();
			this.label19 = new System.Windows.Forms.Label();
			this.checkUSB = new System.Windows.Forms.CheckBox();
			this.label20 = new System.Windows.Forms.Label();
			this.checkBluetooth = new System.Windows.Forms.CheckBox();
			this.label21 = new System.Windows.Forms.Label();
			this.checkRadio = new System.Windows.Forms.CheckBox();
			this.label18 = new System.Windows.Forms.Label();
			this.checkCruiseControl = new System.Windows.Forms.CheckBox();
			this.label17 = new System.Windows.Forms.Label();
			this.checkAirConditioner = new System.Windows.Forms.CheckBox();
			this.label16 = new System.Windows.Forms.Label();
			this.checkAvailable = new System.Windows.Forms.CheckBox();
			this.labelAvailable = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAccept
			// 
			this.buttonAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonAccept.FlatAppearance.BorderSize = 0;
			this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAccept.Location = new System.Drawing.Point(260, 378);
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.Rounded = 0;
			this.buttonAccept.Size = new System.Drawing.Size(258, 31);
			this.buttonAccept.TabIndex = 50;
			this.buttonAccept.Text = "Fahrzeug";
			this.buttonAccept.UseVisualStyleBackColor = false;
			this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(522, 372);
			this.tabControl1.TabIndex = 43;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tabPage1.Controls.Add(this.txtPriceMin);
			this.tabPage1.Controls.Add(this.labelPriceMin);
			this.tabPage1.Controls.Add(this.txtPriceKilo);
			this.tabPage1.Controls.Add(this.labelPriceKilo);
			this.tabPage1.Controls.Add(this.txtPrice);
			this.tabPage1.Controls.Add(this.labelPrice);
			this.tabPage1.Controls.Add(this.comboGear);
			this.tabPage1.Controls.Add(this.comboFuel);
			this.tabPage1.Controls.Add(this.dateTimeLastMaintenance);
			this.tabPage1.Controls.Add(this.comboBrand);
			this.tabPage1.Controls.Add(this.txtSeats);
			this.tabPage1.Controls.Add(this.txtFuelCon);
			this.tabPage1.Controls.Add(this.txtPosY);
			this.tabPage1.Controls.Add(this.txtMaxTankFilling);
			this.tabPage1.Controls.Add(this.txtPosX);
			this.tabPage1.Controls.Add(this.txtTankFilling);
			this.tabPage1.Controls.Add(this.txtNumberplate);
			this.tabPage1.Controls.Add(this.txtModel);
			this.tabPage1.Controls.Add(this.txtPower);
			this.tabPage1.Controls.Add(this.txtReg);
			this.tabPage1.Controls.Add(this.txtConstructionYear);
			this.tabPage1.Controls.Add(this.txtMileage);
			this.tabPage1.Controls.Add(this.labelPosX);
			this.tabPage1.Controls.Add(this.labelFuelCon);
			this.tabPage1.Controls.Add(this.labelFuel);
			this.tabPage1.Controls.Add(this.labelSeats);
			this.tabPage1.Controls.Add(this.labelLastMaint);
			this.tabPage1.Controls.Add(this.labelPosY);
			this.tabPage1.Controls.Add(this.labelTankFilling);
			this.tabPage1.Controls.Add(this.labelMaxTankFilling);
			this.tabPage1.Controls.Add(this.labelPower);
			this.tabPage1.Controls.Add(this.labelGear);
			this.tabPage1.Controls.Add(this.labelReg);
			this.tabPage1.Controls.Add(this.labelConstructionYear);
			this.tabPage1.Controls.Add(this.labelMileage);
			this.tabPage1.Controls.Add(this.labelNumberplate);
			this.tabPage1.Controls.Add(this.labelModel);
			this.tabPage1.Controls.Add(this.labelBrand);
			this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(514, 343);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Allgemeine Fahrzeuginformationen";
			// 
			// txtPriceMin
			// 
			this.txtPriceMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPriceMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtPriceMin.Location = new System.Drawing.Point(348, 317);
			this.txtPriceMin.Name = "txtPriceMin";
			this.txtPriceMin.Size = new System.Drawing.Size(140, 15);
			this.txtPriceMin.TabIndex = 45;
			// 
			// labelPriceMin
			// 
			this.labelPriceMin.AutoSize = true;
			this.labelPriceMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPriceMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPriceMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPriceMin.Location = new System.Drawing.Point(344, 299);
			this.labelPriceMin.Name = "labelPriceMin";
			this.labelPriceMin.Size = new System.Drawing.Size(64, 15);
			this.labelPriceMin.TabIndex = 46;
			this.labelPriceMin.Text = "Preis / min";
			// 
			// txtPriceKilo
			// 
			this.txtPriceKilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtPriceKilo.Location = new System.Drawing.Point(182, 317);
			this.txtPriceKilo.Name = "txtPriceKilo";
			this.txtPriceKilo.Size = new System.Drawing.Size(140, 15);
			this.txtPriceKilo.TabIndex = 43;
			// 
			// labelPriceKilo
			// 
			this.labelPriceKilo.AutoSize = true;
			this.labelPriceKilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPriceKilo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPriceKilo.Location = new System.Drawing.Point(178, 299);
			this.labelPriceKilo.Name = "labelPriceKilo";
			this.labelPriceKilo.Size = new System.Drawing.Size(60, 15);
			this.labelPriceKilo.TabIndex = 44;
			this.labelPriceKilo.Text = "Preis / km";
			// 
			// txtPrice
			// 
			this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtPrice.Location = new System.Drawing.Point(20, 317);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(140, 15);
			this.txtPrice.TabIndex = 41;
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPrice.Location = new System.Drawing.Point(16, 299);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(32, 15);
			this.labelPrice.TabIndex = 42;
			this.labelPrice.Text = "Preis";
			// 
			// comboGear
			// 
			this.comboGear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboGear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.comboGear.FormattingEnabled = true;
			this.comboGear.Location = new System.Drawing.Point(19, 242);
			this.comboGear.Name = "comboGear";
			this.comboGear.Size = new System.Drawing.Size(210, 21);
			this.comboGear.TabIndex = 7;
			// 
			// comboFuel
			// 
			this.comboFuel.BackColor = System.Drawing.SystemColors.Window;
			this.comboFuel.CausesValidation = false;
			this.comboFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.comboFuel.FormattingEnabled = true;
			this.comboFuel.Location = new System.Drawing.Point(275, 242);
			this.comboFuel.Name = "comboFuel";
			this.comboFuel.Size = new System.Drawing.Size(210, 21);
			this.comboFuel.TabIndex = 15;
			// 
			// dateTimeLastMaintenance
			// 
			this.dateTimeLastMaintenance.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimeLastMaintenance.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.dateTimeLastMaintenance.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.dateTimeLastMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimeLastMaintenance.Location = new System.Drawing.Point(275, 171);
			this.dateTimeLastMaintenance.Name = "dateTimeLastMaintenance";
			this.dateTimeLastMaintenance.Size = new System.Drawing.Size(210, 20);
			this.dateTimeLastMaintenance.TabIndex = 13;
			// 
			// comboBrand
			// 
			this.comboBrand.BackColor = System.Drawing.SystemColors.Window;
			this.comboBrand.CausesValidation = false;
			this.comboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.comboBrand.FormattingEnabled = true;
			this.comboBrand.Location = new System.Drawing.Point(19, 61);
			this.comboBrand.Name = "comboBrand";
			this.comboBrand.Size = new System.Drawing.Size(211, 21);
			this.comboBrand.TabIndex = 2;
			// 
			// txtSeats
			// 
			this.txtSeats.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtSeats.Location = new System.Drawing.Point(275, 209);
			this.txtSeats.Name = "txtSeats";
			this.txtSeats.Size = new System.Drawing.Size(210, 15);
			this.txtSeats.TabIndex = 14;
			// 
			// txtFuelCon
			// 
			this.txtFuelCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtFuelCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtFuelCon.Location = new System.Drawing.Point(275, 281);
			this.txtFuelCon.Name = "txtFuelCon";
			this.txtFuelCon.Size = new System.Drawing.Size(210, 15);
			this.txtFuelCon.TabIndex = 16;
			// 
			// txtPosY
			// 
			this.txtPosY.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPosY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtPosY.Location = new System.Drawing.Point(275, 137);
			this.txtPosY.Name = "txtPosY";
			this.txtPosY.Size = new System.Drawing.Size(210, 15);
			this.txtPosY.TabIndex = 12;
			// 
			// txtMaxTankFilling
			// 
			this.txtMaxTankFilling.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMaxTankFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtMaxTankFilling.Location = new System.Drawing.Point(275, 64);
			this.txtMaxTankFilling.Name = "txtMaxTankFilling";
			this.txtMaxTankFilling.Size = new System.Drawing.Size(210, 15);
			this.txtMaxTankFilling.TabIndex = 10;
			// 
			// txtPosX
			// 
			this.txtPosX.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPosX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtPosX.Location = new System.Drawing.Point(275, 101);
			this.txtPosX.Name = "txtPosX";
			this.txtPosX.Size = new System.Drawing.Size(210, 15);
			this.txtPosX.TabIndex = 11;
			// 
			// txtTankFilling
			// 
			this.txtTankFilling.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTankFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtTankFilling.Location = new System.Drawing.Point(275, 28);
			this.txtTankFilling.Name = "txtTankFilling";
			this.txtTankFilling.Size = new System.Drawing.Size(210, 15);
			this.txtTankFilling.TabIndex = 9;
			// 
			// txtNumberplate
			// 
			this.txtNumberplate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNumberplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtNumberplate.Location = new System.Drawing.Point(19, 137);
			this.txtNumberplate.Name = "txtNumberplate";
			this.txtNumberplate.Size = new System.Drawing.Size(210, 15);
			this.txtNumberplate.TabIndex = 4;
			// 
			// txtModel
			// 
			this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtModel.Location = new System.Drawing.Point(19, 101);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(210, 15);
			this.txtModel.TabIndex = 3;
			// 
			// txtPower
			// 
			this.txtPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtPower.Location = new System.Drawing.Point(19, 281);
			this.txtPower.Name = "txtPower";
			this.txtPower.Size = new System.Drawing.Size(210, 15);
			this.txtPower.TabIndex = 8;
			// 
			// txtReg
			// 
			this.txtReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtReg.Location = new System.Drawing.Point(19, 209);
			this.txtReg.Name = "txtReg";
			this.txtReg.Size = new System.Drawing.Size(210, 15);
			this.txtReg.TabIndex = 6;
			// 
			// txtConstructionYear
			// 
			this.txtConstructionYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtConstructionYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtConstructionYear.Location = new System.Drawing.Point(19, 173);
			this.txtConstructionYear.Name = "txtConstructionYear";
			this.txtConstructionYear.Size = new System.Drawing.Size(210, 15);
			this.txtConstructionYear.TabIndex = 5;
			// 
			// txtMileage
			// 
			this.txtMileage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtMileage.Location = new System.Drawing.Point(20, 28);
			this.txtMileage.Name = "txtMileage";
			this.txtMileage.Size = new System.Drawing.Size(210, 15);
			this.txtMileage.TabIndex = 1;
			// 
			// labelPosX
			// 
			this.labelPosX.AutoSize = true;
			this.labelPosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPosX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPosX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPosX.Location = new System.Drawing.Point(272, 83);
			this.labelPosX.Name = "labelPosX";
			this.labelPosX.Size = new System.Drawing.Size(62, 15);
			this.labelPosX.TabIndex = 40;
			this.labelPosX.Text = "Standort X";
			// 
			// labelFuelCon
			// 
			this.labelFuelCon.AutoSize = true;
			this.labelFuelCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelFuelCon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFuelCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelFuelCon.Location = new System.Drawing.Point(272, 263);
			this.labelFuelCon.Name = "labelFuelCon";
			this.labelFuelCon.Size = new System.Drawing.Size(109, 15);
			this.labelFuelCon.TabIndex = 38;
			this.labelFuelCon.Text = "Kraftstoffverbrauch";
			// 
			// labelFuel
			// 
			this.labelFuel.AutoSize = true;
			this.labelFuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelFuel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelFuel.Location = new System.Drawing.Point(272, 227);
			this.labelFuel.Name = "labelFuel";
			this.labelFuel.Size = new System.Drawing.Size(70, 15);
			this.labelFuel.TabIndex = 36;
			this.labelFuel.Text = "Kraftstoffart";
			// 
			// labelSeats
			// 
			this.labelSeats.AutoSize = true;
			this.labelSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelSeats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelSeats.Location = new System.Drawing.Point(272, 191);
			this.labelSeats.Name = "labelSeats";
			this.labelSeats.Size = new System.Drawing.Size(90, 15);
			this.labelSeats.TabIndex = 34;
			this.labelSeats.Text = "Anzahl der Sitze";
			// 
			// labelLastMaint
			// 
			this.labelLastMaint.AutoSize = true;
			this.labelLastMaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelLastMaint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLastMaint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelLastMaint.Location = new System.Drawing.Point(272, 155);
			this.labelLastMaint.Name = "labelLastMaint";
			this.labelLastMaint.Size = new System.Drawing.Size(87, 15);
			this.labelLastMaint.TabIndex = 32;
			this.labelLastMaint.Text = "Letzte Wartung";
			// 
			// labelPosY
			// 
			this.labelPosY.AutoSize = true;
			this.labelPosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPosY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPosY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPosY.Location = new System.Drawing.Point(272, 119);
			this.labelPosY.Name = "labelPosY";
			this.labelPosY.Size = new System.Drawing.Size(62, 15);
			this.labelPosY.TabIndex = 30;
			this.labelPosY.Text = "Standort Y";
			// 
			// labelTankFilling
			// 
			this.labelTankFilling.AutoSize = true;
			this.labelTankFilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelTankFilling.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTankFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelTankFilling.Location = new System.Drawing.Point(272, 10);
			this.labelTankFilling.Name = "labelTankFilling";
			this.labelTankFilling.Size = new System.Drawing.Size(70, 15);
			this.labelTankFilling.TabIndex = 28;
			this.labelTankFilling.Text = "Tankfüllung";
			// 
			// labelMaxTankFilling
			// 
			this.labelMaxTankFilling.AutoSize = true;
			this.labelMaxTankFilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelMaxTankFilling.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMaxTankFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelMaxTankFilling.Location = new System.Drawing.Point(272, 46);
			this.labelMaxTankFilling.Name = "labelMaxTankFilling";
			this.labelMaxTankFilling.Size = new System.Drawing.Size(124, 15);
			this.labelMaxTankFilling.TabIndex = 26;
			this.labelMaxTankFilling.Text = "Maximale Tankfüllung";
			// 
			// labelPower
			// 
			this.labelPower.AutoSize = true;
			this.labelPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPower.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPower.Location = new System.Drawing.Point(16, 263);
			this.labelPower.Name = "labelPower";
			this.labelPower.Size = new System.Drawing.Size(52, 15);
			this.labelPower.TabIndex = 24;
			this.labelPower.Text = "Leistung";
			// 
			// labelGear
			// 
			this.labelGear.AutoSize = true;
			this.labelGear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelGear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelGear.Location = new System.Drawing.Point(17, 227);
			this.labelGear.Name = "labelGear";
			this.labelGear.Size = new System.Drawing.Size(53, 15);
			this.labelGear.TabIndex = 22;
			this.labelGear.Text = "Schaltart";
			// 
			// labelReg
			// 
			this.labelReg.AutoSize = true;
			this.labelReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelReg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelReg.Location = new System.Drawing.Point(16, 191);
			this.labelReg.Name = "labelReg";
			this.labelReg.Size = new System.Drawing.Size(144, 15);
			this.labelReg.TabIndex = 20;
			this.labelReg.Text = "Erstzulassung (MM/YYYY)";
			// 
			// labelConstructionYear
			// 
			this.labelConstructionYear.AutoSize = true;
			this.labelConstructionYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelConstructionYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConstructionYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelConstructionYear.Location = new System.Drawing.Point(16, 155);
			this.labelConstructionYear.Name = "labelConstructionYear";
			this.labelConstructionYear.Size = new System.Drawing.Size(47, 15);
			this.labelConstructionYear.TabIndex = 18;
			this.labelConstructionYear.Text = "Baujahr";
			// 
			// labelMileage
			// 
			this.labelMileage.AutoSize = true;
			this.labelMileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelMileage.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labelMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelMileage.Location = new System.Drawing.Point(17, 10);
			this.labelMileage.Name = "labelMileage";
			this.labelMileage.Size = new System.Drawing.Size(87, 15);
			this.labelMileage.TabIndex = 16;
			this.labelMileage.Text = "Kilometerstand";
			// 
			// labelNumberplate
			// 
			this.labelNumberplate.AutoSize = true;
			this.labelNumberplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelNumberplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNumberplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelNumberplate.Location = new System.Drawing.Point(16, 119);
			this.labelNumberplate.Name = "labelNumberplate";
			this.labelNumberplate.Size = new System.Drawing.Size(93, 15);
			this.labelNumberplate.TabIndex = 14;
			this.labelNumberplate.Text = "Nummernschild";
			// 
			// labelModel
			// 
			this.labelModel.AutoSize = true;
			this.labelModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelModel.Location = new System.Drawing.Point(16, 83);
			this.labelModel.Name = "labelModel";
			this.labelModel.Size = new System.Drawing.Size(44, 15);
			this.labelModel.TabIndex = 12;
			this.labelModel.Text = "Modell";
			// 
			// labelBrand
			// 
			this.labelBrand.AutoSize = true;
			this.labelBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelBrand.Location = new System.Drawing.Point(16, 46);
			this.labelBrand.Name = "labelBrand";
			this.labelBrand.Size = new System.Drawing.Size(40, 15);
			this.labelBrand.TabIndex = 10;
			this.labelBrand.Text = "Marke";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tabPage2.Controls.Add(this.checkSmoker);
			this.tabPage2.Controls.Add(this.label22);
			this.tabPage2.Controls.Add(this.checkWinter);
			this.tabPage2.Controls.Add(this.label23);
			this.tabPage2.Controls.Add(this.checkHeatedSeat);
			this.tabPage2.Controls.Add(this.label24);
			this.tabPage2.Controls.Add(this.checkESP);
			this.tabPage2.Controls.Add(this.label25);
			this.tabPage2.Controls.Add(this.checkABS);
			this.tabPage2.Controls.Add(this.label26);
			this.tabPage2.Controls.Add(this.checkNavigationDevice);
			this.tabPage2.Controls.Add(this.label27);
			this.tabPage2.Controls.Add(this.checkCDPlayer);
			this.tabPage2.Controls.Add(this.label19);
			this.tabPage2.Controls.Add(this.checkUSB);
			this.tabPage2.Controls.Add(this.label20);
			this.tabPage2.Controls.Add(this.checkBluetooth);
			this.tabPage2.Controls.Add(this.label21);
			this.tabPage2.Controls.Add(this.checkRadio);
			this.tabPage2.Controls.Add(this.label18);
			this.tabPage2.Controls.Add(this.checkCruiseControl);
			this.tabPage2.Controls.Add(this.label17);
			this.tabPage2.Controls.Add(this.checkAirConditioner);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(514, 343);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Zubehör";
			// 
			// checkSmoker
			// 
			this.checkSmoker.AutoSize = true;
			this.checkSmoker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkSmoker.Location = new System.Drawing.Point(24, 292);
			this.checkSmoker.Name = "checkSmoker";
			this.checkSmoker.Size = new System.Drawing.Size(15, 14);
			this.checkSmoker.TabIndex = 240;
			this.checkSmoker.UseVisualStyleBackColor = true;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label22.Location = new System.Drawing.Point(45, 286);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(127, 24);
			this.label22.TabIndex = 241;
			this.label22.Text = "Raucherpaket";
			// 
			// checkWinter
			// 
			this.checkWinter.AutoSize = true;
			this.checkWinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkWinter.Location = new System.Drawing.Point(24, 268);
			this.checkWinter.Name = "checkWinter";
			this.checkWinter.Size = new System.Drawing.Size(15, 14);
			this.checkWinter.TabIndex = 238;
			this.checkWinter.UseVisualStyleBackColor = true;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label23.Location = new System.Drawing.Point(45, 262);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(111, 24);
			this.label23.TabIndex = 239;
			this.label23.Text = "Winterreifen";
			// 
			// checkHeatedSeat
			// 
			this.checkHeatedSeat.AutoSize = true;
			this.checkHeatedSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkHeatedSeat.Location = new System.Drawing.Point(24, 245);
			this.checkHeatedSeat.Name = "checkHeatedSeat";
			this.checkHeatedSeat.Size = new System.Drawing.Size(15, 14);
			this.checkHeatedSeat.TabIndex = 236;
			this.checkHeatedSeat.UseVisualStyleBackColor = true;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label24.Location = new System.Drawing.Point(45, 239);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(107, 24);
			this.label24.TabIndex = 237;
			this.label24.Text = "Sitzheizung";
			// 
			// checkESP
			// 
			this.checkESP.AutoSize = true;
			this.checkESP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkESP.Location = new System.Drawing.Point(24, 221);
			this.checkESP.Name = "checkESP";
			this.checkESP.Size = new System.Drawing.Size(15, 14);
			this.checkESP.TabIndex = 234;
			this.checkESP.UseVisualStyleBackColor = true;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label25.Location = new System.Drawing.Point(45, 215);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(47, 24);
			this.label25.TabIndex = 235;
			this.label25.Text = "ESP";
			// 
			// checkABS
			// 
			this.checkABS.AutoSize = true;
			this.checkABS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkABS.Location = new System.Drawing.Point(24, 197);
			this.checkABS.Name = "checkABS";
			this.checkABS.Size = new System.Drawing.Size(15, 14);
			this.checkABS.TabIndex = 232;
			this.checkABS.UseVisualStyleBackColor = true;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label26.Location = new System.Drawing.Point(45, 191);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(47, 24);
			this.label26.TabIndex = 233;
			this.label26.Text = "ABS";
			// 
			// checkNavigationDevice
			// 
			this.checkNavigationDevice.AutoSize = true;
			this.checkNavigationDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkNavigationDevice.Location = new System.Drawing.Point(24, 173);
			this.checkNavigationDevice.Name = "checkNavigationDevice";
			this.checkNavigationDevice.Size = new System.Drawing.Size(15, 14);
			this.checkNavigationDevice.TabIndex = 230;
			this.checkNavigationDevice.UseVisualStyleBackColor = true;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label27.Location = new System.Drawing.Point(45, 167);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(149, 24);
			this.label27.TabIndex = 231;
			this.label27.Text = "Navigationsgerät";
			// 
			// checkCDPlayer
			// 
			this.checkCDPlayer.AutoSize = true;
			this.checkCDPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkCDPlayer.Location = new System.Drawing.Point(24, 149);
			this.checkCDPlayer.Name = "checkCDPlayer";
			this.checkCDPlayer.Size = new System.Drawing.Size(15, 14);
			this.checkCDPlayer.TabIndex = 228;
			this.checkCDPlayer.UseVisualStyleBackColor = true;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label19.Location = new System.Drawing.Point(45, 143);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(101, 24);
			this.label19.TabIndex = 229;
			this.label19.Text = "CD-Spieler";
			// 
			// checkUSB
			// 
			this.checkUSB.AutoSize = true;
			this.checkUSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkUSB.Location = new System.Drawing.Point(24, 125);
			this.checkUSB.Name = "checkUSB";
			this.checkUSB.Size = new System.Drawing.Size(15, 14);
			this.checkUSB.TabIndex = 226;
			this.checkUSB.UseVisualStyleBackColor = true;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label20.Location = new System.Drawing.Point(45, 119);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(47, 24);
			this.label20.TabIndex = 227;
			this.label20.Text = "USB";
			// 
			// checkBluetooth
			// 
			this.checkBluetooth.AutoSize = true;
			this.checkBluetooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBluetooth.Location = new System.Drawing.Point(24, 102);
			this.checkBluetooth.Name = "checkBluetooth";
			this.checkBluetooth.Size = new System.Drawing.Size(15, 14);
			this.checkBluetooth.TabIndex = 224;
			this.checkBluetooth.UseVisualStyleBackColor = true;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label21.Location = new System.Drawing.Point(45, 96);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(89, 24);
			this.label21.TabIndex = 225;
			this.label21.Text = "Bluetooth";
			// 
			// checkRadio
			// 
			this.checkRadio.AutoSize = true;
			this.checkRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkRadio.Location = new System.Drawing.Point(24, 78);
			this.checkRadio.Name = "checkRadio";
			this.checkRadio.Size = new System.Drawing.Size(15, 14);
			this.checkRadio.TabIndex = 222;
			this.checkRadio.UseVisualStyleBackColor = true;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label18.Location = new System.Drawing.Point(45, 72);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(59, 24);
			this.label18.TabIndex = 223;
			this.label18.Text = "Radio";
			// 
			// checkCruiseControl
			// 
			this.checkCruiseControl.AutoSize = true;
			this.checkCruiseControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkCruiseControl.Location = new System.Drawing.Point(24, 54);
			this.checkCruiseControl.Name = "checkCruiseControl";
			this.checkCruiseControl.Size = new System.Drawing.Size(15, 14);
			this.checkCruiseControl.TabIndex = 220;
			this.checkCruiseControl.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label17.Location = new System.Drawing.Point(45, 48);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(101, 24);
			this.label17.TabIndex = 221;
			this.label17.Text = "Tempomat";
			// 
			// checkAirConditioner
			// 
			this.checkAirConditioner.AutoSize = true;
			this.checkAirConditioner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkAirConditioner.Location = new System.Drawing.Point(24, 30);
			this.checkAirConditioner.Name = "checkAirConditioner";
			this.checkAirConditioner.Size = new System.Drawing.Size(15, 14);
			this.checkAirConditioner.TabIndex = 218;
			this.checkAirConditioner.UseVisualStyleBackColor = true;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label16.Location = new System.Drawing.Point(45, 24);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(113, 24);
			this.label16.TabIndex = 219;
			this.label16.Text = "Klimaanlage";
			// 
			// checkAvailable
			// 
			this.checkAvailable.AutoSize = true;
			this.checkAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkAvailable.Location = new System.Drawing.Point(93, 387);
			this.checkAvailable.Name = "checkAvailable";
			this.checkAvailable.Size = new System.Drawing.Size(15, 14);
			this.checkAvailable.TabIndex = 242;
			this.checkAvailable.UseVisualStyleBackColor = true;
			// 
			// labelAvailable
			// 
			this.labelAvailable.AutoSize = true;
			this.labelAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelAvailable.Location = new System.Drawing.Point(20, 385);
			this.labelAvailable.Name = "labelAvailable";
			this.labelAvailable.Size = new System.Drawing.Size(67, 16);
			this.labelAvailable.TabIndex = 243;
			this.labelAvailable.Text = "Verfügbar";
			// 
			// EditDataViewVehicle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.checkAvailable);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.labelAvailable);
			this.Controls.Add(this.buttonAccept);
			this.Name = "EditDataViewVehicle";
			this.Size = new System.Drawing.Size(525, 425);
			this.Load += new System.EventHandler(this.EditDataViewVehicle_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CustomControl.RoundButton buttonAccept;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox txtSeats;
		private System.Windows.Forms.TextBox txtFuelCon;
		private System.Windows.Forms.TextBox txtPosY;
		private System.Windows.Forms.TextBox txtMaxTankFilling;
		private System.Windows.Forms.TextBox txtPosX;
		private System.Windows.Forms.TextBox txtTankFilling;
		private System.Windows.Forms.TextBox txtNumberplate;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.TextBox txtPower;
		private System.Windows.Forms.TextBox txtReg;
		private System.Windows.Forms.TextBox txtConstructionYear;
		private System.Windows.Forms.TextBox txtMileage;
		private System.Windows.Forms.Label labelPosX;
		private System.Windows.Forms.Label labelFuelCon;
		private System.Windows.Forms.Label labelFuel;
		private System.Windows.Forms.Label labelSeats;
		private System.Windows.Forms.Label labelLastMaint;
		private System.Windows.Forms.Label labelPosY;
		private System.Windows.Forms.Label labelTankFilling;
		private System.Windows.Forms.Label labelMaxTankFilling;
		private System.Windows.Forms.Label labelPower;
		private System.Windows.Forms.Label labelGear;
		private System.Windows.Forms.Label labelReg;
		private System.Windows.Forms.Label labelConstructionYear;
		private System.Windows.Forms.Label labelMileage;
		private System.Windows.Forms.Label labelNumberplate;
		private System.Windows.Forms.Label labelModel;
		private System.Windows.Forms.Label labelBrand;
		private System.Windows.Forms.ComboBox comboBrand;
		private System.Windows.Forms.DateTimePicker dateTimeLastMaintenance;
		private System.Windows.Forms.ComboBox comboFuel;
		private System.Windows.Forms.ComboBox comboGear;
		private System.Windows.Forms.TextBox txtPriceMin;
		private System.Windows.Forms.Label labelPriceMin;
		private System.Windows.Forms.TextBox txtPriceKilo;
		private System.Windows.Forms.Label labelPriceKilo;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.CheckBox checkSmoker;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.CheckBox checkWinter;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.CheckBox checkHeatedSeat;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.CheckBox checkESP;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.CheckBox checkABS;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.CheckBox checkNavigationDevice;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.CheckBox checkCDPlayer;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.CheckBox checkUSB;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.CheckBox checkBluetooth;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.CheckBox checkRadio;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.CheckBox checkCruiseControl;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.CheckBox checkAirConditioner;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.CheckBox checkAvailable;
		private System.Windows.Forms.Label labelAvailable;
	}
}
