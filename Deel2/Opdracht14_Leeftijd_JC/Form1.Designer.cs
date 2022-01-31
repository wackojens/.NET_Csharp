namespace Opdracht14_Leeftijd_JC
{
    partial class FrmLeeftijd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLeeftijd));
            this.LblGeboorteDat = new System.Windows.Forms.Label();
            this.TxtGeboorteDat = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.LblTijd = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtDagen = new System.Windows.Forms.TextBox();
            this.TxtMaanden = new System.Windows.Forms.TextBox();
            this.TxtJaren = new System.Windows.Forms.TextBox();
            this.LblDagen = new System.Windows.Forms.Label();
            this.LblMaanden = new System.Windows.Forms.Label();
            this.LblJaren = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblGeboorteDat
            // 
            this.LblGeboorteDat.AutoSize = true;
            this.LblGeboorteDat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGeboorteDat.Location = new System.Drawing.Point(46, 76);
            this.LblGeboorteDat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblGeboorteDat.Name = "LblGeboorteDat";
            this.LblGeboorteDat.Size = new System.Drawing.Size(100, 16);
            this.LblGeboorteDat.TabIndex = 0;
            this.LblGeboorteDat.Text = "Geboortedatum:";
            // 
            // TxtGeboorteDat
            // 
            this.TxtGeboorteDat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGeboorteDat.Location = new System.Drawing.Point(201, 74);
            this.TxtGeboorteDat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtGeboorteDat.Name = "TxtGeboorteDat";
            this.TxtGeboorteDat.Size = new System.Drawing.Size(127, 22);
            this.TxtGeboorteDat.TabIndex = 1;
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(386, 74);
            this.BtnBereken.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(96, 28);
            this.BtnBereken.TabIndex = 2;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // LblTijd
            // 
            this.LblTijd.AutoSize = true;
            this.LblTijd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTijd.Location = new System.Drawing.Point(393, 20);
            this.LblTijd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTijd.Name = "LblTijd";
            this.LblTijd.Size = new System.Drawing.Size(0, 16);
            this.LblTijd.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.TxtDagen);
            this.groupBox1.Controls.Add(this.TxtMaanden);
            this.groupBox1.Controls.Add(this.TxtJaren);
            this.groupBox1.Controls.Add(this.LblDagen);
            this.groupBox1.Controls.Add(this.LblMaanden);
            this.groupBox1.Controls.Add(this.LblJaren);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(46, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(437, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // TxtDagen
            // 
            this.TxtDagen.Enabled = false;
            this.TxtDagen.Location = new System.Drawing.Point(156, 120);
            this.TxtDagen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtDagen.Name = "TxtDagen";
            this.TxtDagen.Size = new System.Drawing.Size(127, 22);
            this.TxtDagen.TabIndex = 5;
            // 
            // TxtMaanden
            // 
            this.TxtMaanden.Enabled = false;
            this.TxtMaanden.Location = new System.Drawing.Point(156, 78);
            this.TxtMaanden.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtMaanden.Name = "TxtMaanden";
            this.TxtMaanden.Size = new System.Drawing.Size(127, 22);
            this.TxtMaanden.TabIndex = 4;
            // 
            // TxtJaren
            // 
            this.TxtJaren.Enabled = false;
            this.TxtJaren.Location = new System.Drawing.Point(156, 34);
            this.TxtJaren.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtJaren.Name = "TxtJaren";
            this.TxtJaren.Size = new System.Drawing.Size(127, 22);
            this.TxtJaren.TabIndex = 3;
            // 
            // LblDagen
            // 
            this.LblDagen.AutoSize = true;
            this.LblDagen.Location = new System.Drawing.Point(67, 124);
            this.LblDagen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDagen.Name = "LblDagen";
            this.LblDagen.Size = new System.Drawing.Size(48, 16);
            this.LblDagen.TabIndex = 2;
            this.LblDagen.Text = "Dagen:";
            // 
            // LblMaanden
            // 
            this.LblMaanden.AutoSize = true;
            this.LblMaanden.Location = new System.Drawing.Point(46, 78);
            this.LblMaanden.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblMaanden.Name = "LblMaanden";
            this.LblMaanden.Size = new System.Drawing.Size(64, 16);
            this.LblMaanden.TabIndex = 1;
            this.LblMaanden.Text = "Maanden:";
            // 
            // LblJaren
            // 
            this.LblJaren.AutoSize = true;
            this.LblJaren.Location = new System.Drawing.Point(75, 37);
            this.LblJaren.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblJaren.Name = "LblJaren";
            this.LblJaren.Size = new System.Drawing.Size(42, 16);
            this.LblJaren.TabIndex = 0;
            this.LblJaren.Text = "Jaren:";
            // 
            // FrmLeeftijd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblTijd);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtGeboorteDat);
            this.Controls.Add(this.LblGeboorteDat);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FrmLeeftijd";
            this.Text = "Leeftijd in dagen, maanden en jaren";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblGeboorteDat;
        private TextBox TxtGeboorteDat;
        private Button BtnBereken;
        private Label LblTijd;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private TextBox TxtDagen;
        private TextBox TxtMaanden;
        private TextBox TxtJaren;
        private Label LblDagen;
        private Label LblMaanden;
        private Label LblJaren;
    }
}