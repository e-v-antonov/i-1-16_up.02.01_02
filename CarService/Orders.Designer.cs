namespace CarService
{
    partial class Orders
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
            this.tb_search_filtration = new System.Windows.Forms.TextBox();
            this.chb_filtration = new System.Windows.Forms.CheckBox();
            this.gb_search_filtration = new System.Windows.Forms.GroupBox();
            this.btn_errors = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pn_cancel = new System.Windows.Forms.Panel();
            this.dgv_clients = new System.Windows.Forms.DataGridView();
            this.dgv_cars = new System.Windows.Forms.DataGridView();
            this.pn_cars_clients = new System.Windows.Forms.Panel();
            this.lbl_cars = new System.Windows.Forms.Label();
            this.cb_cars = new System.Windows.Forms.ComboBox();
            this.gb_manipulation = new System.Windows.Forms.GroupBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pn_manipulation = new System.Windows.Forms.Panel();
            this.pn_docs = new System.Windows.Forms.Panel();
            this.lbl_clients = new System.Windows.Forms.Label();
            this.cb_clients = new System.Windows.Forms.ComboBox();
            this.btn_form_check = new System.Windows.Forms.Button();
            this.btn_form_act = new System.Windows.Forms.Button();
            this.gb_search_filtration.SuspendLayout();
            this.pn_cancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cars)).BeginInit();
            this.pn_cars_clients.SuspendLayout();
            this.gb_manipulation.SuspendLayout();
            this.pn_manipulation.SuspendLayout();
            this.pn_docs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_search_filtration
            // 
            this.tb_search_filtration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_search_filtration.Location = new System.Drawing.Point(3, 16);
            this.tb_search_filtration.Name = "tb_search_filtration";
            this.tb_search_filtration.Size = new System.Drawing.Size(689, 20);
            this.tb_search_filtration.TabIndex = 0;
            // 
            // chb_filtration
            // 
            this.chb_filtration.AutoSize = true;
            this.chb_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chb_filtration.Location = new System.Drawing.Point(692, 16);
            this.chb_filtration.Name = "chb_filtration";
            this.chb_filtration.Size = new System.Drawing.Size(105, 17);
            this.chb_filtration.TabIndex = 1;
            this.chb_filtration.Text = "Отфильтровать";
            this.chb_filtration.UseVisualStyleBackColor = true;
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
            // pn_cancel
            // 
            this.pn_cancel.Controls.Add(this.btn_cancel);
            this.pn_cancel.Controls.Add(this.btn_errors);
            this.pn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_cancel.Location = new System.Drawing.Point(0, 441);
            this.pn_cancel.Name = "pn_cancel";
            this.pn_cancel.Size = new System.Drawing.Size(800, 25);
            this.pn_cancel.TabIndex = 39;
            // 
            // dgv_clients
            // 
            this.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clients.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_clients.Location = new System.Drawing.Point(404, 38);
            this.dgv_clients.Name = "dgv_clients";
            this.dgv_clients.Size = new System.Drawing.Size(396, 291);
            this.dgv_clients.TabIndex = 46;
            // 
            // dgv_cars
            // 
            this.dgv_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cars.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_cars.Location = new System.Drawing.Point(0, 38);
            this.dgv_cars.Name = "dgv_cars";
            this.dgv_cars.Size = new System.Drawing.Size(404, 291);
            this.dgv_cars.TabIndex = 45;
            // 
            // pn_cars_clients
            // 
            this.pn_cars_clients.Controls.Add(this.cb_clients);
            this.pn_cars_clients.Controls.Add(this.lbl_clients);
            this.pn_cars_clients.Controls.Add(this.cb_cars);
            this.pn_cars_clients.Controls.Add(this.lbl_cars);
            this.pn_cars_clients.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_cars_clients.Location = new System.Drawing.Point(3, 43);
            this.pn_cars_clients.Name = "pn_cars_clients";
            this.pn_cars_clients.Size = new System.Drawing.Size(401, 66);
            this.pn_cars_clients.TabIndex = 43;
            // 
            // lbl_cars
            // 
            this.lbl_cars.AutoSize = true;
            this.lbl_cars.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_cars.Location = new System.Drawing.Point(0, 0);
            this.lbl_cars.Name = "lbl_cars";
            this.lbl_cars.Size = new System.Drawing.Size(69, 13);
            this.lbl_cars.TabIndex = 29;
            this.lbl_cars.Text = "Автомобили";
            // 
            // cb_cars
            // 
            this.cb_cars.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_cars.FormattingEnabled = true;
            this.cb_cars.Location = new System.Drawing.Point(0, 13);
            this.cb_cars.Name = "cb_cars";
            this.cb_cars.Size = new System.Drawing.Size(401, 21);
            this.cb_cars.TabIndex = 30;
            // 
            // gb_manipulation
            // 
            this.gb_manipulation.Controls.Add(this.pn_docs);
            this.gb_manipulation.Controls.Add(this.pn_cars_clients);
            this.gb_manipulation.Controls.Add(this.pn_manipulation);
            this.gb_manipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_manipulation.Location = new System.Drawing.Point(0, 329);
            this.gb_manipulation.Name = "gb_manipulation";
            this.gb_manipulation.Size = new System.Drawing.Size(800, 112);
            this.gb_manipulation.TabIndex = 44;
            this.gb_manipulation.TabStop = false;
            this.gb_manipulation.Text = "Манипуляция данными";
            // 
            // btn_insert
            // 
            this.btn_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_insert.Location = new System.Drawing.Point(0, 0);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(265, 27);
            this.btn_insert.TabIndex = 32;
            this.btn_insert.Text = "Добавить данные автомобиля";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_update.Location = new System.Drawing.Point(265, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(265, 27);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "Изменить данные автомобиля";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_delete.Location = new System.Drawing.Point(530, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(265, 27);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Удалить данные автомобиля";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // pn_manipulation
            // 
            this.pn_manipulation.Controls.Add(this.btn_delete);
            this.pn_manipulation.Controls.Add(this.btn_update);
            this.pn_manipulation.Controls.Add(this.btn_insert);
            this.pn_manipulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_manipulation.Location = new System.Drawing.Point(3, 16);
            this.pn_manipulation.Name = "pn_manipulation";
            this.pn_manipulation.Size = new System.Drawing.Size(794, 27);
            this.pn_manipulation.TabIndex = 39;
            // 
            // pn_docs
            // 
            this.pn_docs.Controls.Add(this.btn_form_act);
            this.pn_docs.Controls.Add(this.btn_form_check);
            this.pn_docs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_docs.Location = new System.Drawing.Point(404, 43);
            this.pn_docs.Name = "pn_docs";
            this.pn_docs.Size = new System.Drawing.Size(393, 67);
            this.pn_docs.TabIndex = 44;
            // 
            // lbl_clients
            // 
            this.lbl_clients.AutoSize = true;
            this.lbl_clients.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_clients.Location = new System.Drawing.Point(0, 34);
            this.lbl_clients.Name = "lbl_clients";
            this.lbl_clients.Size = new System.Drawing.Size(51, 13);
            this.lbl_clients.TabIndex = 31;
            this.lbl_clients.Text = "Клиенты";
            // 
            // cb_clients
            // 
            this.cb_clients.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_clients.FormattingEnabled = true;
            this.cb_clients.Location = new System.Drawing.Point(0, 47);
            this.cb_clients.Name = "cb_clients";
            this.cb_clients.Size = new System.Drawing.Size(401, 21);
            this.cb_clients.TabIndex = 32;
            // 
            // btn_form_check
            // 
            this.btn_form_check.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_form_check.Location = new System.Drawing.Point(0, 0);
            this.btn_form_check.Name = "btn_form_check";
            this.btn_form_check.Size = new System.Drawing.Size(393, 34);
            this.btn_form_check.TabIndex = 35;
            this.btn_form_check.Text = "Формирование кассвого чека";
            this.btn_form_check.UseVisualStyleBackColor = true;
            // 
            // btn_form_act
            // 
            this.btn_form_act.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_form_act.Location = new System.Drawing.Point(0, 34);
            this.btn_form_act.Name = "btn_form_act";
            this.btn_form_act.Size = new System.Drawing.Size(393, 34);
            this.btn_form_act.TabIndex = 36;
            this.btn_form_act.Text = "Формирование акта о выполненных услугах";
            this.btn_form_act.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.dgv_clients);
            this.Controls.Add(this.dgv_cars);
            this.Controls.Add(this.gb_manipulation);
            this.Controls.Add(this.pn_cancel);
            this.Controls.Add(this.gb_search_filtration);
            this.Name = "Orders";
            this.Text = "Справочник Заказы";
            this.gb_search_filtration.ResumeLayout(false);
            this.gb_search_filtration.PerformLayout();
            this.pn_cancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cars)).EndInit();
            this.pn_cars_clients.ResumeLayout(false);
            this.pn_cars_clients.PerformLayout();
            this.gb_manipulation.ResumeLayout(false);
            this.pn_manipulation.ResumeLayout(false);
            this.pn_docs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search_filtration;
        private System.Windows.Forms.CheckBox chb_filtration;
        private System.Windows.Forms.GroupBox gb_search_filtration;
        private System.Windows.Forms.Button btn_errors;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel pn_cancel;
        private System.Windows.Forms.DataGridView dgv_clients;
        private System.Windows.Forms.DataGridView dgv_cars;
        private System.Windows.Forms.Panel pn_cars_clients;
        private System.Windows.Forms.ComboBox cb_clients;
        private System.Windows.Forms.Label lbl_clients;
        private System.Windows.Forms.ComboBox cb_cars;
        private System.Windows.Forms.Label lbl_cars;
        private System.Windows.Forms.GroupBox gb_manipulation;
        private System.Windows.Forms.Panel pn_docs;
        private System.Windows.Forms.Button btn_form_act;
        private System.Windows.Forms.Button btn_form_check;
        private System.Windows.Forms.Panel pn_manipulation;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
    }
}