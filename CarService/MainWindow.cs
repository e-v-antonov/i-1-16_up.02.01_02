using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarService
{
    public partial class MainWindow : Form
    {
        private DBConnection dbConnection = new DBConnection();
        private RegistryData registryData = new RegistryData();
        private Thread threadCheckConnection;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionForm connectionForm = new ConnectionForm();
            connectionForm.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lbsstConnection.Visible = true;
            lbsstConnection.Text = "Определение сервера...";
            dbConnection.ConnectionState += InformationConnection;
            threadCheckConnection = new Thread(dbConnection.CheckConnection);
            threadCheckConnection.Start();
        }

        private void InformationConnection(bool value)  //проверка подключения к базе данных
        {
            try
            {
                Action action = () =>
                {
                    switch (value)
                    {
                        case (true):
                            lbsstConnection.Text = RegistryData.DataSourceIP + "\\" + RegistryData.DataSourceServerName + " - " + RegistryData.InitialCatalog;
                            //AuthorizationForm authorizationForm = new AuthorizationForm();
                            //authorizationForm.Show(this);
                            break;
                        case (false):
                            lbsstConnection.Text = "Нет подключения к базе данных";

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "ConnectionForm")
                                    return;
                            }

                            ConnectionForm connectionForm = new ConnectionForm();
                            connectionForm.Show(this);
                            break;
                    }
                };
                Invoke(action);
            }
            catch
            {
                threadCheckConnection.Abort();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QualificationEmployees qualificationEmployees = new QualificationEmployees();
            qualificationEmployees.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmenitiesForm amenitiesForm = new AmenitiesForm();
            amenitiesForm.Show(this);
        }
    }
}