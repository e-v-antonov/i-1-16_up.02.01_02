using System;
using System.Data;
using System.Data.SqlClient;

namespace CarService
{
    class DBTables
    {
        public SqlCommand command = new SqlCommand("", RegistryData.DBConnectionString);

        public DataTable DTKvalifsotrudnika = new DataTable("Kvalif_sotrudnika");
        public DataTable DTUslugi = new DataTable("Uslugi");
        public DataTable DTDeloklienta = new DataTable("Delo_klienta");
        public DataTable DTRoli = new DataTable("Roli");        
        public DataTable DTDeloavtoklienta = new DataTable("Delo_avto_klienta");
        public DataTable DTZakazi = new DataTable("Zakazi");
        public DataTable DTSootvetzakazuuslug = new DataTable("Sootvet_zakazu_uslug");
        public DataTable DTDelosotrudnika = new DataTable("Delo_sotrudnika");
        public DataTable DTClientsComboBox = new DataTable("Clients");
        public string QRKvalifsotrudnika = "select [ID_kvalif], [Nazvanie_kvalif] from [dbo].[Kvalif_sotrudnika] " +
            "where [Kvalif_sotrudnika_Logical_Delete] = 0";
        public string QRUslugi = "select [ID_uslugi], [Nazvanie_uslugi], [Stoimost_uslugi] from [dbo].[Uslugi] where [Uslugi_Logical_Delete] = 0";
        public string QRDeloklienta = "select [ID_dela_klienta], [Surname], [Name], [Otchestvo], CONVERT([varchar] (max), " +
            "DECRYPTBYPASSPHRASE('KexibqП@р0ль!', [dbo].[Delo_klienta].[Telefon])), [Kol_vo_posicheniy] from [dbo].[Delo_klienta] " +
            "where [Delo_klienta_Logical_Delete] = 0";
        public string QRRoli = "select [ID_roli], [Nazvanie_roli] from [dbo][Roli] where [Roli_sotrudnikov_Logical_Delete] = 0";
        public string QRDeloavtoklienta = "select ID_dela_avto, Registr_znak, " +
            "CONVERT([varchar] (max), DECRYPTBYPASSPHRASE('KexibqП@р0ль!', [dbo].[Delo_avto_klienta].[Identific_nomer])), " +
            "Marka, Model, Color, God_vipuska, Delo_klienta_ID, Surname, Name, Otchestvo, " +
            "CONVERT([varchar] (max), DECRYPTBYPASSPHRASE('KexibqП@р0ль!', [dbo].[Delo_klienta].[Telefon])), " +
            "Repair_car_now from [dbo].[Delo_avto_klienta] inner join [dbo].[Delo_klienta] " +
            "on [dbo].[Delo_avto_klienta].[Delo_klienta_ID] = [dbo].[Delo_klienta].[ID_dela_klienta] " +
            "where Delo_avto_klienta_Logical_Delete = 0 and Delo_klienta_Logical_Delete = 0";
        public string QRZakazi = "select Nomer_zakaza, Zakaz_completed, Surname, Name, Otchestvo, CONVERT([varchar] (max), " +
            "DECRYPTBYPASSPHRASE('KexibqП@р0ль!', [dbo].[Delo_klienta].[Telefon])), Kol_vo_posicheniy, Registr_znak, CONVERT([varchar] (max), " +
            "DECRYPTBYPASSPHRASE('KexibqП@р0ль!', [dbo].[Delo_avto_klienta].[Identific_nomer])), Marka, Model, Color, God_vipuska, Repair_car_now " +
            "from[dbo].[Zakazi] inner join[dbo].[Delo_avto_klienta] on[dbo].[Zakazi].[Delo_avto_klienta_ID] = " +
            "[dbo].[Delo_avto_klienta].[ID_dela_avto]inner join[dbo].[Delo_klienta] on[dbo].[Zakazi].[Delo_klienta_ID] = " +
            "[dbo].[Delo_klienta].[ID_dela_klienta] where[dbo].[Delo_klienta].[Delo_klienta_Logical_Delete] = 0 and " +
            "[dbo].[Delo_avto_klienta].[Delo_avto_klienta_Logical_Delete] = 0 and[dbo].[Zakazi].[Zakazi_Logical_Delete] = 0";
        public string QRSootvetzakazuuslug = "select Nomer_zakaza, Zakaz_completed, [dbo].[Delo_klienta].[Surname], [dbo].[Delo_klienta].[Name], " +
            "[dbo].[Delo_klienta].[Otchestvo],CONVERT([varchar] (max), DECRYPTBYPASSPHRASE('KexibqП@р0ль!', [dbo].[Delo_klienta].[Telefon])), " +
            "Kol_vo_posicheniy, Registr_znak, CONVERT([varchar] (max), DECRYPTBYPASSPHRASE('KexibqП@р0ль!', " +
            "[dbo].[Delo_avto_klienta].[Identific_nomer])), Marka, Model,Color, God_vipuska, Repair_car_now, Nazvanie_uslugi, Stoimost_uslugi, " +
            "Usluga_done, [dbo].[Delo_sotrudnika].[Surname], [dbo].[Delo_sotrudnika].[Name],[dbo].[Delo_sotrudnika].[Otchestvo] " +
            "from [dbo].[Sootvet_zakazu_uslug]inner join[dbo].[Zakazi] on[dbo].[Sootvet_zakazu_uslug].[Zakazi_ID] = [dbo].[Zakazi].[ID_zakaza] " +
            "inner join[dbo].[Delo_avto_klienta] on[dbo].[Zakazi].[Delo_avto_klienta_ID] = [dbo].[Delo_avto_klienta].[ID_dela_avto] " +
            "inner join[dbo].[Delo_klienta] on [dbo].[Delo_avto_klienta].[Delo_klienta_ID] = [dbo].[Delo_klienta].[ID_dela_klienta] " +
            "inner join[dbo].[Uslugi] on [dbo].[Sootvet_zakazu_uslug].[Uslugi_ID] = [dbo].[Uslugi].[ID_uslugi] inner join[dbo].[Delo_sotrudnika] on " +
            "[dbo].[Sootvet_zakazu_uslug].[Delo_sotrudnika_ID] = [dbo].[Delo_sotrudnika].[ID_dela_sotrudnika] where " +
            "Sootvet_zakazu_uslug_Logical_Delete = 0 and Sootvet_zakazu_uslug_Logical_Delete = 0 and Delo_avto_klienta_Logical_Delete = 0 and " +
            "Delo_klienta_Logical_Delete = 0 and Uslugi_Logical_Delete = 0 and Delo_sotrudnika_Logical_Delete = 0";
        public string QRDelosotrudnika = "select Surname, Name, Otchestvo, CONVERT([varchar] (max), DECRYPTBYPASSPHRASE('KexibqП@р0ль!', " +
            "[dbo].[Delo_sotrudnika].[Telefon])), Nazvanie_kvalif,Kol_vo_let_staga, Kol_vo_zarplati, CONVERT([varchar] (max), " +
            "DECRYPTBYPASSPHRASE('KexibqП@р0ль!', [dbo].[Delo_sotrudnika].[Login])), CONVERT([varchar] (max), " +
            "DECRYPTBYPASSPHRASE('KexibqП@р0ль!', [dbo].[Delo_sotrudnika].[Password])), Nazvanie_roli from[dbo].[Delo_sotrudnika] " +
            "inner join[dbo].[Kvalif_sotrudnika] on[dbo].[Delo_sotrudnika].[Kvalif_sotrudnika_ID] = [dbo].[Kvalif_sotrudnika].[ID_kvalif] " +
            "inner join[dbo].[Roli_sotrudnikov] on[dbo].[Delo_sotrudnika].[Roli_sotrudnikov_ID] = [dbo].[Roli_sotrudnikov].[ID_roli] where " +
            "[dbo].[Delo_sotrudnika].[Delo_sotrudnika_Logical_Delete] = 0 and [dbo].[Kvalif_sotrudnika].[Kvalif_sotrudnika_Logical_Delete] and " +
            "[dbo].[Roli_sotrudnikov].[Roli_sotrudnikov_Logical_Delete] = 0";
        public string QRClientComboBox = "select ID_dela_klienta, Surname + ' ' + Name + ' ' + Otchestvo + ' ' + " +
            "CONVERT([varchar] (max), DECRYPTBYPASSPHRASE('KexibqП@р0ль!', Telefon)) as \"Client\" from [dbo].[Delo_klienta] " +
            "where Delo_klienta_Logical_Delete = 0";
        public SqlDependency dependency = new SqlDependency();

        private void DataTableFill(DataTable table, string query)
        {
            try
            {
                table.Clear();
                command.Notification = null;
                command.CommandText = query;
                dependency.AddCommandDependency(command);
                SqlDependency.Start(RegistryData.DBConnectionString.ConnectionString);
                RegistryData.DBConnectionString.Open();
                table.Load(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                RegistryData.DBConnectionString.Close();
            }
        }

        public void DTKvalifsotrudnikaFill()
        {
            DataTableFill(DTKvalifsotrudnika, QRKvalifsotrudnika);
        }

        public void DTUslugiFill()
        {
            DataTableFill(DTUslugi, QRUslugi);
        }

        public void DTDeloklientaFill()
        {
            DataTableFill(DTDeloklienta, QRDeloklienta);
        }
        public void DTRoliFill()
        {
            DataTableFill(DTRoli, QRRoli);
        }
        public void DTDeloavtoklientaFill()
        {
            DataTableFill(DTDeloavtoklienta, QRDeloavtoklienta);
        }
        public void DTZakaziFill()
        {
            DataTableFill(DTZakazi, QRZakazi);
        }
        public void DTSootvetzakazuuslugFill()
        {
            DataTableFill(DTSootvetzakazuuslug, QRSootvetzakazuuslug);
        }
        public void DTDelosotrudnikaFill()
        {
            DataTableFill(DTDelosotrudnika, QRDelosotrudnika);
        }

        public void DTClientsComboBoxFill()
        {
            DataTableFill(DTClientsComboBox, QRClientComboBox);
        }
    }
}
