using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Pasaparola
{
    class SkorClass
    {

        private static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VeriTabani.mdb");
        private static OleDbCommand Komut = new OleDbCommand();

        public static double Puanhesapla(int d, int s)
        {
            double Puan;
            return Puan = (d * 10.086) + (s * 2.14);
        }
        public static DataSet SkorGoruntule()
        {

            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select *From Tablo2", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "Tablo2");
            baglanti.Close();
            return ds;

        }

        public static double EnyüksekSkor()
        {
            double Eb = 0;
            int gecici;
            baglanti.Open();
            Komut.Connection = baglanti;
            Komut.CommandText = ("Select *From Tablo2");
            OleDbDataReader oku = Komut.ExecuteReader();

            while (oku.Read())
            {
                gecici = Convert.ToInt32(oku["Puan"]);
                if (gecici >= Eb)
                    Eb = gecici;

            }
            return Eb;
        }

        public static void PuanYaz(double puan, int dogru, int yanlis, int pas)
        {
            Komut.Connection = baglanti;
            Komut.CommandText = "Insert Into Tablo2(Puan,Dogru,Yanlis,Pas)Values('" + puan + "','" + dogru + "','" + yanlis + "','" + pas + "')";
            baglanti.Open();
            Komut.ExecuteNonQuery();
            Komut.Dispose();
            baglanti.Close();
        }

    }
}
