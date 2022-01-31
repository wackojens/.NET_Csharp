namespace Opdracht10_Reiskost_JC
{
    partial class FrmReiskost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReiskost));
            this.LblBestemming = new System.Windows.Forms.Label();
            this.LblBasisvlucht = new System.Windows.Forms.Label();
            this.LblVluchtklasse = new System.Windows.Forms.Label();
            this.LblBasisDag = new System.Windows.Forms.Label();
            this.LblAantalDag = new System.Windows.Forms.Label();
            this.LblPersonen = new System.Windows.Forms.Label();
            this.LblKortingPerc = new System.Windows.Forms.Label();
            this.TxtBestemming = new System.Windows.Forms.TextBox();
            this.TxtBasisVlucht = new System.Windows.Forms.TextBox();
            this.TxtKlasse = new System.Windows.Forms.TextBox();
            this.TxtBasisDag = new System.Windows.Forms.TextBox();
            this.TxtAantalDagen = new System.Windows.Forms.TextBox();
            this.TxtPersonen = new System.Windows.Forms.TextBox();
            this.TxtKortingPerc = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblBestemming
            // 
            this.LblBestemming.AutoSize = true;
            this.LblBestemming.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBestemming.Location = new System.Drawing.Point(60, 39);
            this.LblBestemming.Name = "LblBestemming";
            this.LblBestemming.Size = new System.Drawing.Size(81, 15);
            this.LblBestemming.TabIndex = 0;
            this.LblBestemming.Text = "Bestemming:";
            // 
            // LblBasisvlucht
            // 
            this.LblBasisvlucht.AutoSize = true;
            this.LblBasisvlucht.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBasisvlucht.Location = new System.Drawing.Point(68, 69);
            this.LblBasisvlucht.Name = "LblBasisvlucht";
            this.LblBasisvlucht.Size = new System.Drawing.Size(73, 15);
            this.LblBasisvlucht.TabIndex = 1;
            this.LblBasisvlucht.Text = "Basisvlucht:";
            // 
            // LblVluchtklasse
            // 
            this.LblVluchtklasse.AutoSize = true;
            this.LblVluchtklasse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVluchtklasse.Location = new System.Drawing.Point(13, 99);
            this.LblVluchtklasse.Name = "LblVluchtklasse";
            this.LblVluchtklasse.Size = new System.Drawing.Size(131, 15);
            this.LblVluchtklasse.TabIndex = 2;
            this.LblVluchtklasse.Text = "Vluchtklasse (1,2 of 3):";
            // 
            // LblBasisDag
            // 
            this.LblBasisDag.AutoSize = true;
            this.LblBasisDag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBasisDag.Location = new System.Drawing.Point(36, 129);
            this.LblBasisDag.Name = "LblBasisDag";
            this.LblBasisDag.Size = new System.Drawing.Size(111, 15);
            this.LblBasisDag.TabIndex = 3;
            this.LblBasisDag.Text = "Basisprijs per dag:";
            // 
            // LblAantalDag
            // 
            this.LblAantalDag.AutoSize = true;
            this.LblAantalDag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAantalDag.Location = new System.Drawing.Point(57, 159);
            this.LblAantalDag.Name = "LblAantalDag";
            this.LblAantalDag.Size = new System.Drawing.Size(82, 15);
            this.LblAantalDag.TabIndex = 4;
            this.LblAantalDag.Text = "Aantal dagen:";
            // 
            // LblPersonen
            // 
            this.LblPersonen.AutoSize = true;
            this.LblPersonen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPersonen.Location = new System.Drawing.Point(41, 189);
            this.LblPersonen.Name = "LblPersonen";
            this.LblPersonen.Size = new System.Drawing.Size(100, 15);
            this.LblPersonen.TabIndex = 5;
            this.LblPersonen.Text = "Aantal personen:";
            // 
            // LblKortingPerc
            // 
            this.LblKortingPerc.AutoSize = true;
            this.LblKortingPerc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblKortingPerc.Location = new System.Drawing.Point(36, 219);
            this.LblKortingPerc.Name = "LblKortingPerc";
            this.LblKortingPerc.Size = new System.Drawing.Size(118, 15);
            this.LblKortingPerc.TabIndex = 6;
            this.LblKortingPerc.Text = "Kortingspercentage:";
            // 
            // TxtBestemming
            // 
            this.TxtBestemming.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBestemming.Location = new System.Drawing.Point(170, 31);
            this.TxtBestemming.Name = "TxtBestemming";
            this.TxtBestemming.Size = new System.Drawing.Size(100, 21);
            this.TxtBestemming.TabIndex = 7;
            this.TxtBestemming.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtBasisVlucht
            // 
            this.TxtBasisVlucht.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBasisVlucht.Location = new System.Drawing.Point(170, 61);
            this.TxtBasisVlucht.Name = "TxtBasisVlucht";
            this.TxtBasisVlucht.Size = new System.Drawing.Size(100, 21);
            this.TxtBasisVlucht.TabIndex = 8;
            this.TxtBasisVlucht.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtKlasse
            // 
            this.TxtKlasse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKlasse.Location = new System.Drawing.Point(170, 91);
            this.TxtKlasse.Name = "TxtKlasse";
            this.TxtKlasse.Size = new System.Drawing.Size(100, 21);
            this.TxtKlasse.TabIndex = 9;
            this.TxtKlasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtKlasse.Enter += new System.EventHandler(this.TxtKlasse_Enter);
            this.TxtKlasse.Leave += new System.EventHandler(this.TxtKlasse_Leave);
            // 
            // TxtBasisDag
            // 
            this.TxtBasisDag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBasisDag.Location = new System.Drawing.Point(170, 121);
            this.TxtBasisDag.Name = "TxtBasisDag";
            this.TxtBasisDag.Size = new System.Drawing.Size(100, 21);
            this.TxtBasisDag.TabIndex = 10;
            this.TxtBasisDag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtAantalDagen
            // 
            this.TxtAantalDagen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAantalDagen.Location = new System.Drawing.Point(170, 150);
            this.TxtAantalDagen.Name = "TxtAantalDagen";
            this.TxtAantalDagen.Size = new System.Drawing.Size(100, 21);
            this.TxtAantalDagen.TabIndex = 11;
            this.TxtAantalDagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtPersonen
            // 
            this.TxtPersonen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPersonen.Location = new System.Drawing.Point(170, 181);
            this.TxtPersonen.Name = "TxtPersonen";
            this.TxtPersonen.Size = new System.Drawing.Size(100, 21);
            this.TxtPersonen.TabIndex = 12;
            this.TxtPersonen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtKortingPerc
            // 
            this.TxtKortingPerc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKortingPerc.Location = new System.Drawing.Point(170, 211);
            this.TxtKortingPerc.Name = "TxtKortingPerc";
            this.TxtKortingPerc.Size = new System.Drawing.Size(100, 21);
            this.TxtKortingPerc.TabIndex = 13;
            this.TxtKortingPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(13, 269);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(375, 178);
            this.TxtResultaat.TabIndex = 14;
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(313, 151);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 23);
            this.BtnBereken.TabIndex = 15;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(313, 181);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 23);
            this.BtnWissen.TabIndex = 16;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(313, 211);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 23);
            this.BtnSluiten.TabIndex = 17;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmReiskost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 489);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.TxtKortingPerc);
            this.Controls.Add(this.TxtPersonen);
            this.Controls.Add(this.TxtAantalDagen);
            this.Controls.Add(this.TxtBasisDag);
            this.Controls.Add(this.TxtKlasse);
            this.Controls.Add(this.TxtBasisVlucht);
            this.Controls.Add(this.TxtBestemming);
            this.Controls.Add(this.LblKortingPerc);
            this.Controls.Add(this.LblPersonen);
            this.Controls.Add(this.LblAantalDag);
            this.Controls.Add(this.LblBasisDag);
            this.Controls.Add(this.LblVluchtklasse);
            this.Controls.Add(this.LblBasisvlucht);
            this.Controls.Add(this.LblBestemming);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReiskost";
            this.Text = "Berekening reiskost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblBestemming;
        private Label LblBasisvlucht;
        private Label LblVluchtklasse;
        private Label LblBasisDag;
        private Label LblAantalDag;
        private Label LblPersonen;
        private Label LblKortingPerc;
        private TextBox TxtBestemming;
        private TextBox TxtBasisVlucht;
        private TextBox TxtKlasse;
        private TextBox TxtBasisDag;
        private TextBox TxtAantalDagen;
        private TextBox TxtPersonen;
        private TextBox TxtKortingPerc;
        private TextBox TxtResultaat;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}