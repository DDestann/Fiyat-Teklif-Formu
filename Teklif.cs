using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeklifFormu
{
   public class Teklif:DataConnection
   {
       public int TeklifId { get; set; }
       public Firma Firma { get; set; }
       public Marka Marka { get; set; }
       public Tur Tur { get; set; }
       public Urun Urun { get; set; }
       public AltUrun AltUrun { get; set; }
       public string Adet { get; set; }
       public int indirim1 { get; set; }
       public int indirim2 { get; set; }
       public int indirim3 { get; set; }
       public int indrimFiyati { get; set; }
       public AltUrunFiyat AltUrunFiyat { get; set; }

       public double ToplamFiyat { get; set; }
       public Birim Birim { get; set; }
       public DateTime KTarihi { get; set; }
       public DateTime GTarihi { get; set; }


       public Teklif()//Boş
       {
           this.TeklifId = -1;
           this.Firma = new Firma();
           this.Marka = new Marka();
           this.Tur = new Tur();
           this.Urun = new Urun();
           this.AltUrun = new AltUrun();
           this.Adet = "";
           this.indirim1 = 0;
           this.indirim2 = 0;
           this.indirim3 = 0;
           this.indrimFiyati = 0;
           this.AltUrunFiyat = new AltUrunFiyat();
           this.ToplamFiyat = 0;
           this.Birim = new Birim();
           this.KTarihi = new DateTime();
           this.GTarihi = new DateTime();
       }

       public Teklif(Firma Firma,Marka Marka,Tur Tur,Urun Urun,AltUrun AltUrun,string Adet,int indirim1,int indirim2,int indirim3,int indrimFiyati,AltUrunFiyat AltUrunFiyat,Double ToplamFiyat,Birim Birim,DateTime KTarihi)//Ekle
       {
           this.TeklifId = -1;
           this.Firma = Firma;
           this.Marka =Marka;
           this.Tur = Tur;
           this.Urun = Urun;
           this.AltUrun = AltUrun;
           this.Adet = Adet;
           this.indirim1 = indirim1;
           this.indirim2 = indirim2;
           this.indirim3 = indirim3;
           this.indrimFiyati = indrimFiyati;
           this.AltUrunFiyat = AltUrunFiyat;
           this.ToplamFiyat = ToplamFiyat;
           this.Birim = Birim;
           this.KTarihi = KTarihi;
           this.GTarihi = new DateTime();
       }


       public Teklif(int TeklifId, Firma Firma, Marka Marka, Tur Tur, Urun Urun, AltUrun AltUrun, string Adet, int indirim1, int indirim2, int indirim3,int indrimFiyati, AltUrunFiyat AltUrunFiyat,Double ToplamFiyat,Birim Birim, DateTime GTarihi)//Güncelle
       {
           this.TeklifId = TeklifId;
           this.Firma = Firma;
           this.Marka = Marka;
           this.Tur = Tur;
           this.Urun = Urun;
           this.AltUrun = AltUrun;
           this.Adet = Adet;
           this.indirim1 = indirim1;
           this.indirim2 = indirim2;
           this.indirim3 = indirim3;
           this.indrimFiyati = indrimFiyati;
           this.AltUrunFiyat = AltUrunFiyat;
           this.ToplamFiyat = ToplamFiyat;
           this.Birim = Birim;
           this.KTarihi = KTarihi;
           this.GTarihi = GTarihi;
       }


       public Teklif(int TeklifId)//Sil
       {
           this.TeklifId = TeklifId;
           this.Firma = new Firma();
           this.Marka = new Marka();
           this.Tur = new Tur();
           this.Urun = new Urun();
           this.AltUrun = new AltUrun();
           this.Adet = "";
           this.indirim1 = 0;
           this.indirim2 = 0;
           this.indirim3 = 0;
           this.indrimFiyati = 0;
           this.AltUrunFiyat = new AltUrunFiyat();
           this.ToplamFiyat = 0;
           this.Birim = new Birim();
           this.KTarihi = new DateTime();
           this.GTarihi = new DateTime();
       }


       public void Teklif_Ekle()
       {
           SqlCommand cmd = new SqlCommand("Teklif_Ekle", con);
           cmd.CommandType = CommandType.StoredProcedure;

           cmd.Parameters.AddWithValue("@FirmaId", this.Firma.FirmaId);
           cmd.Parameters.AddWithValue("@MarkaId", this.Marka.MarkaId);
           cmd.Parameters.AddWithValue("@TurId", this.Tur.TurId);
           cmd.Parameters.AddWithValue("@UrunId", this.Urun.UrunId);
           cmd.Parameters.AddWithValue("@AltUrunId", this.AltUrun.AltUrunId);
           cmd.Parameters.AddWithValue("@Adet", this.Adet);
           cmd.Parameters.AddWithValue("@indirim1", this.indirim1);
           cmd.Parameters.AddWithValue("@indirim2", this.indirim2);
           cmd.Parameters.AddWithValue("@indirim3", this.indirim3);
           cmd.Parameters.AddWithValue("@indirimFiyati", this.indrimFiyati);
           cmd.Parameters.AddWithValue("@AltUrunFiyatId", this.AltUrunFiyat.AltUrunFiyatId);
           cmd.Parameters.AddWithValue("@ToplamFiyat", this.ToplamFiyat);
           cmd.Parameters.AddWithValue("@BirimId",this.Birim.BirimId);
           cmd.Parameters.AddWithValue("@KTarihi", this.KTarihi);
           //cmd.Parameters.AddWithValue("@GTarihi", this.Tur.TurId);
           ConOpen();
           cmd.ExecuteNonQuery();
           ConClose();
       
       }


       public void Teklif_Guncelle()
       {
           SqlCommand cmd = new SqlCommand("Teklif_Guncelle", con);
           cmd.CommandType = CommandType.StoredProcedure;

           cmd.Parameters.AddWithValue("@TeklifId", this.TeklifId);
           cmd.Parameters.AddWithValue("@FirmaId", this.Firma.FirmaId);
           cmd.Parameters.AddWithValue("@MarkaId", this.Marka.MarkaId);
           cmd.Parameters.AddWithValue("@TurId", this.Tur.TurId);
           cmd.Parameters.AddWithValue("@UrunId", this.Urun.UrunId);
           cmd.Parameters.AddWithValue("@AltUrunId", this.AltUrun.AltUrunId);
           cmd.Parameters.AddWithValue("@Adet", this.Adet);
           cmd.Parameters.AddWithValue("@indirim1", this.indirim1);
           cmd.Parameters.AddWithValue("@indirim2", this.indirim2);
           cmd.Parameters.AddWithValue("@indirim3", this.indirim3);
           cmd.Parameters.AddWithValue("@indirimFiyati", this.indrimFiyati);
           cmd.Parameters.AddWithValue("@AltUrunFiyatId", this.AltUrunFiyat.AltUrunFiyatId);
           cmd.Parameters.AddWithValue("@ToplamFiyat", this.ToplamFiyat);
           cmd.Parameters.AddWithValue("@BirimId", this.Birim.BirimId);
           //cmd.Parameters.AddWithValue("@KTarihi", this.Tur.TurId);
           cmd.Parameters.AddWithValue("@GTarihi", this.GTarihi);
           ConOpen();
           cmd.ExecuteNonQuery();
           ConClose();

       }


       public void Teklif_Sil()
       {
           SqlCommand cmd = new SqlCommand("Teklif_Sil", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@TeklifId", this.TeklifId);
  
           ConOpen();
           cmd.ExecuteNonQuery();
           ConClose();

       }

       public DataTable Teklif_Listele()
       {
           SqlCommand cmd = new SqlCommand("Teklif_Listele", con);
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
