namespace Opdracht3_Rekenmachine_JC
{
    partial class FrmRekenmachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRekenmachine));
            this.LblGetal1 = new System.Windows.Forms.Label();
            this.LblGetal2 = new System.Windows.Forms.Label();
            this.LblResultaat = new System.Windows.Forms.Label();
            this.TxtGetal1 = new System.Windows.Forms.TextBox();
            this.TxtGetal2 = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMaal = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnDelen = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblGetal1
            // 
            this.LblGetal1.AutoSize = true;
            this.LblGetal1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGetal1.Location = new System.Drawing.Point(25, 27);
            this.LblGetal1.Name = "LblGetal1";
            this.LblGetal1.Size = new System.Drawing.Size(53, 16);
            this.LblGetal1.TabIndex = 0;
            this.LblGetal1.Text = "Getal 1:";
            // 
            // LblGetal2
            // 
            this.LblGetal2.AutoSize = true;
            this.LblGetal2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGetal2.Location = new System.Drawing.Point(25, 63);
            this.LblGetal2.Name = "LblGetal2";
            this.LblGetal2.Size = new System.Drawing.Size(53, 16);
            this.LblGetal2.TabIndex = 1;
            this.LblGetal2.Text = "Getal 2:";
            // 
            // LblResultaat
            // 
            this.LblResultaat.AutoSize = true;
            this.LblResultaat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResultaat.Location = new System.Drawing.Point(25, 115);
            this.LblResultaat.Name = "LblResultaat";
            this.LblResultaat.Size = new System.Drawing.Size(66, 16);
            this.LblResultaat.TabIndex = 2;
            this.LblResultaat.Text = "Resultaat:";
            // 
            // TxtGetal1
            // 
            this.TxtGetal1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGetal1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGetal1.Location = new System.Drawing.Point(94, 21);
            this.TxtGetal1.Name = "TxtGetal1";
            this.TxtGetal1.Size = new System.Drawing.Size(100, 15);
            this.TxtGetal1.TabIndex = 3;
            this.TxtGetal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtGetal2
            // 
            this.TxtGetal2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGetal2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGetal2.Location = new System.Drawing.Point(94, 57);
            this.TxtGetal2.Name = "TxtGetal2";
            this.TxtGetal2.Size = new System.Drawing.Size(100, 15);
            this.TxtGetal2.TabIndex = 4;
            this.TxtGetal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(94, 109);
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(100, 22);
            this.TxtResultaat.TabIndex = 5;
            this.TxtResultaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPlus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPlus.Location = new System.Drawing.Point(212, 21);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(35, 23);
            this.BtnPlus.TabIndex = 6;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnMaal
            // 
            this.BtnMaal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnMaal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMaal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMaal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMaal.Location = new System.Drawing.Point(212, 79);
            this.BtnMaal.Name = "BtnMaal";
            this.BtnMaal.Size = new System.Drawing.Size(35, 23);
            this.BtnMaal.TabIndex = 8;
            this.BtnMaal.Text = "x";
            this.BtnMaal.UseVisualStyleBackColor = false;
            this.BtnMaal.Click += new System.EventHandler(this.BtnMaal_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMin.Location = new System.Drawing.Point(212, 50);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(35, 23);
            this.BtnMin.TabIndex = 7;
            this.BtnMin.Text = "-";
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnDelen
            // 
            this.BtnDelen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnDelen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDelen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelen.Location = new System.Drawing.Point(212, 108);
            this.BtnDelen.Name = "BtnDelen";
            this.BtnDelen.Size = new System.Drawing.Size(35, 23);
            this.BtnDelen.TabIndex = 9;
            this.BtnDelen.Text = ":";
            this.BtnDelen.UseVisualStyleBackColor = false;
            this.BtnDelen.Click += new System.EventHandler(this.BtnDelen_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(94, 162);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(100, 23);
            this.BtnWissen.TabIndex = 10;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = false;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // FrmRekenmachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(287, 211);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnDelen);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnMaal);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.TxtGetal2);
            this.Controls.Add(this.TxtGetal1);
            this.Controls.Add(this.LblResultaat);
            this.Controls.Add(this.LblGetal2);
            this.Controls.Add(this.LblGetal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRekenmachine";
            this.Text = "Rekenmachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblGetal1;
        private Label LblGetal2;
        private Label LblResultaat;
        private TextBox TxtGetal1;
        private TextBox TxtGetal2;
        private TextBox TxtResultaat;
        private Button BtnPlus;
        private Button BtnMaal;
        private Button BtnMin;
        private Button BtnDelen;
        private Button BtnWissen;
    }
}