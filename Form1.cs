using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Dugum
        {
            public int _numara;
            public Dugum _next;

            public Dugum(int numara)
            {
                _numara = numara;
            }


        }

        class CiftDugum
        {
            public int _kod;
            public string _ad;
            public int _fiyat;

            public CiftDugum sonraki;
            public CiftDugum onceki;

            public CiftDugum(int kod, string ad, int fiyat)
            {
                _kod = kod;
                _ad = ad;
                _fiyat = fiyat;
            }

        }

            CiftDugum ilk = null;
            CiftDugum son = null;
        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (hataMesaj.Visible)
            {
                hataMesaj.Visible = false;
            }

            int girilenKod = Convert.ToInt32(urunEkleKod.Text);
            string ad = urunEkleAd.Text;
            int fiyat = Convert.ToInt32(urunEkleFiyat.Text);


            CiftDugum yeni = new CiftDugum(girilenKod, ad, fiyat);



            if (ilk == null)
            {
                ilk = yeni;
                ilk.onceki = null;
                ilk.sonraki = null;
                son = ilk;

            }
            else
            {
                CiftDugum gecici = ilk;

                while (gecici != null)
                {
                    if (yeni._kod == gecici._kod)
                    {
                        hataMesaj.Visible = true;
                        break;
                    }

                    gecici = gecici.sonraki;
                }

                if (hataMesaj.Visible == false)
                {
                    son.sonraki = yeni;
                    yeni.onceki = son;
                    yeni.sonraki = null;
                    son = yeni;
                }


            }


            urunEkleKod.Text = "";
            urunEkleAd.Text = "";
            urunEkleFiyat.Text = "";
        }
        private void urunSilmeBul_Click(object sender, EventArgs e)
        {
            hataMesajSilme.Visible = false;



            int girilenKod = Convert.ToInt32(urunSilmeKod.Text);

            Boolean aynıKodVarmi = false;
            CiftDugum gecici = ilk;

            while (gecici != null)
            {
                if (gecici._kod == girilenKod)
                {
                    urunSilmeAd.Text = gecici._ad;
                    urunSilmeFiyat.Text = gecici._fiyat.ToString();
                    aynıKodVarmi = true;
                    btnSil.Enabled = true;
                    break;
                }

                gecici = gecici.sonraki;
            }

            if (aynıKodVarmi == false)
            {
                hataMesajSilme.Visible = true;
                btnSil.Enabled = false;
                urunSilmeAd.Text = "";
                urunSilmeFiyat.Text = "";

            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CiftDugum silinecek = ilk;


            int girilenKod = Convert.ToInt32(urunSilmeKod.Text);

            while (silinecek != null)
            {
                if (silinecek._kod == girilenKod)
                {

                    if (silinecek == ilk && ilk.sonraki == null)
                    {
                        ilk = null;

                    }
                    else if (silinecek == ilk)
                    {
                        ilk = ilk.sonraki;
                        ilk.onceki = null;

                    }
                    else if (silinecek == son)
                    {
                        son = son.onceki;
                        son.sonraki = null;
                    }
                    else
                    {
                        silinecek.onceki.sonraki = silinecek.sonraki;
                        silinecek.sonraki.onceki = silinecek.onceki;
                    }


                }

                silinecek = silinecek.sonraki;
            }

            urunSilmeKod.Text = "";
            urunSilmeAd.Text = "";
            urunSilmeFiyat.Text = "";
        }


        private void button2_Click(object sender, EventArgs e) ///btnGuncellemeBulma butonu
        {
            urunGuncellemeHata.Visible = false;
            urunGuncelleFiyat.Enabled = false;

            int girilenKod = Convert.ToInt32(urunGuncelleKod.Text);

            CiftDugum gecici = ilk;
            Boolean aynıKodVarmi = false;

            while (gecici != null)
            {
                if (gecici._kod == girilenKod)
                {
                    urunGuncelleAd.Text = gecici._ad.ToString();
                    urunGuncelleFiyat.Text = gecici._fiyat.ToString();
                    aynıKodVarmi = true;
                    btnGüncelle.Enabled = true;
                    urunGuncelleFiyat.Enabled = true;
                    break;
                }

                gecici = gecici.sonraki;
            }

            if (aynıKodVarmi == false)
            {
                urunGuncellemeHata.Visible = true;
                urunGuncelleAd.Text = "";
                urunGuncelleFiyat.Text = "";

            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int girilenfiyat = Convert.ToInt32(urunGuncelleFiyat.Text);
            string girilenad = urunGuncelleAd.Text;

            CiftDugum gecici = ilk;
            int girilenKod = Convert.ToInt32(urunGuncelleKod.Text);


            while (gecici != null)
            {
                if (gecici._kod == girilenKod)
                {
                    gecici._fiyat = girilenfiyat;
                    gecici._ad = girilenad;
                    break;
                }
                gecici = gecici.sonraki;
            }

            btnGüncelle.Enabled = false;

            urunGuncelleAd.Text = "";
            urunGuncelleFiyat.Text = "";
            urunGuncelleKod.Text = "";

        }
        private void button3_Click(object sender, EventArgs e) //btnUrunleriListele butonu
        {
            dataGridView.Rows.Clear();


            CiftDugum gecici = ilk;
            int rows = 0;

            while (gecici  != null)
            {

                dataGridView.Rows.Add();

                dataGridView.Rows[rows].Cells[0].Value = gecici._kod.ToString();

                dataGridView.Rows[rows].Cells[1].Value = gecici._ad;

                dataGridView.Rows[rows].Cells[2].Value = gecici._fiyat.ToString();

                rows += 1;

                gecici = gecici.sonraki;
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}
