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
    public partial class DatabaseSec : Form
    {
        public DatabaseSec()
        {
            InitializeComponent();
            windowsAuthentication.Checked = true;
            Login.Enabled = false;
            Password.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
                MessageBox.Show("Değişiklikler Kaydedildi");

                this.Hide();

            }
            catch (Exception)
            {

                throw;
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
    }
}
