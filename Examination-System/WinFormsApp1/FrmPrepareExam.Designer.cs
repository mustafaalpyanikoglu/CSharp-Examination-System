
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sinavSuresiTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sinaviOlusturBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KapatBTN
            // 
            this.KapatBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(88, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 1);
            this.panel1.TabIndex = 48;
            // 
            // sinavSuresiTxt
            // 
            this.sinavSuresiTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.sinavSuresiTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sinavSuresiTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.sinavSuresiTxt.Location = new System.Drawing.Point(222, 86);
            this.sinavSuresiTxt.Margin = new System.Windows.Forms.Padding(4);
            this.sinavSuresiTxt.Name = "sinavSuresiTxt";
            this.sinavSuresiTxt.Size = new System.Drawing.Size(37, 23);
            this.sinavSuresiTxt.TabIndex = 47;
            this.sinavSuresiTxt.TabStop = false;
            this.sinavSuresiTxt.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "Sınav Süresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "Dakika";
            // 
            // sinaviOlusturBTN
            // 
            this.sinaviOlusturBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.sinaviOlusturBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sinaviOlusturBTN.Location = new System.Drawing.Point(106, 457);
            this.sinaviOlusturBTN.Margin = new System.Windows.Forms.Padding(4);
            this.sinaviOlusturBTN.Name = "sinaviOlusturBTN";
            this.sinaviOlusturBTN.Size = new System.Drawing.Size(188, 43);
            this.sinaviOlusturBTN.TabIndex = 51;
            this.sinaviOlusturBTN.TabStop = false;
            this.sinaviOlusturBTN.Text = "Sınavı Oluştur";
            this.sinaviOlusturBTN.UseVisualStyleBackColor = false;
            // 
            // FrmPrepareExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(417, 552);
            this.Controls.Add(this.sinaviOlusturBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sinavSuresiTxt);
            this.Controls.Add(this.KapatBTN);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrepareExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrepareExam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KapatBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sinavSuresiTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sinaviOlusturBTN;
    }
}