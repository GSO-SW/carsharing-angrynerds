﻿namespace Carsharing
{
	partial class MainViewUserStatus
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
			this.labelWelcome = new System.Windows.Forms.Label();
			this.groupBoxCurrentBooking = new System.Windows.Forms.GroupBox();
			this.labelTotalCostText = new System.Windows.Forms.Label();
			this.labelTotalCost = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.watermarkTextBoxEndMileage = new CustomControl.WatermarkTextBox();
			this.labelStartMileageText = new System.Windows.Forms.Label();
			this.labelStartMileage = new System.Windows.Forms.Label();
			this.labelStartTimeText = new System.Windows.Forms.Label();
			this.labelStartTime = new System.Windows.Forms.Label();
			this.labelPriceMinText = new System.Windows.Forms.Label();
			this.labelPricePerKilometreText = new System.Windows.Forms.Label();
			this.labelPriceMin = new System.Windows.Forms.Label();
			this.labelPricePerKilometre = new System.Windows.Forms.Label();
			this.labelBasePriceText = new System.Windows.Forms.Label();
			this.labelBasePrice = new System.Windows.Forms.Label();
			this.labelNumberplateText = new System.Windows.Forms.Label();
			this.labelCarText = new System.Windows.Forms.Label();
			this.labelCar = new System.Windows.Forms.Label();
			this.labelNumberplate = new System.Windows.Forms.Label();
			this.buttonCloseCurrentBooking = new CustomControl.RoundButton();
			this.buttonUserDelete = new CustomControl.RoundButton();
			this.buttonUserEdit = new CustomControl.RoundButton();
			this.listBoxBooking = new System.Windows.Forms.ListBox();
			this.labelEndMileageText = new System.Windows.Forms.Label();
			this.labelEndTimeText = new System.Windows.Forms.Label();
			this.labelEndTime = new System.Windows.Forms.Label();
			this.groupBoxCurrentBooking.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelWelcome
			// 
			this.labelWelcome.AutoSize = true;
			this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWelcome.Location = new System.Drawing.Point(3, 6);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Size = new System.Drawing.Size(118, 25);
			this.labelWelcome.TabIndex = 2;
			this.labelWelcome.Text = "Willkommen";
			// 
			// groupBoxCurrentBooking
			// 
			this.groupBoxCurrentBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.groupBoxCurrentBooking.Controls.Add(this.labelEndTimeText);
			this.groupBoxCurrentBooking.Controls.Add(this.labelEndTime);
			this.groupBoxCurrentBooking.Controls.Add(this.labelEndMileageText);
			this.groupBoxCurrentBooking.Controls.Add(this.labelTotalCostText);
			this.groupBoxCurrentBooking.Controls.Add(this.labelTotalCost);
			this.groupBoxCurrentBooking.Controls.Add(this.label1);
			this.groupBoxCurrentBooking.Controls.Add(this.watermarkTextBoxEndMileage);
			this.groupBoxCurrentBooking.Controls.Add(this.labelStartMileageText);
			this.groupBoxCurrentBooking.Controls.Add(this.labelStartMileage);
			this.groupBoxCurrentBooking.Controls.Add(this.labelStartTimeText);
			this.groupBoxCurrentBooking.Controls.Add(this.labelStartTime);
			this.groupBoxCurrentBooking.Controls.Add(this.labelPriceMinText);
			this.groupBoxCurrentBooking.Controls.Add(this.labelPricePerKilometreText);
			this.groupBoxCurrentBooking.Controls.Add(this.labelPriceMin);
			this.groupBoxCurrentBooking.Controls.Add(this.labelPricePerKilometre);
			this.groupBoxCurrentBooking.Controls.Add(this.labelBasePriceText);
			this.groupBoxCurrentBooking.Controls.Add(this.labelBasePrice);
			this.groupBoxCurrentBooking.Controls.Add(this.labelNumberplateText);
			this.groupBoxCurrentBooking.Controls.Add(this.labelCarText);
			this.groupBoxCurrentBooking.Controls.Add(this.labelCar);
			this.groupBoxCurrentBooking.Controls.Add(this.labelNumberplate);
			this.groupBoxCurrentBooking.Controls.Add(this.buttonCloseCurrentBooking);
			this.groupBoxCurrentBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBoxCurrentBooking.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxCurrentBooking.Location = new System.Drawing.Point(337, 84);
			this.groupBoxCurrentBooking.Name = "groupBoxCurrentBooking";
			this.groupBoxCurrentBooking.Size = new System.Drawing.Size(560, 488);
			this.groupBoxCurrentBooking.TabIndex = 72;
			this.groupBoxCurrentBooking.TabStop = false;
			this.groupBoxCurrentBooking.Text = "Buchung";
			// 
			// labelTotalCostText
			// 
			this.labelTotalCostText.AutoSize = true;
			this.labelTotalCostText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelTotalCostText.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelTotalCostText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelTotalCostText.Location = new System.Drawing.Point(357, 256);
			this.labelTotalCostText.Name = "labelTotalCostText";
			this.labelTotalCostText.Size = new System.Drawing.Size(105, 19);
			this.labelTotalCostText.TabIndex = 75;
			this.labelTotalCostText.Text = "----------------";
			// 
			// labelTotalCost
			// 
			this.labelTotalCost.AutoSize = true;
			this.labelTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelTotalCost.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelTotalCost.Location = new System.Drawing.Point(357, 237);
			this.labelTotalCost.Name = "labelTotalCost";
			this.labelTotalCost.Size = new System.Drawing.Size(85, 19);
			this.labelTotalCost.TabIndex = 74;
			this.labelTotalCost.Text = "Gesamtpreis";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(357, 186);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 19);
			this.label1.TabIndex = 73;
			this.label1.Text = "Endkilometerstand";
			// 
			// watermarkTextBoxEndMileage
			// 
			this.watermarkTextBoxEndMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.watermarkTextBoxEndMileage.Location = new System.Drawing.Point(361, 208);
			this.watermarkTextBoxEndMileage.Name = "watermarkTextBoxEndMileage";
			this.watermarkTextBoxEndMileage.Password = false;
			this.watermarkTextBoxEndMileage.Size = new System.Drawing.Size(91, 22);
			this.watermarkTextBoxEndMileage.TabIndex = 7;
			this.watermarkTextBoxEndMileage.Watermark = "Stand in Km";
			// 
			// labelStartMileageText
			// 
			this.labelStartMileageText.AutoSize = true;
			this.labelStartMileageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelStartMileageText.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelStartMileageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelStartMileageText.Location = new System.Drawing.Point(357, 153);
			this.labelStartMileageText.Name = "labelStartMileageText";
			this.labelStartMileageText.Size = new System.Drawing.Size(105, 19);
			this.labelStartMileageText.TabIndex = 71;
			this.labelStartMileageText.Text = "----------------";
			// 
			// labelStartMileage
			// 
			this.labelStartMileage.AutoSize = true;
			this.labelStartMileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelStartMileage.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelStartMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelStartMileage.Location = new System.Drawing.Point(357, 134);
			this.labelStartMileage.Name = "labelStartMileage";
			this.labelStartMileage.Size = new System.Drawing.Size(129, 19);
			this.labelStartMileage.TabIndex = 70;
			this.labelStartMileage.Text = "Startkilometerstand";
			// 
			// labelStartTimeText
			// 
			this.labelStartTimeText.AutoSize = true;
			this.labelStartTimeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelStartTimeText.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelStartTimeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelStartTimeText.Location = new System.Drawing.Point(357, 52);
			this.labelStartTimeText.Name = "labelStartTimeText";
			this.labelStartTimeText.Size = new System.Drawing.Size(105, 19);
			this.labelStartTimeText.TabIndex = 67;
			this.labelStartTimeText.Text = "----------------";
			// 
			// labelStartTime
			// 
			this.labelStartTime.AutoSize = true;
			this.labelStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelStartTime.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelStartTime.Location = new System.Drawing.Point(357, 33);
			this.labelStartTime.Name = "labelStartTime";
			this.labelStartTime.Size = new System.Drawing.Size(95, 19);
			this.labelStartTime.TabIndex = 66;
			this.labelStartTime.Text = "Startzeitpunkt";
			// 
			// labelPriceMinText
			// 
			this.labelPriceMinText.AutoSize = true;
			this.labelPriceMinText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPriceMinText.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPriceMinText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPriceMinText.Location = new System.Drawing.Point(113, 255);
			this.labelPriceMinText.Name = "labelPriceMinText";
			this.labelPriceMinText.Size = new System.Drawing.Size(105, 19);
			this.labelPriceMinText.TabIndex = 65;
			this.labelPriceMinText.Text = "----------------";
			// 
			// labelPricePerKilometreText
			// 
			this.labelPricePerKilometreText.AutoSize = true;
			this.labelPricePerKilometreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPricePerKilometreText.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPricePerKilometreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPricePerKilometreText.Location = new System.Drawing.Point(113, 204);
			this.labelPricePerKilometreText.Name = "labelPricePerKilometreText";
			this.labelPricePerKilometreText.Size = new System.Drawing.Size(105, 19);
			this.labelPricePerKilometreText.TabIndex = 64;
			this.labelPricePerKilometreText.Text = "----------------";
			// 
			// labelPriceMin
			// 
			this.labelPriceMin.AutoSize = true;
			this.labelPriceMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPriceMin.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPriceMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPriceMin.Location = new System.Drawing.Point(113, 236);
			this.labelPriceMin.Name = "labelPriceMin";
			this.labelPriceMin.Size = new System.Drawing.Size(74, 19);
			this.labelPriceMin.TabIndex = 63;
			this.labelPriceMin.Text = "Preis / min";
			// 
			// labelPricePerKilometre
			// 
			this.labelPricePerKilometre.AutoSize = true;
			this.labelPricePerKilometre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelPricePerKilometre.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelPricePerKilometre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPricePerKilometre.Location = new System.Drawing.Point(113, 185);
			this.labelPricePerKilometre.Name = "labelPricePerKilometre";
			this.labelPricePerKilometre.Size = new System.Drawing.Size(70, 19);
			this.labelPricePerKilometre.TabIndex = 61;
			this.labelPricePerKilometre.Text = "Preis / km";
			// 
			// labelBasePriceText
			// 
			this.labelBasePriceText.AutoSize = true;
			this.labelBasePriceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelBasePriceText.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelBasePriceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelBasePriceText.Location = new System.Drawing.Point(113, 153);
			this.labelBasePriceText.Name = "labelBasePriceText";
			this.labelBasePriceText.Size = new System.Drawing.Size(105, 19);
			this.labelBasePriceText.TabIndex = 46;
			this.labelBasePriceText.Text = "----------------";
			// 
			// labelBasePrice
			// 
			this.labelBasePrice.AutoSize = true;
			this.labelBasePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelBasePrice.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelBasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelBasePrice.Location = new System.Drawing.Point(113, 134);
			this.labelBasePrice.Name = "labelBasePrice";
			this.labelBasePrice.Size = new System.Drawing.Size(77, 19);
			this.labelBasePrice.TabIndex = 45;
			this.labelBasePrice.Text = "Grundpreis";
			// 
			// labelNumberplateText
			// 
			this.labelNumberplateText.AutoSize = true;
			this.labelNumberplateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelNumberplateText.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelNumberplateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelNumberplateText.Location = new System.Drawing.Point(113, 101);
			this.labelNumberplateText.Name = "labelNumberplateText";
			this.labelNumberplateText.Size = new System.Drawing.Size(105, 19);
			this.labelNumberplateText.TabIndex = 44;
			this.labelNumberplateText.Text = "----------------";
			// 
			// labelCarText
			// 
			this.labelCarText.AutoSize = true;
			this.labelCarText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelCarText.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelCarText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelCarText.Location = new System.Drawing.Point(113, 52);
			this.labelCarText.Name = "labelCarText";
			this.labelCarText.Size = new System.Drawing.Size(105, 19);
			this.labelCarText.TabIndex = 43;
			this.labelCarText.Text = "----------------";
			// 
			// labelCar
			// 
			this.labelCar.AutoSize = true;
			this.labelCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelCar.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelCar.Location = new System.Drawing.Point(113, 33);
			this.labelCar.Name = "labelCar";
			this.labelCar.Size = new System.Drawing.Size(39, 19);
			this.labelCar.TabIndex = 32;
			this.labelCar.Text = "Auto";
			// 
			// labelNumberplate
			// 
			this.labelNumberplate.AutoSize = true;
			this.labelNumberplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelNumberplate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelNumberplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelNumberplate.Location = new System.Drawing.Point(113, 82);
			this.labelNumberplate.Name = "labelNumberplate";
			this.labelNumberplate.Size = new System.Drawing.Size(85, 19);
			this.labelNumberplate.TabIndex = 31;
			this.labelNumberplate.Text = "Kennzeichen";
			// 
			// buttonCloseCurrentBooking
			// 
			this.buttonCloseCurrentBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonCloseCurrentBooking.FlatAppearance.BorderSize = 0;
			this.buttonCloseCurrentBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCloseCurrentBooking.Location = new System.Drawing.Point(386, 302);
			this.buttonCloseCurrentBooking.Name = "buttonCloseCurrentBooking";
			this.buttonCloseCurrentBooking.Size = new System.Drawing.Size(122, 28);
			this.buttonCloseCurrentBooking.TabIndex = 8;
			this.buttonCloseCurrentBooking.Text = "Buchung beenden";
			this.buttonCloseCurrentBooking.UseVisualStyleBackColor = false;
			this.buttonCloseCurrentBooking.Click += new System.EventHandler(this.buttonCloseCurrentBooking_Click);
			// 
			// buttonUserDelete
			// 
			this.buttonUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonUserDelete.FlatAppearance.BorderSize = 0;
			this.buttonUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUserDelete.Location = new System.Drawing.Point(775, 37);
			this.buttonUserDelete.Name = "buttonUserDelete";
			this.buttonUserDelete.Size = new System.Drawing.Size(122, 28);
			this.buttonUserDelete.TabIndex = 6;
			this.buttonUserDelete.Text = "Profil löschen";
			this.buttonUserDelete.UseVisualStyleBackColor = false;
			this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
			// 
			// buttonUserEdit
			// 
			this.buttonUserEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
			this.buttonUserEdit.FlatAppearance.BorderSize = 0;
			this.buttonUserEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUserEdit.Location = new System.Drawing.Point(775, 3);
			this.buttonUserEdit.Name = "buttonUserEdit";
			this.buttonUserEdit.Size = new System.Drawing.Size(122, 28);
			this.buttonUserEdit.TabIndex = 5;
			this.buttonUserEdit.Text = "Profil bearbeiten";
			this.buttonUserEdit.UseVisualStyleBackColor = false;
			this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEdit_Click);
			// 
			// listBoxBooking
			// 
			this.listBoxBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.listBoxBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.listBoxBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBoxBooking.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxBooking.FormattingEnabled = true;
			this.listBoxBooking.ItemHeight = 20;
			this.listBoxBooking.Location = new System.Drawing.Point(8, 84);
			this.listBoxBooking.Name = "listBoxBooking";
			this.listBoxBooking.Size = new System.Drawing.Size(275, 460);
			this.listBoxBooking.TabIndex = 73;
			this.listBoxBooking.SelectedIndexChanged += new System.EventHandler(this.listBoxBooking_SelectedIndexChanged);
			// 
			// labelEndMileageText
			// 
			this.labelEndMileageText.AutoSize = true;
			this.labelEndMileageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelEndMileageText.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelEndMileageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelEndMileageText.Location = new System.Drawing.Point(357, 205);
			this.labelEndMileageText.Name = "labelEndMileageText";
			this.labelEndMileageText.Size = new System.Drawing.Size(105, 19);
			this.labelEndMileageText.TabIndex = 76;
			this.labelEndMileageText.Text = "----------------";
			// 
			// labelEndTimeText
			// 
			this.labelEndTimeText.AutoSize = true;
			this.labelEndTimeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelEndTimeText.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelEndTimeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelEndTimeText.Location = new System.Drawing.Point(357, 101);
			this.labelEndTimeText.Name = "labelEndTimeText";
			this.labelEndTimeText.Size = new System.Drawing.Size(105, 19);
			this.labelEndTimeText.TabIndex = 78;
			this.labelEndTimeText.Text = "----------------";
			// 
			// labelEndTime
			// 
			this.labelEndTime.AutoSize = true;
			this.labelEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelEndTime.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.labelEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelEndTime.Location = new System.Drawing.Point(357, 82);
			this.labelEndTime.Name = "labelEndTime";
			this.labelEndTime.Size = new System.Drawing.Size(89, 19);
			this.labelEndTime.TabIndex = 77;
			this.labelEndTime.Text = "Endzeitpunkt";
			// 
			// MainViewUserStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.groupBoxCurrentBooking);
			this.Controls.Add(this.buttonUserDelete);
			this.Controls.Add(this.buttonUserEdit);
			this.Controls.Add(this.labelWelcome);
			this.Controls.Add(this.listBoxBooking);
			this.Name = "MainViewUserStatus";
			this.Size = new System.Drawing.Size(900, 575);
			this.groupBoxCurrentBooking.ResumeLayout(false);
			this.groupBoxCurrentBooking.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelWelcome;
		private CustomControl.RoundButton buttonUserEdit;
		private CustomControl.RoundButton buttonUserDelete;
        private CustomControl.RoundButton buttonCloseCurrentBooking;
        private System.Windows.Forms.GroupBox groupBoxCurrentBooking;
        private System.Windows.Forms.Label labelNumberplate;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Label labelCarText;
        private System.Windows.Forms.Label labelNumberplateText;
        private System.Windows.Forms.Label labelBasePriceText;
        private System.Windows.Forms.Label labelBasePrice;
        private System.Windows.Forms.Label labelPricePerKilometre;
        private System.Windows.Forms.Label labelPricePerKilometreText;
        private System.Windows.Forms.Label labelPriceMin;
        private System.Windows.Forms.Label labelPriceMinText;
        private System.Windows.Forms.Label labelStartTimeText;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelStartMileageText;
        private System.Windows.Forms.Label labelStartMileage;
        private System.Windows.Forms.Label labelTotalCostText;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label label1;
        private CustomControl.WatermarkTextBox watermarkTextBoxEndMileage;
        private System.Windows.Forms.ListBox listBoxBooking;
		private System.Windows.Forms.Label labelEndMileageText;
		private System.Windows.Forms.Label labelEndTimeText;
		private System.Windows.Forms.Label labelEndTime;
	}
}
