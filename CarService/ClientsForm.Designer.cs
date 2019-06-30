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
            this.btn_errors = new System.Windows.Forms.Button();
            this.pn_cancel = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.chb_filtration = new System.Windows.Forms.CheckBox();
            this.tb_search_filtration = new System.Windows.Forms.TextBox();
            this.gb_search_filtration = new System.Windows.Forms.GroupBox();
            this.pn_second_name = new System.Windows.Forms.Panel();
            this.tb_second_name = new System.Windows.Forms.TextBox();
            this.lbl_second_name = new System.Windows.Forms.Label();
            this.pn_first_name = new System.Windows.Forms.Panel();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.pn_patronynic = new System.Windows.Forms.Panel();
            this.tb_patronynic = new System.Windows.Forms.TextBox();
            this.lbl_patronynic = new System.Windows.Forms.Label();
            this.pn_phone_number = new System.Windows.Forms.Panel();
            this.tb_phone_number = new System.Windows.Forms.TextBox();
            this.lbl_phone_number = new System.Windows.Forms.Label();
            this.gb_manipulation = new System.Windows.Forms.GroupBox();
            this.pn_manipulation = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pn_cancel.SuspendLayout();
            this.gb_search_filtration.SuspendLayout();
            this.pn_second_name.SuspendLayout();
            this.pn_first_name.SuspendLayout();
            this.pn_patronynic.SuspendLayout();
            this.pn_phone_number.SuspendLayout();
            this.gb_manipulation.SuspendLayout();
            this.pn_manipulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_errors
            // 
            this.btn_errors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_errors.Location = new System.Drawing.Point(0, 0);
            this.btn_errors.Name = "btn_errors";
            this.btn_errors.Size = new System.Drawing.Size(166, 25);
            this.btn_errors.TabIndex = 35;
            this.btn_errors.Text = "Ошибки";
            this.btn_errors.UseVisualStyleBackColor = true;
            // 
            // pn_cancel
            // 
            this.pn_cancel.Controls.Add(this.btn_cancel);
            this.pn_cancel.Controls.Add(this.btn_errors);
            this.pn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_cancel.Location = new System.Drawing.Point(0, 354);
            this.pn_cancel.Name = "pn_cancel";
            this.pn_cancel.Size = new System.Drawing.Size(800, 25);
            this.pn_cancel.TabIndex = 39;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.Location = new System.Drawing.Point(634, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(166, 25);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "Закрыть";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // chb_filtration
            // 
            this.chb_filtration.AutoSize = true;
            this.chb_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chb_filtration.Location = new System.Drawing.Point(687, 16);
            this.chb_filtration.Name = "chb_filtration";
            this.chb_filtration.Size = new System.Drawing.Size(110, 17);
            this.chb_filtration.TabIndex = 1;
            this.chb_filtration.Text = "Отфильтровать";
            this.chb_filtration.UseVisualStyleBackColor = true;
            // 
            // tb_search_filtration
            // 
            this.tb_search_filtration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_search_filtration.Location = new System.Drawing.Point(3, 16);
            this.tb_search_filtration.Name = "tb_search_filtration";
            this.tb_search_filtration.Size = new System.Drawing.Size(684, 20);
            this.tb_search_filtration.TabIndex = 0;
            // 
            // gb_search_filtration
            // 
            this.gb_search_filtration.Controls.Add(this.chb_filtration);
            this.gb_search_filtration.Controls.Add(this.tb_search_filtration);
            this.gb_search_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_search_filtration.Location = new System.Drawing.Point(0, 0);
            this.gb_search_filtration.Name = "gb_search_filtration";
            this.gb_search_filtration.Size = new System.Drawing.Size(800, 38);
            this.gb_search_filtration.TabIndex = 36;
            this.gb_search_filtration.TabStop = false;
            this.gb_search_filtration.Text = "Поиск и фильтрация";
            // 
            // pn_second_name
            // 
            this.pn_second_name.Controls.Add(this.tb_second_name);
            this.pn_second_name.Controls.Add(this.lbl_second_name);
            this.pn_second_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_second_name.Location = new System.Drawing.Point(3, 16);
            this.pn_second_name.Name = "pn_second_name";
            this.pn_second_name.Size = new System.Drawing.Size(202, 33);
            this.pn_second_name.TabIndex = 40;
            // 
            // tb_second_name
            // 
            this.tb_second_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_second_name.Location = new System.Drawing.Point(0, 13);
            this.tb_second_name.Name = "tb_second_name";
            this.tb_second_name.Size = new System.Drawing.Size(202, 20);
            this.tb_second_name.TabIndex = 28;
            // 
            // lbl_second_name
            // 
            this.lbl_second_name.AutoSize = true;
            this.lbl_second_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_second_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_second_name.Name = "lbl_second_name";
            this.lbl_second_name.Size = new System.Drawing.Size(100, 13);
            this.lbl_second_name.TabIndex = 27;
            this.lbl_second_name.Text = "Фамилия клиента";
            // 
            // pn_first_name
            // 
            this.pn_first_name.Controls.Add(this.tb_first_name);
            this.pn_first_name.Controls.Add(this.lbl_first_name);
            this.pn_first_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_first_name.Location = new System.Drawing.Point(205, 16);
            this.pn_first_name.Name = "pn_first_name";
            this.pn_first_name.Size = new System.Drawing.Size(202, 33);
            this.pn_first_name.TabIndex = 41;
            // 
            // tb_first_name
            // 
            this.tb_first_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_first_name.Location = new System.Drawing.Point(0, 13);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(202, 20);
            this.tb_first_name.TabIndex = 28;
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_first_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(73, 13);
            this.lbl_first_name.TabIndex = 27;
            this.lbl_first_name.Text = "Имя клиента";
            // 
            // pn_patronynic
            // 
            this.pn_patronynic.Controls.Add(this.tb_patronynic);
            this.pn_patronynic.Controls.Add(this.lbl_patronynic);
            this.pn_patronynic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_patronynic.Location = new System.Drawing.Point(407, 16);
            this.pn_patronynic.Name = "pn_patronynic";
            this.pn_patronynic.Size = new System.Drawing.Size(202, 33);
            this.pn_patronynic.TabIndex = 42;
            // 
            // tb_patronynic
            // 
            this.tb_patronynic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_patronynic.Location = new System.Drawing.Point(0, 13);
            this.tb_patronynic.Name = "tb_patronynic";
            this.tb_patronynic.Size = new System.Drawing.Size(202, 20);
            this.tb_patronynic.TabIndex = 28;
            // 
            // lbl_patronynic
            // 
            this.lbl_patronynic.AutoSize = true;
            this.lbl_patronynic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_patronynic.Location = new System.Drawing.Point(0, 0);
            this.lbl_patronynic.Name = "lbl_patronynic";
            this.lbl_patronynic.Size = new System.Drawing.Size(98, 13);
            this.lbl_patronynic.TabIndex = 27;
            this.lbl_patronynic.Text = "Отчество клиента";
            // 
            // pn_phone_number
            // 
            this.pn_phone_number.Controls.Add(this.tb_phone_number);
            this.pn_phone_number.Controls.Add(this.lbl_phone_number);
            this.pn_phone_number.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_phone_number.Location = new System.Drawing.Point(609, 16);
            this.pn_phone_number.Name = "pn_phone_number";
            this.pn_phone_number.Size = new System.Drawing.Size(191, 33);
            this.pn_phone_number.TabIndex = 43;
            // 
            // tb_phone_number
            // 
            this.tb_phone_number.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_phone_number.Location = new System.Drawing.Point(0, 13);
            this.tb_phone_number.Name = "tb_phone_number";
            this.tb_phone_number.Size = new System.Drawing.Size(191, 20);
            this.tb_phone_number.TabIndex = 30;
            // 
            // lbl_phone_number
            // 
            this.lbl_phone_number.AutoSize = true;
            this.lbl_phone_number.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_phone_number.Location = new System.Drawing.Point(0, 0);
            this.lbl_phone_number.Name = "lbl_phone_number";
            this.lbl_phone_number.Size = new System.Drawing.Size(137, 13);
            this.lbl_phone_number.TabIndex = 29;
            this.lbl_phone_number.Text = "Номер телефона клиента";
            // 
            // gb_manipulation
            // 
            this.gb_manipulation.Controls.Add(this.pn_phone_number);
            this.gb_manipulation.Controls.Add(this.pn_patronynic);
            this.gb_manipulation.Controls.Add(this.pn_first_name);
            this.gb_manipulation.Controls.Add(this.pn_second_name);
            this.gb_manipulation.Controls.Add(this.pn_manipulation);
            this.gb_manipulation.Location = new System.Drawing.Point(0, 276);
            this.gb_manipulation.Name = "gb_manipulation";
            this.gb_manipulation.Size = new System.Drawing.Size(800, 78);
            this.gb_manipulation.TabIndex = 38;
            this.gb_manipulation.TabStop = false;
            this.gb_manipulation.Text = "Манипуляция данными";
            // 
            // pn_manipulation
            // 
            this.pn_manipulation.Controls.Add(this.btn_delete);
            this.pn_manipulation.Controls.Add(this.btn_update);
            this.pn_manipulation.Controls.Add(this.btn_insert);
            this.pn_manipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_manipulation.Location = new System.Drawing.Point(3, 49);
            this.pn_manipulation.Name = "pn_manipulation";
            this.pn_manipulation.Size = new System.Drawing.Size(794, 26);
            this.pn_manipulation.TabIndex = 39;
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_delete.Location = new System.Drawing.Point(530, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(267, 26);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Удалить данные клиента";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_update.Location = new System.Drawing.Point(265, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(265, 26);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "Изменить данные клиента";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_insert.Location = new System.Drawing.Point(0, 0);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(265, 26);
            this.btn_insert.TabIndex = 32;
            this.btn_insert.Text = "Добавить данные клиента";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(800, 316);
            this.listBox1.TabIndex = 40;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.gb_manipulation);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pn_cancel);
            this.Controls.Add(this.gb_search_filtration);
            this.Name = "ClientsForm";
            this.Text = "Справочник Клиенты";
            this.pn_cancel.ResumeLayout(false);
            this.gb_search_filtration.ResumeLayout(false);
            this.gb_search_filtration.PerformLayout();
            this.pn_second_name.ResumeLayout(false);
            this.pn_second_name.PerformLayout();
            this.pn_first_name.ResumeLayout(false);
            this.pn_first_name.PerformLayout();
            this.pn_patronynic.ResumeLayout(false);
            this.pn_patronynic.PerformLayout();
            this.pn_phone_number.ResumeLayout(false);
            this.pn_phone_number.PerformLayout();
            this.gb_manipulation.ResumeLayout(false);
            this.pn_manipulation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_errors;
        private System.Windows.Forms.Panel pn_cancel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckBox chb_filtration;
        private System.Windows.Forms.TextBox tb_search_filtration;
        private System.Windows.Forms.GroupBox gb_search_filtration;
        private System.Windows.Forms.Panel pn_second_name;
        private System.Windows.Forms.TextBox tb_second_name;
        private System.Windows.Forms.Label lbl_second_name;
        private System.Windows.Forms.Panel pn_first_name;
        private System.Windows.Forms.TextBox tb_first_name;
        private System.Windows.Forms.Label lbl_first_name;
        private System.Windows.Forms.Panel pn_patronynic;
        private System.Windows.Forms.TextBox tb_patronynic;
        private System.Windows.Forms.Label lbl_patronynic;
        private System.Windows.Forms.Panel pn_phone_number;
        private System.Windows.Forms.TextBox tb_phone_number;
        private System.Windows.Forms.Label lbl_phone_number;
        private System.Windows.Forms.GroupBox gb_manipulation;
        private System.Windows.Forms.Panel pn_manipulation;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ListBox listBox1;
    }
}