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
    public partial class atmgiris : Form
    {
        public atmgiris()
        {
            InitializeComponent();
        }
        //bool x = false;
        bool result = false;
        public static int i=0;
        public void giris()
        {
            #region Diziler ile Giriş Döngüsü
            //for (i = 0; i < KullaniciKayit.i; i++)
            //{
            //    if (KullaniciKayit.userName[i].ToString() == txtGirisUsername.Text && KullaniciKayit.sifre[i].ToString() == txtGirisSifre.Text)
            //    {
            //         x = true;
            //        MessageBox.Show("başarılı");
            //        Gude_Arayuz f3 = new Gude_Arayuz();
            //        f3.ShowDialog();
            //       atmgiris f2 = new atmgiris();
            //        f2.Close();
            //        break;


            //    }
            //    else
            //    {
            //        x = false;
            //    }


            //}


            //if (x == false)
            //{
            //    MessageBox.Show("Hatalı giriş");
            //}
            #endregion

           
            for (int i = 0; i < KullaniciKayit.userName.Count; i++)
            {
                if (KullaniciKayit.userName[i] == txtGirisUsername.Text && KullaniciKayit.sifre[i] == txtGirisSifre.Text)
                {
                    result = true;
                    MessageBox.Show("başarılı");
                    Gude_Arayuz f3 = new Gude_Arayuz();
                    f3.ShowDialog();
                    atmgiris f2 = new atmgiris();
                    f2.Close();
                    break;
                }
                    else 
                {
                    result = false;
                }
              
            }
            if (result == false)
            {
                MessageBox.Show("Hatalı Giriş");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            giris();   
        }
    }
}
