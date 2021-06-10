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
    public partial class Malzemeler : Form
    {
        WindowsFormsApp1Entities db = new WindowsFormsApp1Entities();
        MesajKutusu mesaj = new MesajKutusu();
        public Malzemeler()
        {
            InitializeComponent();
            malzemeBindingSource.DataSource = db.Malzeme.ToList();
        }

        private void ıconPictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            if (comboBoxMalzeme.Enabled == true)
            {
                comboBoxMalzeme.Enabled = false;
                BtnSil.Enabled = false;
                BtnAktifEt.Enabled = false;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
                FormTemizle();
            }
            else
            {
                comboBoxMalzeme.Enabled = true;
                BtnSil.Enabled = true;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.Color.DarkGreen;

                ComboboxGuncelle();
            }

        }

        private void Malzemeler_Load(object sender, EventArgs e)
        {
            comboBoxMalzeme.Enabled = false;
            BtnSil.Enabled = false;
            BtnAktifEt.Enabled = false;
            comboBoxMalzemeId.Visible = false;
            comboBoxMalzeme.SelectedItem = null;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Malzeme malzeme = new Malzeme();
                if (comboBoxMalzeme.Enabled == true)
                {
                    malzeme = db.Malzeme.Find(int.Parse(comboBoxMalzeme.SelectedValue.ToString()));
                    malzeme.MalzemeAd = textBoxMalzemeAd.Text;
                    malzeme.MalzemeAciklama = textBoxAciklama.Text;
                    malzeme.MalzemeBirimFiyat = int.Parse(textBoxBirimFiyat.Text);
                    malzeme.Arsiv = false;
                    db.Entry(malzeme).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Global.sonmalzeme = malzeme;

                }
                else
                {
                    malzeme.MalzemeAd = textBoxMalzemeAd.Text;
                    malzeme.MalzemeAciklama = textBoxAciklama.Text;
                    malzeme.MalzemeBirimFiyat = int.Parse(textBoxBirimFiyat.Text);
                    malzeme.Arsiv = false;
                    db.Malzeme.Add(malzeme);
                    db.SaveChanges();
                    Global.sonmalzeme = malzeme;
                }

                mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);
                
            }
            catch (Exception)
            {

                mesaj.Mesaj("Ekleme  İşleminde Hata", FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
            }
            ComboboxGuncelle();
            comboBoxMalzeme.Enabled = false;
            BtnSil.Enabled = false;
            ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
            ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
            FormTemizle();
        }

        public void FormDoldur(Malzeme malzeme)
        {
            textBoxMalzemeAd.Text = malzeme.MalzemeAd;
            textBoxAciklama.Text = malzeme.MalzemeAciklama;
            textBoxBirimFiyat.Text = malzeme.MalzemeBirimFiyat.ToString();
        }


        private void comboBoxMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxMalzemeId.SelectedIndex = comboBoxMalzeme.SelectedIndex;
            EkleSil();
        }

        public void FormTemizle()
        {

            textBoxMalzemeAd.Text = String.Empty;
            textBoxAciklama.Text = String.Empty;
            textBoxBirimFiyat.Text = String.Empty;
        }

        private void textBoxBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxMalzemeId.Text);
            var malzeme = db.Malzeme.Find(id);
            if (malzeme != null)
            {
                try
                {
                    malzeme.Arsiv = true;
                    db.Entry(malzeme).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);
                    FormTemizle();
                    comboBoxMalzeme.Enabled = false;
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
        public void EkleSil()
        {
            if (comboBoxMalzeme.Enabled == true)
            {
                try
                {
                    if (comboBoxMalzeme.SelectedValue != null)
                    {

                        int id = int.Parse(comboBoxMalzeme.SelectedValue.ToString());
                        var malzeme = db.Malzeme.FirstOrDefault(x => x.MalzemeId == id);
                        if (malzeme != null)
                        {
                            if (malzeme.Arsiv == true)
                            {
                                BtnAktifEt.Enabled = true;
                                BtnSil.Enabled = false;
                            }
                            else
                            {
                                BtnAktifEt.Enabled = false;
                                BtnSil.Enabled = true;
                            }
                            FormDoldur(malzeme);
                        }
                    }
                }
                catch (Exception)
                {

                }
                

            }
        }
        public void ComboboxGuncelle()
        {
            var liste = db.Malzeme.ToList();
            //comboBoxMalzeme.DataSource = liste.Select(x => x.MalzemeAd).ToList();
            //comboBoxMalzemeId.DataSource = liste.Select(x => x.MalzemeId).ToList();
            //comboBoxMalzeme.AutoCompleteSource = AutoCompleteSource.ListItems;
            //comboBoxMalzeme.AutoCompleteMode = AutoCompleteMode.Suggest;
            //comboBoxMalzeme.MaxDropDownItems = 10;
            if (liste.Count == 0)
            {
                mesaj.Mesaj("Veri Bulunmamakta", FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
                BtnSil.Enabled = false;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
                BtnAktifEt.Enabled = false;
                EkleSil();
                return;
            }
            comboBoxMalzeme.SelectedIndex = 0;
            EkleSil();
        }

        private void BtnAktifEt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxMalzemeId.Text);
            var malzeme = db.Malzeme.Find(id);
            try
            {
                malzeme.Arsiv = false;
                db.Entry(malzeme).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);

            }
            catch (Exception ex)
            {
                mesaj.Mesaj(ex.Message, FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
            }
            comboBoxMalzeme.Enabled = false;
            BtnSil.Enabled = false;
            ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
            ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
            BtnAktifEt.Enabled = false;
            ComboboxGuncelle();
            FormTemizle();
        }

        private void BtnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void Malzemeler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (comboBoxMalzeme.Enabled == true)
            {
                ıconPictureBoxGuncelle_Click(sender, e);
            }
              
        }
    }

}

