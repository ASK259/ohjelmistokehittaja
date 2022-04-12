namespace Oppilashallintajarjestelma
{
    partial class OHallintaForm
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
            this.Tiedot = new System.Windows.Forms.DataGridView();
            this.OpIdLB = new System.Windows.Forms.Label();
            this.EniLB = new System.Windows.Forms.Label();
            this.PNroLB = new System.Windows.Forms.Label();
            this.SniLB = new System.Windows.Forms.Label();
            this.SpoLB = new System.Windows.Forms.Label();
            this.EniTB = new System.Windows.Forms.TextBox();
            this.SniTB = new System.Windows.Forms.TextBox();
            this.PnroTB = new System.Windows.Forms.TextBox();
            this.SpoTB = new System.Windows.Forms.TextBox();
            this.OIdTB = new System.Windows.Forms.TextBox();
            this.TaBT = new System.Windows.Forms.Button();
            this.PaBT = new System.Windows.Forms.Button();
            this.TyBT = new System.Windows.Forms.Button();
            this.PoBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tiedot)).BeginInit();
            this.SuspendLayout();
            // 
            // Tiedot
            // 
            this.Tiedot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tiedot.Location = new System.Drawing.Point(0, 278);
            this.Tiedot.Name = "Tiedot";
            this.Tiedot.RowHeadersWidth = 51;
            this.Tiedot.RowTemplate.Height = 24;
            this.Tiedot.Size = new System.Drawing.Size(1116, 281);
            this.Tiedot.TabIndex = 0;
            this.Tiedot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tiedot_CellContentClick);
            // 
            // OpIdLB
            // 
            this.OpIdLB.AutoSize = true;
            this.OpIdLB.Location = new System.Drawing.Point(377, 30);
            this.OpIdLB.Name = "OpIdLB";
            this.OpIdLB.Size = new System.Drawing.Size(112, 16);
            this.OpIdLB.TabIndex = 1;
            this.OpIdLB.Text = "Opiskelijanumero";
            // 
            // EniLB
            // 
            this.EniLB.AutoSize = true;
            this.EniLB.Location = new System.Drawing.Point(80, 87);
            this.EniLB.Name = "EniLB";
            this.EniLB.Size = new System.Drawing.Size(53, 16);
            this.EniLB.TabIndex = 2;
            this.EniLB.Text = "Etunimi:";
            // 
            // PNroLB
            // 
            this.PNroLB.AutoSize = true;
            this.PNroLB.Location = new System.Drawing.Point(574, 87);
            this.PNroLB.Name = "PNroLB";
            this.PNroLB.Size = new System.Drawing.Size(54, 16);
            this.PNroLB.TabIndex = 3;
            this.PNroLB.Text = "Puhelin:";
            // 
            // SniLB
            // 
            this.SniLB.AutoSize = true;
            this.SniLB.Location = new System.Drawing.Point(80, 160);
            this.SniLB.Name = "SniLB";
            this.SniLB.Size = new System.Drawing.Size(64, 16);
            this.SniLB.TabIndex = 4;
            this.SniLB.Text = "Sukunimi:";
            // 
            // SpoLB
            // 
            this.SpoLB.AutoSize = true;
            this.SpoLB.Location = new System.Drawing.Point(574, 160);
            this.SpoLB.Name = "SpoLB";
            this.SpoLB.Size = new System.Drawing.Size(78, 16);
            this.SpoLB.TabIndex = 5;
            this.SpoLB.Text = "Sähköposti:";
            // 
            // EniTB
            // 
            this.EniTB.Location = new System.Drawing.Point(220, 84);
            this.EniTB.Name = "EniTB";
            this.EniTB.Size = new System.Drawing.Size(100, 22);
            this.EniTB.TabIndex = 6;
            // 
            // SniTB
            // 
            this.SniTB.Location = new System.Drawing.Point(220, 154);
            this.SniTB.Name = "SniTB";
            this.SniTB.Size = new System.Drawing.Size(100, 22);
            this.SniTB.TabIndex = 7;
            // 
            // PnroTB
            // 
            this.PnroTB.Location = new System.Drawing.Point(710, 84);
            this.PnroTB.Name = "PnroTB";
            this.PnroTB.Size = new System.Drawing.Size(100, 22);
            this.PnroTB.TabIndex = 8;
            // 
            // SpoTB
            // 
            this.SpoTB.Location = new System.Drawing.Point(710, 157);
            this.SpoTB.Name = "SpoTB";
            this.SpoTB.Size = new System.Drawing.Size(100, 22);
            this.SpoTB.TabIndex = 9;
            // 
            // OIdTB
            // 
            this.OIdTB.Location = new System.Drawing.Point(511, 27);
            this.OIdTB.Name = "OIdTB";
            this.OIdTB.Size = new System.Drawing.Size(122, 22);
            this.OIdTB.TabIndex = 10;
            // 
            // TaBT
            // 
            this.TaBT.Location = new System.Drawing.Point(113, 232);
            this.TaBT.Name = "TaBT";
            this.TaBT.Size = new System.Drawing.Size(75, 23);
            this.TaBT.TabIndex = 11;
            this.TaBT.Text = "Tallenna";
            this.TaBT.UseVisualStyleBackColor = true;
            this.TaBT.Click += new System.EventHandler(this.TaBT_Click);
            // 
            // PaBT
            // 
            this.PaBT.Location = new System.Drawing.Point(358, 232);
            this.PaBT.Name = "PaBT";
            this.PaBT.Size = new System.Drawing.Size(75, 23);
            this.PaBT.TabIndex = 12;
            this.PaBT.Text = "Päivitä";
            this.PaBT.UseVisualStyleBackColor = true;
            this.PaBT.Click += new System.EventHandler(this.PaBT_Click);
            // 
            // TyBT
            // 
            this.TyBT.Location = new System.Drawing.Point(622, 232);
            this.TyBT.Name = "TyBT";
            this.TyBT.Size = new System.Drawing.Size(75, 23);
            this.TyBT.TabIndex = 13;
            this.TyBT.Text = "Tyhjennä";
            this.TyBT.UseVisualStyleBackColor = true;
            this.TyBT.Click += new System.EventHandler(this.TyBT_Click);
            // 
            // PoBT
            // 
            this.PoBT.Location = new System.Drawing.Point(877, 232);
            this.PoBT.Name = "PoBT";
            this.PoBT.Size = new System.Drawing.Size(75, 23);
            this.PoBT.TabIndex = 14;
            this.PoBT.Text = "Poista";
            this.PoBT.UseVisualStyleBackColor = true;
            this.PoBT.Click += new System.EventHandler(this.PoBT_Click);
            // 
            // OHallintaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 559);
            this.Controls.Add(this.PoBT);
            this.Controls.Add(this.TyBT);
            this.Controls.Add(this.PaBT);
            this.Controls.Add(this.TaBT);
            this.Controls.Add(this.OIdTB);
            this.Controls.Add(this.SpoTB);
            this.Controls.Add(this.PnroTB);
            this.Controls.Add(this.SniTB);
            this.Controls.Add(this.EniTB);
            this.Controls.Add(this.SpoLB);
            this.Controls.Add(this.SniLB);
            this.Controls.Add(this.PNroLB);
            this.Controls.Add(this.EniLB);
            this.Controls.Add(this.OpIdLB);
            this.Controls.Add(this.Tiedot);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OHallintaForm";
            this.Text = "Oppilashallinta";
            this.Load += new System.EventHandler(this.OHallintaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tiedot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tiedot;
        private System.Windows.Forms.Label OpIdLB;
        private System.Windows.Forms.Label EniLB;
        private System.Windows.Forms.Label PNroLB;
        private System.Windows.Forms.Label SniLB;
        private System.Windows.Forms.Label SpoLB;
        private System.Windows.Forms.TextBox EniTB;
        private System.Windows.Forms.TextBox SniTB;
        private System.Windows.Forms.TextBox PnroTB;
        private System.Windows.Forms.TextBox SpoTB;
        private System.Windows.Forms.TextBox OIdTB;
        private System.Windows.Forms.Button TaBT;
        private System.Windows.Forms.Button PaBT;
        private System.Windows.Forms.Button TyBT;
        private System.Windows.Forms.Button PoBT;
    }
}

