namespace Opdracht4_Ondernemingsnummer_JC
{
    partial class FrmOndernemingsnummer
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
            this.BtnControlenummer = new System.Windows.Forms.Button();
            this.LblOndernemingsnummer = new System.Windows.Forms.Label();
            this.TxtOndernemingsnummer = new System.Windows.Forms.TextBox();
            this.TxtControlenummer = new System.Windows.Forms.TextBox();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.LblControlenummer = new System.Windows.Forms.Label();
            this.LblResultaat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnControlenummer
            // 
            this.BtnControlenummer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnControlenummer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnControlenummer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnControlenummer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnControlenummer.Location = new System.Drawing.Point(27, 147);
            this.BtnControlenummer.Name = "BtnControlenummer";
            this.BtnControlenummer.Size = new System.Drawing.Size(115, 23);
            this.BtnControlenummer.TabIndex = 0;
            this.BtnControlenummer.Text = "Controlenummer";
            this.BtnControlenummer.UseVisualStyleBackColor = false;
            this.BtnControlenummer.Click += new System.EventHandler(this.BtnControlenummer_Click);
            // 
            // LblOndernemingsnummer
            // 
            this.LblOndernemingsnummer.AutoSize = true;
            this.LblOndernemingsnummer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOndernemingsnummer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblOndernemingsnummer.Location = new System.Drawing.Point(27, 41);
            this.LblOndernemingsnummer.Name = "LblOndernemingsnummer";
            this.LblOndernemingsnummer.Size = new System.Drawing.Size(140, 15);
            this.LblOndernemingsnummer.TabIndex = 1;
            this.LblOndernemingsnummer.Text = "Ondernemingsnummer:";
            // 
            // TxtOndernemingsnummer
            // 
            this.TxtOndernemingsnummer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtOndernemingsnummer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtOndernemingsnummer.Location = new System.Drawing.Point(178, 41);
            this.TxtOndernemingsnummer.Name = "TxtOndernemingsnummer";
            this.TxtOndernemingsnummer.Size = new System.Drawing.Size(100, 21);
            this.TxtOndernemingsnummer.TabIndex = 2;
            // 
            // TxtControlenummer
            // 
            this.TxtControlenummer.Enabled = false;
            this.TxtControlenummer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtControlenummer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtControlenummer.Location = new System.Drawing.Point(178, 90);
            this.TxtControlenummer.Name = "TxtControlenummer";
            this.TxtControlenummer.Size = new System.Drawing.Size(100, 21);
            this.TxtControlenummer.TabIndex = 3;
            // 
            // BtnWissen
            // 
            this.BtnWissen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnWissen.Location = new System.Drawing.Point(178, 147);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 23);
            this.BtnWissen.TabIndex = 4;
            this.BtnWissen.Text = "Wissen";
            this.BtnWissen.UseVisualStyleBackColor = false;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // LblControlenummer
            // 
            this.LblControlenummer.AutoSize = true;
            this.LblControlenummer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblControlenummer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblControlenummer.Location = new System.Drawing.Point(27, 90);
            this.LblControlenummer.Name = "LblControlenummer";
            this.LblControlenummer.Size = new System.Drawing.Size(104, 15);
            this.LblControlenummer.TabIndex = 5;
            this.LblControlenummer.Text = "Controlenummer:";
            // 
            // LblResultaat
            // 
            this.LblResultaat.AutoSize = true;
            this.LblResultaat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResultaat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblResultaat.Location = new System.Drawing.Point(40, 214);
            this.LblResultaat.Name = "LblResultaat";
            this.LblResultaat.Size = new System.Drawing.Size(0, 16);
            this.LblResultaat.TabIndex = 6;
            // 
            // FrmOndernemingsnummer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(329, 282);
            this.Controls.Add(this.LblResultaat);
            this.Controls.Add(this.LblControlenummer);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.TxtControlenummer);
            this.Controls.Add(this.TxtOndernemingsnummer);
            this.Controls.Add(this.LblOndernemingsnummer);
            this.Controls.Add(this.BtnControlenummer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmOndernemingsnummer";
            this.Text = "Ondernemingsnummer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnControlenummer;
        private Label LblOndernemingsnummer;
        private TextBox TxtOndernemingsnummer;
        private TextBox TxtControlenummer;
        private Button BtnWissen;
        private Label LblControlenummer;
        private Label LblResultaat;
    }
}