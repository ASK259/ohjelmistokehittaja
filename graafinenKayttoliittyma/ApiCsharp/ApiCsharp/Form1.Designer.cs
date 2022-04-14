namespace ApiCsharp
{
    partial class ApiForm
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
            this.TiedotDGV = new System.Windows.Forms.DataGridView();
            this.HaeBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TiedotDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TiedotDGV
            // 
            this.TiedotDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TiedotDGV.Location = new System.Drawing.Point(-2, 233);
            this.TiedotDGV.Name = "TiedotDGV";
            this.TiedotDGV.RowHeadersWidth = 51;
            this.TiedotDGV.RowTemplate.Height = 24;
            this.TiedotDGV.Size = new System.Drawing.Size(947, 256);
            this.TiedotDGV.TabIndex = 0;
            // 
            // HaeBT
            // 
            this.HaeBT.Location = new System.Drawing.Point(49, 89);
            this.HaeBT.Name = "HaeBT";
            this.HaeBT.Size = new System.Drawing.Size(125, 48);
            this.HaeBT.TabIndex = 1;
            this.HaeBT.Text = "Hae tietoja";
            this.HaeBT.UseVisualStyleBackColor = true;
            this.HaeBT.Click += new System.EventHandler(this.HaeBT_Click);
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 485);
            this.Controls.Add(this.HaeBT);
            this.Controls.Add(this.TiedotDGV);
            this.Name = "ApiForm";
            this.Text = "Api testi";
            ((System.ComponentModel.ISupportInitialize)(this.TiedotDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TiedotDGV;
        private System.Windows.Forms.Button HaeBT;
    }
}

