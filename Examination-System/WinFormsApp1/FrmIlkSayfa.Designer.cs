
namespace WinFormsApp1
{
    partial class FrmIlkSayfa
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
            this.components = new System.ComponentModel.Container();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.adminBoxBTN = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OgrenciBoxBTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminBoxBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciBoxBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // adminBoxBTN
            // 
            this.adminBoxBTN.Image = global::WinFormsApp1.Properties.Resources.admin2;
            this.adminBoxBTN.Location = new System.Drawing.Point(128, 56);
            this.adminBoxBTN.Name = "adminBoxBTN";
            this.adminBoxBTN.Size = new System.Drawing.Size(157, 163);
            this.adminBoxBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminBoxBTN.TabIndex = 1;
            this.adminBoxBTN.TabStop = false;
            this.adminBoxBTN.Click += new System.EventHandler(this.AdminBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(177, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(169, 483);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğrenci";
            // 
            // OgrenciBoxBTN
            // 
            this.OgrenciBoxBTN.Image = global::WinFormsApp1.Properties.Resources.firstuser;
            this.OgrenciBoxBTN.Location = new System.Drawing.Point(128, 302);
            this.OgrenciBoxBTN.Name = "OgrenciBoxBTN";
            this.OgrenciBoxBTN.Size = new System.Drawing.Size(157, 163);
            this.OgrenciBoxBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OgrenciBoxBTN.TabIndex = 3;
            this.OgrenciBoxBTN.TabStop = false;
            this.OgrenciBoxBTN.Click += new System.EventHandler(this.ogrenciBTN_Click);
            // 
            // FrmIlkSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(417, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OgrenciBoxBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminBoxBTN);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIlkSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIlkSayfa";
            ((System.ComponentModel.ISupportInitialize)(this.adminBoxBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciBoxBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox adminBoxBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox OgrenciBoxBTN;
    }
}

