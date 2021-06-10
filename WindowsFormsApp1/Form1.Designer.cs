namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.YeniKullanici = new FontAwesome.Sharp.IconButton();
            this.Ayarlar = new FontAwesome.Sharp.IconButton();
            this.AracTartım = new FontAwesome.Sharp.IconButton();
            this.Tanimlamalar = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBorderMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnExit = new FontAwesome.Sharp.IconPictureBox();
            this.BtnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.BtnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelInformation.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.ıconButton1);
            this.panelMenu.Controls.Add(this.YeniKullanici);
            this.panelMenu.Controls.Add(this.Ayarlar);
            this.panelMenu.Controls.Add(this.AracTartım);
            this.panelMenu.Controls.Add(this.Tanimlamalar);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.panelInformation);
            this.panelMenu.Controls.Add(this.panelBorderMenu);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 739);
            this.panelMenu.TabIndex = 0;
            // 
            // ıconButton1
            // 
            this.ıconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ıconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ıconButton1.IconColor = System.Drawing.Color.Black;
            this.ıconButton1.IconSize = 25;
            this.ıconButton1.Location = new System.Drawing.Point(0, 336);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ıconButton1.Rotation = 0D;
            this.ıconButton1.Size = new System.Drawing.Size(218, 40);
            this.ıconButton1.TabIndex = 9;
            this.ıconButton1.Text = "Çıkış";
            this.ıconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton1.UseVisualStyleBackColor = false;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // YeniKullanici
            // 
            this.YeniKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.YeniKullanici.Dock = System.Windows.Forms.DockStyle.Top;
            this.YeniKullanici.FlatAppearance.BorderSize = 0;
            this.YeniKullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YeniKullanici.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.YeniKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YeniKullanici.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.YeniKullanici.IconColor = System.Drawing.Color.Black;
            this.YeniKullanici.IconSize = 25;
            this.YeniKullanici.Location = new System.Drawing.Point(0, 296);
            this.YeniKullanici.Name = "YeniKullanici";
            this.YeniKullanici.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.YeniKullanici.Rotation = 0D;
            this.YeniKullanici.Size = new System.Drawing.Size(218, 40);
            this.YeniKullanici.TabIndex = 8;
            this.YeniKullanici.Text = "Yeni Kullanıcı";
            this.YeniKullanici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.YeniKullanici.UseVisualStyleBackColor = false;
            this.YeniKullanici.Click += new System.EventHandler(this.YeniKullanici_Click);
            // 
            // Ayarlar
            // 
            this.Ayarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.Ayarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ayarlar.FlatAppearance.BorderSize = 0;
            this.Ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ayarlar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Ayarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ayarlar.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.Ayarlar.IconColor = System.Drawing.Color.Black;
            this.Ayarlar.IconSize = 25;
            this.Ayarlar.Location = new System.Drawing.Point(0, 256);
            this.Ayarlar.Name = "Ayarlar";
            this.Ayarlar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Ayarlar.Rotation = 0D;
            this.Ayarlar.Size = new System.Drawing.Size(218, 40);
            this.Ayarlar.TabIndex = 7;
            this.Ayarlar.Text = "Ayarlar";
            this.Ayarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ayarlar.UseVisualStyleBackColor = false;
            this.Ayarlar.Click += new System.EventHandler(this.Ayarlar_Click);
            // 
            // AracTartım
            // 
            this.AracTartım.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.AracTartım.Dock = System.Windows.Forms.DockStyle.Top;
            this.AracTartım.FlatAppearance.BorderSize = 0;
            this.AracTartım.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AracTartım.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AracTartım.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracTartım.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            this.AracTartım.IconColor = System.Drawing.Color.Black;
            this.AracTartım.IconSize = 25;
            this.AracTartım.Location = new System.Drawing.Point(0, 216);
            this.AracTartım.Name = "AracTartım";
            this.AracTartım.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AracTartım.Rotation = 0D;
            this.AracTartım.Size = new System.Drawing.Size(218, 40);
            this.AracTartım.TabIndex = 4;
            this.AracTartım.Text = "Araç Tartım";
            this.AracTartım.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AracTartım.UseVisualStyleBackColor = false;
            this.AracTartım.Click += new System.EventHandler(this.AracTartım_Click);
            // 
            // Tanimlamalar
            // 
            this.Tanimlamalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.Tanimlamalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tanimlamalar.FlatAppearance.BorderSize = 0;
            this.Tanimlamalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tanimlamalar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Tanimlamalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tanimlamalar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.Tanimlamalar.IconColor = System.Drawing.Color.Black;
            this.Tanimlamalar.IconSize = 25;
            this.Tanimlamalar.Location = new System.Drawing.Point(0, 176);
            this.Tanimlamalar.Name = "Tanimlamalar";
            this.Tanimlamalar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Tanimlamalar.Rotation = 0D;
            this.Tanimlamalar.Size = new System.Drawing.Size(218, 40);
            this.Tanimlamalar.TabIndex = 3;
            this.Tanimlamalar.Text = "Tanımlamalar";
            this.Tanimlamalar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Tanimlamalar.UseVisualStyleBackColor = false;
            this.Tanimlamalar.Click += new System.EventHandler(this.Tanimlamalar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 605);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 5);
            this.panel4.TabIndex = 2;
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.panelInformation.Controls.Add(this.label1);
            this.panelInformation.Controls.Add(this.label2);
            this.panelInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInformation.Location = new System.Drawing.Point(0, 610);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(218, 127);
            this.panelInformation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "mali@elektronet.net";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "Elektronet Güvenlik ve Otomasyon Sistemleri";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBorderMenu
            // 
            this.panelBorderMenu.BackColor = System.Drawing.Color.Black;
            this.panelBorderMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorderMenu.Location = new System.Drawing.Point(0, 171);
            this.panelBorderMenu.Name = "panelBorderMenu";
            this.panelBorderMenu.Size = new System.Drawing.Size(218, 5);
            this.panelBorderMenu.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.panelLogo.Controls.Add(this.BtnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(218, 171);
            this.panelLogo.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(218, 171);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 41);
            this.panel1.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.lblTitleChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitleChildForm.Location = new System.Drawing.Point(0, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(900, 39);
            this.lblTitleChildForm.TabIndex = 6;
            this.lblTitleChildForm.Text = "Home";
            this.lblTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitleChildForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitleChildForm_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.panel2.Controls.Add(this.BtnExit);
            this.panel2.Controls.Add(this.BtnMinimize);
            this.panel2.Controls.Add(this.BtnMaximize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(900, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 39);
            this.panel2.TabIndex = 5;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnExit.IconColor = System.Drawing.SystemColors.ControlText;
            this.BtnExit.Location = new System.Drawing.Point(79, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(32, 32);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimize.IconColor = System.Drawing.SystemColors.ControlText;
            this.BtnMinimize.Location = new System.Drawing.Point(3, 3);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(32, 32);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.BtnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximize.IconColor = System.Drawing.SystemColors.ControlText;
            this.BtnMaximize.Location = new System.Drawing.Point(41, 3);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(32, 32);
            this.BtnMaximize.TabIndex = 3;
            this.BtnMaximize.TabStop = false;
            this.BtnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 5);
            this.panel3.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 46);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1025, 693);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1245, 739);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.Text = "WindowsFormsApp1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panelMenu.ResumeLayout(false);
            this.panelInformation.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBorderMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox BtnExit;
        private FontAwesome.Sharp.IconPictureBox BtnMaximize;
        private FontAwesome.Sharp.IconPictureBox BtnMinimize;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton Tanimlamalar;
        private FontAwesome.Sharp.IconButton AracTartım;
        private FontAwesome.Sharp.IconButton Ayarlar;
        private FontAwesome.Sharp.IconButton YeniKullanici;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}

