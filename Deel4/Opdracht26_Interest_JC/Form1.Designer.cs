namespace Opdracht26_Interest_JC
{
    partial class FrmIntrest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntrest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtIntrest = new System.Windows.Forms.TextBox();
            this.TxtEindKap = new System.Windows.Forms.TextBox();
            this.TxtBeginKap = new System.Windows.Forms.TextBox();
            this.LblIntrest = new System.Windows.Forms.Label();
            this.LblBeginKap = new System.Windows.Forms.Label();
            this.LblEindKap = new System.Windows.Forms.Label();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TxtIntrest);
            this.panel1.Controls.Add(this.TxtEindKap);
            this.panel1.Controls.Add(this.TxtBeginKap);
            this.panel1.Controls.Add(this.LblIntrest);
            this.panel1.Controls.Add(this.LblBeginKap);
            this.panel1.Controls.Add(this.LblEindKap);
            this.panel1.Location = new System.Drawing.Point(67, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 141);
            this.panel1.TabIndex = 0;
            // 
            // TxtIntrest
            // 
            this.TxtIntrest.Location = new System.Drawing.Point(160, 88);
            this.TxtIntrest.Name = "TxtIntrest";
            this.TxtIntrest.Size = new System.Drawing.Size(100, 22);
            this.TxtIntrest.TabIndex = 5;
            // 
            // TxtEindKap
            // 
            this.TxtEindKap.Location = new System.Drawing.Point(160, 55);
            this.TxtEindKap.Name = "TxtEindKap";
            this.TxtEindKap.Size = new System.Drawing.Size(100, 22);
            this.TxtEindKap.TabIndex = 4;
            this.TxtEindKap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEindKap_KeyPress);
            // 
            // TxtBeginKap
            // 
            this.TxtBeginKap.Location = new System.Drawing.Point(160, 23);
            this.TxtBeginKap.Name = "TxtBeginKap";
            this.TxtBeginKap.Size = new System.Drawing.Size(100, 22);
            this.TxtBeginKap.TabIndex = 3;
            this.TxtBeginKap.TextChanged += new System.EventHandler(this.TxtBeginKap_TextChanged);
            // 
            // LblIntrest
            // 
            this.LblIntrest.AutoSize = true;
            this.LblIntrest.Location = new System.Drawing.Point(72, 91);
            this.LblIntrest.Name = "LblIntrest";
            this.LblIntrest.Size = new System.Drawing.Size(70, 16);
            this.LblIntrest.TabIndex = 2;
            this.LblIntrest.Text = "Intrestvoet:";
            // 
            // LblBeginKap
            // 
            this.LblBeginKap.AutoSize = true;
            this.LblBeginKap.Location = new System.Drawing.Point(53, 26);
            this.LblBeginKap.Name = "LblBeginKap";
            this.LblBeginKap.Size = new System.Drawing.Size(89, 16);
            this.LblBeginKap.TabIndex = 0;
            this.LblBeginKap.Text = "Beginkapitaal:";
            // 
            // LblEindKap
            // 
            this.LblEindKap.AutoSize = true;
            this.LblEindKap.Location = new System.Drawing.Point(7, 58);
            this.LblEindKap.Name = "LblEindKap";
            this.LblEindKap.Size = new System.Drawing.Size(135, 16);
            this.LblEindKap.TabIndex = 1;
            this.LblEindKap.Text = "Gewenst eindkapitaal:";
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Location = new System.Drawing.Point(392, 48);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.ReadOnly = true;
            this.TxtResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResultaat.Size = new System.Drawing.Size(294, 141);
            this.TxtResultaat.TabIndex = 1;
            // 
            // BtnBereken
            // 
            this.BtnBereken.BackColor = System.Drawing.Color.White;
            this.BtnBereken.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBereken.FlatAppearance.BorderSize = 0;
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBereken.Image = global::Opdracht26_Intrest_JC.Properties.Resources._85350_accept_icon__1_;
            this.BtnBereken.Location = new System.Drawing.Point(67, 203);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(55, 53);
            this.BtnBereken.TabIndex = 2;
            this.BtnBereken.UseVisualStyleBackColor = false;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.BackColor = System.Drawing.Color.White;
            this.BtnWissen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnWissen.FlatAppearance.BorderSize = 0;
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWissen.Image = global::Opdracht26_Intrest_JC.Properties.Resources._61439_minus_icon;
            this.BtnWissen.Location = new System.Drawing.Point(180, 203);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(55, 53);
            this.BtnWissen.TabIndex = 3;
            this.BtnWissen.UseVisualStyleBackColor = false;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.BackColor = System.Drawing.Color.White;
            this.BtnSluiten.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSluiten.FlatAppearance.BorderSize = 0;
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSluiten.Image = global::Opdracht26_Intrest_JC.Properties.Resources._32391_close_icon;
            this.BtnSluiten.Location = new System.Drawing.Point(306, 203);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(55, 53);
            this.BtnSluiten.TabIndex = 4;
            this.BtnSluiten.UseVisualStyleBackColor = false;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmIntrest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Opdracht26_Intrest_JC.Properties.Resources.Credible_low_interest_rates_savings_iStock_1136482684;
            this.ClientSize = new System.Drawing.Size(847, 429);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIntrest";
            this.Text = "Intrestberekening";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox TxtIntrest;
        private TextBox TxtEindKap;
        private TextBox TxtBeginKap;
        private Label LblIntrest;
        private Label LblEindKap;
        private Label LblBeginKap;
        private TextBox TxtResultaat;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}