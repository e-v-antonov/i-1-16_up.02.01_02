using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace CarService
{
    public partial class CarsForm : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandSearchCars = new SqlCommand("", RegistryData.DBConnectionString);
        private string filterCars = "";

        public CarsForm()
        {
            InitializeComponent();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            Thread threadCars = new Thread(CarsFormFill);
            Thread threadClient = new Thread(ClientFill);
            threadCars.Start();
            threadClient.Start();
        }

        private void CarsFormFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTDeloavtoklienta.Clear();
                    dbTables.DTDeloavtoklientaFill();
                    filterCars = dbTables.QRDeloavtoklienta;
                    dbTables.dependency.OnChange += ChangeDataCars;

                    dgvCars.DataSource = dbTables.DTDeloavtoklienta;
                    dgvCars.Columns[0].Visible = false;
                    dgvCars.Columns[1].HeaderText = "Регистрационный знак автомобиля";
                    dgvCars.Columns[2].HeaderText = "Идентификационный номер автомобиля";
                    dgvCars.Columns[3].HeaderText = "Марка автомобиля";
                    dgvCars.Columns[4].HeaderText = "Модель автомобиля";
                    dgvCars.Columns[5].HeaderText = "Цвет автомобиля";
                    dgvCars.Columns[6].HeaderText = "Год выпуска автомобиля";
                    dgvCars.Columns[7].Visible = false;
                    dgvCars.Columns[8].HeaderText ="Данные клиента(владельца автомобиля)";
                    dgvCars.Columns[9].HeaderText = "Автомобиль находится на ремонте";
                    dgvCars.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("ОШибка загрузки данных из базы данных.", "Ошибки в информационной системе", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void ClientFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTClientsComboBox.Clear();
                    dbTables.DTClientsComboBoxFill();
                    dbTables.dependency.OnChange += ChangeDataCars;

                    cbClient.DataSource = dbTables.DTClientsComboBox;
                    cbClient.ValueMember = "ID_dela_klienta";
                    cbClient.DisplayMember = "Client";
                    cbClient.SelectedValue = -1;
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки данных из базы данных.", "Ошибки в информационной системе", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void ChangeDataCars(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                ClientFill();
            }
        }

        private void ChangeDataClients(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                CarsFormFill();
            }
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbRegisterSign.Text = dgvCars.CurrentRow.Cells[1].Value.ToString();
            tbVim.Text = dgvCars.CurrentRow.Cells[2].Value.ToString();
            tbBrand.Text = dgvCars.CurrentRow.Cells[3].Value.ToString();
            tbModel.Text = dgvCars.CurrentRow.Cells[4].Value.ToString();
            tbColor.Text = dgvCars.CurrentRow.Cells[5].Value.ToString();
            tbYearMade.Text = dgvCars.CurrentRow.Cells[6].Value.ToString();

            cbClient.SelectedValue = dgvCars.CurrentRow.Cells[8].Value.ToString();

            if (dgvCars.CurrentRow.Cells[9].Value.ToString() == "1")
                lblRepairCar.Text = "Машина на ремонте: Да";
            else
                lblRepairCar.Text = "Машина на ремонте: Нет";
        }



        //НАПИСАТЬ ФУНКЦИЮ ПРОВЕРКИ ИДЕНТИФИКАЦИОННОГО НОМЕРА ПРИ ИНСЕРТЕ И АПДЕЙТЕ

        private void btnInsert_Click(object sender, EventArgs e)
        {
            storedProcedure.SPDeloavtoklientaInsert(tbRegisterSign.Text, tbVim.Text, tbBrand.Text, tbModel.Text, tbColor.Text, Convert.ToInt32(tbYearMade.Text), Convert.ToInt32(cbClient.SelectedValue.ToString()));

            tbRegisterSign.Clear();
            tbVim.Clear();
            tbBrand.Clear();
            tbModel.Clear();
            tbColor.Clear();
            tbYearMade.Clear();
            cbClient.SelectedValue = -1;
            dgvCars.ClearSelection();
            CarsFormFill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            storedProcedure.SPDeloavtoklientaUpdate(Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value.ToString()), tbRegisterSign.Text, tbVim.Text, tbBrand.Text, tbModel.Text, tbColor.Text, Convert.ToInt32(tbYearMade.Text), Convert.ToInt32(cbClient.SelectedValue.ToString()), Convert.ToInt32(dgvCars.CurrentRow.Cells[9].Value.ToString()));

            tbRegisterSign.Clear();
            tbVim.Clear();
            tbBrand.Clear();
            tbModel.Clear();
            tbColor.Clear();
            tbYearMade.Clear();
            cbClient.SelectedValue = -1;
            dgvCars.ClearSelection();
            CarsFormFill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите удалить машину " + tbRegisterSign.Text + " " + tbVim.Text  + "?", "Удаление автомобиля", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    storedProcedure.SPDeloavtoklientaDelete(Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value.ToString()));
                    CarsFormFill();
                    break;
            }
        }

        private void tbSearchFiltration_TextChanged(object sender, EventArgs e)
        {
            chbFiltration_CheckedChanged(sender, e);
        }

        private void tbSearchFiltration_Leave(object sender, EventArgs e)
        {
            if (tbSearchFiltration.Text == "")
                tbSearchFiltration.Text = "Введите данные автомобиля...";
        }

        private void tbSearchFiltration_Click(object sender, EventArgs e)
        {
            tbSearchFiltration.Clear();
        }

        private void chbFiltration_CheckedChanged(object sender, EventArgs e)
        {
            switch (chbFiltration.CheckState)
            {
                case (CheckState.Checked):  //фильтрация
                    DataTable data = new DataTable("Delo_avto_filter");
                    commandSearchCars.CommandText = filterCars + "and [Registr_znak] like '%" + tbSearchFiltration.Text  + 
                        "%' or CONVERT([varchar] (max), DECRYPTBYPASSPHRASE('KexibqП@р0ль!', [dbo].[Delo_avto_klienta].[Identific_nomer])) " +
                        "like '%" + tbSearchFiltration.Text + "%' or Marka like '%" + tbSearchFiltration.Text + "%' or Model like '%" + 
                        tbSearchFiltration.Text + "%' or Color like '%" + tbSearchFiltration.Text + "%' or God_vipuska like '%" + 
                        tbSearchFiltration + "%' or Surname like '%" + tbSearchFiltration.Text + "%' or Name like '%" + 
                        tbSearchFiltration.Text + "%' or Otchestvo like '%" + tbSearchFiltration.Text + "%' or CONVERT([varchar] (max), " +
                        "DECRYPTBYPASSPHRASE('KexibqП@р0ль!', [dbo].[Delo_klienta].[Telefon])) like '%" + tbSearchFiltration.Text + 
                        "'% or Repair_car_now like '%" + tbSearchFiltration.Text + "%'";
                    RegistryData.DBConnectionString.Open();
                    DBTables dbTables = new DBTables();
                    data.Load(commandSearchCars.ExecuteReader());
                    RegistryData.DBConnectionString.Close();

                    dgvCars.DataSource = data;
                    dgvCars.Columns[0].Visible = false;
                    dgvCars.Columns[1].HeaderText = "Регистрационный знак автомобиля";
                    dgvCars.Columns[2].HeaderText = "Идентификационный номер автомобиля";
                    dgvCars.Columns[3].HeaderText = "Марка автомобиля";
                    dgvCars.Columns[4].HeaderText = "Модель автомобиля";
                    dgvCars.Columns[5].HeaderText = "Цвет автомобиля";
                    dgvCars.Columns[6].HeaderText = "Год выпуска автомобиля";
                    dgvCars.Columns[7].Visible = false;
                    dgvCars.Columns[8].HeaderText = "Данные клиента(владельца автомобиля)";
                    dgvCars.Columns[9].HeaderText = "Автомобиль находится на ремонте";
                    dgvCars.ClearSelection();
                    break;

                case (CheckState.Unchecked):    //поиск
                    CarsFormFill();

                    for (int i = 0; i < dgvCars.RowCount; i++)
                    {
                        for (int j = 0; j < dgvCars.ColumnCount; j++)
                        {
                            if (dgvCars.Rows[i].Cells[j].Value != null)
                                if (dgvCars.Rows[i].Cells[j].Value.ToString().Contains(tbSearchFiltration.Text))
                                {
                                    dgvCars.Rows[i].Selected = true;
                                    break;
                                }
                        }
                    }
                    break;
            }
        }

        private void btnErrors_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RegistryData.ErrorMessage,"Ошибки в информационной системе");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
