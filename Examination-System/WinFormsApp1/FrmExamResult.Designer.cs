
namespace WinFormsApp1
{
    partial class FrmExamResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExamResult));
            this.YanlisSayisiLbl = new System.Windows.Forms.Label();
            this.DogruSayisiLbl = new System.Windows.Forms.Label();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
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
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // YanlisSayisiLbl
            // 
            this.YanlisSayisiLbl.AutoSize = true;
            this.YanlisSayisiLbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YanlisSayisiLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.YanlisSayisiLbl.Location = new System.Drawing.Point(81, 98);
            this.YanlisSayisiLbl.Name = "YanlisSayisiLbl";
            this.YanlisSayisiLbl.Size = new System.Drawing.Size(206, 32);
            this.YanlisSayisiLbl.TabIndex = 93;
            this.YanlisSayisiLbl.Text = "Yanlış Sayısı: 0";
            // 
            // DogruSayisiLbl
            // 
            this.DogruSayisiLbl.AutoSize = true;
            this.DogruSayisiLbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DogruSayisiLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.DogruSayisiLbl.Location = new System.Drawing.Point(80, 48);
            this.DogruSayisiLbl.Name = "DogruSayisiLbl";
            this.DogruSayisiLbl.Size = new System.Drawing.Size(207, 32);
            this.DogruSayisiLbl.TabIndex = 92;
            this.DogruSayisiLbl.Text = "Doğru Sayısı: 0";
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(813, 9);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(30, 30);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 94;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 43);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(50, 153);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(223, 357);
            this.listView1.TabIndex = 97;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Soru";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doğru/Yanlış";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // OptionDTxt
            // 
            this.OptionDTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionDTxt.Enabled = false;
            this.OptionDTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionDTxt.Location = new System.Drawing.Point(395, 517);
            this.OptionDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.OptionDTxt.Name = "OptionDTxt";
            this.OptionDTxt.ReadOnly = true;
            this.OptionDTxt.Size = new System.Drawing.Size(413, 23);
            this.OptionDTxt.TabIndex = 112;
            this.OptionDTxt.TabStop = false;
            // 
            // OptionCTxt
            // 
            this.OptionCTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionCTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionCTxt.Enabled = false;
            this.OptionCTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionCTxt.Location = new System.Drawing.Point(395, 475);
            this.OptionCTxt.Margin = new System.Windows.Forms.Padding(4);
            this.OptionCTxt.Name = "OptionCTxt";
            this.OptionCTxt.ReadOnly = true;
            this.OptionCTxt.Size = new System.Drawing.Size(413, 23);
            this.OptionCTxt.TabIndex = 111;
            this.OptionCTxt.TabStop = false;
            // 
            // OptionBTxt
            // 
            this.OptionBTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionBTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionBTxt.Enabled = false;
            this.OptionBTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionBTxt.Location = new System.Drawing.Point(395, 434);
            this.OptionBTxt.Margin = new System.Windows.Forms.Padding(4);
            this.OptionBTxt.Name = "OptionBTxt";
            this.OptionBTxt.ReadOnly = true;
            this.OptionBTxt.Size = new System.Drawing.Size(413, 23);
            this.OptionBTxt.TabIndex = 110;
            this.OptionBTxt.TabStop = false;
            // 
            // OptionATxt
            // 
            this.OptionATxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.OptionATxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionATxt.Enabled = false;
            this.OptionATxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OptionATxt.Location = new System.Drawing.Point(395, 393);
            this.OptionATxt.Margin = new System.Windows.Forms.Padding(4);
            this.OptionATxt.Name = "OptionATxt";
            this.OptionATxt.ReadOnly = true;
            this.OptionATxt.Size = new System.Drawing.Size(413, 23);
            this.OptionATxt.TabIndex = 109;
            this.OptionATxt.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label11.Location = new System.Drawing.Point(334, 517);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 23);
            this.label11.TabIndex = 108;
            this.label11.Text = "D)";
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Enabled = false;
            this.radioButtonD.ForeColor = System.Drawing.Color.White;
            this.radioButtonD.Location = new System.Drawing.Point(370, 520);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(17, 16);
            this.radioButtonD.TabIndex = 107;
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label10.Location = new System.Drawing.Point(334, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 23);
            this.label10.TabIndex = 106;
            this.label10.Text = "C)";
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Enabled = false;
            this.radioButtonC.ForeColor = System.Drawing.Color.White;
            this.radioButtonC.Location = new System.Drawing.Point(370, 478);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(17, 16);
            this.radioButtonC.TabIndex = 105;
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label9.Location = new System.Drawing.Point(334, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 23);
            this.label9.TabIndex = 104;
            this.label9.Text = "B)";
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Enabled = false;
            this.radioButtonB.ForeColor = System.Drawing.Color.White;
            this.radioButtonB.Location = new System.Drawing.Point(370, 437);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(17, 16);
            this.radioButtonB.TabIndex = 103;
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label8.Location = new System.Drawing.Point(334, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 23);
            this.label8.TabIndex = 102;
            this.label8.Text = "A)";
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Enabled = false;
            this.radioButtonA.ForeColor = System.Drawing.Color.White;
            this.radioButtonA.Location = new System.Drawing.Point(370, 396);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(17, 16);
            this.radioButtonA.TabIndex = 101;
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // QuestionRichTxt
            // 
            this.QuestionRichTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.QuestionRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionRichTxt.Enabled = false;
            this.QuestionRichTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.QuestionRichTxt.Location = new System.Drawing.Point(410, 276);
            this.QuestionRichTxt.Name = "QuestionRichTxt";
            this.QuestionRichTxt.ReadOnly = true;
            this.QuestionRichTxt.Size = new System.Drawing.Size(374, 78);
            this.QuestionRichTxt.TabIndex = 100;
            this.QuestionRichTxt.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label7.Location = new System.Drawing.Point(347, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 99;
            this.label7.Text = "Soru:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.pictureBox.Location = new System.Drawing.Point(410, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(374, 235);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 98;
            this.pictureBox.TabStop = false;
            // 
            // FrmExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(852, 566);
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
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.YanlisSayisiLbl);
            this.Controls.Add(this.DogruSayisiLbl);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmExamResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExamResult";
            this.Load += new System.EventHandler(this.FrmExamResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label YanlisSayisiLbl;
        private System.Windows.Forms.Label DogruSayisiLbl;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
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
    }
}