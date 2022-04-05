namespace Ajastin
{
    partial class AjastinForm
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
            this.MiLB = new System.Windows.Forms.Label();
            this.SeLB = new System.Windows.Forms.Label();
            this.AikaTimer = new System.Windows.Forms.Timer(this.components);
            this.MiCB = new System.Windows.Forms.ComboBox();
            this.SeCB = new System.Windows.Forms.ComboBox();
            this.AikaLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MiLB
            // 
            this.MiLB.AutoSize = true;
            this.MiLB.Location = new System.Drawing.Point(102, 89);
            this.MiLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MiLB.Name = "MiLB";
            this.MiLB.Size = new System.Drawing.Size(119, 36);
            this.MiLB.TabIndex = 0;
            this.MiLB.Text = "MInuutit";
            // 
            // SeLB
            // 
            this.SeLB.AutoSize = true;
            this.SeLB.Location = new System.Drawing.Point(482, 89);
            this.SeLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SeLB.Name = "SeLB";
            this.SeLB.Size = new System.Drawing.Size(121, 36);
            this.SeLB.TabIndex = 1;
            this.SeLB.Text = "Sekunnit";
            // 
            // AikaTimer
            // 
            this.AikaTimer.Tick += new System.EventHandler(this.AikaTimer_Tick);
            // 
            // MiCB
            // 
            this.MiCB.FormattingEnabled = true;
            this.MiCB.Location = new System.Drawing.Point(44, 178);
            this.MiCB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MiCB.Name = "MiCB";
            this.MiCB.Size = new System.Drawing.Size(223, 43);
            this.MiCB.TabIndex = 2;
            // 
            // SeCB
            // 
            this.SeCB.FormattingEnabled = true;
            this.SeCB.Location = new System.Drawing.Point(421, 178);
            this.SeCB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.SeCB.Name = "SeCB";
            this.SeCB.Size = new System.Drawing.Size(223, 43);
            this.SeCB.TabIndex = 3;
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Location = new System.Drawing.Point(144, 304);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(86, 36);
            this.AikaLB.TabIndex = 4;
            this.AikaLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(70, 399);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(133, 48);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(385, 398);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(136, 49);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AjastinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1185, 497);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.AikaLB);
            this.Controls.Add(this.SeCB);
            this.Controls.Add(this.MiCB);
            this.Controls.Add(this.SeLB);
            this.Controls.Add(this.MiLB);
            this.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AjastinForm";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.AjastinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MiLB;
        private System.Windows.Forms.Label SeLB;
        private System.Windows.Forms.Timer AikaTimer;
        private System.Windows.Forms.ComboBox MiCB;
        private System.Windows.Forms.ComboBox SeCB;
        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
    }
}

