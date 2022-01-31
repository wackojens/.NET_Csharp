namespace Opdracht22_MeetkundigFiguur_JC
{
    partial class FrmMeetkundigFiguur
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
            this.BtnVierkantVol = new System.Windows.Forms.Button();
            this.BtnVierkantRand = new System.Windows.Forms.Button();
            this.BtnDriehoek = new System.Windows.Forms.Button();
            this.BtnRuit = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.TxtGrootte = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.LblGrootte = new System.Windows.Forms.Label();
            this.LblFiguur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVierkantVol
            // 
            this.BtnVierkantVol.Location = new System.Drawing.Point(168, 62);
            this.BtnVierkantVol.Name = "BtnVierkantVol";
            this.BtnVierkantVol.Size = new System.Drawing.Size(100, 25);
            this.BtnVierkantVol.TabIndex = 0;
            this.BtnVierkantVol.Text = "&Vol vierkant";
            this.BtnVierkantVol.UseVisualStyleBackColor = true;
            this.BtnVierkantVol.Click += new System.EventHandler(this.BtnVierkantVol_Click);
            // 
            // BtnVierkantRand
            // 
            this.BtnVierkantRand.Location = new System.Drawing.Point(168, 101);
            this.BtnVierkantRand.Name = "BtnVierkantRand";
            this.BtnVierkantRand.Size = new System.Drawing.Size(100, 25);
            this.BtnVierkantRand.TabIndex = 1;
            this.BtnVierkantRand.Text = "&Rand vierkant";
            this.BtnVierkantRand.UseVisualStyleBackColor = true;
            this.BtnVierkantRand.Click += new System.EventHandler(this.BtnVierkantRand_Click);
            // 
            // BtnDriehoek
            // 
            this.BtnDriehoek.Location = new System.Drawing.Point(168, 141);
            this.BtnDriehoek.Name = "BtnDriehoek";
            this.BtnDriehoek.Size = new System.Drawing.Size(100, 25);
            this.BtnDriehoek.TabIndex = 2;
            this.BtnDriehoek.Text = "&Driehoek";
            this.BtnDriehoek.UseVisualStyleBackColor = true;
            this.BtnDriehoek.Click += new System.EventHandler(this.BtnDriehoek_Click);
            // 
            // BtnRuit
            // 
            this.BtnRuit.Location = new System.Drawing.Point(299, 62);
            this.BtnRuit.Name = "BtnRuit";
            this.BtnRuit.Size = new System.Drawing.Size(100, 25);
            this.BtnRuit.TabIndex = 3;
            this.BtnRuit.Text = "R&uit";
            this.BtnRuit.UseVisualStyleBackColor = true;
            this.BtnRuit.Click += new System.EventHandler(this.BtnRuit_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Location = new System.Drawing.Point(299, 101);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(100, 25);
            this.BtnWissen.TabIndex = 4;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Location = new System.Drawing.Point(299, 141);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(100, 25);
            this.BtnSluiten.TabIndex = 5;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // TxtGrootte
            // 
            this.TxtGrootte.Location = new System.Drawing.Point(41, 62);
            this.TxtGrootte.Name = "TxtGrootte";
            this.TxtGrootte.Size = new System.Drawing.Size(51, 22);
            this.TxtGrootte.TabIndex = 6;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(41, 210);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResultaat.Size = new System.Drawing.Size(358, 361);
            this.TxtResultaat.TabIndex = 7;
            // 
            // LblGrootte
            // 
            this.LblGrootte.AutoSize = true;
            this.LblGrootte.Location = new System.Drawing.Point(41, 43);
            this.LblGrootte.Name = "LblGrootte";
            this.LblGrootte.Size = new System.Drawing.Size(85, 16);
            this.LblGrootte.TabIndex = 8;
            this.LblGrootte.Text = "Grootte figuur";
            // 
            // LblFiguur
            // 
            this.LblFiguur.AutoSize = true;
            this.LblFiguur.Location = new System.Drawing.Point(41, 191);
            this.LblFiguur.Name = "LblFiguur";
            this.LblFiguur.Size = new System.Drawing.Size(43, 16);
            this.LblFiguur.TabIndex = 9;
            this.LblFiguur.Text = "Figuur";
            // 
            // FrmMeetkundigFiguur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 607);
            this.Controls.Add(this.LblFiguur);
            this.Controls.Add(this.LblGrootte);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.TxtGrootte);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnRuit);
            this.Controls.Add(this.BtnDriehoek);
            this.Controls.Add(this.BtnVierkantRand);
            this.Controls.Add(this.BtnVierkantVol);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmMeetkundigFiguur";
            this.Text = "Tekenen van een figuur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnVierkantVol;
        private Button BtnVierkantRand;
        private Button BtnDriehoek;
        private Button BtnRuit;
        private Button BtnWissen;
        private Button BtnSluiten;
        private TextBox TxtGrootte;
        private TextBox TxtResultaat;
        private Label LblGrootte;
        private Label LblFiguur;
    }
}