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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
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
			this.buttonRefresh = new CustomControl.RoundButton();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonVehicleDelete
			// 
			this.buttonVehicleDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonVehicleDelete.FlatAppearance.BorderSize = 0;
			this.buttonVehicleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonVehicleDelete.Location = new System.Drawing.Point(435, 544);
			this.buttonVehicleDelete.Name = "buttonVehicleDelete";
			this.buttonVehicleDelete.Rounded = 0;
			this.buttonVehicleDelete.Size = new System.Drawing.Size(150, 28);
			this.buttonVehicleDelete.TabIndex = 5;
			this.buttonVehicleDelete.Text = "Fahrzeug löschen";
			this.buttonVehicleDelete.UseVisualStyleBackColor = false;
			// 
			// buttonVehicleEdit
			// 
			this.buttonVehicleEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonVehicleEdit.Enabled = false;
			this.buttonVehicleEdit.FlatAppearance.BorderSize = 0;
			this.buttonVehicleEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonVehicleEdit.Location = new System.Drawing.Point(591, 544);
			this.buttonVehicleEdit.Name = "buttonVehicleEdit";
			this.buttonVehicleEdit.Rounded = 0;
			this.buttonVehicleEdit.Size = new System.Drawing.Size(150, 28);
			this.buttonVehicleEdit.TabIndex = 4;
			this.buttonVehicleEdit.Text = "Fahrzeug bearbeiten";
			this.buttonVehicleEdit.UseVisualStyleBackColor = false;
			this.buttonVehicleEdit.Click += new System.EventHandler(this.buttonVehicleEdit_Click);
			// 
			// buttonVehicleAdd
			// 
			this.buttonVehicleAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonVehicleAdd.FlatAppearance.BorderSize = 0;
			this.buttonVehicleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonVehicleAdd.Location = new System.Drawing.Point(747, 544);
			this.buttonVehicleAdd.Name = "buttonVehicleAdd";
			this.buttonVehicleAdd.Rounded = 0;
			this.buttonVehicleAdd.Size = new System.Drawing.Size(150, 28);
			this.buttonVehicleAdd.TabIndex = 3;
			this.buttonVehicleAdd.Text = "Fahrzeug hinzufügen";
			this.buttonVehicleAdd.UseVisualStyleBackColor = false;
			this.buttonVehicleAdd.Click += new System.EventHandler(this.buttonAddVehicle_Click);
			// 
			// listVehicle
			// 
			this.listVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.listVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listVehicle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listVehicle.FormattingEnabled = true;
			this.listVehicle.ItemHeight = 20;
			this.listVehicle.Location = new System.Drawing.Point(0, 0);
			this.listVehicle.Name = "listVehicle";
			this.listVehicle.Size = new System.Drawing.Size(242, 580);
			this.listVehicle.TabIndex = 7;
			this.listVehicle.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listVehicle_DrawItem);
			this.listVehicle.SelectedIndexChanged += new System.EventHandler(this.listVehicle_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(242, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(658, 537);
			this.tabControl1.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
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
			this.tabPage1.Size = new System.Drawing.Size(650, 511);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Allgemeine Fahrzeuginformationen";
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
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(650, 511);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Zubehör";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonRefresh.FlatAppearance.BorderSize = 0;
			this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRefresh.Location = new System.Drawing.Point(243, 542);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Rounded = 0;
			this.buttonRefresh.Size = new System.Drawing.Size(94, 28);
			this.buttonRefresh.TabIndex = 9;
			this.buttonRefresh.Text = "Aktualisieren";
			this.buttonRefresh.UseVisualStyleBackColor = false;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// MainViewAdminVehicle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.listVehicle);
			this.Controls.Add(this.buttonVehicleDelete);
			this.Controls.Add(this.buttonVehicleEdit);
			this.Controls.Add(this.buttonVehicleAdd);
			this.Name = "MainViewAdminVehicle";
			this.Size = new System.Drawing.Size(900, 575);
			this.Load += new System.EventHandler(this.AdminVehicles_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private CustomControl.RoundButton buttonVehicleAdd;
		private CustomControl.RoundButton buttonVehicleEdit;
		private CustomControl.RoundButton buttonVehicleDelete;
		private System.Windows.Forms.ListBox listVehicle;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label labelMileage;
		private System.Windows.Forms.Label labelNumberplate;
		private System.Windows.Forms.Label labelModel;
		private System.Windows.Forms.Label labelBrand;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label labelPower;
		private System.Windows.Forms.Label labelGear;
		private System.Windows.Forms.Label labelReg;
		private System.Windows.Forms.Label labelConstructionYear;
		private System.Windows.Forms.Label labelFuelCon;
		private System.Windows.Forms.Label labelFuel;
		private System.Windows.Forms.Label labelSeats;
		private System.Windows.Forms.Label labelLastMaint;
		private System.Windows.Forms.Label labelPosY;
		private System.Windows.Forms.Label labelTankFilling;
		private System.Windows.Forms.Label labelMaxTankFilling;
		private System.Windows.Forms.Label labelPosX;
		private System.Windows.Forms.Label txtMileage;
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
		private CustomControl.RoundButton buttonRefresh;
	}
}
