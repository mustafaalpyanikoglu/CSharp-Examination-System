
namespace WinFormsApp1
{
    partial class FrmAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.SoruOnaylaBoxBTN = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SoruOnaylaBoxBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(157, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Soru Onayla";
            // 
            // SoruOnaylaBoxBTN
            // 
            this.SoruOnaylaBoxBTN.Image = ((System.Drawing.Image)(resources.GetObject("SoruOnaylaBoxBTN.Image")));
            this.SoruOnaylaBoxBTN.Location = new System.Drawing.Point(134, 151);
            this.SoruOnaylaBoxBTN.Name = "SoruOnaylaBoxBTN";
            this.SoruOnaylaBoxBTN.Size = new System.Drawing.Size(157, 163);
            this.SoruOnaylaBoxBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SoruOnaylaBoxBTN.TabIndex = 7;
            this.SoruOnaylaBoxBTN.TabStop = false;
            this.SoruOnaylaBoxBTN.Click += new System.EventHandler(this.SoruOnaylaBoxBTN_Click);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(372, 9);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(36, 35);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 95;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // FrmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(417, 552);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoruOnaylaBoxBTN);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrepareExam";
            ((System.ComponentModel.ISupportInitialize)(this.SoruOnaylaBoxBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SoruOnaylaBoxBTN;
        private System.Windows.Forms.PictureBox closePictureBox;
    }
}