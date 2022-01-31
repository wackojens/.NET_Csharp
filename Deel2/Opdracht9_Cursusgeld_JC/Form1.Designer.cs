namespace Opdracht9_Cursusgeld_JC
{
    partial class FrmCursusgeld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursusgeld));
            this.LblJaar = new System.Windows.Forms.Label();
            this.LblLesuren = new System.Windows.Forms.Label();
            this.LblCursusgeld = new System.Windows.Forms.Label();
            this.TxtJaar = new System.Windows.Forms.TextBox();
            this.TxtLesuren = new System.Windows.Forms.TextBox();
            this.TxtCursusgeld = new System.Windows.Forms.TextBox();
            this.LblNumeriek = new System.Windows.Forms.Label();
            this.LblSchrikkeljaar = new System.Windows.Forms.Label();
            this.BtnTestNum = new System.Windows.Forms.Button();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblJaar
            // 
            this.LblJaar.AutoSize = true;
            this.LblJaar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblJaar.Location = new System.Drawing.Point(85, 27);
            this.LblJaar.Name = "LblJaar";
            this.LblJaar.Size = new System.Drawing.Size(35, 16);
            this.LblJaar.TabIndex = 0;
            this.LblJaar.Text = "Jaar:";
            // 
            // LblLesuren
            // 
            this.LblLesuren.AutoSize = true;
            this.LblLesuren.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLesuren.Location = new System.Drawing.Point(26, 59);
            this.LblLesuren.Name = "LblLesuren";
            this.LblLesuren.Size = new System.Drawing.Size(94, 16);
            this.LblLesuren.TabIndex = 1;
            this.LblLesuren.Text = "Aantal lesuren:";
            // 
            // LblCursusgeld
            // 
            this.LblCursusgeld.AutoSize = true;
            this.LblCursusgeld.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCursusgeld.Location = new System.Drawing.Point(44, 91);
            this.LblCursusgeld.Name = "LblCursusgeld";
            this.LblCursusgeld.Size = new System.Drawing.Size(76, 16);
            this.LblCursusgeld.TabIndex = 2;
            this.LblCursusgeld.Text = "Cursusgeld:";
            // 
            // TxtJaar
            // 
            this.TxtJaar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtJaar.Location = new System.Drawing.Point(147, 20);
            this.TxtJaar.Name = "TxtJaar";
            this.TxtJaar.Size = new System.Drawing.Size(100, 22);
            this.TxtJaar.TabIndex = 3;
            this.TxtJaar.TextChanged += new System.EventHandler(this.TxtJaar_TextChanged);
            // 
            // TxtLesuren
            // 
            this.TxtLesuren.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLesuren.Location = new System.Drawing.Point(147, 52);
            this.TxtLesuren.Name = "TxtLesuren";
            this.TxtLesuren.Size = new System.Drawing.Size(100, 22);
            this.TxtLesuren.TabIndex = 4;
            // 
            // TxtCursusgeld
            // 
            this.TxtCursusgeld.Enabled = false;
            this.TxtCursusgeld.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCursusgeld.Location = new System.Drawing.Point(147, 84);
            this.TxtCursusgeld.Name = "TxtCursusgeld";
            this.TxtCursusgeld.Size = new System.Drawing.Size(100, 22);
            this.TxtCursusgeld.TabIndex = 5;
            // 
            // LblNumeriek
            // 
            this.LblNumeriek.AutoSize = true;
            this.LblNumeriek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNumeriek.Location = new System.Drawing.Point(274, 27);
            this.LblNumeriek.Name = "LblNumeriek";
            this.LblNumeriek.Size = new System.Drawing.Size(74, 16);
            this.LblNumeriek.TabIndex = 6;
            this.LblNumeriek.Text = "Is numeriek";
            this.LblNumeriek.Visible = false;
            // 
            // LblSchrikkeljaar
            // 
            this.LblSchrikkeljaar.AutoSize = true;
            this.LblSchrikkeljaar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSchrikkeljaar.Location = new System.Drawing.Point(274, 59);
            this.LblSchrikkeljaar.Name = "LblSchrikkeljaar";
            this.LblSchrikkeljaar.Size = new System.Drawing.Size(119, 16);
            this.LblSchrikkeljaar.TabIndex = 7;
            this.LblSchrikkeljaar.Text = "Is een schrikkeljaar";
            this.LblSchrikkeljaar.Visible = false;
            // 
            // BtnTestNum
            // 
            this.BtnTestNum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTestNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTestNum.Location = new System.Drawing.Point(25, 139);
            this.BtnTestNum.Name = "BtnTestNum";
            this.BtnTestNum.Size = new System.Drawing.Size(108, 25);
            this.BtnTestNum.TabIndex = 8;
            this.BtnTestNum.Text = "Test &Numeriek";
            this.BtnTestNum.UseVisualStyleBackColor = true;
            this.BtnTestNum.Click += new System.EventHandler(this.BtnTestNum_Click);
            // 
            // BtnBereken
            // 
            this.BtnBereken.Enabled = false;
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(150, 139);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(108, 25);
            this.BtnBereken.TabIndex = 9;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnAfsluiten
            // 
            this.BtnAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAfsluiten.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAfsluiten.Location = new System.Drawing.Point(275, 139);
            this.BtnAfsluiten.Name = "BtnAfsluiten";
            this.BtnAfsluiten.Size = new System.Drawing.Size(108, 25);
            this.BtnAfsluiten.TabIndex = 10;
            this.BtnAfsluiten.Text = "&Afsluiten";
            this.BtnAfsluiten.UseVisualStyleBackColor = true;
            this.BtnAfsluiten.Click += new System.EventHandler(this.BtnAfsluiten_Click);
            // 
            // FrmCursusgeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 196);
            this.Controls.Add(this.BtnAfsluiten);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.BtnTestNum);
            this.Controls.Add(this.LblSchrikkeljaar);
            this.Controls.Add(this.LblNumeriek);
            this.Controls.Add(this.TxtCursusgeld);
            this.Controls.Add(this.TxtLesuren);
            this.Controls.Add(this.TxtJaar);
            this.Controls.Add(this.LblCursusgeld);
            this.Controls.Add(this.LblLesuren);
            this.Controls.Add(this.LblJaar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCursusgeld";
            this.Text = "Cursusjaar - Schrikkeljaar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblJaar;
        private Label LblLesuren;
        private Label LblCursusgeld;
        private TextBox TxtJaar;
        private TextBox TxtLesuren;
        private TextBox TxtCursusgeld;
        private Label LblNumeriek;
        private Label LblSchrikkeljaar;
        private Button BtnTestNum;
        private Button BtnBereken;
        private Button BtnAfsluiten;
    }
}