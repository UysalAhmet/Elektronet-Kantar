using WindowsFormsApp1.Properties;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESC_POS_USB_NET.Printer;

namespace WindowsFormsApp1
{
    public partial class AracTartım : Form
    {

        WindowsFormsApp1Entities db = new WindowsFormsApp1Entities();
        SerialPort sp; MesajKutusu mesaj = new MesajKutusu();
        Tartim tartim;
        public AracTartım()
        {
            InitializeComponent();
            try
            {
                sp = new SerialPort(Settings.Default.PortName, int.Parse(Settings.Default.BoudWidth), (Parity)Enum.Parse(typeof(Parity), Settings.Default.ParityBit), int.Parse(Settings.Default.DataBit), (StopBits)Enum.Parse(typeof(StopBits), Settings.Default.StopBit));
                sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
                if (!sp.IsOpen)
                {
                    sp.Open();
                }
                textBoxTC.Enabled = false;
                this.formtemizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
        public void formtemizle()
        {
            comboBoxSevkYeri.SelectedItem = null;
            comboBoxMalzemeAd.SelectedItem = null;
            comboBoxSofor.SelectedItem = null;
            comboBoxAracPlaka.SelectedItem = null;
            comboBoxAliciFirma.SelectedItem = null;
            comboBox1.SelectedItem = null;
        }

        private void AracTartım_Load(object sender, EventArgs e)
        {
            try
            {
                
                aracBindingSource.DataSource = db.Arac.ToList();
                soforBindingSource.DataSource = db.Sofor.ToList();
                cariUnvanFirmaBindingSource.DataSource = db.CariUnvan_Firma.ToList();
                malzemeBindingSource.DataSource = db.Malzeme.ToList();
                sevkYeriBindingSource.DataSource = db.SevkYeri.ToList();
                cariUnvanFirmaBindingSource1.DataSource= db.CariUnvan_Firma.ToList();
                this.formtemizle();
                //var alicifirma = db.CariUnvan_Firma.Where(x => x.Arsiv == false).ToList();
                //comboBoxAliciFirma.DataSource = alicifirma.Select(x => x.CariUnvan_FirmaAd).ToList();
                //comboBoxAliciFirmaId.DataSource = alicifirma.Select(x => x.CariUnvan_FirmaId).ToList();
                //comboBoxAliciFirma.SelectedItem = null;
                //comboBoxAliciFirmaId.SelectedItem = null;
                ////
                //var arac = db.Arac.Where(x => x.Arsiv == false).ToList();
                //comboBoxAracPlaka.DataSource = arac.Select(x => x.AracPlaka).ToList();
                //comboBoxAracId.DataSource = arac.Select(x => x.AracId).ToList();
                //comboBoxAracPlaka.SelectedItem = null;
                //comboBoxAracId.SelectedItem = null;
                ////
                //var sofor = db.Sofor.Where(x => x.Arsiv == false).ToList();
                //comboBoxSofor.DataSource = sofor.Select(x => x.SoforAdSoyad).ToList();
                //comboBoxSoforId.DataSource = sofor.Select(x => x.SoforId).ToList();
                //comboBoxSofor.SelectedItem = null;
                //comboBoxSoforId.SelectedItem = null;
                ////
                //var malzeme = db.Malzeme.Where(x => x.Arsiv == false).ToList();
                //comboBoxMalzemeAd.DataSource = malzeme.Select(x => x.MalzemeAd).ToList();
                //comboBoxMalzemeId.DataSource = malzeme.Select(x => x.MalzemeId).ToList();
                //comboBoxMalzemeAd.SelectedItem = null;
                //comboBoxMalzemeId.SelectedItem = null;
                ////
                //var sevkyeri = db.SevkYeri.Where(x => x.Arsiv == false).ToList();
                //comboBoxSevkYeri.DataSource = sevkyeri.Select(x => x.SevkYeriAdres).ToList();
                //comboBoxSevkYeriId.DataSource = sevkyeri.Select(x => x.SevkYeriId).ToList();
                //comboBoxSevkYeri.SelectedItem = null;
                //comboBoxSevkYeriId.SelectedItem = null;
                //
                int id = int.Parse(Properties.Settings.Default.GondericiFirma);
                string tarih = DateTime.Now.ToString();
                if (db.CariUnvan_Firma.FirstOrDefault(x => x.CariUnvan_FirmaId == id) != null)
                    comboBoxGonderenFirma.Text = db.CariUnvan_Firma.Find(id).CariUnvan_FirmaAd;

                if (db.Tartim.Count().ToString() == "0")
                {
                    textBoxIslemKod.Text = "1";
                }
                else
                {
                    textBoxIslemKod.Text = (db.Tartim.OrderByDescending(x => x.TartimId).FirstOrDefault().TartimId + 1).ToString();
                    tarih = db.Tartim.OrderByDescending(x => x.TartimId).FirstOrDefault().OlcumTarihi.ToString();

                }

                if (db.Tartim.Count().ToString() == "0")
                {
                    textBoxGunlukIslemKod.Text = "1";
                }

                else if (DateTime.Parse(tarih).ToShortDateString() == DateTime.Today.ToShortDateString())
                {
                    textBoxGunlukIslemKod.Text = (db.Tartim.OrderByDescending(x => x.TartimId).FirstOrDefault().IslemSirasi + 1).ToString();
                }
                else if (DateTime.Parse(tarih).ToShortDateString() != DateTime.Today.ToShortDateString())
                {
                    textBoxGunlukIslemKod.Text = "1";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Gerekli Olan BütünBilgilere Sahip Değilsiniz");
            }



        }



        int brüt = 0;
        int arac = 0;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                tartim = new Tartim();
                tartim.AracId = int.Parse(comboBoxAracPlaka.SelectedValue.ToString());
                tartim.CariUnvan_FirmaAliciId = int.Parse(comboBoxAliciFirma.SelectedValue.ToString());
                tartim.CariUnvan_FirmaGondericiId = int.Parse(Properties.Settings.Default.GondericiFirma);
                tartim.IslemSirasi = int.Parse(textBoxGunlukIslemKod.Text);
                tartim.MalzemeId = int.Parse(comboBoxMalzemeAd.SelectedValue.ToString());
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

                tartim.OlcumTarihi = DateTime.Parse(textBoxIslemTarihi.Text);
                tartim.SevkYeriId = int.Parse(comboBoxSevkYeri.SelectedValue.ToString());
                tartim.SoforId = int.Parse(comboBoxSofor.SelectedValue.ToString());

                tartim.YetkiliId = Global.Kullanici.YetkiliId;
               arac= (int)db.Arac.Find(int.Parse(comboBoxAracPlaka.SelectedValue.ToString())).AracDaraAgirlik;
                if (ıconPictureBoxSahis.IconChar == FontAwesome.Sharp.IconChar.CheckSquare)
                {
                    brüt = arac + int.Parse(textBoxTC.Text);
                }
                else
                {
                    brüt = arac + int.Parse(textBoxAgirlik.Text);
                }
                tartim.BrutAgirlik = brüt;
                tartim.AracAgirlik = db.Arac.Find(int.Parse(comboBoxAracPlaka.SelectedValue.ToString())).AracDaraAgirlik;
               tartim.CariUnvan_FirmaNakliyeciId= int.Parse(comboBox1.SelectedValue.ToString());
                db.Tartim.Add(tartim);
                db.SaveChanges();
                textBoxIslemKod.Text = (db.Tartim.OrderByDescending(x => x.TartimId).FirstOrDefault().TartimId + 1).ToString();
                var tarih = db.Tartim.OrderByDescending(x => x.TartimId).FirstOrDefault().OlcumTarihi.ToString();
                arac = (int)db.Arac.Find(tartim.AracId).AracDaraAgirlik;
                

                if (db.Tartim.Count().ToString() == "0")
                {
                    textBoxGunlukIslemKod.Text = "0";
                }

                else if (DateTime.Parse(tarih).ToShortDateString() == DateTime.Today.ToShortDateString())
                {
                    textBoxGunlukIslemKod.Text = (db.Tartim.OrderByDescending(x => x.TartimId).FirstOrDefault().IslemSirasi + 1).ToString();
                }
                else if (DateTime.Parse(tarih).ToShortDateString() != DateTime.Today.ToShortDateString())
                {
                    textBoxGunlukIslemKod.Text = "1";
                }



                mesaj.Mesaj("İşlem Başarılı", FontAwesome.Sharp.IconChar.Check, System.Drawing.Color.DarkGreen);
            }

            catch (Exception ex)
            {
                mesaj.Mesaj(ex.Message, FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);

            }


        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxIslemTarihi.Text = DateTime.Now.ToString("F");
        }
        private void comboBoxAracPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxAracId.SelectedIndex=comboBoxAracPlaka.SelectedIndex;
            if (comboBoxAracPlaka.SelectedValue != null)
            {
                int id = int.Parse(comboBoxAracPlaka.SelectedValue.ToString());
                var arac = db.Arac.Find(id);
                label20.Text = arac.AracDaraAgirlik.ToString();
            }
            
           
            var trtm = db.Tartim.Where(x => x.Arac.AracPlaka == comboBoxAracPlaka.Text).OrderByDescending(x => x.TartimId).FirstOrDefault();
            if (trtm != null)
            {
                comboBoxAliciFirma.Text = trtm.CariUnvan_Firma.CariUnvan_FirmaAd;
                comboBoxMalzemeAd.Text = trtm.Malzeme.MalzemeAd;
                comboBoxSofor.Text = trtm.Sofor.SoforAdSoyad;
                comboBoxSevkYeri.Text = trtm.SevkYeri.SevkYeriAdres;
            }

        }

        private void comboBoxSofor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxSoforId.SelectedIndex = comboBoxSofor.SelectedIndex;
        }

        private void comboBoxAliciFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxAliciFirmaId.SelectedIndex = comboBoxAliciFirma.SelectedIndex;
        }

        private void comboBoxSevkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxSevkYeriId.SelectedIndex = comboBoxSevkYeri.SelectedIndex;
        }



        private void comboBoxMalzemeAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxMalzemeId.SelectedIndex = comboBoxMalzemeAd.SelectedIndex;
            if (comboBoxMalzemeAd.SelectedIndex >= 0)
            {
                int id = int.Parse(comboBoxMalzemeAd.SelectedValue.ToString());
                textBoxBirimFiyat.Text = db.Malzeme.Find(id).MalzemeBirimFiyat.ToString();

            }

        }
        private delegate void SetTextDeleg(string text);
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Thread.Sleep(500);
            string data = sp.ReadExisting();
            // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.  
            // ---- The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.  
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        }
        private void si_DataReceived(string data)
        {
            if (comboBoxAracPlaka.SelectedIndex >= 0)
            {

                int id = int.Parse((comboBoxAracPlaka.SelectedValue.ToString()));
                double? agirlik = double.Parse(data.Trim(new Char[] { ' ', 'A', 'C' }).Replace(".", ",").Replace("\r", "").TrimEnd('\r', '\n', '\t')) - db.Arac.Find(id).AracDaraAgirlik;
                textBoxAgirlik.Text = "";
                textBoxAgirlik.Text = agirlik.ToString();
                if (comboBoxMalzemeAd.SelectedIndex >= 0)
                {
                    int idd = int.Parse(comboBoxMalzemeAd.SelectedValue.ToString());
                    textBoxToplamFiyat.Text = (db.Malzeme.Find(idd).MalzemeBirimFiyat * agirlik).ToString();

                }
            }
        }





        public void TestPrinter(Printer printer, Tartim tartim)
        {
            int space = int.Parse(Properties.Settings.Default.YaziciSatir);
            if (comboBoxGonderenFirma.Text.Length > 45)
            {
                space--;
            }
            if (comboBoxAliciFirma.Text.Length > 45)
            {
                space--;
            }
            if (comboBoxSevkYeri.Text.Length > 45)
            {
                space--;
            }
            if (comboBoxSofor.Text.Length > 45)
            {
                space--;
            }
            //printer.Append(comboBoxGonderenFirma.Text);
            //printer.Separator();
            //printer.Append("İşlem Tarihi :" + textBoxIslemTarihi.Text);
            //printer.Append("Tartim Kod :" + textBoxIslemKod.Text + " Gunluk Kod :" + textBoxGunlukIslemKod.Text);
            //printer.Separator();
            //printer.Append("Alıcı Firma :" + comboBoxAliciFirma.Text);
            //printer.Append("Sofor :" + comboBoxSofor.Text + "TC:" + tartim.Sofor.SoforTC);
            //printer.Append("Arac Plaka :" + comboBoxAracPlaka.Text);
            //printer.Append("Sevk Yeri :" + comboBoxSevkYeri.Text);
            //printer.Append("Malzeme :" + comboBoxMalzemeAd.Text);
            //printer.Append("Net Agırlık :" + tartim.NetAgirlik.ToString());
            //printer.Append("Brüt Agırlık :" + brüt.ToString());
            //printer.Append("Arac Agırlık :" + arac.ToString());
            //printer.Append("Ucret  :" + tartim.Ucret.ToString());
            //printer.Separator();
            //printer.NewLines(space);
            //printer.InitializePrint();
            printer.Append(tartim.CariUnvan_Firma2.CariUnvan_FirmaAd);
            printer.Separator();
            printer.Append("İşlem Tarihi :" + tartim.OlcumTarihi.ToString());
            printer.Separator();
            printer.Append("Tartim Kod :" + tartim.TartimId.ToString() + " Gunluk Kod :" + tartim.IslemSirasi.ToString());
            printer.Separator();
            printer.Append("Alıcı Firma :" + tartim.CariUnvan_Firma.CariUnvan_FirmaAd);
            printer.Append("Sofor :" + tartim.Sofor.SoforAdSoyad + "TC:" + tartim.Sofor.SoforTC);
            printer.Append("Arac Plaka :" + tartim.Arac.AracPlaka);
            printer.Append("Sevk Yeri :" + tartim.SevkYeri.SevkYeriAdres);
            printer.Append("Malzeme :" + tartim.Malzeme.MalzemeAd);
            printer.Append("Ucret  :" + tartim.Ucret.ToString());
            printer.Separator('=');
          
            printer.Append("Brüt Agırlık :" + (tartim.NetAgirlik + tartim.Arac.AracDaraAgirlik).ToString());
            printer.Append("Arac Agırlık :" + tartim.Arac.AracDaraAgirlik.ToString());
            printer.Append("Net Agırlık :" + tartim.NetAgirlik.ToString());
            printer.Separator('=');
            printer.NewLines(space);
            printer.InitializePrint();
        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
                sp.Close();
            Araclar aracform = new Araclar();
            aracform.ShowDialog();
            var arac = db.Arac.Where(x => x.Arsiv == false).ToList();
            aracBindingSource.DataSource = arac;
            comboBoxAracId.DataSource = arac.Select(x => x.AracId).ToList();
            if (Global.sonarac != null)
                comboBoxAracPlaka.SelectedIndex = comboBoxAracPlaka.FindStringExact(Global.sonarac.AracPlaka);
            // comboBoxAracId.SelectedItem = null;
            if (!sp.IsOpen)
                sp.Open();

        }

        private void ıconPictureBox2_Click(object sender, EventArgs e)
        {
            Soforler soforform = new Soforler();
            soforform.ShowDialog();
            var sofor = db.Sofor.Where(x => x.Arsiv == false).ToList();
            soforBindingSource.DataSource = sofor;
            comboBoxSoforId.DataSource = sofor.Select(x => x.SoforId).ToList();
            if (Global.sonsofor != null)
                comboBoxSofor.SelectedIndex = comboBoxSofor.FindStringExact(Global.sonsofor.SoforAdSoyad) ;
        }

        private void ıconPictureBox3_Click(object sender, EventArgs e)
        {
            CariUnvanFirma cariform = new CariUnvanFirma();
            cariform.ShowDialog();
            var alicifirma = db.CariUnvan_Firma.Where(x => x.Arsiv == false).ToList();
            cariUnvanFirmaBindingSource.DataSource = alicifirma;
            comboBoxAliciFirmaId.DataSource = alicifirma.Select(x => x.CariUnvan_FirmaId).ToList();
            if (Global.sonfirma != null)
                comboBoxAliciFirma.SelectedIndex = comboBoxAliciFirma.FindStringExact(Global.sonfirma.CariUnvan_FirmaAd);
            else
            {
                comboBoxAliciFirma.SelectedItem = null;
            }
        }

        private void ıconPictureBox4_Click(object sender, EventArgs e)
        {
            SevkYeriForm sevkyeriform = new SevkYeriForm();
            sevkyeriform.ShowDialog();
            var sevkyeri = db.SevkYeri.Where(x => x.Arsiv == false).ToList();
            sevkYeriBindingSource.DataSource = sevkyeri;
            comboBoxSevkYeriId.DataSource = sevkyeri.Select(x => x.SevkYeriId).ToList();
            if (Global.sonsevkyeri != null)
                comboBoxSevkYeri.SelectedIndex = comboBoxSevkYeri.FindStringExact(Global.sonsevkyeri.SevkYeriAdres);
        }

        private void ıconPictureBox5_Click(object sender, EventArgs e)
        {
            Malzemeler malzemeler = new Malzemeler();
            malzemeler.ShowDialog();
            var malzeme = db.Malzeme.Where(x => x.Arsiv == false).ToList();
            malzemeBindingSource.DataSource = malzeme;
            comboBoxMalzemeId.DataSource = malzeme.Select(x => x.MalzemeId).ToList();
            if (Global.sonmalzeme != null)
                comboBoxMalzemeAd.SelectedIndex = comboBoxMalzemeAd.FindStringExact( Global.sonmalzeme.MalzemeAd);
            int id = int.Parse(comboBoxMalzemeId.Text);
            textBoxBirimFiyat.Text = db.Malzeme.Find(id).MalzemeBirimFiyat.ToString();
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

        private void textBoxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            if (tartim == null)
            {
                MessageBox.Show("Kayıtlı Veri Yok");
            }
            else
            {
                Printer printer = new Printer(Settings.Default.Printer, codepage: "cp857");
                printer.Clear();
                TestPrinter(printer, tartim);
                printer.PrintDocument();
            }
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            if (tartim == null)
            {
                MessageBox.Show("Kayıtlı Veri Yok");
            }
            else
            {
                Printer printer = new Printer(Settings.Default.Printer, codepage: "cp857");
                printer.Clear();
                TestPrinter(printer, tartim);
                printer.PrintDocument();
                printer = new Printer(Settings.Default.Printer, codepage: "cp857");
                printer.Clear();
                TestPrinter(printer, tartim);
                printer.PrintDocument();
            }
        }

        private void BtnFormTemizle_Click(object sender, EventArgs e)
        {

            comboBoxAliciFirma.SelectedItem = null;
            comboBoxAracPlaka.SelectedItem = null;
            comboBoxSevkYeri.SelectedItem = null;
            comboBoxSofor.SelectedItem = null;
            comboBoxMalzemeAd.SelectedItem = null;
            AgirlikEl();
        }

        private void ıconPictureBox7_Click(object sender, EventArgs e)
        {
            CariUnvanFirma cariform = new CariUnvanFirma();
            cariform.ShowDialog();
            var alicifirma = db.CariUnvan_Firma.Where(x => x.Arsiv == false).ToList();
            cariUnvanFirmaBindingSource.DataSource = alicifirma;
            comboBoxAliciFirmaId.DataSource = alicifirma.Select(x => x.CariUnvan_FirmaId).ToList();
            if (Global.sonfirma != null)
                comboBox1.SelectedIndex = comboBox1.FindStringExact(Global.sonfirma.CariUnvan_FirmaAd);
            else
            {
                comboBox1.SelectedItem = null;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
