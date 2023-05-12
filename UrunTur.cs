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
    public partial class UrunTur : Form
    {
        Tur Tur = new Tur();

        public UrunTur()
        {
            InitializeComponent();
        }

        private void UrunTur_Load(object sender, EventArgs e)
        {

            txt_Temizle();
            Tur_Listele();
        }

        private void Tur_Listele()
        {
            DataTable dt = Tur.Tur_Listele();
            dtlTurListele.DataSource = dt;
        }


        private void txt_Temizle()
        {
            txtId.Text = "";
            txtTurAdi.Text = "";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTurAdi.Text != "")
            {
                Tur = new Tur(txtTurAdi.Text);
                Tur.Tur_Ekle();
                Tur_Listele();
                MessageBox.Show("Kayıt işlemi Başarılı");
                txt_Temizle();
            }
            else
            {
                MessageBox.Show(" * Olan Yerleri Doldurunuz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ? Bu Verinin Altındaki Tüm Bigiler Silinecektir", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Tur = new Tur(Convert.ToInt32(txtId.Text));
                Tur.Tur_Sil();
                Tur_Listele();
                txt_Temizle();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Tur = new Tur(Convert.ToInt32(txtId.Text),txtTurAdi.Text);
            Tur.Tur_Guncelle();
            Tur_Listele();
            txt_Temizle();
            MessageBox.Show("Güncelleme işlemi Başarılı");
        }

        private void dtlTurListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtlTurListele.CurrentRow.Cells[0].Value.ToString();
            txtTurAdi.Text = dtlTurListele.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }





    }
}
