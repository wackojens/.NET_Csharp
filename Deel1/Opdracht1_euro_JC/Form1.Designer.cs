namespace Opdracht1_euro_JC
{
    partial class FrmEuroToBEF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEuroToBEF));
            this.LblEuro = new System.Windows.Forms.Label();
            this.LblBEF = new System.Windows.Forms.Label();
            this.TxtEuro = new System.Windows.Forms.TextBox();
            this.TxtBEF = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEuro
            // 
            this.LblEuro.AutoSize = true;
            this.LblEuro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEuro.Location = new System.Drawing.Point(38, 50);
            this.LblEuro.Name = "LblEuro";
            this.LblEuro.Size = new System.Drawing.Size(93, 15);
            this.LblEuro.TabIndex = 0;
            this.LblEuro.Text = "Bedrag in euro:";
            // 
            // LblBEF
            // 
            this.LblBEF.AutoSize = true;
            this.LblBEF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBEF.Location = new System.Drawing.Point(38, 97);
            this.LblBEF.Name = "LblBEF";
            this.LblBEF.Size = new System.Drawing.Size(88, 15);
            this.LblBEF.TabIndex = 1;
            this.LblBEF.Text = "Bedrag in BEF:";
            // 
            // TxtEuro
            // 
            this.TxtEuro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtEuro.Location = new System.Drawing.Point(131, 42);
            this.TxtEuro.Name = "TxtEuro";
            this.TxtEuro.Size = new System.Drawing.Size(100, 21);
            this.TxtEuro.TabIndex = 2;
            this.TxtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtBEF
            // 
            this.TxtBEF.Enabled = false;
            this.TxtBEF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBEF.Location = new System.Drawing.Point(131, 89);
            this.TxtBEF.Name = "TxtBEF";
            this.TxtBEF.Size = new System.Drawing.Size(100, 21);
            this.TxtBEF.TabIndex = 3;
            this.TxtBEF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBereken
            // 
            this.BtnBereken.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(263, 41);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 23);
            this.BtnBereken.TabIndex = 4;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(263, 89);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 23);
            this.BtnWissen.TabIndex = 5;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // FrmEuroToBEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtBEF);
            this.Controls.Add(this.TxtEuro);
            this.Controls.Add(this.LblBEF);
            this.Controls.Add(this.LblEuro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEuroToBEF";
            this.Text = "Omzetting van euro naar BEF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblEuro;
        private Label LblBEF;
        private TextBox TxtEuro;
        private TextBox TxtBEF;
        private Button BtnBereken;
        private Button BtnWissen;
    }
}