namespace WinFormsUI
{
    partial class FrmCreateTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateTournament));
            this.LblTournament = new System.Windows.Forms.Label();
            this.TxtTournamentName = new System.Windows.Forms.TextBox();
            this.LblTournamentName = new System.Windows.Forms.Label();
            this.TxtEntryFee = new System.Windows.Forms.TextBox();
            this.LblEntryFee = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.LblSelectTeam = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.BtnAddTeam = new System.Windows.Forms.Button();
            this.BtnCreatePrize = new System.Windows.Forms.Button();
            this.TournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.LblTournamentPlayers = new System.Windows.Forms.Label();
            this.BtnRemoveSelectedTeam = new System.Windows.Forms.Button();
            this.BtnRemoveSelectedPrize = new System.Windows.Forms.Button();
            this.LblPrizes = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.BtnCreateTournament = new System.Windows.Forms.Button();
            this.BtnCancelCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTournament
            // 
            this.LblTournament.AutoSize = true;
            this.LblTournament.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTournament.Location = new System.Drawing.Point(12, 9);
            this.LblTournament.Name = "LblTournament";
            this.LblTournament.Size = new System.Drawing.Size(340, 50);
            this.LblTournament.TabIndex = 1;
            this.LblTournament.Text = "Create tournament:";
            // 
            // TxtTournamentName
            // 
            this.TxtTournamentName.Location = new System.Drawing.Point(12, 146);
            this.TxtTournamentName.Name = "TxtTournamentName";
            this.TxtTournamentName.Size = new System.Drawing.Size(357, 35);
            this.TxtTournamentName.TabIndex = 10;
            // 
            // LblTournamentName
            // 
            this.LblTournamentName.AutoSize = true;
            this.LblTournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTournamentName.Location = new System.Drawing.Point(12, 106);
            this.LblTournamentName.Name = "LblTournamentName";
            this.LblTournamentName.Size = new System.Drawing.Size(231, 37);
            this.LblTournamentName.TabIndex = 9;
            this.LblTournamentName.Text = "Tournament name";
            // 
            // TxtEntryFee
            // 
            this.TxtEntryFee.Location = new System.Drawing.Point(138, 261);
            this.TxtEntryFee.Name = "TxtEntryFee";
            this.TxtEntryFee.Size = new System.Drawing.Size(100, 35);
            this.TxtEntryFee.TabIndex = 12;
            this.TxtEntryFee.Text = "0";
            // 
            // LblEntryFee
            // 
            this.LblEntryFee.AutoSize = true;
            this.LblEntryFee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEntryFee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblEntryFee.Location = new System.Drawing.Point(12, 261);
            this.LblEntryFee.Name = "LblEntryFee";
            this.LblEntryFee.Size = new System.Drawing.Size(120, 37);
            this.LblEntryFee.TabIndex = 11;
            this.LblEntryFee.Text = "Entry fee";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(12, 409);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(357, 38);
            this.SelectTeamDropDown.TabIndex = 14;
            // 
            // LblSelectTeam
            // 
            this.LblSelectTeam.AutoSize = true;
            this.LblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSelectTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblSelectTeam.Location = new System.Drawing.Point(12, 369);
            this.LblSelectTeam.Name = "LblSelectTeam";
            this.LblSelectTeam.Size = new System.Drawing.Size(154, 37);
            this.LblSelectTeam.TabIndex = 13;
            this.LblSelectTeam.Text = "Select team";
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Location = new System.Drawing.Point(243, 375);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(126, 30);
            this.CreateNewTeamLink.TabIndex = 15;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create team";
            this.CreateNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewTeamLink_LinkClicked);
            // 
            // BtnAddTeam
            // 
            this.BtnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddTeam.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddTeam.Location = new System.Drawing.Point(110, 453);
            this.BtnAddTeam.Name = "BtnAddTeam";
            this.BtnAddTeam.Size = new System.Drawing.Size(133, 34);
            this.BtnAddTeam.TabIndex = 16;
            this.BtnAddTeam.Text = "Add team";
            this.BtnAddTeam.UseVisualStyleBackColor = true;
            this.BtnAddTeam.Click += new System.EventHandler(this.BtnAddTeam_Click);
            // 
            // BtnCreatePrize
            // 
            this.BtnCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreatePrize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreatePrize.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCreatePrize.Location = new System.Drawing.Point(110, 523);
            this.BtnCreatePrize.Name = "BtnCreatePrize";
            this.BtnCreatePrize.Size = new System.Drawing.Size(133, 34);
            this.BtnCreatePrize.TabIndex = 17;
            this.BtnCreatePrize.Text = "Create prize";
            this.BtnCreatePrize.UseVisualStyleBackColor = true;
            this.BtnCreatePrize.Click += new System.EventHandler(this.BtnCreatePrize_Click);
            // 
            // TournamentTeamsListBox
            // 
            this.TournamentTeamsListBox.FormattingEnabled = true;
            this.TournamentTeamsListBox.ItemHeight = 30;
            this.TournamentTeamsListBox.Location = new System.Drawing.Point(457, 146);
            this.TournamentTeamsListBox.Name = "TournamentTeamsListBox";
            this.TournamentTeamsListBox.Size = new System.Drawing.Size(308, 184);
            this.TournamentTeamsListBox.TabIndex = 18;
            // 
            // LblTournamentPlayers
            // 
            this.LblTournamentPlayers.AutoSize = true;
            this.LblTournamentPlayers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTournamentPlayers.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTournamentPlayers.Location = new System.Drawing.Point(457, 106);
            this.LblTournamentPlayers.Name = "LblTournamentPlayers";
            this.LblTournamentPlayers.Size = new System.Drawing.Size(199, 37);
            this.LblTournamentPlayers.TabIndex = 19;
            this.LblTournamentPlayers.Text = "Teams / players";
            // 
            // BtnRemoveSelectedTeam
            // 
            this.BtnRemoveSelectedTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnRemoveSelectedTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnRemoveSelectedTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnRemoveSelectedTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveSelectedTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRemoveSelectedTeam.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRemoveSelectedTeam.Location = new System.Drawing.Point(794, 208);
            this.BtnRemoveSelectedTeam.Name = "BtnRemoveSelectedTeam";
            this.BtnRemoveSelectedTeam.Size = new System.Drawing.Size(133, 69);
            this.BtnRemoveSelectedTeam.TabIndex = 20;
            this.BtnRemoveSelectedTeam.Text = "Remove selected";
            this.BtnRemoveSelectedTeam.UseVisualStyleBackColor = true;
            this.BtnRemoveSelectedTeam.Click += new System.EventHandler(this.BtnRemoveSelectedTeam_Click);
            // 
            // BtnRemoveSelectedPrize
            // 
            this.BtnRemoveSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnRemoveSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnRemoveSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnRemoveSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveSelectedPrize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRemoveSelectedPrize.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRemoveSelectedPrize.Location = new System.Drawing.Point(794, 426);
            this.BtnRemoveSelectedPrize.Name = "BtnRemoveSelectedPrize";
            this.BtnRemoveSelectedPrize.Size = new System.Drawing.Size(133, 60);
            this.BtnRemoveSelectedPrize.TabIndex = 23;
            this.BtnRemoveSelectedPrize.Text = "Remove selected";
            this.BtnRemoveSelectedPrize.UseVisualStyleBackColor = true;
            this.BtnRemoveSelectedPrize.Click += new System.EventHandler(this.BtnRemoveSelectedPrize_Click);
            // 
            // LblPrizes
            // 
            this.LblPrizes.AutoSize = true;
            this.LblPrizes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrizes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblPrizes.Location = new System.Drawing.Point(457, 351);
            this.LblPrizes.Name = "LblPrizes";
            this.LblPrizes.Size = new System.Drawing.Size(85, 37);
            this.LblPrizes.TabIndex = 22;
            this.LblPrizes.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 30;
            this.PrizesListBox.Location = new System.Drawing.Point(457, 391);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(308, 184);
            this.PrizesListBox.TabIndex = 21;
            // 
            // BtnCreateTournament
            // 
            this.BtnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateTournament.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateTournament.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCreateTournament.Location = new System.Drawing.Point(231, 614);
            this.BtnCreateTournament.Name = "BtnCreateTournament";
            this.BtnCreateTournament.Size = new System.Drawing.Size(197, 55);
            this.BtnCreateTournament.TabIndex = 24;
            this.BtnCreateTournament.Text = "Create tournament";
            this.BtnCreateTournament.UseVisualStyleBackColor = true;
            this.BtnCreateTournament.Click += new System.EventHandler(this.BtnCreateTournament_Click);
            // 
            // BtnCancelCreateTournament
            // 
            this.BtnCancelCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCancelCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnCancelCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnCancelCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelCreateTournament.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelCreateTournament.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCancelCreateTournament.Location = new System.Drawing.Point(512, 614);
            this.BtnCancelCreateTournament.Name = "BtnCancelCreateTournament";
            this.BtnCancelCreateTournament.Size = new System.Drawing.Size(197, 55);
            this.BtnCancelCreateTournament.TabIndex = 25;
            this.BtnCancelCreateTournament.Text = "Cancel";
            this.BtnCancelCreateTournament.UseVisualStyleBackColor = true;
            // 
            // FrmCreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 697);
            this.Controls.Add(this.BtnCancelCreateTournament);
            this.Controls.Add(this.BtnCreateTournament);
            this.Controls.Add(this.BtnRemoveSelectedPrize);
            this.Controls.Add(this.LblPrizes);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.BtnRemoveSelectedTeam);
            this.Controls.Add(this.LblTournamentPlayers);
            this.Controls.Add(this.TournamentTeamsListBox);
            this.Controls.Add(this.BtnCreatePrize);
            this.Controls.Add(this.BtnAddTeam);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.LblSelectTeam);
            this.Controls.Add(this.TxtEntryFee);
            this.Controls.Add(this.LblEntryFee);
            this.Controls.Add(this.TxtTournamentName);
            this.Controls.Add(this.LblTournamentName);
            this.Controls.Add(this.LblTournament);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmCreateTournament";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTournament;
        private TextBox TxtTournamentName;
        private Label LblTournamentName;
        private TextBox TxtEntryFee;
        private Label LblEntryFee;
        private ComboBox SelectTeamDropDown;
        private Label LblSelectTeam;
        private LinkLabel CreateNewTeamLink;
        private Button BtnAddTeam;
        private Button BtnCreatePrize;
        private ListBox TournamentTeamsListBox;
        private Label LblTournamentPlayers;
        private Button BtnRemoveSelectedTeam;
        private Button BtnRemoveSelectedPrize;
        private Label LblPrizes;
        private ListBox PrizesListBox;
        private Button BtnCreateTournament;
        private Button BtnCancelCreateTournament;
    }
}