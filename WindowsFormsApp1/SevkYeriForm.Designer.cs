namespace WindowsFormsApp1
{
    partial class SevkYeriForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ıconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ıconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnFormTemizle = new FontAwesome.Sharp.IconButton();
            this.BtnKaydet = new FontAwesome.Sharp.IconButton();
            this.BtnAktifEt = new FontAwesome.Sharp.IconButton();
            this.comboBoxSevkYeriId = new System.Windows.Forms.ComboBox();
            this.BtnSil = new FontAwesome.Sharp.IconButton();
            this.ıconPictureBoxGuncelle = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSevkYeri = new System.Windows.Forms.ComboBox();
            this.sevkYeriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevkYeriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 5);
            this.panel1.TabIndex = 8;
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.AcceptsReturn = true;
            this.textBoxAciklama.AcceptsTab = true;
            this.textBoxAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAciklama.Location = new System.Drawing.Point(574, 104);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAciklama.Size = new System.Drawing.Size(180, 58);
            this.textBoxAciklama.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(437, 107);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Açıklama";
            // 
            // ıconPictureBox4
            // 
            this.ıconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.ıconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox4.Location = new System.Drawing.Point(399, 92);
            this.ıconPictureBox4.Name = "ıconPictureBox4";
            this.ıconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox4.TabIndex = 38;
            this.ıconPictureBox4.TabStop = false;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.AcceptsReturn = true;
            this.textBoxAdres.AcceptsTab = true;
            this.textBoxAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdres.Location = new System.Drawing.Point(187, 100);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAdres.Size = new System.Drawing.Size(180, 41);
            this.textBoxAdres.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(50, 107);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Adres";
            // 
            // ıconPictureBox7
            // 
            this.ıconPictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.ıconPictureBox7.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox7.Location = new System.Drawing.Point(12, 92);
            this.ıconPictureBox7.Name = "ıconPictureBox7";
            this.ıconPictureBox7.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox7.TabIndex = 41;
            this.ıconPictureBox7.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnFormTemizle);
            this.panel2.Controls.Add(this.BtnKaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 50);
            this.panel2.TabIndex = 44;
            // 
            // BtnFormTemizle
            // 
            this.BtnFormTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.BtnFormTemizle.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnFormTemizle.FlatAppearance.BorderSize = 3;
            this.BtnFormTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFormTemizle.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnFormTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFormTemizle.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnFormTemizle.IconColor = System.Drawing.Color.Maroon;
            this.BtnFormTemizle.IconSize = 32;
            this.BtnFormTemizle.Location = new System.Drawing.Point(355, 0);
            this.BtnFormTemizle.Name = "BtnFormTemizle";
            this.BtnFormTemizle.Rotation = 0D;
            this.BtnFormTemizle.Size = new System.Drawing.Size(399, 50);
            this.BtnFormTemizle.TabIndex = 25;
            this.BtnFormTemizle.Text = "Formu Temizle";
            this.BtnFormTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFormTemizle.UseVisualStyleBackColor = false;
            this.BtnFormTemizle.Click += new System.EventHandler(this.BtnFormTemizle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.BtnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnKaydet.FlatAppearance.BorderSize = 3;
            this.BtnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKaydet.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnKaydet.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnKaydet.IconSize = 32;
            this.BtnKaydet.Location = new System.Drawing.Point(0, 0);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Rotation = 0D;
            this.BtnKaydet.Size = new System.Drawing.Size(355, 50);
            this.BtnKaydet.TabIndex = 24;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnAktifEt
            // 
            this.BtnAktifEt.FlatAppearance.BorderSize = 3;
            this.BtnAktifEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAktifEt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAktifEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAktifEt.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.BtnAktifEt.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnAktifEt.IconSize = 16;
            this.BtnAktifEt.Location = new System.Drawing.Point(613, 13);
            this.BtnAktifEt.Name = "BtnAktifEt";
            this.BtnAktifEt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAktifEt.Rotation = 0D;
            this.BtnAktifEt.Size = new System.Drawing.Size(149, 30);
            this.BtnAktifEt.TabIndex = 44;
            this.BtnAktifEt.Text = "Aktif Et";
            this.BtnAktifEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAktifEt.UseVisualStyleBackColor = true;
            this.BtnAktifEt.Click += new System.EventHandler(this.BtnAktifEt_Click);
            // 
            // comboBoxSevkYeriId
            // 
            this.comboBoxSevkYeriId.FormattingEnabled = true;
            this.comboBoxSevkYeriId.Location = new System.Drawing.Point(271, 44);
            this.comboBoxSevkYeriId.Name = "comboBoxSevkYeriId";
            this.comboBoxSevkYeriId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSevkYeriId.TabIndex = 43;
            // 
            // BtnSil
            // 
            this.BtnSil.FlatAppearance.BorderSize = 3;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnSil.IconColor = System.Drawing.Color.DarkRed;
            this.BtnSil.IconSize = 16;
            this.BtnSil.Location = new System.Drawing.Point(457, 13);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSil.Rotation = 0D;
            this.BtnSil.Size = new System.Drawing.Size(149, 30);
            this.BtnSil.TabIndex = 42;
            this.BtnSil.Text = "Kaydı Sil";
            this.BtnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // ıconPictureBoxGuncelle
            // 
            this.ıconPictureBoxGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxGuncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxGuncelle.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.ıconPictureBoxGuncelle.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxGuncelle.Location = new System.Drawing.Point(11, 11);
            this.ıconPictureBoxGuncelle.Name = "ıconPictureBoxGuncelle";
            this.ıconPictureBoxGuncelle.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxGuncelle.TabIndex = 41;
            this.ıconPictureBoxGuncelle.TabStop = false;
            this.ıconPictureBoxGuncelle.Click += new System.EventHandler(this.ıconPictureBoxGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Guncellemek için kayıt seçin";
            // 
            // comboBoxSevkYeri
            // 
            this.comboBoxSevkYeri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxSevkYeri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSevkYeri.DataSource = this.sevkYeriBindingSource;
            this.comboBoxSevkYeri.DisplayMember = "SevkYeriAdres";
            this.comboBoxSevkYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSevkYeri.DropDownWidth = 400;
            this.comboBoxSevkYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSevkYeri.FormattingEnabled = true;
            this.comboBoxSevkYeri.Location = new System.Drawing.Point(271, 13);
            this.comboBoxSevkYeri.Name = "comboBoxSevkYeri";
            this.comboBoxSevkYeri.Size = new System.Drawing.Size(180, 24);
            this.comboBoxSevkYeri.TabIndex = 39;
            this.comboBoxSevkYeri.ValueMember = "SevkYeriId";
            this.comboBoxSevkYeri.SelectedIndexChanged += new System.EventHandler(this.comboBoxSevkYeri_SelectedIndexChanged);
            // 
            // sevkYeriBindingSource
            // 
            this.sevkYeriBindingSource.DataSource = typeof(WindowsFormsApp1.SevkYeri);
            // 
            // SevkYeriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.BtnAktifEt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBoxSevkYeriId);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ıconPictureBoxGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ıconPictureBox7);
            this.Controls.Add(this.comboBoxSevkYeri);
            this.Controls.Add(this.textBoxAciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ıconPictureBox4);
            this.Controls.Add(this.panel1);
            this.Name = "SevkYeriForm";
            this.Text = "SevkYeriForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SevkYeriForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SevkYeriForm_FormClosed);
            this.Load += new System.EventHandler(this.SevkYeriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevkYeriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox4;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox7;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnFormTemizle;
        private FontAwesome.Sharp.IconButton BtnKaydet;
        private FontAwesome.Sharp.IconButton BtnAktifEt;
        private System.Windows.Forms.ComboBox comboBoxSevkYeriId;
        private FontAwesome.Sharp.IconButton BtnSil;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSevkYeri;
        private System.Windows.Forms.BindingSource sevkYeriBindingSource;
    }
}