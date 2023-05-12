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
    public partial class Urunler : Form
    {
        Tur Tur = new Tur();
        Urun Urun = new Urun();

        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            Tur_Listele();
            Urun_Listele();
            txt_Temizle();
        }

        private void txt_Temizle()
        {
            txtId.Text = "";
            txtUrunAdi.Text = "";

        }

        private void Tur_Listele()
        {
            DataTable dt = Tur.Tur_Listele();
            drpUrunTur.ValueMember = "TurId";
            drpUrunTur.DisplayMember = "TurAdi";
            drpUrunTur.DataSource = dt;
        }

        private void Urun_Listele()
        {
            DataTable dt = Urun.Urun_Listele();
            dtlUrunListele.DataSource = dt;

        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text != "")
            {
                Urun = new Urun(
                    new Tur(Convert.ToInt32(drpUrunTur.SelectedValue)),
                    txtUrunAdi.Text);
                Urun.Urun_Ekle();
                Urun_Listele();
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
                    Urun = new Urun(Convert.ToInt32(txtId.Text));
                    Urun.Urun_Sil();
                    Urun_Listele();
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
            Urun = new Urun(Convert.ToInt32(txtId.Text),new Tur(Convert.ToInt32(drpUrunTur.SelectedValue)), txtUrunAdi.Text);
            Urun.Urun_Guncelle();
            Urun_Listele();
            txt_Temizle();
            MessageBox.Show("Güncelleme işlemi Başarılı");
        }

        private void dtlUrunListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtlUrunListele.CurrentRow.Cells[0].Value.ToString();
            drpUrunTur.Text = dtlUrunListele.CurrentRow.Cells[1].Value.ToString();
            txtUrunAdi.Text = dtlUrunListele.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

    }
}
