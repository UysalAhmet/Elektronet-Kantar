using ESC_POS_USB_NET.Printer;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Raporlama : Form
    {
        WindowsFormsApp1Entities db = new WindowsFormsApp1Entities();
        
        public Raporlama()
        {
            InitializeComponent();
             list = db.Tartim.ToList();
            this.datetimevalbas = DateTime.Parse(dateTimePickerbaslangic.Value.ToString());
            this.datetimevalbit = DateTime.Parse(dateTimePickerBitis.Value.ToString());

            this.sifirla();
            //var alicifirma = db.CariUnvan_Firma.ToList();
            //comboBoxAliciFirma.SelectedItem = null;
            //comboBoxAliciFirmaId.SelectedItem = null;
            //comboBoxAliciFirma.DataSource = alicifirma.Select(x => x.CariUnvan_FirmaAd).ToList();
            //comboBoxAliciFirmaId.DataSource = alicifirma.Select(x => x.CariUnvan_FirmaId).ToList();
           
            //
            //var arac = db.Arac.ToList();
            //comboBoxAracPlaka.DataSource = arac.Select(x => x.AracPlaka).ToList();
            //comboBoxAracId.DataSource = arac.Select(x => x.AracId).ToList();
            //comboBoxAracPlaka.SelectedItem = null;
            //comboBoxAracId.SelectedItem = null;
            //
            //var sofor = db.Sofor.ToList();
            //comboBoxSofor.DataSource = sofor.Select(x => x.SoforAdSoyad).ToList();
            //comboBoxSoforId.DataSource = sofor.Select(x => x.SoforId).ToList();
            //comboBoxSofor.SelectedItem = null;
            //comboBoxSoforId.SelectedItem = null;
            ////
            //var malzeme = db.Malzeme.ToList();
            //comboBoxMalzemeAd.DataSource = malzeme.Select(x => x.MalzemeAd).ToList();
            //comboBoxMalzemeId.DataSource = malzeme.Select(x => x.MalzemeId).ToList();
            //comboBoxMalzemeAd.SelectedItem = null;
            //comboBoxMalzemeId.SelectedItem = null;
            ////
            //var sevkyeri = db.SevkYeri.ToList();
            //comboBoxSevkYeri.DataSource = sevkyeri.Select(x => x.SevkYeriAdres).ToList();
            //comboBoxSevkYeriId.DataSource = sevkyeri.Select(x => x.SevkYeriId).ToList();
            //comboBoxSevkYeri.SelectedItem = null;
            //comboBoxSevkYeriId.SelectedItem = null;
            ////
            //var yetkili = db.Yetkili.ToList();
            //comboBoxYetkili.DataSource = yetkili.Select(x => x.YetkiliKullaniciAd).ToList();
            //comboBoxYetkiliId.DataSource = yetkili.Select(x => x.YetkiliId).ToList();
            //comboBoxYetkili.SelectedItem = null;
            //comboBoxYetkiliId.SelectedItem = null;
            //
            tartimBindingSource.DataSource = list;
            aracBindingSource.DataSource = db.Arac.ToList();
            soforBindingSource.DataSource = db.Sofor.ToList();
            cariUnvanFirmaBindingSource.DataSource = db.CariUnvan_Firma.ToList();
            malzemeBindingSource.DataSource = db.Malzeme.ToList();
            sevkYeriBindingSource.DataSource = db.SevkYeri.ToList();
            yetkiliBindingSource.DataSource = db.Yetkili.ToList();
           


        }
        List<Tartim> list;
        struct DataParameter
        {
           
            public string Filename;
            public List<Tartim> liste;
        }
        DataParameter _inputParameter;
        private void comboBoxAracPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxAracId.SelectedIndex = comboBoxAracPlaka.SelectedIndex;
            //if (comboBoxAracPlaka.SelectedItem!=null)
            //{
            //    int id = int.Parse(comboBoxAracId.Text);
            //    list = list.Where(x => x.AracId == id).ToList();
            //    tartimBindingSource.DataSource = list;
            //    dataGridView1.Refresh();
            //}
           
        }

        private void comboBoxSofor_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBoxSoforId.SelectedIndex = comboBoxSofor.SelectedIndex;
            //if (comboBoxSofor.SelectedItem != null)
            //{
            //    int id = int.Parse(comboBoxSoforId.Text);
            //    list = list.Where(x => x.SoforId == id).ToList();
            //    tartimBindingSource.DataSource = list;
            //    dataGridView1.Refresh();
            //}
        }
        private void comboBoxYetkili_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  comboBoxYetkiliId.SelectedIndex = comboBoxYetkili.SelectedIndex;
        }
        private void comboBoxAliciFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  comboBoxAliciFirmaId.SelectedIndex = comboBoxAliciFirma.SelectedIndex;
           // comboBoxAliciFirmaId.SelectedIndex = comboBoxAliciFirma.SelectedIndex;
        }

        private void comboBoxSevkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBoxSevkYeriId.SelectedIndex = comboBoxSevkYeri.SelectedIndex;
        }



        private void comboBoxMalzemeAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxMalzemeId.SelectedIndex = comboBoxMalzemeAd.SelectedIndex;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            list = db.Tartim.ToList();
            if (comboBoxAliciFirma.SelectedItem != null)
            {
                int id = int.Parse(comboBoxAliciFirma.SelectedValue.ToString());
                list = list.Where(x => x.CariUnvan_FirmaAliciId == id).ToList();
              
            }
            if (comboBoxAracPlaka.SelectedItem != null)
            {
                int id = int.Parse(comboBoxAracPlaka.SelectedValue.ToString());
               
                list = list.Where(x => x.AracId == id).ToList();
            }
            if (comboBoxSofor.SelectedItem != null)
            {
                int id = int.Parse(comboBoxSofor.SelectedValue.ToString());
                list = list.Where(x => x.SoforId == id).ToList();
            }
            if (comboBoxMalzemeAd.SelectedItem != null)
            {
                int id = int.Parse(comboBoxMalzemeAd.SelectedValue.ToString());
                list = list.Where(x => x.MalzemeId == id).ToList();
            }
            if (comboBoxSevkYeri.SelectedItem != null)
            {
                int id = int.Parse(comboBoxSevkYeri.SelectedValue.ToString());
                list = list.Where(x => x.SevkYeriId == id).ToList();
            }
            if (comboBoxYetkili.SelectedItem != null)
            {
                int id = int.Parse(comboBoxYetkili.SelectedValue.ToString());
                list = list.Where(x => x.YetkiliId == id).ToList();
            }
            list = list.Where(t => t.OlcumTarihi >= DateTime.Parse(dateTimePickerbaslangic.Text) && t.OlcumTarihi <= DateTime.Parse(dateTimePickerBitis.Text).AddDays(1)).ToList();
            tartimBindingSource.DataSource = list;
            dataGridView1.Refresh();
           
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                List<Tartim> lst = ((DataParameter)e.Argument).liste;
                string fileName = ((DataParameter)e.Argument).Filename;
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)excel.ActiveSheet;
                excel.Visible = false;
                int index = 1;
                int proccess = lst.Count;
                ws.Cells[1, 1] = "Tartım Kod";
                ws.Cells[1, 2] = "Arac Plaka";
                ws.Cells[1, 3] = "Islem Sirasi";
                ws.Cells[1, 4] = "Olcum Tarihi";
                ws.Cells[1, 5] = "Alici Firma";
                ws.Cells[1, 6] = "Malzeme";
                ws.Cells[1, 7] = "Sevk Yeri";
                ws.Cells[1, 8] = "Sofor";
                ws.Cells[1, 9] = "Net Agirlik";
                ws.Cells[1, 10] = "Brüt Agirlik";
                ws.Cells[1, 11] = "Dara Agirlik";
                ws.Cells[1, 12] = "Ucret";
                ws.Cells[1, 13] = "Gonderen Firma";
                ws.Cells[1, 14] = "Nakliyeci Firma";
                ws.Cells[1, 15] = "Islem Yapan Yetkili";
                foreach (var item in lst)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / proccess);
                        ws.Cells[index, 1] = item.TartimId.ToString();
                        ws.Cells[index, 2] = item.Arac.AracPlaka.ToString();
                        ws.Cells[index, 3] = item.IslemSirasi.ToString();
                        ws.Cells[index, 4] = item.OlcumTarihi.ToString();
                        ws.Cells[index, 5] = item.CariUnvan_Firma.CariUnvan_FirmaAd.ToString();
                        ws.Cells[index, 6] = item.Malzeme.MalzemeAd.ToString();
                        ws.Cells[index, 7] = item.SevkYeri.SevkYeriAdres.ToString();
                        ws.Cells[index, 8] = item.Sofor.SoforAdSoyad.ToString();
                        ws.Cells[index, 9] = item.NetAgirlik.ToString();
                        ws.Cells[index, 10] = (item.NetAgirlik + item.Arac.AracDaraAgirlik).ToString();
                        ws.Cells[index, 11] = item.Arac.AracDaraAgirlik.ToString();
                        ws.Cells[index, 12] = "TL " + item.Ucret.ToString();
                        ws.Cells[index, 13] = item.CariUnvan_Firma2.CariUnvan_FirmaAd.ToString();
                        if (item.CariUnvan_Firma1 != null)
                        {
                            ws.Cells[index, 14] = item.CariUnvan_Firma1.CariUnvan_FirmaAd.ToString();
                        }
                        else
                        {
                            ws.Cells[index, 14] = "Yok";
                        }

                        if (item.Yetkili == null)
                        {
                            ws.Cells[index, 15] = "Yok";
                        }
                        else
                        {
                            ws.Cells[index, 15] = item.Yetkili.YetkiliKullaniciAd.ToString();
                        }
                    }
                }
                ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                excel.Quit();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text="%"+e.ProgressPercentage.ToString();
            progressBar1.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
                //label1.Text = "Verileriniz Başarı ile Excel'e Aktarılmıştır";
            }
        }

        private void BtnFormTemizle_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                return;
            }
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter="Excel Workbook|*.xls"})
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _inputParameter.Filename = sfd.FileName;
                    _inputParameter.liste = tartimBindingSource.DataSource as List<Tartim>;
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 0;
                    backgroundWorker.RunWorkerAsync(_inputParameter);
                }
            }
        }

        private void dateTimePickerbaslangic_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePickerbaslangic.Value.ToString("F"));
            //var tarih = db.Tartim.FirstOrDefault(c => c.TartimId == 50).OlcumTarihi;
            //MessageBox.Show(tarih.Value.ToString("F"));
        }

       
        public void sifirla()
        {
            dateTimePickerbaslangic.Value =datetimevalbas;
            dateTimePickerBitis.Value =datetimevalbit;
            comboBoxAliciFirma.SelectedItem = null;
            comboBoxAliciFirmaId.SelectedItem = null;
            //
            comboBoxAracPlaka.SelectedItem = null;
            comboBoxAracId.SelectedItem = null;
            //
            comboBoxSofor.SelectedItem = null;
            comboBoxSoforId.SelectedItem = null;
            //
            comboBoxMalzemeAd.SelectedItem = null;
            comboBoxMalzemeId.SelectedItem = null;
            //
            comboBoxSevkYeri.SelectedItem = null;
            comboBoxSevkYeriId.SelectedItem = null;
            //
            comboBoxYetkili.SelectedItem = null;
            comboBoxYetkiliId.SelectedItem = null;
        }
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            this.sifirla();
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                db.Tartim.Remove(db.Tartim.Find(id));
                db.SaveChanges();
                dataGridView1.Update();
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            var tartim = db.Tartim.Find(id);
            Printer printer = new Printer(Settings.Default.Printer, codepage: "cp857");
            TestPrinter(printer, tartim);
            printer.PrintDocument();
        }
        public void TestPrinter(Printer printer, Tartim tartim)
        {
            int space = int.Parse(Properties.Settings.Default.YaziciSatir);
            if (tartim.CariUnvan_Firma.CariUnvan_FirmaAd.Length > 45)
            {
                space--;
            }
            if (tartim.CariUnvan_Firma1.CariUnvan_FirmaAd.Length > 45)
            {
                space--;
            }
            if (tartim.SevkYeri.SevkYeriAdres.Length > 45)
            {
                space--;
            }
            if (tartim.Sofor.SoforAdSoyad.Length > 45)
            {
                space--;
            }
            printer.Append(tartim.CariUnvan_Firma2.CariUnvan_FirmaAd);
            printer.Separator();
            printer.Append("İşlem Tarihi :" +tartim.OlcumTarihi.ToString());
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
            
            printer.Append("Brüt Agırlık :" +(tartim.NetAgirlik+tartim.Arac.AracDaraAgirlik).ToString());
            printer.Append("Arac Agırlık :" + tartim.Arac.AracDaraAgirlik.ToString());
            printer.Append("Net Agırlık :" + tartim.NetAgirlik.ToString());
            printer.Separator('=');
            printer.NewLines(space);
            printer.InitializePrint();
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            TartimGuncelle tartimguncelle = new TartimGuncelle(id);
            tartimguncelle.ShowDialog();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        public DateTime datetimevalbas;
        public DateTime datetimevalbit;
        private void Raporlama_Load(object sender, EventArgs e)
        {
            this.sifirla();
        }
    }
}
