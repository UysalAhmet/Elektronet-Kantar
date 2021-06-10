namespace WindowsFormsApp1
{
    partial class Soforler
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnFormTemizle = new FontAwesome.Sharp.IconButton();
            this.BtnKaydet = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTCNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ıconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSoforAdSoyad = new System.Windows.Forms.TextBox();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.BtnAktifEt = new FontAwesome.Sharp.IconButton();
            this.comboBoxSoforId = new System.Windows.Forms.ComboBox();
            this.BtnSil = new FontAwesome.Sharp.IconButton();
            this.ıconPictureBoxGuncelle = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSofor = new System.Windows.Forms.ComboBox();
            this.soforBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.ıconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnFormTemizle);
            this.panel2.Controls.Add(this.BtnKaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 50);
            this.panel2.TabIndex = 45;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 5);
            this.panel1.TabIndex = 48;
            // 
            // textBoxTCNo
            // 
            this.textBoxTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTCNo.Location = new System.Drawing.Point(574, 100);
            this.textBoxTCNo.MaxLength = 11;
            this.textBoxTCNo.Name = "textBoxTCNo";
            this.textBoxTCNo.Size = new System.Drawing.Size(180, 23);
            this.textBoxTCNo.TabIndex = 57;
            this.textBoxTCNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTCNo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(437, 107);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "TC Kimlik No";
            // 
            // ıconPictureBox4
            // 
            this.ıconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.ıconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox4.Location = new System.Drawing.Point(399, 92);
            this.ıconPictureBox4.Name = "ıconPictureBox4";
            this.ıconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox4.TabIndex = 55;
            this.ıconPictureBox4.TabStop = false;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTelefon.Location = new System.Drawing.Point(574, 139);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(180, 23);
            this.textBoxTelefon.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(451, 145);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Telefon";
            // 
            // ıconPictureBox2
            // 
            this.ıconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.ıconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox2.Location = new System.Drawing.Point(399, 130);
            this.ıconPictureBox2.Name = "ıconPictureBox2";
            this.ıconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox2.TabIndex = 52;
            this.ıconPictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 104);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Ad ";
            // 
            // textBoxSoforAdSoyad
            // 
            this.textBoxSoforAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoforAdSoyad.Location = new System.Drawing.Point(187, 100);
            this.textBoxSoforAdSoyad.Name = "textBoxSoforAdSoyad";
            this.textBoxSoforAdSoyad.Size = new System.Drawing.Size(180, 23);
            this.textBoxSoforAdSoyad.TabIndex = 50;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.Location = new System.Drawing.Point(12, 92);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox1.TabIndex = 49;
            this.ıconPictureBox1.TabStop = false;
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
            this.BtnAktifEt.TabIndex = 63;
            this.BtnAktifEt.Text = "Aktif Et";
            this.BtnAktifEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAktifEt.UseVisualStyleBackColor = true;
            this.BtnAktifEt.Click += new System.EventHandler(this.BtnAktifEt_Click);
            // 
            // comboBoxSoforId
            // 
            this.comboBoxSoforId.FormattingEnabled = true;
            this.comboBoxSoforId.Location = new System.Drawing.Point(271, 44);
            this.comboBoxSoforId.Name = "comboBoxSoforId";
            this.comboBoxSoforId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSoforId.TabIndex = 62;
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
            this.BtnSil.TabIndex = 61;
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
            this.ıconPictureBoxGuncelle.TabIndex = 60;
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
            this.label1.TabIndex = 59;
            this.label1.Text = "Guncellemek için kayıt seçin";
            // 
            // comboBoxSofor
            // 
            this.comboBoxSofor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxSofor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSofor.DataSource = this.soforBindingSource;
            this.comboBoxSofor.DisplayMember = "SoforAdSoyad";
            this.comboBoxSofor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSofor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSofor.FormattingEnabled = true;
            this.comboBoxSofor.Location = new System.Drawing.Point(271, 13);
            this.comboBoxSofor.Name = "comboBoxSofor";
            this.comboBoxSofor.Size = new System.Drawing.Size(180, 24);
            this.comboBoxSofor.TabIndex = 58;
            this.comboBoxSofor.ValueMember = "SoforId";
            this.comboBoxSofor.SelectedIndexChanged += new System.EventHandler(this.comboBoxSofor_SelectedIndexChanged);
            // 
            // soforBindingSource
            // 
            this.soforBindingSource.DataSource = typeof(WindowsFormsApp1.Sofor);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 142);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Soyad";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(187, 138);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(180, 23);
            this.textBoxSoyad.TabIndex = 65;
            // 
            // ıconPictureBox3
            // 
            this.ıconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ıconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox3.Location = new System.Drawing.Point(12, 130);
            this.ıconPictureBox3.Name = "ıconPictureBox3";
            this.ıconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox3.TabIndex = 64;
            this.ıconPictureBox3.TabStop = false;
            // 
            // Soforler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.ıconPictureBox3);
            this.Controls.Add(this.BtnAktifEt);
            this.Controls.Add(this.comboBoxSoforId);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.ıconPictureBoxGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSofor);
            this.Controls.Add(this.textBoxTCNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ıconPictureBox4);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ıconPictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSoforAdSoyad);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Soforler";
            this.Text = "Soforler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Soforler_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Soforler_FormClosed);
            this.Load += new System.EventHandler(this.Soforler_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnFormTemizle;
        private FontAwesome.Sharp.IconButton BtnKaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTCNo;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox4;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSoforAdSoyad;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconButton BtnAktifEt;
        private System.Windows.Forms.ComboBox comboBoxSoforId;
        private FontAwesome.Sharp.IconButton BtnSil;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSofor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox3;
        private System.Windows.Forms.BindingSource soforBindingSource;
    }
}