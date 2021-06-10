using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class AppSetting
    {
        Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        //Get connection string from App.Config file
        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        //Save connection string to App.config file
        public void SaveConnectionString(string key, string value)
        {
            try
            {
                config.ConnectionStrings.ConnectionStrings[key].ConnectionString = this.GetConnectionString(key).Replace(Properties.Settings.Default.vtbn/*@"DESKTOP-7M3KNQU\SQLEXPRESS"*/, value);
                // config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.EntityClient";
                 Properties.Settings.Default.vtbn = value;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
                config.Save(ConfigurationSaveMode.Modified);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }

    }
}
