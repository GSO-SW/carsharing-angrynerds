namespace Carsharing
{
	partial class MainViewUserBooking
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
			this.listVehicle = new System.Windows.Forms.ListBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.txtPriceMin = new System.Windows.Forms.Label();
			this.labelPriceMin = new System.Windows.Forms.Label();
			this.txtPriceKilo = new System.Windows.Forms.Label();
			this.labelPriceKilo = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.txtFuelCon = new System.Windows.Forms.Label();
			this.txtSeats = new System.Windows.Forms.Label();
			this.txtLastMaint = new System.Windows.Forms.Label();
			this.txtTankFilling = new System.Windows.Forms.Label();
			this.txtMaxTankFilling = new System.Windows.Forms.Label();
			this.txtPosX = new System.Windows.Forms.Label();
			this.txtPosY = new System.Windows.Forms.Label();
			this.txtPower = new System.Windows.Forms.Label();
			this.txtBrand = new System.Windows.Forms.Label();
			this.txtReg = new System.Windows.Forms.Label();
			this.txtGear = new System.Windows.Forms.Label();
			this.txtFuel = new System.Windows.Forms.Label();
			this.txtConstructionYear = new System.Windows.Forms.Label();
			this.txtNumberplate = new System.Windows.Forms.Label();
			this.txtModel = new System.Windows.Forms.Label();
			this.txtMileage = new System.Windows.Forms.Label();
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
			this.buttonRefresh = new CustomControl.RoundButton();
			this.buttonBookingAdd = new CustomControl.RoundButton();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(3, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(68, 13);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "UserBooking";
			// 
			// listVehicle
			// 
			this.listVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.listVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listVehicle.Dock = System.Windows.Forms.DockStyle.Left;
			this.listVehicle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listVehicle.FormattingEnabled = true;
			this.listVehicle.ItemHeight = 20;
			this.listVehicle.Location = new System.Drawing.Point(0, 0);
			this.listVehicle.Name = "listVehicle";
			this.listVehicle.Size = new System.Drawing.Size(245, 575);
			this.listVehicle.TabIndex = 8;
			this.listVehicle.SelectedIndexChanged += new System.EventHandler(this.listVehicle_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl1.Location = new System.Drawing.Point(245, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(655, 538);
			this.tabControl1.TabIndex = 9;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Controls.Add(this.txtPriceMin);
			this.tabPage1.Controls.Add(this.labelPriceMin);
			this.tabPage1.Controls.Add(this.txtPriceKilo);
			this.tabPage1.Controls.Add(this.labelPriceKilo);
			this.tabPage1.Controls.Add(this.txtPrice);
			this.tabPage1.Controls.Add(this.labelPrice);
			this.tabPage1.Controls.Add(this.txtFuelCon);
			this.tabPage1.Controls.Add(this.txtSeats);
			this.tabPage1.Controls.Add(this.txtLastMaint);
			this.tabPage1.Controls.Add(this.txtTankFilling);
			this.tabPage1.Controls.Add(this.txtMaxTankFilling);
			this.tabPage1.Controls.Add(this.txtPosX);
			this.tabPage1.Controls.Add(this.txtPosY);
			this.tabPage1.Controls.Add(this.txtPower);
			this.tabPage1.Controls.Add(this.txtBrand);
			this.tabPage1.Controls.Add(this.txtReg);
			this.tabPage1.Controls.Add(this.txtGear);
			this.tabPage1.Controls.Add(this.txtFuel);
			this.tabPage1.Controls.Add(this.txtConstructionYear);
			this.tabPage1.Controls.Add(this.txtNumberplate);
			this.tabPage1.Controls.Add(this.txtModel);
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
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(647, 512);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Allgemeine Fahrzeuginformationen";
			// 
			// txtPriceMin
			// 
			this.txtPriceMin.AutoSize = true;
			this.txtPriceMin.BackColor = System.Drawing.Color.White;
			this.txtPriceMin.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPriceMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPriceMin.Location = new System.Drawing.Point(330, 423);
			this.txtPriceMin.Name = "txtPriceMin";
			this.txtPriceMin.Size = new System.Drawing.Size(105, 19);
			this.txtPriceMin.TabIndex = 63;
			this.txtPriceMin.Text = "----------------";
			// 
			// labelPriceMin
			// 
			this.labelPriceMin.AutoSize = true;
			this.labelPriceMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPriceMin.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPriceMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPriceMin.Location = new System.Drawing.Point(330, 401);
			this.labelPriceMin.Name = "labelPriceMin";
			this.labelPriceMin.Size = new System.Drawing.Size(74, 19);
			this.labelPriceMin.TabIndex = 62;
			this.labelPriceMin.Text = "Preis / min";
			// 
			// txtPriceKilo
			// 
			this.txtPriceKilo.AutoSize = true;
			this.txtPriceKilo.BackColor = System.Drawing.Color.White;
			this.txtPriceKilo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPriceKilo.Location = new System.Drawing.Point(173, 423);
			this.txtPriceKilo.Name = "txtPriceKilo";
			this.txtPriceKilo.Size = new System.Drawing.Size(105, 19);
			this.txtPriceKilo.TabIndex = 61;
			this.txtPriceKilo.Text = "----------------";
			// 
			// labelPriceKilo
			// 
			this.labelPriceKilo.AutoSize = true;
			this.labelPriceKilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPriceKilo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPriceKilo.Location = new System.Drawing.Point(173, 401);
			this.labelPriceKilo.Name = "labelPriceKilo";
			this.labelPriceKilo.Size = new System.Drawing.Size(70, 19);
			this.labelPriceKilo.TabIndex = 60;
			this.labelPriceKilo.Text = "Preis / km";
			// 
			// txtPrice
			// 
			this.txtPrice.AutoSize = true;
			this.txtPrice.BackColor = System.Drawing.Color.White;
			this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPrice.Location = new System.Drawing.Point(14, 423);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(105, 19);
			this.txtPrice.TabIndex = 59;
			this.txtPrice.Text = "----------------";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPrice.Location = new System.Drawing.Point(14, 401);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(38, 19);
			this.labelPrice.TabIndex = 58;
			this.labelPrice.Text = "Preis";
			// 
			// txtFuelCon
			// 
			this.txtFuelCon.AutoSize = true;
			this.txtFuelCon.BackColor = System.Drawing.Color.White;
			this.txtFuelCon.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtFuelCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtFuelCon.Location = new System.Drawing.Point(330, 381);
			this.txtFuelCon.Name = "txtFuelCon";
			this.txtFuelCon.Size = new System.Drawing.Size(105, 19);
			this.txtFuelCon.TabIndex = 57;
			this.txtFuelCon.Text = "----------------";
			// 
			// txtSeats
			// 
			this.txtSeats.AutoSize = true;
			this.txtSeats.BackColor = System.Drawing.Color.White;
			this.txtSeats.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtSeats.Location = new System.Drawing.Point(330, 279);
			this.txtSeats.Name = "txtSeats";
			this.txtSeats.Size = new System.Drawing.Size(105, 19);
			this.txtSeats.TabIndex = 56;
			this.txtSeats.Text = "----------------";
			// 
			// txtLastMaint
			// 
			this.txtLastMaint.AutoSize = true;
			this.txtLastMaint.BackColor = System.Drawing.Color.White;
			this.txtLastMaint.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtLastMaint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtLastMaint.Location = new System.Drawing.Point(330, 232);
			this.txtLastMaint.Name = "txtLastMaint";
			this.txtLastMaint.Size = new System.Drawing.Size(105, 19);
			this.txtLastMaint.TabIndex = 55;
			this.txtLastMaint.Text = "----------------";
			// 
			// txtTankFilling
			// 
			this.txtTankFilling.AutoSize = true;
			this.txtTankFilling.BackColor = System.Drawing.Color.White;
			this.txtTankFilling.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtTankFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtTankFilling.Location = new System.Drawing.Point(330, 32);
			this.txtTankFilling.Name = "txtTankFilling";
			this.txtTankFilling.Size = new System.Drawing.Size(105, 19);
			this.txtTankFilling.TabIndex = 54;
			this.txtTankFilling.Text = "----------------";
			// 
			// txtMaxTankFilling
			// 
			this.txtMaxTankFilling.AutoSize = true;
			this.txtMaxTankFilling.BackColor = System.Drawing.Color.White;
			this.txtMaxTankFilling.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtMaxTankFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtMaxTankFilling.Location = new System.Drawing.Point(330, 82);
			this.txtMaxTankFilling.Name = "txtMaxTankFilling";
			this.txtMaxTankFilling.Size = new System.Drawing.Size(105, 19);
			this.txtMaxTankFilling.TabIndex = 53;
			this.txtMaxTankFilling.Text = "----------------";
			// 
			// txtPosX
			// 
			this.txtPosX.AutoSize = true;
			this.txtPosX.BackColor = System.Drawing.Color.White;
			this.txtPosX.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPosX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPosX.Location = new System.Drawing.Point(330, 132);
			this.txtPosX.Name = "txtPosX";
			this.txtPosX.Size = new System.Drawing.Size(105, 19);
			this.txtPosX.TabIndex = 52;
			this.txtPosX.Text = "----------------";
			// 
			// txtPosY
			// 
			this.txtPosY.AutoSize = true;
			this.txtPosY.BackColor = System.Drawing.Color.White;
			this.txtPosY.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPosY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPosY.Location = new System.Drawing.Point(330, 182);
			this.txtPosY.Name = "txtPosY";
			this.txtPosY.Size = new System.Drawing.Size(105, 19);
			this.txtPosY.TabIndex = 51;
			this.txtPosY.Text = "----------------";
			// 
			// txtPower
			// 
			this.txtPower.AutoSize = true;
			this.txtPower.BackColor = System.Drawing.Color.White;
			this.txtPower.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPower.Location = new System.Drawing.Point(14, 382);
			this.txtPower.Name = "txtPower";
			this.txtPower.Size = new System.Drawing.Size(105, 19);
			this.txtPower.TabIndex = 50;
			this.txtPower.Text = "----------------";
			// 
			// txtBrand
			// 
			this.txtBrand.AutoSize = true;
			this.txtBrand.BackColor = System.Drawing.Color.White;
			this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtBrand.Location = new System.Drawing.Point(14, 82);
			this.txtBrand.Name = "txtBrand";
			this.txtBrand.Size = new System.Drawing.Size(105, 19);
			this.txtBrand.TabIndex = 49;
			this.txtBrand.Text = "----------------";
			// 
			// txtReg
			// 
			this.txtReg.AutoSize = true;
			this.txtReg.BackColor = System.Drawing.Color.White;
			this.txtReg.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtReg.Location = new System.Drawing.Point(14, 282);
			this.txtReg.Name = "txtReg";
			this.txtReg.Size = new System.Drawing.Size(105, 19);
			this.txtReg.TabIndex = 48;
			this.txtReg.Text = "----------------";
			// 
			// txtGear
			// 
			this.txtGear.AutoSize = true;
			this.txtGear.BackColor = System.Drawing.Color.White;
			this.txtGear.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtGear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtGear.Location = new System.Drawing.Point(14, 332);
			this.txtGear.Name = "txtGear";
			this.txtGear.Size = new System.Drawing.Size(105, 19);
			this.txtGear.TabIndex = 47;
			this.txtGear.Text = "----------------";
			// 
			// txtFuel
			// 
			this.txtFuel.AutoSize = true;
			this.txtFuel.BackColor = System.Drawing.Color.White;
			this.txtFuel.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtFuel.Location = new System.Drawing.Point(330, 331);
			this.txtFuel.Name = "txtFuel";
			this.txtFuel.Size = new System.Drawing.Size(105, 19);
			this.txtFuel.TabIndex = 46;
			this.txtFuel.Text = "----------------";
			// 
			// txtConstructionYear
			// 
			this.txtConstructionYear.AutoSize = true;
			this.txtConstructionYear.BackColor = System.Drawing.Color.White;
			this.txtConstructionYear.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtConstructionYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtConstructionYear.Location = new System.Drawing.Point(14, 232);
			this.txtConstructionYear.Name = "txtConstructionYear";
			this.txtConstructionYear.Size = new System.Drawing.Size(105, 19);
			this.txtConstructionYear.TabIndex = 45;
			this.txtConstructionYear.Text = "----------------";
			// 
			// txtNumberplate
			// 
			this.txtNumberplate.AutoSize = true;
			this.txtNumberplate.BackColor = System.Drawing.Color.White;
			this.txtNumberplate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtNumberplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtNumberplate.Location = new System.Drawing.Point(14, 182);
			this.txtNumberplate.Name = "txtNumberplate";
			this.txtNumberplate.Size = new System.Drawing.Size(105, 19);
			this.txtNumberplate.TabIndex = 44;
			this.txtNumberplate.Text = "----------------";
			// 
			// txtModel
			// 
			this.txtModel.AutoSize = true;
			this.txtModel.BackColor = System.Drawing.Color.White;
			this.txtModel.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtModel.Location = new System.Drawing.Point(14, 132);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(105, 19);
			this.txtModel.TabIndex = 43;
			this.txtModel.Text = "----------------";
			// 
			// txtMileage
			// 
			this.txtMileage.AutoSize = true;
			this.txtMileage.BackColor = System.Drawing.Color.White;
			this.txtMileage.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtMileage.Location = new System.Drawing.Point(14, 32);
			this.txtMileage.Name = "txtMileage";
			this.txtMileage.Size = new System.Drawing.Size(105, 19);
			this.txtMileage.TabIndex = 42;
			this.txtMileage.Text = "----------------";
			// 
			// labelPosX
			// 
			this.labelPosX.AutoSize = true;
			this.labelPosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPosX.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPosX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPosX.Location = new System.Drawing.Point(331, 110);
			this.labelPosX.Name = "labelPosX";
			this.labelPosX.Size = new System.Drawing.Size(74, 19);
			this.labelPosX.TabIndex = 40;
			this.labelPosX.Text = "Standort X";
			// 
			// labelFuelCon
			// 
			this.labelFuelCon.AutoSize = true;
			this.labelFuelCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelFuelCon.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelFuelCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelFuelCon.Location = new System.Drawing.Point(330, 360);
			this.labelFuelCon.Name = "labelFuelCon";
			this.labelFuelCon.Size = new System.Drawing.Size(126, 19);
			this.labelFuelCon.TabIndex = 38;
			this.labelFuelCon.Text = "Kraftstoffverbrauch";
			// 
			// labelFuel
			// 
			this.labelFuel.AutoSize = true;
			this.labelFuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelFuel.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelFuel.Location = new System.Drawing.Point(330, 310);
			this.labelFuel.Name = "labelFuel";
			this.labelFuel.Size = new System.Drawing.Size(82, 19);
			this.labelFuel.TabIndex = 36;
			this.labelFuel.Text = "Kraftstoffart";
			// 
			// labelSeats
			// 
			this.labelSeats.AutoSize = true;
			this.labelSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelSeats.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelSeats.Location = new System.Drawing.Point(330, 260);
			this.labelSeats.Name = "labelSeats";
			this.labelSeats.Size = new System.Drawing.Size(106, 19);
			this.labelSeats.TabIndex = 34;
			this.labelSeats.Text = "Anzahl der Sitze";
			// 
			// labelLastMaint
			// 
			this.labelLastMaint.AutoSize = true;
			this.labelLastMaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelLastMaint.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelLastMaint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelLastMaint.Location = new System.Drawing.Point(331, 210);
			this.labelLastMaint.Name = "labelLastMaint";
			this.labelLastMaint.Size = new System.Drawing.Size(103, 19);
			this.labelLastMaint.TabIndex = 32;
			this.labelLastMaint.Text = "Letzte Wartung";
			// 
			// labelPosY
			// 
			this.labelPosY.AutoSize = true;
			this.labelPosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPosY.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPosY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPosY.Location = new System.Drawing.Point(330, 160);
			this.labelPosY.Name = "labelPosY";
			this.labelPosY.Size = new System.Drawing.Size(74, 19);
			this.labelPosY.TabIndex = 30;
			this.labelPosY.Text = "Standort Y";
			// 
			// labelTankFilling
			// 
			this.labelTankFilling.AutoSize = true;
			this.labelTankFilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelTankFilling.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelTankFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelTankFilling.Location = new System.Drawing.Point(330, 8);
			this.labelTankFilling.Name = "labelTankFilling";
			this.labelTankFilling.Size = new System.Drawing.Size(78, 19);
			this.labelTankFilling.TabIndex = 28;
			this.labelTankFilling.Text = "Tankfüllung";
			// 
			// labelMaxTankFilling
			// 
			this.labelMaxTankFilling.AutoSize = true;
			this.labelMaxTankFilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelMaxTankFilling.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelMaxTankFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelMaxTankFilling.Location = new System.Drawing.Point(331, 60);
			this.labelMaxTankFilling.Name = "labelMaxTankFilling";
			this.labelMaxTankFilling.Size = new System.Drawing.Size(140, 19);
			this.labelMaxTankFilling.TabIndex = 26;
			this.labelMaxTankFilling.Text = "Maximale Tankfüllung";
			// 
			// labelPower
			// 
			this.labelPower.AutoSize = true;
			this.labelPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPower.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPower.Location = new System.Drawing.Point(14, 360);
			this.labelPower.Name = "labelPower";
			this.labelPower.Size = new System.Drawing.Size(61, 19);
			this.labelPower.TabIndex = 24;
			this.labelPower.Text = "Leistung";
			// 
			// labelGear
			// 
			this.labelGear.AutoSize = true;
			this.labelGear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelGear.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelGear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelGear.Location = new System.Drawing.Point(13, 310);
			this.labelGear.Name = "labelGear";
			this.labelGear.Size = new System.Drawing.Size(62, 19);
			this.labelGear.TabIndex = 22;
			this.labelGear.Text = "Schaltart";
			// 
			// labelReg
			// 
			this.labelReg.AutoSize = true;
			this.labelReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelReg.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelReg.Location = new System.Drawing.Point(13, 260);
			this.labelReg.Name = "labelReg";
			this.labelReg.Size = new System.Drawing.Size(92, 19);
			this.labelReg.TabIndex = 20;
			this.labelReg.Text = "Erstzulassung";
			// 
			// labelConstructionYear
			// 
			this.labelConstructionYear.AutoSize = true;
			this.labelConstructionYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelConstructionYear.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelConstructionYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelConstructionYear.Location = new System.Drawing.Point(13, 210);
			this.labelConstructionYear.Name = "labelConstructionYear";
			this.labelConstructionYear.Size = new System.Drawing.Size(55, 19);
			this.labelConstructionYear.TabIndex = 18;
			this.labelConstructionYear.Text = "Baujahr";
			// 
			// labelMileage
			// 
			this.labelMileage.AutoSize = true;
			this.labelMileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelMileage.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelMileage.Location = new System.Drawing.Point(13, 10);
			this.labelMileage.Name = "labelMileage";
			this.labelMileage.Size = new System.Drawing.Size(101, 19);
			this.labelMileage.TabIndex = 16;
			this.labelMileage.Text = "Kilometerstand";
			// 
			// labelNumberplate
			// 
			this.labelNumberplate.AutoSize = true;
			this.labelNumberplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelNumberplate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelNumberplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelNumberplate.Location = new System.Drawing.Point(13, 160);
			this.labelNumberplate.Name = "labelNumberplate";
			this.labelNumberplate.Size = new System.Drawing.Size(105, 19);
			this.labelNumberplate.TabIndex = 14;
			this.labelNumberplate.Text = "Nummernschild";
			// 
			// labelModel
			// 
			this.labelModel.AutoSize = true;
			this.labelModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelModel.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelModel.Location = new System.Drawing.Point(13, 110);
			this.labelModel.Name = "labelModel";
			this.labelModel.Size = new System.Drawing.Size(51, 19);
			this.labelModel.TabIndex = 12;
			this.labelModel.Text = "Modell";
			// 
			// labelBrand
			// 
			this.labelBrand.AutoSize = true;
			this.labelBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelBrand.Location = new System.Drawing.Point(13, 60);
			this.labelBrand.Name = "labelBrand";
			this.labelBrand.Size = new System.Drawing.Size(48, 19);
			this.labelBrand.TabIndex = 10;
			this.labelBrand.Text = "Marke";
			// 
			// tabPage2
			// 
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
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(647, 512);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Zubehör";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// checkSmoker
			// 
			this.checkSmoker.AutoSize = true;
			this.checkSmoker.Enabled = false;
			this.checkSmoker.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkSmoker.Location = new System.Drawing.Point(211, 258);
			this.checkSmoker.Name = "checkSmoker";
			this.checkSmoker.Size = new System.Drawing.Size(15, 14);
			this.checkSmoker.TabIndex = 264;
			this.checkSmoker.UseVisualStyleBackColor = true;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label22.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label22.Location = new System.Drawing.Point(207, 236);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(92, 19);
			this.label22.TabIndex = 265;
			this.label22.Text = "Raucherpaket";
			// 
			// checkWinter
			// 
			this.checkWinter.AutoSize = true;
			this.checkWinter.Enabled = false;
			this.checkWinter.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkWinter.Location = new System.Drawing.Point(211, 219);
			this.checkWinter.Name = "checkWinter";
			this.checkWinter.Size = new System.Drawing.Size(15, 14);
			this.checkWinter.TabIndex = 262;
			this.checkWinter.UseVisualStyleBackColor = true;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label23.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label23.Location = new System.Drawing.Point(207, 197);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(84, 19);
			this.label23.TabIndex = 263;
			this.label23.Text = "Winterreifen";
			// 
			// checkHeatedSeat
			// 
			this.checkHeatedSeat.AutoSize = true;
			this.checkHeatedSeat.Enabled = false;
			this.checkHeatedSeat.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkHeatedSeat.Location = new System.Drawing.Point(211, 180);
			this.checkHeatedSeat.Name = "checkHeatedSeat";
			this.checkHeatedSeat.Size = new System.Drawing.Size(15, 14);
			this.checkHeatedSeat.TabIndex = 260;
			this.checkHeatedSeat.UseVisualStyleBackColor = true;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label24.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label24.Location = new System.Drawing.Point(207, 158);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(78, 19);
			this.label24.TabIndex = 261;
			this.label24.Text = "Sitzheizung";
			// 
			// checkESP
			// 
			this.checkESP.AutoSize = true;
			this.checkESP.Enabled = false;
			this.checkESP.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkESP.Location = new System.Drawing.Point(211, 141);
			this.checkESP.Name = "checkESP";
			this.checkESP.Size = new System.Drawing.Size(15, 14);
			this.checkESP.TabIndex = 258;
			this.checkESP.UseVisualStyleBackColor = true;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label25.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label25.Location = new System.Drawing.Point(207, 119);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(31, 19);
			this.label25.TabIndex = 259;
			this.label25.Text = "ESP";
			// 
			// checkABS
			// 
			this.checkABS.AutoSize = true;
			this.checkABS.Enabled = false;
			this.checkABS.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkABS.Location = new System.Drawing.Point(211, 102);
			this.checkABS.Name = "checkABS";
			this.checkABS.Size = new System.Drawing.Size(15, 14);
			this.checkABS.TabIndex = 256;
			this.checkABS.UseVisualStyleBackColor = true;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label26.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label26.Location = new System.Drawing.Point(207, 80);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(33, 19);
			this.label26.TabIndex = 257;
			this.label26.Text = "ABS";
			// 
			// checkNavigationDevice
			// 
			this.checkNavigationDevice.AutoSize = true;
			this.checkNavigationDevice.Enabled = false;
			this.checkNavigationDevice.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkNavigationDevice.Location = new System.Drawing.Point(211, 63);
			this.checkNavigationDevice.Name = "checkNavigationDevice";
			this.checkNavigationDevice.Size = new System.Drawing.Size(15, 14);
			this.checkNavigationDevice.TabIndex = 254;
			this.checkNavigationDevice.UseVisualStyleBackColor = true;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label27.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label27.Location = new System.Drawing.Point(207, 41);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(113, 19);
			this.label27.TabIndex = 255;
			this.label27.Text = "Navigationsgerät";
			// 
			// checkCDPlayer
			// 
			this.checkCDPlayer.AutoSize = true;
			this.checkCDPlayer.Enabled = false;
			this.checkCDPlayer.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkCDPlayer.Location = new System.Drawing.Point(53, 258);
			this.checkCDPlayer.Name = "checkCDPlayer";
			this.checkCDPlayer.Size = new System.Drawing.Size(15, 14);
			this.checkCDPlayer.TabIndex = 252;
			this.checkCDPlayer.UseVisualStyleBackColor = true;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label19.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label19.Location = new System.Drawing.Point(49, 236);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(74, 19);
			this.label19.TabIndex = 253;
			this.label19.Text = "CD-Spieler";
			// 
			// checkUSB
			// 
			this.checkUSB.AutoSize = true;
			this.checkUSB.Enabled = false;
			this.checkUSB.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkUSB.Location = new System.Drawing.Point(53, 219);
			this.checkUSB.Name = "checkUSB";
			this.checkUSB.Size = new System.Drawing.Size(15, 14);
			this.checkUSB.TabIndex = 250;
			this.checkUSB.UseVisualStyleBackColor = true;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label20.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label20.Location = new System.Drawing.Point(49, 197);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(34, 19);
			this.label20.TabIndex = 251;
			this.label20.Text = "USB";
			// 
			// checkBluetooth
			// 
			this.checkBluetooth.AutoSize = true;
			this.checkBluetooth.Enabled = false;
			this.checkBluetooth.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkBluetooth.Location = new System.Drawing.Point(53, 180);
			this.checkBluetooth.Name = "checkBluetooth";
			this.checkBluetooth.Size = new System.Drawing.Size(15, 14);
			this.checkBluetooth.TabIndex = 248;
			this.checkBluetooth.UseVisualStyleBackColor = true;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label21.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label21.Location = new System.Drawing.Point(49, 158);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(69, 19);
			this.label21.TabIndex = 249;
			this.label21.Text = "Bluetooth";
			// 
			// checkRadio
			// 
			this.checkRadio.AutoSize = true;
			this.checkRadio.Enabled = false;
			this.checkRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkRadio.Location = new System.Drawing.Point(53, 141);
			this.checkRadio.Name = "checkRadio";
			this.checkRadio.Size = new System.Drawing.Size(15, 14);
			this.checkRadio.TabIndex = 246;
			this.checkRadio.UseVisualStyleBackColor = true;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label18.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label18.Location = new System.Drawing.Point(49, 119);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(43, 19);
			this.label18.TabIndex = 247;
			this.label18.Text = "Radio";
			// 
			// checkCruiseControl
			// 
			this.checkCruiseControl.AutoSize = true;
			this.checkCruiseControl.Enabled = false;
			this.checkCruiseControl.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkCruiseControl.Location = new System.Drawing.Point(53, 102);
			this.checkCruiseControl.Name = "checkCruiseControl";
			this.checkCruiseControl.Size = new System.Drawing.Size(15, 14);
			this.checkCruiseControl.TabIndex = 244;
			this.checkCruiseControl.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label17.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label17.Location = new System.Drawing.Point(49, 80);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(74, 19);
			this.label17.TabIndex = 245;
			this.label17.Text = "Tempomat";
			// 
			// checkAirConditioner
			// 
			this.checkAirConditioner.AutoSize = true;
			this.checkAirConditioner.Enabled = false;
			this.checkAirConditioner.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.checkAirConditioner.Location = new System.Drawing.Point(53, 63);
			this.checkAirConditioner.Name = "checkAirConditioner";
			this.checkAirConditioner.Size = new System.Drawing.Size(15, 14);
			this.checkAirConditioner.TabIndex = 242;
			this.checkAirConditioner.UseVisualStyleBackColor = true;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label16.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label16.Location = new System.Drawing.Point(50, 41);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(82, 19);
			this.label16.TabIndex = 243;
			this.label16.Text = "Klimaanlage";
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonRefresh.FlatAppearance.BorderSize = 0;
			this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRefresh.Location = new System.Drawing.Point(251, 544);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Rounded = 0;
			this.buttonRefresh.Size = new System.Drawing.Size(94, 28);
			this.buttonRefresh.TabIndex = 10;
			this.buttonRefresh.Text = "Aktualisieren";
			this.buttonRefresh.UseVisualStyleBackColor = false;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// buttonBookingAdd
			// 
			this.buttonBookingAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonBookingAdd.FlatAppearance.BorderSize = 0;
			this.buttonBookingAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBookingAdd.Location = new System.Drawing.Point(746, 544);
			this.buttonBookingAdd.Name = "buttonBookingAdd";
			this.buttonBookingAdd.Rounded = 0;
			this.buttonBookingAdd.Size = new System.Drawing.Size(150, 28);
			this.buttonBookingAdd.TabIndex = 11;
			this.buttonBookingAdd.Text = "Fahrzeug buchen";
			this.buttonBookingAdd.UseVisualStyleBackColor = false;
			this.buttonBookingAdd.Click += new System.EventHandler(this.buttonBookingAdd_Click);
			// 
			// MainViewUserBooking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.buttonBookingAdd);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.listVehicle);
			this.Controls.Add(this.labelTitle);
			this.Name = "MainViewUserBooking";
			this.Size = new System.Drawing.Size(900, 575);
			this.Load += new System.EventHandler(this.MainViewUserBooking_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.ListBox listVehicle;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label txtPriceMin;
		private System.Windows.Forms.Label labelPriceMin;
		private System.Windows.Forms.Label txtPriceKilo;
		private System.Windows.Forms.Label labelPriceKilo;
		private System.Windows.Forms.Label txtPrice;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label txtFuelCon;
		private System.Windows.Forms.Label txtSeats;
		private System.Windows.Forms.Label txtLastMaint;
		private System.Windows.Forms.Label txtTankFilling;
		private System.Windows.Forms.Label txtMaxTankFilling;
		private System.Windows.Forms.Label txtPosX;
		private System.Windows.Forms.Label txtPosY;
		private System.Windows.Forms.Label txtPower;
		private System.Windows.Forms.Label txtBrand;
		private System.Windows.Forms.Label txtReg;
		private System.Windows.Forms.Label txtGear;
		private System.Windows.Forms.Label txtFuel;
		private System.Windows.Forms.Label txtConstructionYear;
		private System.Windows.Forms.Label txtNumberplate;
		private System.Windows.Forms.Label txtModel;
		private System.Windows.Forms.Label txtMileage;
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
		private System.Windows.Forms.TabPage tabPage2;
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
		private CustomControl.RoundButton buttonRefresh;
		private CustomControl.RoundButton buttonBookingAdd;
	}
}
