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
    public partial class AltUrunFiyatlar : Form
    {
        AltUrun AltUrun = new AltUrun();
        AltUrunFiyat AltUrunFiyat = new AltUrunFiyat();


        public AltUrunFiyatlar()
        {
            InitializeComponent();
        }

        private void AltUrunFiyatlar_Load(object sender, EventArgs e)
        {
            txt_Temizle();
            AltUrun_Listele();
            Listele();
        }

        private void Listele()
        {
            DataTable dt = AltUrunFiyat.AltUrunFiyat_Listele();
            dtlAltUrunFiyatListele.DataSource = dt;
        }

        private void txt_Temizle()
        {
            txtId.Text = "";
            txtFiyat.Text = "";

        }

        private void AltUrun_Listele()
        {
            DataTable dt = AltUrun.AltUrun_Listele();
            drpAltUrun.ValueMember = "AltUrunId";
            drpAltUrun.DisplayMember = "AltUrunAdi";
            drpAltUrun.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtFiyat.Text != "")
            {
                AltUrunFiyat = new AltUrunFiyat(
                    new AltUrun(Convert.ToInt32(drpAltUrun.SelectedValue)),
                   Convert.ToDouble(txtFiyat.Text)
                    );
                AltUrunFiyat.AltUrunFiyat_Ekle();
                txt_Temizle();
                Listele();
                MessageBox.Show("Kayıt işlemi gerçekleşti");
            }
            else
            {
                MessageBox.Show("* olan kısımları Doldurun");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (txtId.Text != "")
                {
                    AltUrunFiyat = new AltUrunFiyat(Convert.ToInt32(txtId.Text));
                    AltUrunFiyat.AltUrunFiyat_Sil();
                    Listele();
                    txt_Temizle();
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
            AltUrunFiyat = new AltUrunFiyat(Convert.ToInt32(txtId.Text), new AltUrun(Convert.ToInt32(drpAltUrun.SelectedValue)), Convert.ToDouble(txtFiyat.Text));
            AltUrunFiyat.AltUrunFiyat_Guncelle();
            Listele();
            txt_Temizle();
            MessageBox.Show("Güncelleme işlemi Başarılı");
        }

        private void dtlAltUrunFiyatListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtlAltUrunFiyatListele.CurrentRow.Cells[0].Value.ToString();
            txtFiyat.Text = dtlAltUrunFiyatListele.CurrentRow.Cells[1].Value.ToString();
            drpAltUrun.Text = dtlAltUrunFiyatListele.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }


    }
}
