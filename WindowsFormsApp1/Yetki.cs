using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Yetki : Form
    {
        WindowsFormsApp1Entities db = new WindowsFormsApp1Entities();
        public MesajKutusu mesaj = new MesajKutusu();
        public Yetki()
        {
            InitializeComponent();
            using (SHA1 sha1Hash = SHA1.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(Properties.Settings.Default.Bilgisayar);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                if (hash!=Properties.Settings.Default.LisansKey.ToUpper()/*Properties.Settings.Default.LisansKey=="Empty" || Properties.Settings.Default.LisansKey == "" || Properties.Settings.Default.LisansKey == null*/)
                {
                    ıconButton2.Visible = true;
                    ıconButton1.Visible = false;
                    ıconPictureBox3.Visible = false;
                    ıconPictureBox2.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    ıconButton3.Visible = false;

                }
                else
                {
                    ıconButton2.Visible = false;
                    ıconButton1.Visible = true;
                    ıconButton3.Visible = true;
                }

            }
          
        }

        public void YetkiKontrol()
        {
            this.ShowDialog();
        }
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            var yetkili = new Yetkili();
            yetkili.YetkiliKullaniciAd = textBox1.Text;
            yetkili.YetkiliSifre = textBox2.Text;
           
            if (Global.Kullanici == null)
            {
              
                if (Global.Login(yetkili))
                {

                    Global.Kullanici = db.Yetkili.FirstOrDefault(x => x.YetkiliKullaniciAd == yetkili.YetkiliKullaniciAd && x.YetkiliSifre == yetkili.YetkiliSifre); ;
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
                else
                {
                    mesaj.Mesaj("Bilgileriniz Uyuşmuyor", FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
                }
            }
            else
            {
                if (Global.Login(yetkili))
                {
                    Global.basarili = true;
                    this.Close();

                }
                else
                {
                    mesaj.Mesaj("Bilgileriniz Uyuşmuyor", FontAwesome.Sharp.IconChar.Times, System.Drawing.Color.DarkRed);
                }
            }
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ıconButton1_Click(this, new EventArgs());
            }
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
           // Properties.Settings.Default.Bilgisayar = Environment.MachineName;
            Lisans form = new Lisans();
            form.ShowDialog();

            Application.Restart();
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            DatabaseSec form = new DatabaseSec();
            form.ShowDialog();
            Application.Restart();
        }
    }
}
