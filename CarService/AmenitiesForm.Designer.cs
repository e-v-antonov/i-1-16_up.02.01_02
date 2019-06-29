﻿namespace CarService
{
    partial class AmenitiesForm
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
            this.gb_search_filtration = new System.Windows.Forms.GroupBox();
            this.chb_filtration = new System.Windows.Forms.CheckBox();
            this.tb_search_filtration = new System.Windows.Forms.TextBox();
            this.dgv_aminities = new System.Windows.Forms.DataGridView();
            this.gb_manipulation = new System.Windows.Forms.GroupBox();
            this.pn_manipulation = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.pn_service_data = new System.Windows.Forms.Panel();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.tb_name_service = new System.Windows.Forms.TextBox();
            this.lbl_name_service = new System.Windows.Forms.Label();
            this.pn_cancel = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_errors = new System.Windows.Forms.Button();
            this.gb_search_filtration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aminities)).BeginInit();
            this.gb_manipulation.SuspendLayout();
            this.pn_manipulation.SuspendLayout();
            this.pn_service_data.SuspendLayout();
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
            this.gb_search_filtration.Size = new System.Drawing.Size(300, 38);
            this.gb_search_filtration.TabIndex = 37;
            this.gb_search_filtration.TabStop = false;
            this.gb_search_filtration.Text = "Поиск и фильтрация";
            // 
            // chb_filtration
            // 
            this.chb_filtration.AutoSize = true;
            this.chb_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chb_filtration.Location = new System.Drawing.Point(190, 16);
            this.chb_filtration.Name = "chb_filtration";
            this.chb_filtration.Size = new System.Drawing.Size(107, 17);
            this.chb_filtration.TabIndex = 1;
            this.chb_filtration.Text = "Отфильтровать";
            this.chb_filtration.UseVisualStyleBackColor = true;
            // 
            // tb_search_filtration
            // 
            this.tb_search_filtration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_search_filtration.Location = new System.Drawing.Point(3, 16);
            this.tb_search_filtration.Name = "tb_search_filtration";
            this.tb_search_filtration.Size = new System.Drawing.Size(187, 20);
            this.tb_search_filtration.TabIndex = 0;
            // 
            // dgv_aminities
            // 
            this.dgv_aminities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aminities.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_aminities.Location = new System.Drawing.Point(0, 38);
            this.dgv_aminities.Name = "dgv_aminities";
            this.dgv_aminities.Size = new System.Drawing.Size(300, 238);
            this.dgv_aminities.TabIndex = 39;
            // 
            // gb_manipulation
            // 
            this.gb_manipulation.Controls.Add(this.pn_manipulation);
            this.gb_manipulation.Controls.Add(this.pn_service_data);
            this.gb_manipulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_manipulation.Location = new System.Drawing.Point(0, 276);
            this.gb_manipulation.Name = "gb_manipulation";
            this.gb_manipulation.Size = new System.Drawing.Size(300, 164);
            this.gb_manipulation.TabIndex = 40;
            this.gb_manipulation.TabStop = false;
            this.gb_manipulation.Text = "Манипуляция данными";
            // 
            // pn_manipulation
            // 
            this.pn_manipulation.Controls.Add(this.btn_delete);
            this.pn_manipulation.Controls.Add(this.btn_update);
            this.pn_manipulation.Controls.Add(this.btn_insert);
            this.pn_manipulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_manipulation.Location = new System.Drawing.Point(3, 83);
            this.pn_manipulation.Name = "pn_manipulation";
            this.pn_manipulation.Size = new System.Drawing.Size(294, 78);
            this.pn_manipulation.TabIndex = 42;
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_delete.Location = new System.Drawing.Point(0, 52);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(294, 26);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Удалить данные услуги";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_update.Location = new System.Drawing.Point(0, 26);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(294, 26);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "Изменить данные услуги";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_insert.Location = new System.Drawing.Point(0, 0);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(294, 26);
            this.btn_insert.TabIndex = 32;
            this.btn_insert.Text = "Добавить данные услуги";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // pn_service_data
            // 
            this.pn_service_data.Controls.Add(this.tb_price);
            this.pn_service_data.Controls.Add(this.lbl_price);
            this.pn_service_data.Controls.Add(this.tb_name_service);
            this.pn_service_data.Controls.Add(this.lbl_name_service);
            this.pn_service_data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_service_data.Location = new System.Drawing.Point(3, 16);
            this.pn_service_data.Name = "pn_service_data";
            this.pn_service_data.Size = new System.Drawing.Size(294, 67);
            this.pn_service_data.TabIndex = 41;
            // 
            // tb_price
            // 
            this.tb_price.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_price.Location = new System.Drawing.Point(0, 46);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(294, 20);
            this.tb_price.TabIndex = 30;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_price.Location = new System.Drawing.Point(0, 33);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(98, 13);
            this.lbl_price.TabIndex = 29;
            this.lbl_price.Text = "Стоимость услуги";
            // 
            // tb_name_service
            // 
            this.tb_name_service.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_name_service.Location = new System.Drawing.Point(0, 13);
            this.tb_name_service.Name = "tb_name_service";
            this.tb_name_service.Size = new System.Drawing.Size(294, 20);
            this.tb_name_service.TabIndex = 28;
            // 
            // lbl_name_service
            // 
            this.lbl_name_service.AutoSize = true;
            this.lbl_name_service.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_name_service.Location = new System.Drawing.Point(0, 0);
            this.lbl_name_service.Name = "lbl_name_service";
            this.lbl_name_service.Size = new System.Drawing.Size(93, 13);
            this.lbl_name_service.TabIndex = 27;
            this.lbl_name_service.Text = "Название услуги";
            // 
            // pn_cancel
            // 
            this.pn_cancel.Controls.Add(this.btn_cancel);
            this.pn_cancel.Controls.Add(this.btn_errors);
            this.pn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_cancel.Location = new System.Drawing.Point(0, 438);
            this.pn_cancel.Name = "pn_cancel";
            this.pn_cancel.Size = new System.Drawing.Size(300, 25);
            this.pn_cancel.TabIndex = 41;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.Location = new System.Drawing.Point(228, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(72, 25);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "Закрыть";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_errors
            // 
            this.btn_errors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_errors.Location = new System.Drawing.Point(0, 0);
            this.btn_errors.Name = "btn_errors";
            this.btn_errors.Size = new System.Drawing.Size(67, 25);
            this.btn_errors.TabIndex = 35;
            this.btn_errors.Text = "Ошибки";
            this.btn_errors.UseVisualStyleBackColor = true;
            // 
            // AmenitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 463);
            this.Controls.Add(this.pn_cancel);
            this.Controls.Add(this.gb_manipulation);
            this.Controls.Add(this.dgv_aminities);
            this.Controls.Add(this.gb_search_filtration);
            this.Name = "AmenitiesForm";
            this.Text = "Amenities";
            this.gb_search_filtration.ResumeLayout(false);
            this.gb_search_filtration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aminities)).EndInit();
            this.gb_manipulation.ResumeLayout(false);
            this.pn_manipulation.ResumeLayout(false);
            this.pn_service_data.ResumeLayout(false);
            this.pn_service_data.PerformLayout();
            this.pn_cancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_search_filtration;
        private System.Windows.Forms.CheckBox chb_filtration;
        private System.Windows.Forms.TextBox tb_search_filtration;
        private System.Windows.Forms.DataGridView dgv_aminities;
        private System.Windows.Forms.GroupBox gb_manipulation;
        private System.Windows.Forms.Panel pn_service_data;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox tb_name_service;
        private System.Windows.Forms.Label lbl_name_service;
        private System.Windows.Forms.Panel pn_manipulation;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Panel pn_cancel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_errors;
    }
}