using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Lisans : Form
    {
		string hash;
		public Lisans()
        {
            InitializeComponent();
            using (SHA1 sha1Hash = SHA1.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(Properties.Settings.Default.Bilgisayar);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                 hash = BitConverter.ToString(hashBytes).Replace("-",String.Empty);
				windowsAuthentication.Checked = true;
				Login.Enabled = false;
				Password.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
				if (textBox1.Text.ToUpper() == hash)
				{
					AppSetting setting = new AppSetting();
					if (windowsAuthentication.Checked)
					{
						setting.SaveConnectionString("WindowsFormsApp1Entities", Server.Text);
						//Properties.Settings.Default.vtbn = Server.Text;
					}
					else
					{
						setting.SaveConnectionString("WindowsFormsApp1Entities", Server.Text + ";" + "User Id=" + Login.Text + ";Password=" + Password.Text);
						//Properties.Settings.Default.vtbn = Server.Text + ";" + "User Id=" + Login.Text + ";Password=" + Password.Text + ";";
					}


					Properties.Settings.Default.LisansKey = hash;
					Properties.Settings.Default.Save();
					Properties.Settings.Default.Upgrade();
					MessageBox.Show("Aktifleştirildi");

					this.Hide();

				}
				else
				{
					MessageBox.Show("Kodunuz Hatalı");
				}
				

				//Properties.Settings.Default.Save();
				
            }
            catch (Exception ex)
            {

				MessageBox.Show(ex.Message);
            }
           
        }

        private void windowsAuthentication_CheckStateChanged(object sender, EventArgs e)
        {
            if (windowsAuthentication.Checked)
            {

				Login.Enabled = false;
				Password.Enabled = false;
			}
            else
            {
				Login.Enabled = true;
				Password.Enabled = true;
			}
        }

        private void Lisans_FormClosing(object sender, FormClosingEventArgs e)
        {
			Properties.Settings.Default.Save();
			Properties.Settings.Default.Upgrade();

		}
    }
}
