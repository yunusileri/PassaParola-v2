using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Pasaparola
{
    public class GenelSorular
    {

        private string[] sorular;
        private string[] cevaplar;

        int sayac = 0;


        public GenelSorular()
        {
            Veritabanioku();

        }
        public string[] Sorular { get => sorular;}
        public string[] Cevaplar { get => cevaplar; }

        public void Veritabanioku()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VeriTabani.mdb");
            OleDbCommand Komut = new OleDbCommand(); // veri tabanı için bağlantı gerekli bağlantıları tanımlıyoruz.
            sorular = new string[140];// Soruoku struct tan yeni alan alıyoruz.
            cevaplar = new string[140];
            baglanti.Open();//baglantıyı açıyoruz.
            Komut.Connection = baglanti;
            Komut.CommandText = ("Select *From Tablo1");//tablo seciyoruz.
            OleDbDataReader oku = Komut.ExecuteReader();
            while (oku.Read())///tablo sonuna kadar bütün veriler sırayla belleğe alındı.
            {
                sorular[sayac] = oku["Sorular"].ToString();
                cevaplar[sayac] = oku["Cevaplar"].ToString();
                sayac++;
            }
            baglanti.Close();//veritabanını daha etkili kullanabilmek için kapatıyoruz.
        }



    }
}
