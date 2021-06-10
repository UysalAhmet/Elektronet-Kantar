using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace WindowsFormsApp1
{
    public partial class Veritabanı : Form
    {
        MesajKutusu mesaj = new MesajKutusu();
        Server dbServer = new Server(new ServerConnection(Properties.Settings.Default.vtbn));


        public Veritabanı()
        {
            InitializeComponent();
            textBoxYedekYol.Text = Properties.Settings.Default.YedeklemeYolu;
           
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                //Init connect to sql database
                dbServer.KillAllProcesses("KantarDb");
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = "KantarDb" };
                dbBackup.Devices.AddDevice(Properties.Settings.Default.YedeklemeYolu + "\\KantarDb " + DateTime.Now.ToString("yyyy-M-d-H-m") + ".bak", DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblStatus.Text = "";
            lblPercent.Text = "%0";
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                //Update status with multiple threads
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    if (e.Error.Message.Contains("BACKUP DATABASE successfully processed "))
                    {
                        lblStatus.Text = "Veritabanı Başarılı Bir Şekilde Yedeklendi";
                        lblStatus.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        lblStatus.Text = e.Error.Message;
                        lblStatus.ForeColor = Color.Red;
                    }

                });

            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            //Update percentage, progressbar
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            lblPercent.Invoke((MethodInvoker)delegate
            {
                lblPercent.Text = $"{e.Percent}%";
            });
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (textBoxOkunanYedek.Text == "")
            {
                mesaj.Mesaj("Dosya Seçmediniz ", FontAwesome.Sharp.IconChar.ExclamationTriangle, System.Drawing.Color.Yellow);
                return;
            }
            progressBar1.Value = 0;

            try
            {

                //Init connect to sql database

                //Microsoft.SqlServer.Management.Smo.Database db = new Microsoft.SqlServer.Management.Smo.Database(dbServer, "deneme");

                //db.Drop();
                dbServer.KillAllProcesses("KantarDb");
                //dbServer = new Server(new ServerConnection("DESKTOP-JRJ4SS2\\SQLEXPRESS", "Elektronet", "123456"));
                Restore dbRestore = new Restore() { Database = "KantarDb", Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                dbRestore.Devices.AddDevice(textBoxOkunanYedek.Text, DeviceType.File);
                dbRestore.PercentComplete += DbRestore_PercentComplete;
                dbRestore.Complete += DbRestore_Complete;
                dbRestore.SqlRestoreAsync(dbServer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label5.Text = "%0";
            labelYedekOku.Text = "";
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            //Update percent text & progress bar
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();
            });
            label5.Invoke((MethodInvoker)delegate
            {
                label5.Text = $"{e.Percent}%";
            });
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                //Update status text
                labelYedekOku.Invoke((MethodInvoker)delegate
                {


                    if (e.Error.Message.Contains("RESTORE DATABASE successfully processed "))
                    {
                        labelYedekOku.Text = "Veriler Başarılı Bir Şekilde Okundu";
                        labelYedekOku.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        labelYedekOku.Text = e.Error.Message;
                        labelYedekOku.ForeColor = Color.Red;
                    }
                });
            }


        }

        private void Veritabanı_Load(object sender, EventArgs e)
        {

        }

        private void ıconButtonYedekleme_Click(object sender, EventArgs e)
        {
            //OpenFileDialog filedialog = new OpenFileDialog();
            //filedialog.FilterIndex = 1;
            //filedialog.InitialDirectory = "C:\\";
            //filedialog.Filter="bak files(*.bak)|*.bak";
            //filedialog.ShowDialog();
            //textBoxYedekYol.Text = filedialog.FileName;
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = diag.SelectedPath;  //selected folder path
                textBoxYedekYol.Text = folder;
                Properties.Settings.Default.YedeklemeYolu = diag.SelectedPath;
                Properties.Settings.Default.Save();

            }
        }

        private void ıconButtonYedektenSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.FilterIndex = 1;
            if (Properties.Settings.Default.YedeklemeYolu == null)
            {
                filedialog.InitialDirectory = "C:\\";
            }
            else
            {
                filedialog.InitialDirectory = Properties.Settings.Default.YedeklemeYolu;
            }

            filedialog.Filter = "bak files(*.bak)|*.bak";
            filedialog.ShowDialog();
            textBoxOkunanYedek.Text = filedialog.FileName;
        }

      
        //private void ıconButton1_Click(object sender, EventArgs e)
        //{

        //    //SqlConnectionStringBuilder b = new SqlConnectionStringBuilder(@"metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=data source=" + textBox1.Text + ";initial catalog=KantarDb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;");
        //    // Specify the provider name, server and database.
        //    // Specify the provider name, server and database.
        //    string providerName = "System.Data.EntityClient";
        //    string serverName = textBox1.Text;
        //    string databaseName = "KantarDb";

        //    // Initialize the connection string builder for the
        //    // underlying provider.
        //    SqlConnectionStringBuilder sqlBuilder =
        //        new SqlConnectionStringBuilder();

        //    // Set the properties for the data source.
        //    sqlBuilder.DataSource = serverName;
        //    sqlBuilder.InitialCatalog = databaseName;
        //    sqlBuilder.IntegratedSecurity = true;

        //    // Build the SqlConnection connection string.
        //    string providerString = sqlBuilder.ToString();

        //    // Initialize the EntityConnectionStringBuilder.
        //    EntityConnectionStringBuilder entityBuilder =
        //        new EntityConnectionStringBuilder();

        //    //Set the provider name.
        //    entityBuilder.Provider = providerName;

        //    // Set the provider-specific connection string.
        //    entityBuilder.ProviderConnectionString = providerString;

        //    // Set the Metadata location.
        //    entityBuilder.Metadata = @"metadata = res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl";


        //    Properties.Settings.Default.vtbn = textBox1.Text;
        //    AppSetting setting = new AppSetting();
        //    setting.SaveConnectionString("WindowsFormsApp1Entities", textBox1.Text);


        //    Properties.Settings.Default.Save();
        //    MessageBox.Show(Properties.Settings.Default.vtbn);
        //    MessageBox.Show(Properties.Settings.Default.KantarDbConnectionString);
        //}
    }
}
