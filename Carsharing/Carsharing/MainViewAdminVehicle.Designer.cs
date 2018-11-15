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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonAddVehicle = new CustomControl.RoundButton();
			this.roundButton1 = new CustomControl.RoundButton();
			this.roundButton2 = new CustomControl.RoundButton();
			this.available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.numberPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.power = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.basicPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pricePerKilometre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pricePerMinute = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tankFilling = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maxTankFilling = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.constructionYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gearShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fuelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fuelComsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airConditioner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.cruiseControl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.radio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.bluetooth = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.usb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.cdPlayer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.navi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.abs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ESP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.seatHeating = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.winterTire = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.smoker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.available,
            this.numberPlate,
            this.brand,
            this.model,
            this.power,
            this.mileage,
            this.lastMaintenance,
            this.basicPrice,
            this.pricePerKilometre,
            this.pricePerMinute,
            this.tankFilling,
            this.maxTankFilling,
            this.position,
            this.constructionYear,
            this.gearShift,
            this.registration,
            this.seats,
            this.fuelType,
            this.fuelComsumption,
            this.airConditioner,
            this.cruiseControl,
            this.radio,
            this.bluetooth,
            this.usb,
            this.cdPlayer,
            this.navi,
            this.abs,
            this.ESP,
            this.seatHeating,
            this.winterTire,
            this.smoker});
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(900, 538);
			this.dataGridView1.TabIndex = 2;
			// 
			// buttonAddVehicle
			// 
			this.buttonAddVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonAddVehicle.FlatAppearance.BorderSize = 0;
			this.buttonAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddVehicle.Location = new System.Drawing.Point(753, 544);
			this.buttonAddVehicle.Name = "buttonAddVehicle";
			this.buttonAddVehicle.Rounded = 0;
			this.buttonAddVehicle.Size = new System.Drawing.Size(144, 28);
			this.buttonAddVehicle.TabIndex = 3;
			this.buttonAddVehicle.Text = "Fahrzeug hinzufügen";
			this.buttonAddVehicle.UseVisualStyleBackColor = false;
			this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
			// 
			// roundButton1
			// 
			this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.roundButton1.FlatAppearance.BorderSize = 0;
			this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.roundButton1.Location = new System.Drawing.Point(603, 544);
			this.roundButton1.Name = "roundButton1";
			this.roundButton1.Rounded = 0;
			this.roundButton1.Size = new System.Drawing.Size(144, 28);
			this.roundButton1.TabIndex = 4;
			this.roundButton1.Text = "Fahrzeug bearbeiten";
			this.roundButton1.UseVisualStyleBackColor = false;
			// 
			// roundButton2
			// 
			this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.roundButton2.FlatAppearance.BorderSize = 0;
			this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.roundButton2.Location = new System.Drawing.Point(453, 544);
			this.roundButton2.Name = "roundButton2";
			this.roundButton2.Rounded = 0;
			this.roundButton2.Size = new System.Drawing.Size(144, 28);
			this.roundButton2.TabIndex = 5;
			this.roundButton2.Text = "Fahrzeug löschen";
			this.roundButton2.UseVisualStyleBackColor = false;
			// 
			// available
			// 
			this.available.HeaderText = "Verfügbarkeit";
			this.available.Name = "available";
			this.available.ReadOnly = true;
			this.available.Width = 76;
			// 
			// numberPlate
			// 
			this.numberPlate.HeaderText = "Nummernschild";
			this.numberPlate.Name = "numberPlate";
			this.numberPlate.ReadOnly = true;
			this.numberPlate.Width = 104;
			// 
			// brand
			// 
			this.brand.HeaderText = "Marke";
			this.brand.Name = "brand";
			this.brand.ReadOnly = true;
			this.brand.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.brand.Width = 62;
			// 
			// model
			// 
			this.model.HeaderText = "Modell";
			this.model.Name = "model";
			this.model.ReadOnly = true;
			this.model.Width = 63;
			// 
			// power
			// 
			this.power.HeaderText = "Leistung";
			this.power.Name = "power";
			this.power.ReadOnly = true;
			this.power.Width = 72;
			// 
			// mileage
			// 
			this.mileage.HeaderText = "Kilometerstand";
			this.mileage.Name = "mileage";
			this.mileage.ReadOnly = true;
			this.mileage.Width = 101;
			// 
			// lastMaintenance
			// 
			this.lastMaintenance.HeaderText = "Letzte Wartung";
			this.lastMaintenance.Name = "lastMaintenance";
			this.lastMaintenance.ReadOnly = true;
			this.lastMaintenance.Width = 105;
			// 
			// basicPrice
			// 
			this.basicPrice.HeaderText = "Grundpreis";
			this.basicPrice.Name = "basicPrice";
			this.basicPrice.ReadOnly = true;
			this.basicPrice.Width = 83;
			// 
			// pricePerKilometre
			// 
			this.pricePerKilometre.HeaderText = "Preis / km";
			this.pricePerKilometre.Name = "pricePerKilometre";
			this.pricePerKilometre.ReadOnly = true;
			this.pricePerKilometre.Width = 80;
			// 
			// pricePerMinute
			// 
			this.pricePerMinute.HeaderText = "Preis / min";
			this.pricePerMinute.Name = "pricePerMinute";
			this.pricePerMinute.ReadOnly = true;
			this.pricePerMinute.Width = 82;
			// 
			// tankFilling
			// 
			this.tankFilling.HeaderText = "Tankfüllung";
			this.tankFilling.Name = "tankFilling";
			this.tankFilling.ReadOnly = true;
			this.tankFilling.Width = 88;
			// 
			// maxTankFilling
			// 
			this.maxTankFilling.HeaderText = "Maximale Tankfüllung";
			this.maxTankFilling.Name = "maxTankFilling";
			this.maxTankFilling.ReadOnly = true;
			this.maxTankFilling.Width = 135;
			// 
			// position
			// 
			this.position.HeaderText = "Position";
			this.position.Name = "position";
			this.position.ReadOnly = true;
			this.position.Width = 69;
			// 
			// constructionYear
			// 
			this.constructionYear.HeaderText = "Baujahr";
			this.constructionYear.Name = "constructionYear";
			this.constructionYear.ReadOnly = true;
			this.constructionYear.Width = 68;
			// 
			// gearShift
			// 
			this.gearShift.HeaderText = "Schaltung";
			this.gearShift.Name = "gearShift";
			this.gearShift.ReadOnly = true;
			this.gearShift.Width = 80;
			// 
			// registration
			// 
			this.registration.HeaderText = "Erstzulassung";
			this.registration.Name = "registration";
			this.registration.ReadOnly = true;
			this.registration.Width = 97;
			// 
			// seats
			// 
			this.seats.HeaderText = "Sitze";
			this.seats.Name = "seats";
			this.seats.ReadOnly = true;
			this.seats.Width = 55;
			// 
			// fuelType
			// 
			this.fuelType.HeaderText = "Kraftstoffart";
			this.fuelType.Name = "fuelType";
			this.fuelType.ReadOnly = true;
			this.fuelType.Width = 86;
			// 
			// fuelComsumption
			// 
			this.fuelComsumption.HeaderText = "Kraftstoffverbrauch";
			this.fuelComsumption.Name = "fuelComsumption";
			this.fuelComsumption.ReadOnly = true;
			this.fuelComsumption.Width = 122;
			// 
			// airConditioner
			// 
			this.airConditioner.HeaderText = "Klimaanlage";
			this.airConditioner.Name = "airConditioner";
			this.airConditioner.ReadOnly = true;
			this.airConditioner.Width = 70;
			// 
			// cruiseControl
			// 
			this.cruiseControl.HeaderText = "Tempomat";
			this.cruiseControl.Name = "cruiseControl";
			this.cruiseControl.ReadOnly = true;
			this.cruiseControl.Width = 63;
			// 
			// radio
			// 
			this.radio.HeaderText = "Radio";
			this.radio.Name = "radio";
			this.radio.ReadOnly = true;
			this.radio.Width = 41;
			// 
			// bluetooth
			// 
			this.bluetooth.HeaderText = "Bluetooth";
			this.bluetooth.Name = "bluetooth";
			this.bluetooth.ReadOnly = true;
			this.bluetooth.Width = 58;
			// 
			// usb
			// 
			this.usb.HeaderText = "Usb";
			this.usb.Name = "usb";
			this.usb.ReadOnly = true;
			this.usb.Width = 32;
			// 
			// cdPlayer
			// 
			this.cdPlayer.HeaderText = "CD-Player";
			this.cdPlayer.Name = "cdPlayer";
			this.cdPlayer.ReadOnly = true;
			this.cdPlayer.Width = 60;
			// 
			// navi
			// 
			this.navi.HeaderText = "Navi";
			this.navi.Name = "navi";
			this.navi.ReadOnly = true;
			this.navi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.navi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.navi.Width = 54;
			// 
			// abs
			// 
			this.abs.HeaderText = "ABS";
			this.abs.Name = "abs";
			this.abs.ReadOnly = true;
			this.abs.Width = 34;
			// 
			// ESP
			// 
			this.ESP.HeaderText = "ESP";
			this.ESP.Name = "ESP";
			this.ESP.ReadOnly = true;
			this.ESP.Width = 34;
			// 
			// seatHeating
			// 
			this.seatHeating.HeaderText = "Sitzheizung";
			this.seatHeating.Name = "seatHeating";
			this.seatHeating.ReadOnly = true;
			this.seatHeating.Width = 67;
			// 
			// winterTire
			// 
			this.winterTire.HeaderText = "Winterreifen";
			this.winterTire.Name = "winterTire";
			this.winterTire.ReadOnly = true;
			this.winterTire.Width = 70;
			// 
			// smoker
			// 
			this.smoker.HeaderText = "Raucher";
			this.smoker.Name = "smoker";
			this.smoker.ReadOnly = true;
			this.smoker.Width = 54;
			// 
			// MainViewAdminVehicle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.roundButton2);
			this.Controls.Add(this.roundButton1);
			this.Controls.Add(this.buttonAddVehicle);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainViewAdminVehicle";
			this.Size = new System.Drawing.Size(900, 575);
			this.Load += new System.EventHandler(this.AdminVehicles_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridView1;
		private CustomControl.RoundButton buttonAddVehicle;
		private CustomControl.RoundButton roundButton1;
		private CustomControl.RoundButton roundButton2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn available;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberPlate;
		private System.Windows.Forms.DataGridViewTextBoxColumn brand;
		private System.Windows.Forms.DataGridViewTextBoxColumn model;
		private System.Windows.Forms.DataGridViewTextBoxColumn power;
		private System.Windows.Forms.DataGridViewTextBoxColumn mileage;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastMaintenance;
		private System.Windows.Forms.DataGridViewTextBoxColumn basicPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn pricePerKilometre;
		private System.Windows.Forms.DataGridViewTextBoxColumn pricePerMinute;
		private System.Windows.Forms.DataGridViewTextBoxColumn tankFilling;
		private System.Windows.Forms.DataGridViewTextBoxColumn maxTankFilling;
		private System.Windows.Forms.DataGridViewTextBoxColumn position;
		private System.Windows.Forms.DataGridViewTextBoxColumn constructionYear;
		private System.Windows.Forms.DataGridViewTextBoxColumn gearShift;
		private System.Windows.Forms.DataGridViewTextBoxColumn registration;
		private System.Windows.Forms.DataGridViewTextBoxColumn seats;
		private System.Windows.Forms.DataGridViewTextBoxColumn fuelType;
		private System.Windows.Forms.DataGridViewTextBoxColumn fuelComsumption;
		private System.Windows.Forms.DataGridViewCheckBoxColumn airConditioner;
		private System.Windows.Forms.DataGridViewCheckBoxColumn cruiseControl;
		private System.Windows.Forms.DataGridViewCheckBoxColumn radio;
		private System.Windows.Forms.DataGridViewCheckBoxColumn bluetooth;
		private System.Windows.Forms.DataGridViewCheckBoxColumn usb;
		private System.Windows.Forms.DataGridViewCheckBoxColumn cdPlayer;
		private System.Windows.Forms.DataGridViewCheckBoxColumn navi;
		private System.Windows.Forms.DataGridViewCheckBoxColumn abs;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ESP;
		private System.Windows.Forms.DataGridViewCheckBoxColumn seatHeating;
		private System.Windows.Forms.DataGridViewCheckBoxColumn winterTire;
		private System.Windows.Forms.DataGridViewCheckBoxColumn smoker;
	}
}
