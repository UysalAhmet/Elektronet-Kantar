namespace WindowsFormsApp1
{
    partial class YeniKullanici
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
            this.textBoxDaraAgirlik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAracPlaka = new System.Windows.Forms.TextBox();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnFormTemizle = new FontAwesome.Sharp.IconButton();
            this.BtnKaydet = new FontAwesome.Sharp.IconButton();
            this.BtnAktifEt = new FontAwesome.Sharp.IconButton();
            this.comboBoxAracId = new System.Windows.Forms.ComboBox();
            this.BtnSil = new FontAwesome.Sharp.IconButton();
            this.ıconPictureBoxGuncelle = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxArac = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGuncelle)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDaraAgirlik
            // 
            this.textBoxDaraAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDaraAgirlik.Location = new System.Drawing.Point(187, 128);
            this.textBoxDaraAgirlik.Name = "textBoxDaraAgirlik";
            this.textBoxDaraAgirlik.Size = new System.Drawing.Size(180, 23);
            this.textBoxDaraAgirlik.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 131);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sifre";
            // 
            // ıconPictureBox2
            // 
            this.ıconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Weight;
            this.ıconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox2.Location = new System.Drawing.Point(12, 116);
            this.ıconPictureBox2.Name = "ıconPictureBox2";
            this.ıconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox2.TabIndex = 27;
            this.ıconPictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 93);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kullanıcı Ad";
            // 
            // textBoxAracPlaka
            // 
            this.textBoxAracPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAracPlaka.Location = new System.Drawing.Point(187, 86);
            this.textBoxAracPlaka.Name = "textBoxAracPlaka";
            this.textBoxAracPlaka.Size = new System.Drawing.Size(180, 23);
            this.textBoxAracPlaka.TabIndex = 25;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.Location = new System.Drawing.Point(12, 78);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox1.TabIndex = 24;
            this.ıconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnFormTemizle);
            this.panel2.Controls.Add(this.BtnKaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 32;
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
            this.BtnAktifEt.TabIndex = 76;
            this.BtnAktifEt.Text = "Aktif Et";
            this.BtnAktifEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAktifEt.UseVisualStyleBackColor = true;
            this.BtnAktifEt.Click += new System.EventHandler(this.BtnAktifEt_Click);
            // 
            // comboBoxAracId
            // 
            this.comboBoxAracId.FormattingEnabled = true;
            this.comboBoxAracId.Location = new System.Drawing.Point(271, 44);
            this.comboBoxAracId.Name = "comboBoxAracId";
            this.comboBoxAracId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAracId.TabIndex = 75;
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
            this.BtnSil.TabIndex = 74;
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
            this.ıconPictureBoxGuncelle.TabIndex = 73;
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
            this.label1.TabIndex = 72;
            this.label1.Text = "Guncellemek için kayıt seçin";
            // 
            // comboBoxArac
            // 
            this.comboBoxArac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxArac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxArac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxArac.FormattingEnabled = true;
            this.comboBoxArac.Location = new System.Drawing.Point(271, 13);
            this.comboBoxArac.Name = "comboBoxArac";
            this.comboBoxArac.Size = new System.Drawing.Size(180, 24);
            this.comboBoxArac.TabIndex = 71;
            this.comboBoxArac.SelectedIndexChanged += new System.EventHandler(this.comboBoxArac_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 5);
            this.panel1.TabIndex = 70;
            // 
            // YeniKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAktifEt);
            this.Controls.Add(this.comboBoxAracId);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.ıconPictureBoxGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxArac);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxDaraAgirlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ıconPictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAracPlaka);
            this.Controls.Add(this.ıconPictureBox1);
            this.Name = "YeniKullanici";
            this.Text = "YeniKullanici";
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGuncelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDaraAgirlik;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAracPlaka;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnFormTemizle;
        private FontAwesome.Sharp.IconButton BtnKaydet;
        private FontAwesome.Sharp.IconButton BtnAktifEt;
        private System.Windows.Forms.ComboBox comboBoxAracId;
        private FontAwesome.Sharp.IconButton BtnSil;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxArac;
        private System.Windows.Forms.Panel panel1;
    }
}