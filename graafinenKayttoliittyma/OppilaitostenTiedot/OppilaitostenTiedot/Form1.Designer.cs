namespace OppilaitostenTiedot
{
    partial class OLaiTiForm
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.LaitosLB = new System.Windows.Forms.Label();
            this.VastuuhenkiloLB = new System.Windows.Forms.Label();
            this.LaitosCB = new System.Windows.Forms.ComboBox();
            this.VastuuhenkiloCB = new System.Windows.Forms.ComboBox();
            this.OsLB = new System.Windows.Forms.Label();
            this.PnroLB = new System.Windows.Forms.Label();
            this.PtoimiLB = new System.Windows.Forms.Label();
            this.PuhLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.SijaintiLB = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.PhoneLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Baskerville Old Face", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoLB.Location = new System.Drawing.Point(46, 40);
            this.OtsikkoLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(479, 48);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Oppilaitosten avainhenkilöt";
            // 
            // LaitosLB
            // 
            this.LaitosLB.AutoSize = true;
            this.LaitosLB.Location = new System.Drawing.Point(46, 109);
            this.LaitosLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LaitosLB.Name = "LaitosLB";
            this.LaitosLB.Size = new System.Drawing.Size(211, 32);
            this.LaitosLB.TabIndex = 1;
            this.LaitosLB.Text = "Valitse oppilaitos:";
            // 
            // VastuuhenkiloLB
            // 
            this.VastuuhenkiloLB.AutoSize = true;
            this.VastuuhenkiloLB.Location = new System.Drawing.Point(398, 109);
            this.VastuuhenkiloLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.VastuuhenkiloLB.Name = "VastuuhenkiloLB";
            this.VastuuhenkiloLB.Size = new System.Drawing.Size(257, 32);
            this.VastuuhenkiloLB.TabIndex = 2;
            this.VastuuhenkiloLB.Text = "Valitse vastuuhenkilö:";
            // 
            // LaitosCB
            // 
            this.LaitosCB.FormattingEnabled = true;
            this.LaitosCB.Location = new System.Drawing.Point(52, 187);
            this.LaitosCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LaitosCB.Name = "LaitosCB";
            this.LaitosCB.Size = new System.Drawing.Size(212, 39);
            this.LaitosCB.TabIndex = 3;
            this.LaitosCB.SelectedIndexChanged += new System.EventHandler(this.LaitosCB_SelectedIndexChanged);
            // 
            // VastuuhenkiloCB
            // 
            this.VastuuhenkiloCB.FormattingEnabled = true;
            this.VastuuhenkiloCB.Location = new System.Drawing.Point(404, 187);
            this.VastuuhenkiloCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.VastuuhenkiloCB.Name = "VastuuhenkiloCB";
            this.VastuuhenkiloCB.Size = new System.Drawing.Size(223, 39);
            this.VastuuhenkiloCB.TabIndex = 4;
            this.VastuuhenkiloCB.SelectedIndexChanged += new System.EventHandler(this.VastuuhenkiloCB_SelectedIndexChanged);
            // 
            // OsLB
            // 
            this.OsLB.AutoSize = true;
            this.OsLB.Location = new System.Drawing.Point(54, 269);
            this.OsLB.Name = "OsLB";
            this.OsLB.Size = new System.Drawing.Size(38, 32);
            this.OsLB.TabIndex = 5;
            this.OsLB.Text = "os";
            // 
            // PnroLB
            // 
            this.PnroLB.AutoSize = true;
            this.PnroLB.Location = new System.Drawing.Point(54, 330);
            this.PnroLB.Name = "PnroLB";
            this.PnroLB.Size = new System.Drawing.Size(53, 32);
            this.PnroLB.TabIndex = 6;
            this.PnroLB.Text = "nro";
            // 
            // PtoimiLB
            // 
            this.PtoimiLB.AutoSize = true;
            this.PtoimiLB.Location = new System.Drawing.Point(54, 385);
            this.PtoimiLB.Name = "PtoimiLB";
            this.PtoimiLB.Size = new System.Drawing.Size(79, 32);
            this.PtoimiLB.TabIndex = 7;
            this.PtoimiLB.Text = "ptoim";
            // 
            // PuhLB
            // 
            this.PuhLB.AutoSize = true;
            this.PuhLB.Location = new System.Drawing.Point(54, 445);
            this.PuhLB.Name = "PuhLB";
            this.PuhLB.Size = new System.Drawing.Size(58, 32);
            this.PuhLB.TabIndex = 8;
            this.PuhLB.Text = "puh";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(398, 269);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(35, 32);
            this.TitteliLB.TabIndex = 9;
            this.TitteliLB.Text = "tit";
            // 
            // SijaintiLB
            // 
            this.SijaintiLB.AutoSize = true;
            this.SijaintiLB.Location = new System.Drawing.Point(398, 330);
            this.SijaintiLB.Name = "SijaintiLB";
            this.SijaintiLB.Size = new System.Drawing.Size(37, 32);
            this.SijaintiLB.TabIndex = 10;
            this.SijaintiLB.Text = "sij";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Location = new System.Drawing.Point(398, 385);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(75, 32);
            this.EmailLB.TabIndex = 11;
            this.EmailLB.Text = "email";
            // 
            // PhoneLB
            // 
            this.PhoneLB.AutoSize = true;
            this.PhoneLB.Location = new System.Drawing.Point(398, 445);
            this.PhoneLB.Name = "PhoneLB";
            this.PhoneLB.Size = new System.Drawing.Size(58, 32);
            this.PhoneLB.TabIndex = 12;
            this.PhoneLB.Text = "puh";
            // 
            // OLaiTiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 572);
            this.Controls.Add(this.PhoneLB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.SijaintiLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.PuhLB);
            this.Controls.Add(this.PtoimiLB);
            this.Controls.Add(this.PnroLB);
            this.Controls.Add(this.OsLB);
            this.Controls.Add(this.VastuuhenkiloCB);
            this.Controls.Add(this.LaitosCB);
            this.Controls.Add(this.VastuuhenkiloLB);
            this.Controls.Add(this.LaitosLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "OLaiTiForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.OLaiTiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Label LaitosLB;
        private System.Windows.Forms.Label VastuuhenkiloLB;
        private System.Windows.Forms.ComboBox LaitosCB;
        private System.Windows.Forms.ComboBox VastuuhenkiloCB;
        private System.Windows.Forms.Label OsLB;
        private System.Windows.Forms.Label PnroLB;
        private System.Windows.Forms.Label PtoimiLB;
        private System.Windows.Forms.Label PuhLB;
        private System.Windows.Forms.Label TitteliLB;
        private System.Windows.Forms.Label SijaintiLB;
        private System.Windows.Forms.Label EmailLB;
        private System.Windows.Forms.Label PhoneLB;
    }
}

