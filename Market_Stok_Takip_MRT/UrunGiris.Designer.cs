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
            this.txtOlcuBirimi = new System.Windows.Forms.TextBox();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.btnKaydet.Location = new System.Drawing.Point(37, 323);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 43);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
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
            this.label7.Location = new System.Drawing.Point(44, 261);
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
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(178, 188);
            this.txtSatisFiyati.Multiline = true;
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(150, 30);
            this.txtSatisFiyati.TabIndex = 14;
            this.txtSatisFiyati.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.Location = new System.Drawing.Point(178, 224);
            this.txtKdvOrani.Multiline = true;
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Size = new System.Drawing.Size(150, 30);
            this.txtKdvOrani.TabIndex = 15;
            // 
            // txtOlcuBirimi
            // 
            this.txtOlcuBirimi.Location = new System.Drawing.Point(178, 260);
            this.txtOlcuBirimi.Multiline = true;
            this.txtOlcuBirimi.Name = "txtOlcuBirimi";
            this.txtOlcuBirimi.Size = new System.Drawing.Size(150, 30);
            this.txtOlcuBirimi.TabIndex = 16;
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
            this.btnVazgec.Location = new System.Drawing.Point(138, 323);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(85, 43);
            this.btnVazgec.TabIndex = 19;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVazgec.UseVisualStyleBackColor = true;
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
            // UrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 533);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.cmbUrunGrubu);
            this.Controls.Add(this.txtOlcuBirimi);
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
        private System.Windows.Forms.TextBox txtOlcuBirimi;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

