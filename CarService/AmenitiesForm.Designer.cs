namespace CarService
{
    partial class AmenitiesForm
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
            this.gbSearchFiltration = new System.Windows.Forms.GroupBox();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.tbSearchFiltration = new System.Windows.Forms.TextBox();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.lbAminities = new System.Windows.Forms.ListBox();
            this.gbManipulation = new System.Windows.Forms.GroupBox();
            this.pnManipulation = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnServiceData = new System.Windows.Forms.Panel();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbNameService = new System.Windows.Forms.TextBox();
            this.lblNameService = new System.Windows.Forms.Label();
            this.gbSearchFiltration.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbManipulation.SuspendLayout();
            this.pnManipulation.SuspendLayout();
            this.pnServiceData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFiltration);
            this.gbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.Size = new System.Drawing.Size(300, 38);
            this.gbSearchFiltration.TabIndex = 37;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(190, 16);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(107, 17);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            // 
            // tbSearchFiltration
            // 
            this.tbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFiltration.Location = new System.Drawing.Point(3, 16);
            this.tbSearchFiltration.Name = "tbSearchFiltration";
            this.tbSearchFiltration.Size = new System.Drawing.Size(187, 20);
            this.tbSearchFiltration.TabIndex = 0;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnCancel);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 438);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(300, 25);
            this.pnCancel.TabIndex = 41;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(228, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 25);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnErrors
            // 
            this.btnErrors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnErrors.Location = new System.Drawing.Point(0, 0);
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Size = new System.Drawing.Size(67, 25);
            this.btnErrors.TabIndex = 35;
            this.btnErrors.Text = "Ошибки";
            this.btnErrors.UseVisualStyleBackColor = true;
            // 
            // lbAminities
            // 
            this.lbAminities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAminities.FormattingEnabled = true;
            this.lbAminities.Location = new System.Drawing.Point(0, 38);
            this.lbAminities.Name = "lbAminities";
            this.lbAminities.Size = new System.Drawing.Size(300, 400);
            this.lbAminities.TabIndex = 37;
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.pnManipulation);
            this.gbManipulation.Controls.Add(this.pnServiceData);
            this.gbManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManipulation.Location = new System.Drawing.Point(0, 274);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Size = new System.Drawing.Size(300, 164);
            this.gbManipulation.TabIndex = 42;
            this.gbManipulation.TabStop = false;
            this.gbManipulation.Text = "Манипуляция данными";
            // 
            // pnManipulation
            // 
            this.pnManipulation.Controls.Add(this.btnDelete);
            this.pnManipulation.Controls.Add(this.btnUpdate);
            this.pnManipulation.Controls.Add(this.btnInsert);
            this.pnManipulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnManipulation.Location = new System.Drawing.Point(3, 83);
            this.pnManipulation.Name = "pnManipulation";
            this.pnManipulation.Size = new System.Drawing.Size(294, 78);
            this.pnManipulation.TabIndex = 42;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(0, 52);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(294, 26);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Удалить данные услуги";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Location = new System.Drawing.Point(0, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(294, 26);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Изменить данные услуги";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(294, 26);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Добавить данные услуги";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // pnServiceData
            // 
            this.pnServiceData.Controls.Add(this.tbPrice);
            this.pnServiceData.Controls.Add(this.lblPrice);
            this.pnServiceData.Controls.Add(this.tbNameService);
            this.pnServiceData.Controls.Add(this.lblNameService);
            this.pnServiceData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnServiceData.Location = new System.Drawing.Point(3, 16);
            this.pnServiceData.Name = "pnServiceData";
            this.pnServiceData.Size = new System.Drawing.Size(294, 67);
            this.pnServiceData.TabIndex = 41;
            // 
            // tbPrice
            // 
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPrice.Location = new System.Drawing.Point(0, 46);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(294, 20);
            this.tbPrice.TabIndex = 30;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Location = new System.Drawing.Point(0, 33);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 13);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Стоимость услуги";
            // 
            // tbNameService
            // 
            this.tbNameService.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNameService.Location = new System.Drawing.Point(0, 13);
            this.tbNameService.Name = "tbNameService";
            this.tbNameService.Size = new System.Drawing.Size(294, 20);
            this.tbNameService.TabIndex = 28;
            // 
            // lblNameService
            // 
            this.lblNameService.AutoSize = true;
            this.lblNameService.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNameService.Location = new System.Drawing.Point(0, 0);
            this.lblNameService.Name = "lblNameService";
            this.lblNameService.Size = new System.Drawing.Size(93, 13);
            this.lblNameService.TabIndex = 27;
            this.lblNameService.Text = "Название услуги";
            // 
            // AmenitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 463);
            this.Controls.Add(this.gbManipulation);
            this.Controls.Add(this.lbAminities);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchFiltration);
            this.Name = "AmenitiesForm";
            this.Text = "Справочник Услуги";
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbManipulation.ResumeLayout(false);
            this.pnManipulation.ResumeLayout(false);
            this.pnServiceData.ResumeLayout(false);
            this.pnServiceData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearchFiltration;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.ListBox lbAminities;
        private System.Windows.Forms.GroupBox gbManipulation;
        private System.Windows.Forms.Panel pnManipulation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel pnServiceData;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbNameService;
        private System.Windows.Forms.Label lblNameService;
    }
}