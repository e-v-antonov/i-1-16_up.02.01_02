namespace CarService
{
    partial class CreateOrderForm
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
            this.gbClientCar = new System.Windows.Forms.GroupBox();
            this.pnIndetificationRegistration = new System.Windows.Forms.Panel();
            this.btnIdentificationClient = new System.Windows.Forms.Button();
            this.btnRegistrationClient = new System.Windows.Forms.Button();
            this.pnPhoneNumber = new System.Windows.Forms.Panel();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.pnPatronymicRegCar = new System.Windows.Forms.Panel();
            this.btnRegCar = new System.Windows.Forms.Button();
            this.tbOtchestvo = new System.Windows.Forms.TextBox();
            this.lblOtchestvo = new System.Windows.Forms.Label();
            this.pnFirstNameIdentification = new System.Windows.Forms.Panel();
            this.tbIdentificationNumber = new System.Windows.Forms.TextBox();
            this.lblIdentificationNumber = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnSecondNameRegister = new System.Windows.Forms.Panel();
            this.tbRegisterSign = new System.Windows.Forms.TextBox();
            this.lblRegisterSign = new System.Windows.Forms.Label();
            this.tbSecondNameClient = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.tbSearchOrder = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnDocs = new System.Windows.Forms.Panel();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pnDocsPrice = new System.Windows.Forms.Panel();
            this.pnPrice = new System.Windows.Forms.Panel();
            this.pnPostSummTake = new System.Windows.Forms.Panel();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.tbPostSumm = new System.Windows.Forms.TextBox();
            this.lblPostSumm = new System.Windows.Forms.Label();
            this.pnDiscount = new System.Windows.Forms.Panel();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.pnPreSumm = new System.Windows.Forms.Panel();
            this.tbPreSumm = new System.Windows.Forms.TextBox();
            this.lblPreSumm = new System.Windows.Forms.Label();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.gbClientCar.SuspendLayout();
            this.pnIndetificationRegistration.SuspendLayout();
            this.pnPhoneNumber.SuspendLayout();
            this.pnPatronymicRegCar.SuspendLayout();
            this.pnFirstNameIdentification.SuspendLayout();
            this.pnSecondNameRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnDocs.SuspendLayout();
            this.pnDocsPrice.SuspendLayout();
            this.pnPrice.SuspendLayout();
            this.pnPostSummTake.SuspendLayout();
            this.pnDiscount.SuspendLayout();
            this.pnPreSumm.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClientCar
            // 
            this.gbClientCar.Controls.Add(this.pnIndetificationRegistration);
            this.gbClientCar.Controls.Add(this.pnPhoneNumber);
            this.gbClientCar.Controls.Add(this.pnPatronymicRegCar);
            this.gbClientCar.Controls.Add(this.pnFirstNameIdentification);
            this.gbClientCar.Controls.Add(this.pnSecondNameRegister);
            this.gbClientCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbClientCar.Location = new System.Drawing.Point(0, 0);
            this.gbClientCar.Name = "gbClientCar";
            this.gbClientCar.Size = new System.Drawing.Size(800, 90);
            this.gbClientCar.TabIndex = 0;
            this.gbClientCar.TabStop = false;
            this.gbClientCar.Text = "Клиенты и автомобили";
            // 
            // pnIndetificationRegistration
            // 
            this.pnIndetificationRegistration.Controls.Add(this.btnIdentificationClient);
            this.pnIndetificationRegistration.Controls.Add(this.btnRegistrationClient);
            this.pnIndetificationRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnIndetificationRegistration.Location = new System.Drawing.Point(538, 16);
            this.pnIndetificationRegistration.Name = "pnIndetificationRegistration";
            this.pnIndetificationRegistration.Size = new System.Drawing.Size(259, 71);
            this.pnIndetificationRegistration.TabIndex = 9;
            // 
            // btnIdentificationClient
            // 
            this.btnIdentificationClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIdentificationClient.Location = new System.Drawing.Point(9, 0);
            this.btnIdentificationClient.Name = "btnIdentificationClient";
            this.btnIdentificationClient.Size = new System.Drawing.Size(125, 71);
            this.btnIdentificationClient.TabIndex = 0;
            this.btnIdentificationClient.Text = "Идентификация клиента";
            this.btnIdentificationClient.UseVisualStyleBackColor = true;
            // 
            // btnRegistrationClient
            // 
            this.btnRegistrationClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegistrationClient.Location = new System.Drawing.Point(134, 0);
            this.btnRegistrationClient.Name = "btnRegistrationClient";
            this.btnRegistrationClient.Size = new System.Drawing.Size(125, 71);
            this.btnRegistrationClient.TabIndex = 0;
            this.btnRegistrationClient.Text = "Регистрация \r\nклиента";
            this.btnRegistrationClient.UseVisualStyleBackColor = true;
            // 
            // pnPhoneNumber
            // 
            this.pnPhoneNumber.Controls.Add(this.tbPhoneNumber);
            this.pnPhoneNumber.Controls.Add(this.lblPhoneNumber);
            this.pnPhoneNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPhoneNumber.Location = new System.Drawing.Point(400, 16);
            this.pnPhoneNumber.Name = "pnPhoneNumber";
            this.pnPhoneNumber.Size = new System.Drawing.Size(138, 71);
            this.pnPhoneNumber.TabIndex = 8;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPhoneNumber.Location = new System.Drawing.Point(0, 13);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(138, 20);
            this.tbPhoneNumber.TabIndex = 2;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhoneNumber.Location = new System.Drawing.Point(0, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(137, 13);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Номер телефона клиента";
            // 
            // pnPatronymicRegCar
            // 
            this.pnPatronymicRegCar.Controls.Add(this.btnRegCar);
            this.pnPatronymicRegCar.Controls.Add(this.tbOtchestvo);
            this.pnPatronymicRegCar.Controls.Add(this.lblOtchestvo);
            this.pnPatronymicRegCar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPatronymicRegCar.Location = new System.Drawing.Point(288, 16);
            this.pnPatronymicRegCar.Name = "pnPatronymicRegCar";
            this.pnPatronymicRegCar.Size = new System.Drawing.Size(112, 71);
            this.pnPatronymicRegCar.TabIndex = 7;
            // 
            // btnRegCar
            // 
            this.btnRegCar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegCar.Location = new System.Drawing.Point(0, 33);
            this.btnRegCar.Name = "btnRegCar";
            this.btnRegCar.Size = new System.Drawing.Size(112, 38);
            this.btnRegCar.TabIndex = 3;
            this.btnRegCar.Text = "Регистрация автомобиля";
            this.btnRegCar.UseVisualStyleBackColor = true;
            // 
            // tbOtchestvo
            // 
            this.tbOtchestvo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOtchestvo.Location = new System.Drawing.Point(0, 13);
            this.tbOtchestvo.Name = "tbOtchestvo";
            this.tbOtchestvo.Size = new System.Drawing.Size(112, 20);
            this.tbOtchestvo.TabIndex = 2;
            // 
            // lblOtchestvo
            // 
            this.lblOtchestvo.AutoSize = true;
            this.lblOtchestvo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOtchestvo.Location = new System.Drawing.Point(0, 0);
            this.lblOtchestvo.Name = "lblOtchestvo";
            this.lblOtchestvo.Size = new System.Drawing.Size(98, 13);
            this.lblOtchestvo.TabIndex = 1;
            this.lblOtchestvo.Text = "Отчество клиента";
            // 
            // pnFirstNameIdentification
            // 
            this.pnFirstNameIdentification.Controls.Add(this.tbIdentificationNumber);
            this.pnFirstNameIdentification.Controls.Add(this.lblIdentificationNumber);
            this.pnFirstNameIdentification.Controls.Add(this.tbFirstName);
            this.pnFirstNameIdentification.Controls.Add(this.lblFirstName);
            this.pnFirstNameIdentification.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFirstNameIdentification.Location = new System.Drawing.Point(132, 16);
            this.pnFirstNameIdentification.Name = "pnFirstNameIdentification";
            this.pnFirstNameIdentification.Size = new System.Drawing.Size(156, 71);
            this.pnFirstNameIdentification.TabIndex = 6;
            // 
            // tbIdentificationNumber
            // 
            this.tbIdentificationNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbIdentificationNumber.Location = new System.Drawing.Point(0, 46);
            this.tbIdentificationNumber.Name = "tbIdentificationNumber";
            this.tbIdentificationNumber.Size = new System.Drawing.Size(156, 20);
            this.tbIdentificationNumber.TabIndex = 4;
            // 
            // lblIdentificationNumber
            // 
            this.lblIdentificationNumber.AutoSize = true;
            this.lblIdentificationNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdentificationNumber.Location = new System.Drawing.Point(0, 33);
            this.lblIdentificationNumber.Name = "lblIdentificationNumber";
            this.lblIdentificationNumber.Size = new System.Drawing.Size(149, 13);
            this.lblIdentificationNumber.TabIndex = 3;
            this.lblIdentificationNumber.Text = "Идентификационный номер";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFirstName.Location = new System.Drawing.Point(0, 13);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(156, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFirstName.Location = new System.Drawing.Point(0, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Имя клиента";
            // 
            // pnSecondNameRegister
            // 
            this.pnSecondNameRegister.Controls.Add(this.tbRegisterSign);
            this.pnSecondNameRegister.Controls.Add(this.lblRegisterSign);
            this.pnSecondNameRegister.Controls.Add(this.tbSecondNameClient);
            this.pnSecondNameRegister.Controls.Add(this.lblSecondName);
            this.pnSecondNameRegister.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSecondNameRegister.Location = new System.Drawing.Point(3, 16);
            this.pnSecondNameRegister.Name = "pnSecondNameRegister";
            this.pnSecondNameRegister.Size = new System.Drawing.Size(129, 71);
            this.pnSecondNameRegister.TabIndex = 4;
            // 
            // tbRegisterSign
            // 
            this.tbRegisterSign.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbRegisterSign.Location = new System.Drawing.Point(0, 46);
            this.tbRegisterSign.Name = "tbRegisterSign";
            this.tbRegisterSign.Size = new System.Drawing.Size(129, 20);
            this.tbRegisterSign.TabIndex = 4;
            // 
            // lblRegisterSign
            // 
            this.lblRegisterSign.AutoSize = true;
            this.lblRegisterSign.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegisterSign.Location = new System.Drawing.Point(0, 33);
            this.lblRegisterSign.Name = "lblRegisterSign";
            this.lblRegisterSign.Size = new System.Drawing.Size(125, 13);
            this.lblRegisterSign.TabIndex = 3;
            this.lblRegisterSign.Text = "Регистрационный знак";
            // 
            // tbSecondNameClient
            // 
            this.tbSecondNameClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSecondNameClient.Location = new System.Drawing.Point(0, 13);
            this.tbSecondNameClient.Name = "tbSecondNameClient";
            this.tbSecondNameClient.Size = new System.Drawing.Size(129, 20);
            this.tbSecondNameClient.TabIndex = 2;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecondName.Location = new System.Drawing.Point(0, 0);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(100, 13);
            this.lblSecondName.TabIndex = 1;
            this.lblSecondName.Text = "Фамилия клиента";
            // 
            // tbSearchOrder
            // 
            this.tbSearchOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearchOrder.Location = new System.Drawing.Point(0, 90);
            this.tbSearchOrder.Name = "tbSearchOrder";
            this.tbSearchOrder.Size = new System.Drawing.Size(800, 20);
            this.tbSearchOrder.TabIndex = 5;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOrders.Location = new System.Drawing.Point(0, 110);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(800, 181);
            this.dgvOrders.TabIndex = 6;
            // 
            // pnDocs
            // 
            this.pnDocs.Controls.Add(this.btnAct);
            this.pnDocs.Controls.Add(this.btnCheck);
            this.pnDocs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDocs.Location = new System.Drawing.Point(0, 0);
            this.pnDocs.Name = "pnDocs";
            this.pnDocs.Size = new System.Drawing.Size(262, 90);
            this.pnDocs.TabIndex = 7;
            // 
            // btnAct
            // 
            this.btnAct.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAct.Location = new System.Drawing.Point(160, 0);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(102, 90);
            this.btnAct.TabIndex = 5;
            this.btnAct.Text = "Формирование акта о выполненных услугах";
            this.btnAct.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCheck.Location = new System.Drawing.Point(0, 0);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(108, 90);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Формирование кассового чека";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // pnDocsPrice
            // 
            this.pnDocsPrice.Controls.Add(this.pnPrice);
            this.pnDocsPrice.Controls.Add(this.pnDocs);
            this.pnDocsPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDocsPrice.Location = new System.Drawing.Point(0, 291);
            this.pnDocsPrice.Name = "pnDocsPrice";
            this.pnDocsPrice.Size = new System.Drawing.Size(800, 90);
            this.pnDocsPrice.TabIndex = 0;
            // 
            // pnPrice
            // 
            this.pnPrice.Controls.Add(this.pnPostSummTake);
            this.pnPrice.Controls.Add(this.pnDiscount);
            this.pnPrice.Controls.Add(this.pnPreSumm);
            this.pnPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPrice.Location = new System.Drawing.Point(522, 0);
            this.pnPrice.Name = "pnPrice";
            this.pnPrice.Size = new System.Drawing.Size(278, 90);
            this.pnPrice.TabIndex = 9;
            // 
            // pnPostSummTake
            // 
            this.pnPostSummTake.Controls.Add(this.btnTakeOrder);
            this.pnPostSummTake.Controls.Add(this.tbPostSumm);
            this.pnPostSummTake.Controls.Add(this.lblPostSumm);
            this.pnPostSummTake.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPostSummTake.Location = new System.Drawing.Point(184, 0);
            this.pnPostSummTake.Name = "pnPostSummTake";
            this.pnPostSummTake.Size = new System.Drawing.Size(92, 90);
            this.pnPostSummTake.TabIndex = 11;
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTakeOrder.Location = new System.Drawing.Point(0, 59);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(92, 31);
            this.btnTakeOrder.TabIndex = 37;
            this.btnTakeOrder.Text = "Принять заказ";
            this.btnTakeOrder.UseVisualStyleBackColor = true;
            // 
            // tbPostSumm
            // 
            this.tbPostSumm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPostSumm.Location = new System.Drawing.Point(0, 39);
            this.tbPostSumm.Name = "tbPostSumm";
            this.tbPostSumm.Size = new System.Drawing.Size(92, 20);
            this.tbPostSumm.TabIndex = 2;
            // 
            // lblPostSumm
            // 
            this.lblPostSumm.AutoSize = true;
            this.lblPostSumm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPostSumm.Location = new System.Drawing.Point(0, 0);
            this.lblPostSumm.Name = "lblPostSumm";
            this.lblPostSumm.Size = new System.Drawing.Size(66, 39);
            this.lblPostSumm.TabIndex = 1;
            this.lblPostSumm.Text = "\r\nСумма-итог\r\n\r\n";
            // 
            // pnDiscount
            // 
            this.pnDiscount.Controls.Add(this.tbDiscount);
            this.pnDiscount.Controls.Add(this.lblDiscount);
            this.pnDiscount.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDiscount.Location = new System.Drawing.Point(92, 0);
            this.pnDiscount.Name = "pnDiscount";
            this.pnDiscount.Size = new System.Drawing.Size(92, 90);
            this.pnDiscount.TabIndex = 10;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDiscount.Location = new System.Drawing.Point(0, 39);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(92, 20);
            this.tbDiscount.TabIndex = 2;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiscount.Location = new System.Drawing.Point(0, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(76, 39);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "Скидка \r\nпостоянному \r\nклиенту";
            // 
            // pnPreSumm
            // 
            this.pnPreSumm.Controls.Add(this.tbPreSumm);
            this.pnPreSumm.Controls.Add(this.lblPreSumm);
            this.pnPreSumm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPreSumm.Location = new System.Drawing.Point(0, 0);
            this.pnPreSumm.Name = "pnPreSumm";
            this.pnPreSumm.Size = new System.Drawing.Size(92, 90);
            this.pnPreSumm.TabIndex = 9;
            // 
            // tbPreSumm
            // 
            this.tbPreSumm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPreSumm.Location = new System.Drawing.Point(0, 39);
            this.tbPreSumm.Name = "tbPreSumm";
            this.tbPreSumm.Size = new System.Drawing.Size(92, 20);
            this.tbPreSumm.TabIndex = 2;
            // 
            // lblPreSumm
            // 
            this.lblPreSumm.AutoSize = true;
            this.lblPreSumm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPreSumm.Location = new System.Drawing.Point(0, 0);
            this.lblPreSumm.Name = "lblPreSumm";
            this.lblPreSumm.Size = new System.Drawing.Size(41, 39);
            this.lblPreSumm.TabIndex = 1;
            this.lblPreSumm.Text = "\r\nСумма\r\n\r\n";
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnCancel);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 425);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(800, 25);
            this.pnCancel.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(634, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 25);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnErrors
            // 
            this.btnErrors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnErrors.Location = new System.Drawing.Point(0, 0);
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Size = new System.Drawing.Size(166, 25);
            this.btnErrors.TabIndex = 35;
            this.btnErrors.Text = "Ошибки";
            this.btnErrors.UseVisualStyleBackColor = true;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.pnDocsPrice);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.tbSearchOrder);
            this.Controls.Add(this.gbClientCar);
            this.Name = "CreateOrderForm";
            this.Text = "Составление заказа";
            this.gbClientCar.ResumeLayout(false);
            this.pnIndetificationRegistration.ResumeLayout(false);
            this.pnPhoneNumber.ResumeLayout(false);
            this.pnPhoneNumber.PerformLayout();
            this.pnPatronymicRegCar.ResumeLayout(false);
            this.pnPatronymicRegCar.PerformLayout();
            this.pnFirstNameIdentification.ResumeLayout(false);
            this.pnFirstNameIdentification.PerformLayout();
            this.pnSecondNameRegister.ResumeLayout(false);
            this.pnSecondNameRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnDocs.ResumeLayout(false);
            this.pnDocsPrice.ResumeLayout(false);
            this.pnPrice.ResumeLayout(false);
            this.pnPostSummTake.ResumeLayout(false);
            this.pnPostSummTake.PerformLayout();
            this.pnDiscount.ResumeLayout(false);
            this.pnDiscount.PerformLayout();
            this.pnPreSumm.ResumeLayout(false);
            this.pnPreSumm.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientCar;
        private System.Windows.Forms.Panel pnIndetificationRegistration;
        private System.Windows.Forms.Button btnIdentificationClient;
        private System.Windows.Forms.Button btnRegistrationClient;
        private System.Windows.Forms.Panel pnPhoneNumber;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Panel pnPatronymicRegCar;
        private System.Windows.Forms.Button btnRegCar;
        private System.Windows.Forms.TextBox tbOtchestvo;
        private System.Windows.Forms.Label lblOtchestvo;
        private System.Windows.Forms.Panel pnFirstNameIdentification;
        private System.Windows.Forms.TextBox tbIdentificationNumber;
        private System.Windows.Forms.Label lblIdentificationNumber;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel pnSecondNameRegister;
        private System.Windows.Forms.TextBox tbRegisterSign;
        private System.Windows.Forms.Label lblRegisterSign;
        private System.Windows.Forms.TextBox tbSecondNameClient;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox tbSearchOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnDocs;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel pnDocsPrice;
        private System.Windows.Forms.Panel pnPrice;
        private System.Windows.Forms.Panel pnPostSummTake;
        private System.Windows.Forms.TextBox tbPostSumm;
        private System.Windows.Forms.Label lblPostSumm;
        private System.Windows.Forms.Panel pnDiscount;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel pnPreSumm;
        private System.Windows.Forms.TextBox tbPreSumm;
        private System.Windows.Forms.Label lblPreSumm;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.Button btnTakeOrder;
    }
}