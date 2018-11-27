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
			this.txtSeats = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
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
			this.comboBrand = new System.Windows.Forms.ComboBox();
			this.dateTimeLastMaintenance = new System.Windows.Forms.DateTimePicker();
			this.comboFuel = new System.Windows.Forms.ComboBox();
			this.comboGear = new System.Windows.Forms.ComboBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.txtPriceKilo = new System.Windows.Forms.TextBox();
			this.labelPriceKilo = new System.Windows.Forms.Label();
			this.txtPriceMin = new System.Windows.Forms.TextBox();
			this.labelPriceMin = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAccept
			// 
			this.buttonAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonAccept.FlatAppearance.BorderSize = 0;
			this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAccept.Location = new System.Drawing.Point(79, 378);
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.Rounded = 0;
			this.buttonAccept.Size = new System.Drawing.Size(350, 31);
			this.buttonAccept.TabIndex = 50;
			this.buttonAccept.Text = "Fahrzeug";
			this.buttonAccept.UseVisualStyleBackColor = false;
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
			this.tabPage1.Controls.Add(this.textBox8);
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
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(514, 343);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Allgemeine Fahrzeuginformationen";
			// 
			// txtSeats
			// 
			this.txtSeats.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSeats.Location = new System.Drawing.Point(275, 209);
			this.txtSeats.Name = "txtSeats";
			this.txtSeats.Size = new System.Drawing.Size(210, 15);
			this.txtSeats.TabIndex = 14;
			// 
			// textBox8
			// 
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox8.Location = new System.Drawing.Point(275, 281);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(210, 15);
			this.textBox8.TabIndex = 16;
			// 
			// txtPosY
			// 
			this.txtPosY.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPosY.Location = new System.Drawing.Point(275, 137);
			this.txtPosY.Name = "txtPosY";
			this.txtPosY.Size = new System.Drawing.Size(210, 15);
			this.txtPosY.TabIndex = 12;
			// 
			// txtMaxTankFilling
			// 
			this.txtMaxTankFilling.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMaxTankFilling.Location = new System.Drawing.Point(275, 64);
			this.txtMaxTankFilling.Name = "txtMaxTankFilling";
			this.txtMaxTankFilling.Size = new System.Drawing.Size(210, 15);
			this.txtMaxTankFilling.TabIndex = 10;
			// 
			// txtPosX
			// 
			this.txtPosX.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPosX.Location = new System.Drawing.Point(275, 101);
			this.txtPosX.Name = "txtPosX";
			this.txtPosX.Size = new System.Drawing.Size(210, 15);
			this.txtPosX.TabIndex = 11;
			// 
			// txtTankFilling
			// 
			this.txtTankFilling.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTankFilling.Location = new System.Drawing.Point(275, 28);
			this.txtTankFilling.Name = "txtTankFilling";
			this.txtTankFilling.Size = new System.Drawing.Size(210, 15);
			this.txtTankFilling.TabIndex = 9;
			// 
			// txtNumberplate
			// 
			this.txtNumberplate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNumberplate.Location = new System.Drawing.Point(19, 137);
			this.txtNumberplate.Name = "txtNumberplate";
			this.txtNumberplate.Size = new System.Drawing.Size(210, 15);
			this.txtNumberplate.TabIndex = 4;
			// 
			// txtModel
			// 
			this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtModel.Location = new System.Drawing.Point(19, 101);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(210, 15);
			this.txtModel.TabIndex = 3;
			// 
			// txtPower
			// 
			this.txtPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPower.Location = new System.Drawing.Point(19, 281);
			this.txtPower.Name = "txtPower";
			this.txtPower.Size = new System.Drawing.Size(210, 15);
			this.txtPower.TabIndex = 8;
			// 
			// txtReg
			// 
			this.txtReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtReg.Location = new System.Drawing.Point(19, 209);
			this.txtReg.Name = "txtReg";
			this.txtReg.Size = new System.Drawing.Size(210, 15);
			this.txtReg.TabIndex = 6;
			// 
			// txtConstructionYear
			// 
			this.txtConstructionYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtConstructionYear.Location = new System.Drawing.Point(19, 173);
			this.txtConstructionYear.Name = "txtConstructionYear";
			this.txtConstructionYear.Size = new System.Drawing.Size(210, 15);
			this.txtConstructionYear.TabIndex = 5;
			// 
			// txtMileage
			// 
			this.txtMileage.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(514, 321);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Zubehör";
			// 
			// comboBrand
			// 
			this.comboBrand.BackColor = System.Drawing.SystemColors.Window;
			this.comboBrand.CausesValidation = false;
			this.comboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBrand.FormattingEnabled = true;
			this.comboBrand.Location = new System.Drawing.Point(19, 61);
			this.comboBrand.Name = "comboBrand";
			this.comboBrand.Size = new System.Drawing.Size(211, 21);
			this.comboBrand.TabIndex = 2;
			// 
			// dateTimeLastMaintenance
			// 
			this.dateTimeLastMaintenance.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimeLastMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimeLastMaintenance.Location = new System.Drawing.Point(275, 171);
			this.dateTimeLastMaintenance.Name = "dateTimeLastMaintenance";
			this.dateTimeLastMaintenance.Size = new System.Drawing.Size(210, 20);
			this.dateTimeLastMaintenance.TabIndex = 13;
			// 
			// comboFuel
			// 
			this.comboFuel.BackColor = System.Drawing.SystemColors.Window;
			this.comboFuel.CausesValidation = false;
			this.comboFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboFuel.FormattingEnabled = true;
			this.comboFuel.Location = new System.Drawing.Point(275, 242);
			this.comboFuel.Name = "comboFuel";
			this.comboFuel.Size = new System.Drawing.Size(210, 21);
			this.comboFuel.TabIndex = 15;
			// 
			// comboGear
			// 
			this.comboGear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboGear.FormattingEnabled = true;
			this.comboGear.Location = new System.Drawing.Point(19, 242);
			this.comboGear.Name = "comboGear";
			this.comboGear.Size = new System.Drawing.Size(210, 21);
			this.comboGear.TabIndex = 7;
			// 
			// txtPrice
			// 
			this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
			// txtPriceKilo
			// 
			this.txtPriceKilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
			// txtPriceMin
			// 
			this.txtPriceMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
			// EditDataViewVehicle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonAccept);
			this.Name = "EditDataViewVehicle";
			this.Size = new System.Drawing.Size(525, 425);
			this.Load += new System.EventHandler(this.EditDataViewVehicle_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private CustomControl.RoundButton buttonAccept;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox txtSeats;
		private System.Windows.Forms.TextBox textBox8;
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
	}
}
