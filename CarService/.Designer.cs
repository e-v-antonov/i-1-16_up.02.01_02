﻿namespace CarService
{
    partial class CarsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_search_filtration = new System.Windows.Forms.GroupBox();
            this.chb_filtration = new System.Windows.Forms.CheckBox();
            this.tb_search_filtration = new System.Windows.Forms.TextBox();
            this.gb_manipulation = new System.Windows.Forms.GroupBox();
            this.pn_client_formKlients = new System.Windows.Forms.Panel();
            this.btn_from_clients = new System.Windows.Forms.Button();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.lbl_client = new System.Windows.Forms.Label();
            this.pn_color_year_made = new System.Windows.Forms.Panel();
            this.tb_year_made = new System.Windows.Forms.TextBox();
            this.lbl_year_made = new System.Windows.Forms.Label();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.pn_brand_model = new System.Windows.Forms.Panel();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.tb_brand = new System.Windows.Forms.TextBox();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.pn_reg_vim = new System.Windows.Forms.Panel();
            this.tb_vim = new System.Windows.Forms.TextBox();
            this.lbl_vim = new System.Windows.Forms.Label();
            this.tb_register_sign = new System.Windows.Forms.TextBox();
            this.lbl_registration_plate = new System.Windows.Forms.Label();
            this.pn_manipulation = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.pn_cancel = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_errors = new System.Windows.Forms.Button();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.gb_search_filtration.SuspendLayout();
            this.gb_manipulation.SuspendLayout();
            this.pn_client_formKlients.SuspendLayout();
            this.pn_color_year_made.SuspendLayout();
            this.pn_brand_model.SuspendLayout();
            this.pn_reg_vim.SuspendLayout();
            this.pn_manipulation.SuspendLayout();
            this.pn_cancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_search_filtration
            // 
            this.gb_search_filtration.Controls.Add(this.chb_filtration);
            this.gb_search_filtration.Controls.Add(this.tb_search_filtration);
            this.gb_search_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_search_filtration.Location = new System.Drawing.Point(0, 0);
            this.gb_search_filtration.Margin = new System.Windows.Forms.Padding(4);
            this.gb_search_filtration.Name = "gb_search_filtration";
            this.gb_search_filtration.Padding = new System.Windows.Forms.Padding(4);
            this.gb_search_filtration.Size = new System.Drawing.Size(833, 47);
            this.gb_search_filtration.TabIndex = 0;
            this.gb_search_filtration.TabStop = false;
            this.gb_search_filtration.Text = "Поиск и фильтрация";
            // 
            // chb_filtration
            // 
            this.chb_filtration.AutoSize = true;
            this.chb_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chb_filtration.Location = new System.Drawing.Point(684, 19);
            this.chb_filtration.Margin = new System.Windows.Forms.Padding(4);
            this.chb_filtration.Name = "chb_filtration";
            this.chb_filtration.Size = new System.Drawing.Size(145, 21);
            this.chb_filtration.TabIndex = 1;
            this.chb_filtration.Text = "Отфильтровать";
            this.chb_filtration.UseVisualStyleBackColor = true;
            // 
            // tb_search_filtration
            // 
            this.tb_search_filtration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_search_filtration.Location = new System.Drawing.Point(4, 19);
            this.tb_search_filtration.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search_filtration.Name = "tb_search_filtration";
            this.tb_search_filtration.Size = new System.Drawing.Size(680, 22);
            this.tb_search_filtration.TabIndex = 0;
            // 
            // gb_manipulation
            // 
            this.gb_manipulation.Controls.Add(this.pn_client_formKlients);
            this.gb_manipulation.Controls.Add(this.pn_color_year_made);
            this.gb_manipulation.Controls.Add(this.pn_brand_model);
            this.gb_manipulation.Controls.Add(this.pn_reg_vim);
            this.gb_manipulation.Controls.Add(this.pn_manipulation);
            this.gb_manipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_manipulation.Location = new System.Drawing.Point(0, 379);
            this.gb_manipulation.Margin = new System.Windows.Forms.Padding(4);
            this.gb_manipulation.Name = "gb_manipulation";
            this.gb_manipulation.Padding = new System.Windows.Forms.Padding(4);
            this.gb_manipulation.Size = new System.Drawing.Size(833, 139);
            this.gb_manipulation.TabIndex = 2;
            this.gb_manipulation.TabStop = false;
            this.gb_manipulation.Text = "Манипуляция данными";
            // 
            // pn_client_formKlients
            // 
            this.pn_client_formKlients.Controls.Add(this.btn_from_clients);
            this.pn_client_formKlients.Controls.Add(this.cb_client);
            this.pn_client_formKlients.Controls.Add(this.lbl_client);
            this.pn_client_formKlients.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_client_formKlients.Location = new System.Drawing.Point(595, 19);
            this.pn_client_formKlients.Margin = new System.Windows.Forms.Padding(4);
            this.pn_client_formKlients.Name = "pn_client_formKlients";
            this.pn_client_formKlients.Size = new System.Drawing.Size(234, 81);
            this.pn_client_formKlients.TabIndex = 43;
            // 
            // btn_from_clients
            // 
            this.btn_from_clients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_from_clients.Location = new System.Drawing.Point(0, 53);
            this.btn_from_clients.Margin = new System.Windows.Forms.Padding(4);
            this.btn_from_clients.Name = "btn_from_clients";
            this.btn_from_clients.Size = new System.Drawing.Size(234, 28);
            this.btn_from_clients.TabIndex = 31;
            this.btn_from_clients.Text = "Клиенты";
            this.btn_from_clients.UseVisualStyleBackColor = true;
            // 
            // cb_client
            // 
            this.cb_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(0, 17);
            this.cb_client.Margin = new System.Windows.Forms.Padding(4);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(234, 24);
            this.cb_client.TabIndex = 30;
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_client.Location = new System.Drawing.Point(0, 0);
            this.lbl_client.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(56, 17);
            this.lbl_client.TabIndex = 29;
            this.lbl_client.Text = "Клиент";
            // 
            // pn_color_year_made
            // 
            this.pn_color_year_made.Controls.Add(this.tb_year_made);
            this.pn_color_year_made.Controls.Add(this.lbl_year_made);
            this.pn_color_year_made.Controls.Add(this.tb_color);
            this.pn_color_year_made.Controls.Add(this.lbl_color);
            this.pn_color_year_made.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_color_year_made.Location = new System.Drawing.Point(398, 19);
            this.pn_color_year_made.Margin = new System.Windows.Forms.Padding(4);
            this.pn_color_year_made.Name = "pn_color_year_made";
            this.pn_color_year_made.Size = new System.Drawing.Size(197, 83);
            this.pn_color_year_made.TabIndex = 42;
            // 
            // tb_year_made
            // 
            this.tb_year_made.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_year_made.Location = new System.Drawing.Point(0, 56);
            this.tb_year_made.Margin = new System.Windows.Forms.Padding(4);
            this.tb_year_made.Name = "tb_year_made";
            this.tb_year_made.Size = new System.Drawing.Size(197, 22);
            this.tb_year_made.TabIndex = 30;
            // 
            // lbl_year_made
            // 
            this.lbl_year_made.AutoSize = true;
            this.lbl_year_made.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_year_made.Location = new System.Drawing.Point(0, 39);
            this.lbl_year_made.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_year_made.Name = "lbl_year_made";
            this.lbl_year_made.Size = new System.Drawing.Size(90, 17);
            this.lbl_year_made.TabIndex = 29;
            this.lbl_year_made.Text = "Год выпуска";
            // 
            // tb_color
            // 
            this.tb_color.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_color.Location = new System.Drawing.Point(0, 17);
            this.tb_color.Margin = new System.Windows.Forms.Padding(4);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(197, 22);
            this.tb_color.TabIndex = 28;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_color.Location = new System.Drawing.Point(0, 0);
            this.lbl_color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(41, 17);
            this.lbl_color.TabIndex = 27;
            this.lbl_color.Text = "Цвет";
            // 
            // pn_brand_model
            // 
            this.pn_brand_model.Controls.Add(this.tb_model);
            this.pn_brand_model.Controls.Add(this.lbl_model);
            this.pn_brand_model.Controls.Add(this.tb_brand);
            this.pn_brand_model.Controls.Add(this.lbl_brand);
            this.pn_brand_model.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_brand_model.Location = new System.Drawing.Point(201, 19);
            this.pn_brand_model.Margin = new System.Windows.Forms.Padding(4);
            this.pn_brand_model.Name = "pn_brand_model";
            this.pn_brand_model.Size = new System.Drawing.Size(197, 83);
            this.pn_brand_model.TabIndex = 41;
            // 
            // tb_model
            // 
            this.tb_model.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_model.Location = new System.Drawing.Point(0, 56);
            this.tb_model.Margin = new System.Windows.Forms.Padding(4);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(197, 22);
            this.tb_model.TabIndex = 30;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_model.Location = new System.Drawing.Point(0, 39);
            this.lbl_model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(58, 17);
            this.lbl_model.TabIndex = 29;
            this.lbl_model.Text = "Модель";
            // 
            // tb_brand
            // 
            this.tb_brand.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_brand.Location = new System.Drawing.Point(0, 17);
            this.tb_brand.Margin = new System.Windows.Forms.Padding(4);
            this.tb_brand.Name = "tb_brand";
            this.tb_brand.Size = new System.Drawing.Size(197, 22);
            this.tb_brand.TabIndex = 28;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_brand.Location = new System.Drawing.Point(0, 0);
            this.lbl_brand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(50, 17);
            this.lbl_brand.TabIndex = 27;
            this.lbl_brand.Text = "Марка";
            // 
            // pn_reg_vim
            // 
            this.pn_reg_vim.Controls.Add(this.tb_vim);
            this.pn_reg_vim.Controls.Add(this.lbl_vim);
            this.pn_reg_vim.Controls.Add(this.tb_register_sign);
            this.pn_reg_vim.Controls.Add(this.lbl_registration_plate);
            this.pn_reg_vim.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_reg_vim.Location = new System.Drawing.Point(4, 19);
            this.pn_reg_vim.Margin = new System.Windows.Forms.Padding(4);
            this.pn_reg_vim.Name = "pn_reg_vim";
            this.pn_reg_vim.Size = new System.Drawing.Size(197, 83);
            this.pn_reg_vim.TabIndex = 40;
            // 
            // tb_vim
            // 
            this.tb_vim.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_vim.Location = new System.Drawing.Point(0, 56);
            this.tb_vim.Margin = new System.Windows.Forms.Padding(4);
            this.tb_vim.Name = "tb_vim";
            this.tb_vim.Size = new System.Drawing.Size(197, 22);
            this.tb_vim.TabIndex = 30;
            // 
            // lbl_vim
            // 
            this.lbl_vim.AutoSize = true;
            this.lbl_vim.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_vim.Location = new System.Drawing.Point(0, 39);
            this.lbl_vim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vim.Name = "lbl_vim";
            this.lbl_vim.Size = new System.Drawing.Size(194, 17);
            this.lbl_vim.TabIndex = 29;
            this.lbl_vim.Text = "Идентификационный номер";
            // 
            // tb_register_sign
            // 
            this.tb_register_sign.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_register_sign.Location = new System.Drawing.Point(0, 17);
            this.tb_register_sign.Margin = new System.Windows.Forms.Padding(4);
            this.tb_register_sign.Name = "tb_register_sign";
            this.tb_register_sign.Size = new System.Drawing.Size(197, 22);
            this.tb_register_sign.TabIndex = 28;
            // 
            // lbl_registration_plate
            // 
            this.lbl_registration_plate.AutoSize = true;
            this.lbl_registration_plate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_registration_plate.Location = new System.Drawing.Point(0, 0);
            this.lbl_registration_plate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_registration_plate.Name = "lbl_registration_plate";
            this.lbl_registration_plate.Size = new System.Drawing.Size(160, 17);
            this.lbl_registration_plate.TabIndex = 27;
            this.lbl_registration_plate.Text = "Регистрационный знак";
            // 
            // pn_manipulation
            // 
            this.pn_manipulation.Controls.Add(this.btn_delete);
            this.pn_manipulation.Controls.Add(this.btn_update);
            this.pn_manipulation.Controls.Add(this.btn_insert);
            this.pn_manipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_manipulation.Location = new System.Drawing.Point(4, 102);
            this.pn_manipulation.Margin = new System.Windows.Forms.Padding(4);
            this.pn_manipulation.Name = "pn_manipulation";
            this.pn_manipulation.Size = new System.Drawing.Size(825, 33);
            this.pn_manipulation.TabIndex = 39;
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_delete.Location = new System.Drawing.Point(550, 0);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(275, 33);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Удалить данные автомобиля";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_update.Location = new System.Drawing.Point(275, 0);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(275, 33);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "Изменить данные автомобиля";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_insert.Location = new System.Drawing.Point(0, 0);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(275, 33);
            this.btn_insert.TabIndex = 32;
            this.btn_insert.Text = "Добавить данные автомобиля";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // pn_cancel
            // 
            this.pn_cancel.Controls.Add(this.btn_cancel);
            this.pn_cancel.Controls.Add(this.btn_errors);
            this.pn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_cancel.Location = new System.Drawing.Point(0, 518);
            this.pn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.pn_cancel.Name = "pn_cancel";
            this.pn_cancel.Size = new System.Drawing.Size(833, 31);
            this.pn_cancel.TabIndex = 35;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.Location = new System.Drawing.Point(612, 0);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(221, 31);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "Закрыть";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_errors
            // 
            this.btn_errors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_errors.Location = new System.Drawing.Point(0, 0);
            this.btn_errors.Margin = new System.Windows.Forms.Padding(4);
            this.btn_errors.Name = "btn_errors";
            this.btn_errors.Size = new System.Drawing.Size(221, 31);
            this.btn_errors.TabIndex = 35;
            this.btn_errors.Text = "Ошибки";
            this.btn_errors.UseVisualStyleBackColor = true;
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.BackgroundColor = System.Drawing.Color.White;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCars.Location = new System.Drawing.Point(0, 47);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.Size = new System.Drawing.Size(833, 332);
            this.dgvCars.TabIndex = 36;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 549);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.gb_manipulation);
            this.Controls.Add(this.pn_cancel);
            this.Controls.Add(this.gb_search_filtration);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarsForm";
            this.Text = "Справочник Автомобили";
            this.gb_search_filtration.ResumeLayout(false);
            this.gb_search_filtration.PerformLayout();
            this.gb_manipulation.ResumeLayout(false);
            this.pn_client_formKlients.ResumeLayout(false);
            this.pn_client_formKlients.PerformLayout();
            this.pn_color_year_made.ResumeLayout(false);
            this.pn_color_year_made.PerformLayout();
            this.pn_brand_model.ResumeLayout(false);
            this.pn_brand_model.PerformLayout();
            this.pn_reg_vim.ResumeLayout(false);
            this.pn_reg_vim.PerformLayout();
            this.pn_manipulation.ResumeLayout(false);
            this.pn_cancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_search_filtration;
        private System.Windows.Forms.CheckBox chb_filtration;
        private System.Windows.Forms.TextBox tb_search_filtration;
        private System.Windows.Forms.GroupBox gb_manipulation;
        private System.Windows.Forms.Panel pn_client_formKlients;
        private System.Windows.Forms.Button btn_from_clients;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.Panel pn_color_year_made;
        private System.Windows.Forms.TextBox tb_year_made;
        private System.Windows.Forms.Label lbl_year_made;
        private System.Windows.Forms.TextBox tb_color;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Panel pn_brand_model;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.TextBox tb_brand;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Panel pn_reg_vim;
        private System.Windows.Forms.TextBox tb_vim;
        private System.Windows.Forms.Label lbl_vim;
        private System.Windows.Forms.TextBox tb_register_sign;
        private System.Windows.Forms.Label lbl_registration_plate;
        private System.Windows.Forms.Panel pn_manipulation;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Panel pn_cancel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_errors;
        private System.Windows.Forms.DataGridView dgvCars;
    }
}
