namespace Opdracht25_Sparen_JC
{
    partial class FrmSparen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSparen));
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblSpaarbedrag = new System.Windows.Forms.Label();
            this.TxtSpaarbedrag = new System.Windows.Forms.TextBox();
            this.LblVerhoging = new System.Windows.Forms.Label();
            this.TxtVerhoging = new System.Windows.Forms.TextBox();
            this.LblWeekgeld = new System.Windows.Forms.Label();
            this.TxtWeekgeld = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBereken
            // 
            this.BtnBereken.Location = new System.Drawing.Point(491, 126);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(100, 35);
            this.BtnBereken.TabIndex = 0;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Location = new System.Drawing.Point(491, 167);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(100, 35);
            this.BtnWissen.TabIndex = 1;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Location = new System.Drawing.Point(491, 208);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(100, 35);
            this.BtnSluiten.TabIndex = 2;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblSpaarbedrag);
            this.panel1.Controls.Add(this.TxtSpaarbedrag);
            this.panel1.Controls.Add(this.LblVerhoging);
            this.panel1.Controls.Add(this.TxtVerhoging);
            this.panel1.Controls.Add(this.LblWeekgeld);
            this.panel1.Controls.Add(this.TxtWeekgeld);
            this.panel1.Location = new System.Drawing.Point(12, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 121);
            this.panel1.TabIndex = 3;
            // 
            // LblSpaarbedrag
            // 
            this.LblSpaarbedrag.AutoSize = true;
            this.LblSpaarbedrag.Location = new System.Drawing.Point(39, 81);
            this.LblSpaarbedrag.Name = "LblSpaarbedrag";
            this.LblSpaarbedrag.Size = new System.Drawing.Size(144, 16);
            this.LblSpaarbedrag.TabIndex = 7;
            this.LblSpaarbedrag.Text = "Gewenste spaarbedrag:";
            // 
            // TxtSpaarbedrag
            // 
            this.TxtSpaarbedrag.Location = new System.Drawing.Point(200, 78);
            this.TxtSpaarbedrag.Name = "TxtSpaarbedrag";
            this.TxtSpaarbedrag.Size = new System.Drawing.Size(100, 22);
            this.TxtSpaarbedrag.TabIndex = 2;
            // 
            // LblVerhoging
            // 
            this.LblVerhoging.AutoSize = true;
            this.LblVerhoging.Location = new System.Drawing.Point(50, 50);
            this.LblVerhoging.Name = "LblVerhoging";
            this.LblVerhoging.Size = new System.Drawing.Size(133, 16);
            this.LblVerhoging.TabIndex = 6;
            this.LblVerhoging.Text = "Wekelijkse verhoging:";
            // 
            // TxtVerhoging
            // 
            this.TxtVerhoging.Location = new System.Drawing.Point(200, 47);
            this.TxtVerhoging.Name = "TxtVerhoging";
            this.TxtVerhoging.Size = new System.Drawing.Size(100, 22);
            this.TxtVerhoging.TabIndex = 1;
            // 
            // LblWeekgeld
            // 
            this.LblWeekgeld.AutoSize = true;
            this.LblWeekgeld.Location = new System.Drawing.Point(114, 19);
            this.LblWeekgeld.Name = "LblWeekgeld";
            this.LblWeekgeld.Size = new System.Drawing.Size(69, 16);
            this.LblWeekgeld.TabIndex = 5;
            this.LblWeekgeld.Text = "Weekgeld:";
            // 
            // TxtWeekgeld
            // 
            this.TxtWeekgeld.Location = new System.Drawing.Point(200, 16);
            this.TxtWeekgeld.Name = "TxtWeekgeld";
            this.TxtWeekgeld.Size = new System.Drawing.Size(100, 22);
            this.TxtWeekgeld.TabIndex = 0;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Location = new System.Drawing.Point(12, 451);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(318, 135);
            this.TxtResultaat.TabIndex = 4;
            // 
            // FrmSparen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Opdracht25_Sparen_JC.Properties.Resources.piggy2;
            this.ClientSize = new System.Drawing.Size(618, 612);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSparen";
            this.Text = "Sparen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
        private Panel panel1;
        private Label LblSpaarbedrag;
        private TextBox TxtSpaarbedrag;
        private Label LblVerhoging;
        private TextBox TxtVerhoging;
        private Label LblWeekgeld;
        private TextBox TxtWeekgeld;
        private TextBox TxtResultaat;
    }
}