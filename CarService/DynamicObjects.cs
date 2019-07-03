using System;
using System.Windows.Forms;
namespace CarService
{
    class DynamicObjects
    {
        //Положительное выполнение
        //Форма Успешное добавление записи
        public Form fmRecord = new Form();
        public Label lblRecord = new Label();
        public Button btnOk = new Button();
        public Form parentCreate = new Form();

        public void RecordAddedCreateForm()
        {
            fmRecord.Text = "Добавление записи";
            fmRecord.StartPosition = FormStartPosition.CenterScreen;
            fmRecord.BackColor = System.Drawing.Color.LightGreen;
            fmRecord.MinimizeBox = false;
            fmRecord.MaximizeBox = false;

            lblRecord.Text = "Запись успешно добавлена!";
            lblRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lblRecord.Dock = DockStyle.Top;
            lblRecord.Height = 50;
            lblRecord.Font = new System.Drawing.Font("Times New Roman", 16, System.Drawing.FontStyle.Bold);

            btnOk.Text = "Ok";
            btnOk.Dock = DockStyle.Top;
            btnOk.BackColor = System.Drawing.Color.LightGray;
            btnOk.Click += btnOk_Click;

            fmRecord.Size = new System.Drawing.Size(300, 110);
            fmRecord.Controls.Add(btnOk);
            fmRecord.Controls.Add(lblRecord);

            fmRecord.Show();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Click -= btnOk_Click;
            fmRecord.Controls.Remove(btnOk);
            fmRecord.Controls.Remove(lblRecord);
            fmRecord.Close();
        }

        //Форма Успешное добавление записи
        public void RecordUpdateCreateForm()
        {
            fmRecord.Text = "Изменение записи";
            fmRecord.StartPosition = FormStartPosition.CenterScreen;
            fmRecord.BackColor = System.Drawing.Color.LightGreen;
            fmRecord.MinimizeBox = false;
            fmRecord.MaximizeBox = false;

            lblRecord.Text = "Запись успешно изменена!";
            lblRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lblRecord.Dock = DockStyle.Top;
            lblRecord.Height = 50;
            lblRecord.Font = new System.Drawing.Font("Times New Roman", 16, System.Drawing.FontStyle.Bold);

            btnOk.Text = "Ok";
            btnOk.Dock = DockStyle.Top;
            btnOk.BackColor = System.Drawing.Color.LightGray;
            btnOk.Click += btnOk_Click;

            fmRecord.Size = new System.Drawing.Size(300, 110);
            fmRecord.Controls.Add(btnOk);
            fmRecord.Controls.Add(lblRecord);

            fmRecord.Show();
        }
        //Форма Успешное удаление записи
        public void RecordDeleteCreateForm()
        {
            fmRecord.Text = "Удаление записи";
            fmRecord.StartPosition = FormStartPosition.CenterScreen;
            fmRecord.BackColor = System.Drawing.Color.LightGreen;
            fmRecord.MinimizeBox = false;
            fmRecord.MaximizeBox = false;

            lblRecord.Text = "Запись успешно удалена!";
            lblRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lblRecord.Dock = DockStyle.Top;
            lblRecord.Height = 50;
            lblRecord.Font = new System.Drawing.Font("Times New Roman", 16, System.Drawing.FontStyle.Bold);

            btnOk.Text = "Ok";
            btnOk.Dock = DockStyle.Top;
            btnOk.BackColor = System.Drawing.Color.LightGray;
            btnOk.Click += btnOk_Click;

            fmRecord.Size = new System.Drawing.Size(300, 110);
            fmRecord.Controls.Add(btnOk);
            fmRecord.Controls.Add(lblRecord);

            fmRecord.Show();
        }
        //Отказ выполнения
        //Форма ошибка добавления
        public void RecordNotCreateForm()
        {
            fmRecord.Text = "Добавление записи";
            fmRecord.StartPosition = FormStartPosition.CenterScreen;
            fmRecord.BackColor = System.Drawing.Color.Red;
            fmRecord.MinimizeBox = false;
            fmRecord.MaximizeBox = false;

            lblRecord.Text = "Не удалось довабить запись!";
            lblRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lblRecord.Dock = DockStyle.Top;
            lblRecord.Height = 50;
            lblRecord.Font = new System.Drawing.Font("Times New Roman", 16, System.Drawing.FontStyle.Bold);

            btnOk.Text = "Ok";
            btnOk.Dock = DockStyle.Top;
            btnOk.BackColor = System.Drawing.Color.LightGray;
            btnOk.Click += btnOk_Click;

            fmRecord.Size = new System.Drawing.Size(300, 110);
            fmRecord.Controls.Add(btnOk);
            fmRecord.Controls.Add(lblRecord);

            fmRecord.Show();
        }

        //Форма ошибка изменения
        public void RecordNotUpdateCreateForm()
        {
            fmRecord.Text = "Изменение записи";
            fmRecord.StartPosition = FormStartPosition.CenterScreen;
            fmRecord.BackColor = System.Drawing.Color.Red;
            fmRecord.MinimizeBox = false;
            fmRecord.MaximizeBox = false;

            lblRecord.Text = "Не удалось изменить запись!";
            lblRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lblRecord.Dock = DockStyle.Top;
            lblRecord.Height = 50;
            lblRecord.Font = new System.Drawing.Font("Times New Roman", 16, System.Drawing.FontStyle.Bold);

            btnOk.Text = "Ok";
            btnOk.Dock = DockStyle.Top;
            btnOk.BackColor = System.Drawing.Color.LightGray;
            btnOk.Click += btnOk_Click;

            fmRecord.Size = new System.Drawing.Size(300, 110);
            fmRecord.Controls.Add(btnOk);
            fmRecord.Controls.Add(lblRecord);

            fmRecord.Show();
        }

        //Форма ошибка удаления
        public void RecordNotDeleteCreateForm()
        {
            fmRecord.Text = "Удаление записи";
            fmRecord.StartPosition = FormStartPosition.CenterScreen;
            fmRecord.BackColor = System.Drawing.Color.Red;
            fmRecord.MinimizeBox = false;
            fmRecord.MaximizeBox = false;

            lblRecord.Text = "Не удалось удалить запись!";
            lblRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lblRecord.Dock = DockStyle.Top;
            lblRecord.Height = 50;
            lblRecord.Font = new System.Drawing.Font("Times New Roman", 16, System.Drawing.FontStyle.Bold);

            btnOk.Text = "Ok";
            btnOk.Dock = DockStyle.Top;
            btnOk.BackColor = System.Drawing.Color.LightGray;
            btnOk.Click += btnOk_Click;

            fmRecord.Size = new System.Drawing.Size(300, 110);
            fmRecord.Controls.Add(btnOk);
            fmRecord.Controls.Add(lblRecord);

            fmRecord.Show();
        }
    }
}