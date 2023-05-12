using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeklifFormu
{
    public class AltUrunFiyat : DataConnection
    {
        public int AltUrunFiyatId { get; set; }
        public AltUrun AltUrun { get; set; }
        public Double AltUrunFiyati { get; set; }


        public AltUrunFiyat()
        {
            this.AltUrunFiyatId = -1;
            this.AltUrun = new AltUrun();
            this.AltUrunFiyati =0;

        }

        public AltUrunFiyat(AltUrun AltUrun, Double AltUrunFiyat)//Ekle
        {
            this.AltUrunFiyatId = -1;
            this.AltUrun = AltUrun;
            this.AltUrunFiyati = AltUrunFiyat;

        }

        public AltUrunFiyat(int AltUrunFiyatId, AltUrun AltUrun, Double AltUrunFiyat)//Güncelle
        {
            this.AltUrunFiyatId = AltUrunFiyatId;
            this.AltUrun = AltUrun;
            this.AltUrunFiyati = AltUrunFiyat;

        }

        public AltUrunFiyat(int AltUrunFiyatId)//Sil
        {
            this.AltUrunFiyatId = AltUrunFiyatId;
            this.AltUrun = new AltUrun();
            this.AltUrunFiyati =0;

        }

        public AltUrunFiyat(AltUrun AltUrun)//
        {
            this.AltUrunFiyatId = -1;
            this.AltUrun = AltUrun;
            this.AltUrunFiyati = 0;

        }

        public void AltUrunFiyat_Ekle()
        {
            SqlCommand cmd = new SqlCommand("AltUrunFiyat_Ekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AltUrunId", this.AltUrun.AltUrunId);
            cmd.Parameters.AddWithValue("@AltUrunFiyat", this.AltUrunFiyati);
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }

        public void AltUrunFiyat_Sil()
        {
            SqlCommand cmd = new SqlCommand("AltUrunFiyat_Sil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AltUrunFiyatId", this.AltUrunFiyatId);
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }



        public void AltUrunFiyat_Guncelle()
        {
            SqlCommand cmd = new SqlCommand("AltUrunFiyat_Guncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AltUrunFiyatId", this.AltUrunFiyatId);
            cmd.Parameters.AddWithValue("@AltUrunId", this.AltUrun.AltUrunId);
            cmd.Parameters.AddWithValue("@AltUrunFiyat", this.AltUrunFiyati);  
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }

        public DataTable AltUrunFiyat_Listele()
        {
            SqlCommand cmd = new SqlCommand("AltUrunFiyat_Listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            ConOpen();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            ConClose();
            return dt;

        }

        public DataTable AltUrun_Listele(int UrunId)
        {
            SqlCommand cmd = new SqlCommand("AltUrunn_Listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AltUrunId", UrunId);
            ConOpen();
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            ConClose();
            return dt;

        }




    }
}
