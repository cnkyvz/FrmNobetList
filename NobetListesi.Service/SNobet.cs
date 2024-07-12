using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NobetListesi.Interface;

namespace NobetListesi.Service
{
    public class SNobet

    {
        public void NobetList(string adSoyad, string telNo, string mail)

        {
            string ConnectionString = "Data Source=DESKTOP-IEIMSH4\\SQLEXPRESS;Initial Catalog=kullanici_bilgileri;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "INSERT INTO NobetTablo (AD_SOYAD, TEL_NO, MAIL) VALUES ('" + adSoyad + "','" + telNo + "','" + mail + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable Kisiler(string ay)

        {
            string ConnectionString = "Data Source=DESKTOP-IEIMSH4\\SQLEXPRESS;Initial Catalog=kullanici_bilgileri;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "  SELECT DISTINCT(AD_SOYAD) FROM NobetTablo order by 1";
            SqlParameter parametre = new SqlParameter();
            parametre.SqlDbType = SqlDbType.DateTime;
            parametre.Direction = ParameterDirection.Input;
            SqlCommand cmd = new SqlCommand(Query, con);

            //parametre.ParameterName = "ay";
            //parametre.Value = ay.ToString("(M");
            //cmd.Parameters.Add(parametre);

            cmd.ExecuteNonQuery();
            SqlDataAdapter dataAdapt = new SqlDataAdapter();
            dataAdapt.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            dataAdapt.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable NobetListGrid()
        {
            string ConnectionString = "Data Source=DESKTOP-IEIMSH4\\SQLEXPRESS;Initial Catalog=kullanici_bilgileri;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "SELECT  AD_SOYAD, TEL_NO, MAIL, KAYIT_TARIHI FROM NobetTablo ";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter dataAdapt = new SqlDataAdapter();
            dataAdapt.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            dataAdapt.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public void NobetDongu(DateTime dt)
        {
            DateTime today = DateTime.Today;
            dt = today;

            int gun = (int)dt.DayOfWeek;
            if (gun == 6 || gun == 0)
            {
                //haftasonu   
            }

            else
            {
                //haftaici

                string ConnectionString = "Data Source=DESKTOP-IEIMSH4\\SQLEXPRESS;Initial Catalog=kullanici_bilgileri;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string Query = "INSERT INTO NobetTablo (TARIH) VALUES ('" + dt + "')";
                SqlCommand com = new SqlCommand(Query, con);
                com.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}