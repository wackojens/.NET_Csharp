namespace Opdracht43_ArraySommen_JC
{
    partial class FrmArraySom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArraySom));
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnSom = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(46, 41);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.ReadOnly = true;
            this.TxtResultaat.Size = new System.Drawing.Size(136, 192);
            this.TxtResultaat.TabIndex = 0;
            // 
            // BtnSom
            // 
            this.BtnSom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSom.Location = new System.Drawing.Point(75, 255);
            this.BtnSom.Name = "BtnSom";
            this.BtnSom.Size = new System.Drawing.Size(75, 25);
            this.BtnSom.TabIndex = 1;
            this.BtnSom.Text = "&Som";
            this.BtnSom.UseVisualStyleBackColor = true;
            this.BtnSom.Click += new System.EventHandler(this.BtnSom_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(75, 300);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 25);
            this.BtnSluiten.TabIndex = 2;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmArraySom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 366);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnSom);
            this.Controls.Add(this.TxtResultaat);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArraySom";
            this.Text = "Som van arrays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtResultaat;
        private Button BtnSom;
        private Button BtnSluiten;
    }
}