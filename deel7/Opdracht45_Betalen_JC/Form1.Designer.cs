namespace Opdracht45_Betalen_JC
{
    partial class FrmCoupures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoupures));
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.LblBedrag = new System.Windows.Forms.Label();
            this.TxtBedrag = new System.Windows.Forms.TextBox();
            this.LblAantal = new System.Windows.Forms.Label();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Location = new System.Drawing.Point(276, 162);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 23);
            this.BtnBereken.TabIndex = 0;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Location = new System.Drawing.Point(276, 206);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 23);
            this.BtnWissen.TabIndex = 1;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(276, 249);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 23);
            this.BtnSluiten.TabIndex = 2;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // LblBedrag
            // 
            this.LblBedrag.AutoSize = true;
            this.LblBedrag.Location = new System.Drawing.Point(37, 34);
            this.LblBedrag.Name = "LblBedrag";
            this.LblBedrag.Size = new System.Drawing.Size(48, 16);
            this.LblBedrag.TabIndex = 3;
            this.LblBedrag.Text = "Bedrag";
            // 
            // TxtBedrag
            // 
            this.TxtBedrag.Location = new System.Drawing.Point(37, 53);
            this.TxtBedrag.Name = "TxtBedrag";
            this.TxtBedrag.Size = new System.Drawing.Size(100, 22);
            this.TxtBedrag.TabIndex = 4;
            this.TxtBedrag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBedrag_KeyPress);
            // 
            // LblAantal
            // 
            this.LblAantal.AutoSize = true;
            this.LblAantal.Location = new System.Drawing.Point(37, 112);
            this.LblAantal.Name = "LblAantal";
            this.LblAantal.Size = new System.Drawing.Size(44, 16);
            this.LblAantal.TabIndex = 5;
            this.LblAantal.Text = "Aantal";
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Location = new System.Drawing.Point(37, 131);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.ReadOnly = true;
            this.TxtResultaat.Size = new System.Drawing.Size(189, 169);
            this.TxtResultaat.TabIndex = 6;
            // 
            // FrmCoupures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 346);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.LblAantal);
            this.Controls.Add(this.TxtBedrag);
            this.Controls.Add(this.LblBedrag);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCoupures";
            this.Text = "Berekening coupures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
        private Label LblBedrag;
        private TextBox TxtBedrag;
        private Label LblAantal;
        private TextBox TxtResultaat;
    }
}