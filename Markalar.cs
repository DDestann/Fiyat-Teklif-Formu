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
    public partial class Markalar : Form
    {
        Marka Marka = new Marka();

        public Markalar()
        {
            InitializeComponent();
        }

        private void Markalar_Load(object sender, EventArgs e)
        {

            txt_Temizle();
            Marka_Listele();
        }

        private void Marka_Listele()
        {
            DataTable dt = Marka.Marka_Listele();
            dtlMarkaListele.DataSource = dt;
        }


        private void txt_Temizle()
        {
            txtId.Text = "";
            txtMarkaAdi.Text = "";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMarkaAdi.Text != "")
            {
                Marka = new Marka(txtMarkaAdi.Text);
                Marka.Marka_Ekle();
                Marka_Listele();
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

                Marka = new Marka(Convert.ToInt32(txtId.Text));
                Marka.Marka_Sil();
                Marka_Listele();
                txt_Temizle();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Marka = new Marka(Convert.ToInt32(txtId.Text), txtMarkaAdi.Text);
            Marka.Marka_Guncelle();
            Marka_Listele();
            txt_Temizle();
            MessageBox.Show("Güncelleme işlemi Başarılı");
        }

        private void dtlMarkaListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtlMarkaListele.CurrentRow.Cells[0].Value.ToString();
            txtMarkaAdi.Text = dtlMarkaListele.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }






    }
}
