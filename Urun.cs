using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TeklifFormu
{
  public class Urun:DataConnection
    {
      public int UrunId { get; set; }
      public Tur Tur { get; set; }
        public string UrunAdi { get; set; }
       

        public Urun()
        {
            this.UrunId = -1;
            this.Tur = new Tur();
            this.UrunAdi = "";
           
        }

        public Urun(Tur Tur, string UrunAdi)//Ekle
        {
            this.UrunId = -1;
            this.Tur = Tur;
            this.UrunAdi = UrunAdi;
            
        }

        public Urun(int UrunId, Tur Tur, string UrunAdi)//Güncelle
        {
            this.UrunId = UrunId;
            this.Tur = Tur;
            this.UrunAdi = UrunAdi;
          
        }

        public Urun(int UrunId)//Sil
        {
            this.UrunId = UrunId;
            this.Tur = new Tur();
            this.UrunAdi = "";
           
        }

        public Urun(Tur Tur)//
        {
            this.UrunId = -1;
            this.Tur = Tur;
            this.UrunAdi ="";

        }

        public void Urun_Ekle()
      {
          SqlCommand cmd = new SqlCommand("Urun_Ekle", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@TurId", this.Tur.TurId);
          cmd.Parameters.AddWithValue("@UrunAdi", this.UrunAdi);
          ConOpen();
          cmd.ExecuteNonQuery();
          ConClose();
      
      }

        public void Urun_Sil()
      {
          SqlCommand cmd = new SqlCommand("Urun_Sil", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@UrunId", this.UrunId);
          ConOpen();
          cmd.ExecuteNonQuery();
          ConClose();
          
      }



        public void Urun_Guncelle()
      {
          SqlCommand cmd = new SqlCommand("Urun_Guncelle", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@UrunId", this.UrunId);
          cmd.Parameters.AddWithValue("@TurId", this.Tur.TurId);
          cmd.Parameters.AddWithValue("@UrunAdi", this.UrunAdi);
          ConOpen();
          cmd.ExecuteNonQuery();
          ConClose();

      }

        public DataTable Urun_Listele()
      {
          SqlCommand cmd = new SqlCommand("Urun_Listele", con);
          cmd.CommandType = CommandType.StoredProcedure;
          ConOpen();
          SqlDataReader dr = cmd.ExecuteReader();
          DataTable dt = new DataTable();
          dt.Load(dr);
          ConClose();
          return dt;

      }

        public DataTable UrunTur_Listele(int TurId)
        {
            SqlCommand cmd = new SqlCommand("UrunTur_Listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TurId",TurId);
            ConOpen();
            SqlDataReader dr = cmd.ExecuteReader();
           
            DataTable dt = new DataTable();
            dt.Load(dr);
            ConClose();
            return dt;

        }




    }
}
