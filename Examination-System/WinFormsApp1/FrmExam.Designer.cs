
namespace WinFormsApp1
{
    partial class FrmExam
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
            this.components = new System.ComponentModel.Container();
            this.QuestionRichTxt = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.SoruDegisBTN = new System.Windows.Forms.Button();
            this.Saniye = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.saniyeLbl = new System.Windows.Forms.Label();
            this.dakikaLbl = new System.Windows.Forms.Label();
            this.UniteNoLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.OptionDRichTxt = new System.Windows.Forms.RichTextBox();
            this.OptionCRichTxt = new System.Windows.Forms.RichTextBox();
            this.OptionBRichTxt = new System.Windows.Forms.RichTextBox();
            this.OptionARichTxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionRichTxt
            // 
            this.QuestionRichTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.QuestionRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionRichTxt.Enabled = false;
            this.QuestionRichTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.QuestionRichTxt.Location = new System.Drawing.Point(128, 347);
            this.QuestionRichTxt.Name = "QuestionRichTxt";
            this.QuestionRichTxt.ReadOnly = true;
            this.QuestionRichTxt.Size = new System.Drawing.Size(374, 78);
            this.QuestionRichTxt.TabIndex = 68;
            this.QuestionRichTxt.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label7.Location = new System.Drawing.Point(65, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "Soru:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.pictureBox.Location = new System.Drawing.Point(128, 83);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(374, 235);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 65;
            this.pictureBox.TabStop = false;
            // 
            // SoruDegisBTN
            // 
            this.SoruDegisBTN.Location = new System.Drawing.Point(195, 699);
            this.SoruDegisBTN.Name = "SoruDegisBTN";
            this.SoruDegisBTN.Size = new System.Drawing.Size(171, 39);
            this.SoruDegisBTN.TabIndex = 81;
            this.SoruDegisBTN.Text = "Sonraki Soru";
            this.SoruDegisBTN.UseVisualStyleBackColor = true;
            this.SoruDegisBTN.Click += new System.EventHandler(this.SoruDegisBTN_Click);
            // 
            // Saniye
            // 
            this.Saniye.Tick += new System.EventHandler(this.Saniye_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(113, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 23);
            this.label2.TabIndex = 84;
            this.label2.Text = ":";
            // 
            // saniyeLbl
            // 
            this.saniyeLbl.AutoSize = true;
            this.saniyeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.saniyeLbl.Location = new System.Drawing.Point(126, 29);
            this.saniyeLbl.Name = "saniyeLbl";
            this.saniyeLbl.Size = new System.Drawing.Size(0, 23);
            this.saniyeLbl.TabIndex = 82;
            // 
            // dakikaLbl
            // 
            this.dakikaLbl.AutoSize = true;
            this.dakikaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.dakikaLbl.Location = new System.Drawing.Point(88, 29);
            this.dakikaLbl.Name = "dakikaLbl";
            this.dakikaLbl.Size = new System.Drawing.Size(0, 23);
            this.dakikaLbl.TabIndex = 83;
            // 
            // UniteNoLbl
            // 
            this.UniteNoLbl.AutoSize = true;
            this.UniteNoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.UniteNoLbl.Location = new System.Drawing.Point(24, 29);
            this.UniteNoLbl.Name = "UniteNoLbl";
            this.UniteNoLbl.Size = new System.Drawing.Size(58, 23);
            this.UniteNoLbl.TabIndex = 57;
            this.UniteNoLbl.Text = "Süre:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(128, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 3);
            this.panel2.TabIndex = 85;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(128, 315);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 3);
            this.panel1.TabIndex = 86;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(128, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 235);
            this.panel3.TabIndex = 87;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(502, 83);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 234);
            this.panel4.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(72, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 134;
            this.label1.Text = "D)";
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(108, 638);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(17, 16);
            this.radioButtonD.TabIndex = 133;
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label12.Location = new System.Drawing.Point(71, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 23);
            this.label12.TabIndex = 132;
            this.label12.Text = "C)";
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(107, 583);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(17, 16);
            this.radioButtonC.TabIndex = 131;
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // OptionDRichTxt
            // 
            this.OptionDRichTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionDRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionDRichTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionDRichTxt.Location = new System.Drawing.Point(133, 632);
            this.OptionDRichTxt.Name = "OptionDRichTxt";
            this.OptionDRichTxt.Size = new System.Drawing.Size(374, 35);
            this.OptionDRichTxt.TabIndex = 130;
            this.OptionDRichTxt.Text = "";
            // 
            // OptionCRichTxt
            // 
            this.OptionCRichTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionCRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionCRichTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionCRichTxt.Location = new System.Drawing.Point(133, 574);
            this.OptionCRichTxt.Name = "OptionCRichTxt";
            this.OptionCRichTxt.Size = new System.Drawing.Size(374, 35);
            this.OptionCRichTxt.TabIndex = 129;
            this.OptionCRichTxt.Text = "";
            // 
            // OptionBRichTxt
            // 
            this.OptionBRichTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionBRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionBRichTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionBRichTxt.Location = new System.Drawing.Point(133, 519);
            this.OptionBRichTxt.Name = "OptionBRichTxt";
            this.OptionBRichTxt.Size = new System.Drawing.Size(374, 35);
            this.OptionBRichTxt.TabIndex = 128;
            this.OptionBRichTxt.Text = "";
            // 
            // OptionARichTxt
            // 
            this.OptionARichTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionARichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionARichTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionARichTxt.Location = new System.Drawing.Point(131, 464);
            this.OptionARichTxt.Name = "OptionARichTxt";
            this.OptionARichTxt.Size = new System.Drawing.Size(374, 35);
            this.OptionARichTxt.TabIndex = 127;
            this.OptionARichTxt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(72, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 23);
            this.label3.TabIndex = 126;
            this.label3.Text = "B)";
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(108, 529);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(17, 16);
            this.radioButtonB.TabIndex = 125;
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label6.Location = new System.Drawing.Point(72, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 23);
            this.label6.TabIndex = 124;
            this.label6.Text = "A)";
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(108, 474);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(17, 16);
            this.radioButtonA.TabIndex = 123;
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // FrmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(589, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.OptionDRichTxt);
            this.Controls.Add(this.OptionCRichTxt);
            this.Controls.Add(this.OptionBRichTxt);
            this.Controls.Add(this.OptionARichTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dakikaLbl);
            this.Controls.Add(this.saniyeLbl);
            this.Controls.Add(this.SoruDegisBTN);
            this.Controls.Add(this.QuestionRichTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.UniteNoLbl);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Exam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox QuestionRichTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button SoruDegisBTN;
        private System.Windows.Forms.Timer Saniye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label saniyeLbl;
        private System.Windows.Forms.Label dakikaLbl;
        private System.Windows.Forms.Label UniteNoLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RichTextBox OptionDRichTxt;
        private System.Windows.Forms.RichTextBox OptionCRichTxt;
        private System.Windows.Forms.RichTextBox OptionBRichTxt;
        private System.Windows.Forms.RichTextBox OptionARichTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonA;
    }
}