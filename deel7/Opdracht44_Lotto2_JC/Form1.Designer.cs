namespace Opdracht44_Lotto2_JC
{
    partial class FrmLotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLotto));
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(29, 33);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.ReadOnly = true;
            this.TxtResultaat.Size = new System.Drawing.Size(196, 129);
            this.TxtResultaat.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStart.Location = new System.Drawing.Point(255, 33);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 25);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "&Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Location = new System.Drawing.Point(255, 86);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 25);
            this.BtnWissen.TabIndex = 2;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(255, 137);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 25);
            this.BtnSluiten.TabIndex = 3;
            this.BtnSluiten.Text = "S&luiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 206);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtResultaat);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLotto";
            this.Text = "Lotto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtResultaat;
        private Button BtnStart;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}