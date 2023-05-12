using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeklifFormu
{
    public partial class Firmalar : Form
    {
        Firma Firma = new Firma();

        public Firmalar()
        {
            InitializeComponent();
        }


        private void Firmalar_Load(object sender, EventArgs e)
        {

            Firma_Listele();
            txt_Temizle();

        }

        private void txt_Temizle()
        {
            txtId.Text = "";
            txtFirmaAdi.Text = "";
            txtYetkili.Text = "";
            txtTel.Text = "";
            txtCep.Text = ""; ;
            txtAciklama.Text = "";
        }

        private void Firma_Listele()
        {
            DataTable dt = Firma.Firma_Listele();
            dtlFirmaListele.DataSource = dt;
        }




        private void btnEkle_Click(object sender, EventArgs e)
        {
            DataTable dt = Firma.Firma_Ekle_Kontrol(txtFirmaAdi.Text);

            if (dt.Rows.Count==0)
            {
                if (txtFirmaAdi.Text != "" && txtYetkili.Text != "" && txtTel.Text != "" || txtCep.Text != "")
                {
                    Firma = new Firma(txtFirmaAdi.Text, txtYetkili.Text, txtTel.Text, txtCep.Text, txtAciklama.Text, DateTime.Now);
                    Firma.Firma_Ekle();
                    Firma_Listele();
                    MessageBox.Show("Kayıt işlemi Başarılı");
                    txt_Temizle();
                }
                else
                {
                    MessageBox.Show(" * Olan Yerleri Doldurunuz");
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz Firma Adı Kullanılmaktadır Lütfen başka Firma Giriniz...");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Firma = new Firma(Convert.ToInt32(txtId.Text));
                Firma.Firma_Sil();
                Firma_Listele();
                txt_Temizle();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Firma = new Firma(Convert.ToInt32(txtId.Text), txtFirmaAdi.Text, txtYetkili.Text, txtTel.Text, txtCep.Text, txtAciklama.Text, DateTime.Now);
            Firma.Firma_Guncelle();
            Firma_Listele();
            txt_Temizle();
            MessageBox.Show("Güncelleme işlemi Başarılı");
        }

        private void dtlFirmaListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtlFirmaListele.CurrentRow.Cells[0].Value.ToString();
            txtFirmaAdi.Text = dtlFirmaListele.CurrentRow.Cells[1].Value.ToString();
            txtYetkili.Text = dtlFirmaListele.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dtlFirmaListele.CurrentRow.Cells[3].Value.ToString();
            txtCep.Text = dtlFirmaListele.CurrentRow.Cells[4].Value.ToString();
            txtAciklama.Text = dtlFirmaListele.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        
    }
}
