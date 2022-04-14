namespace Cryptaus_harjoitus
{
    partial class CryptForm
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
            this.PasswordLB = new System.Windows.Forms.Label();
            this.CryptLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.CryptCB = new System.Windows.Forms.ComboBox();
            this.CryptBT = new System.Windows.Forms.Button();
            this.DecryptBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.Location = new System.Drawing.Point(65, 65);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(123, 45);
            this.PasswordLB.TabIndex = 0;
            this.PasswordLB.Text = "Salasana:";
            // 
            // CryptLB
            // 
            this.CryptLB.AutoSize = true;
            this.CryptLB.Location = new System.Drawing.Point(65, 158);
            this.CryptLB.Name = "CryptLB";
            this.CryptLB.Size = new System.Drawing.Size(133, 45);
            this.CryptLB.TabIndex = 1;
            this.CryptLB.Text = "Cryptattu:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(65, 252);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(109, 45);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(235, 65);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(472, 53);
            this.PasswordTB.TabIndex = 3;
            // 
            // CryptCB
            // 
            this.CryptCB.FormattingEnabled = true;
            this.CryptCB.Location = new System.Drawing.Point(235, 150);
            this.CryptCB.Name = "CryptCB";
            this.CryptCB.Size = new System.Drawing.Size(472, 53);
            this.CryptCB.TabIndex = 4;
            this.CryptCB.SelectedIndexChanged += new System.EventHandler(this.CryptCB_SelectedIndexChanged);
            // 
            // CryptBT
            // 
            this.CryptBT.Location = new System.Drawing.Point(746, 70);
            this.CryptBT.Name = "CryptBT";
            this.CryptBT.Size = new System.Drawing.Size(134, 48);
            this.CryptBT.TabIndex = 5;
            this.CryptBT.Text = "Cryptaa";
            this.CryptBT.UseVisualStyleBackColor = true;
            this.CryptBT.Click += new System.EventHandler(this.CryptBT_Click);
            // 
            // DecryptBT
            // 
            this.DecryptBT.Location = new System.Drawing.Point(746, 153);
            this.DecryptBT.Name = "DecryptBT";
            this.DecryptBT.Size = new System.Drawing.Size(199, 50);
            this.DecryptBT.TabIndex = 6;
            this.DecryptBT.Text = "Näytä salasana";
            this.DecryptBT.UseVisualStyleBackColor = true;
            this.DecryptBT.Click += new System.EventHandler(this.DecryptBT_Click);
            // 
            // CryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 478);
            this.Controls.Add(this.DecryptBT);
            this.Controls.Add(this.CryptBT);
            this.Controls.Add(this.CryptCB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.CryptLB);
            this.Controls.Add(this.PasswordLB);
            this.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "CryptForm";
            this.Text = "Salasanan Cryptaus";
            this.Load += new System.EventHandler(this.CryptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.Label CryptLB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.ComboBox CryptCB;
        private System.Windows.Forms.Button CryptBT;
        private System.Windows.Forms.Button DecryptBT;
    }
}

