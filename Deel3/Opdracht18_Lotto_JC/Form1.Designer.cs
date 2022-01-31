namespace Opdracht18_Lotto_JC
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
            this.PicLotto = new System.Windows.Forms.PictureBox();
            this.LblResultaat = new System.Windows.Forms.Label();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLotto)).BeginInit();
            this.SuspendLayout();
            // 
            // PicLotto
            // 
            this.PicLotto.ErrorImage = null;
            this.PicLotto.Image = global::Opdracht18_Lotto_JC.Properties.Resources.lottoBalls;
            this.PicLotto.ImageLocation = "";
            this.PicLotto.InitialImage = null;
            this.PicLotto.Location = new System.Drawing.Point(12, 12);
            this.PicLotto.Name = "PicLotto";
            this.PicLotto.Size = new System.Drawing.Size(531, 522);
            this.PicLotto.TabIndex = 0;
            this.PicLotto.TabStop = false;
            // 
            // LblResultaat
            // 
            this.LblResultaat.AutoSize = true;
            this.LblResultaat.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResultaat.Location = new System.Drawing.Point(572, 85);
            this.LblResultaat.Name = "LblResultaat";
            this.LblResultaat.Size = new System.Drawing.Size(220, 26);
            this.LblResultaat.TabIndex = 1;
            this.LblResultaat.Text = "De 6 lotto getallen zijn:";
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.BackColor = System.Drawing.SystemColors.Control;
            this.TxtResultaat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(572, 146);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(137, 173);
            this.TxtResultaat.TabIndex = 2;
            // 
            // BtnStart
            // 
            this.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStart.Location = new System.Drawing.Point(782, 296);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 38);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "S&tart";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWissen.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(782, 340);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 38);
            this.BtnWissen.TabIndex = 4;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSluiten.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(782, 382);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 38);
            this.BtnSluiten.TabIndex = 5;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 540);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.LblResultaat);
            this.Controls.Add(this.PicLotto);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLotto";
            this.Text = "Lotto";
            ((System.ComponentModel.ISupportInitialize)(this.PicLotto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PicLotto;
        private Label LblResultaat;
        private TextBox TxtResultaat;
        private Button BtnStart;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}