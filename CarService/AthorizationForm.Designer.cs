namespace CarService
{
    partial class AthorizationForm
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
            this.btn_authorization = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_registration = new System.Windows.Forms.Button();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.pn_empty = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_authorization
            // 
            this.btn_authorization.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_authorization.Location = new System.Drawing.Point(0, 136);
            this.btn_authorization.Name = "btn_authorization";
            this.btn_authorization.Size = new System.Drawing.Size(314, 23);
            this.btn_authorization.TabIndex = 25;
            this.btn_authorization.Text = "Авторизация";
            this.btn_authorization.UseVisualStyleBackColor = true;
            // 
            // tb_password
            // 
            this.tb_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_password.Location = new System.Drawing.Point(0, 86);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(314, 20);
            this.tb_password.TabIndex = 24;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_password.Location = new System.Drawing.Point(0, 73);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(45, 13);
            this.lbl_password.TabIndex = 23;
            this.lbl_password.Text = "Пароль";
            // 
            // btn_registration
            // 
            this.btn_registration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_registration.Location = new System.Drawing.Point(0, 159);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(314, 23);
            this.btn_registration.TabIndex = 22;
            this.btn_registration.Text = "Регистрация";
            this.btn_registration.UseVisualStyleBackColor = true;
            // 
            // tb_login
            // 
            this.tb_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_login.Location = new System.Drawing.Point(0, 53);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(314, 20);
            this.tb_login.TabIndex = 21;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_login.Location = new System.Drawing.Point(0, 40);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(38, 13);
            this.lbl_login.TabIndex = 20;
            this.lbl_login.Text = "Логин";
            // 
            // pn_empty
            // 
            this.pn_empty.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_empty.Location = new System.Drawing.Point(0, 0);
            this.pn_empty.Name = "pn_empty";
            this.pn_empty.Size = new System.Drawing.Size(314, 40);
            this.pn_empty.TabIndex = 19;
            // 
            // AthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 182);
            this.Controls.Add(this.btn_authorization);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.btn_registration);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.pn_empty);
            this.Name = "AthorizationForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_authorization;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Panel pn_empty;
    }
}