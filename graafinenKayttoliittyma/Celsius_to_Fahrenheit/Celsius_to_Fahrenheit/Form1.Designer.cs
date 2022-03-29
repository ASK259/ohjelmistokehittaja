namespace Celsius_to_Fahrenheit
{
    partial class LampoMuunnin
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
            this.OhjeLB = new System.Windows.Forms.Label();
            this.AsteTB = new System.Windows.Forms.TextBox();
            this.CelciusRB = new System.Windows.Forms.RadioButton();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.KysymysLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OhjeLB
            // 
            this.OhjeLB.AutoSize = true;
            this.OhjeLB.Location = new System.Drawing.Point(60, 167);
            this.OhjeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OhjeLB.Name = "OhjeLB";
            this.OhjeLB.Size = new System.Drawing.Size(130, 23);
            this.OhjeLB.TabIndex = 0;
            this.OhjeLB.Text = "Anna asteet:";
            // 
            // AsteTB
            // 
            this.AsteTB.Location = new System.Drawing.Point(213, 164);
            this.AsteTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AsteTB.Name = "AsteTB";
            this.AsteTB.Size = new System.Drawing.Size(148, 30);
            this.AsteTB.TabIndex = 1;
            // 
            // CelciusRB
            // 
            this.CelciusRB.AutoSize = true;
            this.CelciusRB.Location = new System.Drawing.Point(481, 128);
            this.CelciusRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CelciusRB.Name = "CelciusRB";
            this.CelciusRB.Size = new System.Drawing.Size(98, 27);
            this.CelciusRB.TabIndex = 2;
            this.CelciusRB.TabStop = true;
            this.CelciusRB.Text = "Celcius";
            this.CelciusRB.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Location = new System.Drawing.Point(481, 196);
            this.FahrenheitRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(138, 27);
            this.FahrenheitRB.TabIndex = 3;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "Fahrenheit";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Location = new System.Drawing.Point(711, 167);
            this.MuunnaBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(112, 33);
            this.MuunnaBT.TabIndex = 4;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(76, 334);
            this.VastausLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(81, 23);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(452, 63);
            this.KysymysLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(218, 23);
            this.KysymysLB.TabIndex = 6;
            this.KysymysLB.Text = "Kummaksi muunnat?";
            // 
            // LampoMuunnin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(991, 514);
            this.Controls.Add(this.KysymysLB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.FahrenheitRB);
            this.Controls.Add(this.CelciusRB);
            this.Controls.Add(this.AsteTB);
            this.Controls.Add(this.OhjeLB);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LampoMuunnin";
            this.Text = "Celsius to Fahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OhjeLB;
        private System.Windows.Forms.TextBox AsteTB;
        private System.Windows.Forms.RadioButton CelciusRB;
        private System.Windows.Forms.RadioButton FahrenheitRB;
        private System.Windows.Forms.Button MuunnaBT;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Label KysymysLB;
    }
}

