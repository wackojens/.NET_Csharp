namespace Opdracht27_Talstelsel_JC
{
    partial class FrmTalstelsel
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
            this.LblHexa = new System.Windows.Forms.Label();
            this.LblDeci = new System.Windows.Forms.Label();
            this.TxtHexa = new System.Windows.Forms.TextBox();
            this.TxtDeci = new System.Windows.Forms.TextBox();
            this.BtnZetOm = new System.Windows.Forms.Button();
            this.BtnOpnieuw = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHexa
            // 
            this.LblHexa.AutoSize = true;
            this.LblHexa.Location = new System.Drawing.Point(37, 35);
            this.LblHexa.Name = "LblHexa";
            this.LblHexa.Size = new System.Drawing.Size(93, 32);
            this.LblHexa.TabIndex = 0;
            this.LblHexa.Text = "Hexadecimale \r\nwaarde";
            // 
            // LblDeci
            // 
            this.LblDeci.AutoSize = true;
            this.LblDeci.Location = new System.Drawing.Point(191, 35);
            this.LblDeci.Name = "LblDeci";
            this.LblDeci.Size = new System.Drawing.Size(61, 32);
            this.LblDeci.TabIndex = 1;
            this.LblDeci.Text = "Decimale\r\nwaarde";
            // 
            // TxtHexa
            // 
            this.TxtHexa.Location = new System.Drawing.Point(30, 88);
            this.TxtHexa.Name = "TxtHexa";
            this.TxtHexa.Size = new System.Drawing.Size(100, 22);
            this.TxtHexa.TabIndex = 2;
            this.TxtHexa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHexa_KeyPress);
            // 
            // TxtDeci
            // 
            this.TxtDeci.Location = new System.Drawing.Point(152, 88);
            this.TxtDeci.Name = "TxtDeci";
            this.TxtDeci.ReadOnly = true;
            this.TxtDeci.Size = new System.Drawing.Size(100, 22);
            this.TxtDeci.TabIndex = 3;
            this.TxtDeci.TabStop = false;
            // 
            // BtnZetOm
            // 
            this.BtnZetOm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnZetOm.Location = new System.Drawing.Point(307, 35);
            this.BtnZetOm.Name = "BtnZetOm";
            this.BtnZetOm.Size = new System.Drawing.Size(75, 23);
            this.BtnZetOm.TabIndex = 4;
            this.BtnZetOm.Text = "&Zet om";
            this.BtnZetOm.UseVisualStyleBackColor = true;
            this.BtnZetOm.Click += new System.EventHandler(this.BtnZetOm_Click);
            // 
            // BtnOpnieuw
            // 
            this.BtnOpnieuw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOpnieuw.Location = new System.Drawing.Point(307, 64);
            this.BtnOpnieuw.Name = "BtnOpnieuw";
            this.BtnOpnieuw.Size = new System.Drawing.Size(75, 23);
            this.BtnOpnieuw.TabIndex = 5;
            this.BtnOpnieuw.Text = "&Opnieuw";
            this.BtnOpnieuw.UseVisualStyleBackColor = true;
            this.BtnOpnieuw.Click += new System.EventHandler(this.BtnOpnieuw_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(307, 93);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 23);
            this.BtnSluiten.TabIndex = 6;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmTalstelsel
            // 
            this.AcceptButton = this.BtnZetOm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 150);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnOpnieuw);
            this.Controls.Add(this.BtnZetOm);
            this.Controls.Add(this.TxtDeci);
            this.Controls.Add(this.TxtHexa);
            this.Controls.Add(this.LblDeci);
            this.Controls.Add(this.LblHexa);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmTalstelsel";
            this.Text = "Het hexadecimale talstelsel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblHexa;
        private Label LblDeci;
        private TextBox TxtHexa;
        private TextBox TxtDeci;
        private Button BtnZetOm;
        private Button BtnOpnieuw;
        private Button BtnSluiten;
    }
}