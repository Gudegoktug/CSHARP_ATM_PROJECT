namespace gudeatm
{
    partial class Gude_Arayuz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParaCekme = new System.Windows.Forms.Button();
            this.btnParaYatirma = new System.Windows.Forms.Button();
            this.btnHavale = new System.Windows.Forms.Button();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.txtHavaleKullanici = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnOnay = new System.Windows.Forms.Button();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblEftKullanici = new System.Windows.Forms.Label();
            this.btnOnayparaYatirma = new System.Windows.Forms.Button();
            this.btnHavaleOnay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUDE BANKA HOŞGELDİNİZ";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(300, 37);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(92, 16);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "isim soyisim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yapmak istenilen işlemi seçiniz";
            // 
            // btnParaCekme
            // 
            this.btnParaCekme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCekme.Location = new System.Drawing.Point(15, 145);
            this.btnParaCekme.Name = "btnParaCekme";
            this.btnParaCekme.Size = new System.Drawing.Size(107, 57);
            this.btnParaCekme.TabIndex = 3;
            this.btnParaCekme.Text = "Para Çekme";
            this.btnParaCekme.UseVisualStyleBackColor = true;
            this.btnParaCekme.Click += new System.EventHandler(this.btnParaCekme_Click);
            // 
            // btnParaYatirma
            // 
            this.btnParaYatirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYatirma.Location = new System.Drawing.Point(128, 145);
            this.btnParaYatirma.Name = "btnParaYatirma";
            this.btnParaYatirma.Size = new System.Drawing.Size(107, 57);
            this.btnParaYatirma.TabIndex = 4;
            this.btnParaYatirma.Text = "Para Yatırma";
            this.btnParaYatirma.UseVisualStyleBackColor = true;
            this.btnParaYatirma.Click += new System.EventHandler(this.btnParaYatirma_Click);
            // 
            // btnHavale
            // 
            this.btnHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavale.Location = new System.Drawing.Point(15, 224);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(107, 57);
            this.btnHavale.TabIndex = 5;
            this.btnHavale.Text = "EFT/HAVALE";
            this.btnHavale.UseVisualStyleBackColor = true;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // btnBakiye
            // 
            this.btnBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakiye.Location = new System.Drawing.Point(128, 224);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(107, 57);
            this.btnBakiye.TabIndex = 6;
            this.btnBakiye.Text = "Bakiye Görüntüleme";
            this.btnBakiye.UseVisualStyleBackColor = true;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);
            // 
            // txtHavaleKullanici
            // 
            this.txtHavaleKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHavaleKullanici.Location = new System.Drawing.Point(288, 154);
            this.txtHavaleKullanici.Name = "txtHavaleKullanici";
            this.txtHavaleKullanici.Size = new System.Drawing.Size(169, 22);
            this.txtHavaleKullanici.TabIndex = 7;
            this.txtHavaleKullanici.Visible = false;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(288, 205);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(169, 22);
            this.txtMiktar.TabIndex = 8;
            this.txtMiktar.Visible = false;
            // 
            // btnOnay
            // 
            this.btnOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnay.Location = new System.Drawing.Point(368, 241);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(75, 23);
            this.btnOnay.TabIndex = 10;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Visible = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(285, 186);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(96, 16);
            this.lblMiktar.TabIndex = 11;
            this.lblMiktar.Text = "Miktar Giriniz";
            this.lblMiktar.Visible = false;
            // 
            // lblEftKullanici
            // 
            this.lblEftKullanici.AutoSize = true;
            this.lblEftKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEftKullanici.Location = new System.Drawing.Point(285, 138);
            this.lblEftKullanici.Name = "lblEftKullanici";
            this.lblEftKullanici.Size = new System.Drawing.Size(373, 16);
            this.lblEftKullanici.TabIndex = 12;
            this.lblEftKullanici.Text = "Havale/EFT yapılacak Hesabın KulllanıcıAdını Giriniz";
            this.lblEftKullanici.Visible = false;
            // 
            // btnOnayparaYatirma
            // 
            this.btnOnayparaYatirma.Location = new System.Drawing.Point(463, 241);
            this.btnOnayparaYatirma.Name = "btnOnayparaYatirma";
            this.btnOnayparaYatirma.Size = new System.Drawing.Size(75, 23);
            this.btnOnayparaYatirma.TabIndex = 13;
            this.btnOnayparaYatirma.Text = "Onay";
            this.btnOnayparaYatirma.UseVisualStyleBackColor = true;
            this.btnOnayparaYatirma.Visible = false;
            this.btnOnayparaYatirma.Click += new System.EventHandler(this.btnOnayparaYatirma_Click);
            // 
            // btnHavaleOnay
            // 
            this.btnHavaleOnay.Location = new System.Drawing.Point(272, 241);
            this.btnHavaleOnay.Name = "btnHavaleOnay";
            this.btnHavaleOnay.Size = new System.Drawing.Size(75, 23);
            this.btnHavaleOnay.TabIndex = 14;
            this.btnHavaleOnay.Text = "Onay";
            this.btnHavaleOnay.UseVisualStyleBackColor = true;
            this.btnHavaleOnay.Visible = false;
            this.btnHavaleOnay.Click += new System.EventHandler(this.btnHavaleOnay_Click);
            // 
            // Gude_Arayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.btnHavaleOnay);
            this.Controls.Add(this.btnOnayparaYatirma);
            this.Controls.Add(this.lblEftKullanici);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtHavaleKullanici);
            this.Controls.Add(this.btnBakiye);
            this.Controls.Add(this.btnHavale);
            this.Controls.Add(this.btnParaYatirma);
            this.Controls.Add(this.btnParaCekme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Gude_Arayuz";
            this.Text = "Gude_Arayuz";
            this.Load += new System.EventHandler(this.Gude_Arayuz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParaCekme;
        private System.Windows.Forms.Button btnParaYatirma;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.TextBox txtHavaleKullanici;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblEftKullanici;
        private System.Windows.Forms.Button btnOnayparaYatirma;
        private System.Windows.Forms.Button btnHavaleOnay;
    }
}