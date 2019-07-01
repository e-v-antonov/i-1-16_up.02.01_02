namespace CarService
{
    partial class SettingsForm
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
            this.pnColor = new System.Windows.Forms.Panel();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.pnLanguage = new System.Windows.Forms.Panel();
            this.btnEngLanguage = new System.Windows.Forms.Button();
            this.btnRusLanguage = new System.Windows.Forms.Button();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.pnFilePath = new System.Windows.Forms.Panel();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.pnMargin = new System.Windows.Forms.Panel();
            this.pnMarginView = new System.Windows.Forms.Panel();
            this.pnLeftMargin = new System.Windows.Forms.Panel();
            this.tbLeftMargin = new System.Windows.Forms.TextBox();
            this.lblLeftMargin = new System.Windows.Forms.Label();
            this.pnRightMargin = new System.Windows.Forms.Panel();
            this.tbRightMargin = new System.Windows.Forms.TextBox();
            this.lblRightMargin = new System.Windows.Forms.Label();
            this.lblBottomMargin = new System.Windows.Forms.Label();
            this.tbTopMargin = new System.Windows.Forms.TextBox();
            this.tbBottomMargin = new System.Windows.Forms.TextBox();
            this.lblTopMargin = new System.Windows.Forms.Label();
            this.pnColor.SuspendLayout();
            this.pnLanguage.SuspendLayout();
            this.pnFilePath.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.pnMargin.SuspendLayout();
            this.pnLeftMargin.SuspendLayout();
            this.pnRightMargin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnColor
            // 
            this.pnColor.Controls.Add(this.cbColor);
            this.pnColor.Controls.Add(this.lblColor);
            this.pnColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnColor.Location = new System.Drawing.Point(0, 0);
            this.pnColor.Name = "pnColor";
            this.pnColor.Size = new System.Drawing.Size(494, 39);
            this.pnColor.TabIndex = 0;
            // 
            // cbColor
            // 
            this.cbColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(0, 13);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 21);
            this.cbColor.TabIndex = 3;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblColor.Location = new System.Drawing.Point(0, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(124, 13);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Цвет окон приложения";
            // 
            // pnLanguage
            // 
            this.pnLanguage.Controls.Add(this.btnEngLanguage);
            this.pnLanguage.Controls.Add(this.btnRusLanguage);
            this.pnLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLanguage.Location = new System.Drawing.Point(0, 39);
            this.pnLanguage.Name = "pnLanguage";
            this.pnLanguage.Size = new System.Drawing.Size(494, 31);
            this.pnLanguage.TabIndex = 5;
            // 
            // btnEngLanguage
            // 
            this.btnEngLanguage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEngLanguage.Location = new System.Drawing.Point(366, 0);
            this.btnEngLanguage.Name = "btnEngLanguage";
            this.btnEngLanguage.Size = new System.Drawing.Size(128, 31);
            this.btnEngLanguage.TabIndex = 4;
            this.btnEngLanguage.Text = "Английский язык";
            this.btnEngLanguage.UseVisualStyleBackColor = true;
            // 
            // btnRusLanguage
            // 
            this.btnRusLanguage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRusLanguage.Location = new System.Drawing.Point(0, 0);
            this.btnRusLanguage.Name = "btnRusLanguage";
            this.btnRusLanguage.Size = new System.Drawing.Size(128, 31);
            this.btnRusLanguage.TabIndex = 0;
            this.btnRusLanguage.Text = "Русский язык";
            this.btnRusLanguage.UseVisualStyleBackColor = true;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFilePath.Location = new System.Drawing.Point(419, 0);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(75, 36);
            this.btnFilePath.TabIndex = 7;
            this.btnFilePath.Text = "Обзор";
            this.btnFilePath.UseVisualStyleBackColor = true;
            // 
            // pnFilePath
            // 
            this.pnFilePath.Controls.Add(this.tbFilePath);
            this.pnFilePath.Controls.Add(this.lblFilePath);
            this.pnFilePath.Controls.Add(this.btnFilePath);
            this.pnFilePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFilePath.Location = new System.Drawing.Point(0, 70);
            this.pnFilePath.Name = "pnFilePath";
            this.pnFilePath.Size = new System.Drawing.Size(494, 36);
            this.pnFilePath.TabIndex = 8;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFilePath.Location = new System.Drawing.Point(0, 13);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(419, 20);
            this.tbFilePath.TabIndex = 9;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilePath.Location = new System.Drawing.Point(0, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(128, 13);
            this.lblFilePath.TabIndex = 8;
            this.lblFilePath.Text = "Путь сохранения файла";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(419, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(344, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnCancel);
            this.pnCancel.Controls.Add(this.btnSave);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 474);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(494, 28);
            this.pnCancel.TabIndex = 10;
            // 
            // pnMargin
            // 
            this.pnMargin.Controls.Add(this.pnMarginView);
            this.pnMargin.Controls.Add(this.pnLeftMargin);
            this.pnMargin.Controls.Add(this.pnRightMargin);
            this.pnMargin.Controls.Add(this.lblBottomMargin);
            this.pnMargin.Controls.Add(this.tbTopMargin);
            this.pnMargin.Controls.Add(this.tbBottomMargin);
            this.pnMargin.Controls.Add(this.lblTopMargin);
            this.pnMargin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnMargin.Location = new System.Drawing.Point(0, 112);
            this.pnMargin.Name = "pnMargin";
            this.pnMargin.Size = new System.Drawing.Size(494, 362);
            this.pnMargin.TabIndex = 11;
            // 
            // pnMarginView
            // 
            this.pnMarginView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMarginView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMarginView.Location = new System.Drawing.Point(100, 33);
            this.pnMarginView.Name = "pnMarginView";
            this.pnMarginView.Size = new System.Drawing.Size(294, 296);
            this.pnMarginView.TabIndex = 29;
            // 
            // pnLeftMargin
            // 
            this.pnLeftMargin.Controls.Add(this.tbLeftMargin);
            this.pnLeftMargin.Controls.Add(this.lblLeftMargin);
            this.pnLeftMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeftMargin.Location = new System.Drawing.Point(0, 33);
            this.pnLeftMargin.Name = "pnLeftMargin";
            this.pnLeftMargin.Size = new System.Drawing.Size(100, 296);
            this.pnLeftMargin.TabIndex = 28;
            // 
            // tbLeftMargin
            // 
            this.tbLeftMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLeftMargin.Location = new System.Drawing.Point(0, 13);
            this.tbLeftMargin.Name = "tbLeftMargin";
            this.tbLeftMargin.Size = new System.Drawing.Size(100, 20);
            this.tbLeftMargin.TabIndex = 23;
            // 
            // lblLeftMargin
            // 
            this.lblLeftMargin.AutoSize = true;
            this.lblLeftMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeftMargin.Location = new System.Drawing.Point(0, 0);
            this.lblLeftMargin.Name = "lblLeftMargin";
            this.lblLeftMargin.Size = new System.Drawing.Size(77, 13);
            this.lblLeftMargin.TabIndex = 22;
            this.lblLeftMargin.Text = "Левый отступ";
            // 
            // pnRightMargin
            // 
            this.pnRightMargin.Controls.Add(this.tbRightMargin);
            this.pnRightMargin.Controls.Add(this.lblRightMargin);
            this.pnRightMargin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRightMargin.Location = new System.Drawing.Point(394, 33);
            this.pnRightMargin.Name = "pnRightMargin";
            this.pnRightMargin.Size = new System.Drawing.Size(100, 296);
            this.pnRightMargin.TabIndex = 27;
            // 
            // tbRightMargin
            // 
            this.tbRightMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbRightMargin.Location = new System.Drawing.Point(0, 13);
            this.tbRightMargin.Name = "tbRightMargin";
            this.tbRightMargin.Size = new System.Drawing.Size(100, 20);
            this.tbRightMargin.TabIndex = 24;
            // 
            // lblRightMargin
            // 
            this.lblRightMargin.AutoSize = true;
            this.lblRightMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRightMargin.Location = new System.Drawing.Point(0, 0);
            this.lblRightMargin.Name = "lblRightMargin";
            this.lblRightMargin.Size = new System.Drawing.Size(83, 13);
            this.lblRightMargin.TabIndex = 22;
            this.lblRightMargin.Text = "Правый отступ";
            // 
            // lblBottomMargin
            // 
            this.lblBottomMargin.AutoSize = true;
            this.lblBottomMargin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBottomMargin.Location = new System.Drawing.Point(0, 329);
            this.lblBottomMargin.Name = "lblBottomMargin";
            this.lblBottomMargin.Size = new System.Drawing.Size(83, 13);
            this.lblBottomMargin.TabIndex = 24;
            this.lblBottomMargin.Text = "Нижний отступ";
            // 
            // tbTopMargin
            // 
            this.tbTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTopMargin.Location = new System.Drawing.Point(0, 13);
            this.tbTopMargin.Name = "tbTopMargin";
            this.tbTopMargin.Size = new System.Drawing.Size(494, 20);
            this.tbTopMargin.TabIndex = 15;
            // 
            // tbBottomMargin
            // 
            this.tbBottomMargin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbBottomMargin.Location = new System.Drawing.Point(0, 342);
            this.tbBottomMargin.Name = "tbBottomMargin";
            this.tbBottomMargin.Size = new System.Drawing.Size(494, 20);
            this.tbBottomMargin.TabIndex = 14;
            // 
            // lblTopMargin
            // 
            this.lblTopMargin.AutoSize = true;
            this.lblTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopMargin.Location = new System.Drawing.Point(0, 0);
            this.lblTopMargin.Name = "lblTopMargin";
            this.lblTopMargin.Size = new System.Drawing.Size(85, 13);
            this.lblTopMargin.TabIndex = 3;
            this.lblTopMargin.Text = "Верхний отступ";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 502);
            this.Controls.Add(this.pnMargin);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.pnFilePath);
            this.Controls.Add(this.pnLanguage);
            this.Controls.Add(this.pnColor);
            this.Name = "SettingsForm";
            this.Text = "Настройки приложения";
            this.pnColor.ResumeLayout(false);
            this.pnColor.PerformLayout();
            this.pnLanguage.ResumeLayout(false);
            this.pnFilePath.ResumeLayout(false);
            this.pnFilePath.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.pnMargin.ResumeLayout(false);
            this.pnMargin.PerformLayout();
            this.pnLeftMargin.ResumeLayout(false);
            this.pnLeftMargin.PerformLayout();
            this.pnRightMargin.ResumeLayout(false);
            this.pnRightMargin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Panel pnLanguage;
        private System.Windows.Forms.Button btnEngLanguage;
        private System.Windows.Forms.Button btnRusLanguage;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Panel pnFilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Panel pnMargin;
        private System.Windows.Forms.Panel pnLeftMargin;
        private System.Windows.Forms.TextBox tbLeftMargin;
        private System.Windows.Forms.Label lblLeftMargin;
        private System.Windows.Forms.Panel pnRightMargin;
        private System.Windows.Forms.TextBox tbRightMargin;
        private System.Windows.Forms.Label lblRightMargin;
        private System.Windows.Forms.Label lblBottomMargin;
        private System.Windows.Forms.TextBox tbTopMargin;
        private System.Windows.Forms.TextBox tbBottomMargin;
        private System.Windows.Forms.Label lblTopMargin;
        private System.Windows.Forms.Panel pnMarginView;
    }
}