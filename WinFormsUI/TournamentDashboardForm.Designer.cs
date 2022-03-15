namespace WinFormsUI
{
    partial class FrmTournamentDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTournamentDashboard));
            this.LblTournamentDashboard = new System.Windows.Forms.Label();
            this.LoadTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LblLoadTournament = new System.Windows.Forms.Label();
            this.BtnLoadTournament = new System.Windows.Forms.Button();
            this.BtnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTournamentDashboard
            // 
            this.LblTournamentDashboard.AutoSize = true;
            this.LblTournamentDashboard.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTournamentDashboard.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTournamentDashboard.Location = new System.Drawing.Point(83, 29);
            this.LblTournamentDashboard.Name = "LblTournamentDashboard";
            this.LblTournamentDashboard.Size = new System.Drawing.Size(412, 50);
            this.LblTournamentDashboard.TabIndex = 13;
            this.LblTournamentDashboard.Text = "Tournament dashboard:";
            // 
            // LoadTournamentDropDown
            // 
            this.LoadTournamentDropDown.FormattingEnabled = true;
            this.LoadTournamentDropDown.Location = new System.Drawing.Point(110, 177);
            this.LoadTournamentDropDown.Name = "LoadTournamentDropDown";
            this.LoadTournamentDropDown.Size = new System.Drawing.Size(357, 38);
            this.LoadTournamentDropDown.TabIndex = 23;
            // 
            // LblLoadTournament
            // 
            this.LblLoadTournament.AutoSize = true;
            this.LblLoadTournament.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLoadTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblLoadTournament.Location = new System.Drawing.Point(177, 137);
            this.LblLoadTournament.Name = "LblLoadTournament";
            this.LblLoadTournament.Size = new System.Drawing.Size(222, 37);
            this.LblLoadTournament.TabIndex = 22;
            this.LblLoadTournament.Text = "Load tournament";
            // 
            // BtnLoadTournament
            // 
            this.BtnLoadTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnLoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnLoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadTournament.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLoadTournament.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnLoadTournament.Location = new System.Drawing.Point(187, 247);
            this.BtnLoadTournament.Name = "BtnLoadTournament";
            this.BtnLoadTournament.Size = new System.Drawing.Size(197, 55);
            this.BtnLoadTournament.TabIndex = 27;
            this.BtnLoadTournament.Text = "Load tournament";
            this.BtnLoadTournament.UseVisualStyleBackColor = true;
            // 
            // BtnCreateTournament
            // 
            this.BtnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateTournament.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateTournament.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCreateTournament.Location = new System.Drawing.Point(187, 327);
            this.BtnCreateTournament.Name = "BtnCreateTournament";
            this.BtnCreateTournament.Size = new System.Drawing.Size(197, 55);
            this.BtnCreateTournament.TabIndex = 28;
            this.BtnCreateTournament.Text = "Create tournament";
            this.BtnCreateTournament.UseVisualStyleBackColor = true;
            this.BtnCreateTournament.Click += new System.EventHandler(this.BtnCreateTournament_Click);
            // 
            // FrmTournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 466);
            this.Controls.Add(this.BtnCreateTournament);
            this.Controls.Add(this.BtnLoadTournament);
            this.Controls.Add(this.LoadTournamentDropDown);
            this.Controls.Add(this.LblLoadTournament);
            this.Controls.Add(this.LblTournamentDashboard);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmTournamentDashboard";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTournamentDashboard;
        private ComboBox LoadTournamentDropDown;
        private Label LblLoadTournament;
        private Button BtnLoadTournament;
        private Button BtnCreateTournament;
    }
}