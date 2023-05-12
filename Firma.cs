using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TeklifFormu
{
  public class Firma:DataConnection
    {

        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; }
        public string Yetkili { get; set; }
        public string Tel { get; set; }
        public string Cep { get; set; }
        public string FirmaAciklama { get; set; }
        public DateTime KTarihi { get; set; }
        public DateTime GTarihi { get; set; }

        public Firma()
        {
            this.FirmaId = -1;
            this.FirmaAdi = "";
            this.Yetkili = "";
            this.Tel = "";
            this.Cep = "";
            this.FirmaAciklama = "";
            this.KTarihi = new DateTime();
        }

        public Firma(string FirmaAdi,string Yetkili,String Tel, string Cep, string FirmaAciklama, DateTime KTarihi)//Ekle
        {
            this.FirmaId = -1;
            this.FirmaAdi = FirmaAdi;
            this.Yetkili = Yetkili;
            this.Tel = Tel;
            this.Cep = Cep;
            this.FirmaAciklama = FirmaAciklama;
            this.KTarihi = KTarihi;
        }

        public Firma(int FirmaId,string FirmaAdi, string Yetkili, String Tel, string Cep, string FirmaAciklama, DateTime GTarihi)//Güncelle
        {
            this.FirmaId = FirmaId;
            this.FirmaAdi = FirmaAdi;
            this.Yetkili = Yetkili;
            this.Tel = Tel;
            this.Cep = Cep;
            this.FirmaAciklama = FirmaAciklama;
            this.GTarihi = GTarihi;
        }

        public Firma(int FirmaId)//Sil
        {
            this.FirmaId = FirmaId;
            this.FirmaAdi = "";
            this.Yetkili = "";
            this.Tel = "";
            this.Cep = "";
            this.FirmaAciklama = "";
            this.KTarihi = new DateTime();
        }

      public void Firma_Ekle()
      {
          SqlCommand cmd = new SqlCommand("Firma_Ekle", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@FirmaAdi",this.FirmaAdi);
          cmd.Parameters.AddWithValue("@Yetkili",this.Yetkili);
          cmd.Parameters.AddWithValue("@Tel", this.Tel);
          cmd.Parameters.AddWithValue("@Cep", this.Cep);
          cmd.Parameters.AddWithValue("@FirmaAciklama", this.FirmaAciklama);
          cmd.Parameters.AddWithValue("@KTarihi", this.KTarihi);
          
          ConOpen();
          cmd.ExecuteNonQuery();
          ConClose();
      
      }

      public void Firma_Sil()
      {
          SqlCommand cmd = new SqlCommand("Firma_Sil", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@FirmaId", this.FirmaId);
          ConOpen();
          cmd.ExecuteNonQuery();
          ConClose();

      }



      public void Firma_Guncelle()
      {
          SqlCommand cmd = new SqlCommand("Firma_Guncelle", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@FirmaId",this.FirmaId);
          cmd.Parameters.AddWithValue("@FirmaAdi", this.FirmaAdi);
          cmd.Parameters.AddWithValue("@Yetkili", this.Yetkili);
          cmd.Parameters.AddWithValue("@Tel", this.Tel);
          cmd.Parameters.AddWithValue("@Cep", this.Cep);
          cmd.Parameters.AddWithValue("@FirmaAciklama", this.FirmaAciklama);
          cmd.Parameters.AddWithValue("@GTarihi", this.GTarihi);
         
          ConOpen();
          cmd.ExecuteNonQuery();
          ConClose();

      }

      public DataTable Firma_Listele()
      {
          SqlCommand cmd = new SqlCommand("Firma_Listele", con);
          cmd.CommandType = CommandType.StoredProcedure;
          ConOpen();
          SqlDataReader dr = cmd.ExecuteReader();
          DataTable dt = new DataTable();
          dt.Load(dr);
          ConClose();
          return dt;

      }


      public DataTable Firma_Ekle_Kontrol(string FirmaAdi)
      {
          SqlCommand cmd = new SqlCommand("Firma_Ekle_Kontrol", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@FirmaAdi", FirmaAdi);

          ConOpen();
          SqlDataReader dr = cmd.ExecuteReader();
          DataTable dt = new DataTable();
          dt.Load(dr);
          ConClose();
          return dt;
      }





    }
}
