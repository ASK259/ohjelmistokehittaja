namespace LukujenJarjestys
{
    partial class LukujenJarjestys
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
            this.annaLukuLB = new System.Windows.Forms.Label();
            this.uusiLukuTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // annaLukuLB
            // 
            this.annaLukuLB.AutoSize = true;
            this.annaLukuLB.Location = new System.Drawing.Point(101, 160);
            this.annaLukuLB.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.annaLukuLB.Name = "annaLukuLB";
            this.annaLukuLB.Size = new System.Drawing.Size(319, 44);
            this.annaLukuLB.TabIndex = 0;
            this.annaLukuLB.Text = "Anna luku(-999 lopetus): ";
            // 
            // uusiLukuTB
            // 
            this.uusiLukuTB.Location = new System.Drawing.Point(488, 160);
            this.uusiLukuTB.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.uusiLukuTB.Name = "uusiLukuTB";
            this.uusiLukuTB.Size = new System.Drawing.Size(220, 50);
            this.uusiLukuTB.TabIndex = 1;
            this.uusiLukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uusiLukuTB_KeyPress);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(108, 268);
            this.VastausLB.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(106, 44);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "vastaus";
            this.VastausLB.Visible = false;
            // 
            // LukujenJarjestys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(801, 485);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.uusiLukuTB);
            this.Controls.Add(this.annaLukuLB);
            this.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "LukujenJarjestys";
            this.Text = "Lukujen järjestys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label annaLukuLB;
        private System.Windows.Forms.TextBox uusiLukuTB;
        private System.Windows.Forms.Label VastausLB;
    }
}

