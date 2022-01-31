namespace Opdracht5_Bioscoop_JC
{
    partial class FrmBioscoop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBioscoop));
            this.LblNormaal = new System.Windows.Forms.Label();
            this.LblKorting = new System.Windows.Forms.Label();
            this.LblStudent = new System.Windows.Forms.Label();
            this.TxtNormaal = new System.Windows.Forms.TextBox();
            this.TxtKorting = new System.Windows.Forms.TextBox();
            this.TxtStudent = new System.Windows.Forms.TextBox();
            this.LblPrijs = new System.Windows.Forms.Label();
            this.TxtPrijs = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNormaal
            // 
            this.LblNormaal.AutoSize = true;
            this.LblNormaal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNormaal.Location = new System.Drawing.Point(30, 22);
            this.LblNormaal.Name = "LblNormaal";
            this.LblNormaal.Size = new System.Drawing.Size(91, 16);
            this.LblNormaal.TabIndex = 0;
            this.LblNormaal.Text = "Normaal tarief:";
            // 
            // LblKorting
            // 
            this.LblKorting.AutoSize = true;
            this.LblKorting.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblKorting.Location = new System.Drawing.Point(30, 62);
            this.LblKorting.Name = "LblKorting";
            this.LblKorting.Size = new System.Drawing.Size(87, 16);
            this.LblKorting.TabIndex = 1;
            this.LblKorting.Text = "Kortingstarief:";
            // 
            // LblStudent
            // 
            this.LblStudent.AutoSize = true;
            this.LblStudent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStudent.Location = new System.Drawing.Point(30, 103);
            this.LblStudent.Name = "LblStudent";
            this.LblStudent.Size = new System.Drawing.Size(99, 16);
            this.LblStudent.TabIndex = 2;
            this.LblStudent.Text = "Studentenkaart:";
            // 
            // TxtNormaal
            // 
            this.TxtNormaal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNormaal.Location = new System.Drawing.Point(140, 16);
            this.TxtNormaal.Name = "TxtNormaal";
            this.TxtNormaal.Size = new System.Drawing.Size(100, 22);
            this.TxtNormaal.TabIndex = 3;
            this.TxtNormaal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtKorting
            // 
            this.TxtKorting.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKorting.Location = new System.Drawing.Point(140, 56);
            this.TxtKorting.Name = "TxtKorting";
            this.TxtKorting.Size = new System.Drawing.Size(100, 22);
            this.TxtKorting.TabIndex = 4;
            this.TxtKorting.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtStudent
            // 
            this.TxtStudent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStudent.Location = new System.Drawing.Point(140, 97);
            this.TxtStudent.Name = "TxtStudent";
            this.TxtStudent.Size = new System.Drawing.Size(100, 22);
            this.TxtStudent.TabIndex = 5;
            this.TxtStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblPrijs
            // 
            this.LblPrijs.AutoSize = true;
            this.LblPrijs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrijs.Location = new System.Drawing.Point(30, 143);
            this.LblPrijs.Name = "LblPrijs";
            this.LblPrijs.Size = new System.Drawing.Size(37, 16);
            this.LblPrijs.TabIndex = 6;
            this.LblPrijs.Text = "Prijs:";
            // 
            // TxtPrijs
            // 
            this.TxtPrijs.Enabled = false;
            this.TxtPrijs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrijs.Location = new System.Drawing.Point(140, 137);
            this.TxtPrijs.Name = "TxtPrijs";
            this.TxtPrijs.Size = new System.Drawing.Size(100, 22);
            this.TxtPrijs.TabIndex = 7;
            this.TxtPrijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(269, 56);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 23);
            this.BtnBereken.TabIndex = 8;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(269, 97);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 23);
            this.BtnWissen.TabIndex = 9;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnAfsluiten
            // 
            this.BtnAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAfsluiten.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAfsluiten.Location = new System.Drawing.Point(269, 137);
            this.BtnAfsluiten.Name = "BtnAfsluiten";
            this.BtnAfsluiten.Size = new System.Drawing.Size(75, 23);
            this.BtnAfsluiten.TabIndex = 10;
            this.BtnAfsluiten.Text = "&Afsluiten";
            this.BtnAfsluiten.UseVisualStyleBackColor = true;
            this.BtnAfsluiten.Click += new System.EventHandler(this.BtnAfsluiten_Click);
            // 
            // FrmBioscoop
            // 
            this.AcceptButton = this.BtnBereken;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 233);
            this.Controls.Add(this.BtnAfsluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtPrijs);
            this.Controls.Add(this.LblPrijs);
            this.Controls.Add(this.TxtStudent);
            this.Controls.Add(this.TxtKorting);
            this.Controls.Add(this.TxtNormaal);
            this.Controls.Add(this.LblStudent);
            this.Controls.Add(this.LblKorting);
            this.Controls.Add(this.LblNormaal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBioscoop";
            this.Text = "Totale ticketprijs berekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblNormaal;
        private Label LblKorting;
        private Label LblStudent;
        private TextBox TxtNormaal;
        private TextBox TxtKorting;
        private TextBox TxtStudent;
        private Label LblPrijs;
        private TextBox TxtPrijs;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnAfsluiten;
    }
}