namespace Suosikkinimet
{
    partial class NimiForm
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.TarkastaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(27, 98);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(458, 30);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Anna nimesi, niin tarkastetaan, onko se 50 suosituimman joukossa:";
            // 
            // NimiTB
            // 
            this.NimiTB.BackColor = System.Drawing.Color.DarkOrange;
            this.NimiTB.Location = new System.Drawing.Point(534, 99);
            this.NimiTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(100, 36);
            this.NimiTB.TabIndex = 1;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(36, 210);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(66, 30);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // TarkastaBT
            // 
            this.TarkastaBT.BackColor = System.Drawing.Color.DarkOrange;
            this.TarkastaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TarkastaBT.Location = new System.Drawing.Point(534, 198);
            this.TarkastaBT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TarkastaBT.Name = "TarkastaBT";
            this.TarkastaBT.Size = new System.Drawing.Size(100, 42);
            this.TarkastaBT.TabIndex = 3;
            this.TarkastaBT.Text = "Tarkasta";
            this.TarkastaBT.UseVisualStyleBackColor = false;
            this.TarkastaBT.Click += new System.EventHandler(this.TarkastaBT_Click);
            // 
            // NimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 816);
            this.Controls.Add(this.TarkastaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.KysymysLB);
            this.Font = new System.Drawing.Font("Niagara Engraved", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "NimiForm";
            this.Text = "Suosikkinimet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.TextBox NimiTB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Button TarkastaBT;
    }
}

