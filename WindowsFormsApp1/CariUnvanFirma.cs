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
    public partial class CariUnvanFirma : Form
    {
        WindowsFormsApp1Entities db = new WindowsFormsApp1Entities();
        MesajKutusu mesaj = new MesajKutusu();

        public CariUnvanFirma()
        {
            InitializeComponent();
        }
        //Eventler
        #region
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxVergiNo.Text == "")
            {
                mesaj.Mesaj("Vergi No Boş Geçilemez ", FontAwesome.Sharp.IconChar.ExclamationTriangle, System.Drawing.Color.Yellow);
                return;
            }
            else if (ıconPictureBoxSahis.IconChar == FontAwesome.Sharp.IconChar.CheckSquare && textBoxTC.Text == "")
            {
                mesaj.Mesaj("TC Boş Geçilemez ", FontAwesome.Sharp.IconChar.ExclamationTriangle, System.Drawing.Color.Yellow);
                return;
            }
            else
            {


                CariUnvan_Firma firma = null;
                if (comboBoxFirma.Enabled == true)
                {
                    firma = db.CariUnvan_Firma.FirstOrDefault(c => c.CariUnvan_FirmaVergiNo == textBoxVergiNo.Text);
                }
                else
                {
                    firma = db.CariUnvan_Firma.FirstOrDefault(c => c.CariUnvan_FirmaVergiNo == textBoxVergiNo.Text);
                    if (firma != null)
                    {
                        mesaj.Mesaj("Böyle Bir Firma Zaten '" + firma.CariUnvan_FirmaAd + "'Olarak Kayıtlı Aktif Ediniz", FontAwesome.Sharp.IconChar.ExclamationTriangle, System.Drawing.Color.Yellow);
                        return;
                    }
                }

                if (firma == null)
                {
                    try
                    {

                        CariUnvan_Firma instance = new CariUnvan_Firma();
                        instance.CariUnvan_FirmaAd = Validate(textBoxFirmaAd.Text);
                        instance.CariUnvan_FirmaAdres = Validate(textBoxAdres.Text);
                        instance.CariUnvan_FirmaEmail = Validate(textBoxEmail.Text);
                        instance.CariUnvan_FirmaMarsisNo = Validate(textBoxMersisNo.Text);
                        instance.CariUnvan_FirmaTelefon = Validate(textBoxTelefon.Text);
                        instance.CariUnvan_FirmaVergiDairesi = Validate(textBoxVergiDairesi.Text);
                        instance.CariUnvan_FirmaVergiNo = Validate(textBoxVergiNo.Text);
                        instance.Il = Validate(textBoxIl.Text);
                        instance.Ilce = Validate(textBoxIlce.Text);
                        if (ıconPictureBoxSahis.IconChar != FontAwesome.Sharp.IconChar.Square)
                        {
                            instance.CariUnvan_FirmaTC = Validate(textBoxTC.Text);
                            instance.CariUnvan_SahisAdSoyad = Validate(textBoxAdSoyad.Text) + " " + Validate(textBoxSoyad.Text);
                            instance.CariUnvan_SahisAd = Validate(textBoxAdSoyad.Text);
                            instance.CariUnvan_SahisSoyad = Validate(textBoxSoyad.Text);
                            instance.CariUnvan_FirmaAd = Validate(textBoxAdSoyad.Text) + " " + Validate(textBoxSoyad.Text);
                            instance.CariUnvan_FirmaTip = 0;
                        }
                        else
                        {

                            instance.CariUnvan_FirmaTip = 1;

                            instance.CariUnvan_FirmaTC = null;
                            instance.CariUnvan_SahisAdSoyad = null;
                            instance.CariUnvan_SahisAd = null;
                            instance.CariUnvan_SahisSoyad = null;
                        }
                        instance.Arsiv = false;
                        db.CariUnvan_Firma.Add(instance);
                        db.SaveChanges();
                        Global.sonfirma = instance;
                        if (mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen))
                        {
                            FormTemizle();
                        }







                    }
                    catch (Exception ex)
                    {

                        mesaj.Mesaj(ex.Message, FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
                    }
                }
                else
                {

                    firma.CariUnvan_FirmaAd = Validate(textBoxFirmaAd.Text);
                    firma.CariUnvan_FirmaAdres = Validate(textBoxAdres.Text);
                    firma.CariUnvan_FirmaEmail = Validate(textBoxEmail.Text);
                    firma.CariUnvan_FirmaMarsisNo = Validate(textBoxMersisNo.Text);
                    firma.CariUnvan_FirmaTelefon = Validate(textBoxTelefon.Text);
                    firma.CariUnvan_FirmaVergiDairesi = Validate(textBoxVergiDairesi.Text);
                    firma.CariUnvan_FirmaVergiNo = Validate(textBoxVergiNo.Text);
                    firma.Il = Validate(textBoxIl.Text);
                    firma.Ilce = Validate(textBoxIlce.Text);
                    if (ıconPictureBoxSahis.IconChar != FontAwesome.Sharp.IconChar.Square)
                    {
                        firma.CariUnvan_FirmaTC = Validate(textBoxTC.Text);
                        firma.CariUnvan_SahisAdSoyad = Validate(textBoxAdSoyad.Text) + " " + Validate(textBoxSoyad.Text);
                        firma.CariUnvan_SahisAd = Validate(textBoxAdSoyad.Text);
                        firma.CariUnvan_SahisSoyad = Validate(textBoxSoyad.Text);
                        firma.CariUnvan_FirmaAd = Validate(textBoxAdSoyad.Text) + " " + Validate(textBoxSoyad.Text);
                        firma.CariUnvan_FirmaTip = 0;
                    }
                    else
                    {
                        firma.CariUnvan_FirmaTip = 1;
                        firma.CariUnvan_FirmaTC = null;
                        firma.CariUnvan_SahisAdSoyad = null;
                        firma.CariUnvan_SahisAd = null;
                        firma.CariUnvan_SahisSoyad = null;
                    }

                    firma.Arsiv = false;
                    db.Entry(firma).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Global.sonfirma = firma;
                    if (mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen))
                    {
                        FormTemizle();
                        comboBoxFirma.Enabled = false;
                        BtnSil.Enabled = false;
                    }
                }
                ComboboxGuncelle();
                comboBoxFirma.Enabled = false;
                BtnSil.Enabled = false;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
                FormTemizle();
            }
        }


        private void CariUnvanFirma_Load(object sender, EventArgs e)
        {
            comboBoxFirma.Enabled = false;
            BtnSil.Enabled = false;
            BtnAktifEt.Enabled = false;
            textBoxTC.Enabled = false;
            textBoxAdSoyad.Enabled = false;
            textBoxSoyad.Enabled = false;
            comboBoxFirmaId.Visible = false;
            FormTemizle();

        }

        private void ıconPictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            if (comboBoxFirma.Enabled == true)
            {
                comboBoxFirma.Enabled = false;
                BtnSil.Enabled = false;
                BtnAktifEt.Enabled = false;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
                FormTemizle();
            }
            else
            {
                comboBoxFirma.Enabled = true;
                BtnSil.Enabled = true;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.Color.DarkGreen;

                if (ComboboxGuncelle())
                {
                    comboBoxFirma.Enabled = true;
                    EkleSil();
                }
                else
                {
                    comboBoxFirma.Enabled = false;
                }

            }

        }



        private void comboBoxFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxFirmaId.SelectedIndex = comboBoxFirma.SelectedIndex;
            EkleSil();

        }


        private void BtnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxFirmaId.Text);
            var firma = db.CariUnvan_Firma.FirstOrDefault(x => x.CariUnvan_FirmaId == id);
            if (firma != null)
            {
                try
                {
                    firma.Arsiv = true;
                    db.Entry(firma).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);
                    FormTemizle();
                    comboBoxFirma.Enabled = false;
                    BtnSil.Enabled = false;
                    ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
                    ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;

                }
                catch (Exception)
                {
                    mesaj.Mesaj("Silme İşleminde Hata", FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);

                }

            }
        }

        private void ıconPictureBoxSahis_Click(object sender, EventArgs e)
        {
            SahisBilgiler();
        }


        private void textBoxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BtnAktifEt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxFirmaId.Text);
            var firma = db.CariUnvan_Firma.Find(id);
            try
            {
                firma.Arsiv = false;
                db.Entry(firma).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);

            }
            catch (Exception ex)
            {
                mesaj.Mesaj(ex.Message, FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
            }
            comboBoxFirma.Enabled = false;
            BtnSil.Enabled = false;
            ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
            ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
            BtnAktifEt.Enabled = false;
            ComboboxGuncelle();
            FormTemizle();
        }

        private void textBoxVergiNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion
        //Fonksiyonlar
        #region 
        public void FormDoldur(CariUnvan_Firma firma)
        {
            textBoxAdres.Text = firma.CariUnvan_FirmaAdres;
            textBoxEmail.Text = firma.CariUnvan_FirmaEmail;
            textBoxFirmaAd.Text = firma.CariUnvan_FirmaAd;
            textBoxMersisNo.Text = firma.CariUnvan_FirmaMarsisNo;
            textBoxTelefon.Text = firma.CariUnvan_FirmaTelefon;
            textBoxVergiDairesi.Text = firma.CariUnvan_FirmaVergiDairesi;
            textBoxVergiNo.Text = firma.CariUnvan_FirmaVergiNo;
            textBoxIl.Text = firma.Il;
            textBoxIlce.Text = firma.Ilce;
            if (firma.CariUnvan_FirmaTip == 0)
            {
                textBoxTC.Enabled = true;
                textBoxAdSoyad.Enabled = true;
                textBoxSoyad.Enabled = true;
                ıconPictureBoxSahis.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                ıconPictureBoxSahis.IconColor = System.Drawing.Color.DarkGreen;
                textBoxAdSoyad.Text = firma.CariUnvan_SahisAd;
                textBoxSoyad.Text = firma.CariUnvan_SahisSoyad;
                textBoxTC.Text = firma.CariUnvan_FirmaTC;
            }
            else
            {
                textBoxTC.Enabled = false;
                textBoxAdSoyad.Enabled = false;
                textBoxSoyad.Enabled = false;
                ıconPictureBoxSahis.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxSahis.IconColor = System.Drawing.SystemColors.ControlText;
                textBoxAdSoyad.Text = null;
                textBoxSoyad.Text = null;
                textBoxTC.Text = null;
            }
        }
        public void FormTemizle()
        {
            textBoxAdres.Text = String.Empty;
            textBoxEmail.Text = String.Empty;
            textBoxFirmaAd.Text = String.Empty;
            textBoxMersisNo.Text = String.Empty;
            textBoxTelefon.Text = String.Empty;
            textBoxVergiDairesi.Text = String.Empty;
            textBoxVergiNo.Text = String.Empty;
            textBoxAdSoyad.Text = String.Empty;
            textBoxSoyad.Text = String.Empty;
            textBoxTC.Text = String.Empty;
            textBoxIl.Text = String.Empty;
            textBoxIlce.Text = String.Empty;
            textBoxTC.Enabled = false;
            textBoxAdSoyad.Enabled = false;
            textBoxSoyad.Enabled = false;
            ıconPictureBoxSahis.IconChar = FontAwesome.Sharp.IconChar.Square;
            ıconPictureBoxSahis.IconColor = System.Drawing.SystemColors.ControlText;


        }
        public void SahisBilgiler()
        {

            if (textBoxTC.Enabled == true)
            {
                textBoxTC.Enabled = false;
                textBoxAdSoyad.Enabled = false;
                textBoxSoyad.Enabled = false;
                ıconPictureBoxSahis.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxSahis.IconColor = System.Drawing.SystemColors.ControlText;
            }
            else
            {
                textBoxTC.Enabled = true;
                textBoxAdSoyad.Enabled = true;
                textBoxSoyad.Enabled = true;
                ıconPictureBoxSahis.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                ıconPictureBoxSahis.IconColor = System.Drawing.Color.DarkGreen;
            }
        }
        public void EkleSil()
        {
            if (comboBoxFirma.Enabled == true)
            {
                var firma = db.CariUnvan_Firma.FirstOrDefault(x => x.CariUnvan_FirmaAd == comboBoxFirma.Text);
                if (firma != null)
                {
                    FormDoldur(firma);
                    if (firma.Arsiv == true)
                    {
                        BtnSil.Enabled = false;
                        BtnAktifEt.Enabled = true;
                    }
                    else
                    {
                        BtnSil.Enabled = true;
                        BtnAktifEt.Enabled = false;
                    }
                }

            }

        }
        public bool ComboboxGuncelle()
        {
            var list = db.CariUnvan_Firma.ToList();
            comboBoxFirma.DataSource = list.Select(x => x.CariUnvan_FirmaAd).ToList();
            comboBoxFirmaId.DataSource = list.Select(x => x.CariUnvan_FirmaId).ToList();
            comboBoxFirma.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxFirma.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxFirma.MaxDropDownItems = 10;
            if (list.Count == 0)
            {
                mesaj.Mesaj("Veri Bulunmamakta", FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
                BtnSil.Enabled = false;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
                BtnAktifEt.Enabled = false;

                return false;
            }
            comboBoxFirma.SelectedIndex = 0;
            return true;
        }
        public string Validate(string s)
        {
            if (s == "")
            {
                return null;
            }
            else
            {
                return s;
            }
        }
        #endregion

        private void textBoxTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void ıconPictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       
    }
}
