using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace TeklifFormu
{
    public class Tur : DataConnection
    {

        public int TurId { get; set; }
        public string TurAdi { get; set; }


        public Tur()
        {
            this.TurId = -1;
            this.TurAdi = "";

        }

        public Tur(string TurAdi)//Ekle
        {
            this.TurId = -1;
            this.TurAdi = TurAdi;

        }

        public Tur(int TurId, string TurAdi)//Güncelle
        {
            this.TurId = TurId;
            this.TurAdi = TurAdi;

        }

        public Tur(int TurId)//Sil
        {
            this.TurId = TurId;
            this.TurAdi = "";

        }

        public void Tur_Ekle()
        {
            SqlCommand cmd = new SqlCommand("Tur_Ekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TurAdi", this.TurAdi);
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }

        public void Tur_Sil()
        {
            SqlCommand cmd = new SqlCommand("Tur_Sil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TurId", this.TurId);
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }



        public void Tur_Guncelle()
        {
            SqlCommand cmd = new SqlCommand("Tur_Guncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TurId", this.TurId);
            cmd.Parameters.AddWithValue("@TurAdi", this.TurAdi);
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }

        public DataTable Tur_Listele()
        {
            SqlCommand cmd = new SqlCommand("Tur_Listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            ConOpen();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            ConClose();
            return dt;

        }


      



    }
}