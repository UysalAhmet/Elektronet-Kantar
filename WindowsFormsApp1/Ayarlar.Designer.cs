namespace WindowsFormsApp1
{
    partial class Ayarlar
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnVeritabanı = new FontAwesome.Sharp.IconButton();
            this.BtnRaporlar = new FontAwesome.Sharp.IconButton();
            this.BtnGenelAyarlar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.BtnVeritabanı);
            this.panelMenu.Controls.Add(this.BtnRaporlar);
            this.panelMenu.Controls.Add(this.BtnGenelAyarlar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // BtnVeritabanı
            // 
            this.BtnVeritabanı.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVeritabanı.FlatAppearance.BorderSize = 0;
            this.BtnVeritabanı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVeritabanı.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnVeritabanı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVeritabanı.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.BtnVeritabanı.IconColor = System.Drawing.Color.Black;
            this.BtnVeritabanı.IconSize = 25;
            this.BtnVeritabanı.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVeritabanı.Location = new System.Drawing.Point(0, 80);
            this.BtnVeritabanı.Name = "BtnVeritabanı";
            this.BtnVeritabanı.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnVeritabanı.Rotation = 0D;
            this.BtnVeritabanı.Size = new System.Drawing.Size(198, 40);
            this.BtnVeritabanı.TabIndex = 2;
            this.BtnVeritabanı.Text = "Veritabanı";
            this.BtnVeritabanı.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVeritabanı.UseVisualStyleBackColor = true;
            this.BtnVeritabanı.Click += new System.EventHandler(this.BtnVeritabanı_Click);
            // 
            // BtnRaporlar
            // 
            this.BtnRaporlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRaporlar.FlatAppearance.BorderSize = 0;
            this.BtnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRaporlar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRaporlar.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.BtnRaporlar.IconColor = System.Drawing.Color.Black;
            this.BtnRaporlar.IconSize = 25;
            this.BtnRaporlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRaporlar.Location = new System.Drawing.Point(0, 40);
            this.BtnRaporlar.Name = "BtnRaporlar";
            this.BtnRaporlar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnRaporlar.Rotation = 0D;
            this.BtnRaporlar.Size = new System.Drawing.Size(198, 40);
            this.BtnRaporlar.TabIndex = 1;
            this.BtnRaporlar.Text = "Raporlar";
            this.BtnRaporlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRaporlar.UseVisualStyleBackColor = true;
            this.BtnRaporlar.Click += new System.EventHandler(this.BtnRaporlar_Click);
            // 
            // BtnGenelAyarlar
            // 
            this.BtnGenelAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGenelAyarlar.FlatAppearance.BorderSize = 0;
            this.BtnGenelAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenelAyarlar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnGenelAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGenelAyarlar.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.BtnGenelAyarlar.IconColor = System.Drawing.Color.Black;
            this.BtnGenelAyarlar.IconSize = 25;
            this.BtnGenelAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenelAyarlar.Location = new System.Drawing.Point(0, 0);
            this.BtnGenelAyarlar.Name = "BtnGenelAyarlar";
            this.BtnGenelAyarlar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnGenelAyarlar.Rotation = 0D;
            this.BtnGenelAyarlar.Size = new System.Drawing.Size(198, 40);
            this.BtnGenelAyarlar.TabIndex = 0;
            this.BtnGenelAyarlar.Text = "Genel Ayarlar";
            this.BtnGenelAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGenelAyarlar.UseVisualStyleBackColor = true;
            this.BtnGenelAyarlar.Click += new System.EventHandler(this.BtnGenelAyarlar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 450);
            this.panel2.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(205, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(595, 450);
            this.panelDesktop.TabIndex = 3;
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ayarlar_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton BtnVeritabanı;
        private FontAwesome.Sharp.IconButton BtnRaporlar;
        private FontAwesome.Sharp.IconButton BtnGenelAyarlar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktop;
    }
}