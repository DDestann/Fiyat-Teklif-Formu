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
    public partial class Form2 : Form
    {

        double Sonuc;
        double indirim;
        double indirimTopla;


        public Form2()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            txtindirimFiyat.Text = null;

            if (txtAdet.Text != "" && txtBirimFiyat.Text != "")
            {
                Sonuc = Convert.ToDouble(txtAdet.Text) * Convert.ToDouble(txtBirimFiyat.Text);
                txtToplamFiyat.Text = Sonuc.ToString();

                if (txtAdet.Text != "" && txtBirimFiyat.Text != "" && txtindirim1.Text != "" && txtindirim2.Text != "" && txtindirim3.Text != "")
                {
                    indirimTopla = Convert.ToDouble(txtindirim1.Text) + Convert.ToDouble(txtindirim2.Text) + Convert.ToDouble(txtindirim3.Text);
                    indirim = (Sonuc * indirimTopla) / 100;
                    Sonuc = Convert.ToDouble(txtToplamFiyat.Text) - indirim;
                    txtindirimFiyat.Text = indirim.ToString();
                    txtToplamFiyat.Text = Sonuc.ToString();
                    lblGenelToplam.Text = indirimTopla.ToString();
                }

                else if (txtAdet.Text != "" && txtBirimFiyat.Text != "" && txtindirim1.Text != "" && txtindirim2.Text != "")
                {
                    indirimTopla = Convert.ToDouble(txtindirim1.Text) + Convert.ToDouble(txtindirim2.Text);
                    indirim = (Sonuc * indirimTopla) / 100;
                    Sonuc = Convert.ToDouble(txtToplamFiyat.Text) - indirim;
                    txtindirimFiyat.Text = indirim.ToString();
                    txtToplamFiyat.Text = Sonuc.ToString();
                    lblGenelToplam.Text = indirimTopla.ToString();
                }

                else if (txtAdet.Text != "" && txtBirimFiyat.Text != "" && txtindirim1.Text != "")
                {
                    indirim = (Sonuc * Convert.ToDouble(txtindirim1.Text)) / 100;
                    Sonuc = (Convert.ToDouble(txtToplamFiyat.Text)) - indirim;
                    txtToplamFiyat.Text = Sonuc.ToString();
                    txtindirimFiyat.Text = indirim.ToString();
                }


            }


        }
    }
}
