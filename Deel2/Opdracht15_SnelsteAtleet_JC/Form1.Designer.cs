namespace Opdracht15_SnelsteAtleet_JC
{
    partial class FrmSnelsteAtleet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSnelsteAtleet));
            this.LblAtleet = new System.Windows.Forms.Label();
            this.LblSeconden = new System.Windows.Forms.Label();
            this.BtnNieuw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSeconden = new System.Windows.Forms.TextBox();
            this.TxtAtleet = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnSnelste = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAtleet
            // 
            this.LblAtleet.AutoSize = true;
            this.LblAtleet.Location = new System.Drawing.Point(87, 28);
            this.LblAtleet.Name = "LblAtleet";
            this.LblAtleet.Size = new System.Drawing.Size(81, 16);
            this.LblAtleet.TabIndex = 6;
            this.LblAtleet.Text = "Naam atleet:";
            // 
            // LblSeconden
            // 
            this.LblSeconden.AutoSize = true;
            this.LblSeconden.Location = new System.Drawing.Point(24, 69);
            this.LblSeconden.Name = "LblSeconden";
            this.LblSeconden.Size = new System.Drawing.Size(144, 16);
            this.LblSeconden.TabIndex = 7;
            this.LblSeconden.Text = "Totaal aantal seconden:";
            // 
            // BtnNieuw
            // 
            this.BtnNieuw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNieuw.Location = new System.Drawing.Point(352, 295);
            this.BtnNieuw.Name = "BtnNieuw";
            this.BtnNieuw.Size = new System.Drawing.Size(115, 28);
            this.BtnNieuw.TabIndex = 2;
            this.BtnNieuw.Text = "&Nieuwe ingave";
            this.BtnNieuw.UseVisualStyleBackColor = true;
            this.BtnNieuw.Click += new System.EventHandler(this.BtnNieuw_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LblAtleet);
            this.panel1.Controls.Add(this.TxtSeconden);
            this.panel1.Controls.Add(this.LblSeconden);
            this.panel1.Controls.Add(this.TxtAtleet);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 123);
            this.panel1.TabIndex = 9;
            // 
            // TxtSeconden
            // 
            this.TxtSeconden.Location = new System.Drawing.Point(195, 66);
            this.TxtSeconden.Name = "TxtSeconden";
            this.TxtSeconden.Size = new System.Drawing.Size(191, 22);
            this.TxtSeconden.TabIndex = 1;
            this.TxtSeconden.Leave += new System.EventHandler(this.TxtSeconden_Leave);
            // 
            // TxtAtleet
            // 
            this.TxtAtleet.Location = new System.Drawing.Point(195, 25);
            this.TxtAtleet.Name = "TxtAtleet";
            this.TxtAtleet.Size = new System.Drawing.Size(191, 22);
            this.TxtAtleet.TabIndex = 0;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Location = new System.Drawing.Point(12, 165);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(300, 278);
            this.TxtResultaat.TabIndex = 8;
            // 
            // BtnSnelste
            // 
            this.BtnSnelste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSnelste.Location = new System.Drawing.Point(352, 335);
            this.BtnSnelste.Name = "BtnSnelste";
            this.BtnSnelste.Size = new System.Drawing.Size(115, 28);
            this.BtnSnelste.TabIndex = 3;
            this.BtnSnelste.Text = "Snelste &atleet";
            this.BtnSnelste.UseVisualStyleBackColor = true;
            this.BtnSnelste.Click += new System.EventHandler(this.BtnSnelste_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Location = new System.Drawing.Point(352, 375);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(115, 28);
            this.BtnWissen.TabIndex = 4;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(352, 415);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(115, 28);
            this.BtnSluiten.TabIndex = 5;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmSnelsteAtleet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 480);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnSnelste);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnNieuw);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSnelsteAtleet";
            this.Text = "Snelste atleet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LblAtleet;
        private Label LblSeconden;
        private Button BtnNieuw;
        private Panel panel1;
        private TextBox TxtSeconden;
        private TextBox TxtAtleet;
        private TextBox TxtResultaat;
        private Button BtnSnelste;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}