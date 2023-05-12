using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TeklifFormu
{
    public class Birim : DataConnection
    {

        public int BirimId { get; set; }
        public string BirimAdi { get; set; }


        public Birim()
        {
            this.BirimId = -1;
            this.BirimAdi = "";

        }

        public Birim(string BirimAdi)//Ekle
        {
            this.BirimId = -1;
            this.BirimAdi = BirimAdi;

        }

        public Birim(int BirimId, string BirimAdi)//Güncelle
        {
            this.BirimId = BirimId;
            this.BirimAdi = BirimAdi;

        }

        public Birim(int BirimId)//Sil
        {
            this.BirimId = BirimId;
            this.BirimAdi = "";

        }

        public void Birim_Ekle()
        {
            SqlCommand cmd = new SqlCommand("Birim_Ekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BirimAdi", this.BirimAdi);
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }

        public void Birim_Sil()
        {
            SqlCommand cmd = new SqlCommand("Birim_Sil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BirimId", this.BirimId);
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }



        public void Birim_Guncelle()
        {
            SqlCommand cmd = new SqlCommand("Birim_Guncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BirimId", this.BirimId);
            cmd.Parameters.AddWithValue("@BirimAdi", this.BirimAdi);
            ConOpen();
            cmd.ExecuteNonQuery();
            ConClose();

        }

        public DataTable Birim_Listele()
        {
            SqlCommand cmd = new SqlCommand("Birim_Listele", con);
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
