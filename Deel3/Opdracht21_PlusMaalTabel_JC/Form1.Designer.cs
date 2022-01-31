namespace Opdracht21_PlusMaalTabel_JC
{
    partial class FrmPlusMaalTabel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlusMaalTabel));
            this.TxtMaximum = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.LblMaxwaarde = new System.Windows.Forms.Label();
            this.BtnOptellen = new System.Windows.Forms.Button();
            this.BtnVermenigvuldigen = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TxtMaximum
            // 
            this.TxtMaximum.Location = new System.Drawing.Point(623, 72);
            this.TxtMaximum.Name = "TxtMaximum";
            this.TxtMaximum.Size = new System.Drawing.Size(47, 22);
            this.TxtMaximum.TabIndex = 0;
            this.TxtMaximum.Leave += new System.EventHandler(this.TxtMaximum_Leave);
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Location = new System.Drawing.Point(12, 72);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(605, 302);
            this.TxtResultaat.TabIndex = 1;
            // 
            // LblMaxwaarde
            // 
            this.LblMaxwaarde.AutoSize = true;
            this.LblMaxwaarde.Location = new System.Drawing.Point(623, 41);
            this.LblMaxwaarde.Name = "LblMaxwaarde";
            this.LblMaxwaarde.Size = new System.Drawing.Size(109, 16);
            this.LblMaxwaarde.TabIndex = 2;
            this.LblMaxwaarde.Text = "Maximumwaarde:";
            // 
            // BtnOptellen
            // 
            this.BtnOptellen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOptellen.Location = new System.Drawing.Point(623, 225);
            this.BtnOptellen.Name = "BtnOptellen";
            this.BtnOptellen.Size = new System.Drawing.Size(119, 30);
            this.BtnOptellen.TabIndex = 3;
            this.BtnOptellen.Text = "&Optellen";
            this.BtnOptellen.UseVisualStyleBackColor = true;
            this.BtnOptellen.Click += new System.EventHandler(this.BtnOptellen_Click);
            // 
            // BtnVermenigvuldigen
            // 
            this.BtnVermenigvuldigen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVermenigvuldigen.Location = new System.Drawing.Point(623, 261);
            this.BtnVermenigvuldigen.Name = "BtnVermenigvuldigen";
            this.BtnVermenigvuldigen.Size = new System.Drawing.Size(119, 30);
            this.BtnVermenigvuldigen.TabIndex = 5;
            this.BtnVermenigvuldigen.Text = "&Vermenigvuldigen";
            this.BtnVermenigvuldigen.UseVisualStyleBackColor = true;
            this.BtnVermenigvuldigen.Click += new System.EventHandler(this.BtnVermenigvuldigen_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Location = new System.Drawing.Point(623, 297);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(119, 30);
            this.BtnWissen.TabIndex = 7;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Location = new System.Drawing.Point(623, 333);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(119, 30);
            this.BtnSluiten.TabIndex = 9;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 700;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmPlusMaalTabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 389);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnVermenigvuldigen);
            this.Controls.Add(this.BtnOptellen);
            this.Controls.Add(this.LblMaxwaarde);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.TxtMaximum);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPlusMaalTabel";
            this.Text = "Tabel met optellingen of vermenigvuldigingen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtMaximum;
        private TextBox TxtResultaat;
        private Label LblMaxwaarde;
        private Button BtnOptellen;
        private Button BtnVermenigvuldigen;
        private Button BtnWissen;
        private Button BtnSluiten;
        private System.Windows.Forms.Timer Timer1;
    }
}