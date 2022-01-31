namespace Opdracht6_Weddeberekening_JC
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
            this.LblPersoneel = new System.Windows.Forms.Label();
            this.LblUurloon = new System.Windows.Forms.Label();
            this.LblAantalUren = new System.Windows.Forms.Label();
            this.TxtPersoneel = new System.Windows.Forms.TextBox();
            this.TxtUurloon = new System.Windows.Forms.TextBox();
            this.TxtAantalUren = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblPersoneel
            // 
            this.LblPersoneel.AutoSize = true;
            this.LblPersoneel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPersoneel.Location = new System.Drawing.Point(37, 33);
            this.LblPersoneel.Name = "LblPersoneel";
            this.LblPersoneel.Size = new System.Drawing.Size(89, 16);
            this.LblPersoneel.TabIndex = 0;
            this.LblPersoneel.Text = "Personeelslid:";
            // 
            // LblUurloon
            // 
            this.LblUurloon.AutoSize = true;
            this.LblUurloon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUurloon.Location = new System.Drawing.Point(71, 61);
            this.LblUurloon.Name = "LblUurloon";
            this.LblUurloon.Size = new System.Drawing.Size(55, 16);
            this.LblUurloon.TabIndex = 1;
            this.LblUurloon.Text = "Uurloon:";
            // 
            // LblAantalUren
            // 
            this.LblAantalUren.AutoSize = true;
            this.LblAantalUren.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAantalUren.Location = new System.Drawing.Point(49, 94);
            this.LblAantalUren.Name = "LblAantalUren";
            this.LblAantalUren.Size = new System.Drawing.Size(77, 16);
            this.LblAantalUren.TabIndex = 2;
            this.LblAantalUren.Text = "Aantal uren:";
            // 
            // TxtPersoneel
            // 
            this.TxtPersoneel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPersoneel.Location = new System.Drawing.Point(133, 25);
            this.TxtPersoneel.Name = "TxtPersoneel";
            this.TxtPersoneel.Size = new System.Drawing.Size(100, 22);
            this.TxtPersoneel.TabIndex = 3;
            // 
            // TxtUurloon
            // 
            this.TxtUurloon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUurloon.Location = new System.Drawing.Point(133, 55);
            this.TxtUurloon.Name = "TxtUurloon";
            this.TxtUurloon.Size = new System.Drawing.Size(100, 22);
            this.TxtUurloon.TabIndex = 4;
            this.TxtUurloon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtAantalUren
            // 
            this.TxtAantalUren.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAantalUren.Location = new System.Drawing.Point(133, 88);
            this.TxtAantalUren.Name = "TxtAantalUren";
            this.TxtAantalUren.Size = new System.Drawing.Size(100, 22);
            this.TxtAantalUren.TabIndex = 5;
            this.TxtAantalUren.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(281, 25);
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
            this.BtnWissen.Location = new System.Drawing.Point(281, 55);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 23);
            this.BtnWissen.TabIndex = 7;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(281, 88);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 23);
            this.BtnSluiten.TabIndex = 8;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(37, 146);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(319, 200);
            this.TxtResultaat.TabIndex = 9;
            // 
            // FrmWeddeberekening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 397);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtAantalUren);
            this.Controls.Add(this.TxtUurloon);
            this.Controls.Add(this.TxtPersoneel);
            this.Controls.Add(this.LblAantalUren);
            this.Controls.Add(this.LblUurloon);
            this.Controls.Add(this.LblPersoneel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
        private TextBox TxtResultaat;
    }
}