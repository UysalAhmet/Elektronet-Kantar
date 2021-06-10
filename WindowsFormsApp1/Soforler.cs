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
    public partial class Soforler : Form
    {
        WindowsFormsApp1Entities db = new WindowsFormsApp1Entities();
        MesajKutusu mesaj = new MesajKutusu();
        public Soforler()
        {
            InitializeComponent();
            soforBindingSource.DataSource = db.Sofor.ToList();
        }

        private void textBoxTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ıconPictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            if (comboBoxSofor.Enabled == true)
            {
                comboBoxSofor.Enabled = false;
                BtnSil.Enabled = false;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
                FormTemizle();
            }
            else
            {
                BtnSil.Enabled = true;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.Color.DarkGreen;
                if (ComboboxGuncelle())
                {
                    comboBoxSofor.Enabled = true;
                    EkleSil();
                }
                else
                {
                    comboBoxSofor.Enabled = false;
                }

               
                

            }
        }

        private void Soforler_Load(object sender, EventArgs e)
        {
            comboBoxSofor.Enabled = false;
            BtnSil.Enabled = false;
            BtnAktifEt.Enabled = false;
            comboBoxSoforId.Visible = false;
            FormTemizle();
        }
        #region

        public void FormTemizle()
        {
            textBoxSoforAdSoyad.Text = String.Empty;
            textBoxSoyad.Text = String.Empty;
            textBoxTelefon.Text = String.Empty;
            textBoxTCNo.Text = String.Empty;
            ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
            ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
           
            comboBoxSofor.Enabled = false;
            BtnSil.Enabled = false;
            BtnAktifEt.Enabled = false;


        }
        public bool ComboboxGuncelle()
        {
            var list = db.Sofor.ToList();
            //comboBoxSofor.DataSource = list.Select(x => x.SoforAdSoyad).ToList();
            //comboBoxSoforId.DataSource = list.Select(x => x.SoforId).ToList();
            //comboBoxSofor.AutoCompleteSource = AutoCompleteSource.ListItems;
            //comboBoxSofor.AutoCompleteMode = AutoCompleteMode.Suggest;
            //comboBoxSofor.MaxDropDownItems = 10;
            if (list.Count == 0)
            {
                mesaj.Mesaj("Veri Bulunmamakta", FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
                BtnSil.Enabled = false;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
                BtnAktifEt.Enabled = false;
                
                return false;
            }
            comboBoxSofor.SelectedIndex = 0;
            EkleSil();
            return true;
        }
        public void EkleSil()
        {
            if (comboBoxSofor.Enabled == true)
            {
                if (comboBoxSofor.SelectedValue != null)
                {
                    int id = int.Parse(comboBoxSofor.SelectedValue.ToString());
                    var sofor = db.Sofor.FirstOrDefault(x => x.SoforId == id);
                    if (sofor != null)
                    {
                        FormDoldur(sofor);
                        if (sofor.Arsiv == true)
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

        }
        public void FormDoldur(Sofor sofor)
        {
            textBoxSoforAdSoyad.Text = sofor.SoforAdSoyad;
            textBoxTelefon.Text = sofor.SoforTelefon;
            textBoxTCNo.Text = sofor.SoforTC;

        }



        #endregion

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxSoforId.Text);
            var sofor = db.Sofor.FirstOrDefault(x => x.SoforId == id);
            if (sofor != null)
            {
                try
                {
                    sofor.Arsiv = true;
                    db.Entry(sofor).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);
                    FormTemizle();
                    comboBoxSofor.Enabled = false;
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

        private void BtnAktifEt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxSoforId.Text);
            var sofor = db.Sofor.Find(id);
            try
            {
                sofor.Arsiv = false;
                db.Entry(sofor).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);

            }
            catch (Exception ex)
            {
                mesaj.Mesaj(ex.Message, FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
            }
            comboBoxSofor.Enabled = false;
            BtnSil.Enabled = false;
            ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
            ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
            BtnAktifEt.Enabled = false;
            ComboboxGuncelle();
            FormTemizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSofor.Enabled == true)
                {
                    int id = int.Parse(comboBoxSofor.SelectedValue.ToString());
                    var sofor = db.Sofor.Find(id);
                    sofor.SoforAdSoyad = textBoxSoforAdSoyad.Text+" "+textBoxSoyad.Text;
                    sofor.SoforAd = textBoxSoforAdSoyad.Text;
                    sofor.SoforSoyad =textBoxSoyad.Text;
                    sofor.SoforTC = textBoxTCNo.Text;
                    sofor.SoforTelefon = textBoxTelefon.Text;
                    sofor.Arsiv = false;
                    db.Entry(sofor).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Global.sonsofor = sofor;

                }
                else
                {
                    var sofor = new Sofor();
                    sofor.SoforAdSoyad = textBoxSoforAdSoyad.Text + " " + textBoxSoyad.Text;
                    sofor.SoforAd = textBoxSoforAdSoyad.Text;
                    sofor.SoforSoyad = textBoxSoyad.Text;
                    sofor.SoforTC = textBoxTCNo.Text;
                    sofor.SoforTelefon = textBoxTelefon.Text;
                    sofor.Arsiv = false;
                    db.Sofor.Add(sofor);
                    db.SaveChanges();
                    Global.sonsofor = sofor;
                }
                mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);
            }
            catch (Exception ex)
            {
                mesaj.Mesaj(ex.Message, FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);

            }
            FormTemizle();
        }

        private void BtnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void comboBoxSofor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxSoforId.SelectedIndex = comboBoxSofor.SelectedIndex;
           EkleSil();
        }

        private void Soforler_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if (comboBoxSofor.Enabled == true)
            {

                ıconPictureBoxGuncelle_Click(sender, e);
            }
        }

        private void Soforler_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
