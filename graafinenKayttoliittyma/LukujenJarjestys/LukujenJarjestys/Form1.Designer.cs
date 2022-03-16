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
            this.annaLukuLB.Location = new System.Drawing.Point(45, 61);
            this.annaLukuLB.Name = "annaLukuLB";
            this.annaLukuLB.Size = new System.Drawing.Size(151, 16);
            this.annaLukuLB.TabIndex = 0;
            this.annaLukuLB.Text = "Anna luku(-999 lopetus): ";
            // 
            // uusiLukuTB
            // 
            this.uusiLukuTB.Location = new System.Drawing.Point(217, 61);
            this.uusiLukuTB.Name = "uusiLukuTB";
            this.uusiLukuTB.Size = new System.Drawing.Size(100, 22);
            this.uusiLukuTB.TabIndex = 1;
            this.uusiLukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uusiLukuTB_KeyPress);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(48, 102);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(44, 16);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "label1";
            this.VastausLB.Visible = false;
            // 
            // LukujenJarjestys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 697);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.uusiLukuTB);
            this.Controls.Add(this.annaLukuLB);
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

