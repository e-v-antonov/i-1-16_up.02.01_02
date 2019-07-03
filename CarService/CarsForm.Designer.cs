namespace CarService
{
    partial class CarsForm
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
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.tbSearchFiltration = new System.Windows.Forms.TextBox();
            this.gbSearchFiltration = new System.Windows.Forms.GroupBox();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.gbManipulation = new System.Windows.Forms.GroupBox();
            this.pnClientFormKlients = new System.Windows.Forms.Panel();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.pnColorYearMade = new System.Windows.Forms.Panel();
            this.tbYearMade = new System.Windows.Forms.TextBox();
            this.lblYearMade = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.pnBrandModel = new System.Windows.Forms.Panel();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnRegVim = new System.Windows.Forms.Panel();
            this.tbVim = new System.Windows.Forms.TextBox();
            this.lblVim = new System.Windows.Forms.Label();
            this.tbRegisterSign = new System.Windows.Forms.TextBox();
            this.lblRegistrationPlate = new System.Windows.Forms.Label();
            this.pnManipulation = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblRepairCar = new System.Windows.Forms.Label();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.gbSearchFiltration.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbManipulation.SuspendLayout();
            this.pnClientFormKlients.SuspendLayout();
            this.pnColorYearMade.SuspendLayout();
            this.pnBrandModel.SuspendLayout();
            this.pnRegVim.SuspendLayout();
            this.pnManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(684, 19);
            this.chbFiltration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(145, 21);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            this.chbFiltration.CheckedChanged += new System.EventHandler(this.chbFiltration_CheckedChanged);
            // 
            // tbSearchFiltration
            // 
            this.tbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFiltration.Location = new System.Drawing.Point(4, 19);
            this.tbSearchFiltration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearchFiltration.Name = "tbSearchFiltration";
            this.tbSearchFiltration.Size = new System.Drawing.Size(680, 22);
            this.tbSearchFiltration.TabIndex = 0;
            this.tbSearchFiltration.Text = "Введите данные автомобиля...";
            this.tbSearchFiltration.Click += new System.EventHandler(this.tbSearchFiltration_Click);
            this.tbSearchFiltration.TextChanged += new System.EventHandler(this.tbSearchFiltration_TextChanged);
            this.tbSearchFiltration.Leave += new System.EventHandler(this.tbSearchFiltration_Leave);
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFiltration);
            this.gbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchFiltration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSearchFiltration.Size = new System.Drawing.Size(833, 47);
            this.gbSearchFiltration.TabIndex = 45;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnCancel);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 518);
            this.pnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(833, 31);
            this.pnCancel.TabIndex = 49;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(612, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(221, 31);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnErrors
            // 
            this.btnErrors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnErrors.Location = new System.Drawing.Point(0, 0);
            this.btnErrors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Size = new System.Drawing.Size(221, 31);
            this.btnErrors.TabIndex = 35;
            this.btnErrors.Text = "Ошибки";
            this.btnErrors.UseVisualStyleBackColor = true;
            this.btnErrors.Click += new System.EventHandler(this.btnErrors_Click);
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.pnClientFormKlients);
            this.gbManipulation.Controls.Add(this.pnColorYearMade);
            this.gbManipulation.Controls.Add(this.pnBrandModel);
            this.gbManipulation.Controls.Add(this.pnRegVim);
            this.gbManipulation.Controls.Add(this.pnManipulation);
            this.gbManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManipulation.Location = new System.Drawing.Point(0, 379);
            this.gbManipulation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbManipulation.Size = new System.Drawing.Size(833, 139);
            this.gbManipulation.TabIndex = 50;
            this.gbManipulation.TabStop = false;
            this.gbManipulation.Text = "Манипуляция данными";
            // 
            // pnClientFormKlients
            // 
            this.pnClientFormKlients.Controls.Add(this.lblRepairCar);
            this.pnClientFormKlients.Controls.Add(this.cbClient);
            this.pnClientFormKlients.Controls.Add(this.lblClient);
            this.pnClientFormKlients.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnClientFormKlients.Location = new System.Drawing.Point(595, 19);
            this.pnClientFormKlients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnClientFormKlients.Name = "pnClientFormKlients";
            this.pnClientFormKlients.Size = new System.Drawing.Size(234, 81);
            this.pnClientFormKlients.TabIndex = 43;
            // 
            // cbClient
            // 
            this.cbClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(0, 17);
            this.cbClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(234, 24);
            this.cbClient.TabIndex = 30;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClient.Location = new System.Drawing.Point(0, 0);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(56, 17);
            this.lblClient.TabIndex = 29;
            this.lblClient.Text = "Клиент";
            // 
            // pnColorYearMade
            // 
            this.pnColorYearMade.Controls.Add(this.tbYearMade);
            this.pnColorYearMade.Controls.Add(this.lblYearMade);
            this.pnColorYearMade.Controls.Add(this.tbColor);
            this.pnColorYearMade.Controls.Add(this.lblColor);
            this.pnColorYearMade.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnColorYearMade.Location = new System.Drawing.Point(398, 19);
            this.pnColorYearMade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnColorYearMade.Name = "pnColorYearMade";
            this.pnColorYearMade.Size = new System.Drawing.Size(197, 83);
            this.pnColorYearMade.TabIndex = 42;
            // 
            // tbYearMade
            // 
            this.tbYearMade.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbYearMade.Location = new System.Drawing.Point(0, 56);
            this.tbYearMade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbYearMade.Name = "tbYearMade";
            this.tbYearMade.Size = new System.Drawing.Size(197, 22);
            this.tbYearMade.TabIndex = 30;
            // 
            // lblYearMade
            // 
            this.lblYearMade.AutoSize = true;
            this.lblYearMade.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYearMade.Location = new System.Drawing.Point(0, 39);
            this.lblYearMade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearMade.Name = "lblYearMade";
            this.lblYearMade.Size = new System.Drawing.Size(90, 17);
            this.lblYearMade.TabIndex = 29;
            this.lblYearMade.Text = "Год выпуска";
            // 
            // tbColor
            // 
            this.tbColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbColor.Location = new System.Drawing.Point(0, 17);
            this.tbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(197, 22);
            this.tbColor.TabIndex = 28;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblColor.Location = new System.Drawing.Point(0, 0);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 17);
            this.lblColor.TabIndex = 27;
            this.lblColor.Text = "Цвет";
            // 
            // pnBrandModel
            // 
            this.pnBrandModel.Controls.Add(this.tbModel);
            this.pnBrandModel.Controls.Add(this.lblModel);
            this.pnBrandModel.Controls.Add(this.tbBrand);
            this.pnBrandModel.Controls.Add(this.lblBrand);
            this.pnBrandModel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBrandModel.Location = new System.Drawing.Point(201, 19);
            this.pnBrandModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnBrandModel.Name = "pnBrandModel";
            this.pnBrandModel.Size = new System.Drawing.Size(197, 83);
            this.pnBrandModel.TabIndex = 41;
            // 
            // tbModel
            // 
            this.tbModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbModel.Location = new System.Drawing.Point(0, 56);
            this.tbModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(197, 22);
            this.tbModel.TabIndex = 30;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModel.Location = new System.Drawing.Point(0, 39);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(58, 17);
            this.lblModel.TabIndex = 29;
            this.lblModel.Text = "Модель";
            // 
            // tbBrand
            // 
            this.tbBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBrand.Location = new System.Drawing.Point(0, 17);
            this.tbBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(197, 22);
            this.tbBrand.TabIndex = 28;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrand.Location = new System.Drawing.Point(0, 0);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(50, 17);
            this.lblBrand.TabIndex = 27;
            this.lblBrand.Text = "Марка";
            // 
            // pnRegVim
            // 
            this.pnRegVim.Controls.Add(this.tbVim);
            this.pnRegVim.Controls.Add(this.lblVim);
            this.pnRegVim.Controls.Add(this.tbRegisterSign);
            this.pnRegVim.Controls.Add(this.lblRegistrationPlate);
            this.pnRegVim.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnRegVim.Location = new System.Drawing.Point(4, 19);
            this.pnRegVim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnRegVim.Name = "pnRegVim";
            this.pnRegVim.Size = new System.Drawing.Size(197, 83);
            this.pnRegVim.TabIndex = 40;
            // 
            // tbVim
            // 
            this.tbVim.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbVim.Location = new System.Drawing.Point(0, 56);
            this.tbVim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVim.Name = "tbVim";
            this.tbVim.Size = new System.Drawing.Size(197, 22);
            this.tbVim.TabIndex = 30;
            // 
            // lblVim
            // 
            this.lblVim.AutoSize = true;
            this.lblVim.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVim.Location = new System.Drawing.Point(0, 39);
            this.lblVim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVim.Name = "lblVim";
            this.lblVim.Size = new System.Drawing.Size(194, 17);
            this.lblVim.TabIndex = 29;
            this.lblVim.Text = "Идентификационный номер";
            // 
            // tbRegisterSign
            // 
            this.tbRegisterSign.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbRegisterSign.Location = new System.Drawing.Point(0, 17);
            this.tbRegisterSign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRegisterSign.Name = "tbRegisterSign";
            this.tbRegisterSign.Size = new System.Drawing.Size(197, 22);
            this.tbRegisterSign.TabIndex = 28;
            // 
            // lblRegistrationPlate
            // 
            this.lblRegistrationPlate.AutoSize = true;
            this.lblRegistrationPlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegistrationPlate.Location = new System.Drawing.Point(0, 0);
            this.lblRegistrationPlate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrationPlate.Name = "lblRegistrationPlate";
            this.lblRegistrationPlate.Size = new System.Drawing.Size(160, 17);
            this.lblRegistrationPlate.TabIndex = 27;
            this.lblRegistrationPlate.Text = "Регистрационный знак";
            // 
            // pnManipulation
            // 
            this.pnManipulation.Controls.Add(this.btnDelete);
            this.pnManipulation.Controls.Add(this.btnUpdate);
            this.pnManipulation.Controls.Add(this.btnInsert);
            this.pnManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnManipulation.Location = new System.Drawing.Point(4, 102);
            this.pnManipulation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnManipulation.Name = "pnManipulation";
            this.pnManipulation.Size = new System.Drawing.Size(825, 33);
            this.pnManipulation.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(550, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(275, 33);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Удалить данные автомобиля";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.Location = new System.Drawing.Point(275, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(275, 33);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Изменить данные автомобиля";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(275, 33);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Добавить данные автомобиля";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblRepairCar
            // 
            this.lblRepairCar.AutoSize = true;
            this.lblRepairCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRepairCar.Location = new System.Drawing.Point(0, 41);
            this.lblRepairCar.Name = "lblRepairCar";
            this.lblRepairCar.Size = new System.Drawing.Size(175, 17);
            this.lblRepairCar.TabIndex = 31;
            this.lblRepairCar.Text = "Машина на ремонте: Нет";
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.BackgroundColor = System.Drawing.Color.White;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCars.Location = new System.Drawing.Point(0, 47);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.Size = new System.Drawing.Size(833, 332);
            this.dgvCars.TabIndex = 51;
            this.dgvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellClick);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 549);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.gbManipulation);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchFiltration);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CarsForm";
            this.Text = "Справочник Автомобили";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbManipulation.ResumeLayout(false);
            this.pnClientFormKlients.ResumeLayout(false);
            this.pnClientFormKlients.PerformLayout();
            this.pnColorYearMade.ResumeLayout(false);
            this.pnColorYearMade.PerformLayout();
            this.pnBrandModel.ResumeLayout(false);
            this.pnBrandModel.PerformLayout();
            this.pnRegVim.ResumeLayout(false);
            this.pnRegVim.PerformLayout();
            this.pnManipulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearchFiltration;
        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.GroupBox gbManipulation;
        private System.Windows.Forms.Panel pnClientFormKlients;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Panel pnColorYearMade;
        private System.Windows.Forms.TextBox tbYearMade;
        private System.Windows.Forms.Label lblYearMade;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Panel pnBrandModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel pnRegVim;
        private System.Windows.Forms.TextBox tbVim;
        private System.Windows.Forms.Label lblVim;
        private System.Windows.Forms.TextBox tbRegisterSign;
        private System.Windows.Forms.Label lblRegistrationPlate;
        private System.Windows.Forms.Panel pnManipulation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblRepairCar;
        private System.Windows.Forms.DataGridView dgvCars;
    }
}