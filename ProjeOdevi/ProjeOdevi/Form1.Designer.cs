namespace ProjeOdevi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.unut = new System.Windows.Forms.LinkLabel();
            this.beniHatirla = new System.Windows.Forms.CheckBox();
            this.giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sifre:";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(238, 207);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(178, 20);
            this.kullaniciAdi.TabIndex = 1;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(238, 255);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(178, 20);
            this.sifre.TabIndex = 1;
            // 
            // unut
            // 
            this.unut.AutoSize = true;
            this.unut.Location = new System.Drawing.Point(166, 301);
            this.unut.Name = "unut";
            this.unut.Size = new System.Drawing.Size(134, 13);
            this.unut.TabIndex = 2;
            this.unut.TabStop = true;
            this.unut.Text = "Kullanici Bilgilerimi Unuttum";
            this.unut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.unut_LinkClicked);
            // 
            // beniHatirla
            // 
            this.beniHatirla.AutoSize = true;
            this.beniHatirla.Location = new System.Drawing.Point(169, 343);
            this.beniHatirla.Name = "beniHatirla";
            this.beniHatirla.Size = new System.Drawing.Size(80, 17);
            this.beniHatirla.TabIndex = 3;
            this.beniHatirla.Text = "Beni Hatirla";
            this.beniHatirla.UseVisualStyleBackColor = true;
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(341, 332);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(75, 28);
            this.giris.TabIndex = 4;
            this.giris.Text = "Giris";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.beniHatirla);
            this.Controls.Add(this.unut);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.LinkLabel unut;
        private System.Windows.Forms.CheckBox beniHatirla;
        private System.Windows.Forms.Button giris;
    }
}

