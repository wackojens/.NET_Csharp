namespace Project1
{
    partial class FrmFuel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuel));
            this.LblKilometers = new System.Windows.Forms.Label();
            this.LblLiters = new System.Windows.Forms.Label();
            this.LblVerbruik = new System.Windows.Forms.Label();
            this.TxtKilometers = new System.Windows.Forms.TextBox();
            this.TxtLiters = new System.Windows.Forms.TextBox();
            this.TxtVerbruik = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnLeegmaken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblKilometers
            // 
            this.LblKilometers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblKilometers.Location = new System.Drawing.Point(50, 22);
            this.LblKilometers.Name = "LblKilometers";
            this.LblKilometers.Size = new System.Drawing.Size(140, 20);
            this.LblKilometers.TabIndex = 0;
            this.LblKilometers.Text = "Kilometers gereden";
            // 
            // LblLiters
            // 
            this.LblLiters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLiters.Location = new System.Drawing.Point(50, 62);
            this.LblLiters.Name = "LblLiters";
            this.LblLiters.Size = new System.Drawing.Size(140, 20);
            this.LblLiters.TabIndex = 1;
            this.LblLiters.Text = "Liters getankt";
            this.LblLiters.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblVerbruik
            // 
            this.LblVerbruik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblVerbruik.Location = new System.Drawing.Point(50, 101);
            this.LblVerbruik.Name = "LblVerbruik";
            this.LblVerbruik.Size = new System.Drawing.Size(140, 20);
            this.LblVerbruik.TabIndex = 2;
            this.LblVerbruik.Text = "Gemiddelde verbruik";
            // 
            // TxtKilometers
            // 
            this.TxtKilometers.Location = new System.Drawing.Point(233, 21);
            this.TxtKilometers.Name = "TxtKilometers";
            this.TxtKilometers.Size = new System.Drawing.Size(100, 22);
            this.TxtKilometers.TabIndex = 3;
            this.TxtKilometers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtLiters
            // 
            this.TxtLiters.Location = new System.Drawing.Point(233, 62);
            this.TxtLiters.Name = "TxtLiters";
            this.TxtLiters.Size = new System.Drawing.Size(100, 22);
            this.TxtLiters.TabIndex = 4;
            this.TxtLiters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtVerbruik
            // 
            this.TxtVerbruik.Enabled = false;
            this.TxtVerbruik.Location = new System.Drawing.Point(233, 101);
            this.TxtVerbruik.Name = "TxtVerbruik";
            this.TxtVerbruik.Size = new System.Drawing.Size(100, 22);
            this.TxtVerbruik.TabIndex = 5;
            this.TxtVerbruik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBereken
            // 
            this.BtnBereken.Location = new System.Drawing.Point(100, 135);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(90, 25);
            this.BtnBereken.TabIndex = 6;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnLeegmaken
            // 
            this.BtnLeegmaken.Location = new System.Drawing.Point(243, 135);
            this.BtnLeegmaken.Name = "BtnLeegmaken";
            this.BtnLeegmaken.Size = new System.Drawing.Size(90, 25);
            this.BtnLeegmaken.TabIndex = 7;
            this.BtnLeegmaken.Text = "&Leegmaken";
            this.BtnLeegmaken.UseVisualStyleBackColor = true;
            this.BtnLeegmaken.Click += new System.EventHandler(this.BtnLeegmaken_Click);
            // 
            // FrmFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.BtnLeegmaken);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtVerbruik);
            this.Controls.Add(this.TxtLiters);
            this.Controls.Add(this.TxtKilometers);
            this.Controls.Add(this.LblVerbruik);
            this.Controls.Add(this.LblLiters);
            this.Controls.Add(this.LblKilometers);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFuel";
            this.Text = "Fuel consumption";
            this.Load += new System.EventHandler(this.FrmFuel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblKilometers;
        private Label LblLiters;
        private Label LblVerbruik;
        private TextBox TxtKilometers;
        private TextBox TxtLiters;
        private TextBox TxtVerbruik;
        private Button BtnBereken;
        private Button BtnLeegmaken;
    }
}