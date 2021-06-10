using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GenelAyarlar : Form
    {
        WindowsFormsApp1Entities db = new WindowsFormsApp1Entities();
        public GenelAyarlar()
        {
            try
            {
                InitializeComponent();
                String pkInstalledPrinters;
                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                    comboBoxYazicilar.Items.Add(pkInstalledPrinters);
                }
                comboBoxKantarPort.Items.AddRange(SerialPort.GetPortNames());
                comboBoxBoudWidth.Items.AddRange(new string[]{
                "110","300","1200","2400","4800","9600","19200","38400","57600","115200"});
                comboBoxDataBit.Items.AddRange(new string[] { "5", "6", "7", "8" });
                comboBoxStopBit.Items.AddRange(new string[] { "One", "Two" });
                comboBoxParityBit.Items.AddRange(new string[] { "None", "Odd", "Even" });

                textBox1.Text = Properties.Settings.Default.YaziciSatir;
                if(db.CariUnvan_Firma.Where(x => x.Arsiv == false).Select(x => x.CariUnvan_FirmaAd).ToArray() != null)
                {
                    comboBoxFirma.Items.AddRange(db.CariUnvan_Firma.Where(x => x.Arsiv == false).Select(x => x.CariUnvan_FirmaAd).ToArray());
                    foreach (var item in db.CariUnvan_Firma.Where(x => x.Arsiv == false).Select(x => x.CariUnvan_FirmaId).ToList())
                    {
                        comboBoxGonderenId.Items.Add(item.ToString());
                    }
                }
               

                //comboBoxBoudWidth.SelectedIndex = 0;
                //if (comboBoxKantarPort.Items.Count > 0)
                //comboBoxKantarPort.SelectedIndex = 0;
                //comboBoxParityBit.SelectedIndex = 0;
                //comboBoxStopBit.SelectedIndex = 0;
                //comboBoxDataBit.SelectedIndex = 0;
                //if (Properties.Settings.Default.GondericiFirma == "Empty")
                //{
                //    comboBoxFirma.SelectedItem = null;
                //}
                //else
                //{

                if (Properties.Settings.Default.GondericiFirma != "Empty")
                {

                    int id = int.Parse(Properties.Settings.Default.GondericiFirma);
                    if(db.CariUnvan_Firma.FirstOrDefault(x=>x.CariUnvan_FirmaId==id)!=null)
                    comboBoxFirma.SelectedItem = db.CariUnvan_Firma.Find(id).CariUnvan_FirmaAd;
                }



                comboBoxParityBit.SelectedItem = Properties.Settings.Default.ParityBit;
                comboBoxStopBit.SelectedItem = Properties.Settings.Default.StopBit;
                comboBoxBoudWidth.SelectedItem = Properties.Settings.Default.BoudWidth;
                comboBoxDataBit.SelectedItem = Properties.Settings.Default.DataBit;
                comboBoxKantarPort.SelectedItem = Properties.Settings.Default.PortName;
                comboBoxYazicilar.SelectedItem = Properties.Settings.Default.Printer;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
           

        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PortName = comboBoxKantarPort.Text;
            Properties.Settings.Default.BoudWidth = comboBoxBoudWidth.Text;
            Properties.Settings.Default.DataBit = comboBoxDataBit.Text;
            Properties.Settings.Default.ParityBit = comboBoxParityBit.Text;
            Properties.Settings.Default.StopBit = comboBoxStopBit.Text;
            Properties.Settings.Default.Printer = comboBoxYazicilar.Text;
            Properties.Settings.Default.GondericiFirma = comboBoxGonderenId.Text;
            Properties.Settings.Default.YaziciSatir = textBox1.Text;

            Properties.Settings.Default.Save();
           
        }

        private void BtnFormTemizle_Click(object sender, EventArgs e)
        {
           
            Properties.Settings.Default.PortName = String.Empty;
            Properties.Settings.Default.BoudWidth = String.Empty;
            Properties.Settings.Default.DataBit = String.Empty;
            Properties.Settings.Default.ParityBit = String.Empty;
            Properties.Settings.Default.StopBit = String.Empty;
            Properties.Settings.Default.Printer = String.Empty;
            Properties.Settings.Default.GondericiFirma = String.Empty;
            Properties.Settings.Default.Save();
            comboBoxParityBit.SelectedItem = null;
            comboBoxStopBit.SelectedItem = null;
            comboBoxBoudWidth.SelectedItem = null;
            comboBoxDataBit.SelectedItem = null;
            comboBoxKantarPort.SelectedItem = null;
            comboBoxYazicilar.SelectedItem = null;
            comboBoxFirma.SelectedItem = null;
            comboBoxGonderenId.SelectedItem = null;
        }

        private void comboBoxFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGonderenId.SelectedIndex = comboBoxFirma.SelectedIndex;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void GenelAyarlar_Load(object sender, EventArgs e)
        {

        }
    }
}
