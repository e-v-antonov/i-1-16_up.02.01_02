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
            this.pnManipulation = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.pnSearch.SuspendLayout();
            this.pnManipulation.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.lbQualification);
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Controls.Add(this.lblSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(494, 304);
            this.pnSearch.TabIndex = 2;
            // 
            // lbQualification
            // 
            this.lbQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQualification.FormattingEnabled = true;
            this.lbQualification.Location = new System.Drawing.Point(0, 33);
            this.lbQualification.Name = "lbQualification";
            this.lbQualification.Size = new System.Drawing.Size(494, 271);
            this.lbQualification.TabIndex = 3;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(0, 13);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(494, 20);
            this.tbSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearch.Location = new System.Drawing.Point(0, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(116, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Поиск квалификации";
            // 
            // tbNameQualification
            // 
            this.tbNameQualification.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNameQualification.Location = new System.Drawing.Point(0, 317);
            this.tbNameQualification.Name = "tbNameQualification";
            this.tbNameQualification.Size = new System.Drawing.Size(494, 20);
            this.tbNameQualification.TabIndex = 45;
            // 
            // lblNameQualification
            // 
            this.lblNameQualification.AutoSize = true;
            this.lblNameQualification.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNameQualification.Location = new System.Drawing.Point(0, 304);
            this.lblNameQualification.Name = "lblNameQualification";
            this.lblNameQualification.Size = new System.Drawing.Size(134, 13);
            this.lblNameQualification.TabIndex = 44;
            this.lblNameQualification.Text = "Название квалификации";
            // 
            // pnManipulation
            // 
            this.pnManipulation.Controls.Add(this.btnDelete);
            this.pnManipulation.Controls.Add(this.btnUpdate);
            this.pnManipulation.Controls.Add(this.btnInsert);
            this.pnManipulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnManipulation.Location = new System.Drawing.Point(0, 337);
            this.pnManipulation.Name = "pnManipulation";
            this.pnManipulation.Size = new System.Drawing.Size(494, 78);
            this.pnManipulation.TabIndex = 46;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(0, 52);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(494, 26);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Удалить данные услуги";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Location = new System.Drawing.Point(0, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(494, 26);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Изменить данные услуги";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(494, 26);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Добавить данные услуги";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnCancel);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 472);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(494, 25);
            this.pnCancel.TabIndex = 47;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(422, 0);
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
            // QualificationEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 497);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.pnManipulation);
            this.Controls.Add(this.tbNameQualification);
            this.Controls.Add(this.lblNameQualification);
            this.Controls.Add(this.pnSearch);
            this.Name = "QualificationEmployees";
            this.Text = "Справочник Квалификация сотрудника";
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnManipulation.ResumeLayout(false);
            this.pnCancel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.ListBox lbQualification;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbNameQualification;
        private System.Windows.Forms.Label lblNameQualification;
        private System.Windows.Forms.Panel pnManipulation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnErrors;
    }
}