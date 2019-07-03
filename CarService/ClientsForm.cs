using System;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarService
{
    public partial class ClientsForm : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandSearchClient = new SqlCommand("", RegistryData.DBConnectionString);
        private string filterClient = "";
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            Thread threadClient = new Thread(ClientsFill);
            threadClient.Start();
        }

        private void ClientsFill()
        {
            DBTables dBTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dBTables.DTDeloklienta.Clear();
                    dBTables.DTDeloklientaFill();
                    dBTables.dependency.OnChange += ChangeDataClients;

                    filterClient = dBTables.QRDeloklienta;
                    dgvClients.DataSource = dBTables.DTDeloklienta;
                    dgvClients.Columns[0].Visible = false;
                    dgvClients.Columns[1].HeaderText = "Фамилия";
                    dgvClients.Columns[2].HeaderText = "Имя";
                    dgvClients.Columns[3].HeaderText = "Отчество";
                    dgvClients.Columns[4].HeaderText = "Номер телефона";
                    dgvClients.Columns[5].HeaderText = "Кол-во посещений";
                    dgvClients.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки данных из базы данных!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void ChangeDataClients(object sender, SqlNotificationEventArgs e)
        {
            if(e.Info != SqlNotificationInfo.Invalid)
            {
                ClientsFill();
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbSecondName.Text = dgvClients.CurrentRow.Cells[1].Value.ToString();
            tbFirstName.Text = dgvClients.CurrentRow.Cells[2].Value.ToString();
            tbPatronynic.Text = dgvClients.CurrentRow.Cells[3].Value.ToString();
            mtbTelefon.Text = dgvClients.CurrentRow.Cells[4].Value.ToString();
            tbKolVoPos.Text = dgvClients.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            storedProcedure.SPDeloklientaInsert(tbSecondName.Text, tbFirstName.Text, tbPatronynic.Text, mtbTelefon.Text);
            tbSecondName.Clear();
            tbFirstName.Clear();
            tbPatronynic.Clear();
            mtbTelefon.Clear();
            tbKolVoPos.Clear();
            dgvClients.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            storedProcedure.SPDeloklientaUpdate(Convert.ToInt32(dgvClients.CurrentRow.Cells[0].Value.ToString()), tbSecondName.Text, tbFirstName.Text, tbPatronynic.Text, mtbTelefon.Text, Convert.ToInt32(tbKolVoPos.Text));
            tbSecondName.Clear();
            tbFirstName.Clear();
            tbPatronynic.Clear();
            mtbTelefon.Clear();
            tbKolVoPos.Clear();
            dgvClients.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите удалить клиента" + tbSecondName.Text + " " + tbFirstName.Text + " " + tbPatronynic.Text + " " + mtbTelefon.Text + "?", "Удаление данных клиента", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    storedProcedure.SPDeloklientaDelete(Convert.ToInt32(dgvClients.CurrentRow.Cells[0].Value.ToString()));
                    tbSecondName.Clear();
                    tbFirstName.Clear();
                    tbPatronynic.Clear();
                    mtbTelefon.Clear();
                    tbKolVoPos.Clear();
                    break;
            }
        }

        private void tbSearchFiltration_TextChanged(object sender, EventArgs e)
        {
            chbFiltration_CheckedChanged(sender, e);
        }

        private void tbSearchFiltration_Enter(object sender, EventArgs e)
        {
            if (tbSearchFiltration.Text == "Введите данные клиента...")
                tbSearchFiltration.Clear();
        }

        private void tbSearchFiltration_Leave(object sender, EventArgs e)
        {
            if (tbSearchFiltration.Text == "")
                tbSearchFiltration.Text = "Введите данные клиента...";
        }

        private void tbSearchFiltration_Click(object sender, EventArgs e)
        {
            tbSearchFiltration.Clear();
        }

        private void chbFiltration_CheckedChanged(object sender, EventArgs e)
        {
            switch (chbFiltration.CheckState)
            {
                case (CheckState.Checked):
                    DataTable data = new DataTable("Clients");
                    commandSearchClient.CommandText = filterClient + " and [Surname] like '%" + tbSearchFiltration.Text
                        + "%' or [Name] like '%" + tbSearchFiltration.Text + "%' or [Otchestvo] like '%" + tbSearchFiltration.Text + "%' or CONVERT([varchar] (max), DECRYPTBYPASSPHRASE('KexibqП@р0ль!', [dbo].[Delo_klienta].[Telefon])) like '%" + tbSearchFiltration.Text + "%' or [Kol_vo_posicheniy] like '%" + tbSearchFiltration.Text + "%'";
                    RegistryData.DBConnectionString.Open();
                    data.Load(commandSearchClient.ExecuteReader());
                    RegistryData.DBConnectionString.Close();
                    dgvClients.DataSource = data;
                    dgvClients.Columns[0].Visible = false;
                    dgvClients.Columns[1].HeaderText = "Фамилия";
                    dgvClients.Columns[2].HeaderText = "Имя";
                    dgvClients.Columns[3].HeaderText = "Отчество";
                    dgvClients.Columns[4].HeaderText = "Номер телефона";
                    dgvClients.Columns[5].HeaderText = "Кол-во посещений";
                    dgvClients.ClearSelection();
                    break;
                case (CheckState.Unchecked):
                    ClientsFill();
                    for (int i = 0; i < dgvClients.RowCount; i++)
                    {
                        for (int j = 0; j < dgvClients.ColumnCount; j++)
                        {
                            if (dgvClients.Rows[i].Cells[j].Value != null)
                                if (dgvClients.Rows[i].Cells[j].Value.ToString().Contains(tbSearchFiltration.Text))
                                {
                                    dgvClients.Rows[i].Selected = true;
                                    break;
                                }
                        }
                    }
                    break;
            }
        }

        private void btnErrors_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RegistryData.ErrorMessage, "Ошибки информационной системы");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
