namespace CarService
{
    partial class CarsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSearchFiltration = new System.Windows.Forms.GroupBox();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.tbSearchFiltration = new System.Windows.Forms.TextBox();
            this.gbManipulation = new System.Windows.Forms.GroupBox();
            this.pnClientFormKlients = new System.Windows.Forms.Panel();
            this.btnFromClients = new System.Windows.Forms.Button();
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
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.lbCars = new System.Windows.Forms.ListBox();
            this.gbSearchFiltration.SuspendLayout();
            this.gbManipulation.SuspendLayout();
            this.pnClientFormKlients.SuspendLayout();
            this.pnColorYearMade.SuspendLayout();
            this.pnBrandModel.SuspendLayout();
            this.pnRegVim.SuspendLayout();
            this.pnManipulation.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFiltration);
            this.gbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.Size = new System.Drawing.Size(625, 38);
            this.gbSearchFiltration.TabIndex = 0;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(514, 16);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(108, 17);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            // 
            // tbSearchFiltration
            // 
            this.tbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFiltration.Location = new System.Drawing.Point(3, 16);
            this.tbSearchFiltration.Name = "tbSearchFiltration";
            this.tbSearchFiltration.Size = new System.Drawing.Size(511, 20);
            this.tbSearchFiltration.TabIndex = 0;
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.pnClientFormKlients);
            this.gbManipulation.Controls.Add(this.pnColorYearMade);
            this.gbManipulation.Controls.Add(this.pnBrandModel);
            this.gbManipulation.Controls.Add(this.pnRegVim);
            this.gbManipulation.Controls.Add(this.pnManipulation);
            this.gbManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManipulation.Location = new System.Drawing.Point(0, 333);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Size = new System.Drawing.Size(625, 113);
            this.gbManipulation.TabIndex = 2;
            this.gbManipulation.TabStop = false;
            this.gbManipulation.Text = "Манипуляция данными";
            // 
            // pnClientFormKlients
            // 
            this.pnClientFormKlients.Controls.Add(this.btnFromClients);
            this.pnClientFormKlients.Controls.Add(this.cbClient);
            this.pnClientFormKlients.Controls.Add(this.lblClient);
            this.pnClientFormKlients.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnClientFormKlients.Location = new System.Drawing.Point(447, 16);
            this.pnClientFormKlients.Name = "pnClientFormKlients";
            this.pnClientFormKlients.Size = new System.Drawing.Size(175, 66);
            this.pnClientFormKlients.TabIndex = 43;
            // 
            // btnFromClients
            // 
            this.btnFromClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFromClients.Location = new System.Drawing.Point(0, 43);
            this.btnFromClients.Name = "btnFromClients";
            this.btnFromClients.Size = new System.Drawing.Size(175, 23);
            this.btnFromClients.TabIndex = 31;
            this.btnFromClients.Text = "Клиенты";
            this.btnFromClients.UseVisualStyleBackColor = true;
            // 
            // cbClient
            // 
            this.cbClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(0, 13);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(175, 21);
            this.cbClient.TabIndex = 30;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClient.Location = new System.Drawing.Point(0, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 13);
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
            this.pnColorYearMade.Location = new System.Drawing.Point(299, 16);
            this.pnColorYearMade.Name = "pnColorYearMade";
            this.pnColorYearMade.Size = new System.Drawing.Size(148, 67);
            this.pnColorYearMade.TabIndex = 42;
            // 
            // tbYearMade
            // 
            this.tbYearMade.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbYearMade.Location = new System.Drawing.Point(0, 46);
            this.tbYearMade.Name = "tbYearMade";
            this.tbYearMade.Size = new System.Drawing.Size(148, 20);
            this.tbYearMade.TabIndex = 30;
            // 
            // lblYearMade
            // 
            this.lblYearMade.AutoSize = true;
            this.lblYearMade.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYearMade.Location = new System.Drawing.Point(0, 33);
            this.lblYearMade.Name = "lblYearMade";
            this.lblYearMade.Size = new System.Drawing.Size(71, 13);
            this.lblYearMade.TabIndex = 29;
            this.lblYearMade.Text = "Год выпуска";
            // 
            // tbColor
            // 
            this.tbColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbColor.Location = new System.Drawing.Point(0, 13);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(148, 20);
            this.tbColor.TabIndex = 28;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblColor.Location = new System.Drawing.Point(0, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(32, 13);
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
            this.pnBrandModel.Location = new System.Drawing.Point(151, 16);
            this.pnBrandModel.Name = "pnBrandModel";
            this.pnBrandModel.Size = new System.Drawing.Size(148, 67);
            this.pnBrandModel.TabIndex = 41;
            // 
            // tbModel
            // 
            this.tbModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbModel.Location = new System.Drawing.Point(0, 46);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(148, 20);
            this.tbModel.TabIndex = 30;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModel.Location = new System.Drawing.Point(0, 33);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 13);
            this.lblModel.TabIndex = 29;
            this.lblModel.Text = "Модель";
            // 
            // tbBrand
            // 
            this.tbBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBrand.Location = new System.Drawing.Point(0, 13);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(148, 20);
            this.tbBrand.TabIndex = 28;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrand.Location = new System.Drawing.Point(0, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(40, 13);
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
            this.pnRegVim.Location = new System.Drawing.Point(3, 16);
            this.pnRegVim.Name = "pnRegVim";
            this.pnRegVim.Size = new System.Drawing.Size(148, 67);
            this.pnRegVim.TabIndex = 40;
            // 
            // tbVim
            // 
            this.tbVim.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbVim.Location = new System.Drawing.Point(0, 46);
            this.tbVim.Name = "tbVim";
            this.tbVim.Size = new System.Drawing.Size(148, 20);
            this.tbVim.TabIndex = 30;
            // 
            // lblVim
            // 
            this.lblVim.AutoSize = true;
            this.lblVim.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVim.Location = new System.Drawing.Point(0, 33);
            this.lblVim.Name = "lblVim";
            this.lblVim.Size = new System.Drawing.Size(149, 13);
            this.lblVim.TabIndex = 29;
            this.lblVim.Text = "Идентификационный номер";
            // 
            // tbRegisterSign
            // 
            this.tbRegisterSign.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbRegisterSign.Location = new System.Drawing.Point(0, 13);
            this.tbRegisterSign.Name = "tbRegisterSign";
            this.tbRegisterSign.Size = new System.Drawing.Size(148, 20);
            this.tbRegisterSign.TabIndex = 28;
            // 
            // lblRegistrationPlate
            // 
            this.lblRegistrationPlate.AutoSize = true;
            this.lblRegistrationPlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegistrationPlate.Location = new System.Drawing.Point(0, 0);
            this.lblRegistrationPlate.Name = "lblRegistrationPlate";
            this.lblRegistrationPlate.Size = new System.Drawing.Size(125, 13);
            this.lblRegistrationPlate.TabIndex = 27;
            this.lblRegistrationPlate.Text = "Регистрационный знак";
            // 
            // pnManipulation
            // 
            this.pnManipulation.Controls.Add(this.btnDelete);
            this.pnManipulation.Controls.Add(this.btnUpdate);
            this.pnManipulation.Controls.Add(this.btnInsert);
            this.pnManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnManipulation.Location = new System.Drawing.Point(3, 83);
            this.pnManipulation.Name = "pnManipulation";
            this.pnManipulation.Size = new System.Drawing.Size(619, 27);
            this.pnManipulation.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(412, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 27);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Удалить данные автомобиля";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.Location = new System.Drawing.Point(206, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(206, 27);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Изменить данные автомобиля";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(206, 27);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Добавить данные автомобиля";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnCancel);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 308);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(625, 25);
            this.pnCancel.TabIndex = 35;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(459, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 25);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnErrors
            // 
            this.btnErrors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnErrors.Location = new System.Drawing.Point(0, 0);
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Size = new System.Drawing.Size(166, 25);
            this.btnErrors.TabIndex = 35;
            this.btnErrors.Text = "Ошибки";
            this.btnErrors.UseVisualStyleBackColor = true;
            // 
            // lbCars
            // 
            this.lbCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCars.FormattingEnabled = true;
            this.lbCars.Location = new System.Drawing.Point(0, 38);
            this.lbCars.Name = "lbCars";
            this.lbCars.Size = new System.Drawing.Size(625, 270);
            this.lbCars.TabIndex = 44;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 446);
            this.Controls.Add(this.lbCars);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbManipulation);
            this.Controls.Add(this.gbSearchFiltration);
            this.Name = "CarsForm";
            this.Text = "Справочник Автомобили";
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
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
            this.pnCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearchFiltration;
        private System.Windows.Forms.GroupBox gbManipulation;
        private System.Windows.Forms.Panel pnClientFormKlients;
        private System.Windows.Forms.Button btnFromClients;
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
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.ListBox lbCars;
    }
}

