namespace Opdracht19_Dubbelfeest_JC
{
    partial class FrmDubbelfeest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDubbelfeest));
            this.LblPersonen = new System.Windows.Forms.Label();
            this.TxtPersonen = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblPersonen
            // 
            this.LblPersonen.AutoSize = true;
            this.LblPersonen.Location = new System.Drawing.Point(43, 56);
            this.LblPersonen.Name = "LblPersonen";
            this.LblPersonen.Size = new System.Drawing.Size(101, 16);
            this.LblPersonen.TabIndex = 0;
            this.LblPersonen.Text = "Aantal personen";
            // 
            // TxtPersonen
            // 
            this.TxtPersonen.Location = new System.Drawing.Point(43, 75);
            this.TxtPersonen.Name = "TxtPersonen";
            this.TxtPersonen.Size = new System.Drawing.Size(69, 22);
            this.TxtPersonen.TabIndex = 1;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Location = new System.Drawing.Point(43, 125);
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(299, 22);
            this.TxtResultaat.TabIndex = 2;
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Location = new System.Drawing.Point(43, 175);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 25);
            this.BtnBereken.TabIndex = 3;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Location = new System.Drawing.Point(154, 175);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 25);
            this.BtnWissen.TabIndex = 4;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(267, 175);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 25);
            this.BtnSluiten.TabIndex = 5;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmDubbelfeest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 236);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.TxtPersonen);
            this.Controls.Add(this.LblPersonen);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDubbelfeest";
            this.Text = "Berekening van de kans op een \"dubbel\"feest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblPersonen;
        private TextBox TxtPersonen;
        private TextBox TxtResultaat;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}