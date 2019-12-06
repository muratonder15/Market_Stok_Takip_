namespace Market_Stok_Takip_MRT
{
    partial class UrunGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunGiris));
            this.btnBarkodVer = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUrunGrubuEkle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtKdvOrani = new System.Windows.Forms.TextBox();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEskiStok = new System.Windows.Forms.TextBox();
            this.txtYeniStok = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbToptanci = new System.Windows.Forms.ComboBox();
            this.cmbOdemeTurleri = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbOlcuBirimi = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBarkodVer
            // 
            this.btnBarkodVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarkodVer.ImageKey = "Button-Refresh-icon.png";
            this.btnBarkodVer.ImageList = this.ımageList1;
            this.btnBarkodVer.Location = new System.Drawing.Point(346, 45);
            this.btnBarkodVer.Name = "btnBarkodVer";
            this.btnBarkodVer.Size = new System.Drawing.Size(145, 43);
            this.btnBarkodVer.TabIndex = 0;
            this.btnBarkodVer.Text = "Otomatik Barkod No Ver";
            this.btnBarkodVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBarkodVer.UseVisualStyleBackColor = true;
            this.btnBarkodVer.Click += new System.EventHandler(this.btnBarkodVer_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Button-Ok-icon.png");
            this.ımageList1.Images.SetKeyName(1, "Button-Delete-icon.png");
            this.ımageList1.Images.SetKeyName(2, "Button-Add-icon.png");
            this.ımageList1.Images.SetKeyName(3, "Button-Refresh-icon.png");
            // 
            // btnUrunGrubuEkle
            // 
            this.btnUrunGrubuEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunGrubuEkle.ImageKey = "Button-Add-icon.png";
            this.btnUrunGrubuEkle.ImageList = this.ımageList1;
            this.btnUrunGrubuEkle.Location = new System.Drawing.Point(346, 114);
            this.btnUrunGrubuEkle.Name = "btnUrunGrubuEkle";
            this.btnUrunGrubuEkle.Size = new System.Drawing.Size(145, 42);
            this.btnUrunGrubuEkle.TabIndex = 1;
            this.btnUrunGrubuEkle.Text = "Yeni Ürün Grubu Ekle";
            this.btnUrunGrubuEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunGrubuEkle.UseVisualStyleBackColor = true;
            this.btnUrunGrubuEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.ImageKey = "Button-Ok-icon.png";
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(32, 451);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 43);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barkod No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürün Grubu Seç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alış Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(44, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Satış Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(44, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "KDV Oranı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(45, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ölçü Birimi:";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(178, 42);
            this.txtBarkodNo.Multiline = true;
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(150, 30);
            this.txtBarkodNo.TabIndex = 11;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            this.txtBarkodNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkodNo_KeyDown);
            this.txtBarkodNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkodNo_KeyPress);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(178, 78);
            this.txtUrunAdi.Multiline = true;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(150, 30);
            this.txtUrunAdi.TabIndex = 12;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(178, 152);
            this.txtAlisFiyati.Multiline = true;
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(150, 30);
            this.txtAlisFiyati.TabIndex = 13;
            this.txtAlisFiyati.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtAlisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlisFiyati_KeyPress);
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(178, 188);
            this.txtSatisFiyati.Multiline = true;
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(150, 30);
            this.txtSatisFiyati.TabIndex = 14;
            this.txtSatisFiyati.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisFiyati_KeyPress);
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.Location = new System.Drawing.Point(178, 224);
            this.txtKdvOrani.Multiline = true;
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Size = new System.Drawing.Size(150, 30);
            this.txtKdvOrani.TabIndex = 15;
            this.txtKdvOrani.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKdvOrani_KeyPress);
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(178, 114);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(150, 21);
            this.cmbUrunGrubu.TabIndex = 18;
            // 
            // btnVazgec
            // 
            this.btnVazgec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVazgec.ImageKey = "Button-Delete-icon.png";
            this.btnVazgec.ImageList = this.ımageList1;
            this.btnVazgec.Location = new System.Drawing.Point(133, 451);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(85, 43);
            this.btnVazgec.TabIndex = 19;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVazgec.UseVisualStyleBackColor = true;
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(179, 264);
            this.txtStokMiktari.Multiline = true;
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(149, 30);
            this.txtStokMiktari.TabIndex = 21;
            this.txtStokMiktari.Text = "0";
            this.txtStokMiktari.TextChanged += new System.EventHandler(this.txtStokMiktari_TextChanged);
            this.txtStokMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStokMiktari_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(45, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mevcut Stok Miktarı";
            // 
            // txtEskiStok
            // 
            this.txtEskiStok.Location = new System.Drawing.Point(362, 265);
            this.txtEskiStok.Multiline = true;
            this.txtEskiStok.Name = "txtEskiStok";
            this.txtEskiStok.Size = new System.Drawing.Size(52, 29);
            this.txtEskiStok.TabIndex = 22;
            // 
            // txtYeniStok
            // 
            this.txtYeniStok.Location = new System.Drawing.Point(439, 265);
            this.txtYeniStok.Multiline = true;
            this.txtYeniStok.Name = "txtYeniStok";
            this.txtYeniStok.Size = new System.Drawing.Size(52, 29);
            this.txtYeniStok.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(359, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Eski Stok";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(431, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Yeni Stok";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(340, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "+";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(420, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "=";
            // 
            // cmbToptanci
            // 
            this.cmbToptanci.FormattingEnabled = true;
            this.cmbToptanci.Location = new System.Drawing.Point(179, 354);
            this.cmbToptanci.Name = "cmbToptanci";
            this.cmbToptanci.Size = new System.Drawing.Size(150, 21);
            this.cmbToptanci.TabIndex = 28;
            // 
            // cmbOdemeTurleri
            // 
            this.cmbOdemeTurleri.FormattingEnabled = true;
            this.cmbOdemeTurleri.Location = new System.Drawing.Point(179, 396);
            this.cmbOdemeTurleri.Name = "cmbOdemeTurleri";
            this.cmbOdemeTurleri.Size = new System.Drawing.Size(150, 21);
            this.cmbOdemeTurleri.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(45, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Toptancı Adı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(45, 397);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Ödeme Şekli";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "Button-Add-icon.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(343, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 32;
            this.button1.Text = "Yeni Toptancı Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbOlcuBirimi
            // 
            this.cmbOlcuBirimi.FormattingEnabled = true;
            this.cmbOlcuBirimi.Location = new System.Drawing.Point(178, 311);
            this.cmbOlcuBirimi.Name = "cmbOlcuBirimi";
            this.cmbOlcuBirimi.Size = new System.Drawing.Size(150, 21);
            this.cmbOlcuBirimi.TabIndex = 33;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageKey = "Button-Ok-icon.png";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(32, 451);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 43);
            this.btnGuncelle.TabIndex = 34;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // UrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 533);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbOlcuBirimi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbOdemeTurleri);
            this.Controls.Add(this.cmbToptanci);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYeniStok);
            this.Controls.Add(this.txtEskiStok);
            this.Controls.Add(this.txtStokMiktari);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.cmbUrunGrubu);
            this.Controls.Add(this.txtKdvOrani);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnUrunGrubuEkle);
            this.Controls.Add(this.btnBarkodVer);
            this.Name = "UrunGiris";
            this.Text = "ÜRÜN GİRİŞİ";
            this.Load += new System.EventHandler(this.UrunGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBarkodVer;
        private System.Windows.Forms.Button btnUrunGrubuEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtKdvOrani;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbToptanci;
        private System.Windows.Forms.ComboBox cmbOdemeTurleri;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbOlcuBirimi;
        public System.Windows.Forms.TextBox txtEskiStok;
        public System.Windows.Forms.TextBox txtYeniStok;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnGuncelle;
    }
}

