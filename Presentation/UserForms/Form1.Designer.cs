namespace UserForms
{
    partial class frmUserAdd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailTekrar = new System.Windows.Forms.Label();
            this.txtEmailTekrar = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblNick = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblÖzelSoru = new System.Windows.Forms.Label();
            this.txtÖzelCevap = new System.Windows.Forms.TextBox();
            this.cmbÖzelSoru = new System.Windows.Forms.ComboBox();
            this.lblÖzelCevap = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbluyarinick = new System.Windows.Forms.Label();
            this.lbluyariözelsoru = new System.Windows.Forms.Label();
            this.lbluyarisifre = new System.Windows.Forms.Label();
            this.lbluyaritemailtekrar = new System.Windows.Forms.Label();
            this.lbluyariemail = new System.Windows.Forms.Label();
            this.lbluyarisayad = new System.Windows.Forms.Label();
            this.lbluyariad = new System.Windows.Forms.Label();
            this.lbluyariözelcevap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(424, 100);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(151, 27);
            this.txtAd.TabIndex = 0;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAd.Location = new System.Drawing.Point(301, 103);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(78, 25);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Adiniz  :";
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(226, 483);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(94, 29);
            this.btnKayit.TabIndex = 2;
            this.btnKayit.Text = "Kayit ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(657, 483);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(94, 29);
            this.btniptal.TabIndex = 3;
            this.btniptal.Text = "Iptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoyad.Location = new System.Drawing.Point(283, 159);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(100, 25);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyadiniz :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(424, 156);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(151, 27);
            this.txtSoyad.TabIndex = 4;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(300, 215);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 25);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-Mail  :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(424, 212);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 27);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmailTekrar
            // 
            this.lblEmailTekrar.AutoSize = true;
            this.lblEmailTekrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailTekrar.Location = new System.Drawing.Point(213, 271);
            this.lblEmailTekrar.Name = "lblEmailTekrar";
            this.lblEmailTekrar.Size = new System.Drawing.Size(189, 25);
            this.lblEmailTekrar.TabIndex = 9;
            this.lblEmailTekrar.Text = "E-Mail tekrar giriniz  :";
            // 
            // txtEmailTekrar
            // 
            this.txtEmailTekrar.Location = new System.Drawing.Point(424, 268);
            this.txtEmailTekrar.Name = "txtEmailTekrar";
            this.txtEmailTekrar.Size = new System.Drawing.Size(151, 27);
            this.txtEmailTekrar.TabIndex = 8;
            this.txtEmailTekrar.TextChanged += new System.EventHandler(this.txtEmailTekrar_TextChanged);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSifre.Location = new System.Drawing.Point(294, 327);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(88, 25);
            this.lblSifre.TabIndex = 11;
            this.lblSifre.Text = "Sifreniz  :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(424, 324);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(151, 27);
            this.txtSifre.TabIndex = 10;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNick.Location = new System.Drawing.Point(214, 47);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(188, 25);
            this.lblNick.TabIndex = 13;
            this.lblNick.Text = "Kullanici Adi Giriniz  :";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(424, 44);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(151, 27);
            this.txtNick.TabIndex = 12;
            this.txtNick.TextChanged += new System.EventHandler(this.txtNick_TextChanged);
            // 
            // lblÖzelSoru
            // 
            this.lblÖzelSoru.AutoSize = true;
            this.lblÖzelSoru.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblÖzelSoru.Location = new System.Drawing.Point(205, 383);
            this.lblÖzelSoru.Name = "lblÖzelSoru";
            this.lblÖzelSoru.Size = new System.Drawing.Size(201, 25);
            this.lblÖzelSoru.TabIndex = 15;
            this.lblÖzelSoru.Text = "Kullanici Özel Sorusu  :";
            // 
            // txtÖzelCevap
            // 
            this.txtÖzelCevap.Location = new System.Drawing.Point(424, 432);
            this.txtÖzelCevap.Name = "txtÖzelCevap";
            this.txtÖzelCevap.Size = new System.Drawing.Size(151, 27);
            this.txtÖzelCevap.TabIndex = 14;
            this.txtÖzelCevap.TextChanged += new System.EventHandler(this.txtÖzelCevap_TextChanged);
            // 
            // cmbÖzelSoru
            // 
            this.cmbÖzelSoru.FormattingEnabled = true;
            this.cmbÖzelSoru.Items.AddRange(new object[] {
            "En Sevdiginiz Ders nedir ?",
            "En cok sevdiginiz Kitap nedir ?",
            "En cok sevdiginiz spor nedir ?",
            "Bos vaktinizde  en  cok ne yapmaktan hoslanirsiniz ?"});
            this.cmbÖzelSoru.Location = new System.Drawing.Point(424, 379);
            this.cmbÖzelSoru.Name = "cmbÖzelSoru";
            this.cmbÖzelSoru.Size = new System.Drawing.Size(151, 28);
            this.cmbÖzelSoru.TabIndex = 16;
            this.cmbÖzelSoru.Text = "Özel soru seciniz...";
            // 
            // lblÖzelCevap
            // 
            this.lblÖzelCevap.AutoSize = true;
            this.lblÖzelCevap.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblÖzelCevap.Location = new System.Drawing.Point(230, 435);
            this.lblÖzelCevap.Name = "lblÖzelCevap";
            this.lblÖzelCevap.Size = new System.Drawing.Size(167, 25);
            this.lblÖzelCevap.TabIndex = 17;
            this.lblÖzelCevap.Text = "Özel Soru Cevabi  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(294, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(562, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Özel Soru Cevabi  : Bu cevap sifrenizi unuttugunuzda cok önemli!!!";
            // 
            // lbluyarinick
            // 
            this.lbluyarinick.AutoSize = true;
            this.lbluyarinick.BackColor = System.Drawing.Color.White;
            this.lbluyarinick.ForeColor = System.Drawing.Color.Red;
            this.lbluyarinick.Location = new System.Drawing.Point(603, 51);
            this.lbluyarinick.Name = "lbluyarinick";
            this.lbluyarinick.Size = new System.Drawing.Size(15, 20);
            this.lbluyarinick.TabIndex = 19;
            this.lbluyarinick.Text = "*";
            this.lbluyarinick.Visible = false;
            // 
            // lbluyariözelsoru
            // 
            this.lbluyariözelsoru.AutoSize = true;
            this.lbluyariözelsoru.BackColor = System.Drawing.Color.White;
            this.lbluyariözelsoru.ForeColor = System.Drawing.Color.Red;
            this.lbluyariözelsoru.Location = new System.Drawing.Point(603, 387);
            this.lbluyariözelsoru.Name = "lbluyariözelsoru";
            this.lbluyariözelsoru.Size = new System.Drawing.Size(15, 20);
            this.lbluyariözelsoru.TabIndex = 20;
            this.lbluyariözelsoru.Text = "*";
            this.lbluyariözelsoru.Visible = false;
            // 
            // lbluyarisifre
            // 
            this.lbluyarisifre.AutoSize = true;
            this.lbluyarisifre.BackColor = System.Drawing.Color.White;
            this.lbluyarisifre.ForeColor = System.Drawing.Color.Red;
            this.lbluyarisifre.Location = new System.Drawing.Point(603, 331);
            this.lbluyarisifre.Name = "lbluyarisifre";
            this.lbluyarisifre.Size = new System.Drawing.Size(15, 20);
            this.lbluyarisifre.TabIndex = 21;
            this.lbluyarisifre.Text = "*";
            this.lbluyarisifre.Visible = false;
            // 
            // lbluyaritemailtekrar
            // 
            this.lbluyaritemailtekrar.AutoSize = true;
            this.lbluyaritemailtekrar.BackColor = System.Drawing.Color.White;
            this.lbluyaritemailtekrar.ForeColor = System.Drawing.Color.Red;
            this.lbluyaritemailtekrar.Location = new System.Drawing.Point(603, 275);
            this.lbluyaritemailtekrar.Name = "lbluyaritemailtekrar";
            this.lbluyaritemailtekrar.Size = new System.Drawing.Size(15, 20);
            this.lbluyaritemailtekrar.TabIndex = 22;
            this.lbluyaritemailtekrar.Text = "*";
            this.lbluyaritemailtekrar.Visible = false;
            // 
            // lbluyariemail
            // 
            this.lbluyariemail.AutoSize = true;
            this.lbluyariemail.BackColor = System.Drawing.Color.White;
            this.lbluyariemail.ForeColor = System.Drawing.Color.Red;
            this.lbluyariemail.Location = new System.Drawing.Point(603, 219);
            this.lbluyariemail.Name = "lbluyariemail";
            this.lbluyariemail.Size = new System.Drawing.Size(15, 20);
            this.lbluyariemail.TabIndex = 23;
            this.lbluyariemail.Text = "*";
            this.lbluyariemail.Visible = false;
            // 
            // lbluyarisayad
            // 
            this.lbluyarisayad.AutoSize = true;
            this.lbluyarisayad.BackColor = System.Drawing.Color.White;
            this.lbluyarisayad.ForeColor = System.Drawing.Color.Red;
            this.lbluyarisayad.Location = new System.Drawing.Point(603, 163);
            this.lbluyarisayad.Name = "lbluyarisayad";
            this.lbluyarisayad.Size = new System.Drawing.Size(15, 20);
            this.lbluyarisayad.TabIndex = 24;
            this.lbluyarisayad.Text = "*";
            this.lbluyarisayad.Visible = false;
            // 
            // lbluyariad
            // 
            this.lbluyariad.AutoSize = true;
            this.lbluyariad.BackColor = System.Drawing.Color.White;
            this.lbluyariad.ForeColor = System.Drawing.Color.Red;
            this.lbluyariad.Location = new System.Drawing.Point(603, 103);
            this.lbluyariad.Name = "lbluyariad";
            this.lbluyariad.Size = new System.Drawing.Size(15, 20);
            this.lbluyariad.TabIndex = 25;
            this.lbluyariad.Text = "*";
            this.lbluyariad.Visible = false;
            // 
            // lbluyariözelcevap
            // 
            this.lbluyariözelcevap.AutoSize = true;
            this.lbluyariözelcevap.BackColor = System.Drawing.Color.White;
            this.lbluyariözelcevap.ForeColor = System.Drawing.Color.Red;
            this.lbluyariözelcevap.Location = new System.Drawing.Point(603, 439);
            this.lbluyariözelcevap.Name = "lbluyariözelcevap";
            this.lbluyariözelcevap.Size = new System.Drawing.Size(15, 20);
            this.lbluyariözelcevap.TabIndex = 26;
            this.lbluyariözelcevap.Text = "*";
            this.lbluyariözelcevap.Visible = false;
            // 
            // frmUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 540);
            this.Controls.Add(this.lbluyariözelcevap);
            this.Controls.Add(this.lbluyariad);
            this.Controls.Add(this.lbluyarisayad);
            this.Controls.Add(this.lbluyariemail);
            this.Controls.Add(this.lbluyaritemailtekrar);
            this.Controls.Add(this.lbluyarisifre);
            this.Controls.Add(this.lbluyariözelsoru);
            this.Controls.Add(this.lbluyarinick);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblÖzelCevap);
            this.Controls.Add(this.cmbÖzelSoru);
            this.Controls.Add(this.lblÖzelSoru);
            this.Controls.Add(this.txtÖzelCevap);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblEmailTekrar);
            this.Controls.Add(this.txtEmailTekrar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici Kayit Ekrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAd;
        private Label lblAd;
        private Button btnKayit;
        private Button btniptal;
        private Label lblSoyad;
        private TextBox txtSoyad;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblEmailTekrar;
        private TextBox txtEmailTekrar;
        private Label lblSifre;
        private TextBox txtSifre;
        private Label lblNick;
        private TextBox txtNick;
        private Label lblÖzelSoru;
        private TextBox txtÖzelCevap;
        private ComboBox cmbÖzelSoru;
        private Label lblÖzelCevap;
        private Label label9;
        private Label lbluyarinick;
        private Label lbluyariözelsoru;
        private Label lbluyarisifre;
        private Label lbluyaritemailtekrar;
        private Label lbluyariemail;
        private Label lbluyarisayad;
        private Label lbluyariad;
        private Label lbluyariözelcevap;
    }
}