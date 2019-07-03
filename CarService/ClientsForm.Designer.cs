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
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.gbManipulation = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbKolVoPos = new System.Windows.Forms.TextBox();
            this.lbKolVoPos = new System.Windows.Forms.Label();
            this.pnManipulation = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.pnCancel.SuspendLayout();
            this.gbSearchFiltration.SuspendLayout();
            this.pnSecondName.SuspendLayout();
            this.pnFirstName.SuspendLayout();
            this.pnPatronynic.SuspendLayout();
            this.pnPhoneNumber.SuspendLayout();
            this.gbManipulation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnErrors
            // 
            this.btnErrors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnErrors.Location = new System.Drawing.Point(0, 0);
            this.btnErrors.Margin = new System.Windows.Forms.Padding(4);
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Size = new System.Drawing.Size(221, 31);
            this.btnErrors.TabIndex = 35;
            this.btnErrors.Text = "Ошибки";
            this.btnErrors.UseVisualStyleBackColor = true;
            this.btnErrors.Click += new System.EventHandler(this.btnErrors_Click);
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnCancel);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 435);
            this.pnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(1067, 31);
            this.pnCancel.TabIndex = 39;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(846, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(221, 31);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(915, 19);
            this.chbFiltration.Margin = new System.Windows.Forms.Padding(4);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(148, 21);
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
            this.tbSearchFiltration.Size = new System.Drawing.Size(911, 22);
            this.tbSearchFiltration.TabIndex = 0;
            this.tbSearchFiltration.Text = "Введите данные клиента...";
            this.tbSearchFiltration.Click += new System.EventHandler(this.tbSearchFiltration_Click);
            this.tbSearchFiltration.TextChanged += new System.EventHandler(this.tbSearchFiltration_TextChanged);
            this.tbSearchFiltration.Enter += new System.EventHandler(this.tbSearchFiltration_Enter);
            this.tbSearchFiltration.Leave += new System.EventHandler(this.tbSearchFiltration_Leave);
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
            this.gbSearchFiltration.Size = new System.Drawing.Size(1067, 47);
            this.gbSearchFiltration.TabIndex = 36;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // pnSecondName
            // 
            this.pnSecondName.Controls.Add(this.tbSecondName);
            this.pnSecondName.Controls.Add(this.lblSecondName);
            this.pnSecondName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSecondName.Location = new System.Drawing.Point(4, 19);
            this.pnSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.pnSecondName.Name = "pnSecondName";
            this.pnSecondName.Size = new System.Drawing.Size(213, 41);
            this.pnSecondName.TabIndex = 40;
            // 
            // tbSecondName
            // 
            this.tbSecondName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSecondName.Location = new System.Drawing.Point(0, 17);
            this.tbSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(213, 22);
            this.tbSecondName.TabIndex = 28;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecondName.Location = new System.Drawing.Point(0, 0);
            this.lblSecondName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(128, 17);
            this.lblSecondName.TabIndex = 27;
            this.lblSecondName.Text = "Фамилия клиента";
            // 
            // pnFirstName
            // 
            this.pnFirstName.Controls.Add(this.tbFirstName);
            this.pnFirstName.Controls.Add(this.lblFirstName);
            this.pnFirstName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFirstName.Location = new System.Drawing.Point(217, 19);
            this.pnFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.pnFirstName.Name = "pnFirstName";
            this.pnFirstName.Size = new System.Drawing.Size(213, 41);
            this.pnFirstName.TabIndex = 41;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFirstName.Location = new System.Drawing.Point(0, 17);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(213, 22);
            this.tbFirstName.TabIndex = 28;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFirstName.Location = new System.Drawing.Point(0, 0);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(93, 17);
            this.lblFirstName.TabIndex = 27;
            this.lblFirstName.Text = "Имя клиента";
            // 
            // pnPatronynic
            // 
            this.pnPatronynic.Controls.Add(this.tbPatronynic);
            this.pnPatronynic.Controls.Add(this.lblPatronynic);
            this.pnPatronynic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPatronynic.Location = new System.Drawing.Point(430, 19);
            this.pnPatronynic.Margin = new System.Windows.Forms.Padding(4);
            this.pnPatronynic.Name = "pnPatronynic";
            this.pnPatronynic.Size = new System.Drawing.Size(213, 41);
            this.pnPatronynic.TabIndex = 42;
            // 
            // tbPatronynic
            // 
            this.tbPatronynic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPatronynic.Location = new System.Drawing.Point(0, 17);
            this.tbPatronynic.Margin = new System.Windows.Forms.Padding(4);
            this.tbPatronynic.Name = "tbPatronynic";
            this.tbPatronynic.Size = new System.Drawing.Size(213, 22);
            this.tbPatronynic.TabIndex = 28;
            // 
            // lblPatronynic
            // 
            this.lblPatronynic.AutoSize = true;
            this.lblPatronynic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatronynic.Location = new System.Drawing.Point(0, 0);
            this.lblPatronynic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatronynic.Name = "lblPatronynic";
            this.lblPatronynic.Size = new System.Drawing.Size(129, 17);
            this.lblPatronynic.TabIndex = 27;
            this.lblPatronynic.Text = "Отчество клиента";
            // 
            // pnPhoneNumber
            // 
            this.pnPhoneNumber.Controls.Add(this.mtbTelefon);
            this.pnPhoneNumber.Controls.Add(this.lblPhoneNumber);
            this.pnPhoneNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPhoneNumber.Location = new System.Drawing.Point(643, 19);
            this.pnPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.pnPhoneNumber.Name = "pnPhoneNumber";
            this.pnPhoneNumber.Size = new System.Drawing.Size(213, 41);
            this.pnPhoneNumber.TabIndex = 43;
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtbTelefon.Location = new System.Drawing.Point(0, 17);
            this.mtbTelefon.Mask = "0(000)000-00-00";
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(213, 22);
            this.mtbTelefon.TabIndex = 30;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhoneNumber.Location = new System.Drawing.Point(0, 0);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(179, 17);
            this.lblPhoneNumber.TabIndex = 29;
            this.lblPhoneNumber.Text = "Номер телефона клиента";
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.panel1);
            this.gbManipulation.Controls.Add(this.pnPhoneNumber);
            this.gbManipulation.Controls.Add(this.pnPatronynic);
            this.gbManipulation.Controls.Add(this.pnFirstName);
            this.gbManipulation.Controls.Add(this.pnSecondName);
            this.gbManipulation.Controls.Add(this.pnManipulation);
            this.gbManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManipulation.Location = new System.Drawing.Point(0, 339);
            this.gbManipulation.Margin = new System.Windows.Forms.Padding(4);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Padding = new System.Windows.Forms.Padding(4);
            this.gbManipulation.Size = new System.Drawing.Size(1067, 96);
            this.gbManipulation.TabIndex = 38;
            this.gbManipulation.TabStop = false;
            this.gbManipulation.Text = "Манипуляция данными";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbKolVoPos);
            this.panel1.Controls.Add(this.lbKolVoPos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(856, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 41);
            this.panel1.TabIndex = 44;
            // 
            // tbKolVoPos
            // 
            this.tbKolVoPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbKolVoPos.Location = new System.Drawing.Point(0, 17);
            this.tbKolVoPos.Name = "tbKolVoPos";
            this.tbKolVoPos.Size = new System.Drawing.Size(207, 22);
            this.tbKolVoPos.TabIndex = 30;
            // 
            // lbKolVoPos
            // 
            this.lbKolVoPos.AutoSize = true;
            this.lbKolVoPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbKolVoPos.Location = new System.Drawing.Point(0, 0);
            this.lbKolVoPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKolVoPos.Name = "lbKolVoPos";
            this.lbKolVoPos.Size = new System.Drawing.Size(164, 17);
            this.lbKolVoPos.TabIndex = 29;
            this.lbKolVoPos.Text = "Количество посищений";
            // 
            // pnManipulation
            // 
            this.pnManipulation.Controls.Add(this.btnDelete);
            this.pnManipulation.Controls.Add(this.btnUpdate);
            this.pnManipulation.Controls.Add(this.btnInsert);
            this.pnManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnManipulation.Location = new System.Drawing.Point(4, 60);
            this.pnManipulation.Margin = new System.Windows.Forms.Padding(4);
            this.pnManipulation.Name = "pnManipulation";
            this.pnManipulation.Size = new System.Drawing.Size(1059, 32);
            this.pnManipulation.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(706, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(356, 32);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Удалить данные клиента";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.Location = new System.Drawing.Point(353, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(353, 32);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Изменить данные клиента";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(353, 32);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Добавить данные клиента";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.Location = new System.Drawing.Point(0, 47);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(1067, 292);
            this.dgvClients.TabIndex = 40;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 466);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.gbManipulation);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchFiltration);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientsForm";
            this.Text = "Справочник Клиенты";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnManipulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
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
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox gbManipulation;
        private System.Windows.Forms.Panel pnManipulation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.MaskedTextBox mtbTelefon;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbKolVoPos;
        private System.Windows.Forms.Label lbKolVoPos;
    }
}