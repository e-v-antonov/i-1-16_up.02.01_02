namespace CarService
{
    partial class OrdersForm
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
            this.tbSearchFiltration = new System.Windows.Forms.TextBox();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.gbSearchFiltration = new System.Windows.Forms.GroupBox();
            this.btnErrors = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.pnCarsClients = new System.Windows.Forms.Panel();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.lblClients = new System.Windows.Forms.Label();
            this.cbCars = new System.Windows.Forms.ComboBox();
            this.lblCars = new System.Windows.Forms.Label();
            this.gbManipulation = new System.Windows.Forms.GroupBox();
            this.pnDocs = new System.Windows.Forms.Panel();
            this.btnFormAct = new System.Windows.Forms.Button();
            this.btnFormCheck = new System.Windows.Forms.Button();
            this.pnManipulation = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gbSearchFiltration.SuspendLayout();
            this.pnCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.pnCarsClients.SuspendLayout();
            this.gbManipulation.SuspendLayout();
            this.pnDocs.SuspendLayout();
            this.pnManipulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearchFiltration
            // 
            this.tbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFiltration.Location = new System.Drawing.Point(4, 19);
            this.tbSearchFiltration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearchFiltration.Name = "tbSearchFiltration";
            this.tbSearchFiltration.Size = new System.Drawing.Size(917, 22);
            this.tbSearchFiltration.TabIndex = 0;
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(921, 19);
            this.chbFiltration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(142, 21);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
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
            this.gbSearchFiltration.Size = new System.Drawing.Size(1067, 47);
            this.gbSearchFiltration.TabIndex = 36;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
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
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(846, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(221, 31);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnCancel);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 543);
            this.pnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(1067, 31);
            this.pnCancel.TabIndex = 39;
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvClients.Location = new System.Drawing.Point(539, 47);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(528, 358);
            this.dgvClients.TabIndex = 46;
            // 
            // dgvCars
            // 
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCars.Location = new System.Drawing.Point(0, 47);
            this.dgvCars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.Size = new System.Drawing.Size(539, 358);
            this.dgvCars.TabIndex = 45;
            // 
            // pnCarsClients
            // 
            this.pnCarsClients.Controls.Add(this.cbClients);
            this.pnCarsClients.Controls.Add(this.lblClients);
            this.pnCarsClients.Controls.Add(this.cbCars);
            this.pnCarsClients.Controls.Add(this.lblCars);
            this.pnCarsClients.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCarsClients.Location = new System.Drawing.Point(4, 52);
            this.pnCarsClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnCarsClients.Name = "pnCarsClients";
            this.pnCarsClients.Size = new System.Drawing.Size(535, 82);
            this.pnCarsClients.TabIndex = 43;
            // 
            // cbClients
            // 
            this.cbClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(0, 58);
            this.cbClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(535, 24);
            this.cbClients.TabIndex = 32;
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClients.Location = new System.Drawing.Point(0, 41);
            this.lblClients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(66, 17);
            this.lblClients.TabIndex = 31;
            this.lblClients.Text = "Клиенты";
            // 
            // cbCars
            // 
            this.cbCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCars.FormattingEnabled = true;
            this.cbCars.Location = new System.Drawing.Point(0, 17);
            this.cbCars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCars.Name = "cbCars";
            this.cbCars.Size = new System.Drawing.Size(535, 24);
            this.cbCars.TabIndex = 30;
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCars.Location = new System.Drawing.Point(0, 0);
            this.lblCars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(88, 17);
            this.lblCars.TabIndex = 29;
            this.lblCars.Text = "Автомобили";
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.pnDocs);
            this.gbManipulation.Controls.Add(this.pnCarsClients);
            this.gbManipulation.Controls.Add(this.pnManipulation);
            this.gbManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManipulation.Location = new System.Drawing.Point(0, 405);
            this.gbManipulation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbManipulation.Size = new System.Drawing.Size(1067, 138);
            this.gbManipulation.TabIndex = 44;
            this.gbManipulation.TabStop = false;
            this.gbManipulation.Text = "Манипуляция данными";
            // 
            // pnDocs
            // 
            this.pnDocs.Controls.Add(this.btnFormAct);
            this.pnDocs.Controls.Add(this.btnFormCheck);
            this.pnDocs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDocs.Location = new System.Drawing.Point(539, 52);
            this.pnDocs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnDocs.Name = "pnDocs";
            this.pnDocs.Size = new System.Drawing.Size(524, 82);
            this.pnDocs.TabIndex = 44;
            // 
            // btnFormAct
            // 
            this.btnFormAct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormAct.Location = new System.Drawing.Point(0, 42);
            this.btnFormAct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFormAct.Name = "btnFormAct";
            this.btnFormAct.Size = new System.Drawing.Size(524, 42);
            this.btnFormAct.TabIndex = 36;
            this.btnFormAct.Text = "Формирование акта о выполненных услугах";
            this.btnFormAct.UseVisualStyleBackColor = true;
            // 
            // btnFormCheck
            // 
            this.btnFormCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormCheck.Location = new System.Drawing.Point(0, 0);
            this.btnFormCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFormCheck.Name = "btnFormCheck";
            this.btnFormCheck.Size = new System.Drawing.Size(524, 42);
            this.btnFormCheck.TabIndex = 35;
            this.btnFormCheck.Text = "Формирование кассвого чека";
            this.btnFormCheck.UseVisualStyleBackColor = true;
            // 
            // pnManipulation
            // 
            this.pnManipulation.Controls.Add(this.btnDelete);
            this.pnManipulation.Controls.Add(this.btnUpdate);
            this.pnManipulation.Controls.Add(this.btnInsert);
            this.pnManipulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnManipulation.Location = new System.Drawing.Point(4, 19);
            this.pnManipulation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnManipulation.Name = "pnManipulation";
            this.pnManipulation.Size = new System.Drawing.Size(1059, 33);
            this.pnManipulation.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(706, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(353, 33);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Удалить данные автомобиля";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.Location = new System.Drawing.Point(353, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(353, 33);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Изменить данные автомобиля";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(353, 33);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Добавить данные автомобиля";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 574);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.gbManipulation);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchFiltration);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrdersForm";
            this.Text = "Справочник Заказы";
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.pnCarsClients.ResumeLayout(false);
            this.pnCarsClients.PerformLayout();
            this.gbManipulation.ResumeLayout(false);
            this.pnDocs.ResumeLayout(false);
            this.pnManipulation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Panel pnCarsClients;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.ComboBox cbCars;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.GroupBox gbManipulation;
        private System.Windows.Forms.Panel pnDocs;
        private System.Windows.Forms.Button btnFormAct;
        private System.Windows.Forms.Button btnFormCheck;
        private System.Windows.Forms.Panel pnManipulation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}