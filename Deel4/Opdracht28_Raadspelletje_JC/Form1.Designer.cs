namespace Opdracht28_Raadspelletje_JC
{
    partial class FrmRaadspel
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
            this.LblUitleg = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUitleg
            // 
            this.LblUitleg.AutoSize = true;
            this.LblUitleg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUitleg.Location = new System.Drawing.Point(39, 54);
            this.LblUitleg.Name = "LblUitleg";
            this.LblUitleg.Size = new System.Drawing.Size(460, 24);
            this.LblUitleg.TabIndex = 0;
            this.LblUitleg.Text = "Raad zo snel mogelijk een getal tussen 0 en 100";
            // 
            // BtnStart
            // 
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStart.Location = new System.Drawing.Point(228, 131);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "&Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(228, 178);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 23);
            this.BtnSluiten.TabIndex = 2;
            this.BtnSluiten.Text = "&Afsluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmRaadspel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 240);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblUitleg);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmRaadspel";
            this.Text = "Raadspel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblUitleg;
        private Button BtnStart;
        private Button BtnSluiten;
    }
}