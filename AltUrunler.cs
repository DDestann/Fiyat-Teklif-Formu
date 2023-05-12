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
    public partial class AltUrunler : Form
    {
        AltUrun AltUrun = new AltUrun();
        Urun Urun = new Urun();

        public AltUrunler()
        {
            InitializeComponent();
        }

        private void AltUrunler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veriDataSet.tblAltUrun' table. You can move, or remove it, as needed.
    

            Urun_Listele();
            AltUrun_Listele();
            txt_Temizle();
        }

        private void AltUrun_Listele()
        {
            DataTable dt = AltUrun.AltUrun_Listele();
            dtlAltUrunListele.DataSource = dt;
        }

        private void txt_Temizle()
        {
            txtId.Text = "";
            txtAltUrunAdi.Text = "";

        }

        private void Urun_Listele()
        {
            DataTable dt = Urun.Urun_Listele();
            drpUrun.ValueMember = "UrunId";
            drpUrun.DisplayMember = "UrunAdi";
            drpUrun.DataSource = dt;
        }

       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAltUrunAdi.Text != "")
            {
                AltUrun = new AltUrun(
                    new Urun(Convert.ToInt32(drpUrun.SelectedValue)),
                    txtAltUrunAdi.Text);
                AltUrun.AltUrun_Ekle();
                AltUrun_Listele();
                txt_Temizle();
              
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
                    AltUrun = new AltUrun(Convert.ToInt32(txtId.Text));
                    AltUrun.AltUrun_Sil();
                    AltUrun_Listele();
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

            AltUrun = new AltUrun(Convert.ToInt32(txtId.Text), new Urun(Convert.ToInt32(drpUrun.SelectedValue)), txtAltUrunAdi.Text);
            AltUrun.AltUrun_Guncelle();
            AltUrun_Listele();
            txt_Temizle();
          
            MessageBox.Show("Güncelleme işlemi Başarılı");
        }

       

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void dtlAltUrunListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = dtlAltUrunListele.CurrentRow.Cells[0].Value.ToString();
            txtAltUrunAdi.Text = dtlAltUrunListele.CurrentRow.Cells[1].Value.ToString();
            drpUrun.Text = dtlAltUrunListele.CurrentRow.Cells[2].Value.ToString();
           
        }

       

      






    }
}
