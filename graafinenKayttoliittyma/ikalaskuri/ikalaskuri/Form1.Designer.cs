namespace ikalaskuri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vaPaDT = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VuLB = new System.Windows.Forms.Label();
            this.KkLB = new System.Windows.Forms.Label();
            this.PaLB = new System.Windows.Forms.Label();
            this.TuLB = new System.Windows.Forms.Label();
            this.MiLB = new System.Windows.Forms.Label();
            this.SeLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vaPaDT
            // 
            this.vaPaDT.Location = new System.Drawing.Point(110, 46);
            this.vaPaDT.Name = "vaPaDT";
            this.vaPaDT.Size = new System.Drawing.Size(251, 27);
            this.vaPaDT.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(406, 46);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(94, 29);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VuLB
            // 
            this.VuLB.AutoSize = true;
            this.VuLB.Location = new System.Drawing.Point(110, 117);
            this.VuLB.Name = "VuLB";
            this.VuLB.Size = new System.Drawing.Size(55, 20);
            this.VuLB.TabIndex = 2;
            this.VuLB.Text = "vuodet";
            this.VuLB.Visible = false;
            // 
            // KkLB
            // 
            this.KkLB.AutoSize = true;
            this.KkLB.Location = new System.Drawing.Point(110, 162);
            this.KkLB.Name = "KkLB";
            this.KkLB.Size = new System.Drawing.Size(77, 20);
            this.KkLB.TabIndex = 3;
            this.KkLB.Text = "kuukaudet";
            this.KkLB.Visible = false;
            // 
            // PaLB
            // 
            this.PaLB.AutoSize = true;
            this.PaLB.Location = new System.Drawing.Point(110, 206);
            this.PaLB.Name = "PaLB";
            this.PaLB.Size = new System.Drawing.Size(50, 20);
            this.PaLB.TabIndex = 4;
            this.PaLB.Text = "päivät";
            this.PaLB.Visible = false;
            // 
            // TuLB
            // 
            this.TuLB.AutoSize = true;
            this.TuLB.Location = new System.Drawing.Point(406, 117);
            this.TuLB.Name = "TuLB";
            this.TuLB.Size = new System.Drawing.Size(47, 20);
            this.TuLB.TabIndex = 5;
            this.TuLB.Text = "tunnit";
            this.TuLB.Visible = false;
            // 
            // MiLB
            // 
            this.MiLB.AutoSize = true;
            this.MiLB.Location = new System.Drawing.Point(406, 162);
            this.MiLB.Name = "MiLB";
            this.MiLB.Size = new System.Drawing.Size(64, 20);
            this.MiLB.TabIndex = 6;
            this.MiLB.Text = "minuutit";
            this.MiLB.Visible = false;

            // 
            // SeLB
            // 
            this.SeLB.AutoSize = true;
            this.SeLB.Location = new System.Drawing.Point(406, 206);
            this.SeLB.Name = "SeLB";
            this.SeLB.Size = new System.Drawing.Size(63, 20);
            this.SeLB.TabIndex = 7;
            this.SeLB.Text = "sekunnit";
            this.SeLB.Visible = false;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 750);
            this.Controls.Add(this.SeLB);
            this.Controls.Add(this.MiLB);
            this.Controls.Add(this.TuLB);
            this.Controls.Add(this.PaLB);
            this.Controls.Add(this.KkLB);
            this.Controls.Add(this.VuLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.vaPaDT);
            this.Name = "Form1";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker vaPaDT;
        private Button LaskeBT;
        private Label VuLB;
        private Label KkLB;
        private Label PaLB;
        private Label TuLB;
        private Label MiLB;
        private Label SeLB;
    }
}