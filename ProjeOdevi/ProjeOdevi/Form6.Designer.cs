namespace ProjeOdevi
{
    partial class Form6
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnInternet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDakika = new System.Windows.Forms.TextBox();
            this.btnDakika = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.btnSMS = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Internet:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(162, 59);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 1;
            // 
            // btnInternet
            // 
            this.btnInternet.Location = new System.Drawing.Point(315, 59);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(75, 23);
            this.btnInternet.TabIndex = 2;
            this.btnInternet.Text = "Kullan";
            this.btnInternet.UseVisualStyleBackColor = true;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dakika:";
            // 
            // txtDakika
            // 
            this.txtDakika.Location = new System.Drawing.Point(162, 111);
            this.txtDakika.Name = "txtDakika";
            this.txtDakika.Size = new System.Drawing.Size(100, 20);
            this.txtDakika.TabIndex = 1;
            // 
            // btnDakika
            // 
            this.btnDakika.Location = new System.Drawing.Point(315, 111);
            this.btnDakika.Name = "btnDakika";
            this.btnDakika.Size = new System.Drawing.Size(75, 23);
            this.btnDakika.TabIndex = 2;
            this.btnDakika.Text = "Kullan";
            this.btnDakika.UseVisualStyleBackColor = true;
            this.btnDakika.Click += new System.EventHandler(this.btnDakika_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SMS:";
            // 
            // txtSMS
            // 
            this.txtSMS.Location = new System.Drawing.Point(162, 164);
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(100, 20);
            this.txtSMS.TabIndex = 1;
            // 
            // btnSMS
            // 
            this.btnSMS.Location = new System.Drawing.Point(315, 164);
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.Size = new System.Drawing.Size(75, 23);
            this.btnSMS.TabIndex = 2;
            this.btnSMS.Text = "Kullan";
            this.btnSMS.UseVisualStyleBackColor = true;
            this.btnSMS.Click += new System.EventHandler(this.btnSMS_Click);
            // 
            // btnCik
            // 
            this.btnCik.Location = new System.Drawing.Point(315, 230);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(75, 23);
            this.btnCik.TabIndex = 2;
            this.btnCik.Text = "Cikis";
            this.btnCik.UseVisualStyleBackColor = true;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 303);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnSMS);
            this.Controls.Add(this.txtSMS);
            this.Controls.Add(this.btnDakika);
            this.Controls.Add(this.txtDakika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInternet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDakika;
        private System.Windows.Forms.Button btnDakika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSMS;
        private System.Windows.Forms.Button btnSMS;
        private System.Windows.Forms.Button btnCik;
    }
}