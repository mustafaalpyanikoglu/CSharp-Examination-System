
namespace WinFormsApp1
{
    partial class FrmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForgotPassword));
            this.sifreHatirlaBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.eMailTxt = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // sifreHatirlaBTN
            // 
            this.sifreHatirlaBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.sifreHatirlaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifreHatirlaBTN.Location = new System.Drawing.Point(42, 411);
            this.sifreHatirlaBTN.Margin = new System.Windows.Forms.Padding(4);
            this.sifreHatirlaBTN.Name = "sifreHatirlaBTN";
            this.sifreHatirlaBTN.Size = new System.Drawing.Size(333, 43);
            this.sifreHatirlaBTN.TabIndex = 24;
            this.sifreHatirlaBTN.TabStop = false;
            this.sifreHatirlaBTN.Text = "Şifremi Hatırla";
            this.sifreHatirlaBTN.UseVisualStyleBackColor = false;
            this.sifreHatirlaBTN.Click += new System.EventHandler(this.sifreHatirlaBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(42, 288);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 1);
            this.panel1.TabIndex = 20;
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.kullaniciAdiTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciAdiTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(82, 257);
            this.kullaniciAdiTxt.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(293, 23);
            this.kullaniciAdiTxt.TabIndex = 19;
            this.kullaniciAdiTxt.TabStop = false;
            this.kullaniciAdiTxt.Text = "Kullanıcı Adı";
            this.kullaniciAdiTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kullaniciAdiTxt_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormsApp1.Properties.Resources.adsoyad2;
            this.pictureBox2.Location = new System.Drawing.Point(42, 251);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.rename;
            this.pictureBox1.Location = new System.Drawing.Point(162, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(42, 353);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 1);
            this.panel4.TabIndex = 29;
            // 
            // eMailTxt
            // 
            this.eMailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.eMailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eMailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.eMailTxt.Location = new System.Drawing.Point(82, 322);
            this.eMailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.eMailTxt.Name = "eMailTxt";
            this.eMailTxt.Size = new System.Drawing.Size(293, 23);
            this.eMailTxt.TabIndex = 28;
            this.eMailTxt.TabStop = false;
            this.eMailTxt.Text = "e-Mail";
            this.eMailTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eMailTxt_MouseClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(42, 316);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // FrmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(417, 552);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.eMailTxt);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.sifreHatirlaBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sifreHatirlaBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox kullaniciAdiTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox eMailTxt;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}