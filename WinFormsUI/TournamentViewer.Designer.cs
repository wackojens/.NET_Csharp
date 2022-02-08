namespace WinFormsUI
{
    partial class FrmTournamentViewer
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
            this.LblTournament = new System.Windows.Forms.Label();
            this.LblTournamentName = new System.Windows.Forms.Label();
            this.LblRound = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedCheckBox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LblTeam1 = new System.Windows.Forms.Label();
            this.LblScoreTeam1 = new System.Windows.Forms.Label();
            this.TxtScoreTeam1 = new System.Windows.Forms.TextBox();
            this.TxtScoreTeam2 = new System.Windows.Forms.TextBox();
            this.ScoreTeam2 = new System.Windows.Forms.Label();
            this.LblTeam2 = new System.Windows.Forms.Label();
            this.LblVersus = new System.Windows.Forms.Label();
            this.BtnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTournament
            // 
            this.LblTournament.AutoSize = true;
            this.LblTournament.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTournament.Location = new System.Drawing.Point(26, 22);
            this.LblTournament.Name = "LblTournament";
            this.LblTournament.Size = new System.Drawing.Size(226, 50);
            this.LblTournament.TabIndex = 0;
            this.LblTournament.Text = "Tournament:";
            // 
            // LblTournamentName
            // 
            this.LblTournamentName.AutoSize = true;
            this.LblTournamentName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTournamentName.Location = new System.Drawing.Point(243, 22);
            this.LblTournamentName.Name = "LblTournamentName";
            this.LblTournamentName.Size = new System.Drawing.Size(155, 50);
            this.LblTournamentName.TabIndex = 1;
            this.LblTournamentName.Text = "<none>";
            // 
            // LblRound
            // 
            this.LblRound.AutoSize = true;
            this.LblRound.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblRound.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblRound.Location = new System.Drawing.Point(26, 99);
            this.LblRound.Name = "LblRound";
            this.LblRound.Size = new System.Drawing.Size(94, 37);
            this.LblRound.TabIndex = 2;
            this.LblRound.Text = "Round";
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(126, 98);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(208, 38);
            this.RoundDropDown.TabIndex = 3;
            // 
            // UnplayedCheckBox
            // 
            this.UnplayedCheckBox.AutoSize = true;
            this.UnplayedCheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnplayedCheckBox.Location = new System.Drawing.Point(126, 152);
            this.UnplayedCheckBox.Name = "UnplayedCheckBox";
            this.UnplayedCheckBox.Size = new System.Drawing.Size(208, 41);
            this.UnplayedCheckBox.TabIndex = 4;
            this.UnplayedCheckBox.Text = "Unplayed only";
            this.UnplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(26, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 304);
            this.listBox1.TabIndex = 5;
            // 
            // LblTeam1
            // 
            this.LblTeam1.AutoSize = true;
            this.LblTeam1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTeam1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTeam1.Location = new System.Drawing.Point(371, 199);
            this.LblTeam1.Name = "LblTeam1";
            this.LblTeam1.Size = new System.Drawing.Size(137, 37);
            this.LblTeam1.TabIndex = 6;
            this.LblTeam1.Text = "<Team 1>";
            // 
            // LblScoreTeam1
            // 
            this.LblScoreTeam1.AutoSize = true;
            this.LblScoreTeam1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblScoreTeam1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblScoreTeam1.Location = new System.Drawing.Point(345, 236);
            this.LblScoreTeam1.Name = "LblScoreTeam1";
            this.LblScoreTeam1.Size = new System.Drawing.Size(82, 37);
            this.LblScoreTeam1.TabIndex = 7;
            this.LblScoreTeam1.Text = "Score";
            // 
            // TxtScoreTeam1
            // 
            this.TxtScoreTeam1.Location = new System.Drawing.Point(433, 239);
            this.TxtScoreTeam1.Name = "TxtScoreTeam1";
            this.TxtScoreTeam1.Size = new System.Drawing.Size(100, 35);
            this.TxtScoreTeam1.TabIndex = 8;
            // 
            // TxtScoreTeam2
            // 
            this.TxtScoreTeam2.Location = new System.Drawing.Point(620, 450);
            this.TxtScoreTeam2.Name = "TxtScoreTeam2";
            this.TxtScoreTeam2.Size = new System.Drawing.Size(100, 35);
            this.TxtScoreTeam2.TabIndex = 11;
            // 
            // ScoreTeam2
            // 
            this.ScoreTeam2.AutoSize = true;
            this.ScoreTeam2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreTeam2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ScoreTeam2.Location = new System.Drawing.Point(532, 447);
            this.ScoreTeam2.Name = "ScoreTeam2";
            this.ScoreTeam2.Size = new System.Drawing.Size(82, 37);
            this.ScoreTeam2.TabIndex = 10;
            this.ScoreTeam2.Text = "Score";
            // 
            // LblTeam2
            // 
            this.LblTeam2.AutoSize = true;
            this.LblTeam2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTeam2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTeam2.Location = new System.Drawing.Point(558, 410);
            this.LblTeam2.Name = "LblTeam2";
            this.LblTeam2.Size = new System.Drawing.Size(137, 37);
            this.LblTeam2.TabIndex = 9;
            this.LblTeam2.Text = "<Team 2>";
            // 
            // LblVersus
            // 
            this.LblVersus.AutoSize = true;
            this.LblVersus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVersus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblVersus.Location = new System.Drawing.Point(496, 328);
            this.LblVersus.Name = "LblVersus";
            this.LblVersus.Size = new System.Drawing.Size(70, 37);
            this.LblVersus.TabIndex = 12;
            this.LblVersus.Text = "-VS-";
            // 
            // BtnScore
            // 
            this.BtnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnScore.Location = new System.Drawing.Point(361, 469);
            this.BtnScore.Name = "BtnScore";
            this.BtnScore.Size = new System.Drawing.Size(87, 34);
            this.BtnScore.TabIndex = 13;
            this.BtnScore.Text = "Score";
            this.BtnScore.UseVisualStyleBackColor = true;
            // 
            // FrmTournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 532);
            this.Controls.Add(this.BtnScore);
            this.Controls.Add(this.LblVersus);
            this.Controls.Add(this.TxtScoreTeam2);
            this.Controls.Add(this.ScoreTeam2);
            this.Controls.Add(this.LblTeam2);
            this.Controls.Add(this.TxtScoreTeam1);
            this.Controls.Add(this.LblScoreTeam1);
            this.Controls.Add(this.LblTeam1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.UnplayedCheckBox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.LblRound);
            this.Controls.Add(this.LblTournamentName);
            this.Controls.Add(this.LblTournament);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmTournamentViewer";
            this.Text = "Tournament viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTournament;
        private Label LblTournamentName;
        private Label LblRound;
        private ComboBox RoundDropDown;
        private CheckBox UnplayedCheckBox;
        private ListBox listBox1;
        private Label LblTeam1;
        private Label LblScoreTeam1;
        private TextBox TxtScoreTeam1;
        private TextBox TxtScoreTeam2;
        private Label ScoreTeam2;
        private Label LblTeam2;
        private Label LblVersus;
        private Button BtnScore;
    }
}