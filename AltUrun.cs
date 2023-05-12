using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeklifFormu
{
    public class AltUrun : DataConnection
    {
        public int AltUrunId { get; set; }
        public Urun Urun { get; set; }
        public string AltUrunAdi { get; set; }


        public AltUrun()
        {
            this.AltUrunId = -1;
            this.Urun = new Urun();
            this.AltUrunAdi = "";

        }

        public AltUrun(Urun Urun, string AltUrunAdi)//Ekle
        {
            this.AltUrunId = -1;
            this.Urun = Urun;
            this.AltUrunAdi = AltUrunAdi;

        }

        public AltUrun(int AltUrunId, Urun Urun, string AltUrunAdi)//Güncelle
        {
            this.AltUrunId = AltUrunId;
            this.Urun = Urun;
            this.AltUrunAdi = AltUrunAdi;

        }

        public AltUrun(int AltUrunId)//Sil
        {
            this.AltUrunId = AltUrunId;
            this.Urun = new Urun();
            this.AltUrunAdi = "";

        }

        public AltUrun(Urun Urun)//
        {
            this.AltUrunId = -1;
            this.Urun = Urun;
            this.AltUrunAdi = "";

        }

        public void AltUrun_Ekle()
        {
            SqlCommand cmd = new SqlCommand("AltUrun_Ekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UrunId", this.Urun.UrunId);
            cmd.Parameters.AddWithValue("@AltUrunAdi", this.AltUrunAdi);
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }

        public void AltUrun_Sil()
        {
            SqlCommand cmd = new SqlCommand("AltUrun_Sil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AltUrunId", this.AltUrunId);
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }



        public void AltUrun_Guncelle()
        {
            SqlCommand cmd = new SqlCommand("AltUrun_Guncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AltUrunId", this.AltUrunId);
            cmd.Parameters.AddWithValue("@UrunId", this.Urun.UrunId);
            cmd.Parameters.AddWithValue("@AltUrunAdi", this.AltUrunAdi);  
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }

        public DataTable AltUrun_Listele()
        {
            SqlCommand cmd = new SqlCommand("AltUrun_Listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            ConOpen();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            ConClose();
            return dt;

        }

        public DataTable Urun_Listele(int UrunId)
        {
            SqlCommand cmd = new SqlCommand("Urunn_Listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UrunId", UrunId);
            ConOpen();
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            ConClose();
            return dt;

        }




    }
}
