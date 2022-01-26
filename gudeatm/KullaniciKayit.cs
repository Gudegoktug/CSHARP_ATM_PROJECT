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
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }
       
        public static string[] name = new string[100];
        public static string[] surname = new string[100];
        public static string[] birthdate = new string[100];
        public static string[] tc = new string[100];
        public static string[] userName = new string[100];
        public static string[] sifre = new string[100];
        public static string[] cinsiyet = new string[100];  
        public static int[] bakiye = new int[100];
        public static int i = 0;
        public void kullaniciKayit()
        {
            //try
            //{
            //    if (i <= 0 && i > 100 && sifre[i] == sifreTekrar[i])
            //    {
            //        name[i] = txtName.Text;
            //        surname[i] = txtSurname.Text;
            //        birthdate[i] = mskBirthDate.Text;
            //        tc[i] = mskTc.Text;
            //        userName[i] = txtUsername.Text;
            //        sifre[i] = txtSifre.Text;
            //        sifreTekrar[i] = txtSifreTekrar.Text;
            //        MessageBox.Show("Başarılı");
            //    8    if (rdoErkek.Checked == true)
            //        {
            //            cinsiyet[i] = rdoErkek.ToString();
            //        }
            //        else
            //        {
            //            cinsiyet[i] = rdoKadin.ToString();
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Hata..!!");
            //}
          
           
            

        }
        public void saat()
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saat();
        }
       
        private void btnKayit_Click(object sender, EventArgs e)
        {
            //kullaniciKayit();
            try
            {
                if (i >= 0 && i < 100 )
                {
                    name[i] = txtName.Text;
                    surname[i] = txtSurname.Text;
                    birthdate[i] = mskBirthDate.Text;
                    tc[i] = mskTc.Text;
                    userName[i] = txtUsername.Text;
                    sifre[i] = txtSifre.Text;
                    bakiye[i] = 10000;
                   
               
                    if (rdoErkek.Checked == true)
                    {
                        cinsiyet[i] = "erkek";
                    }
                    else if(rdoKadin.Checked ==true)
                    {
                        cinsiyet[i] = "kadın";
                    }
                    else
                    {
                        cinsiyet[i] = "lpgli";
                    }
                   
                }
                MessageBox.Show("Başarılı kayıt");
                i++;
                
            }
            catch
            {
                MessageBox.Show("Hata..!!");
            }

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
          atmgiris f2 = new atmgiris();
            f2.ShowDialog();
            this.Hide();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat();
        }
    }
}
