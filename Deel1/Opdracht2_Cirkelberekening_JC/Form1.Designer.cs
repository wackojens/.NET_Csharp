namespace Opdracht2_Cirkelberekening_JC
{
    partial class FrmCircle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCircle));
            this.LblStraal = new System.Windows.Forms.Label();
            this.LblOppervlakte = new System.Windows.Forms.Label();
            this.LblOmtrek = new System.Windows.Forms.Label();
            this.TxtStraal = new System.Windows.Forms.TextBox();
            this.TxtOppervlakte = new System.Windows.Forms.TextBox();
            this.TxtOmtrek = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblStraal
            // 
            this.LblStraal.AutoSize = true;
            this.LblStraal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStraal.Location = new System.Drawing.Point(60, 45);
            this.LblStraal.Name = "LblStraal";
            this.LblStraal.Size = new System.Drawing.Size(75, 16);
            this.LblStraal.TabIndex = 0;
            this.LblStraal.Text = "Straal (cm):";
            // 
            // LblOppervlakte
            // 
            this.LblOppervlakte.AutoSize = true;
            this.LblOppervlakte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOppervlakte.Location = new System.Drawing.Point(60, 90);
            this.LblOppervlakte.Name = "LblOppervlakte";
            this.LblOppervlakte.Size = new System.Drawing.Size(109, 16);
            this.LblOppervlakte.TabIndex = 1;
            this.LblOppervlakte.Text = "Oppervlakte (cm):";
            // 
            // LblOmtrek
            // 
            this.LblOmtrek.AutoSize = true;
            this.LblOmtrek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOmtrek.Location = new System.Drawing.Point(60, 135);
            this.LblOmtrek.Name = "LblOmtrek";
            this.LblOmtrek.Size = new System.Drawing.Size(84, 16);
            this.LblOmtrek.TabIndex = 2;
            this.LblOmtrek.Text = "Omtrek (cm):";
            // 
            // TxtStraal
            // 
            this.TxtStraal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtStraal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStraal.Location = new System.Drawing.Point(172, 45);
            this.TxtStraal.Name = "TxtStraal";
            this.TxtStraal.Size = new System.Drawing.Size(100, 22);
            this.TxtStraal.TabIndex = 3;
            this.TxtStraal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtOppervlakte
            // 
            this.TxtOppervlakte.Enabled = false;
            this.TxtOppervlakte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtOppervlakte.Location = new System.Drawing.Point(172, 90);
            this.TxtOppervlakte.Name = "TxtOppervlakte";
            this.TxtOppervlakte.Size = new System.Drawing.Size(100, 22);
            this.TxtOppervlakte.TabIndex = 4;
            this.TxtOppervlakte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtOmtrek
            // 
            this.TxtOmtrek.Enabled = false;
            this.TxtOmtrek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtOmtrek.Location = new System.Drawing.Point(172, 135);
            this.TxtOmtrek.Name = "TxtOmtrek";
            this.TxtOmtrek.Size = new System.Drawing.Size(100, 22);
            this.TxtOmtrek.TabIndex = 5;
            this.TxtOmtrek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(307, 45);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 23);
            this.BtnBereken.TabIndex = 6;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(307, 135);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 23);
            this.BtnWissen.TabIndex = 7;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // FrmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 215);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtOmtrek);
            this.Controls.Add(this.TxtOppervlakte);
            this.Controls.Add(this.TxtStraal);
            this.Controls.Add(this.LblOmtrek);
            this.Controls.Add(this.LblOppervlakte);
            this.Controls.Add(this.LblStraal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCircle";
            this.Text = "Berekening van oppervlakte en omtrek van een cirkel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblStraal;
        private Label LblOppervlakte;
        private Label LblOmtrek;
        private TextBox TxtStraal;
        private TextBox TxtOppervlakte;
        private TextBox TxtOmtrek;
        private Button BtnBereken;
        private Button BtnWissen;
    }
}