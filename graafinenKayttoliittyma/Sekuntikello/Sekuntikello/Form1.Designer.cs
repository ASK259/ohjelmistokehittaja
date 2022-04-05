namespace Sekuntikello
{
    partial class SekuntikelloForm
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
            this.components = new System.ComponentModel.Container();
            this.KelloLB = new System.Windows.Forms.Label();
            this.SeTimer = new System.Windows.Forms.Timer(this.components);
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KelloLB
            // 
            this.KelloLB.AutoSize = true;
            this.KelloLB.Font = new System.Drawing.Font("Yu Gothic Light", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KelloLB.Location = new System.Drawing.Point(292, 121);
            this.KelloLB.Name = "KelloLB";
            this.KelloLB.Size = new System.Drawing.Size(305, 64);
            this.KelloLB.TabIndex = 0;
            this.KelloLB.Text = "00:00:00.000";
            // 
            // SeTimer
            // 
            this.SeTimer.Enabled = true;
            this.SeTimer.Tick += new System.EventHandler(this.SeTimer_Tick);
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(77, 361);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(95, 46);
            this.StartBT.TabIndex = 1;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(419, 361);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(102, 46);
            this.StopBT.TabIndex = 2;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.Location = new System.Drawing.Point(749, 361);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(105, 46);
            this.ResetBT.TabIndex = 3;
            this.ResetBT.Text = "Reset";
            this.ResetBT.UseVisualStyleBackColor = true;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // SekuntikelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(924, 467);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.KelloLB);
            this.Font = new System.Drawing.Font("Yu Gothic Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SekuntikelloForm";
            this.Text = "Sekuntikello";
            this.Load += new System.EventHandler(this.SekuntikelloForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KelloLB;
        private System.Windows.Forms.Timer SeTimer;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Button ResetBT;
    }
}

