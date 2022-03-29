namespace _10Kysymysta
{
    partial class Vastauslomake
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KysymysLB = new System.Windows.Forms.Label();
            this.ApuRB = new System.Windows.Forms.RadioButton();
            this.VastausARB = new System.Windows.Forms.RadioButton();
            this.VastausBRB = new System.Windows.Forms.RadioButton();
            this.VastausDRB = new System.Windows.Forms.RadioButton();
            this.VastausCRB = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VastausDRB);
            this.groupBox1.Controls.Add(this.VastausCRB);
            this.groupBox1.Controls.Add(this.VastausBRB);
            this.groupBox1.Controls.Add(this.VastausARB);
            this.groupBox1.Controls.Add(this.ApuRB);
            this.groupBox1.Location = new System.Drawing.Point(467, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(179, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "vastaus";
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(44, 69);
            this.KysymysLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(296, 30);
            this.KysymysLB.TabIndex = 1;
            this.KysymysLB.Text = "Vastaus 1. kysymykseen:";
            // 
            // ApuRB
            // 
            this.ApuRB.AutoCheck = false;
            this.ApuRB.AutoSize = true;
            this.ApuRB.Location = new System.Drawing.Point(24, 41);
            this.ApuRB.Name = "ApuRB";
            this.ApuRB.Size = new System.Drawing.Size(51, 34);
            this.ApuRB.TabIndex = 0;
            this.ApuRB.TabStop = true;
            this.ApuRB.Text = "E";
            this.ApuRB.UseVisualStyleBackColor = true;
            this.ApuRB.Visible = false;
            // 
            // VastausARB
            // 
            this.VastausARB.AutoSize = true;
            this.VastausARB.Location = new System.Drawing.Point(23, 41);
            this.VastausARB.Name = "VastausARB";
            this.VastausARB.Size = new System.Drawing.Size(54, 34);
            this.VastausARB.TabIndex = 1;
            this.VastausARB.TabStop = true;
            this.VastausARB.Text = "A";
            this.VastausARB.UseVisualStyleBackColor = true;
            // 
            // VastausBRB
            // 
            this.VastausBRB.AutoSize = true;
            this.VastausBRB.Location = new System.Drawing.Point(24, 96);
            this.VastausBRB.Name = "VastausBRB";
            this.VastausBRB.Size = new System.Drawing.Size(53, 34);
            this.VastausBRB.TabIndex = 2;
            this.VastausBRB.TabStop = true;
            this.VastausBRB.Text = "B";
            this.VastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausDRB
            // 
            this.VastausDRB.AutoSize = true;
            this.VastausDRB.Location = new System.Drawing.Point(24, 208);
            this.VastausDRB.Name = "VastausDRB";
            this.VastausDRB.Size = new System.Drawing.Size(54, 34);
            this.VastausDRB.TabIndex = 4;
            this.VastausDRB.TabStop = true;
            this.VastausDRB.Text = "D";
            this.VastausDRB.UseVisualStyleBackColor = true;
            // 
            // VastausCRB
            // 
            this.VastausCRB.AutoSize = true;
            this.VastausCRB.Location = new System.Drawing.Point(24, 153);
            this.VastausCRB.Name = "VastausCRB";
            this.VastausCRB.Size = new System.Drawing.Size(53, 34);
            this.VastausCRB.TabIndex = 3;
            this.VastausCRB.TabStop = true;
            this.VastausCRB.Text = "C";
            this.VastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(44, 300);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(101, 30);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Vastauslomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 503);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KysymysLB);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Vastauslomake";
            this.Text = "Vastauslomake";
            this.Load += new System.EventHandler(this.Vastauslomake_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.RadioButton VastausDRB;
        private System.Windows.Forms.RadioButton VastausCRB;
        private System.Windows.Forms.RadioButton VastausBRB;
        private System.Windows.Forms.RadioButton VastausARB;
        private System.Windows.Forms.RadioButton ApuRB;
        private System.Windows.Forms.Label VastausLB;
    }
}

