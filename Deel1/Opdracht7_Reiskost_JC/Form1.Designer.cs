namespace Opdracht7_Reiskost_JC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblBestemming = new System.Windows.Forms.Label();
            this.LblVlucht = new System.Windows.Forms.Label();
            this.LblKlasse = new System.Windows.Forms.Label();
            this.LblBasisDag = new System.Windows.Forms.Label();
            this.LblAantalDagen = new System.Windows.Forms.Label();
            this.LblPersonen = new System.Windows.Forms.Label();
            this.LblKorting = new System.Windows.Forms.Label();
            this.TxtBestemming = new System.Windows.Forms.TextBox();
            this.TxtBasisVlucht = new System.Windows.Forms.TextBox();
            this.TxtKlasse = new System.Windows.Forms.TextBox();
            this.TxtBasisDag = new System.Windows.Forms.TextBox();
            this.TxtAantalDag = new System.Windows.Forms.TextBox();
            this.TxtPersonen = new System.Windows.Forms.TextBox();
            this.TxtKorting = new System.Windows.Forms.TextBox();
            this.LblOpties = new System.Windows.Forms.Label();
            this.BtnBerekenen = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblBestemming
            // 
            this.LblBestemming.AutoSize = true;
            this.LblBestemming.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBestemming.Location = new System.Drawing.Point(64, 33);
            this.LblBestemming.Name = "LblBestemming";
            this.LblBestemming.Size = new System.Drawing.Size(81, 15);
            this.LblBestemming.TabIndex = 0;
            this.LblBestemming.Text = "Bestemming:";
            // 
            // LblVlucht
            // 
            this.LblVlucht.AutoSize = true;
            this.LblVlucht.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVlucht.Location = new System.Drawing.Point(72, 63);
            this.LblVlucht.Name = "LblVlucht";
            this.LblVlucht.Size = new System.Drawing.Size(73, 15);
            this.LblVlucht.TabIndex = 1;
            this.LblVlucht.Text = "Basisvlucht:";
            // 
            // LblKlasse
            // 
            this.LblKlasse.AutoSize = true;
            this.LblKlasse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblKlasse.Location = new System.Drawing.Point(14, 93);
            this.LblKlasse.Name = "LblKlasse";
            this.LblKlasse.Size = new System.Drawing.Size(131, 15);
            this.LblKlasse.TabIndex = 2;
            this.LblKlasse.Text = "Vluchtklasse (1,2 of 3):";
            // 
            // LblBasisDag
            // 
            this.LblBasisDag.AutoSize = true;
            this.LblBasisDag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBasisDag.Location = new System.Drawing.Point(34, 123);
            this.LblBasisDag.Name = "LblBasisDag";
            this.LblBasisDag.Size = new System.Drawing.Size(111, 15);
            this.LblBasisDag.TabIndex = 3;
            this.LblBasisDag.Text = "Basisprijs per dag:";
            // 
            // LblAantalDagen
            // 
            this.LblAantalDagen.AutoSize = true;
            this.LblAantalDagen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAantalDagen.Location = new System.Drawing.Point(63, 153);
            this.LblAantalDagen.Name = "LblAantalDagen";
            this.LblAantalDagen.Size = new System.Drawing.Size(82, 15);
            this.LblAantalDagen.TabIndex = 4;
            this.LblAantalDagen.Text = "Aantal dagen:";
            // 
            // LblPersonen
            // 
            this.LblPersonen.AutoSize = true;
            this.LblPersonen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPersonen.Location = new System.Drawing.Point(45, 183);
            this.LblPersonen.Name = "LblPersonen";
            this.LblPersonen.Size = new System.Drawing.Size(100, 15);
            this.LblPersonen.TabIndex = 5;
            this.LblPersonen.Text = "Aantal personen:";
            // 
            // LblKorting
            // 
            this.LblKorting.AutoSize = true;
            this.LblKorting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblKorting.Location = new System.Drawing.Point(27, 213);
            this.LblKorting.Name = "LblKorting";
            this.LblKorting.Size = new System.Drawing.Size(118, 15);
            this.LblKorting.TabIndex = 6;
            this.LblKorting.Text = "Kortingspercentage:";
            // 
            // TxtBestemming
            // 
            this.TxtBestemming.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBestemming.Location = new System.Drawing.Point(151, 27);
            this.TxtBestemming.Name = "TxtBestemming";
            this.TxtBestemming.Size = new System.Drawing.Size(100, 21);
            this.TxtBestemming.TabIndex = 7;
            // 
            // TxtBasisVlucht
            // 
            this.TxtBasisVlucht.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBasisVlucht.Location = new System.Drawing.Point(151, 57);
            this.TxtBasisVlucht.Name = "TxtBasisVlucht";
            this.TxtBasisVlucht.Size = new System.Drawing.Size(100, 21);
            this.TxtBasisVlucht.TabIndex = 8;
            // 
            // TxtKlasse
            // 
            this.TxtKlasse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKlasse.Location = new System.Drawing.Point(151, 87);
            this.TxtKlasse.Name = "TxtKlasse";
            this.TxtKlasse.Size = new System.Drawing.Size(100, 21);
            this.TxtKlasse.TabIndex = 9;
            this.TxtKlasse.Enter += new System.EventHandler(this.TxtKlasse_Enter);
            this.TxtKlasse.Leave += new System.EventHandler(this.TxtKlasse_Leave);
            // 
            // TxtBasisDag
            // 
            this.TxtBasisDag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBasisDag.Location = new System.Drawing.Point(151, 117);
            this.TxtBasisDag.Name = "TxtBasisDag";
            this.TxtBasisDag.Size = new System.Drawing.Size(100, 21);
            this.TxtBasisDag.TabIndex = 10;
            // 
            // TxtAantalDag
            // 
            this.TxtAantalDag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAantalDag.Location = new System.Drawing.Point(151, 147);
            this.TxtAantalDag.Name = "TxtAantalDag";
            this.TxtAantalDag.Size = new System.Drawing.Size(100, 21);
            this.TxtAantalDag.TabIndex = 11;
            // 
            // TxtPersonen
            // 
            this.TxtPersonen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPersonen.Location = new System.Drawing.Point(151, 177);
            this.TxtPersonen.Name = "TxtPersonen";
            this.TxtPersonen.Size = new System.Drawing.Size(100, 21);
            this.TxtPersonen.TabIndex = 12;
            // 
            // TxtKorting
            // 
            this.TxtKorting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKorting.Location = new System.Drawing.Point(151, 207);
            this.TxtKorting.Name = "TxtKorting";
            this.TxtKorting.Size = new System.Drawing.Size(100, 21);
            this.TxtKorting.TabIndex = 13;
            // 
            // LblOpties
            // 
            this.LblOpties.AutoSize = true;
            this.LblOpties.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOpties.Location = new System.Drawing.Point(257, 63);
            this.LblOpties.Name = "LblOpties";
            this.LblOpties.Size = new System.Drawing.Size(128, 45);
            this.LblOpties.TabIndex = 14;
            this.LblOpties.Text = "1=Charter\r\n2=Standaard lijnvlucht\r\n3=Bussinessclass\r\n";
            this.LblOpties.Visible = false;
            // 
            // BtnBerekenen
            // 
            this.BtnBerekenen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBerekenen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBerekenen.Location = new System.Drawing.Point(257, 145);
            this.BtnBerekenen.Name = "BtnBerekenen";
            this.BtnBerekenen.Size = new System.Drawing.Size(75, 23);
            this.BtnBerekenen.TabIndex = 15;
            this.BtnBerekenen.Text = "&Bereken";
            this.BtnBerekenen.UseVisualStyleBackColor = true;
            this.BtnBerekenen.Click += new System.EventHandler(this.BtnBerekenen_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(257, 175);
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
            this.BtnSluiten.Location = new System.Drawing.Point(257, 205);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 23);
            this.BtnSluiten.TabIndex = 17;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(29, 249);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(356, 186);
            this.TxtResultaat.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 457);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBerekenen);
            this.Controls.Add(this.LblOpties);
            this.Controls.Add(this.TxtKorting);
            this.Controls.Add(this.TxtPersonen);
            this.Controls.Add(this.TxtAantalDag);
            this.Controls.Add(this.TxtBasisDag);
            this.Controls.Add(this.TxtKlasse);
            this.Controls.Add(this.TxtBasisVlucht);
            this.Controls.Add(this.TxtBestemming);
            this.Controls.Add(this.LblKorting);
            this.Controls.Add(this.LblPersonen);
            this.Controls.Add(this.LblAantalDagen);
            this.Controls.Add(this.LblBasisDag);
            this.Controls.Add(this.LblKlasse);
            this.Controls.Add(this.LblVlucht);
            this.Controls.Add(this.LblBestemming);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblBestemming;
        private Label LblVlucht;
        private Label LblKlasse;
        private Label LblBasisDag;
        private Label LblAantalDagen;
        private Label LblPersonen;
        private Label LblKorting;
        private TextBox TxtBestemming;
        private TextBox TxtBasisVlucht;
        private TextBox TxtKlasse;
        private TextBox TxtBasisDag;
        private TextBox TxtAantalDag;
        private TextBox TxtPersonen;
        private TextBox TxtKorting;
        private Label LblOpties;
        private Button BtnBerekenen;
        private Button BtnWissen;
        private Button BtnSluiten;
        private TextBox TxtResultaat;
    }
}