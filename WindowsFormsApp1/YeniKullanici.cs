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
    public partial class YeniKullanici : Form
    {
        WindowsFormsApp1Entities db = new WindowsFormsApp1Entities();
        MesajKutusu mesaj = new MesajKutusu();
        public YeniKullanici()
        {
            InitializeComponent();
            comboBoxArac.Enabled = false;
            BtnSil.Enabled = false;
            BtnAktifEt.Enabled = false;
            comboBoxAracId.Visible = false;
          
            FormTemizle();
        }
        public void FormTemizle()
        {
            textBoxAracPlaka.Text = String.Empty;
          
            textBoxDaraAgirlik.Text = String.Empty;
            
            ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
            ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
            
            comboBoxArac.Enabled = false;
            BtnSil.Enabled = false;
            BtnAktifEt.Enabled = false;
        }
        public bool ComboboxGuncelle()
        {
            var list = db.Yetkili.ToList();
            comboBoxArac.DataSource = list.Select(x => x.YetkiliKullaniciAd).ToList();
            comboBoxAracId.DataSource = list.Select(x => x.YetkiliId).ToList();
            comboBoxArac.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxArac.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxArac.MaxDropDownItems = 10;
            if (list.Count == 0)
            {
                mesaj.Mesaj("Veri Bulunmamakta", FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
                BtnSil.Enabled = false;
                ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
                BtnAktifEt.Enabled = false;

                return false;
            }
            comboBoxArac.SelectedIndex = 0;
            EkleSil();
            return true;
        }
        public void EkleSil()
        {
            if (comboBoxArac.Enabled == true)
            {
                int id = int.Parse(comboBoxAracId.Text);
                var yetkili = db.Yetkili.FirstOrDefault(x => x.YetkiliId == id);
                if (yetkili != null)
                {
                    FormDoldur(yetkili);
                    if (yetkili.Arsiv == true)
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
        public void FormDoldur(Yetkili yetkili)
        {
            textBoxAracPlaka.Text = yetkili.YetkiliKullaniciAd;

            textBoxDaraAgirlik.Text = yetkili.YetkiliSifre.ToString();

        }

        private void ıconPictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            if (comboBoxArac.Enabled == true)
            {
                comboBoxArac.Enabled = false;
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
                    comboBoxArac.Enabled = true;
                    EkleSil();
                }
                else
                {
                    comboBoxArac.Enabled = false;
                }




            }
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxAracId.Text);
            var yetkili = db.Yetkili.FirstOrDefault(x => x.YetkiliId == id);
            if (yetkili != null)
            {
                try
                {
                    yetkili.Arsiv = true;
                    db.Entry(yetkili).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);
                    FormTemizle();
                    comboBoxArac.Enabled = false;
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
            int id = int.Parse(comboBoxAracId.Text);
            var yetkili = db.Yetkili.Find(id);
            try
            {
                yetkili.Arsiv = false;
                db.Entry(yetkili).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);

            }
            catch (Exception ex)
            {
                mesaj.Mesaj(ex.Message, FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
            }
            comboBoxArac.Enabled = false;
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
                if (comboBoxArac.Enabled == true)
                {
                    int id = int.Parse(comboBoxAracId.Text);
                    var yetkili = db.Yetkili.Find(id);
                    yetkili.YetkiliKullaniciAd = textBoxAracPlaka.Text;
                    yetkili.YetkiliSifre = textBoxDaraAgirlik.Text;
                   
                    yetkili.Arsiv = false;
                    db.Entry(yetkili).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
                else
                {
                    var arackontrol = new Yetkili();

                        arackontrol.YetkiliKullaniciAd = textBoxAracPlaka.Text;
                        arackontrol.YetkiliSifre = textBoxDaraAgirlik.Text;

                        arackontrol.Arsiv = false;
                        db.Yetkili.Add(arackontrol);
                        db.SaveChanges();
                    
                  
                }
                mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);
                FormTemizle();
            }
            catch (Exception ex)
            {
                mesaj.Mesaj(ex.Message, FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);

            }

        }

        private void BtnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void comboBoxArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAracId.SelectedIndex = comboBoxArac.SelectedIndex;
            EkleSil();
        }

    }
}
