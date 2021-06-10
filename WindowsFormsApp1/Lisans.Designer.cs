namespace WindowsFormsApp1
{
    partial class Lisans
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.windowsAuthentication = new System.Windows.Forms.CheckBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(543, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lisans Anahtarı :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(149, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aktifleştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(149, 73);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(543, 20);
            this.Server.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server              :";
            // 
            // windowsAuthentication
            // 
            this.windowsAuthentication.AutoSize = true;
            this.windowsAuthentication.Location = new System.Drawing.Point(149, 99);
            this.windowsAuthentication.Name = "windowsAuthentication";
            this.windowsAuthentication.Size = new System.Drawing.Size(141, 17);
            this.windowsAuthentication.TabIndex = 7;
            this.windowsAuthentication.Text = "Windows Authentication";
            this.windowsAuthentication.UseVisualStyleBackColor = true;
            this.windowsAuthentication.CheckStateChanged += new System.EventHandler(this.windowsAuthentication_CheckStateChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(149, 122);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(543, 20);
            this.Login.TabIndex = 8;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(149, 148);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(543, 20);
            this.Password.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Login               :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password         :";
            // 
            // Lisans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.windowsAuthentication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Name = "Lisans";
            this.Text = "Lisans";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lisans_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox windowsAuthentication;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}