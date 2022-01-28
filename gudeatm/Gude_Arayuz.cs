using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gudeatm
{
    public partial class Gude_Arayuz : Form
    {
        public Gude_Arayuz()
        {
            InitializeComponent();
        }
        public void paraYatirma()
        {
            KullaniciKayit.bakiye[KullaniciKayit.i] += Convert.ToInt32(txtMiktar);
        }
        public void paraCekme()
        {

            KullaniciKayit.bakiye[KullaniciKayit.i] -= Convert.ToInt32(txtMiktar);
        }
        private void Gude_Arayuz_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = KullaniciKayit.name[KullaniciKayit.i] + KullaniciKayit.surname[KullaniciKayit.i];
        }

        private void btnParaCekme_Click(object sender, EventArgs e)
        {
            lblMiktar.Visible = true;
            txtMiktar.Visible = true;
            btnOnay.Visible = true;
            txtHavaleKullanici.Visible = false;
            lblEftKullanici.Visible = false;
            btnHavaleOnay.Visible = false;
            btnOnayparaYatirma.Visible = false;
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {  
            paraCekme();
        }

        private void btnOnayparaYatirma_Click(object sender, EventArgs e)
        {
            paraYatirma();
        }

        private void btnParaYatirma_Click(object sender, EventArgs e)
        {
            lblMiktar.Visible = true;
            txtMiktar.Visible = true;
            btnOnayparaYatirma.Visible = true;
            txtHavaleKullanici.Visible = false;
            lblEftKullanici.Visible = false;
            btnHavaleOnay.Visible = false;
            btnOnay.Visible = false;

        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            lblMiktar.Visible = true;
            txtMiktar.Visible = true;
            txtHavaleKullanici.Visible = true;
            lblEftKullanici.Visible = true;
            btnHavaleOnay.Visible = true;
            btnOnay.Visible = false;
            btnOnayparaYatirma.Visible = false;
            
           
        }

        private void btnBakiye_Click(object sender, EventArgs e)
            
        {
            MessageBox.Show($"{KullaniciKayit.name[atmgiris.i].ToString()}  {KullaniciKayit.surname[atmgiris.i]} \n {KullaniciKayit.cinsiyet[atmgiris.i]} \n {KullaniciKayit.birthdate[atmgiris.i]} \n {KullaniciKayit.userName[atmgiris.i]} \n Bakiyeniz: {KullaniciKayit.bakiye[atmgiris.i]} ");
        }

        private void btnHavaleOnay_Click(object sender, EventArgs e)
        {
            for (int z = 0; z < KullaniciKayit.i; z++)
            {
                if (txtHavaleKullanici.Text == KullaniciKayit.userName[z])
                {
                    KullaniciKayit.bakiye[z] += Convert.ToInt32(txtMiktar.Text);
                    KullaniciKayit.bakiye[atmgiris.i] -= Convert.ToInt32(txtMiktar.Text);
                    //MessageBox.Show(KullaniciKayit.userName[z] + KullaniciKayit.bakiye[z]+ KullaniciKayit.userName[atmgiris.i] + KullaniciKayit.bakiye[atmgiris.i]);
                    MessageBox.Show("Havale başarıyla gerçekleşti Göderilen hesap bilgileri \n "+ KullaniciKayit.name[z]+"\n"+KullaniciKayit.surname[z]+"\n"+KullaniciKayit.tc[z]+"\n"+ KullaniciKayit.birthdate[z]);

                }
               
            }
        
        }
    }
}
