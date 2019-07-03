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
            this.dgvAmenities = new System.Windows.Forms.DataGridView();
            this.gbSearchFiltration.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbManipulation.SuspendLayout();
            this.pnManipulation.SuspendLayout();
            this.pnServiceData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmenities)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFiltration);
            this.gbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchFiltration.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearchFiltration.Size = new System.Drawing.Size(400, 47);
            this.gbSearchFiltration.TabIndex = 37;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(252, 19);
            this.chbFiltration.Margin = new System.Windows.Forms.Padding(4);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(144, 21);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            this.chbFiltration.CheckedChanged += new System.EventHandler(this.chbFiltration_CheckedChanged);
            // 
            // tbSearchFiltration
            // 
            this.tbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFiltration.Location = new System.Drawing.Point(4, 19);
            this.tbSearchFiltration.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchFiltration.Name = "tbSearchFiltration";
            this.tbSearchFiltration.Size = new System.Drawing.Size(248, 22);
            this.tbSearchFiltration.TabIndex = 0;
            this.tbSearchFiltration.Text = "Введите данные услуги...";
            this.tbSearchFiltration.Click += new System.EventHandler(this.tbSearchFiltration_Click);
            this.tbSearchFiltration.TextChanged += new System.EventHandler(this.tbSearchFiltration_TextChanged);
            this.tbSearchFiltration.Enter += new System.EventHandler(this.tbSearchFiltration_Enter);
            this.tbSearchFiltration.Leave += new System.EventHandler(this.tbSearchFiltration_Leave);
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnCancel);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 539);
            this.pnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(400, 31);
            this.pnCancel.TabIndex = 41;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(304, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnErrors
            // 
            this.btnErrors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnErrors.Location = new System.Drawing.Point(0, 0);
            this.btnErrors.Margin = new System.Windows.Forms.Padding(4);
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Size = new System.Drawing.Size(89, 31);
            this.btnErrors.TabIndex = 35;
            this.btnErrors.Text = "Ошибки";
            this.btnErrors.UseVisualStyleBackColor = true;
            this.btnErrors.Click += new System.EventHandler(this.btnErrors_Click);
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.pnManipulation);
            this.gbManipulation.Controls.Add(this.pnServiceData);
            this.gbManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManipulation.Location = new System.Drawing.Point(0, 337);
            this.gbManipulation.Margin = new System.Windows.Forms.Padding(4);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Padding = new System.Windows.Forms.Padding(4);
            this.gbManipulation.Size = new System.Drawing.Size(400, 202);
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
            this.pnManipulation.Location = new System.Drawing.Point(4, 101);
            this.pnManipulation.Margin = new System.Windows.Forms.Padding(4);
            this.pnManipulation.Name = "pnManipulation";
            this.pnManipulation.Size = new System.Drawing.Size(392, 96);
            this.pnManipulation.TabIndex = 42;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(0, 64);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(392, 32);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Удалить данные услуги";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Location = new System.Drawing.Point(0, 32);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(392, 32);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Изменить данные услуги";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(392, 32);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Добавить данные услуги";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // pnServiceData
            // 
            this.pnServiceData.Controls.Add(this.tbPrice);
            this.pnServiceData.Controls.Add(this.lblPrice);
            this.pnServiceData.Controls.Add(this.tbNameService);
            this.pnServiceData.Controls.Add(this.lblNameService);
            this.pnServiceData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnServiceData.Location = new System.Drawing.Point(4, 19);
            this.pnServiceData.Margin = new System.Windows.Forms.Padding(4);
            this.pnServiceData.Name = "pnServiceData";
            this.pnServiceData.Size = new System.Drawing.Size(392, 82);
            this.pnServiceData.TabIndex = 41;
            // 
            // tbPrice
            // 
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPrice.Location = new System.Drawing.Point(0, 56);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(392, 22);
            this.tbPrice.TabIndex = 30;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Location = new System.Drawing.Point(0, 39);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(124, 17);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Стоимость услуги";
            // 
            // tbNameService
            // 
            this.tbNameService.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNameService.Location = new System.Drawing.Point(0, 17);
            this.tbNameService.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameService.Name = "tbNameService";
            this.tbNameService.Size = new System.Drawing.Size(392, 22);
            this.tbNameService.TabIndex = 28;
            // 
            // lblNameService
            // 
            this.lblNameService.AutoSize = true;
            this.lblNameService.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNameService.Location = new System.Drawing.Point(0, 0);
            this.lblNameService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameService.Name = "lblNameService";
            this.lblNameService.Size = new System.Drawing.Size(118, 17);
            this.lblNameService.TabIndex = 27;
            this.lblNameService.Text = "Название услуги";
            // 
            // dgvAmenities
            // 
            this.dgvAmenities.AllowUserToAddRows = false;
            this.dgvAmenities.AllowUserToDeleteRows = false;
            this.dgvAmenities.BackgroundColor = System.Drawing.Color.White;
            this.dgvAmenities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmenities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAmenities.Location = new System.Drawing.Point(0, 47);
            this.dgvAmenities.Name = "dgvAmenities";
            this.dgvAmenities.ReadOnly = true;
            this.dgvAmenities.RowTemplate.Height = 24;
            this.dgvAmenities.Size = new System.Drawing.Size(400, 290);
            this.dgvAmenities.TabIndex = 43;
            this.dgvAmenities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAmenities_CellClick);
            // 
            // AmenitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 570);
            this.Controls.Add(this.dgvAmenities);
            this.Controls.Add(this.gbManipulation);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchFiltration);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AmenitiesForm";
            this.Text = "Справочник Услуги";
            this.Load += new System.EventHandler(this.AmenitiesForm_Load);
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbManipulation.ResumeLayout(false);
            this.pnManipulation.ResumeLayout(false);
            this.pnServiceData.ResumeLayout(false);
            this.pnServiceData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmenities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearchFiltration;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnErrors;
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
        private System.Windows.Forms.DataGridView dgvAmenities;
    }
}