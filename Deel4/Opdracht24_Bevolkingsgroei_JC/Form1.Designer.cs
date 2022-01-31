namespace Opdracht24_Bevolkingsgroei_JC
{
    partial class FrmBevolkingsgroei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBevolkingsgroei));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtGroeiPercent = new System.Windows.Forms.TextBox();
            this.LblBevolking = new System.Windows.Forms.Label();
            this.LblLand = new System.Windows.Forms.Label();
            this.TxtBevolking = new System.Windows.Forms.TextBox();
            this.LblGroeipercent = new System.Windows.Forms.Label();
            this.TxtLand = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtGroeiPercent);
            this.panel1.Controls.Add(this.LblBevolking);
            this.panel1.Controls.Add(this.LblLand);
            this.panel1.Controls.Add(this.TxtBevolking);
            this.panel1.Controls.Add(this.LblGroeipercent);
            this.panel1.Controls.Add(this.TxtLand);
            this.panel1.Location = new System.Drawing.Point(30, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 148);
            this.panel1.TabIndex = 0;
            // 
            // TxtGroeiPercent
            // 
            this.TxtGroeiPercent.Location = new System.Drawing.Point(172, 96);
            this.TxtGroeiPercent.Name = "TxtGroeiPercent";
            this.TxtGroeiPercent.Size = new System.Drawing.Size(138, 22);
            this.TxtGroeiPercent.TabIndex = 5;
            // 
            // LblBevolking
            // 
            this.LblBevolking.AutoSize = true;
            this.LblBevolking.Location = new System.Drawing.Point(3, 60);
            this.LblBevolking.Name = "LblBevolking";
            this.LblBevolking.Size = new System.Drawing.Size(153, 16);
            this.LblBevolking.TabIndex = 1;
            this.LblBevolking.Text = "Huidige bevolkingsaantal:";
            // 
            // LblLand
            // 
            this.LblLand.AutoSize = true;
            this.LblLand.Location = new System.Drawing.Point(117, 23);
            this.LblLand.Name = "LblLand";
            this.LblLand.Size = new System.Drawing.Size(39, 16);
            this.LblLand.TabIndex = 0;
            this.LblLand.Text = "Land:";
            // 
            // TxtBevolking
            // 
            this.TxtBevolking.Location = new System.Drawing.Point(172, 57);
            this.TxtBevolking.Name = "TxtBevolking";
            this.TxtBevolking.Size = new System.Drawing.Size(138, 22);
            this.TxtBevolking.TabIndex = 4;
            // 
            // LblGroeipercent
            // 
            this.LblGroeipercent.AutoSize = true;
            this.LblGroeipercent.Location = new System.Drawing.Point(50, 99);
            this.LblGroeipercent.Name = "LblGroeipercent";
            this.LblGroeipercent.Size = new System.Drawing.Size(106, 16);
            this.LblGroeipercent.TabIndex = 2;
            this.LblGroeipercent.Text = "Groeipercentage:";
            // 
            // TxtLand
            // 
            this.TxtLand.Location = new System.Drawing.Point(172, 20);
            this.TxtLand.Name = "TxtLand";
            this.TxtLand.Size = new System.Drawing.Size(138, 22);
            this.TxtLand.TabIndex = 3;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Location = new System.Drawing.Point(30, 204);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(325, 137);
            this.TxtResultaat.TabIndex = 1;
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Location = new System.Drawing.Point(374, 241);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 23);
            this.BtnBereken.TabIndex = 2;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Location = new System.Drawing.Point(374, 280);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 23);
            this.BtnWissen.TabIndex = 3;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(374, 318);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 23);
            this.BtnSluiten.TabIndex = 4;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmBevolkingsgroei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 366);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBevolkingsgroei";
            this.Text = "Berekening bevolkingsverdubbeling";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox TxtGroeiPercent;
        private TextBox TxtBevolking;
        private TextBox TxtLand;
        private Label LblGroeipercent;
        private Label LblBevolking;
        private Label LblLand;
        private TextBox TxtResultaat;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}