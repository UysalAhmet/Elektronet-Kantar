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
    public partial class SevkYeriForm : Form
    {
        WindowsFormsApp1Entities db = new WindowsFormsApp1Entities();
        MesajKutusu mesaj = new MesajKutusu();
        public SevkYeriForm()
        {
            InitializeComponent();
            sevkYeriBindingSource.DataSource = db.SevkYeri.ToList();
        }
        private void SevkYeriForm_Load(object sender, EventArgs e)
        {
            comboBoxSevkYeri.Enabled = false;
            BtnSil.Enabled = false;
            BtnAktifEt.Enabled = false;
            comboBoxSevkYeriId.Visible = false;
            FormTemizle();
          

        }
        //Eventler
        #region
        private void ıconPictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            if (comboBoxSevkYeri.Enabled == true)
            {
                comboBoxSevkYeri.Enabled = false;
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
                    comboBoxSevkYeri.Enabled = true;
                    EkleSil();
                }
                else
                {
                    comboBoxSevkYeri.Enabled = false;
                }

            }

        }
        private void comboBoxSevkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBoxSevkYeriId.SelectedIndex = comboBoxSevkYeri.SelectedIndex;
            EkleSil();
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
          
            int id = int.Parse(comboBoxSevkYeriId.Text);
            var sevkyeri = Global.db.SevkYeri.FirstOrDefault(x => x.SevkYeriId == id);
            if (sevkyeri != null)
            {
                try
                {
                    sevkyeri.Arsiv = true;
                    Global.db.Entry(sevkyeri).State = System.Data.Entity.EntityState.Modified;
                    Global.db.SaveChanges();
                    mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);
                    FormTemizle();
                    comboBoxSevkYeri.Enabled = false;
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
            int id = int.Parse(comboBoxSevkYeriId.Text);
            var sevkYeri = Global.db.SevkYeri.Find(id);
            try
            {
                sevkYeri.Arsiv = false;
                Global.db.Entry(sevkYeri).State = System.Data.Entity.EntityState.Modified;
                Global.db.SaveChanges();
                mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);

            }
            catch (Exception ex)
            {
                mesaj.Mesaj(ex.Message, FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
            }
            comboBoxSevkYeri.Enabled = false;
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
                if (comboBoxSevkYeri.Enabled == true)
                {
                    int id = int.Parse(comboBoxSevkYeri.SelectedValue.ToString());
                    var sevkyeri = Global.db.SevkYeri.Find(id);
                    sevkyeri.SevkYeriAdres = textBoxAdres.Text;
                    sevkyeri.SevkYeriAciklama = textBoxAciklama.Text;
                    sevkyeri.Arsiv = false;
                    Global.db.Entry(sevkyeri).State = System.Data.Entity.EntityState.Modified;
                    Global.db.SaveChanges();
                    Global.sonsevkyeri=sevkyeri;
                }
                else
                {
                    var sevkyeri = new SevkYeri();
                    sevkyeri.SevkYeriAdres = textBoxAdres.Text;
                    sevkyeri.SevkYeriAciklama = textBoxAciklama.Text;
                    sevkyeri.Arsiv = false;
                    Global.db.SevkYeri.Add(sevkyeri);
                    Global.db.SaveChanges();
                    Global.sonsevkyeri = sevkyeri;
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

        #endregion
        //Fonksiyonlar
        #region

        public void FormTemizle()
        {
            textBoxAdres.Text = String.Empty;
            textBoxAciklama.Text = String.Empty;


        }
        public bool ComboboxGuncelle()
        {
           
            var list = Global.db.SevkYeri.ToList();
            //comboBoxSevkYeri.DataSource = list.Select(x => x.SevkYeriAdres).ToList();
            //comboBoxSevkYeriId.DataSource = list.Select(x => x.SevkYeriId).ToList();
            //comboBoxSevkYeri.AutoCompleteSource = AutoCompleteSource.ListItems;
            //comboBoxSevkYeri.AutoCompleteMode = AutoCompleteMode.Suggest;
            //comboBoxSevkYeri.MaxDropDownItems = 10;
            if (list.Count == 0)
            {
                mesaj.Mesaj("Veri Bulunmamakta", FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
                BtnSil.Enabled = false;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
                BtnAktifEt.Enabled = false;
                //EkleSil();
                return false;
            }
            comboBoxSevkYeri.SelectedIndex = 0;
            
            EkleSil();
           
            return true;
        }
        public void EkleSil()
        {
            
            if (comboBoxSevkYeri.Enabled == true)
            {
                try
                {
                    if (comboBoxSevkYeri.SelectedValue != null)
                    {

                        int id = int.Parse(comboBoxSevkYeri.SelectedValue.ToString());
                        var sevkyeri = Global.db.SevkYeri.FirstOrDefault(x => x.SevkYeriId == id);
                        if (sevkyeri != null)
                        {
                            FormDoldur(sevkyeri);
                            if (sevkyeri.Arsiv == true)
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
                catch (Exception)
                {
                }
              

            }
           
        }
        public void FormDoldur(SevkYeri sevkyeri)
        {
            textBoxAdres.Text = sevkyeri.SevkYeriAdres;
            textBoxAciklama.Text = sevkyeri.SevkYeriAciklama;

        }





        #endregion

        private void SevkYeriForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void SevkYeriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (comboBoxSevkYeri.Enabled == true)
            {
                ıconPictureBoxGuncelle_Click(sender, e);
            }
        }
    }
}
