
namespace WinFormsApp1
{
    partial class FrmPrepareExam
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
            this.KapatBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KapatBTN
            // 
            this.KapatBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.KapatBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KapatBTN.Location = new System.Drawing.Point(375, 13);
            this.KapatBTN.Margin = new System.Windows.Forms.Padding(4);
            this.KapatBTN.Name = "KapatBTN";
            this.KapatBTN.Size = new System.Drawing.Size(29, 29);
            this.KapatBTN.TabIndex = 45;
            this.KapatBTN.TabStop = false;
            this.KapatBTN.Text = "X";
            this.KapatBTN.UseVisualStyleBackColor = false;
            this.KapatBTN.Click += new System.EventHandler(this.KapatBTN_Click);
            // 
            // FrmPrepareExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(417, 552);
            this.Controls.Add(this.KapatBTN);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrepareExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrepareExam";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KapatBTN;
    }
}