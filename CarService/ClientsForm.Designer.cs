namespace CarService
{
    partial class ClientsForm
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
            this.btnErrors = new System.Windows.Forms.Button();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.tbSearchFiltration = new System.Windows.Forms.TextBox();
            this.gbSearchFiltration = new System.Windows.Forms.GroupBox();
            this.pnSecondName = new System.Windows.Forms.Panel();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.pnFirstName = new System.Windows.Forms.Panel();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnPatronynic = new System.Windows.Forms.Panel();
            this.tbPatronynic = new System.Windows.Forms.TextBox();
            this.lblPatronynic = new System.Windows.Forms.Label();
            this.pnPhoneNumber = new System.Windows.Forms.Panel();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.gbManipulation = new System.Windows.Forms.GroupBox();
            this.pnManipulation = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.pnCancel.SuspendLayout();
            this.gbSearchFiltration.SuspendLayout();
            this.pnSecondName.SuspendLayout();
            this.pnFirstName.SuspendLayout();
            this.pnPatronynic.SuspendLayout();
            this.pnPhoneNumber.SuspendLayout();
            this.gbManipulation.SuspendLayout();
            this.pnManipulation.SuspendLayout();
            this.SuspendLayout();
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
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnCancel);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 354);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(800, 25);
            this.pnCancel.TabIndex = 39;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(634, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 25);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(687, 16);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(110, 17);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            // 
            // tbSearchFiltration
            // 
            this.tbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFiltration.Location = new System.Drawing.Point(3, 16);
            this.tbSearchFiltration.Name = "tbSearchFiltration";
            this.tbSearchFiltration.Size = new System.Drawing.Size(684, 20);
            this.tbSearchFiltration.TabIndex = 0;
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFiltration);
            this.gbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.Size = new System.Drawing.Size(800, 38);
            this.gbSearchFiltration.TabIndex = 36;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // pnSecondName
            // 
            this.pnSecondName.Controls.Add(this.tbSecondName);
            this.pnSecondName.Controls.Add(this.lblSecondName);
            this.pnSecondName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSecondName.Location = new System.Drawing.Point(3, 16);
            this.pnSecondName.Name = "pnSecondName";
            this.pnSecondName.Size = new System.Drawing.Size(202, 33);
            this.pnSecondName.TabIndex = 40;
            // 
            // tbSecondName
            // 
            this.tbSecondName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSecondName.Location = new System.Drawing.Point(0, 13);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(202, 20);
            this.tbSecondName.TabIndex = 28;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecondName.Location = new System.Drawing.Point(0, 0);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(100, 13);
            this.lblSecondName.TabIndex = 27;
            this.lblSecondName.Text = "Фамилия клиента";
            // 
            // pnFirstName
            // 
            this.pnFirstName.Controls.Add(this.tbFirstName);
            this.pnFirstName.Controls.Add(this.lblFirstName);
            this.pnFirstName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFirstName.Location = new System.Drawing.Point(205, 16);
            this.pnFirstName.Name = "pnFirstName";
            this.pnFirstName.Size = new System.Drawing.Size(202, 33);
            this.pnFirstName.TabIndex = 41;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFirstName.Location = new System.Drawing.Point(0, 13);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(202, 20);
            this.tbFirstName.TabIndex = 28;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFirstName.Location = new System.Drawing.Point(0, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 13);
            this.lblFirstName.TabIndex = 27;
            this.lblFirstName.Text = "Имя клиента";
            // 
            // pnPatronynic
            // 
            this.pnPatronynic.Controls.Add(this.tbPatronynic);
            this.pnPatronynic.Controls.Add(this.lblPatronynic);
            this.pnPatronynic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPatronynic.Location = new System.Drawing.Point(407, 16);
            this.pnPatronynic.Name = "pnPatronynic";
            this.pnPatronynic.Size = new System.Drawing.Size(202, 33);
            this.pnPatronynic.TabIndex = 42;
            // 
            // tbPatronynic
            // 
            this.tbPatronynic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPatronynic.Location = new System.Drawing.Point(0, 13);
            this.tbPatronynic.Name = "tbPatronynic";
            this.tbPatronynic.Size = new System.Drawing.Size(202, 20);
            this.tbPatronynic.TabIndex = 28;
            // 
            // lblPatronynic
            // 
            this.lblPatronynic.AutoSize = true;
            this.lblPatronynic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatronynic.Location = new System.Drawing.Point(0, 0);
            this.lblPatronynic.Name = "lblPatronynic";
            this.lblPatronynic.Size = new System.Drawing.Size(98, 13);
            this.lblPatronynic.TabIndex = 27;
            this.lblPatronynic.Text = "Отчество клиента";
            // 
            // pnPhoneNumber
            // 
            this.pnPhoneNumber.Controls.Add(this.tbPhoneNumber);
            this.pnPhoneNumber.Controls.Add(this.lblPhoneNumber);
            this.pnPhoneNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPhoneNumber.Location = new System.Drawing.Point(609, 16);
            this.pnPhoneNumber.Name = "pnPhoneNumber";
            this.pnPhoneNumber.Size = new System.Drawing.Size(191, 33);
            this.pnPhoneNumber.TabIndex = 43;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPhoneNumber.Location = new System.Drawing.Point(0, 13);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(191, 20);
            this.tbPhoneNumber.TabIndex = 30;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhoneNumber.Location = new System.Drawing.Point(0, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(137, 13);
            this.lblPhoneNumber.TabIndex = 29;
            this.lblPhoneNumber.Text = "Номер телефона клиента";
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.pnPhoneNumber);
            this.gbManipulation.Controls.Add(this.pnPatronynic);
            this.gbManipulation.Controls.Add(this.pnFirstName);
            this.gbManipulation.Controls.Add(this.pnSecondName);
            this.gbManipulation.Controls.Add(this.pnManipulation);
            this.gbManipulation.Location = new System.Drawing.Point(0, 276);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Size = new System.Drawing.Size(800, 78);
            this.gbManipulation.TabIndex = 38;
            this.gbManipulation.TabStop = false;
            this.gbManipulation.Text = "Манипуляция данными";
            // 
            // pnManipulation
            // 
            this.pnManipulation.Controls.Add(this.btnDelete);
            this.pnManipulation.Controls.Add(this.btnUpdate);
            this.pnManipulation.Controls.Add(this.btnInsert);
            this.pnManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnManipulation.Location = new System.Drawing.Point(3, 49);
            this.pnManipulation.Name = "pnManipulation";
            this.pnManipulation.Size = new System.Drawing.Size(794, 26);
            this.pnManipulation.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(530, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(267, 26);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Удалить данные клиента";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.Location = new System.Drawing.Point(265, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(265, 26);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Изменить данные клиента";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(265, 26);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Добавить данные клиента";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // lbClients
            // 
            this.lbClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(0, 38);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(800, 316);
            this.lbClients.TabIndex = 40;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.gbManipulation);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchFiltration);
            this.Name = "ClientsForm";
            this.Text = "Справочник Клиенты";
            this.pnCancel.ResumeLayout(false);
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
            this.pnSecondName.ResumeLayout(false);
            this.pnSecondName.PerformLayout();
            this.pnFirstName.ResumeLayout(false);
            this.pnFirstName.PerformLayout();
            this.pnPatronynic.ResumeLayout(false);
            this.pnPatronynic.PerformLayout();
            this.pnPhoneNumber.ResumeLayout(false);
            this.pnPhoneNumber.PerformLayout();
            this.gbManipulation.ResumeLayout(false);
            this.pnManipulation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearchFiltration;
        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.Panel pnSecondName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Panel pnFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel pnPatronynic;
        private System.Windows.Forms.TextBox tbPatronynic;
        private System.Windows.Forms.Label lblPatronynic;
        private System.Windows.Forms.Panel pnPhoneNumber;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox gbManipulation;
        private System.Windows.Forms.Panel pnManipulation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListBox lbClients;
    }
}