using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TartimGuncelle : Form
    {
        private int id = 0;
        MesajKutusu mesaj = new MesajKutusu();
        public TartimGuncelle(int id)
        {
            InitializeComponent();
            this.id = id;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm:ss";
        }
        WindowsFormsApp1Entities db = new WindowsFormsApp1Entities();
        private void TartimGuncelle_Load(object sender, EventArgs e)
        {
            try
            {
                var tartim = db.Tartim.Find(this.id);
                var alicifirma = db.CariUnvan_Firma.Where(x => x.Arsiv == false).ToList();
                comboBoxAliciFirma.DataSource = alicifirma.Select(x => x.CariUnvan_FirmaAd).ToList();
                comboBoxAliciFirmaId.DataSource = alicifirma.Select(x => x.CariUnvan_FirmaId).ToList();
                comboBoxAliciFirma.Text = tartim.CariUnvan_Firma.CariUnvan_FirmaAd;
                // comboBoxAliciFirmaId.SelectedItem = comboBoxAliciFirmaId.FindString(tartim.CariUnvan_FirmaAliciId.ToString());
                //
                var arac = db.Arac.Where(x => x.Arsiv == false).ToList();
                comboBoxAracPlaka.DataSource = arac.Select(x => x.AracPlaka).ToList();
                comboBoxAracId.DataSource = arac.Select(x => x.AracId).ToList();
                comboBoxAracPlaka.Text = tartim.Arac.AracPlaka;
                // comboBoxAracId.SelectedItem = null;
                //
                var sofor = db.Sofor.Where(x => x.Arsiv == false).ToList();
                comboBoxSofor.DataSource = sofor.Select(x => x.SoforAdSoyad).ToList();
                comboBoxSoforId.DataSource = sofor.Select(x => x.SoforId).ToList();
                comboBoxSofor.Text = tartim.Sofor.SoforAdSoyad;
                // comboBoxSoforId.SelectedItem = null;
                //
                var malzeme = db.Malzeme.Where(x => x.Arsiv == false).ToList();
                comboBoxMalzemeAd.DataSource = malzeme.Select(x => x.MalzemeAd).ToList();
                comboBoxMalzemeId.DataSource = malzeme.Select(x => x.MalzemeId).ToList();
                comboBoxMalzemeAd.Text = tartim.Malzeme.MalzemeAd;
                // comboBoxMalzemeId.SelectedItem = null;
                //
                var sevkyeri = db.SevkYeri.Where(x => x.Arsiv == false).ToList();
                comboBoxSevkYeri.DataSource = sevkyeri.Select(x => x.SevkYeriAdres).ToList();
                comboBoxSevkYeriId.DataSource = sevkyeri.Select(x => x.SevkYeriId).ToList();
                comboBoxSevkYeri.Text = tartim.SevkYeri.SevkYeriAdres;
                // comboBoxSevkYeriId.SelectedItem = null;
                //
                int id = int.Parse(Properties.Settings.Default.GondericiFirma);
                string tarih = DateTime.Now.ToString();
                if (db.CariUnvan_Firma.FirstOrDefault(x => x.CariUnvan_FirmaId == id) != null)
                    comboBoxGonderenFirma.Text = db.CariUnvan_Firma.Find(id).CariUnvan_FirmaAd;

                textBoxIslemKod.Text = tartim.TartimId.ToString();
                textBoxGunlukIslemKod.Text = tartim.IslemSirasi.ToString();
                textBoxAgirlik.Text = tartim.NetAgirlik.ToString();
                textBoxBirimFiyat.Text = tartim.Malzeme.MalzemeBirimFiyat.ToString();
                textBoxToplamFiyat.Text = tartim.Ucret.ToString();
                dateTimePicker1.Text = tartim.OlcumTarihi.ToString();
                textBoxTC.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Gerekli Olan BütünBilgilere Sahip Değilsiniz");
            }


        }

        private void comboBoxAracPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAracId.SelectedIndex = comboBoxAracPlaka.SelectedIndex;
        }

        private void comboBoxSofor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSoforId.SelectedIndex = comboBoxSofor.SelectedIndex;
        }

        private void comboBoxAliciFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAliciFirmaId.SelectedIndex = comboBoxAliciFirma.SelectedIndex;
        }

        private void comboBoxSevkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSevkYeriId.SelectedIndex = comboBoxSevkYeri.SelectedIndex;
        }



        private void comboBoxMalzemeAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMalzemeId.SelectedIndex = comboBoxMalzemeAd.SelectedIndex;
            if (comboBoxMalzemeId.SelectedIndex >= 0)
            {
                int id = int.Parse(comboBoxMalzemeId.Text);
                textBoxBirimFiyat.Text = db.Malzeme.Find(id).MalzemeBirimFiyat.ToString();

            }

        }

        private void ıconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ıconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ıconPictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void ıconPictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ıconPictureBoxSahis_Click(object sender, EventArgs e)
        {
            AgirlikEl();
        }
        public void AgirlikEl()
        {

            if (textBoxTC.Enabled == true)
            {
                textBoxTC.Enabled = false;
                ıconPictureBoxSahis.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxSahis.IconColor = System.Drawing.SystemColors.ControlText;
            }
            else
            {
                textBoxTC.Enabled = true;
                ıconPictureBoxSahis.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                ıconPictureBoxSahis.IconColor = System.Drawing.Color.DarkGreen;
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Tartim tartim = db.Tartim.Find(this.id);
                tartim.AracId = int.Parse(comboBoxAracId.Text);
                tartim.CariUnvan_FirmaAliciId = int.Parse(comboBoxAliciFirmaId.Text);
                tartim.CariUnvan_FirmaGondericiId = int.Parse(Properties.Settings.Default.GondericiFirma);
                tartim.IslemSirasi = int.Parse(textBoxGunlukIslemKod.Text);
                tartim.MalzemeId = int.Parse(comboBoxMalzemeId.Text);
                if (ıconPictureBoxSahis.IconChar == FontAwesome.Sharp.IconChar.CheckSquare)
                {
                    tartim.NetAgirlik = double.Parse(textBoxTC.Text);
                    tartim.Ucret = 0;
                }
                else
                {
                    tartim.NetAgirlik = double.Parse(textBoxAgirlik.Text);
                    tartim.Ucret = double.Parse(textBoxToplamFiyat.Text);
                }

                tartim.OlcumTarihi = dateTimePicker1.Value;
                tartim.SevkYeriId = int.Parse(comboBoxSevkYeriId.Text);
                tartim.SoforId = int.Parse(comboBoxSoforId.Text);

                tartim.YetkiliId = Global.Kullanici.YetkiliId;
                db.Entry(tartim).State=System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);
            }

            catch (Exception ex)
            {
                mesaj.Mesaj(ex.Message, FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);

            }

        }
    }
}