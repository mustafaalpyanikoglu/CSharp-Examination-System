
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
            this.label3 = new System.Windows.Forms.Label();
            this.SınavHazırlaBoxBTN = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SoruOnaylaBoxBTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SınavHazırlaBoxBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoruOnaylaBoxBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(151, 461);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sınav Hazırla";
            // 
            // SınavHazırlaBoxBTN
            // 
            this.SınavHazırlaBoxBTN.Image = global::WinFormsApp1.Properties.Resources.admin2;
            this.SınavHazırlaBoxBTN.Location = new System.Drawing.Point(135, 286);
            this.SınavHazırlaBoxBTN.Name = "SınavHazırlaBoxBTN";
            this.SınavHazırlaBoxBTN.Size = new System.Drawing.Size(157, 163);
            this.SınavHazırlaBoxBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SınavHazırlaBoxBTN.TabIndex = 10;
            this.SınavHazırlaBoxBTN.TabStop = false;
            this.SınavHazırlaBoxBTN.Click += new System.EventHandler(this.SınavHazırlaBoxBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(158, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Soru Onayla";
            // 
            // SoruOnaylaBoxBTN
            // 
            this.SoruOnaylaBoxBTN.Image = global::WinFormsApp1.Properties.Resources.admin2;
            this.SoruOnaylaBoxBTN.Location = new System.Drawing.Point(135, 51);
            this.SoruOnaylaBoxBTN.Name = "SoruOnaylaBoxBTN";
            this.SoruOnaylaBoxBTN.Size = new System.Drawing.Size(157, 163);
            this.SoruOnaylaBoxBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SoruOnaylaBoxBTN.TabIndex = 7;
            this.SoruOnaylaBoxBTN.TabStop = false;
            this.SoruOnaylaBoxBTN.Click += new System.EventHandler(this.SoruOnaylaBoxBTN_Click);
            // 
            // FrmPrepareExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(417, 552);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SınavHazırlaBoxBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoruOnaylaBoxBTN);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrepareExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrepareExam";
            ((System.ComponentModel.ISupportInitialize)(this.SınavHazırlaBoxBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoruOnaylaBoxBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox SınavHazırlaBoxBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SoruOnaylaBoxBTN;
    }
}