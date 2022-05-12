
namespace WinFormsApp1
{
    partial class FrmMusteriMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.SinavaGirBoxBTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SinavaGirBoxBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(159, 332);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sınava Gir";
            // 
            // SinavaGirBoxBTN
            // 
            this.SinavaGirBoxBTN.Image = ((System.Drawing.Image)(resources.GetObject("SinavaGirBoxBTN.Image")));
            this.SinavaGirBoxBTN.Location = new System.Drawing.Point(136, 157);
            this.SinavaGirBoxBTN.Name = "SinavaGirBoxBTN";
            this.SinavaGirBoxBTN.Size = new System.Drawing.Size(157, 163);
            this.SinavaGirBoxBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SinavaGirBoxBTN.TabIndex = 12;
            this.SinavaGirBoxBTN.TabStop = false;
            this.SinavaGirBoxBTN.Click += new System.EventHandler(this.SinavaGirBoxBTN_Click);
            // 
            // FrmMusteriMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(417, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SinavaGirBoxBTN);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMusteriMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMusteriMenu";
            ((System.ComponentModel.ISupportInitialize)(this.SinavaGirBoxBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SinavaGirBoxBTN;
    }
}