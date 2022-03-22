namespace roomalaiset_nrot
{
    partial class roomalaisetNro
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
            this.OhjeLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.LukuTB = new System.Windows.Forms.TextBox();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoLB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OtsikkoLB.Location = new System.Drawing.Point(115, 53);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(388, 60);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Roomalaiset numerot";
            // 
            // OhjeLB
            // 
            this.OhjeLB.AutoSize = true;
            this.OhjeLB.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OhjeLB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OhjeLB.Location = new System.Drawing.Point(118, 137);
            this.OhjeLB.Name = "OhjeLB";
            this.OhjeLB.Size = new System.Drawing.Size(582, 34);
            this.OhjeLB.TabIndex = 1;
            this.OhjeLB.Text = "Anna luku väliltä(1-3999), niin se muutetaan roomalaiseksi:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.VastausLB.Location = new System.Drawing.Point(118, 201);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(85, 34);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // LukuTB
            // 
            this.LukuTB.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LukuTB.Location = new System.Drawing.Point(789, 137);
            this.LukuTB.Name = "LukuTB";
            this.LukuTB.Size = new System.Drawing.Size(100, 32);
            this.LukuTB.TabIndex = 3;
            // 
            // MuutaBT
            // 
            this.MuutaBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MuutaBT.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuutaBT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MuutaBT.Location = new System.Drawing.Point(789, 212);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(110, 40);
            this.MuutaBT.TabIndex = 4;
            this.MuutaBT.Text = "Muuta";
            this.MuutaBT.UseVisualStyleBackColor = true;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // roomalaisetNro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(991, 523);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.LukuTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.OhjeLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Name = "roomalaisetNro";
            this.Text = "Numeroiden muutos latinalaisista roomalaisiksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Label OhjeLB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox LukuTB;
        private System.Windows.Forms.Button MuutaBT;
    }
}

