using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace CarService
{
    public partial class QualificationEmployees : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        public QualificationEmployees()
        {
            InitializeComponent();
        }

        private void QualificationEmployees_Load(object sender, EventArgs e)
        {
            Thread threadQualification = new Thread(QualificationEmployeesFill);
            threadQualification.Start();
        }

        private void QualificationEmployeesFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                dbTables.DTKvalifsotrudnika.Clear();
                dbTables.DTKvalifsotrudnikaFill();
                dbTables.dependency.OnChange += ChangeDataQualification;

                lbQualification.DataSource = dbTables.DTKvalifsotrudnika;
                lbQualification.ValueMember = "ID_kvalif";
                lbQualification.DisplayMember = "Nazvanie_kvalif";
            };
            Invoke(action);
        }

        private void ChangeDataQualification(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                QualificationEmployeesFill();
            }
        }

        private void lbQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNameQualification.Text = lbQualification.Text;
        }

        private void lbQualification_Click(object sender, EventArgs e)
        {
            //tbNameQualification.Text = lbQualification.Text;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //ДОБАВИТЬ ВЫВОД ДИНАМИЧЕСКОГО ОКНА
            storedProcedure.SPKvalifsotrudnikaInsert(tbNameQualification.Text);
            tbNameQualification.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //ДОБАВИТЬ ВЫВОД ДИНАМИЧЕСКОГО ОКНА
            storedProcedure.SPKvalifsotrudnikaUpdate(Convert.ToInt32(lbQualification.SelectedValue.ToString()), tbNameQualification.Text);
            tbNameQualification.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           switch (MessageBox.Show("Вы действительно хотите удалить квалификация " + lbQualification.Text + "?", "Удаление квалификации", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    storedProcedure.SPKvalifsotrudnikaDelete(Convert.ToInt32(lbQualification.SelectedValue.ToString()));
                    break;
            }
            tbNameQualification.Clear();
        }

        private void btnErrors_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RegistryData.ErrorMessage, "Ошибки информационной системы");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            lbQualification.SelectedIndex = lbQualification.FindString(tbSearch.Text);
            lbQualification_Click(sender, e);
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Введите название квалификации...";
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Введите название квалификации...")
                tbSearch.Clear();
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
        }
    }
}
