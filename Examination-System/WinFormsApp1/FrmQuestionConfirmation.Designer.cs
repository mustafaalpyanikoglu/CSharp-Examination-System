
namespace WinFormsApp1
{
    partial class FrmQuestionConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestionConfirmation));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.onaylaBTN = new System.Windows.Forms.Button();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.OptionDTxt = new System.Windows.Forms.TextBox();
            this.OptionCTxt = new System.Windows.Forms.TextBox();
            this.OptionBTxt = new System.Windows.Forms.TextBox();
            this.OptionATxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.QuestionRichTxt = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.SubjectNameTxt = new System.Windows.Forms.TextBox();
            this.UnitNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubjectNoTxt = new System.Windows.Forms.TextBox();
            this.UnitNoTxt = new System.Windows.Forms.TextBox();
            this.KonuNoLbl = new System.Windows.Forms.Label();
            this.UniteNoLbl = new System.Windows.Forms.Label();
            this.soruSecBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(148, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // onaylaBTN
            // 
            this.onaylaBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.onaylaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onaylaBTN.Location = new System.Drawing.Point(12, 320);
            this.onaylaBTN.Margin = new System.Windows.Forms.Padding(4);
            this.onaylaBTN.Name = "onaylaBTN";
            this.onaylaBTN.Size = new System.Drawing.Size(148, 43);
            this.onaylaBTN.TabIndex = 42;
            this.onaylaBTN.TabStop = false;
            this.onaylaBTN.Text = "Onayla";
            this.onaylaBTN.UseVisualStyleBackColor = false;
            this.onaylaBTN.Click += new System.EventHandler(this.onaylaBTN_Click);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(923, 9);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(30, 30);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 47;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // OptionDTxt
            // 
            this.OptionDTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionDTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionDTxt.Location = new System.Drawing.Point(339, 647);
            this.OptionDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.OptionDTxt.Name = "OptionDTxt";
            this.OptionDTxt.Size = new System.Drawing.Size(413, 23);
            this.OptionDTxt.TabIndex = 80;
            this.OptionDTxt.TabStop = false;
            // 
            // OptionCTxt
            // 
            this.OptionCTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionCTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionCTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionCTxt.Location = new System.Drawing.Point(339, 605);
            this.OptionCTxt.Margin = new System.Windows.Forms.Padding(4);
            this.OptionCTxt.Name = "OptionCTxt";
            this.OptionCTxt.Size = new System.Drawing.Size(413, 23);
            this.OptionCTxt.TabIndex = 79;
            this.OptionCTxt.TabStop = false;
            // 
            // OptionBTxt
            // 
            this.OptionBTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionBTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionBTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionBTxt.Location = new System.Drawing.Point(339, 564);
            this.OptionBTxt.Margin = new System.Windows.Forms.Padding(4);
            this.OptionBTxt.Name = "OptionBTxt";
            this.OptionBTxt.Size = new System.Drawing.Size(413, 23);
            this.OptionBTxt.TabIndex = 78;
            this.OptionBTxt.TabStop = false;
            // 
            // OptionATxt
            // 
            this.OptionATxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionATxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionATxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionATxt.Location = new System.Drawing.Point(339, 523);
            this.OptionATxt.Margin = new System.Windows.Forms.Padding(4);
            this.OptionATxt.Name = "OptionATxt";
            this.OptionATxt.Size = new System.Drawing.Size(413, 23);
            this.OptionATxt.TabIndex = 77;
            this.OptionATxt.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label11.Location = new System.Drawing.Point(277, 648);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 23);
            this.label11.TabIndex = 76;
            this.label11.Text = "D)";
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(313, 651);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(17, 16);
            this.radioButtonD.TabIndex = 75;
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label10.Location = new System.Drawing.Point(277, 606);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 23);
            this.label10.TabIndex = 74;
            this.label10.Text = "C)";
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(313, 609);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(17, 16);
            this.radioButtonC.TabIndex = 73;
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label9.Location = new System.Drawing.Point(277, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 23);
            this.label9.TabIndex = 72;
            this.label9.Text = "B)";
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(313, 568);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(17, 16);
            this.radioButtonB.TabIndex = 71;
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label8.Location = new System.Drawing.Point(277, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 23);
            this.label8.TabIndex = 70;
            this.label8.Text = "A)";
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(313, 527);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(17, 16);
            this.radioButtonA.TabIndex = 69;
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // QuestionRichTxt
            // 
            this.QuestionRichTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.QuestionRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionRichTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.QuestionRichTxt.Location = new System.Drawing.Point(378, 407);
            this.QuestionRichTxt.Name = "QuestionRichTxt";
            this.QuestionRichTxt.Size = new System.Drawing.Size(374, 78);
            this.QuestionRichTxt.TabIndex = 68;
            this.QuestionRichTxt.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label7.Location = new System.Drawing.Point(314, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "Soru:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.pictureBox.Location = new System.Drawing.Point(378, 143);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(374, 235);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 65;
            this.pictureBox.TabStop = false;
            // 
            // SubjectNameTxt
            // 
            this.SubjectNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.SubjectNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.SubjectNameTxt.Location = new System.Drawing.Point(676, 96);
            this.SubjectNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.SubjectNameTxt.Name = "SubjectNameTxt";
            this.SubjectNameTxt.Size = new System.Drawing.Size(219, 23);
            this.SubjectNameTxt.TabIndex = 64;
            this.SubjectNameTxt.TabStop = false;
            // 
            // UnitNameTxt
            // 
            this.UnitNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.UnitNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.UnitNameTxt.Location = new System.Drawing.Point(324, 103);
            this.UnitNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.UnitNameTxt.Name = "UnitNameTxt";
            this.UnitNameTxt.Size = new System.Drawing.Size(219, 23);
            this.UnitNameTxt.TabIndex = 63;
            this.UnitNameTxt.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label4.Location = new System.Drawing.Point(574, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "Konu Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label5.Location = new System.Drawing.Point(220, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 61;
            this.label5.Text = "Ünite Adı:";
            // 
            // SubjectNoTxt
            // 
            this.SubjectNoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.SubjectNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectNoTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.SubjectNoTxt.Location = new System.Drawing.Point(676, 49);
            this.SubjectNoTxt.Margin = new System.Windows.Forms.Padding(4);
            this.SubjectNoTxt.Name = "SubjectNoTxt";
            this.SubjectNoTxt.Size = new System.Drawing.Size(219, 23);
            this.SubjectNoTxt.TabIndex = 60;
            this.SubjectNoTxt.TabStop = false;
            // 
            // UnitNoTxt
            // 
            this.UnitNoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.UnitNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitNoTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.UnitNoTxt.Location = new System.Drawing.Point(324, 49);
            this.UnitNoTxt.Margin = new System.Windows.Forms.Padding(4);
            this.UnitNoTxt.Name = "UnitNoTxt";
            this.UnitNoTxt.Size = new System.Drawing.Size(219, 23);
            this.UnitNoTxt.TabIndex = 59;
            this.UnitNoTxt.TabStop = false;
            // 
            // KonuNoLbl
            // 
            this.KonuNoLbl.AutoSize = true;
            this.KonuNoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.KonuNoLbl.Location = new System.Drawing.Point(579, 49);
            this.KonuNoLbl.Name = "KonuNoLbl";
            this.KonuNoLbl.Size = new System.Drawing.Size(90, 23);
            this.KonuNoLbl.TabIndex = 58;
            this.KonuNoLbl.Text = "Konu No:";
            // 
            // UniteNoLbl
            // 
            this.UniteNoLbl.AutoSize = true;
            this.UniteNoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.UniteNoLbl.Location = new System.Drawing.Point(225, 50);
            this.UniteNoLbl.Name = "UniteNoLbl";
            this.UniteNoLbl.Size = new System.Drawing.Size(91, 23);
            this.UniteNoLbl.TabIndex = 57;
            this.UniteNoLbl.Text = "Ünite No:";
            // 
            // soruSecBTN
            // 
            this.soruSecBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.soruSecBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soruSecBTN.Location = new System.Drawing.Point(182, 251);
            this.soruSecBTN.Margin = new System.Windows.Forms.Padding(4);
            this.soruSecBTN.Name = "soruSecBTN";
            this.soruSecBTN.Size = new System.Drawing.Size(148, 43);
            this.soruSecBTN.TabIndex = 81;
            this.soruSecBTN.TabStop = false;
            this.soruSecBTN.Text = "Soru Seç";
            this.soruSecBTN.UseVisualStyleBackColor = false;
            // 
            // FrmQuestionConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(962, 712);
            this.Controls.Add(this.soruSecBTN);
            this.Controls.Add(this.OptionDTxt);
            this.Controls.Add(this.OptionCTxt);
            this.Controls.Add(this.OptionBTxt);
            this.Controls.Add(this.OptionATxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.QuestionRichTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.SubjectNameTxt);
            this.Controls.Add(this.UnitNameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubjectNoTxt);
            this.Controls.Add(this.UnitNoTxt);
            this.Controls.Add(this.KonuNoLbl);
            this.Controls.Add(this.UniteNoLbl);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.onaylaBTN);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmQuestionConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuestionConfirmation";
            this.Load += new System.EventHandler(this.FrmQuestionConfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button onaylaBTN;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.TextBox OptionDTxt;
        private System.Windows.Forms.TextBox OptionCTxt;
        private System.Windows.Forms.TextBox OptionBTxt;
        private System.Windows.Forms.TextBox OptionATxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RichTextBox QuestionRichTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox SubjectNameTxt;
        private System.Windows.Forms.TextBox UnitNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubjectNoTxt;
        private System.Windows.Forms.TextBox UnitNoTxt;
        private System.Windows.Forms.Label KonuNoLbl;
        private System.Windows.Forms.Label UniteNoLbl;
        private System.Windows.Forms.Button soruSecBTN;
    }
}