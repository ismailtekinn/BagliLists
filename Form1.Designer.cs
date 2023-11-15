
namespace VeriYapilari
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.urunEkleKod = new System.Windows.Forms.TextBox();
            this.urunEkleAd = new System.Windows.Forms.TextBox();
            this.urunEkleFiyat = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.urunSilmeFiyat = new System.Windows.Forms.TextBox();
            this.urunSilmeAd = new System.Windows.Forms.TextBox();
            this.urunSilmeKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.urunGuncelleFiyat = new System.Windows.Forms.TextBox();
            this.urunGuncelleAd = new System.Windows.Forms.TextBox();
            this.urunGuncelleKod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.urunSilmeBul = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hataMesaj = new System.Windows.Forms.Label();
            this.btnUrunleriListele = new System.Windows.Forms.Button();
            this.hataMesajSilme = new System.Windows.Forms.Label();
            this.urunGuncellemeHata = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urunEkleFiyat);
            this.groupBox1.Controls.Add(this.urunEkleAd);
            this.groupBox1.Controls.Add(this.urunEkleKod);
            this.groupBox1.Controls.Add(this.lblFiyat);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.lblKod);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekleme";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(26, 34);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(32, 13);
            this.lblKod.TabIndex = 0;
            this.lblKod.Text = "Kodu";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(29, 66);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(22, 13);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Adı";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(29, 118);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(29, 13);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Fiyat";
            // 
            // urunEkleKod
            // 
            this.urunEkleKod.Location = new System.Drawing.Point(85, 34);
            this.urunEkleKod.Name = "urunEkleKod";
            this.urunEkleKod.Size = new System.Drawing.Size(100, 20);
            this.urunEkleKod.TabIndex = 3;
            // 
            // urunEkleAd
            // 
            this.urunEkleAd.Location = new System.Drawing.Point(85, 66);
            this.urunEkleAd.Name = "urunEkleAd";
            this.urunEkleAd.Size = new System.Drawing.Size(100, 20);
            this.urunEkleAd.TabIndex = 4;
            // 
            // urunEkleFiyat
            // 
            this.urunEkleFiyat.Location = new System.Drawing.Point(85, 115);
            this.urunEkleFiyat.Name = "urunEkleFiyat";
            this.urunEkleFiyat.Size = new System.Drawing.Size(100, 20);
            this.urunEkleFiyat.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.urunSilmeBul);
            this.groupBox2.Controls.Add(this.urunSilmeFiyat);
            this.groupBox2.Controls.Add(this.urunSilmeAd);
            this.groupBox2.Controls.Add(this.urunSilmeKod);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(245, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Silme";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // urunSilmeFiyat
            // 
            this.urunSilmeFiyat.Location = new System.Drawing.Point(85, 115);
            this.urunSilmeFiyat.Name = "urunSilmeFiyat";
            this.urunSilmeFiyat.Size = new System.Drawing.Size(100, 20);
            this.urunSilmeFiyat.TabIndex = 5;
            // 
            // urunSilmeAd
            // 
            this.urunSilmeAd.Location = new System.Drawing.Point(85, 66);
            this.urunSilmeAd.Name = "urunSilmeAd";
            this.urunSilmeAd.Size = new System.Drawing.Size(100, 20);
            this.urunSilmeAd.TabIndex = 4;
            // 
            // urunSilmeKod
            // 
            this.urunSilmeKod.Location = new System.Drawing.Point(85, 34);
            this.urunSilmeKod.Name = "urunSilmeKod";
            this.urunSilmeKod.Size = new System.Drawing.Size(100, 20);
            this.urunSilmeKod.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kodu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.urunGuncelleFiyat);
            this.groupBox3.Controls.Add(this.urunGuncelleAd);
            this.groupBox3.Controls.Add(this.urunGuncelleKod);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(508, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 182);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Fiyat Güncellem";
            // 
            // urunGuncelleFiyat
            // 
            this.urunGuncelleFiyat.Location = new System.Drawing.Point(85, 115);
            this.urunGuncelleFiyat.Name = "urunGuncelleFiyat";
            this.urunGuncelleFiyat.Size = new System.Drawing.Size(100, 20);
            this.urunGuncelleFiyat.TabIndex = 5;
            // 
            // urunGuncelleAd
            // 
            this.urunGuncelleAd.Location = new System.Drawing.Point(85, 66);
            this.urunGuncelleAd.Name = "urunGuncelleAd";
            this.urunGuncelleAd.Size = new System.Drawing.Size(100, 20);
            this.urunGuncelleAd.TabIndex = 4;
            // 
            // urunGuncelleKod
            // 
            this.urunGuncelleKod.Location = new System.Drawing.Point(85, 34);
            this.urunGuncelleKod.Name = "urunGuncelleKod";
            this.urunGuncelleKod.Size = new System.Drawing.Size(100, 20);
            this.urunGuncelleKod.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kodu";
            // 
            // urunSilmeBul
            // 
            this.urunSilmeBul.Location = new System.Drawing.Point(192, 30);
            this.urunSilmeBul.Name = "urunSilmeBul";
            this.urunSilmeBul.Size = new System.Drawing.Size(43, 23);
            this.urunSilmeBul.TabIndex = 6;
            this.urunSilmeBul.Text = "Bul";
            this.urunSilmeBul.UseVisualStyleBackColor = true;
            this.urunSilmeBul.Click += new System.EventHandler(this.urunSilmeBul_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Bul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(66, 210);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(343, 210);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(603, 210);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 5;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView.Location = new System.Drawing.Point(214, 312);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(345, 122);
            this.dataGridView.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ÜrünKodu";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ürün Kg Fiyatı";
            this.Column3.Name = "Column3";
            // 
            // hataMesaj
            // 
            this.hataMesaj.AutoSize = true;
            this.hataMesaj.Location = new System.Drawing.Point(85, 259);
            this.hataMesaj.Name = "hataMesaj";
            this.hataMesaj.Size = new System.Drawing.Size(46, 13);
            this.hataMesaj.TabIndex = 7;
            this.hataMesaj.Text = "hata123";
            // 
            // btnUrunleriListele
            // 
            this.btnUrunleriListele.Location = new System.Drawing.Point(319, 283);
            this.btnUrunleriListele.Name = "btnUrunleriListele";
            this.btnUrunleriListele.Size = new System.Drawing.Size(137, 23);
            this.btnUrunleriListele.TabIndex = 8;
            this.btnUrunleriListele.Text = "Ürünleri Listeli";
            this.btnUrunleriListele.UseVisualStyleBackColor = true;
            this.btnUrunleriListele.Click += new System.EventHandler(this.button3_Click);
            // 
            // hataMesajSilme
            // 
            this.hataMesajSilme.AutoSize = true;
            this.hataMesajSilme.Location = new System.Drawing.Point(360, 259);
            this.hataMesajSilme.Name = "hataMesajSilme";
            this.hataMesajSilme.Size = new System.Drawing.Size(51, 13);
            this.hataMesajSilme.TabIndex = 9;
            this.hataMesajSilme.Text = "hatasilme";
            // 
            // urunGuncellemeHata
            // 
            this.urunGuncellemeHata.AutoSize = true;
            this.urunGuncellemeHata.Location = new System.Drawing.Point(631, 259);
            this.urunGuncellemeHata.Name = "urunGuncellemeHata";
            this.urunGuncellemeHata.Size = new System.Drawing.Size(68, 13);
            this.urunGuncellemeHata.TabIndex = 10;
            this.urunGuncellemeHata.Text = "hataguncelle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 446);
            this.Controls.Add(this.urunGuncellemeHata);
            this.Controls.Add(this.hataMesajSilme);
            this.Controls.Add(this.btnUrunleriListele);
            this.Controls.Add(this.hataMesaj);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox urunEkleFiyat;
        private System.Windows.Forms.TextBox urunEkleAd;
        private System.Windows.Forms.TextBox urunEkleKod;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button urunSilmeBul;
        private System.Windows.Forms.TextBox urunSilmeFiyat;
        private System.Windows.Forms.TextBox urunSilmeAd;
        private System.Windows.Forms.TextBox urunSilmeKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox urunGuncelleFiyat;
        private System.Windows.Forms.TextBox urunGuncelleAd;
        private System.Windows.Forms.TextBox urunGuncelleKod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label hataMesaj;
        private System.Windows.Forms.Button btnUrunleriListele;
        private System.Windows.Forms.Label hataMesajSilme;
        private System.Windows.Forms.Label urunGuncellemeHata;
    }
}

