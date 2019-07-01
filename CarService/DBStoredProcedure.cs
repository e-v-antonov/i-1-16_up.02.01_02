using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CarService
{
    class DBStoredProcedure
    {
        private SqlCommand storedProcedure = new SqlCommand("", RegistryData.DBConnectionString);//добавляем подключение к БД

        private void ConfigurationProcedure(string nameProcedure)
        {
            storedProcedure.CommandText = nameProcedure;
            storedProcedure.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public void SPDeloklientaInsert(string Surname, string Name, string Otchestvo, string Telefon)
        {
            ConfigurationProcedure("Delo_klienta_Insert");

            storedProcedure.Parameters.AddWithValue("@Surname", Surname);
            storedProcedure.Parameters.AddWithValue("@Name", Name);
            storedProcedure.Parameters.AddWithValue("@Otchestvo", Otchestvo);
            storedProcedure.Parameters.AddWithValue("@Telefon", Telefon);

            ExecuteStoredProcedure();
        }
        public void SPDeloklientaUpdate(Int32 idDeloKlienta, string Surname, string Name, string Otchestvo, string Telefon)
        {
            ConfigurationProcedure("Delo_klienta_Update");

            storedProcedure.Parameters.AddWithValue("@ID_Delo_klienta", idDeloKlienta);
            storedProcedure.Parameters.AddWithValue("@Surname", Surname);
            storedProcedure.Parameters.AddWithValue("@Name", Name);
            storedProcedure.Parameters.AddWithValue("@Otchestvo", Otchestvo);
            storedProcedure.Parameters.AddWithValue("@Telefon", Telefon);

            ExecuteStoredProcedure();
        }
        public void SPDeloklientaDelete(Int32 idDelaKlienta)
        {
            ConfigurationProcedure("Delo_klienta_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_dela_klineta", idDelaKlienta);

            ExecuteStoredProcedure();
        }
        public void SPDeloklientaLogicalDelete(Int32 idDelaKlienta)
        {
            ConfigurationProcedure("Delo_klienta_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Dela_Klineta", idDelaKlienta);

            ExecuteStoredProcedure();
        }


        public void SPDelokavtolientaInsert(string Registrznak,string Identificnomer,string Marka, string Model, string Color, 
            Int32 Godvipuska, Int32 DeloklientaID)
        {
            ConfigurationProcedure("Delo_avto_klienta_Insert");

            storedProcedure.Parameters.AddWithValue("@Registr_znak", Registrznak);
            storedProcedure.Parameters.AddWithValue("@Identific_nomer", Identificnomer);
            storedProcedure.Parameters.AddWithValue("@Marka", Marka);
            storedProcedure.Parameters.AddWithValue("@Model", Model);
            storedProcedure.Parameters.AddWithValue("@Color", Color);
            storedProcedure.Parameters.AddWithValue("@God_vipuska", Godvipuska);
            storedProcedure.Parameters.AddWithValue("@Delo_klienta_ID", DeloklientaID);

            ExecuteStoredProcedure();
        }
        public void SPDelokavtolientaUpdate(Int32 idDeloavtoklienta, string Registrznak, string Identificnomer, string Marka, string Model, string Color,
            Int32 Godvipuska, Int32 DeloklientaID)
        {
            ConfigurationProcedure("Delo_avto_klienta_Update");

            storedProcedure.Parameters.AddWithValue("@ID_Delo_avto_klienta", idDeloavtoklienta);
            storedProcedure.Parameters.AddWithValue("@Registr_znak", Registrznak);
            storedProcedure.Parameters.AddWithValue("@Identific_nomer", Identificnomer);
            storedProcedure.Parameters.AddWithValue("@Marka", Marka);
            storedProcedure.Parameters.AddWithValue("@Model", Model);
            storedProcedure.Parameters.AddWithValue("@Color", Color);
            storedProcedure.Parameters.AddWithValue("@God_vipuska", Godvipuska);
            storedProcedure.Parameters.AddWithValue("@Delo_klienta_ID", DeloklientaID);

            ExecuteStoredProcedure();
        }
        public void SPDeloavtoklientaDelete(Int32 idDelaAvto)
        {
            ConfigurationProcedure("Delo_avto_klienta_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_dela_avto", idDelaAvto);

            ExecuteStoredProcedure();
        }
        public void SPDeloavtoklientaLogicalDelete(Int32 idDelaAvto)
        {
            ConfigurationProcedure("Delo_avto_klienta_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_dela_avto", idDelaAvto);

            ExecuteStoredProcedure();
        }


        public void SPUslugiInsert(string Nazvanieuslugi, decimal Stoimostuslugi)
        {
            ConfigurationProcedure("Uslugi_Insert");

            storedProcedure.Parameters.AddWithValue("@Nazvanie_uslugi", Nazvanieuslugi);
            storedProcedure.Parameters.AddWithValue("@Stoimost_uslugi", Stoimostuslugi);

            ExecuteStoredProcedure();
        }
        public void SPUslugiUpdate(Int32 iduslugi, string Nazvanieuslugi, decimal Stoimostuslugi)
        {
            ConfigurationProcedure("Uslugi_Update");

            storedProcedure.Parameters.AddWithValue("@ID_uslugi", iduslugi);
            storedProcedure.Parameters.AddWithValue("@Nazvanie_uslugi", Nazvanieuslugi);
            storedProcedure.Parameters.AddWithValue("@Stoimost_uslugi", Stoimostuslugi);

            ExecuteStoredProcedure();
        }
        public void SPUslugiDelete(Int32 iduslugi)
        {
            ConfigurationProcedure("Uslugi_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_uslugi", iduslugi);

            ExecuteStoredProcedure();
        }
        public void SPUslugiLogicalDelete(Int32 iduslugi)
        {
            ConfigurationProcedure("Uslugi_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_uslugi", iduslugi);

            ExecuteStoredProcedure();
        }

        public void SPKvalifsotrudnikaInsert(string Nazvaniekvalif)
        {
            ConfigurationProcedure("Kvalif_sotrudnika_Insert");

            
            storedProcedure.Parameters.AddWithValue("@Nazvanie_kvalif", Nazvaniekvalif);

            ExecuteStoredProcedure();
        }
        public void SPKvalifsotrudnikaUpdate(Int32 idkvalif, string Nazvaniekvalif)
        {
            ConfigurationProcedure("Kvalif_sotrudnika_Update");

            storedProcedure.Parameters.AddWithValue("@ID_kvalif", idkvalif);
            storedProcedure.Parameters.AddWithValue("@Nazvanie_kvalif", Nazvaniekvalif);

            ExecuteStoredProcedure();
        }

        public void SPKvalifsotrudnikaDelete(Int32 idkvalif)
        {
            ConfigurationProcedure("Kvalif_sotrudnika_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_kvalif", idkvalif);

            ExecuteStoredProcedure();
        }
        public void SPKvalifsotrudnikaLogicalDelete(Int32 idkvalif)
        {
            ConfigurationProcedure("Kvalif_sotrudnika_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_kvalif", idkvalif);

            ExecuteStoredProcedure();
        }

        public void SPRolisotrudnikovInsert(string Nazvanieroli)
        {
            ConfigurationProcedure("Roli_sotrudnikov_Insert");


            storedProcedure.Parameters.AddWithValue("@Nazvanie_roli", Nazvanieroli);

            ExecuteStoredProcedure();
        }
        public void SPRolisotrudnikovUpdate(Int32 idroli,string Nazvanieroli)
        {
            ConfigurationProcedure("Roli_sotrudnikov_Update");

            storedProcedure.Parameters.AddWithValue("@ID_roli", idroli);
            storedProcedure.Parameters.AddWithValue("@Nazvanie_roli", Nazvanieroli);

            ExecuteStoredProcedure();
        }
        public void SPRolisotrudnikovDelete(Int32 idroli)
        {
            ConfigurationProcedure("Roli_sotrudnikov_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_roli", idroli);

            ExecuteStoredProcedure();
        }
        public void SPRolisotrudnikovLogicalDelete(Int32 idroli)
        {
            ConfigurationProcedure("Roli_sotrudnikov_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_roli", idroli);

            ExecuteStoredProcedure();
        }
        public void SPZakaziInsert(Int32 Nomerzakaza, Int32 DeloklientaID, Int32 DeloavtoklientaID)
        {
            ConfigurationProcedure("Zakazi_Insert");

            storedProcedure.Parameters.AddWithValue("@Nomer_zakaza", Nomerzakaza);
            storedProcedure.Parameters.AddWithValue("@Delo_klienta_ID", DeloklientaID);
            storedProcedure.Parameters.AddWithValue("@Delo_avtoklienta_ID", DeloavtoklientaID);

            ExecuteStoredProcedure();
        }

            public void SPZakaziUpdate(Int32 idzakaza, Int32 Nomerzakaza, Int32 DeloklientaID, Int32 DeloavtoklientaID)
        {
            ConfigurationProcedure("Zakazi_Update");

            storedProcedure.Parameters.AddWithValue("@ID_zakaza", idzakaza);
            storedProcedure.Parameters.AddWithValue("@Nomer_zakaza", Nomerzakaza);
            storedProcedure.Parameters.AddWithValue("@Delo_klienta_ID", DeloklientaID);
            storedProcedure.Parameters.AddWithValue("@Delo_avtoklienta_ID", DeloavtoklientaID);

            ExecuteStoredProcedure();
        }

        public void SPZakaziDelete(Int32 idZakaza)
        {
            ConfigurationProcedure("Zakazi_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_zakaza", idZakaza);

            ExecuteStoredProcedure();
        }
        public void SPZakaziLogicalDelete(Int32 idZakaza)
        {
            ConfigurationProcedure("Zakazi_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_zakaza", idZakaza);

            ExecuteStoredProcedure();
        }
        public void SPSootvetzakazuuslugInsert(Int32 UslugiID, Int32 ZakaziID)
        {
            ConfigurationProcedure("Sootvet_zakazu_uslug_Insert");

            storedProcedure.Parameters.AddWithValue("@Uslugi_ID", UslugiID);
            storedProcedure.Parameters.AddWithValue("@Zakazi_ID", ZakaziID);

            ExecuteStoredProcedure();
        }
        public void SPSootvetzakazuuslugUpdate(Int32 idsootvet, Int32 UslugiID, Int32 ZakaziID)
        {
            ConfigurationProcedure("Sootvet_zakazu_uslug_Update");

            storedProcedure.Parameters.AddWithValue("@ID_sootvet", idsootvet);
            storedProcedure.Parameters.AddWithValue("@Uslugi_ID", UslugiID);
            storedProcedure.Parameters.AddWithValue("@Zakazi_ID", ZakaziID);

            ExecuteStoredProcedure();
        }
        public void SPSootvetzakazuuslugDelete(Int32 idsootvet)
        {
            ConfigurationProcedure("Sootvet_zakazu_uslug_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_sootvet", idsootvet);

            ExecuteStoredProcedure();
        }
        public void SPSootvetzakazuuslugLogicalDelete(Int32 idsootvet)
        {
            ConfigurationProcedure("Sootvet_zakazu_uslug_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_sootvet", idsootvet);

            ExecuteStoredProcedure();
        }
        public void SPDelosotrudnikaInsert(string Surname, string Name, string Otchestvo, string Telefon, Int32 Kolvoletstaga,
        decimal Kolvozarplati, string Login, string Password, Int32 RolisotrudnikovID, Int32 KvalifsotrudnikaID, Int32 UslugiID)
        {
            ConfigurationProcedure("Delo_sotrudnika_Insert");

            storedProcedure.Parameters.AddWithValue("@Surname", Surname);
            storedProcedure.Parameters.AddWithValue("@Name", Name);
            storedProcedure.Parameters.AddWithValue("@Otchestvo", Otchestvo);
            storedProcedure.Parameters.AddWithValue("@Telefon", Telefon);
            storedProcedure.Parameters.AddWithValue("@Kol_vo_let_staga", Kolvoletstaga);
            storedProcedure.Parameters.AddWithValue("@Kol_vo_zarplati", Kolvozarplati);
            storedProcedure.Parameters.AddWithValue("@Login", Login);
            storedProcedure.Parameters.AddWithValue("@Password", Password);
            storedProcedure.Parameters.AddWithValue("@Roli_sotrudnikov_ID", RolisotrudnikovID);
            storedProcedure.Parameters.AddWithValue("@Kvalif_sotrudnika_ID", KvalifsotrudnikaID);
            storedProcedure.Parameters.AddWithValue("@Uslugi_ID", UslugiID);

            ExecuteStoredProcedure();
        }
        public void SPDelosotrudnikaUpdate(Int32 iddelasotrudnika, string Surname, string Name, string Otchestvo, string Telefon, Int32 Kolvoletstaga,
        decimal Kolvozarplati, string Login, string Password, Int32 RolisotrudnikovID, Int32 KvalifsotrudnikaID, Int32 UslugiID)
        {
            ConfigurationProcedure("Delo_sotrudnika_Update");

            storedProcedure.Parameters.AddWithValue("@ID_dela_sotrudnika", iddelasotrudnika);
            storedProcedure.Parameters.AddWithValue("@Surname", Surname);
            storedProcedure.Parameters.AddWithValue("@Name", Name);
            storedProcedure.Parameters.AddWithValue("@Otchestvo", Otchestvo);
            storedProcedure.Parameters.AddWithValue("@Telefon", Telefon);
            storedProcedure.Parameters.AddWithValue("@Kol_vo_let_staga", Kolvoletstaga);
            storedProcedure.Parameters.AddWithValue("@Kol_vo_zarplati", Kolvozarplati);
            storedProcedure.Parameters.AddWithValue("@Login", Login);
            storedProcedure.Parameters.AddWithValue("@Password", Password);
            storedProcedure.Parameters.AddWithValue("@Roli_sotrudnikov_ID", RolisotrudnikovID);
            storedProcedure.Parameters.AddWithValue("@Kvalif_sotrudnika_ID", KvalifsotrudnikaID);
            storedProcedure.Parameters.AddWithValue("@Uslugi_ID", UslugiID);

            ExecuteStoredProcedure();
        }
        public void SPDelosotrudnikaDelete(Int32 iddelasotrudnika)
        {
            ConfigurationProcedure("Delo_sotrudnika_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_dela_sotrudnika", iddelasotrudnika);

            ExecuteStoredProcedure();
        }
        public void SPDelosotrudnikaLogicalDelete(Int32 iddelasotrudnika)
        {
            ConfigurationProcedure("Delo_sotrudnika_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_dela_sotrudnika", iddelasotrudnika);

            ExecuteStoredProcedure();
        }

        private void ExecuteStoredProcedure()
        {
            try
            {
                RegistryData.DBConnectionString.Open();
                RegistryData.DBConnectionString.InfoMessage += MessageInformation;
                storedProcedure.ExecuteNonQuery();
                storedProcedure.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryData.DBConnectionString.Close();
            }
        }
        private void MessageInformation(object sender, SqlInfoMessageEventArgs e)
        {
            RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + " " + e.Message;
        }
    }
}
