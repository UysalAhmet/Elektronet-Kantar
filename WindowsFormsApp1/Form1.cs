using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderbtn;
        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 40);
            panelMenu.Controls.Add(leftBorderbtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.BackColor = Color.White;
            if (Global.Kullanici!=null && Global.Kullanici.Admin == true)
            {
                YeniKullanici.Visible = true;
            }
            else
            {
                YeniKullanici.Visible = false;
            }
            //panel1.BackColor = Color.FromArgb(0, Color.Black);
            //panel2.BackColor = Color.FromArgb(0, Color.Black);
            //panel3.BackColor = Color.FromArgb(0, Color.Black);
            //panel4.BackColor = Color.FromArgb(0, Color.Black);
            //panelBorderMenu.BackColor = Color.FromArgb(0, Color.Black);
            //panelDesktop.BackColor = Color.FromArgb(0, Color.Black);
            //panelMenu.BackColor = Color.FromArgb(0, Color.Black);
            //panelInformation.BackColor = Color.FromArgb(0, Color.Black);
            //panelLogo.BackColor = Color.FromArgb(0, Color.Black);
            //BtnExit.BackColor = Color.FromArgb(0, Color.Black);
            //BtnHome.BackColor = Color.FromArgb(0, Color.Black);
            //BtnMaximize.BackColor = Color.FromArgb(0, Color.Black);
            //BtnMinimize.BackColor = Color.FromArgb(0, Color.Black);
            //label1.BackColor = Color.FromArgb(0, Color.Black);
            //label2.BackColor = Color.FromArgb(0, Color.Black);
            //lblTitleChildForm.BackColor = Color.FromArgb(0, Color.Black);
            //Tanimlamalar.BackColor = Color.FromArgb(0, Color.Black);
            //Ayarlar.BackColor = Color.FromArgb(0, Color.Black);
            //AracTartım.BackColor = Color.FromArgb(0, Color.Black);

            
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
                leftBorderbtn.Location = new Point(0,  currentBtn.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();
                //Icon Currend Child
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderbtn.Visible = false;
            lblTitleChildForm.Text = "Home";
        }
        private void OpenChildForm(Form childForm)
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
            lblTitleChildForm.Text = childForm.Text;
        }
       
           
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void lblTitleChildForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Tanimlamalar_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActiveButton(sender, Color.Black);
            OpenChildForm(new Tanimlamalar());
        }

        private void AracTartım_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActiveButton(sender, Color.Black);
            OpenChildForm(new AracTartım());
        }

        private void Ayarlar_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                
                currentChildForm.Close();
            }

            ActiveButton(sender, Color.Black);
            Yetki form = new Yetki();
            form.YetkiKontrol();
            if (Global.basarili)
            {
                OpenChildForm(new Ayarlar());
            }




        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics mgraphics = e.Graphics;
            //    Pen pen = new Pen(Color.FromArgb(132, 58, 197), 1);
            //Rectangle area = new Rectangle(0,0,this.Width-1,this.Height-1);
            //LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(132, 58, 197), Color.FromArgb(123, 197, 58), LinearGradientMode.Vertical);
            //mgraphics.FillRectangle(lgb,area);
            //mgraphics.DrawRectangle(pen, area);
            //Graphics mgraphics = e.Graphics;
            //Pen pen = new Pen(Color.FromArgb(184, 183, 186), 1);
            //Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            //LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(184, 183, 186), Color.FromArgb(240, 240, 241), LinearGradientMode.Horizontal);
            //mgraphics.FillRectangle(lgb, area);
            //mgraphics.DrawRectangle(pen, area);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {
            //Graphics mgraphics = e.Graphics;
            //Pen pen = new Pen(Color.FromArgb(184, 183, 186), 1);
            //Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            //LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(184, 183, 186), Color.FromArgb(240, 240, 241), LinearGradientMode.Vertical);
            //mgraphics.FillRectangle(lgb, area);
            //mgraphics.DrawRectangle(pen, area);
        }

        private void YeniKullanici_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActiveButton(sender, Color.Black);
            OpenChildForm(new YeniKullanici());
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
