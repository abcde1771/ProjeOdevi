namespace ProjeOdevi
{
    partial class Form5
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
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.onay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici Adi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(159, 93);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(120, 20);
            this.txtKullanici.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yeni Sifre:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSifre1
            // 
            this.txtSifre1.Location = new System.Drawing.Point(159, 134);
            this.txtSifre1.Name = "txtSifre1";
            this.txtSifre1.PasswordChar = '*';
            this.txtSifre1.Size = new System.Drawing.Size(120, 20);
            this.txtSifre1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sifre Tekrar:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSifre2
            // 
            this.txtSifre2.Location = new System.Drawing.Point(159, 173);
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.PasswordChar = '*';
            this.txtSifre2.Size = new System.Drawing.Size(120, 20);
            this.txtSifre2.TabIndex = 1;
            // 
            // onay
            // 
            this.onay.Location = new System.Drawing.Point(148, 250);
            this.onay.Name = "onay";
            this.onay.Size = new System.Drawing.Size(75, 23);
            this.onay.TabIndex = 2;
            this.onay.Text = "Tamam";
            this.onay.UseVisualStyleBackColor = true;
            this.onay.Click += new System.EventHandler(this.onay_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 385);
            this.Controls.Add(this.onay);
            this.Controls.Add(this.txtSifre2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre2;
        private System.Windows.Forms.Button onay;
    }
}