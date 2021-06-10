namespace WindowsFormsApp1
{
    partial class Veritabanı
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ıconButtonYedekAl = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYedekYol = new System.Windows.Forms.TextBox();
            this.ıconButtonYedekleme = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ıconButtonYedektenSec = new FontAwesome.Sharp.IconButton();
            this.textBoxOkunanYedek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ıconButtonYedektanOku = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelYedekOku = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(151, 122);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(511, 23);
            this.progressBar.TabIndex = 0;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPercent.Location = new System.Drawing.Point(364, 152);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(30, 17);
            this.lblPercent.TabIndex = 1;
            this.lblPercent.Text = "%0";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(12, 196);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 2;
            // 
            // ıconButtonYedekAl
            // 
            this.ıconButtonYedekAl.FlatAppearance.BorderSize = 2;
            this.ıconButtonYedekAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonYedekAl.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ıconButtonYedekAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButtonYedekAl.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.ıconButtonYedekAl.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ıconButtonYedekAl.IconSize = 28;
            this.ıconButtonYedekAl.Location = new System.Drawing.Point(15, 113);
            this.ıconButtonYedekAl.Name = "ıconButtonYedekAl";
            this.ıconButtonYedekAl.Rotation = 0D;
            this.ıconButtonYedekAl.Size = new System.Drawing.Size(114, 40);
            this.ıconButtonYedekAl.TabIndex = 4;
            this.ıconButtonYedekAl.Text = "Yedekle";
            this.ıconButtonYedekAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonYedekAl.UseVisualStyleBackColor = true;
            this.ıconButtonYedekAl.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(151, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 3);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Veri Yedekleme ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Veri Yedekleme ";
            // 
            // textBoxYedekYol
            // 
            this.textBoxYedekYol.Enabled = false;
            this.textBoxYedekYol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYedekYol.Location = new System.Drawing.Point(151, 53);
            this.textBoxYedekYol.Name = "textBoxYedekYol";
            this.textBoxYedekYol.Size = new System.Drawing.Size(474, 23);
            this.textBoxYedekYol.TabIndex = 9;
            // 
            // ıconButtonYedekleme
            // 
            this.ıconButtonYedekleme.FlatAppearance.BorderSize = 2;
            this.ıconButtonYedekleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonYedekleme.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ıconButtonYedekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButtonYedekleme.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.ıconButtonYedekleme.IconColor = System.Drawing.Color.Green;
            this.ıconButtonYedekleme.IconSize = 28;
            this.ıconButtonYedekleme.Location = new System.Drawing.Point(637, 41);
            this.ıconButtonYedekleme.Name = "ıconButtonYedekleme";
            this.ıconButtonYedekleme.Rotation = 0D;
            this.ıconButtonYedekleme.Size = new System.Drawing.Size(114, 40);
            this.ıconButtonYedekleme.TabIndex = 10;
            this.ıconButtonYedekleme.Text = "Değiştir";
            this.ıconButtonYedekleme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonYedekleme.UseVisualStyleBackColor = true;
            this.ıconButtonYedekleme.Click += new System.EventHandler(this.ıconButtonYedekleme_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(151, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 3);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yedekten Yükleme";
            // 
            // ıconButtonYedektenSec
            // 
            this.ıconButtonYedektenSec.FlatAppearance.BorderSize = 2;
            this.ıconButtonYedektenSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonYedektenSec.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ıconButtonYedektenSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButtonYedektenSec.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.ıconButtonYedektenSec.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ıconButtonYedektenSec.IconSize = 28;
            this.ıconButtonYedektenSec.Location = new System.Drawing.Point(637, 295);
            this.ıconButtonYedektenSec.Name = "ıconButtonYedektenSec";
            this.ıconButtonYedektenSec.Rotation = 0D;
            this.ıconButtonYedektenSec.Size = new System.Drawing.Size(114, 40);
            this.ıconButtonYedektenSec.TabIndex = 18;
            this.ıconButtonYedektenSec.Text = "Seç";
            this.ıconButtonYedektenSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonYedektenSec.UseVisualStyleBackColor = true;
            this.ıconButtonYedektenSec.Click += new System.EventHandler(this.ıconButtonYedektenSec_Click);
            // 
            // textBoxOkunanYedek
            // 
            this.textBoxOkunanYedek.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOkunanYedek.Enabled = false;
            this.textBoxOkunanYedek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOkunanYedek.Location = new System.Drawing.Point(151, 307);
            this.textBoxOkunanYedek.Name = "textBoxOkunanYedek";
            this.textBoxOkunanYedek.Size = new System.Drawing.Size(474, 23);
            this.textBoxOkunanYedek.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yedekten Oku";
            // 
            // ıconButtonYedektanOku
            // 
            this.ıconButtonYedektanOku.FlatAppearance.BorderSize = 2;
            this.ıconButtonYedektanOku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonYedektanOku.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ıconButtonYedektanOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButtonYedektanOku.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.ıconButtonYedektanOku.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ıconButtonYedektanOku.IconSize = 28;
            this.ıconButtonYedektanOku.Location = new System.Drawing.Point(15, 367);
            this.ıconButtonYedektanOku.Name = "ıconButtonYedektanOku";
            this.ıconButtonYedektanOku.Rotation = 0D;
            this.ıconButtonYedektanOku.Size = new System.Drawing.Size(114, 40);
            this.ıconButtonYedektanOku.TabIndex = 15;
            this.ıconButtonYedektanOku.Text = "Yükle";
            this.ıconButtonYedektanOku.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonYedektanOku.UseVisualStyleBackColor = true;
            this.ıconButtonYedektanOku.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(364, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "%0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(151, 376);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(511, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // labelYedekOku
            // 
            this.labelYedekOku.AutoSize = true;
            this.labelYedekOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYedekOku.Location = new System.Drawing.Point(12, 441);
            this.labelYedekOku.Name = "labelYedekOku";
            this.labelYedekOku.Size = new System.Drawing.Size(0, 17);
            this.labelYedekOku.TabIndex = 19;
            // 
            // Veritabanı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.labelYedekOku);
            this.Controls.Add(this.ıconButtonYedektenSec);
            this.Controls.Add(this.textBoxOkunanYedek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ıconButtonYedektanOku);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ıconButtonYedekleme);
            this.Controls.Add(this.textBoxYedekYol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ıconButtonYedekAl);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.progressBar);
            this.Name = "Veritabanı";
            this.Text = "Veritabanı";
            this.Load += new System.EventHandler(this.Veritabanı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblStatus;
        private FontAwesome.Sharp.IconButton ıconButtonYedekAl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYedekYol;
        private FontAwesome.Sharp.IconButton ıconButtonYedekleme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ıconButtonYedektenSec;
        private System.Windows.Forms.TextBox textBoxOkunanYedek;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton ıconButtonYedektanOku;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelYedekOku;
    }
}