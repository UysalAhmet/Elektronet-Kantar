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
    public partial class MesajKutusu : Form
    {
        public MesajKutusu()
        {
            InitializeComponent();
        }
        public bool Mesaj(string mesaj, FontAwesome.Sharp.IconChar icon, System.Drawing.Color renk)
        {
            labelMesaj.Text = mesaj;
            ıconPictureBox1.IconChar = icon;
            ıconPictureBox1.IconColor = renk;
            this.ShowDialog();
            if(icon== FontAwesome.Sharp.IconChar.Times)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
