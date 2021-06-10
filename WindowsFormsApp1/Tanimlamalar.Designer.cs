namespace WindowsFormsApp1
{
    partial class Tanimlamalar
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
            this.BtnArac = new FontAwesome.Sharp.IconButton();
            this.BtnSofor = new FontAwesome.Sharp.IconButton();
            this.BtnSevkYeri = new FontAwesome.Sharp.IconButton();
            this.BtnMalzeme = new FontAwesome.Sharp.IconButton();
            this.BtnCariUnvanFirma = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.BtnArac);
            this.panelMenu.Controls.Add(this.BtnSofor);
            this.panelMenu.Controls.Add(this.BtnSevkYeri);
            this.panelMenu.Controls.Add(this.BtnMalzeme);
            this.panelMenu.Controls.Add(this.BtnCariUnvanFirma);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 593);
            this.panelMenu.TabIndex = 0;
            // 
            // BtnArac
            // 
            this.BtnArac.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnArac.FlatAppearance.BorderSize = 0;
            this.BtnArac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArac.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnArac.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.BtnArac.IconColor = System.Drawing.Color.Black;
            this.BtnArac.IconSize = 25;
            this.BtnArac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnArac.Location = new System.Drawing.Point(0, 160);
            this.BtnArac.Name = "BtnArac";
            this.BtnArac.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnArac.Rotation = 0D;
            this.BtnArac.Size = new System.Drawing.Size(198, 40);
            this.BtnArac.TabIndex = 4;
            this.BtnArac.Text = "Araç";
            this.BtnArac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnArac.UseVisualStyleBackColor = true;
            this.BtnArac.Click += new System.EventHandler(this.BtnArac_Click);
            // 
            // BtnSofor
            // 
            this.BtnSofor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSofor.FlatAppearance.BorderSize = 0;
            this.BtnSofor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSofor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSofor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSofor.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BtnSofor.IconColor = System.Drawing.Color.Black;
            this.BtnSofor.IconSize = 25;
            this.BtnSofor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSofor.Location = new System.Drawing.Point(0, 120);
            this.BtnSofor.Name = "BtnSofor";
            this.BtnSofor.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnSofor.Rotation = 0D;
            this.BtnSofor.Size = new System.Drawing.Size(198, 40);
            this.BtnSofor.TabIndex = 3;
            this.BtnSofor.Text = "Şöför";
            this.BtnSofor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSofor.UseVisualStyleBackColor = true;
            this.BtnSofor.Click += new System.EventHandler(this.BtnSofor_Click);
            // 
            // BtnSevkYeri
            // 
            this.BtnSevkYeri.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSevkYeri.FlatAppearance.BorderSize = 0;
            this.BtnSevkYeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSevkYeri.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSevkYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSevkYeri.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.BtnSevkYeri.IconColor = System.Drawing.Color.Black;
            this.BtnSevkYeri.IconSize = 25;
            this.BtnSevkYeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSevkYeri.Location = new System.Drawing.Point(0, 80);
            this.BtnSevkYeri.Name = "BtnSevkYeri";
            this.BtnSevkYeri.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnSevkYeri.Rotation = 0D;
            this.BtnSevkYeri.Size = new System.Drawing.Size(198, 40);
            this.BtnSevkYeri.TabIndex = 2;
            this.BtnSevkYeri.Text = "SevkYeri";
            this.BtnSevkYeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSevkYeri.UseVisualStyleBackColor = true;
            this.BtnSevkYeri.Click += new System.EventHandler(this.BtnSevkYeri_Click);
            // 
            // BtnMalzeme
            // 
            this.BtnMalzeme.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMalzeme.FlatAppearance.BorderSize = 0;
            this.BtnMalzeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMalzeme.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMalzeme.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.BtnMalzeme.IconColor = System.Drawing.Color.Black;
            this.BtnMalzeme.IconSize = 25;
            this.BtnMalzeme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMalzeme.Location = new System.Drawing.Point(0, 40);
            this.BtnMalzeme.Name = "BtnMalzeme";
            this.BtnMalzeme.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnMalzeme.Rotation = 0D;
            this.BtnMalzeme.Size = new System.Drawing.Size(198, 40);
            this.BtnMalzeme.TabIndex = 1;
            this.BtnMalzeme.Text = "Malzeme";
            this.BtnMalzeme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMalzeme.UseVisualStyleBackColor = true;
            this.BtnMalzeme.Click += new System.EventHandler(this.BtnMalzeme_Click);
            // 
            // BtnCariUnvanFirma
            // 
            this.BtnCariUnvanFirma.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCariUnvanFirma.FlatAppearance.BorderSize = 0;
            this.BtnCariUnvanFirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCariUnvanFirma.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCariUnvanFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCariUnvanFirma.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.BtnCariUnvanFirma.IconColor = System.Drawing.Color.Black;
            this.BtnCariUnvanFirma.IconSize = 25;
            this.BtnCariUnvanFirma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCariUnvanFirma.Location = new System.Drawing.Point(0, 0);
            this.BtnCariUnvanFirma.Name = "BtnCariUnvanFirma";
            this.BtnCariUnvanFirma.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnCariUnvanFirma.Rotation = 0D;
            this.BtnCariUnvanFirma.Size = new System.Drawing.Size(198, 40);
            this.BtnCariUnvanFirma.TabIndex = 0;
            this.BtnCariUnvanFirma.Text = "Cari Ünvan / Firma";
            this.BtnCariUnvanFirma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCariUnvanFirma.UseVisualStyleBackColor = true;
            this.BtnCariUnvanFirma.Click += new System.EventHandler(this.BtnCariUnvanFirma_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 593);
            this.panel2.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(205, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(724, 593);
            this.panelDesktop.TabIndex = 2;
            // 
            // Tanimlamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(929, 593);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Name = "Tanimlamalar";
            this.Text = "Tanimlamalar";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton BtnArac;
        private FontAwesome.Sharp.IconButton BtnSofor;
        private FontAwesome.Sharp.IconButton BtnSevkYeri;
        private FontAwesome.Sharp.IconButton BtnMalzeme;
        private FontAwesome.Sharp.IconButton BtnCariUnvanFirma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktop;
    }
}