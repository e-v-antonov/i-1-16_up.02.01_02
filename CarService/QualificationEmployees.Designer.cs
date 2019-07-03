namespace CarService
{
    partial class QualificationEmployees
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
            this.pnSearch = new System.Windows.Forms.Panel();
            this.lbQualification = new System.Windows.Forms.ListBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbNameQualification = new System.Windows.Forms.TextBox();
            this.lblNameQualification = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.gbManipulation = new System.Windows.Forms.GroupBox();
            this.pnSearch.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbManipulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Controls.Add(this.lblSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(438, 40);
            this.pnSearch.TabIndex = 2;
            // 
            // lbQualification
            // 
            this.lbQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQualification.FormattingEnabled = true;
            this.lbQualification.ItemHeight = 16;
            this.lbQualification.Location = new System.Drawing.Point(0, 40);
            this.lbQualification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbQualification.Name = "lbQualification";
            this.lbQualification.Size = new System.Drawing.Size(438, 263);
            this.lbQualification.TabIndex = 3;
            this.lbQualification.Click += new System.EventHandler(this.lbQualification_Click);
            this.lbQualification.SelectedIndexChanged += new System.EventHandler(this.lbQualification_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(0, 17);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(438, 22);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.Text = "Введите название квалификации...";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearch.Location = new System.Drawing.Point(0, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(148, 17);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Поиск квалификации";
            // 
            // tbNameQualification
            // 
            this.tbNameQualification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbNameQualification.Location = new System.Drawing.Point(3, 36);
            this.tbNameQualification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNameQualification.Name = "tbNameQualification";
            this.tbNameQualification.Size = new System.Drawing.Size(432, 22);
            this.tbNameQualification.TabIndex = 45;
            // 
            // lblNameQualification
            // 
            this.lblNameQualification.AutoSize = true;
            this.lblNameQualification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNameQualification.Location = new System.Drawing.Point(3, 19);
            this.lblNameQualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameQualification.Name = "lblNameQualification";
            this.lblNameQualification.Size = new System.Drawing.Size(172, 17);
            this.lblNameQualification.TabIndex = 44;
            this.lblNameQualification.Text = "Название квалификации";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(3, 122);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(432, 32);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Удалить данные услуги";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdate.Location = new System.Drawing.Point(3, 90);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(432, 32);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Изменить данные услуги";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInsert.Location = new System.Drawing.Point(3, 58);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(432, 32);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Добавить данные услуги";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnCancel);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 460);
            this.pnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(438, 31);
            this.pnCancel.TabIndex = 47;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(342, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnErrors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Size = new System.Drawing.Size(89, 31);
            this.btnErrors.TabIndex = 35;
            this.btnErrors.Text = "Ошибки";
            this.btnErrors.UseVisualStyleBackColor = true;
            this.btnErrors.Click += new System.EventHandler(this.btnErrors_Click);
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.lblNameQualification);
            this.gbManipulation.Controls.Add(this.tbNameQualification);
            this.gbManipulation.Controls.Add(this.btnInsert);
            this.gbManipulation.Controls.Add(this.btnUpdate);
            this.gbManipulation.Controls.Add(this.btnDelete);
            this.gbManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManipulation.Location = new System.Drawing.Point(0, 303);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Size = new System.Drawing.Size(438, 157);
            this.gbManipulation.TabIndex = 48;
            this.gbManipulation.TabStop = false;
            this.gbManipulation.Text = "Манипулирование данными";
            // 
            // QualificationEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 491);
            this.Controls.Add(this.lbQualification);
            this.Controls.Add(this.gbManipulation);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.pnSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QualificationEmployees";
            this.Text = "Справочник Квалификация сотрудника";
            this.Load += new System.EventHandler(this.QualificationEmployees_Load);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbManipulation.ResumeLayout(false);
            this.gbManipulation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.ListBox lbQualification;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbNameQualification;
        private System.Windows.Forms.Label lblNameQualification;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.GroupBox gbManipulation;
    }
}