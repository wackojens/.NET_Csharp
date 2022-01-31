namespace Opdracht16_Machtsverheffing_JC
{
    partial class FrmMachtsverheffing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMachtsverheffing));
            this.LblGetal = new System.Windows.Forms.Label();
            this.TxtGetal = new System.Windows.Forms.TextBox();
            this.LblResultaat = new System.Windows.Forms.Label();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblGetal
            // 
            this.LblGetal.AutoSize = true;
            this.LblGetal.Location = new System.Drawing.Point(20, 50);
            this.LblGetal.Name = "LblGetal";
            this.LblGetal.Size = new System.Drawing.Size(38, 16);
            this.LblGetal.TabIndex = 0;
            this.LblGetal.Text = "Getal";
            // 
            // TxtGetal
            // 
            this.TxtGetal.Location = new System.Drawing.Point(20, 75);
            this.TxtGetal.Name = "TxtGetal";
            this.TxtGetal.Size = new System.Drawing.Size(70, 22);
            this.TxtGetal.TabIndex = 1;
            // 
            // LblResultaat
            // 
            this.LblResultaat.AutoSize = true;
            this.LblResultaat.Location = new System.Drawing.Point(20, 150);
            this.LblResultaat.Name = "LblResultaat";
            this.LblResultaat.Size = new System.Drawing.Size(62, 16);
            this.LblResultaat.TabIndex = 2;
            this.LblResultaat.Text = "Resultaat";
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Location = new System.Drawing.Point(20, 175);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(288, 205);
            this.TxtResultaat.TabIndex = 3;
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Location = new System.Drawing.Point(335, 275);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 25);
            this.BtnBereken.TabIndex = 4;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Location = new System.Drawing.Point(335, 315);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 25);
            this.BtnWissen.TabIndex = 5;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(335, 355);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 25);
            this.BtnSluiten.TabIndex = 6;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmMachtsverheffing
            // 
            this.AcceptButton = this.BtnBereken;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 404);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.LblResultaat);
            this.Controls.Add(this.TxtGetal);
            this.Controls.Add(this.LblGetal);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMachtsverheffing";
            this.Text = "Machtsverheffing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblGetal;
        private TextBox TxtGetal;
        private Label LblResultaat;
        private TextBox TxtResultaat;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}