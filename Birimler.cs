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
    public partial class Birimler : Form
    {
        Birim Birim = new Birim();
        public Birimler()
        {
            InitializeComponent();
        }

        private void Birimler_Load(object sender, EventArgs e)
        {

            txt_Temizle();
            Birim_Listele();
        }

        private void Birim_Listele()
        {
            DataTable dt = Birim.Birim_Listele();
            dtlBirimListele.DataSource = dt;
        }


        private void txt_Temizle()
        {
            txtId.Text = "";
            txtBirimAdi.Text = "";

        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBirimAdi.Text != "")
            {
                Birim = new Birim(txtBirimAdi.Text);
                Birim.Birim_Ekle();
                Birim_Listele();
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

                Birim = new Birim(Convert.ToInt32(txtId.Text));
                Birim.Birim_Sil();
                Birim_Listele();
                txt_Temizle();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Birim = new Birim(Convert.ToInt32(txtId.Text), txtBirimAdi.Text);
            Birim.Birim_Guncelle();
            Birim_Listele();
            txt_Temizle();
            MessageBox.Show("Güncelleme işlemi Başarılı");
        }

        private void dtlBirimListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtlBirimListele.CurrentRow.Cells[0].Value.ToString();
            txtBirimAdi.Text = dtlBirimListele.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        
    }
}
