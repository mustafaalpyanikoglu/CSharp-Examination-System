
namespace WinFormsApp1
{
    partial class FrmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.girisBTN = new System.Windows.Forms.Button();
            this.kayıtOlBTN = new System.Windows.Forms.Button();
            this.SifreUnuttumBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.rename;
            this.pictureBox1.Location = new System.Drawing.Point(162, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormsApp1.Properties.Resources.adsoyad2;
            this.pictureBox2.Location = new System.Drawing.Point(42, 191);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.kullaniciAdiTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciAdiTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(82, 197);
            this.kullaniciAdiTxt.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(293, 23);
            this.kullaniciAdiTxt.TabIndex = 11;
            this.kullaniciAdiTxt.TabStop = false;
            this.kullaniciAdiTxt.Text = "Kullanıcı Adı";
            this.kullaniciAdiTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kullaniciAdiTxt_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(42, 228);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 1);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(42, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 1);
            this.panel2.TabIndex = 15;
            // 
            // sifreTxt
            // 
            this.sifreTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.sifreTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifreTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.sifreTxt.Location = new System.Drawing.Point(82, 274);
            this.sifreTxt.Margin = new System.Windows.Forms.Padding(4);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(293, 23);
            this.sifreTxt.TabIndex = 14;
            this.sifreTxt.TabStop = false;
            this.sifreTxt.Text = "Şifre";
            this.sifreTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sifreTxt_MouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinFormsApp1.Properties.Resources.şifreM;
            this.pictureBox3.Location = new System.Drawing.Point(42, 268);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // girisBTN
            // 
            this.girisBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.girisBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisBTN.Location = new System.Drawing.Point(42, 346);
            this.girisBTN.Margin = new System.Windows.Forms.Padding(4);
            this.girisBTN.Name = "girisBTN";
            this.girisBTN.Size = new System.Drawing.Size(333, 43);
            this.girisBTN.TabIndex = 16;
            this.girisBTN.TabStop = false;
            this.girisBTN.Text = "Giriş Yap";
            this.girisBTN.UseVisualStyleBackColor = false;
            this.girisBTN.Click += new System.EventHandler(this.girisBTN_Click);
            // 
            // kayıtOlBTN
            // 
            this.kayıtOlBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.kayıtOlBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayıtOlBTN.Location = new System.Drawing.Point(42, 406);
            this.kayıtOlBTN.Margin = new System.Windows.Forms.Padding(4);
            this.kayıtOlBTN.Name = "kayıtOlBTN";
            this.kayıtOlBTN.Size = new System.Drawing.Size(333, 43);
            this.kayıtOlBTN.TabIndex = 17;
            this.kayıtOlBTN.TabStop = false;
            this.kayıtOlBTN.Text = "Kayıt Ol";
            this.kayıtOlBTN.UseVisualStyleBackColor = false;
            this.kayıtOlBTN.Click += new System.EventHandler(this.kayıtOlBTN_Click);
            // 
            // SifreUnuttumBTN
            // 
            this.SifreUnuttumBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.SifreUnuttumBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SifreUnuttumBTN.Location = new System.Drawing.Point(42, 462);
            this.SifreUnuttumBTN.Margin = new System.Windows.Forms.Padding(4);
            this.SifreUnuttumBTN.Name = "SifreUnuttumBTN";
            this.SifreUnuttumBTN.Size = new System.Drawing.Size(333, 43);
            this.SifreUnuttumBTN.TabIndex = 18;
            this.SifreUnuttumBTN.TabStop = false;
            this.SifreUnuttumBTN.Text = "Şifremi Unuttum";
            this.SifreUnuttumBTN.UseVisualStyleBackColor = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(417, 552);
            this.Controls.Add(this.SifreUnuttumBTN);
            this.Controls.Add(this.kayıtOlBTN);
            this.Controls.Add(this.girisBTN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox kullaniciAdiTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button girisBTN;
        private System.Windows.Forms.Button kayıtOlBTN;
        private System.Windows.Forms.Button SifreUnuttumBTN;
    }
}