
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Araclar : Form
    {
        //  SerialPort sp = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
        WindowsFormsApp1Entities db = new WindowsFormsApp1Entities();
        MesajKutusu mesaj = new MesajKutusu();

        SerialPort sp;


        public Araclar()
        {
            InitializeComponent();
            aracBindingSource.DataSource = db.Arac.ToList();
        }

        private delegate void SetTextDeleg(string text);
        private void Araclar_Load(object sender, EventArgs e)
        {
            try
            {
                sp = new SerialPort(Settings.Default.PortName, int.Parse(Settings.Default.BoudWidth), (Parity)Enum.Parse(typeof(Parity), Settings.Default.ParityBit), int.Parse(Settings.Default.DataBit), (StopBits)Enum.Parse(typeof(StopBits), Settings.Default.StopBit));

            }
            catch (Exception)
            {

                MessageBox.Show("Seri Port Bağlı Değil");
            }
          

            comboBoxArac.Enabled = false;
            BtnSil.Enabled = false;
            BtnAktifEt.Enabled = false;
            comboBoxAracId.Visible = false;
            textBoxElDara.Enabled = false;
            FormTemizle();
            sp.DataReceived+= new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            if(!sp.IsOpen)
            sp.Open();


        }
        #region

        public void FormTemizle()
        {
            textBoxAracPlaka.Text = String.Empty;
            textBoxMarkaModel.Text = String.Empty;
            textBoxDaraAgirlik.Text = String.Empty;
            textBoxElDara.Text = String.Empty;
            radioButtonFirmaAraci.Checked = false;
            radioButtonYabanci.Checked = false;
            ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
            ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
            ıconPictureBoxElleGiris.IconChar = FontAwesome.Sharp.IconChar.Square;
            ıconPictureBoxElleGiris.IconColor = System.Drawing.SystemColors.ControlText;
            textBoxElDara.Enabled = false;
            comboBoxArac.Enabled = false;
            BtnSil.Enabled = false;
            BtnAktifEt.Enabled = false;
        }
        public bool ComboboxGuncelle()
        {
            var list = db.Arac.ToList();
            //comboBoxArac.DataSource = list.Select(x => x.AracPlaka).ToList();
            //comboBoxAracId.DataSource = list.Select(x => x.AracId).ToList();
            //comboBoxArac.AutoCompleteSource = AutoCompleteSource.ListItems;
            //comboBoxArac.AutoCompleteMode = AutoCompleteMode.Suggest;
            //comboBoxArac.MaxDropDownItems = 10;
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
                if (comboBoxArac.SelectedValue != null)
                {

                    int id = int.Parse(comboBoxArac.SelectedValue.ToString());
                    var arac = db.Arac.FirstOrDefault(x => x.AracId == id);
                    if (arac != null)
                    {
                        FormDoldur(arac);
                        if (arac.Arsiv == true)
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
        public void FormDoldur(Arac arac)
        {
            textBoxAracPlaka.Text = arac.AracPlaka;
            textBoxMarkaModel.Text = arac.AracMarkaModel;

            if (arac.AracTip == false)
            {
                radioButtonFirmaAraci.Checked = true;
                radioButtonYabanci.Checked = false;
            }
            else if (arac.AracTip == true)
            {
                radioButtonFirmaAraci.Checked = false;
                radioButtonYabanci.Checked = true;
            }
            else
            {
                radioButtonFirmaAraci.Checked = false;
                radioButtonYabanci.Checked = false;
            }
            textBoxElDara.Text = arac.AracDaraAgirlik.ToString();
            textBoxDaraAgirlik.Text = arac.AracDaraAgirlik.ToString();

        }



        #endregion



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
            var arac = db.Arac.FirstOrDefault(x => x.AracId == id);
            if (arac != null)
            {
                try
                {
                    arac.Arsiv = true;
                    db.Entry(arac).State = System.Data.Entity.EntityState.Modified;
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
            var arac = db.Arac.Find(id);
            try
            {
                arac.Arsiv = false;
                db.Entry(arac).State = System.Data.Entity.EntityState.Modified;
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
                    int id = int.Parse(comboBoxArac.SelectedValue.ToString());
                    var arac = db.Arac.Find(id);
                    arac.AracPlaka = textBoxAracPlaka.Text;
                    arac.AracMarkaModel = textBoxMarkaModel.Text;
                    if (ıconPictureBoxElleGiris.IconChar == FontAwesome.Sharp.IconChar.CheckSquare)
                    {
                        arac.AracDaraAgirlik = double.Parse(textBoxElDara.Text.Replace(".", ","));
                    }
                    else
                    {
                        arac.AracDaraAgirlik = double.Parse(textBoxDaraAgirlik.Text.Replace(".", ","));
                    }
                    if (radioButtonFirmaAraci.Checked == true)
                    {
                        arac.AracTip = false;
                    }
                    else if (radioButtonYabanci.Checked == true)
                    {
                        arac.AracTip = true;
                    }
                    else
                    {
                        arac.AracTip = false;
                    }
                    arac.AracDorsePlaka = textBox1.Text;
                    arac.Arsiv = false;
                    db.Entry(arac).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Global.sonarac = arac;

                }
                else
                {
                    var arackontrol = db.Arac.FirstOrDefault(x => x.AracPlaka == textBoxAracPlaka.Text);

                    if (arackontrol == null)
                    {
                        var arac = new Arac();
                        arac.AracPlaka = textBoxAracPlaka.Text;
                        arac.AracMarkaModel = textBoxMarkaModel.Text;
                        if (ıconPictureBoxElleGiris.IconChar == FontAwesome.Sharp.IconChar.CheckSquare)
                        {
                            arac.AracDaraAgirlik = double.Parse(textBoxElDara.Text.Replace(".", ","));
                        }
                        else
                        {
                            arac.AracDaraAgirlik = double.Parse(textBoxDaraAgirlik.Text.Replace(".", ","));
                        }
                        if (radioButtonFirmaAraci.Checked == true)
                        {
                            arac.AracTip = false;
                        }
                        else if (radioButtonYabanci.Checked == true)
                        {
                            arac.AracTip = true;
                        }
                        else
                        {
                            arac.AracTip = false;
                        }
                        arac.AracDorsePlaka = textBox1.Text;
                        arac.Arsiv = false;
                        db.Arac.Add(arac);
                        db.SaveChanges();
                        Global.sonarac = arac;

                    }
                    else
                    {
                        mesaj.Mesaj("Bu Plaka Zaten Kayıtlı ", FontAwesome.Sharp.IconChar.ExclamationTriangle, System.Drawing.Color.Yellow);
                        return;
                    }

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
            //comboBoxAracId.SelectedIndex = comboBoxArac.SelectedIndex;
            EkleSil();
        }

        private void ıconPictureBoxElleGiris_Click(object sender, EventArgs e)
        {
            if (ıconPictureBoxElleGiris.IconChar == FontAwesome.Sharp.IconChar.Square)
            {
                ıconPictureBoxElleGiris.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                ıconPictureBoxElleGiris.IconColor = System.Drawing.Color.DarkGreen;
                textBoxElDara.Enabled = true;
            }
            else
            {
                ıconPictureBoxElleGiris.IconChar = FontAwesome.Sharp.IconChar.Square;
                ıconPictureBoxElleGiris.IconColor = System.Drawing.SystemColors.ControlText;
                textBoxElDara.Enabled = false;
            }
        }

        private void textBoxElDara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Thread.Sleep(500);
            string data =  sp.ReadExisting();
            // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.  
            // ---- The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.  
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        }
        private void si_DataReceived(string data)
        {
            textBoxDaraAgirlik.Text = "";
            textBoxDaraAgirlik.Text = data.Trim(new Char[] { ' ', 'A', 'C' }).Replace(".",",").Replace("\r","").TrimEnd('\r','\n','\t'); 
        }

        private void Araclar_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if (comboBoxArac.Enabled == true)
            {

                ıconPictureBoxGuncelle_Click(sender, e);
            }
                    sp.Close();
        }
    }
}
