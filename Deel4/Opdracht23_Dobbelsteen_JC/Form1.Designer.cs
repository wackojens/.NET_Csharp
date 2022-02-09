namespace Opdracht23_Dobbelsteen_JC
{
    partial class FrmDobbelsteen
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnOpnieuw = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStart.Location = new System.Drawing.Point(360, 66);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 25);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "&Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnOpnieuw
            // 
            this.BtnOpnieuw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOpnieuw.Location = new System.Drawing.Point(360, 123);
            this.BtnOpnieuw.Name = "BtnOpnieuw";
            this.BtnOpnieuw.Size = new System.Drawing.Size(75, 25);
            this.BtnOpnieuw.TabIndex = 1;
            this.BtnOpnieuw.Text = "&Opnieuw";
            this.BtnOpnieuw.UseVisualStyleBackColor = true;
            this.BtnOpnieuw.Click += new System.EventHandler(this.BtnOpnieuw_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(360, 288);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 25);
            this.BtnSluiten.TabIndex = 2;
            this.BtnSluiten.Text = "S&luiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Location = new System.Drawing.Point(33, 66);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResultaat.Size = new System.Drawing.Size(250, 246);
            this.TxtResultaat.TabIndex = 3;
            // 
            // FrmDobbelsteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 382);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnOpnieuw);
            this.Controls.Add(this.BtnStart);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmDobbelsteen";
            this.Text = "Dobbelsteenworpen tot gooien van 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnStart;
        private Button BtnOpnieuw;
        private Button BtnSluiten;
        private TextBox TxtResultaat;
    }
}