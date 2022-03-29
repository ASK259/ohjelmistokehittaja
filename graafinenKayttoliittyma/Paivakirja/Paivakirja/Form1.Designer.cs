namespace Paivakirja
{
    partial class PaivakirjaF
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
            this.SyottoRTB = new System.Windows.Forms.RichTextBox();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyottoRTB
            // 
            this.SyottoRTB.Location = new System.Drawing.Point(2, 3);
            this.SyottoRTB.Name = "SyottoRTB";
            this.SyottoRTB.Size = new System.Drawing.Size(665, 357);
            this.SyottoRTB.TabIndex = 0;
            this.SyottoRTB.Text = "";
            // 
            // TallennaBT
            // 
            this.TallennaBT.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TallennaBT.Location = new System.Drawing.Point(2, 366);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(665, 72);
            this.TallennaBT.TabIndex = 1;
            this.TallennaBT.Text = "Tallenna päiväkirjaan";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // PaivakirjaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 516);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.SyottoRTB);
            this.Name = "PaivakirjaF";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox SyottoRTB;
        private System.Windows.Forms.Button TallennaBT;
    }
}

