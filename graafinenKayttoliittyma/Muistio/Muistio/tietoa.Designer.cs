namespace Muistio
{
    partial class tietoa
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
            this.TietoaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TietoaLB
            // 
            this.TietoaLB.AutoSize = true;
            this.TietoaLB.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TietoaLB.Location = new System.Drawing.Point(100, 106);
            this.TietoaLB.Name = "TietoaLB";
            this.TietoaLB.Size = new System.Drawing.Size(360, 34);
            this.TietoaLB.TabIndex = 0;
            this.TietoaLB.Text = "Made by Antti Kuusisto";
            // 
            // tietoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TietoaLB);
            this.Name = "tietoa";
            this.Text = "tietoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TietoaLB;
    }
}