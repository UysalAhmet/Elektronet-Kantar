namespace WindowsFormsApp1
{
    partial class AracTartım
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
            this.label7 = new System.Windows.Forms.Label();
            this.ıconPictureBoxMalzemeAd = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ıconPictureBoxSevkYeri = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ıconPictureBoxSofor = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ıconPictureBoxGonderenFirma = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ıconPictureBoxAliciFirma = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ıconPictureBoxArac = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ıconPictureBoxBirimFiyat = new FontAwesome.Sharp.IconPictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ıconPictureBoxNetAgirlik = new FontAwesome.Sharp.IconPictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ıconPictureBoxToplamFiyat = new FontAwesome.Sharp.IconPictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ıconPictureBoxIslemTarihi = new FontAwesome.Sharp.IconPictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ıconPictureBoxIslemKod = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.ıconPictureBoxGunlukKod = new FontAwesome.Sharp.IconPictureBox();
            this.comboBoxAracPlaka = new System.Windows.Forms.ComboBox();
            this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSofor = new System.Windows.Forms.ComboBox();
            this.soforBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxAliciFirma = new System.Windows.Forms.ComboBox();
            this.cariUnvanFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSevkYeri = new System.Windows.Forms.ComboBox();
            this.sevkYeriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMalzemeAd = new System.Windows.Forms.ComboBox();
            this.malzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxIslemTarihi = new System.Windows.Forms.TextBox();
            this.textBoxBirimFiyat = new System.Windows.Forms.TextBox();
            this.textBoxToplamFiyat = new System.Windows.Forms.TextBox();
            this.textBoxAgirlik = new System.Windows.Forms.TextBox();
            this.textBoxIslemKod = new System.Windows.Forms.TextBox();
            this.textBoxGunlukIslemKod = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnFormTemizle = new FontAwesome.Sharp.IconButton();
            this.BtnKaydet = new FontAwesome.Sharp.IconButton();
            this.comboBoxAracId = new System.Windows.Forms.ComboBox();
            this.comboBoxSoforId = new System.Windows.Forms.ComboBox();
            this.comboBoxAliciFirmaId = new System.Windows.Forms.ComboBox();
            this.comboBoxSevkYeriId = new System.Windows.Forms.ComboBox();
            this.comboBoxMalzemeId = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxGonderenFirma = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ıconPictureBoxSahis = new FontAwesome.Sharp.IconPictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ıconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cariUnvanFirmaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.ıconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ıconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxMalzemeAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxSevkYeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxSofor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGonderenFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxAliciFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxArac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxNetAgirlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxToplamFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxIslemTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxIslemKod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGunlukKod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariUnvanFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevkYeriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxSahis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariUnvanFirmaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(50, 339);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Malzeme Adı";
            // 
            // ıconPictureBoxMalzemeAd
            // 
            this.ıconPictureBoxMalzemeAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxMalzemeAd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxMalzemeAd.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.ıconPictureBoxMalzemeAd.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxMalzemeAd.Location = new System.Drawing.Point(12, 327);
            this.ıconPictureBoxMalzemeAd.Name = "ıconPictureBoxMalzemeAd";
            this.ıconPictureBoxMalzemeAd.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxMalzemeAd.TabIndex = 36;
            this.ıconPictureBoxMalzemeAd.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(53, 224);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Sevk Yeri";
            // 
            // ıconPictureBoxSevkYeri
            // 
            this.ıconPictureBoxSevkYeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxSevkYeri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxSevkYeri.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.ıconPictureBoxSevkYeri.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxSevkYeri.Location = new System.Drawing.Point(15, 209);
            this.ıconPictureBoxSevkYeri.Name = "ıconPictureBoxSevkYeri";
            this.ıconPictureBoxSevkYeri.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxSevkYeri.TabIndex = 33;
            this.ıconPictureBoxSevkYeri.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(448, 57);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Şöför ";
            // 
            // ıconPictureBoxSofor
            // 
            this.ıconPictureBoxSofor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxSofor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxSofor.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ıconPictureBoxSofor.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxSofor.Location = new System.Drawing.Point(410, 42);
            this.ıconPictureBoxSofor.Name = "ıconPictureBoxSofor";
            this.ıconPictureBoxSofor.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxSofor.TabIndex = 30;
            this.ıconPictureBoxSofor.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(448, 162);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Gönderen Firma";
            // 
            // ıconPictureBoxGonderenFirma
            // 
            this.ıconPictureBoxGonderenFirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxGonderenFirma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxGonderenFirma.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.ıconPictureBoxGonderenFirma.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxGonderenFirma.Location = new System.Drawing.Point(410, 147);
            this.ıconPictureBoxGonderenFirma.Name = "ıconPictureBoxGonderenFirma";
            this.ıconPictureBoxGonderenFirma.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxGonderenFirma.TabIndex = 27;
            this.ıconPictureBoxGonderenFirma.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 162);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Alıcı Firma";
            // 
            // ıconPictureBoxAliciFirma
            // 
            this.ıconPictureBoxAliciFirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxAliciFirma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxAliciFirma.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.ıconPictureBoxAliciFirma.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxAliciFirma.Location = new System.Drawing.Point(15, 147);
            this.ıconPictureBoxAliciFirma.Name = "ıconPictureBoxAliciFirma";
            this.ıconPictureBoxAliciFirma.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxAliciFirma.TabIndex = 24;
            this.ıconPictureBoxAliciFirma.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 58);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Araç Plaka";
            // 
            // ıconPictureBoxArac
            // 
            this.ıconPictureBoxArac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxArac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxArac.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.ıconPictureBoxArac.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxArac.Location = new System.Drawing.Point(12, 43);
            this.ıconPictureBoxArac.Name = "ıconPictureBoxArac";
            this.ıconPictureBoxArac.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxArac.TabIndex = 21;
            this.ıconPictureBoxArac.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(151, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 3);
            this.panel2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Araç Bilgileri";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(151, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 3);
            this.panel1.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Teslimat Bilgileri";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(151, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 3);
            this.panel3.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Malzeme Bilgileri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(448, 336);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Birim Fiyatı";
            // 
            // ıconPictureBoxBirimFiyat
            // 
            this.ıconPictureBoxBirimFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxBirimFiyat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxBirimFiyat.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.ıconPictureBoxBirimFiyat.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxBirimFiyat.Location = new System.Drawing.Point(410, 324);
            this.ıconPictureBoxBirimFiyat.Name = "ıconPictureBoxBirimFiyat";
            this.ıconPictureBoxBirimFiyat.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxBirimFiyat.TabIndex = 45;
            this.ıconPictureBoxBirimFiyat.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(53, 400);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "Ağırlık";
            // 
            // ıconPictureBoxNetAgirlik
            // 
            this.ıconPictureBoxNetAgirlik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxNetAgirlik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxNetAgirlik.IconChar = FontAwesome.Sharp.IconChar.Weight;
            this.ıconPictureBoxNetAgirlik.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxNetAgirlik.Location = new System.Drawing.Point(15, 388);
            this.ıconPictureBoxNetAgirlik.Name = "ıconPictureBoxNetAgirlik";
            this.ıconPictureBoxNetAgirlik.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxNetAgirlik.TabIndex = 48;
            this.ıconPictureBoxNetAgirlik.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(448, 400);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "Toplam Fiyat";
            // 
            // ıconPictureBoxToplamFiyat
            // 
            this.ıconPictureBoxToplamFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxToplamFiyat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxToplamFiyat.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.ıconPictureBoxToplamFiyat.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxToplamFiyat.Location = new System.Drawing.Point(410, 388);
            this.ıconPictureBoxToplamFiyat.Name = "ıconPictureBoxToplamFiyat";
            this.ıconPictureBoxToplamFiyat.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxToplamFiyat.TabIndex = 51;
            this.ıconPictureBoxToplamFiyat.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(448, 224);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 55;
            this.label13.Text = "İşlem Tarihi";
            // 
            // ıconPictureBoxIslemTarihi
            // 
            this.ıconPictureBoxIslemTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxIslemTarihi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxIslemTarihi.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.ıconPictureBoxIslemTarihi.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxIslemTarihi.Location = new System.Drawing.Point(410, 212);
            this.ıconPictureBoxIslemTarihi.Name = "ıconPictureBoxIslemTarihi";
            this.ıconPictureBoxIslemTarihi.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxIslemTarihi.TabIndex = 54;
            this.ıconPictureBoxIslemTarihi.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(53, 540);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 58;
            this.label14.Text = "İşlem Kodu";
            // 
            // ıconPictureBoxIslemKod
            // 
            this.ıconPictureBoxIslemKod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxIslemKod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxIslemKod.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.ıconPictureBoxIslemKod.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxIslemKod.Location = new System.Drawing.Point(15, 528);
            this.ıconPictureBoxIslemKod.Name = "ıconPictureBoxIslemKod";
            this.ıconPictureBoxIslemKod.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxIslemKod.TabIndex = 57;
            this.ıconPictureBoxIslemKod.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(12, 507);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1114, 3);
            this.panel4.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(448, 537);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 17);
            this.label15.TabIndex = 62;
            this.label15.Text = "Günlük İşlem Kodu";
            // 
            // ıconPictureBoxGunlukKod
            // 
            this.ıconPictureBoxGunlukKod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxGunlukKod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxGunlukKod.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.ıconPictureBoxGunlukKod.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxGunlukKod.Location = new System.Drawing.Point(410, 525);
            this.ıconPictureBoxGunlukKod.Name = "ıconPictureBoxGunlukKod";
            this.ıconPictureBoxGunlukKod.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxGunlukKod.TabIndex = 61;
            this.ıconPictureBoxGunlukKod.TabStop = false;
            // 
            // comboBoxAracPlaka
            // 
            this.comboBoxAracPlaka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAracPlaka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAracPlaka.DataSource = this.aracBindingSource;
            this.comboBoxAracPlaka.DisplayMember = "AracPlaka";
            this.comboBoxAracPlaka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAracPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAracPlaka.FormattingEnabled = true;
            this.comboBoxAracPlaka.Location = new System.Drawing.Point(187, 54);
            this.comboBoxAracPlaka.Name = "comboBoxAracPlaka";
            this.comboBoxAracPlaka.Size = new System.Drawing.Size(180, 24);
            this.comboBoxAracPlaka.TabIndex = 64;
            this.comboBoxAracPlaka.ValueMember = "AracId";
            this.comboBoxAracPlaka.SelectedIndexChanged += new System.EventHandler(this.comboBoxAracPlaka_SelectedIndexChanged);
            // 
            // aracBindingSource
            // 
            this.aracBindingSource.DataSource = typeof(WindowsFormsApp1.Arac);
            // 
            // comboBoxSofor
            // 
            this.comboBoxSofor.DataSource = this.soforBindingSource;
            this.comboBoxSofor.DisplayMember = "SoforAdSoyad";
            this.comboBoxSofor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSofor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSofor.FormattingEnabled = true;
            this.comboBoxSofor.Location = new System.Drawing.Point(596, 57);
            this.comboBoxSofor.Name = "comboBoxSofor";
            this.comboBoxSofor.Size = new System.Drawing.Size(180, 24);
            this.comboBoxSofor.TabIndex = 65;
            this.comboBoxSofor.ValueMember = "SoforId";
            this.comboBoxSofor.SelectedIndexChanged += new System.EventHandler(this.comboBoxSofor_SelectedIndexChanged);
            // 
            // soforBindingSource
            // 
            this.soforBindingSource.DataSource = typeof(WindowsFormsApp1.Sofor);
            // 
            // comboBoxAliciFirma
            // 
            this.comboBoxAliciFirma.DataSource = this.cariUnvanFirmaBindingSource;
            this.comboBoxAliciFirma.DisplayMember = "CariUnvan_FirmaAd";
            this.comboBoxAliciFirma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAliciFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAliciFirma.FormattingEnabled = true;
            this.comboBoxAliciFirma.Location = new System.Drawing.Point(187, 155);
            this.comboBoxAliciFirma.Name = "comboBoxAliciFirma";
            this.comboBoxAliciFirma.Size = new System.Drawing.Size(180, 24);
            this.comboBoxAliciFirma.TabIndex = 66;
            this.comboBoxAliciFirma.ValueMember = "CariUnvan_FirmaId";
            this.comboBoxAliciFirma.SelectedIndexChanged += new System.EventHandler(this.comboBoxAliciFirma_SelectedIndexChanged);
            // 
            // cariUnvanFirmaBindingSource
            // 
            this.cariUnvanFirmaBindingSource.DataSource = typeof(WindowsFormsApp1.CariUnvan_Firma);
            // 
            // comboBoxSevkYeri
            // 
            this.comboBoxSevkYeri.DataSource = this.sevkYeriBindingSource;
            this.comboBoxSevkYeri.DisplayMember = "SevkYeriAdres";
            this.comboBoxSevkYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSevkYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSevkYeri.FormattingEnabled = true;
            this.comboBoxSevkYeri.Location = new System.Drawing.Point(187, 217);
            this.comboBoxSevkYeri.Name = "comboBoxSevkYeri";
            this.comboBoxSevkYeri.Size = new System.Drawing.Size(180, 24);
            this.comboBoxSevkYeri.TabIndex = 67;
            this.comboBoxSevkYeri.ValueMember = "SevkYeriId";
            this.comboBoxSevkYeri.SelectedIndexChanged += new System.EventHandler(this.comboBoxSevkYeri_SelectedIndexChanged);
            // 
            // sevkYeriBindingSource
            // 
            this.sevkYeriBindingSource.DataSource = typeof(WindowsFormsApp1.SevkYeri);
            // 
            // comboBoxMalzemeAd
            // 
            this.comboBoxMalzemeAd.DataSource = this.malzemeBindingSource;
            this.comboBoxMalzemeAd.DisplayMember = "MalzemeAd";
            this.comboBoxMalzemeAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMalzemeAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxMalzemeAd.FormattingEnabled = true;
            this.comboBoxMalzemeAd.Location = new System.Drawing.Point(187, 332);
            this.comboBoxMalzemeAd.Name = "comboBoxMalzemeAd";
            this.comboBoxMalzemeAd.Size = new System.Drawing.Size(180, 24);
            this.comboBoxMalzemeAd.TabIndex = 68;
            this.comboBoxMalzemeAd.ValueMember = "MalzemeId";
            this.comboBoxMalzemeAd.SelectedIndexChanged += new System.EventHandler(this.comboBoxMalzemeAd_SelectedIndexChanged);
            // 
            // malzemeBindingSource
            // 
            this.malzemeBindingSource.DataSource = typeof(WindowsFormsApp1.Malzeme);
            // 
            // textBoxIslemTarihi
            // 
            this.textBoxIslemTarihi.Enabled = false;
            this.textBoxIslemTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxIslemTarihi.Location = new System.Drawing.Point(596, 218);
            this.textBoxIslemTarihi.Name = "textBoxIslemTarihi";
            this.textBoxIslemTarihi.Size = new System.Drawing.Size(180, 23);
            this.textBoxIslemTarihi.TabIndex = 72;
            // 
            // textBoxBirimFiyat
            // 
            this.textBoxBirimFiyat.Enabled = false;
            this.textBoxBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBirimFiyat.Location = new System.Drawing.Point(596, 339);
            this.textBoxBirimFiyat.Name = "textBoxBirimFiyat";
            this.textBoxBirimFiyat.Size = new System.Drawing.Size(180, 23);
            this.textBoxBirimFiyat.TabIndex = 73;
            // 
            // textBoxToplamFiyat
            // 
            this.textBoxToplamFiyat.Enabled = false;
            this.textBoxToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxToplamFiyat.Location = new System.Drawing.Point(596, 397);
            this.textBoxToplamFiyat.Name = "textBoxToplamFiyat";
            this.textBoxToplamFiyat.Size = new System.Drawing.Size(180, 23);
            this.textBoxToplamFiyat.TabIndex = 74;
            // 
            // textBoxAgirlik
            // 
            this.textBoxAgirlik.Enabled = false;
            this.textBoxAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAgirlik.Location = new System.Drawing.Point(187, 400);
            this.textBoxAgirlik.Name = "textBoxAgirlik";
            this.textBoxAgirlik.Size = new System.Drawing.Size(180, 23);
            this.textBoxAgirlik.TabIndex = 75;
            // 
            // textBoxIslemKod
            // 
            this.textBoxIslemKod.Enabled = false;
            this.textBoxIslemKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxIslemKod.Location = new System.Drawing.Point(187, 537);
            this.textBoxIslemKod.Name = "textBoxIslemKod";
            this.textBoxIslemKod.Size = new System.Drawing.Size(180, 23);
            this.textBoxIslemKod.TabIndex = 76;
            // 
            // textBoxGunlukIslemKod
            // 
            this.textBoxGunlukIslemKod.Enabled = false;
            this.textBoxGunlukIslemKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGunlukIslemKod.Location = new System.Drawing.Point(596, 537);
            this.textBoxGunlukIslemKod.Name = "textBoxGunlukIslemKod";
            this.textBoxGunlukIslemKod.Size = new System.Drawing.Size(180, 23);
            this.textBoxGunlukIslemKod.TabIndex = 77;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ıconButton2);
            this.panel5.Controls.Add(this.ıconButton1);
            this.panel5.Controls.Add(this.BtnFormTemizle);
            this.panel5.Controls.Add(this.BtnKaydet);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 614);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1155, 50);
            this.panel5.TabIndex = 78;
            // 
            // ıconButton2
            // 
            this.ıconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ıconButton2.FlatAppearance.BorderSize = 3;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ıconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.ıconButton2.IconColor = System.Drawing.Color.DarkGreen;
            this.ıconButton2.IconSize = 32;
            this.ıconButton2.Location = new System.Drawing.Point(850, 0);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Rotation = 0D;
            this.ıconButton2.Size = new System.Drawing.Size(140, 50);
            this.ıconButton2.TabIndex = 27;
            this.ıconButton2.Text = "Çift Fiş";
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton2.UseVisualStyleBackColor = false;
            this.ıconButton2.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // ıconButton1
            // 
            this.ıconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ıconButton1.FlatAppearance.BorderSize = 3;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ıconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.ıconButton1.IconColor = System.Drawing.Color.DarkGreen;
            this.ıconButton1.IconSize = 32;
            this.ıconButton1.Location = new System.Drawing.Point(710, 0);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Rotation = 0D;
            this.ıconButton1.Size = new System.Drawing.Size(140, 50);
            this.ıconButton1.TabIndex = 26;
            this.ıconButton1.Text = "Tek Fiş";
            this.ıconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton1.UseVisualStyleBackColor = false;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
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
            this.BtnFormTemizle.Size = new System.Drawing.Size(355, 50);
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
            // comboBoxAracId
            // 
            this.comboBoxAracId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAracId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAracId.FormattingEnabled = true;
            this.comboBoxAracId.Location = new System.Drawing.Point(187, 84);
            this.comboBoxAracId.Name = "comboBoxAracId";
            this.comboBoxAracId.Size = new System.Drawing.Size(180, 24);
            this.comboBoxAracId.TabIndex = 79;
            this.comboBoxAracId.Visible = false;
            // 
            // comboBoxSoforId
            // 
            this.comboBoxSoforId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSoforId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSoforId.FormattingEnabled = true;
            this.comboBoxSoforId.Location = new System.Drawing.Point(596, 87);
            this.comboBoxSoforId.Name = "comboBoxSoforId";
            this.comboBoxSoforId.Size = new System.Drawing.Size(180, 24);
            this.comboBoxSoforId.TabIndex = 80;
            this.comboBoxSoforId.Visible = false;
            // 
            // comboBoxAliciFirmaId
            // 
            this.comboBoxAliciFirmaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAliciFirmaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAliciFirmaId.FormattingEnabled = true;
            this.comboBoxAliciFirmaId.Location = new System.Drawing.Point(187, 185);
            this.comboBoxAliciFirmaId.Name = "comboBoxAliciFirmaId";
            this.comboBoxAliciFirmaId.Size = new System.Drawing.Size(180, 24);
            this.comboBoxAliciFirmaId.TabIndex = 81;
            this.comboBoxAliciFirmaId.Visible = false;
            // 
            // comboBoxSevkYeriId
            // 
            this.comboBoxSevkYeriId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSevkYeriId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSevkYeriId.FormattingEnabled = true;
            this.comboBoxSevkYeriId.Location = new System.Drawing.Point(810, 441);
            this.comboBoxSevkYeriId.Name = "comboBoxSevkYeriId";
            this.comboBoxSevkYeriId.Size = new System.Drawing.Size(180, 24);
            this.comboBoxSevkYeriId.TabIndex = 82;
            this.comboBoxSevkYeriId.Visible = false;
            // 
            // comboBoxMalzemeId
            // 
            this.comboBoxMalzemeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMalzemeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxMalzemeId.FormattingEnabled = true;
            this.comboBoxMalzemeId.Location = new System.Drawing.Point(187, 362);
            this.comboBoxMalzemeId.Name = "comboBoxMalzemeId";
            this.comboBoxMalzemeId.Size = new System.Drawing.Size(180, 24);
            this.comboBoxMalzemeId.TabIndex = 84;
            this.comboBoxMalzemeId.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxGonderenFirma
            // 
            this.comboBoxGonderenFirma.Enabled = false;
            this.comboBoxGonderenFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxGonderenFirma.FormattingEnabled = true;
            this.comboBoxGonderenFirma.Location = new System.Drawing.Point(596, 162);
            this.comboBoxGonderenFirma.Name = "comboBoxGonderenFirma";
            this.comboBoxGonderenFirma.Size = new System.Drawing.Size(180, 24);
            this.comboBoxGonderenFirma.TabIndex = 87;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.DarkGreen;
            this.ıconPictureBox1.IconSize = 22;
            this.ıconPictureBox1.Location = new System.Drawing.Point(373, 54);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(22, 24);
            this.ıconPictureBox1.TabIndex = 88;
            this.ıconPictureBox1.TabStop = false;
            this.ıconPictureBox1.Click += new System.EventHandler(this.ıconPictureBox1_Click);
            // 
            // ıconPictureBox2
            // 
            this.ıconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ıconPictureBox2.IconColor = System.Drawing.Color.DarkGreen;
            this.ıconPictureBox2.IconSize = 22;
            this.ıconPictureBox2.Location = new System.Drawing.Point(782, 58);
            this.ıconPictureBox2.Name = "ıconPictureBox2";
            this.ıconPictureBox2.Size = new System.Drawing.Size(22, 24);
            this.ıconPictureBox2.TabIndex = 89;
            this.ıconPictureBox2.TabStop = false;
            this.ıconPictureBox2.Click += new System.EventHandler(this.ıconPictureBox2_Click);
            // 
            // ıconPictureBox3
            // 
            this.ıconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.ıconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ıconPictureBox3.IconColor = System.Drawing.Color.DarkGreen;
            this.ıconPictureBox3.IconSize = 22;
            this.ıconPictureBox3.Location = new System.Drawing.Point(373, 155);
            this.ıconPictureBox3.Name = "ıconPictureBox3";
            this.ıconPictureBox3.Size = new System.Drawing.Size(22, 24);
            this.ıconPictureBox3.TabIndex = 90;
            this.ıconPictureBox3.TabStop = false;
            this.ıconPictureBox3.Click += new System.EventHandler(this.ıconPictureBox3_Click);
            // 
            // ıconPictureBox4
            // 
            this.ıconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox4.ForeColor = System.Drawing.Color.DarkGreen;
            this.ıconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ıconPictureBox4.IconColor = System.Drawing.Color.DarkGreen;
            this.ıconPictureBox4.IconSize = 22;
            this.ıconPictureBox4.Location = new System.Drawing.Point(373, 218);
            this.ıconPictureBox4.Name = "ıconPictureBox4";
            this.ıconPictureBox4.Size = new System.Drawing.Size(22, 24);
            this.ıconPictureBox4.TabIndex = 91;
            this.ıconPictureBox4.TabStop = false;
            this.ıconPictureBox4.Click += new System.EventHandler(this.ıconPictureBox4_Click);
            // 
            // ıconPictureBox5
            // 
            this.ıconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox5.ForeColor = System.Drawing.Color.DarkGreen;
            this.ıconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ıconPictureBox5.IconColor = System.Drawing.Color.DarkGreen;
            this.ıconPictureBox5.IconSize = 22;
            this.ıconPictureBox5.Location = new System.Drawing.Point(373, 332);
            this.ıconPictureBox5.Name = "ıconPictureBox5";
            this.ıconPictureBox5.Size = new System.Drawing.Size(22, 24);
            this.ıconPictureBox5.TabIndex = 92;
            this.ıconPictureBox5.TabStop = false;
            this.ıconPictureBox5.Click += new System.EventHandler(this.ıconPictureBox5_Click);
            // 
            // textBoxTC
            // 
            this.textBoxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTC.Location = new System.Drawing.Point(187, 470);
            this.textBoxTC.MaxLength = 11;
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(180, 23);
            this.textBoxTC.TabIndex = 96;
            this.textBoxTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTC_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(54, 441);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label17.Size = new System.Drawing.Size(143, 17);
            this.label17.TabIndex = 94;
            this.label17.Text = "Ağırlık El ile Giriş";
            // 
            // ıconPictureBoxSahis
            // 
            this.ıconPictureBoxSahis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBoxSahis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxSahis.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.ıconPictureBoxSahis.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBoxSahis.Location = new System.Drawing.Point(15, 426);
            this.ıconPictureBoxSahis.Name = "ıconPictureBoxSahis";
            this.ıconPictureBoxSahis.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBoxSahis.TabIndex = 93;
            this.ıconPictureBoxSahis.TabStop = false;
            this.ıconPictureBoxSahis.Click += new System.EventHandler(this.ıconPictureBoxSahis_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(53, 476);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label18.Size = new System.Drawing.Size(63, 17);
            this.label18.TabIndex = 99;
            this.label18.Text = "Ağırlık";
            // 
            // ıconPictureBox6
            // 
            this.ıconPictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Weight;
            this.ıconPictureBox6.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox6.Location = new System.Drawing.Point(15, 464);
            this.ıconPictureBox6.Name = "ıconPictureBox6";
            this.ıconPictureBox6.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox6.TabIndex = 98;
            this.ıconPictureBox6.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cariUnvanFirmaBindingSource1;
            this.comboBox1.DisplayMember = "CariUnvan_FirmaAd";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 102;
            this.comboBox1.ValueMember = "CariUnvan_FirmaId";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cariUnvanFirmaBindingSource1
            // 
            this.cariUnvanFirmaBindingSource1.DataSource = typeof(WindowsFormsApp1.CariUnvan_Firma);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(53, 262);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label16.Size = new System.Drawing.Size(128, 17);
            this.label16.TabIndex = 101;
            this.label16.Text = "Nakliyeci Firma";
            // 
            // ıconPictureBox8
            // 
            this.ıconPictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.ıconPictureBox8.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox8.Location = new System.Drawing.Point(15, 247);
            this.ıconPictureBox8.Name = "ıconPictureBox8";
            this.ıconPictureBox8.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox8.TabIndex = 100;
            this.ıconPictureBox8.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(448, 473);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label19.Size = new System.Drawing.Size(91, 17);
            this.label19.TabIndex = 104;
            this.label19.Text = "Arac Dara";
            // 
            // ıconPictureBox7
            // 
            this.ıconPictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ıconPictureBox7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Weight;
            this.ıconPictureBox7.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox7.Location = new System.Drawing.Point(410, 461);
            this.ıconPictureBox7.Name = "ıconPictureBox7";
            this.ıconPictureBox7.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox7.TabIndex = 103;
            this.ıconPictureBox7.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(593, 478);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 17);
            this.label20.TabIndex = 105;
            // 
            // AracTartım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1155, 664);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ıconPictureBox7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ıconPictureBox8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ıconPictureBox6);
            this.Controls.Add(this.textBoxTC);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ıconPictureBoxSahis);
            this.Controls.Add(this.ıconPictureBox5);
            this.Controls.Add(this.ıconPictureBox4);
            this.Controls.Add(this.ıconPictureBox3);
            this.Controls.Add(this.ıconPictureBox2);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.comboBoxGonderenFirma);
            this.Controls.Add(this.comboBoxMalzemeId);
            this.Controls.Add(this.comboBoxSevkYeriId);
            this.Controls.Add(this.comboBoxAliciFirmaId);
            this.Controls.Add(this.comboBoxSoforId);
            this.Controls.Add(this.comboBoxAracId);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxGunlukIslemKod);
            this.Controls.Add(this.textBoxIslemKod);
            this.Controls.Add(this.textBoxAgirlik);
            this.Controls.Add(this.textBoxToplamFiyat);
            this.Controls.Add(this.textBoxBirimFiyat);
            this.Controls.Add(this.textBoxIslemTarihi);
            this.Controls.Add(this.comboBoxMalzemeAd);
            this.Controls.Add(this.comboBoxSevkYeri);
            this.Controls.Add(this.comboBoxAliciFirma);
            this.Controls.Add(this.comboBoxSofor);
            this.Controls.Add(this.comboBoxAracPlaka);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ıconPictureBoxGunlukKod);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ıconPictureBoxIslemKod);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ıconPictureBoxIslemTarihi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ıconPictureBoxToplamFiyat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ıconPictureBoxNetAgirlik);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ıconPictureBoxBirimFiyat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ıconPictureBoxMalzemeAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ıconPictureBoxSevkYeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ıconPictureBoxSofor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ıconPictureBoxGonderenFirma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ıconPictureBoxAliciFirma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ıconPictureBoxArac);
            this.Name = "AracTartım";
            this.Text = "AracTartım";
            this.Load += new System.EventHandler(this.AracTartım_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxMalzemeAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxSevkYeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxSofor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGonderenFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxAliciFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxArac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxNetAgirlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxToplamFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxIslemTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxIslemKod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxGunlukKod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariUnvanFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevkYeriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxSahis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariUnvanFirmaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxMalzemeAd;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxSevkYeri;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxSofor;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxGonderenFirma;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxAliciFirma;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxArac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxBirimFiyat;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxNetAgirlik;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxToplamFiyat;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxIslemTarihi;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxIslemKod;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxGunlukKod;
        private System.Windows.Forms.ComboBox comboBoxAracPlaka;
        private System.Windows.Forms.ComboBox comboBoxSofor;
        private System.Windows.Forms.ComboBox comboBoxAliciFirma;
        private System.Windows.Forms.ComboBox comboBoxSevkYeri;
        private System.Windows.Forms.ComboBox comboBoxMalzemeAd;
        private System.Windows.Forms.TextBox textBoxIslemTarihi;
        private System.Windows.Forms.TextBox textBoxBirimFiyat;
        private System.Windows.Forms.TextBox textBoxToplamFiyat;
        private System.Windows.Forms.TextBox textBoxAgirlik;
        private System.Windows.Forms.TextBox textBoxIslemKod;
        private System.Windows.Forms.TextBox textBoxGunlukIslemKod;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton BtnFormTemizle;
        private FontAwesome.Sharp.IconButton BtnKaydet;
        private System.Windows.Forms.ComboBox comboBoxAracId;
        private System.Windows.Forms.ComboBox comboBoxSoforId;
        private System.Windows.Forms.ComboBox comboBoxAliciFirmaId;
        private System.Windows.Forms.ComboBox comboBoxSevkYeriId;
        private System.Windows.Forms.ComboBox comboBoxMalzemeId;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxGonderenFirma;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox5;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxSahis;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox6;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private System.Windows.Forms.BindingSource aracBindingSource;
        private System.Windows.Forms.BindingSource soforBindingSource;
        private System.Windows.Forms.BindingSource cariUnvanFirmaBindingSource;
        private System.Windows.Forms.BindingSource sevkYeriBindingSource;
        private System.Windows.Forms.BindingSource malzemeBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox8;
        private System.Windows.Forms.BindingSource cariUnvanFirmaBindingSource1;
        private System.Windows.Forms.Label label19;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox7;
        private System.Windows.Forms.Label label20;
    }
}