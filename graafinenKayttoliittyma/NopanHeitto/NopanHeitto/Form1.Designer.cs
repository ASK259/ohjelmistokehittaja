namespace NopanHeitto
{
    partial class NopanHeitto
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
            this.HeitaBT = new System.Windows.Forms.Button();
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Jokerman", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoLB.Location = new System.Drawing.Point(231, 41);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(354, 72);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Nopan heitto";
            // 
            // HeitaBT
            // 
            this.HeitaBT.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeitaBT.ForeColor = System.Drawing.Color.Black;
            this.HeitaBT.Location = new System.Drawing.Point(366, 337);
            this.HeitaBT.Name = "HeitaBT";
            this.HeitaBT.Size = new System.Drawing.Size(120, 41);
            this.HeitaBT.TabIndex = 1;
            this.HeitaBT.Text = "Heitä";
            this.HeitaBT.UseVisualStyleBackColor = true;
            this.HeitaBT.Click += new System.EventHandler(this.HeitaBT_Click);
            // 
            // noppa01PB
            // 
            this.noppa01PB.Image = global::NopanHeitto.Properties.Resources.dice01;
            this.noppa01PB.Location = new System.Drawing.Point(243, 158);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(158, 130);
            this.noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa01PB.TabIndex = 2;
            this.noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            this.noppa02PB.Image = global::NopanHeitto.Properties.Resources.dice01;
            this.noppa02PB.Location = new System.Drawing.Point(454, 158);
            this.noppa02PB.Name = "noppa02PB";
            this.noppa02PB.Size = new System.Drawing.Size(131, 130);
            this.noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa02PB.TabIndex = 3;
            this.noppa02PB.TabStop = false;
            // 
            // NopanHeitto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(963, 521);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Controls.Add(this.HeitaBT);
            this.Controls.Add(this.OtsikkoLB);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "NopanHeitto";
            this.Text = "Nopan heitto";
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Button HeitaBT;
        private System.Windows.Forms.PictureBox noppa01PB;
        private System.Windows.Forms.PictureBox noppa02PB;
    }
}

