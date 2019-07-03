using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace CarService
{
    public partial class AmenitiesForm : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandSearchAminities = new SqlCommand("", RegistryData.DBConnectionString);
        private string filterAminities = "";

        public AmenitiesForm()
        {
            InitializeComponent();
        }

        private void AmenitiesForm_Load(object sender, EventArgs e)
        {
            Thread threadAminities = new Thread(AminitiesFill);
            threadAminities.Start();
        }

        private void AminitiesFill()
        {
            DBTables dBTables = new DBTables();

            Action action = () =>
            {
                try
                {
                    dBTables.DTUslugi.Clear();
                    dBTables.DTUslugiFill();
                    filterAminities = dBTables.QRUslugi;
                    dBTables.dependency.OnChange += ChangeDataUslugi;

                    dgvAmenities.DataSource = dBTables.DTUslugi;
                    dgvAmenities.Columns[0].Visible = false;
                    dgvAmenities.Columns[1].HeaderText = "Название услуги";
                    dgvAmenities.Columns[2].HeaderText = "Стоимость";
                    dgvAmenities.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки данных из базы данных!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void ChangeDataUslugi(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                AminitiesFill();
            }
        }

        private void dgvAmenities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNameService.Text = dgvAmenities.CurrentRow.Cells[1].Value.ToString();
            tbPrice.Text = dgvAmenities.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            storedProcedure.SPUslugiInsert(tbNameService.Text, Convert.ToInt32(tbPrice.Text));
            tbNameService.Clear();
            tbPrice.Clear();
            dgvAmenities.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            storedProcedure.SPUslugiUpdate(Convert.ToInt32(dgvAmenities.CurrentRow.Cells[0].Value.ToString()), tbNameService.Text, Convert.ToInt32(tbPrice.Text));
            tbNameService.Clear();
            tbPrice.Clear();
            dgvAmenities.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите удалить услугу " + tbNameService.Text + " " + tbPrice.Text + "?", "Удаление услуги", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    storedProcedure.SPUslugiDelete(Convert.ToInt32(dgvAmenities.CurrentRow.Cells[0].Value.ToString()));
                    break;
            }
        }

        private void tbSearchFiltration_TextChanged(object sender, EventArgs e)
        {
            chbFiltration_CheckedChanged(sender, e);
        }

        private void tbSearchFiltration_Enter(object sender, EventArgs e)
        {
            if (tbSearchFiltration.Text == "Введите данные услуги...")
                tbSearchFiltration.Clear();
        }

        private void tbSearchFiltration_Leave(object sender, EventArgs e)
        {
            if (tbSearchFiltration.Text == "")
                tbSearchFiltration.Text = "Введите данные услуги...";
        }

        private void tbSearchFiltration_Click(object sender, EventArgs e)
        {
            tbSearchFiltration.Clear();
        }

        private void chbFiltration_CheckedChanged(object sender, EventArgs e)
        {
            switch(chbFiltration.CheckState)
            {
                case (CheckState.Checked):
                    DataTable data = new DataTable("Uslugi");
                    commandSearchAminities.CommandText = filterAminities + " and [Nazvanie_uslugi] like '%" + tbSearchFiltration.Text + "%' or [Stoimost_uslugi] like '%" + tbSearchFiltration.Text + "%'";
                    RegistryData.DBConnectionString.Open();
                    data.Load(commandSearchAminities.ExecuteReader());
                    RegistryData.DBConnectionString.Close();
                    dgvAmenities.DataSource = data;
                    dgvAmenities.Columns[0].Visible = false;
                    dgvAmenities.Columns[1].HeaderText = "Название услуги";
                    dgvAmenities.Columns[2].HeaderText = "Стоимость";
                    dgvAmenities.ClearSelection();
                    break;
                case (CheckState.Unchecked):
                    AminitiesFill();
                    for (int i = 0; i < dgvAmenities.RowCount; i++)
                    {
                        for (int j = 0; j < dgvAmenities.ColumnCount; j++)
                        {
                            if (dgvAmenities.Rows[i].Cells[j].Value != null)
                                if (dgvAmenities.Rows[i].Cells[j].Value.ToString().Contains(tbSearchFiltration.Text))
                                {
                                    dgvAmenities.Rows[i].Selected = true;
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
