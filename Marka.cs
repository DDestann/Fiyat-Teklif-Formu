using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TeklifFormu
{
  public class Marka:DataConnection
    {

        public int MarkaId { get; set; }
        public string MarkaAdi { get; set; }
       

        public Marka()
        {
            this.MarkaId = -1;
            this.MarkaAdi = "";
           
        }

        public Marka(string MarkaAdi)//Ekle
        {
            this.MarkaId = -1;
            this.MarkaAdi = MarkaAdi;
            
        }

        public Marka(int MarkaId, string MarkaAdi)//Güncelle
        {
            this.MarkaId = MarkaId;
            this.MarkaAdi = MarkaAdi;
          
        }

        public Marka(int MarkaId)//Sil
        {
            this.MarkaId = MarkaId;
            this.MarkaAdi = "";
           
        }

        public void Marka_Ekle()
      {
          SqlCommand cmd = new SqlCommand("Marka_Ekle", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@MarkaAdi", this.MarkaAdi);
          ConOpen();
          cmd.ExecuteNonQuery();
          ConClose();
      
      }

        public void Marka_Sil()
      {
          SqlCommand cmd = new SqlCommand("Marka_Sil", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@MarkaId", this.MarkaId);
          ConOpen();
          cmd.ExecuteNonQuery();
          ConClose();

      }



        public void Marka_Guncelle()
      {
          SqlCommand cmd = new SqlCommand("Marka_Guncelle", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@MarkaId", this.MarkaId);
          cmd.Parameters.AddWithValue("@MarkaAdi", this.MarkaAdi);
          ConOpen();
          cmd.ExecuteNonQuery();
          ConClose();

      }

        public DataTable Marka_Listele()
      {
          SqlCommand cmd = new SqlCommand("Marka_Listele", con);
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
