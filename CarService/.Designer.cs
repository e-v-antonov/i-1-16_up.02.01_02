namespace CarService
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
            this.dgv_cars = new System.Windows.Forms.DataGridView();
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
            this.tb_registration_plate = new System.Windows.Forms.TextBox();
            this.lbl_registration_plate = new System.Windows.Forms.Label();
            this.pn_manipulation = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.pn_cancel = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_errors = new System.Windows.Forms.Button();
            this.gb_search_filtration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cars)).BeginInit();
            this.gb_manipulation.SuspendLayout();
            this.pn_client_formKlients.SuspendLayout();
            this.pn_color_year_made.SuspendLayout();
            this.pn_brand_model.SuspendLayout();
            this.pn_reg_vim.SuspendLayout();
            this.pn_manipulation.SuspendLayout();
            this.pn_cancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_search_filtration
            // 
            this.gb_search_filtration.Controls.Add(this.chb_filtration);
            this.gb_search_filtration.Controls.Add(this.tb_search_filtration);
            this.gb_search_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_search_filtration.Location = new System.Drawing.Point(0, 0);
            this.gb_search_filtration.Name = "gb_search_filtration";
            this.gb_search_filtration.Size = new System.Drawing.Size(625, 38);
            this.gb_search_filtration.TabIndex = 0;
            this.gb_search_filtration.TabStop = false;
            this.gb_search_filtration.Text = "Поиск и фильтрация";
            // 
            // chb_filtration
            // 
            this.chb_filtration.AutoSize = true;
            this.chb_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chb_filtration.Location = new System.Drawing.Point(514, 16);
            this.chb_filtration.Name = "chb_filtration";
            this.chb_filtration.Size = new System.Drawing.Size(108, 17);
            this.chb_filtration.TabIndex = 1;
            this.chb_filtration.Text = "Отфильтровать";
            this.chb_filtration.UseVisualStyleBackColor = true;
            // 
            // tb_search_filtration
            // 
            this.tb_search_filtration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_search_filtration.Location = new System.Drawing.Point(3, 16);
            this.tb_search_filtration.Name = "tb_search_filtration";
            this.tb_search_filtration.Size = new System.Drawing.Size(511, 20);
            this.tb_search_filtration.TabIndex = 0;
            // 
            // dgv_cars
            // 
            this.dgv_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cars.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_cars.Location = new System.Drawing.Point(0, 38);
            this.dgv_cars.Name = "dgv_cars";
            this.dgv_cars.Size = new System.Drawing.Size(625, 238);
            this.dgv_cars.TabIndex = 1;
            // 
            // gb_manipulation
            // 
            this.gb_manipulation.Controls.Add(this.pn_client_formKlients);
            this.gb_manipulation.Controls.Add(this.pn_color_year_made);
            this.gb_manipulation.Controls.Add(this.pn_brand_model);
            this.gb_manipulation.Controls.Add(this.pn_reg_vim);
            this.gb_manipulation.Controls.Add(this.pn_manipulation);
            this.gb_manipulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_manipulation.Location = new System.Drawing.Point(0, 276);
            this.gb_manipulation.Name = "gb_manipulation";
            this.gb_manipulation.Size = new System.Drawing.Size(625, 113);
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
            this.pn_client_formKlients.Location = new System.Drawing.Point(447, 16);
            this.pn_client_formKlients.Name = "pn_client_formKlients";
            this.pn_client_formKlients.Size = new System.Drawing.Size(175, 66);
            this.pn_client_formKlients.TabIndex = 43;
            // 
            // btn_from_clients
            // 
            this.btn_from_clients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_from_clients.Location = new System.Drawing.Point(0, 43);
            this.btn_from_clients.Name = "btn_from_clients";
            this.btn_from_clients.Size = new System.Drawing.Size(175, 23);
            this.btn_from_clients.TabIndex = 31;
            this.btn_from_clients.Text = "Клиенты";
            this.btn_from_clients.UseVisualStyleBackColor = true;
            // 
            // cb_client
            // 
            this.cb_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(0, 13);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(175, 21);
            this.cb_client.TabIndex = 30;
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_client.Location = new System.Drawing.Point(0, 0);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(43, 13);
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
            this.pn_color_year_made.Location = new System.Drawing.Point(299, 16);
            this.pn_color_year_made.Name = "pn_color_year_made";
            this.pn_color_year_made.Size = new System.Drawing.Size(148, 67);
            this.pn_color_year_made.TabIndex = 42;
            // 
            // tb_year_made
            // 
            this.tb_year_made.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_year_made.Location = new System.Drawing.Point(0, 46);
            this.tb_year_made.Name = "tb_year_made";
            this.tb_year_made.Size = new System.Drawing.Size(148, 20);
            this.tb_year_made.TabIndex = 30;
            // 
            // lbl_year_made
            // 
            this.lbl_year_made.AutoSize = true;
            this.lbl_year_made.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_year_made.Location = new System.Drawing.Point(0, 33);
            this.lbl_year_made.Name = "lbl_year_made";
            this.lbl_year_made.Size = new System.Drawing.Size(71, 13);
            this.lbl_year_made.TabIndex = 29;
            this.lbl_year_made.Text = "Год выпуска";
            // 
            // tb_color
            // 
            this.tb_color.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_color.Location = new System.Drawing.Point(0, 13);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(148, 20);
            this.tb_color.TabIndex = 28;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_color.Location = new System.Drawing.Point(0, 0);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(32, 13);
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
            this.pn_brand_model.Location = new System.Drawing.Point(151, 16);
            this.pn_brand_model.Name = "pn_brand_model";
            this.pn_brand_model.Size = new System.Drawing.Size(148, 67);
            this.pn_brand_model.TabIndex = 41;
            // 
            // tb_model
            // 
            this.tb_model.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_model.Location = new System.Drawing.Point(0, 46);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(148, 20);
            this.tb_model.TabIndex = 30;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_model.Location = new System.Drawing.Point(0, 33);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(46, 13);
            this.lbl_model.TabIndex = 29;
            this.lbl_model.Text = "Модель";
            // 
            // tb_brand
            // 
            this.tb_brand.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_brand.Location = new System.Drawing.Point(0, 13);
            this.tb_brand.Name = "tb_brand";
            this.tb_brand.Size = new System.Drawing.Size(148, 20);
            this.tb_brand.TabIndex = 28;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_brand.Location = new System.Drawing.Point(0, 0);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(40, 13);
            this.lbl_brand.TabIndex = 27;
            this.lbl_brand.Text = "Марка";
            // 
            // pn_reg_vim
            // 
            this.pn_reg_vim.Controls.Add(this.tb_vim);
            this.pn_reg_vim.Controls.Add(this.lbl_vim);
            this.pn_reg_vim.Controls.Add(this.tb_registration_plate);
            this.pn_reg_vim.Controls.Add(this.lbl_registration_plate);
            this.pn_reg_vim.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_reg_vim.Location = new System.Drawing.Point(3, 16);
            this.pn_reg_vim.Name = "pn_reg_vim";
            this.pn_reg_vim.Size = new System.Drawing.Size(148, 67);
            this.pn_reg_vim.TabIndex = 40;
            // 
            // tb_vim
            // 
            this.tb_vim.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_vim.Location = new System.Drawing.Point(0, 46);
            this.tb_vim.Name = "tb_vim";
            this.tb_vim.Size = new System.Drawing.Size(148, 20);
            this.tb_vim.TabIndex = 30;
            // 
            // lbl_vim
            // 
            this.lbl_vim.AutoSize = true;
            this.lbl_vim.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_vim.Location = new System.Drawing.Point(0, 33);
            this.lbl_vim.Name = "lbl_vim";
            this.lbl_vim.Size = new System.Drawing.Size(149, 13);
            this.lbl_vim.TabIndex = 29;
            this.lbl_vim.Text = "Идентификационный номер";
            // 
            // tb_registration_plate
            // 
            this.tb_registration_plate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_registration_plate.Location = new System.Drawing.Point(0, 13);
            this.tb_registration_plate.Name = "tb_registration_plate";
            this.tb_registration_plate.Size = new System.Drawing.Size(148, 20);
            this.tb_registration_plate.TabIndex = 28;
            // 
            // lbl_registration_plate
            // 
            this.lbl_registration_plate.AutoSize = true;
            this.lbl_registration_plate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_registration_plate.Location = new System.Drawing.Point(0, 0);
            this.lbl_registration_plate.Name = "lbl_registration_plate";
            this.lbl_registration_plate.Size = new System.Drawing.Size(125, 13);
            this.lbl_registration_plate.TabIndex = 27;
            this.lbl_registration_plate.Text = "Регистрационный знак";
            // 
            // pn_manipulation
            // 
            this.pn_manipulation.Controls.Add(this.btn_delete);
            this.pn_manipulation.Controls.Add(this.btn_update);
            this.pn_manipulation.Controls.Add(this.btn_insert);
            this.pn_manipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_manipulation.Location = new System.Drawing.Point(3, 83);
            this.pn_manipulation.Name = "pn_manipulation";
            this.pn_manipulation.Size = new System.Drawing.Size(619, 27);
            this.pn_manipulation.TabIndex = 39;
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_delete.Location = new System.Drawing.Point(412, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(206, 27);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Удалить данные автомобиля";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_update.Location = new System.Drawing.Point(206, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(206, 27);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "Изменить данные автомобиля";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_insert.Location = new System.Drawing.Point(0, 0);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(206, 27);
            this.btn_insert.TabIndex = 32;
            this.btn_insert.Text = "Добавить данные автомобиля";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // pn_cancel
            // 
            this.pn_cancel.Controls.Add(this.btn_cancel);
            this.pn_cancel.Controls.Add(this.btn_errors);
            this.pn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_cancel.Location = new System.Drawing.Point(0, 421);
            this.pn_cancel.Name = "pn_cancel";
            this.pn_cancel.Size = new System.Drawing.Size(625, 25);
            this.pn_cancel.TabIndex = 35;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.Location = new System.Drawing.Point(459, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(166, 25);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "Закрыть";
            this.btn_cancel.UseVisualStyleBackColor = true;
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
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 446);
            this.Controls.Add(this.pn_cancel);
            this.Controls.Add(this.gb_manipulation);
            this.Controls.Add(this.dgv_cars);
            this.Controls.Add(this.gb_search_filtration);
            this.Name = "CarsForm";
            this.Text = "Справочник Автомобили";
            this.gb_search_filtration.ResumeLayout(false);
            this.gb_search_filtration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cars)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_search_filtration;
        private System.Windows.Forms.CheckBox chb_filtration;
        private System.Windows.Forms.TextBox tb_search_filtration;
        private System.Windows.Forms.DataGridView dgv_cars;
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
        private System.Windows.Forms.TextBox tb_registration_plate;
        private System.Windows.Forms.Label lbl_registration_plate;
        private System.Windows.Forms.Panel pn_manipulation;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Panel pn_cancel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_errors;
    }
}

