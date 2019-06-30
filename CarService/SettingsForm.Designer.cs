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
            this.pn_color = new System.Windows.Forms.Panel();
            this.cb_color = new System.Windows.Forms.ComboBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.pn_language = new System.Windows.Forms.Panel();
            this.btn_eng_language = new System.Windows.Forms.Button();
            this.btn_rus_language = new System.Windows.Forms.Button();
            this.btn_file_path = new System.Windows.Forms.Button();
            this.pn_file_path = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pn_cancel = new System.Windows.Forms.Panel();
            this.pn_margin = new System.Windows.Forms.Panel();
            this.lbl_file_path = new System.Windows.Forms.Label();
            this.tb_file_path = new System.Windows.Forms.TextBox();
            this.tb_bottom_margin = new System.Windows.Forms.TextBox();
            this.lbl_bottom_margin = new System.Windows.Forms.Label();
            this.lbl_top_margin = new System.Windows.Forms.Label();
            this.tb_top_margin = new System.Windows.Forms.TextBox();
            this.lbl_right_margin = new System.Windows.Forms.Label();
            this.pn_right_margin = new System.Windows.Forms.Panel();
            this.pn_left_margin = new System.Windows.Forms.Panel();
            this.tb_left_margin = new System.Windows.Forms.TextBox();
            this.lbl_left_margin = new System.Windows.Forms.Label();
            this.tb_right_margin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_color.SuspendLayout();
            this.pn_language.SuspendLayout();
            this.pn_file_path.SuspendLayout();
            this.pn_cancel.SuspendLayout();
            this.pn_margin.SuspendLayout();
            this.pn_right_margin.SuspendLayout();
            this.pn_left_margin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_color
            // 
            this.pn_color.Controls.Add(this.cb_color);
            this.pn_color.Controls.Add(this.lbl_color);
            this.pn_color.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_color.Location = new System.Drawing.Point(0, 0);
            this.pn_color.Name = "pn_color";
            this.pn_color.Size = new System.Drawing.Size(494, 39);
            this.pn_color.TabIndex = 0;
            // 
            // cb_color
            // 
            this.cb_color.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_color.FormattingEnabled = true;
            this.cb_color.Location = new System.Drawing.Point(0, 13);
            this.cb_color.Name = "cb_color";
            this.cb_color.Size = new System.Drawing.Size(121, 21);
            this.cb_color.TabIndex = 3;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_color.Location = new System.Drawing.Point(0, 0);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(124, 13);
            this.lbl_color.TabIndex = 2;
            this.lbl_color.Text = "Цвет окон приложения";
            // 
            // pn_language
            // 
            this.pn_language.Controls.Add(this.btn_eng_language);
            this.pn_language.Controls.Add(this.btn_rus_language);
            this.pn_language.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_language.Location = new System.Drawing.Point(0, 39);
            this.pn_language.Name = "pn_language";
            this.pn_language.Size = new System.Drawing.Size(494, 31);
            this.pn_language.TabIndex = 5;
            // 
            // btn_eng_language
            // 
            this.btn_eng_language.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_eng_language.Location = new System.Drawing.Point(366, 0);
            this.btn_eng_language.Name = "btn_eng_language";
            this.btn_eng_language.Size = new System.Drawing.Size(128, 31);
            this.btn_eng_language.TabIndex = 4;
            this.btn_eng_language.Text = "Английский язык";
            this.btn_eng_language.UseVisualStyleBackColor = true;
            // 
            // btn_rus_language
            // 
            this.btn_rus_language.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_rus_language.Location = new System.Drawing.Point(0, 0);
            this.btn_rus_language.Name = "btn_rus_language";
            this.btn_rus_language.Size = new System.Drawing.Size(128, 31);
            this.btn_rus_language.TabIndex = 0;
            this.btn_rus_language.Text = "Русский язык";
            this.btn_rus_language.UseVisualStyleBackColor = true;
            // 
            // btn_file_path
            // 
            this.btn_file_path.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_file_path.Location = new System.Drawing.Point(419, 0);
            this.btn_file_path.Name = "btn_file_path";
            this.btn_file_path.Size = new System.Drawing.Size(75, 36);
            this.btn_file_path.TabIndex = 7;
            this.btn_file_path.Text = "Обзор";
            this.btn_file_path.UseVisualStyleBackColor = true;
            // 
            // pn_file_path
            // 
            this.pn_file_path.Controls.Add(this.tb_file_path);
            this.pn_file_path.Controls.Add(this.lbl_file_path);
            this.pn_file_path.Controls.Add(this.btn_file_path);
            this.pn_file_path.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_file_path.Location = new System.Drawing.Point(0, 70);
            this.pn_file_path.Name = "pn_file_path";
            this.pn_file_path.Size = new System.Drawing.Size(494, 36);
            this.pn_file_path.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_save.Location = new System.Drawing.Point(419, 0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 28);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.Location = new System.Drawing.Point(344, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Закрыть";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // pn_cancel
            // 
            this.pn_cancel.Controls.Add(this.btn_cancel);
            this.pn_cancel.Controls.Add(this.btn_save);
            this.pn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_cancel.Location = new System.Drawing.Point(0, 474);
            this.pn_cancel.Name = "pn_cancel";
            this.pn_cancel.Size = new System.Drawing.Size(494, 28);
            this.pn_cancel.TabIndex = 10;
            // 
            // pn_margin
            // 
            this.pn_margin.Controls.Add(this.panel1);
            this.pn_margin.Controls.Add(this.pn_left_margin);
            this.pn_margin.Controls.Add(this.pn_right_margin);
            this.pn_margin.Controls.Add(this.lbl_bottom_margin);
            this.pn_margin.Controls.Add(this.tb_top_margin);
            this.pn_margin.Controls.Add(this.tb_bottom_margin);
            this.pn_margin.Controls.Add(this.lbl_top_margin);
            this.pn_margin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_margin.Location = new System.Drawing.Point(0, 112);
            this.pn_margin.Name = "pn_margin";
            this.pn_margin.Size = new System.Drawing.Size(494, 362);
            this.pn_margin.TabIndex = 11;
            // 
            // lbl_file_path
            // 
            this.lbl_file_path.AutoSize = true;
            this.lbl_file_path.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_file_path.Location = new System.Drawing.Point(0, 0);
            this.lbl_file_path.Name = "lbl_file_path";
            this.lbl_file_path.Size = new System.Drawing.Size(128, 13);
            this.lbl_file_path.TabIndex = 8;
            this.lbl_file_path.Text = "Путь сохранения файла";
            // 
            // tb_file_path
            // 
            this.tb_file_path.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_file_path.Location = new System.Drawing.Point(0, 13);
            this.tb_file_path.Name = "tb_file_path";
            this.tb_file_path.Size = new System.Drawing.Size(419, 20);
            this.tb_file_path.TabIndex = 9;
            // 
            // tb_bottom_margin
            // 
            this.tb_bottom_margin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_bottom_margin.Location = new System.Drawing.Point(0, 342);
            this.tb_bottom_margin.Name = "tb_bottom_margin";
            this.tb_bottom_margin.Size = new System.Drawing.Size(494, 20);
            this.tb_bottom_margin.TabIndex = 14;
            // 
            // lbl_bottom_margin
            // 
            this.lbl_bottom_margin.AutoSize = true;
            this.lbl_bottom_margin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_bottom_margin.Location = new System.Drawing.Point(0, 329);
            this.lbl_bottom_margin.Name = "lbl_bottom_margin";
            this.lbl_bottom_margin.Size = new System.Drawing.Size(83, 13);
            this.lbl_bottom_margin.TabIndex = 24;
            this.lbl_bottom_margin.Text = "Нижний отступ";
            // 
            // lbl_top_margin
            // 
            this.lbl_top_margin.AutoSize = true;
            this.lbl_top_margin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_top_margin.Location = new System.Drawing.Point(0, 0);
            this.lbl_top_margin.Name = "lbl_top_margin";
            this.lbl_top_margin.Size = new System.Drawing.Size(85, 13);
            this.lbl_top_margin.TabIndex = 3;
            this.lbl_top_margin.Text = "Верхний отступ";
            // 
            // tb_top_margin
            // 
            this.tb_top_margin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_top_margin.Location = new System.Drawing.Point(0, 13);
            this.tb_top_margin.Name = "tb_top_margin";
            this.tb_top_margin.Size = new System.Drawing.Size(494, 20);
            this.tb_top_margin.TabIndex = 15;
            // 
            // lbl_right_margin
            // 
            this.lbl_right_margin.AutoSize = true;
            this.lbl_right_margin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_right_margin.Location = new System.Drawing.Point(0, 0);
            this.lbl_right_margin.Name = "lbl_right_margin";
            this.lbl_right_margin.Size = new System.Drawing.Size(83, 13);
            this.lbl_right_margin.TabIndex = 22;
            this.lbl_right_margin.Text = "Правый отступ";
            // 
            // pn_right_margin
            // 
            this.pn_right_margin.Controls.Add(this.tb_right_margin);
            this.pn_right_margin.Controls.Add(this.lbl_right_margin);
            this.pn_right_margin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_right_margin.Location = new System.Drawing.Point(394, 33);
            this.pn_right_margin.Name = "pn_right_margin";
            this.pn_right_margin.Size = new System.Drawing.Size(100, 296);
            this.pn_right_margin.TabIndex = 27;
            // 
            // pn_left_margin
            // 
            this.pn_left_margin.Controls.Add(this.tb_left_margin);
            this.pn_left_margin.Controls.Add(this.lbl_left_margin);
            this.pn_left_margin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_left_margin.Location = new System.Drawing.Point(0, 33);
            this.pn_left_margin.Name = "pn_left_margin";
            this.pn_left_margin.Size = new System.Drawing.Size(100, 296);
            this.pn_left_margin.TabIndex = 28;
            // 
            // tb_left_margin
            // 
            this.tb_left_margin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_left_margin.Location = new System.Drawing.Point(0, 13);
            this.tb_left_margin.Name = "tb_left_margin";
            this.tb_left_margin.Size = new System.Drawing.Size(100, 20);
            this.tb_left_margin.TabIndex = 23;
            // 
            // lbl_left_margin
            // 
            this.lbl_left_margin.AutoSize = true;
            this.lbl_left_margin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_left_margin.Location = new System.Drawing.Point(0, 0);
            this.lbl_left_margin.Name = "lbl_left_margin";
            this.lbl_left_margin.Size = new System.Drawing.Size(77, 13);
            this.lbl_left_margin.TabIndex = 22;
            this.lbl_left_margin.Text = "Левый отступ";
            // 
            // tb_right_margin
            // 
            this.tb_right_margin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_right_margin.Location = new System.Drawing.Point(0, 13);
            this.tb_right_margin.Name = "tb_right_margin";
            this.tb_right_margin.Size = new System.Drawing.Size(100, 20);
            this.tb_right_margin.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(100, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 296);
            this.panel1.TabIndex = 29;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 502);
            this.Controls.Add(this.pn_margin);
            this.Controls.Add(this.pn_cancel);
            this.Controls.Add(this.pn_file_path);
            this.Controls.Add(this.pn_language);
            this.Controls.Add(this.pn_color);
            this.Name = "SettingsForm";
            this.Text = "Настройки приложения";
            this.pn_color.ResumeLayout(false);
            this.pn_color.PerformLayout();
            this.pn_language.ResumeLayout(false);
            this.pn_file_path.ResumeLayout(false);
            this.pn_file_path.PerformLayout();
            this.pn_cancel.ResumeLayout(false);
            this.pn_margin.ResumeLayout(false);
            this.pn_margin.PerformLayout();
            this.pn_right_margin.ResumeLayout(false);
            this.pn_right_margin.PerformLayout();
            this.pn_left_margin.ResumeLayout(false);
            this.pn_left_margin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_color;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.ComboBox cb_color;
        private System.Windows.Forms.Panel pn_language;
        private System.Windows.Forms.Button btn_eng_language;
        private System.Windows.Forms.Button btn_rus_language;
        private System.Windows.Forms.Button btn_file_path;
        private System.Windows.Forms.Panel pn_file_path;
        private System.Windows.Forms.TextBox tb_file_path;
        private System.Windows.Forms.Label lbl_file_path;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel pn_cancel;
        private System.Windows.Forms.Panel pn_margin;
        private System.Windows.Forms.Panel pn_left_margin;
        private System.Windows.Forms.TextBox tb_left_margin;
        private System.Windows.Forms.Label lbl_left_margin;
        private System.Windows.Forms.Panel pn_right_margin;
        private System.Windows.Forms.TextBox tb_right_margin;
        private System.Windows.Forms.Label lbl_right_margin;
        private System.Windows.Forms.Label lbl_bottom_margin;
        private System.Windows.Forms.TextBox tb_top_margin;
        private System.Windows.Forms.TextBox tb_bottom_margin;
        private System.Windows.Forms.Label lbl_top_margin;
        private System.Windows.Forms.Panel panel1;
    }
}