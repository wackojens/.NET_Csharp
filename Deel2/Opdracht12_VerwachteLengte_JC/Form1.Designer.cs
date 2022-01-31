namespace Opdracht12_VerwachteLengte_JC
{
    partial class FrmVerwLeng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerwLeng));
            this.RadJongen = new System.Windows.Forms.RadioButton();
            this.RadMeisje = new System.Windows.Forms.RadioButton();
            this.GbxGeslacht = new System.Windows.Forms.GroupBox();
            this.LblVader = new System.Windows.Forms.Label();
            this.LblMoeder = new System.Windows.Forms.Label();
            this.LblVerwachtJongen = new System.Windows.Forms.Label();
            this.LblVerwachtMeisje = new System.Windows.Forms.Label();
            this.TxtVader = new System.Windows.Forms.TextBox();
            this.TxtMoeder = new System.Windows.Forms.TextBox();
            this.TxtVerJongen = new System.Windows.Forms.TextBox();
            this.TxtVerMeisje = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.GbxGeslacht.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadJongen
            // 
            this.RadJongen.AutoSize = true;
            this.RadJongen.Location = new System.Drawing.Point(25, 37);
            this.RadJongen.Name = "RadJongen";
            this.RadJongen.Size = new System.Drawing.Size(66, 20);
            this.RadJongen.TabIndex = 0;
            this.RadJongen.TabStop = true;
            this.RadJongen.Text = "Jongen";
            this.RadJongen.UseVisualStyleBackColor = true;
            this.RadJongen.CheckedChanged += new System.EventHandler(this.RadJongen_CheckedChanged);
            // 
            // RadMeisje
            // 
            this.RadMeisje.AutoSize = true;
            this.RadMeisje.Location = new System.Drawing.Point(117, 37);
            this.RadMeisje.Name = "RadMeisje";
            this.RadMeisje.Size = new System.Drawing.Size(63, 20);
            this.RadMeisje.TabIndex = 1;
            this.RadMeisje.TabStop = true;
            this.RadMeisje.Text = "Meisje";
            this.RadMeisje.UseVisualStyleBackColor = true;
            this.RadMeisje.CheckedChanged += new System.EventHandler(this.RadMeisje_CheckedChanged);
            // 
            // GbxGeslacht
            // 
            this.GbxGeslacht.Controls.Add(this.RadMeisje);
            this.GbxGeslacht.Controls.Add(this.RadJongen);
            this.GbxGeslacht.Location = new System.Drawing.Point(118, 22);
            this.GbxGeslacht.Name = "GbxGeslacht";
            this.GbxGeslacht.Size = new System.Drawing.Size(200, 63);
            this.GbxGeslacht.TabIndex = 3;
            this.GbxGeslacht.TabStop = false;
            this.GbxGeslacht.Text = "Geslacht";
            // 
            // LblVader
            // 
            this.LblVader.AutoSize = true;
            this.LblVader.Location = new System.Drawing.Point(118, 113);
            this.LblVader.Name = "LblVader";
            this.LblVader.Size = new System.Drawing.Size(84, 16);
            this.LblVader.TabIndex = 4;
            this.LblVader.Text = "Lengte vader:";
            // 
            // LblMoeder
            // 
            this.LblMoeder.AutoSize = true;
            this.LblMoeder.Location = new System.Drawing.Point(105, 139);
            this.LblMoeder.Name = "LblMoeder";
            this.LblMoeder.Size = new System.Drawing.Size(97, 16);
            this.LblMoeder.TabIndex = 5;
            this.LblMoeder.Text = "Lengte moeder:";
            // 
            // LblVerwachtJongen
            // 
            this.LblVerwachtJongen.AutoSize = true;
            this.LblVerwachtJongen.Location = new System.Drawing.Point(27, 196);
            this.LblVerwachtJongen.Name = "LblVerwachtJongen";
            this.LblVerwachtJongen.Size = new System.Drawing.Size(175, 16);
            this.LblVerwachtJongen.TabIndex = 6;
            this.LblVerwachtJongen.Text = "Verwachte lengte van jongen:";
            // 
            // LblVerwachtMeisje
            // 
            this.LblVerwachtMeisje.AutoSize = true;
            this.LblVerwachtMeisje.Location = new System.Drawing.Point(27, 225);
            this.LblVerwachtMeisje.Name = "LblVerwachtMeisje";
            this.LblVerwachtMeisje.Size = new System.Drawing.Size(175, 16);
            this.LblVerwachtMeisje.TabIndex = 7;
            this.LblVerwachtMeisje.Text = "Verwachte lengte van meisje:";
            // 
            // TxtVader
            // 
            this.TxtVader.Location = new System.Drawing.Point(218, 110);
            this.TxtVader.Name = "TxtVader";
            this.TxtVader.Size = new System.Drawing.Size(100, 22);
            this.TxtVader.TabIndex = 8;
            // 
            // TxtMoeder
            // 
            this.TxtMoeder.Location = new System.Drawing.Point(218, 136);
            this.TxtMoeder.Name = "TxtMoeder";
            this.TxtMoeder.Size = new System.Drawing.Size(100, 22);
            this.TxtMoeder.TabIndex = 9;
            // 
            // TxtVerJongen
            // 
            this.TxtVerJongen.Location = new System.Drawing.Point(218, 193);
            this.TxtVerJongen.Name = "TxtVerJongen";
            this.TxtVerJongen.Size = new System.Drawing.Size(100, 22);
            this.TxtVerJongen.TabIndex = 10;
            // 
            // TxtVerMeisje
            // 
            this.TxtVerMeisje.Location = new System.Drawing.Point(218, 222);
            this.TxtVerMeisje.Name = "TxtVerMeisje";
            this.TxtVerMeisje.Size = new System.Drawing.Size(100, 22);
            this.TxtVerMeisje.TabIndex = 11;
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Location = new System.Drawing.Point(356, 176);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 23);
            this.BtnBereken.TabIndex = 12;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(356, 218);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 23);
            this.BtnSluiten.TabIndex = 13;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmVerwLeng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 265);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtVerMeisje);
            this.Controls.Add(this.TxtVerJongen);
            this.Controls.Add(this.TxtMoeder);
            this.Controls.Add(this.TxtVader);
            this.Controls.Add(this.LblVerwachtMeisje);
            this.Controls.Add(this.LblVerwachtJongen);
            this.Controls.Add(this.LblMoeder);
            this.Controls.Add(this.LblVader);
            this.Controls.Add(this.GbxGeslacht);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVerwLeng";
            this.Text = "Verwachte lengte";
            this.GbxGeslacht.ResumeLayout(false);
            this.GbxGeslacht.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton RadJongen;
        private RadioButton RadMeisje;
        private GroupBox GbxGeslacht;
        private Label LblVader;
        private Label LblMoeder;
        private Label LblVerwachtJongen;
        private Label LblVerwachtMeisje;
        private TextBox TxtVader;
        private TextBox TxtMoeder;
        private TextBox TxtVerJongen;
        private TextBox TxtVerMeisje;
        private Button BtnBereken;
        private Button BtnSluiten;
    }
}