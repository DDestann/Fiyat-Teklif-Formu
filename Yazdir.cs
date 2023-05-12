using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeklifFormu
{
  public  class Yazdir:DataConnection
    {

       public int YazdirId { get; set; }
       public Firma Firma { get; set; }
       public Marka Marka { get; set; }
       public Tur Tur { get; set; }
       public Urun Urun { get; set; }
       public AltUrun AltUrun { get; set; }
       public string Adet { get; set; }
       public AltUrunFiyat AltUrunFiyat { get; set; }
       public double ToplamFiyat { get; set; }


       public Yazdir()//Boş
       {
           this.YazdirId = -1;
           this.Firma = new Firma();
           this.Marka = new Marka();
           this.Tur = new Tur();
           this.Urun = new Urun();
           this.AltUrun = new AltUrun();
           this.Adet = "";
           this.AltUrunFiyat = new AltUrunFiyat();
           this.ToplamFiyat = 0;

       }

       public Yazdir(Firma Firma,Marka Marka,Tur Tur,Urun Urun,AltUrun AltUrun,string Adet,AltUrunFiyat AltUrunFiyat,Double ToplamFiyat)//Ekle
       {
           this.YazdirId = -1;
           this.Firma = Firma;
           this.Marka =Marka;
           this.Tur = Tur;
           this.Urun = Urun;
           this.AltUrun = AltUrun;
           this.Adet = Adet;

           this.AltUrunFiyat = AltUrunFiyat;
           this.ToplamFiyat = ToplamFiyat;

       }


       //public Yazdir(int YazdirId, Firma Firma, Marka Marka, Tur Tur, Urun Urun, AltUrun AltUrun, string Adet, int indirim1, int indirim2, int indirim3, int indrimFiyati, AltUrunFiyat AltUrunFiyat, Double ToplamFiyat, DateTime KTarihi, DateTime GTarihi)//Güncelle
       //{
       //    this.YazdirId = YazdirId;
       //    this.Firma = Firma;
       //    this.Marka = Marka;
       //    this.Tur = Tur;
       //    this.Urun = Urun;
       //    this.AltUrun = AltUrun;
       //    this.Adet = Adet;
       //    this.indirim1 = indirim1;
       //    this.indirim2 = indirim2;
       //    this.indirim3 = indirim3;
       //    this.indrimFiyati = indrimFiyati;
       //    this.AltUrunFiyat = AltUrunFiyat;
       //    this.ToplamFiyat = ToplamFiyat;
       //    this.KTarihi = KTarihi;
       //    this.GTarihi = GTarihi;
       //}


       public Yazdir(int YazdirId)//Sil
       {
           this.YazdirId = YazdirId;
           this.Firma = new Firma();
           this.Marka = new Marka();
           this.Tur = new Tur();
           this.Urun = new Urun();
           this.AltUrun = new AltUrun();
           this.Adet = "";

           this.AltUrunFiyat = new AltUrunFiyat();
           this.ToplamFiyat = 0;

       }


       public void Yazdir_Ekle()
       {
           SqlCommand cmd = new SqlCommand("Yazdir_Ekle", con);
           cmd.CommandType = CommandType.StoredProcedure;

           cmd.Parameters.AddWithValue("@FirmaId", this.Firma.FirmaId);
           cmd.Parameters.AddWithValue("@MarkaId", this.Marka.MarkaId);
           cmd.Parameters.AddWithValue("@TurId", this.Tur.TurId);
           cmd.Parameters.AddWithValue("@UrunId", this.Urun.UrunId);
           cmd.Parameters.AddWithValue("@AltUrunId", this.AltUrun.AltUrunId);
           cmd.Parameters.AddWithValue("@Adet", this.Adet);
           cmd.Parameters.AddWithValue("@AltUrunFiyatId", this.AltUrunFiyat.AltUrunFiyatId);
           cmd.Parameters.AddWithValue("@ToplamFiyat", this.ToplamFiyat);

           ConOpen();
           cmd.ExecuteNonQuery();
           ConClose();
       
       }


       //public void Teklif_Guncelle()
       //{
       //    SqlCommand cmd = new SqlCommand("Teklif_Guncelle", con);
       //    cmd.CommandType = CommandType.StoredProcedure;

       //    cmd.Parameters.AddWithValue("@TeklifId", this.TeklifId);
       //    cmd.Parameters.AddWithValue("@FirmaId", this.Firma.FirmaId);
       //    cmd.Parameters.AddWithValue("@MarkaId", this.Marka.MarkaId);
       //    cmd.Parameters.AddWithValue("@TurId", this.Tur.TurId);
       //    cmd.Parameters.AddWithValue("@UrunId", this.Urun.UrunId);
       //    cmd.Parameters.AddWithValue("@AltUrunId", this.AltUrun.AltUrunId);
       //    cmd.Parameters.AddWithValue("@Adet", this.Adet);
       //    cmd.Parameters.AddWithValue("@indirim1", this.indirim1);
       //    cmd.Parameters.AddWithValue("@indirim2", this.indirim2);
       //    cmd.Parameters.AddWithValue("@indirim3", this.indirim3);
       //    cmd.Parameters.AddWithValue("@indirimFiyati", this.indrimFiyati);
       //    cmd.Parameters.AddWithValue("@AltUrunFiyatId", this.AltUrunFiyat.AltUrunFiyatId);
       //    cmd.Parameters.AddWithValue("@ToplamFiyat", this.ToplamFiyat);
       //    cmd.Parameters.AddWithValue("@KTarihi", this.Tur.TurId);
       //    cmd.Parameters.AddWithValue("@GTarihi", this.Tur.TurId);
       //    ConOpen();
       //    cmd.ExecuteNonQuery();
       //    ConClose();

       //}


       public void Yazdir_Sil()
       {
           SqlCommand cmd = new SqlCommand("Yazdir_Sil", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@YazdirId", this.YazdirId);
  
           ConOpen();
           cmd.ExecuteNonQuery();
           ConClose();

       }

       public DataTable Yazdir_Listele()
       {
           SqlCommand cmd = new SqlCommand("Yazdir_Listele", con);
           cmd.CommandType = CommandType.StoredProcedure;
           ConOpen();
           SqlDataReader dr = cmd.ExecuteReader();
           DataTable dt = new DataTable();
           dt.Load(dr);
           ConClose();
           return dt;

       }




      //public DataTable Excel_Yazdir()
      //{
      //    SqlCommand cmd = new SqlCommand("Excel_Aktar", con);
      //    cmd.CommandType = CommandType.StoredProcedure;
      //    ConOpen();
      //    SqlDataReader dr = cmd.ExecuteReader();
      //    DataTable dt = new DataTable();
      //    dt.Load(dr);
      //    ConClose();
      //    return dt;

      //}



    }
}
