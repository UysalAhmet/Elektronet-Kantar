using FontAwesome.Sharp;
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
    public partial class Tanimlamalar : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderbtn;
        public static Form currentChildForm;
        MesajKutusu mesaj = new MesajKutusu();
        public Tanimlamalar()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 40);
            panelMenu.Controls.Add(leftBorderbtn);
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(165, 175, 187);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            try
            {
                //open only form
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }
                currentChildForm = childForm;
                //End
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception )
            {
               //mesaj.Mesaj(ex.Message, FontAwesome.Sharp.IconChar.ExclamationTriangle, System.Drawing.Color.Yellow);
               // panelDesktop.Controls.Remove(childForm);
               // return;
            }
            
            
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(143, 149, 158);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderbtn.BackColor = color;
                leftBorderbtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();
                //Icon Currend Child
            }
        }

        private void BtnCariUnvanFirma_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Black);
            OpenChildForm(new CariUnvanFirma());
        }

        private void BtnMalzeme_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Black);
            OpenChildForm(new Malzemeler());
        }

        private void BtnSevkYeri_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActiveButton(sender, Color.Black);
            OpenChildForm(new SevkYeriForm());
        }

        private void BtnSofor_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Black);
            OpenChildForm(new Soforler());
        }

        private void BtnArac_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Black);
            OpenChildForm(new Araclar());
        }
    }
}
