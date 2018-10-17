namespace Scraper {
    partial class frmScraper {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblLookupDate = new System.Windows.Forms.Label();
            this.dteLookupDate = new System.Windows.Forms.DateTimePicker();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(164, 143);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(321, 14);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblLookupDate
            // 
            this.lblLookupDate.AutoSize = true;
            this.lblLookupDate.Location = new System.Drawing.Point(15, 24);
            this.lblLookupDate.Name = "lblLookupDate";
            this.lblLookupDate.Size = new System.Drawing.Size(73, 13);
            this.lblLookupDate.TabIndex = 2;
            this.lblLookupDate.Text = "Look up date:";
            // 
            // dteLookupDate
            // 
            this.dteLookupDate.Location = new System.Drawing.Point(94, 17);
            this.dteLookupDate.Name = "dteLookupDate";
            this.dteLookupDate.Size = new System.Drawing.Size(212, 20);
            this.dteLookupDate.TabIndex = 0;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(94, 59);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(212, 63);
            this.txtResults.TabIndex = 2;
            // 
            // frmScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 176);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.dteLookupDate);
            this.Controls.Add(this.lblLookupDate);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScraper";
            this.Text = "Get MXN Exchange Rate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblLookupDate;
        private System.Windows.Forms.DateTimePicker dteLookupDate;
        private System.Windows.Forms.TextBox txtResults;
    }
}

