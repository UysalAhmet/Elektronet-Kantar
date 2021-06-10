namespace WindowsFormsApp1
{
    partial class Araclar
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
                try
                {
                    sp.Close();
                }
                catch (System.Exception)
                {

                    
                }
               
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
            this.label6 = new System.Windows.Forms.Label();
            this.ıconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxMarkaModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ıconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxDaraAgirlik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAracPlaka = new System.Windows.Forms.TextBox();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.radioButtonYabanci = new System.Windows.Forms.RadioButton();
            this.radioButtonFirmaAraci = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnFormTemizle = new FontAwesome.Sharp.IconButton();
            this.BtnKaydet = new FontAwesome.Sharp.IconButton();
            this.BtnAktifEt = new FontAwesome.Sharp.IconButton();
            this.comboBoxAracId = new System.Windows.Forms.ComboBox();
            this.BtnSil = new FontAwesome.Sharp.IconButton();
            this.ıconPictureBoxGuncelle = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxArac = new System.Windows.Forms.ComboBox();
            this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxElDara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ıconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBoxElleGiris = new FontAwesome.Sharp.IconPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ıconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxElleGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 5);
            this.panel1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(454, 145);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tip";
            // 
            // ıconPictureBox5
            // 
            this.ıconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.ıconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox5.Location = new System.Drawing.Point(416, 130);
            this.ıconPictureBox5.Name = "ıconPictureBox5";
            this.ıconPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox5.TabIndex = 27;
            this.ıconPictureBox5.TabStop = false;
            // 
            // textBoxMarkaModel
            // 
            this.textBoxMarkaModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMarkaModel.Location = new System.Drawing.Point(574, 104);
            this.textBoxMarkaModel.Name = "textBoxMarkaModel";
            this.textBoxMarkaModel.Size = new System.Drawing.Size(180, 23);
            this.textBoxMarkaModel.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(454, 107);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Marka/Model";
            // 
            // ıconPictureBox4
            // 
            this.ıconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.ıconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox4.Location = new System.Drawing.Point(416, 92);
            this.ıconPictureBox4.Name = "ıconPictureBox4";
            this.ıconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox4.TabIndex = 24;
            this.ıconPictureBox4.TabStop = false;
            // 
            // textBoxDaraAgirlik
            // 
            this.textBoxDaraAgirlik.Enabled = false;
            this.textBoxDaraAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDaraAgirlik.Location = new System.Drawing.Point(187, 142);
            this.textBoxDaraAgirlik.Name = "textBoxDaraAgirlik";
            this.textBoxDaraAgirlik.Size = new System.Drawing.Size(180, 23);
            this.textBoxDaraAgirlik.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 145);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dara Ağırlık";
            // 
            // ıconPictureBox2
            // 
            this.ıconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Weight;
            this.ıconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox2.Location = new System.Drawing.Point(12, 130);
            this.ıconPictureBox2.Name = "ıconPictureBox2";
            this.ıconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox2.TabIndex = 21;
            this.ıconPictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 107);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Araç Plaka";
            // 
            // textBoxAracPlaka
            // 
            this.textBoxAracPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAracPlaka.Location = new System.Drawing.Point(187, 100);
            this.textBoxAracPlaka.Name = "textBoxAracPlaka";
            this.textBoxAracPlaka.Size = new System.Drawing.Size(180, 23);
            this.textBoxAracPlaka.TabIndex = 19;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.Location = new System.Drawing.Point(12, 92);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox1.TabIndex = 18;
            this.ıconPictureBox1.TabStop = false;
            // 
            // radioButtonYabanci
            // 
            this.radioButtonYabanci.AutoSize = true;
            this.radioButtonYabanci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonYabanci.Location = new System.Drawing.Point(550, 148);
            this.radioButtonYabanci.Name = "radioButtonYabanci";
            this.radioButtonYabanci.Size = new System.Drawing.Size(84, 21);
            this.radioButtonYabanci.TabIndex = 29;
            this.radioButtonYabanci.TabStop = true;
            this.radioButtonYabanci.Text = "Yabancı";
            this.radioButtonYabanci.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirmaAraci
            // 
            this.radioButtonFirmaAraci.AutoSize = true;
            this.radioButtonFirmaAraci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonFirmaAraci.Location = new System.Drawing.Point(645, 148);
            this.radioButtonFirmaAraci.Name = "radioButtonFirmaAraci";
            this.radioButtonFirmaAraci.Size = new System.Drawing.Size(108, 21);
            this.radioButtonFirmaAraci.TabIndex = 30;
            this.radioButtonFirmaAraci.TabStop = true;
            this.radioButtonFirmaAraci.Text = "Firma Aracı";
            this.radioButtonFirmaAraci.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnFormTemizle);
            this.panel2.Controls.Add(this.BtnKaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 31;
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
            this.BtnAktifEt.TabIndex = 69;
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
            this.comboBoxAracId.TabIndex = 68;
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
            this.BtnSil.TabIndex = 67;
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
            this.ıconPictureBoxGuncelle.TabIndex = 66;
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
            this.label1.TabIndex = 65;
            this.label1.Text = "Guncellemek için kayıt seçin";
            // 
            // comboBoxArac
            // 
            this.comboBoxArac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxArac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxArac.DataSource = this.aracBindingSource;
            this.comboBoxArac.DisplayMember = "AracPlaka";
            this.comboBoxArac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxArac.FormattingEnabled = true;
            this.comboBoxArac.Location = new System.Drawing.Point(271, 13);
            this.comboBoxArac.Name = "comboBoxArac";
            this.comboBoxArac.Size = new System.Drawing.Size(180, 24);
            this.comboBoxArac.TabIndex = 64;
            this.comboBoxArac.ValueMember = "AracId";
            this.comboBoxArac.SelectedIndexChanged += new System.EventHandler(this.comboBoxArac_SelectedIndexChanged);
            // 
            // aracBindingSource
            // 
            this.aracBindingSource.DataSource = typeof(WindowsFormsApp1.Arac);
            // 
            // textBoxElDara
            // 
            this.textBoxElDara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxElDara.Location = new System.Drawing.Point(186, 293);
            this.textBoxElDara.Name = "textBoxElDara";
            this.textBoxElDara.Size = new System.Drawing.Size(180, 23);
            this.textBoxElDara.TabIndex = 72;
            this.textBoxElDara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxElDara_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 296);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Dara Ağırlık";
            // 
            // ıconPictureBox3
            // 
            this.ıconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Weight;
            this.ıconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox3.Location = new System.Drawing.Point(11, 281);
            this.ıconPictureBox3.Name = "ıconPictureBox3";
            this.ıconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox3.TabIndex = 70;
            this.ıconPictureBox3.TabStop = false;
            // 
            // ıconPictureBoxElleGiris
            // 
            this.ıconPictureBoxElleGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxElleGiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxElleGiris.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.ıconPictureBoxElleGiris.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxElleGiris.Location = new System.Drawing.Point(11, 243);
            this.ıconPictureBoxElleGiris.Name = "ıconPictureBoxElleGiris";
            this.ıconPictureBoxElleGiris.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxElleGiris.TabIndex = 73;
            this.ıconPictureBoxElleGiris.TabStop = false;
            this.ıconPictureBoxElleGiris.Click += new System.EventHandler(this.ıconPictureBoxElleGiris_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(49, 258);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 74;
            this.label7.Text = "El ile Giriş";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(67, 183);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "Dorse Plaka";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(187, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 23);
            this.textBox1.TabIndex = 76;
            // 
            // ıconPictureBox6
            // 
            this.ıconPictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.ıconPictureBox6.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox6.Location = new System.Drawing.Point(12, 168);
            this.ıconPictureBox6.Name = "ıconPictureBox6";
            this.ıconPictureBox6.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox6.TabIndex = 75;
            this.ıconPictureBox6.TabStop = false;
            // 
            // Araclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ıconPictureBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ıconPictureBoxElleGiris);
            this.Controls.Add(this.textBoxElDara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ıconPictureBox3);
            this.Controls.Add(this.BtnAktifEt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBoxAracId);
            this.Controls.Add(this.radioButtonFirmaAraci);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.radioButtonYabanci);
            this.Controls.Add(this.ıconPictureBoxGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxArac);
            this.Controls.Add(this.ıconPictureBox5);
            this.Controls.Add(this.textBoxMarkaModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ıconPictureBox4);
            this.Controls.Add(this.textBoxDaraAgirlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ıconPictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAracPlaka);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Araclar";
            this.Text = "Araclar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Araclar_FormClosing);
            this.Load += new System.EventHandler(this.Araclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxElleGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox5;
        private System.Windows.Forms.TextBox textBoxMarkaModel;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox4;
        private System.Windows.Forms.TextBox textBoxDaraAgirlik;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAracPlaka;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.RadioButton radioButtonYabanci;
        private System.Windows.Forms.RadioButton radioButtonFirmaAraci;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnFormTemizle;
        private FontAwesome.Sharp.IconButton BtnKaydet;
        private FontAwesome.Sharp.IconButton BtnAktifEt;
        private System.Windows.Forms.ComboBox comboBoxAracId;
        private FontAwesome.Sharp.IconButton BtnSil;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxArac;
        private System.Windows.Forms.TextBox textBoxElDara;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxElleGiris;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.BindingSource aracBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox6;
    }
}