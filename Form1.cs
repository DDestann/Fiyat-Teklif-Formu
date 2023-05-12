using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace TeklifFormu
{
    public partial class Form1 : Form
    {
        Double Sonuc;
        Double indirim;
        Double indirimTopla;

        Firma Firma = new Firma();
        Tur Tur = new Tur();
        Urun Urun = new Urun();
        Marka Marka = new Marka();
        Birim Birim = new Birim();
        AltUrun AltUrun = new AltUrun();
        Yazdir Yazdir = new Yazdir();
        AltUrunFiyat AltUrunFiyat = new AltUrunFiyat();
        Teklif Teklif = new Teklif();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Firma_Listele();
            Tur_Listele();
            Marka_Listele();
            Birim_Listele();
           // Excel_Aktar();
            Yazdirr_Listele();
            Tekliff_Listele();
            txt_temizle();

        }

        private void Yazdirr_Listele()
        {
            System.Data.DataTable dt = Yazdir.Yazdir_Listele();
            dtlListele.DataSource = dt;
        }

        private void txt_temizle()
        {
            txtAdet.Text = "";
            txtToplamFiyat.Text = "";
            txtindirim1.Text = "0";
            txtindirim2.Text = "0";
            txtindirim3.Text = "0";
            txtindirimFiyat.Text = "";


        }

        private void Tekliff_Listele()
        {
            System.Data.DataTable dt = Teklif.Teklif_Listele();
            dtlListeleFull.DataSource = dt;
        }



        //private void Excel_Aktar()
        //{
        //    System.Data.DataTable dt = Yazdir.Excel_Yazdir();
        //    dtlListele.DataSource = dt;
        //}

        private void Birim_Listele()
        {
            System.Data.DataTable dt = Birim.Birim_Listele();
            drpBirim.ValueMember = "BirimId";
            drpBirim.DisplayMember = "BirimAdi";
            drpBirim.DataSource = dt;
        }

        private void Marka_Listele()
        {
            System.Data.DataTable dt = Marka.Marka_Listele();
            drpMarka.ValueMember = "MarkaId";
            drpMarka.DisplayMember = "MarkaAdi";
            drpMarka.DataSource = dt;
        }

        private void Tur_Listele()
        {
            System.Data.DataTable dt = Tur.Tur_Listele();
            drpUrunTur.ValueMember = "TurId";
            drpUrunTur.DisplayMember = "TurAdi";
            drpUrunTur.DataSource = dt;
        }



        private void Firma_Listele()
        {
            System.Data.DataTable dt = Firma.Firma_Listele();
            drpFirma.ValueMember = "FirmaId";
            drpFirma.DisplayMember = "FirmaAdi";
            drpFirma.DataSource = dt;
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Firmalar frm = new Firmalar();
            frm.Show();
            this.Hide();
        }

        private void türToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunTur frm = new UrunTur();
            frm.Show();
            this.Hide();
        }

        private void ürünKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Urunler frm = new Urunler();
            frm.Show();
            this.Hide();
        }

        private void drpUrunTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Urun =new Urun(new Tur(Convert.ToInt32(drpUrunTur.SelectedValue)));
            System.Data.DataTable dt = Urun.UrunTur_Listele(Convert.ToInt32(drpUrunTur.SelectedValue));
            drpUrun.ValueMember = "UrunId";
            drpUrun.DisplayMember = "UrunAdi";
            drpUrun.DataSource = dt;

        }

        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Markalar frm = new Markalar();
            frm.Show();
            this.Hide();
        }

        private void birimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Birimler frm = new Birimler();
            frm.Show();
            this.Hide();
        }

        private void drpUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dt = AltUrun.Urun_Listele(Convert.ToInt32(drpUrun.SelectedValue));
            drpAltUrun.ValueMember = "AltUrunId";
            drpAltUrun.DisplayMember = "AltUrunAdi";
            drpAltUrun.DataSource = dt;
        }

        private void altÜrünKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltUrunler frm = new AltUrunler();
            frm.Show();
            this.Hide();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            txtindirimFiyat.Text = null;

            if (txtAdet.Text != "" && drpFiyat.Text != "")
            {
                Sonuc = Convert.ToDouble(txtAdet.Text) * Convert.ToDouble(drpFiyat.Text);
                txtToplamFiyat.Text = Sonuc.ToString();
                lblAdetBirim.Text = txtAdet.Text + drpBirim.Text;
                

                if (txtAdet.Text != "" && drpFiyat.Text != "" && txtindirim1.Text != "" && txtindirim2.Text != "" && txtindirim3.Text != "")
                {
                    indirimTopla = Convert.ToDouble(txtindirim1.Text) + Convert.ToDouble(txtindirim2.Text) + Convert.ToDouble(txtindirim3.Text);
                    indirim = (Sonuc * indirimTopla) / 100;
                    Sonuc = Convert.ToDouble(txtToplamFiyat.Text) - indirim;
                    txtindirimFiyat.Text = indirim.ToString();
                    txtToplamFiyat.Text = Sonuc.ToString();
                    lblAdetBirim.Text = txtAdet.Text + drpBirim.Text;
                }

                else if (txtAdet.Text != "" && drpFiyat.Text != "" && txtindirim1.Text != "" && txtindirim2.Text != "")
                {
                    indirimTopla = Convert.ToDouble(txtindirim1.Text) + Convert.ToDouble(txtindirim2.Text);
                    indirim = (Sonuc * indirimTopla) / 100;
                    Sonuc = Convert.ToDouble(txtToplamFiyat.Text) - indirim;
                    txtindirimFiyat.Text = indirim.ToString();
                    txtToplamFiyat.Text = Sonuc.ToString();
                    lblAdetBirim.Text = txtAdet.Text + drpBirim.Text;
                }

                else if (txtAdet.Text != "" && drpFiyat.Text != "" && txtindirim1.Text != "")
                {
                    indirim = (Sonuc * Convert.ToDouble(txtindirim1.Text)) / 100;
                    Sonuc = (Convert.ToDouble(txtToplamFiyat.Text)) - indirim;
                    txtToplamFiyat.Text = Sonuc.ToString();
                    txtindirimFiyat.Text = indirim.ToString();
                    lblAdetBirim.Text = txtAdet.Text + drpBirim.Text;
                }


            }


        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dtlListele.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dtlListele.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dtlListele.Rows.Count; i++)
            {
                for (int j = 0; j < dtlListele.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dtlListele[j, i].Value == null ? "" : dtlListele[j, i].Value;
                    myRange.Select();


                }
            }
        }

        private void aLtUrunFiyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltUrunFiyatlar frm = new AltUrunFiyatlar();
            frm.Show();
            this.Hide();
        }

        private void drpAltUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dt = AltUrunFiyat.AltUrun_Listele(Convert.ToInt32(drpAltUrun.SelectedValue));
            drpFiyat.ValueMember = "AltUrunFiyatId";
            drpFiyat.DisplayMember = "AltUrunFiyat";
            drpFiyat.DataSource = dt;
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtToplamFiyat.Text != "" && txtAdet.Text != "")
            {
                Teklif = new Teklif(
                new Firma(Convert.ToInt32(drpFirma.SelectedValue)),
                 new Marka(Convert.ToInt32(drpMarka.SelectedValue)),
                  new Tur(Convert.ToInt32(drpUrunTur.SelectedValue)),
                   new Urun(Convert.ToInt32(drpUrun.SelectedValue)),
                    new AltUrun(Convert.ToInt32(drpAltUrun.SelectedValue)),
                     txtAdet.Text,
                     Convert.ToInt32(txtindirim1.Text),
                     Convert.ToInt32(txtindirim2.Text),
                     Convert.ToInt32(txtindirim3.Text),
                     Convert.ToInt32(txtindirimFiyat.Text),
                     new AltUrunFiyat(Convert.ToInt32(drpFiyat.SelectedValue)),
                     Convert.ToDouble(txtToplamFiyat.Text),
                     new Birim(Convert.ToInt32(drpBirim.SelectedValue)),
                     DateTime.Now  );

                Teklif.Teklif_Ekle();
                Tekliff_Listele();


                Yazdir = new Yazdir(
                new Firma(Convert.ToInt32(drpFirma.SelectedValue)),
                 new Marka(Convert.ToInt32(drpMarka.SelectedValue)),
                  new Tur(Convert.ToInt32(drpUrunTur.SelectedValue)),
                   new Urun(Convert.ToInt32(drpUrun.SelectedValue)),
                    new AltUrun(Convert.ToInt32(drpAltUrun.SelectedValue)),
                     lblAdetBirim.Text,
                     new AltUrunFiyat(Convert.ToInt32(drpFiyat.SelectedValue)),
                     Convert.ToDouble(txtToplamFiyat.Text));

                Yazdir.Yazdir_Ekle();
                Yazdirr_Listele();

                txt_temizle();
            }
            else
            {
                MessageBox.Show("Hesaplama işlemi yapılmadan Kayıt işlemi Yapılamaz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (txtId.Text != "")
                {
                    Teklif = new Teklif(Convert.ToInt32(txtId.Text));
                    Teklif.Teklif_Sil();
                    Tekliff_Listele();
                    txt_temizle();
                    MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Seçili Öğe Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Teklif = new Teklif(
                Convert.ToInt32(txtId.Text),
                new Firma(Convert.ToInt32(drpFirma.SelectedValue)),
                 new Marka(Convert.ToInt32(drpMarka.SelectedValue)),
                  new Tur(Convert.ToInt32(drpUrunTur.SelectedValue)),
                   new Urun(Convert.ToInt32(drpUrun.SelectedValue)),
                    new AltUrun(Convert.ToInt32(drpAltUrun.SelectedValue)),
                     txtAdet.Text,
                     Convert.ToInt32(txtindirim1.Text),
                     Convert.ToInt32(txtindirim2.Text),
                     Convert.ToInt32(txtindirim3.Text),
                     Convert.ToInt32(txtindirimFiyat.Text),
                     new AltUrunFiyat(Convert.ToInt32(drpFiyat.SelectedValue)),
                     Convert.ToDouble(txtToplamFiyat.Text),
                     new Birim(Convert.ToInt32(drpBirim.SelectedValue)),
                     DateTime.Now
                );


            Teklif.Teklif_Guncelle();
            Tekliff_Listele();

            Yazdir = new Yazdir(
            new Firma(Convert.ToInt32(drpFirma.SelectedValue)),
             new Marka(Convert.ToInt32(drpMarka.SelectedValue)),
              new Tur(Convert.ToInt32(drpUrunTur.SelectedValue)),
               new Urun(Convert.ToInt32(drpUrun.SelectedValue)),
                new AltUrun(Convert.ToInt32(drpAltUrun.SelectedValue)),
                 lblAdetBirim.Text,
                 new AltUrunFiyat(Convert.ToInt32(drpFiyat.SelectedValue)),
                 Convert.ToDouble(txtToplamFiyat.Text));

            Yazdir.Yazdir_Ekle();
            Yazdirr_Listele();



            txt_temizle();
            MessageBox.Show("Güncelleme işlemi Başarılı");
        }

        private void dtlListeleFull_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtlListeleFull.CurrentRow.Cells[0].Value.ToString();
            drpFirma.Text = dtlListeleFull.CurrentRow.Cells[1].Value.ToString();
            drpMarka.Text = dtlListeleFull.CurrentRow.Cells[2].Value.ToString();
            drpUrunTur.Text = dtlListeleFull.CurrentRow.Cells[3].Value.ToString();
            drpUrun.Text = dtlListeleFull.CurrentRow.Cells[4].Value.ToString();
            drpAltUrun.Text = dtlListeleFull.CurrentRow.Cells[5].Value.ToString();
            txtAdet.Text = dtlListeleFull.CurrentRow.Cells[6].Value.ToString();
            txtindirim1.Text = dtlListeleFull.CurrentRow.Cells[7].Value.ToString();
            txtindirim2.Text = dtlListeleFull.CurrentRow.Cells[8].Value.ToString();
            txtindirim3.Text = dtlListeleFull.CurrentRow.Cells[9].Value.ToString();
            txtindirimFiyat.Text = dtlListeleFull.CurrentRow.Cells[10].Value.ToString();
            drpFiyat.Text = dtlListeleFull.CurrentRow.Cells[11].Value.ToString();
            txtToplamFiyat.Text = dtlListeleFull.CurrentRow.Cells[12].Value.ToString();
            drpBirim.Text = dtlListeleFull.CurrentRow.Cells[13].Value.ToString();
            
        }

        private void btnExcelSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (txtexcelId.Text != "")
                {
                    Yazdir = new Yazdir(Convert.ToInt32(txtexcelId.Text));
                    Yazdir.Yazdir_Sil();
                    Yazdirr_Listele();
                    txt_temizle();
                    MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Seçili Öğe Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dtlListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtexcelId.Text = dtlListele.CurrentRow.Cells[0].Value.ToString();

        }
   
    
    }

}