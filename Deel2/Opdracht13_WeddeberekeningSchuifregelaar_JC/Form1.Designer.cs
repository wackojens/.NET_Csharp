namespace Opdracht13_WeddeberekeningSchuifregelaar_JC
{
    partial class FrmWeddeberekening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeddeberekening));
            this.TrbInkomen = new System.Windows.Forms.TrackBar();
            this.LblBelasting = new System.Windows.Forms.Label();
            this.LblBelastingVal = new System.Windows.Forms.Label();
            this.Ttp1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TrbInkomen)).BeginInit();
            this.SuspendLayout();
            // 
            // TrbInkomen
            // 
            this.TrbInkomen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TrbInkomen.LargeChange = 500;
            this.TrbInkomen.Location = new System.Drawing.Point(31, 135);
            this.TrbInkomen.Maximum = 100000;
            this.TrbInkomen.Name = "TrbInkomen";
            this.TrbInkomen.Size = new System.Drawing.Size(407, 45);
            this.TrbInkomen.TabIndex = 0;
            this.TrbInkomen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrbInkomen.Scroll += new System.EventHandler(this.TrbInkomen_Scroll);
            // 
            // LblBelasting
            // 
            this.LblBelasting.AutoSize = true;
            this.LblBelasting.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBelasting.Location = new System.Drawing.Point(56, 55);
            this.LblBelasting.Name = "LblBelasting";
            this.LblBelasting.Size = new System.Drawing.Size(104, 22);
            this.LblBelasting.TabIndex = 1;
            this.LblBelasting.Text = "Belasting:";
            // 
            // LblBelastingVal
            // 
            this.LblBelastingVal.AutoSize = true;
            this.LblBelastingVal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBelastingVal.Location = new System.Drawing.Point(205, 55);
            this.LblBelastingVal.Name = "LblBelastingVal";
            this.LblBelastingVal.Size = new System.Drawing.Size(18, 19);
            this.LblBelastingVal.TabIndex = 2;
            this.LblBelastingVal.Text = "0";
            // 
            // FrmWeddeberekening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 206);
            this.Controls.Add(this.LblBelastingVal);
            this.Controls.Add(this.LblBelasting);
            this.Controls.Add(this.TrbInkomen);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWeddeberekening";
            this.Text = "Belastingen berekenen";
            ((System.ComponentModel.ISupportInitialize)(this.TrbInkomen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar TrbInkomen;
        private Label LblBelasting;
        private Label LblBelastingVal;
        private ToolTip Ttp1;
    }
}