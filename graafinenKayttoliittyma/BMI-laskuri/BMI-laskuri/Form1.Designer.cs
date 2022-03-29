namespace BMI_laskuri
{
    partial class BmiLaskuri
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
            this.PainoLB = new System.Windows.Forms.Label();
            this.PituusLB = new System.Windows.Forms.Label();
            this.PainoTB = new System.Windows.Forms.TextBox();
            this.PituusTB = new System.Windows.Forms.TextBox();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.BmiLB = new System.Windows.Forms.Label();
            this.KuvausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PainoLB
            // 
            this.PainoLB.AutoSize = true;
            this.PainoLB.Location = new System.Drawing.Point(150, 74);
            this.PainoLB.Name = "PainoLB";
            this.PainoLB.Size = new System.Drawing.Size(116, 24);
            this.PainoLB.TabIndex = 0;
            this.PainoLB.Text = "Anna paino:";
            // 
            // PituusLB
            // 
            this.PituusLB.AutoSize = true;
            this.PituusLB.Location = new System.Drawing.Point(150, 144);
            this.PituusLB.Name = "PituusLB";
            this.PituusLB.Size = new System.Drawing.Size(121, 24);
            this.PituusLB.TabIndex = 1;
            this.PituusLB.Text = "Anna pituus:";
            // 
            // PainoTB
            // 
            this.PainoTB.Location = new System.Drawing.Point(342, 74);
            this.PainoTB.Name = "PainoTB";
            this.PainoTB.Size = new System.Drawing.Size(100, 31);
            this.PainoTB.TabIndex = 2;
            // 
            // PituusTB
            // 
            this.PituusTB.Location = new System.Drawing.Point(342, 144);
            this.PituusTB.Name = "PituusTB";
            this.PituusTB.Size = new System.Drawing.Size(100, 31);
            this.PituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(181, 231);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(245, 49);
            this.LaskeBT.TabIndex = 4;
            this.LaskeBT.Text = "Laske painoindeksi";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // BmiLB
            // 
            this.BmiLB.AutoSize = true;
            this.BmiLB.Location = new System.Drawing.Point(154, 316);
            this.BmiLB.Name = "BmiLB";
            this.BmiLB.Size = new System.Drawing.Size(62, 24);
            this.BmiLB.TabIndex = 5;
            this.BmiLB.Text = "label3";
            this.BmiLB.Visible = false;
            // 
            // KuvausLB
            // 
            this.KuvausLB.AutoSize = true;
            this.KuvausLB.Location = new System.Drawing.Point(158, 376);
            this.KuvausLB.Name = "KuvausLB";
            this.KuvausLB.Size = new System.Drawing.Size(63, 24);
            this.KuvausLB.TabIndex = 6;
            this.KuvausLB.Text = "label4";
            this.KuvausLB.Visible = false;
            // 
            // BmiLaskuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(974, 519);
            this.Controls.Add(this.KuvausLB);
            this.Controls.Add(this.BmiLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.PituusTB);
            this.Controls.Add(this.PainoTB);
            this.Controls.Add(this.PituusLB);
            this.Controls.Add(this.PainoLB);
            this.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BmiLaskuri";
            this.Text = "BMI-laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PainoLB;
        private System.Windows.Forms.Label PituusLB;
        private System.Windows.Forms.TextBox PainoTB;
        private System.Windows.Forms.TextBox PituusTB;
        private System.Windows.Forms.Button LaskeBT;
        private System.Windows.Forms.Label BmiLB;
        private System.Windows.Forms.Label KuvausLB;
    }
}

