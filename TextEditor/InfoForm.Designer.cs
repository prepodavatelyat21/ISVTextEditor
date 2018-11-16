namespace TextEditor
{
    partial class InfoForm
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
            this.lbl = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblSpeciality = new System.Windows.Forms.Label();
            this.lblAssistant = new System.Windows.Forms.Label();
            this.pbToshko = new System.Windows.Forms.PictureBox();
            this.pbAuthor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbToshko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(145, 43);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(46, 17);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "label1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(779, 43);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 2;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(565, 133);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(46, 17);
            this.lblTeacher.TabIndex = 3;
            this.lblTeacher.Text = "label1";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(565, 219);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 17);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "label2";
            // 
            // lblSpeciality
            // 
            this.lblSpeciality.AutoSize = true;
            this.lblSpeciality.Location = new System.Drawing.Point(565, 262);
            this.lblSpeciality.Name = "lblSpeciality";
            this.lblSpeciality.Size = new System.Drawing.Size(46, 17);
            this.lblSpeciality.TabIndex = 5;
            this.lblSpeciality.Text = "label3";
            // 
            // lblAssistant
            // 
            this.lblAssistant.AutoSize = true;
            this.lblAssistant.Location = new System.Drawing.Point(565, 173);
            this.lblAssistant.Name = "lblAssistant";
            this.lblAssistant.Size = new System.Drawing.Size(46, 17);
            this.lblAssistant.TabIndex = 6;
            this.lblAssistant.Text = "label3";
            // 
            // pbToshko
            // 
            this.pbToshko.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbToshko.Location = new System.Drawing.Point(742, 355);
            this.pbToshko.Name = "pbToshko";
            this.pbToshko.Size = new System.Drawing.Size(183, 108);
            this.pbToshko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbToshko.TabIndex = 7;
            this.pbToshko.TabStop = false;
            // 
            // pbAuthor
            // 
            this.pbAuthor.Location = new System.Drawing.Point(148, 100);
            this.pbAuthor.Name = "pbAuthor";
            this.pbAuthor.Size = new System.Drawing.Size(218, 191);
            this.pbAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAuthor.TabIndex = 0;
            this.pbAuthor.TabStop = false;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 548);
            this.Controls.Add(this.pbToshko);
            this.Controls.Add(this.lblAssistant);
            this.Controls.Add(this.lblSpeciality);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pbAuthor);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbToshko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAuthor;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblSpeciality;
        private System.Windows.Forms.Label lblAssistant;
        private System.Windows.Forms.PictureBox pbToshko;
    }
}