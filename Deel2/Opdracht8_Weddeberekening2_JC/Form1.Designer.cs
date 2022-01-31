namespace Opdracht8_Weddeberekening2_JC
{
    partial class FrmWeddeberekening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeddeberekening));
            this.LblPersoneel = new System.Windows.Forms.Label();
            this.LblUurloon = new System.Windows.Forms.Label();
            this.LblAantalUren = new System.Windows.Forms.Label();
            this.TxtPersoneel = new System.Windows.Forms.TextBox();
            this.TxtUurloon = new System.Windows.Forms.TextBox();
            this.TxtAantalUren = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblPersoneel
            // 
            this.LblPersoneel.AutoSize = true;
            this.LblPersoneel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPersoneel.Location = new System.Drawing.Point(40, 32);
            this.LblPersoneel.Name = "LblPersoneel";
            this.LblPersoneel.Size = new System.Drawing.Size(89, 16);
            this.LblPersoneel.TabIndex = 0;
            this.LblPersoneel.Text = "Personeelslid:";
            // 
            // LblUurloon
            // 
            this.LblUurloon.AutoSize = true;
            this.LblUurloon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUurloon.Location = new System.Drawing.Point(74, 64);
            this.LblUurloon.Name = "LblUurloon";
            this.LblUurloon.Size = new System.Drawing.Size(55, 16);
            this.LblUurloon.TabIndex = 1;
            this.LblUurloon.Text = "Uurloon:";
            // 
            // LblAantalUren
            // 
            this.LblAantalUren.AutoSize = true;
            this.LblAantalUren.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAantalUren.Location = new System.Drawing.Point(52, 96);
            this.LblAantalUren.Name = "LblAantalUren";
            this.LblAantalUren.Size = new System.Drawing.Size(77, 16);
            this.LblAantalUren.TabIndex = 2;
            this.LblAantalUren.Text = "Aantal uren:";
            // 
            // TxtPersoneel
            // 
            this.TxtPersoneel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPersoneel.Location = new System.Drawing.Point(157, 26);
            this.TxtPersoneel.Name = "TxtPersoneel";
            this.TxtPersoneel.Size = new System.Drawing.Size(100, 22);
            this.TxtPersoneel.TabIndex = 3;
            // 
            // TxtUurloon
            // 
            this.TxtUurloon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUurloon.Location = new System.Drawing.Point(157, 58);
            this.TxtUurloon.Name = "TxtUurloon";
            this.TxtUurloon.Size = new System.Drawing.Size(100, 22);
            this.TxtUurloon.TabIndex = 4;
            // 
            // TxtAantalUren
            // 
            this.TxtAantalUren.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAantalUren.Location = new System.Drawing.Point(157, 90);
            this.TxtAantalUren.Name = "TxtAantalUren";
            this.TxtAantalUren.Size = new System.Drawing.Size(100, 22);
            this.TxtAantalUren.TabIndex = 5;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(40, 154);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(334, 161);
            this.TxtResultaat.TabIndex = 6;
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(299, 25);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 25);
            this.BtnBereken.TabIndex = 7;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(299, 57);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 25);
            this.BtnWissen.TabIndex = 8;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(299, 89);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 25);
            this.BtnSluiten.TabIndex = 9;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmWeddeberekening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 353);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.TxtAantalUren);
            this.Controls.Add(this.TxtUurloon);
            this.Controls.Add(this.TxtPersoneel);
            this.Controls.Add(this.LblAantalUren);
            this.Controls.Add(this.LblUurloon);
            this.Controls.Add(this.LblPersoneel);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWeddeberekening";
            this.Text = "Weddeberekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblPersoneel;
        private Label LblUurloon;
        private Label LblAantalUren;
        private TextBox TxtPersoneel;
        private TextBox TxtUurloon;
        private TextBox TxtAantalUren;
        private TextBox TxtResultaat;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}