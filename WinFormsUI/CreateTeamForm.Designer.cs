namespace WinFormsUI
{
    partial class FrmCreateTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateTeam));
            this.TxtTeamName = new System.Windows.Forms.TextBox();
            this.LblTeamName = new System.Windows.Forms.Label();
            this.LblCreateTeam = new System.Windows.Forms.Label();
            this.BtnAddPlayer = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.LblSelectTeamMember = new System.Windows.Forms.Label();
            this.PlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.BtnCreatePlayer = new System.Windows.Forms.Button();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.BtnRemoveSelectedPlayer = new System.Windows.Forms.Button();
            this.BtnCancelCreateTeam = new System.Windows.Forms.Button();
            this.BtnCreateTeam = new System.Windows.Forms.Button();
            this.PlayerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTeamName
            // 
            this.TxtTeamName.Location = new System.Drawing.Point(12, 125);
            this.TxtTeamName.Name = "TxtTeamName";
            this.TxtTeamName.Size = new System.Drawing.Size(357, 35);
            this.TxtTeamName.TabIndex = 13;
            // 
            // LblTeamName
            // 
            this.LblTeamName.AutoSize = true;
            this.LblTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTeamName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTeamName.Location = new System.Drawing.Point(12, 85);
            this.LblTeamName.Name = "LblTeamName";
            this.LblTeamName.Size = new System.Drawing.Size(152, 37);
            this.LblTeamName.TabIndex = 12;
            this.LblTeamName.Text = "Team name";
            // 
            // LblCreateTeam
            // 
            this.LblCreateTeam.AutoSize = true;
            this.LblCreateTeam.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCreateTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblCreateTeam.Location = new System.Drawing.Point(12, 9);
            this.LblCreateTeam.Name = "LblCreateTeam";
            this.LblCreateTeam.Size = new System.Drawing.Size(229, 50);
            this.LblCreateTeam.TabIndex = 11;
            this.LblCreateTeam.Text = "Create team:";
            // 
            // BtnAddPlayer
            // 
            this.BtnAddPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnAddPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnAddPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPlayer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddPlayer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddPlayer.Location = new System.Drawing.Point(110, 267);
            this.BtnAddPlayer.Name = "BtnAddPlayer";
            this.BtnAddPlayer.Size = new System.Drawing.Size(133, 34);
            this.BtnAddPlayer.TabIndex = 22;
            this.BtnAddPlayer.Text = "Add player";
            this.BtnAddPlayer.UseVisualStyleBackColor = true;
            this.BtnAddPlayer.Click += new System.EventHandler(this.BtnAddPlayer_Click);
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(12, 223);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(357, 38);
            this.SelectTeamMemberDropDown.TabIndex = 21;
            // 
            // LblSelectTeamMember
            // 
            this.LblSelectTeamMember.AutoSize = true;
            this.LblSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSelectTeamMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblSelectTeamMember.Location = new System.Drawing.Point(12, 183);
            this.LblSelectTeamMember.Name = "LblSelectTeamMember";
            this.LblSelectTeamMember.Size = new System.Drawing.Size(167, 37);
            this.LblSelectTeamMember.TabIndex = 20;
            this.LblSelectTeamMember.Text = "Select player";
            // 
            // PlayerGroupBox
            // 
            this.PlayerGroupBox.Controls.Add(this.BtnCreatePlayer);
            this.PlayerGroupBox.Controls.Add(this.TxtPhoneNumber);
            this.PlayerGroupBox.Controls.Add(this.LblPhoneNumber);
            this.PlayerGroupBox.Controls.Add(this.TxtEmail);
            this.PlayerGroupBox.Controls.Add(this.LblEmail);
            this.PlayerGroupBox.Controls.Add(this.TxtLastName);
            this.PlayerGroupBox.Controls.Add(this.LblLastName);
            this.PlayerGroupBox.Controls.Add(this.TxtFirstName);
            this.PlayerGroupBox.Controls.Add(this.LblFirstName);
            this.PlayerGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PlayerGroupBox.Location = new System.Drawing.Point(12, 324);
            this.PlayerGroupBox.Name = "PlayerGroupBox";
            this.PlayerGroupBox.Size = new System.Drawing.Size(357, 332);
            this.PlayerGroupBox.TabIndex = 23;
            this.PlayerGroupBox.TabStop = false;
            this.PlayerGroupBox.Text = "Add new player";
            // 
            // BtnCreatePlayer
            // 
            this.BtnCreatePlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCreatePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnCreatePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnCreatePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreatePlayer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreatePlayer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCreatePlayer.Location = new System.Drawing.Point(98, 266);
            this.BtnCreatePlayer.Name = "BtnCreatePlayer";
            this.BtnCreatePlayer.Size = new System.Drawing.Size(133, 34);
            this.BtnCreatePlayer.TabIndex = 24;
            this.BtnCreatePlayer.Text = "create player";
            this.BtnCreatePlayer.UseVisualStyleBackColor = true;
            this.BtnCreatePlayer.Click += new System.EventHandler(this.BtnCreatePlayer_Click);
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(151, 210);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(179, 43);
            this.TxtPhoneNumber.TabIndex = 31;
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPhoneNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblPhoneNumber.Location = new System.Drawing.Point(6, 207);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(138, 37);
            this.LblPhoneNumber.TabIndex = 30;
            this.LblPhoneNumber.Text = "Cellphone";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(151, 155);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(179, 43);
            this.TxtEmail.TabIndex = 29;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblEmail.Location = new System.Drawing.Point(6, 152);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(82, 37);
            this.LblEmail.TabIndex = 28;
            this.LblEmail.Text = "Email";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(151, 99);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(179, 43);
            this.TxtLastName.TabIndex = 27;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLastName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblLastName.Location = new System.Drawing.Point(6, 96);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(137, 37);
            this.LblLastName.TabIndex = 26;
            this.LblLastName.Text = "Last name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(151, 43);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(179, 43);
            this.TxtFirstName.TabIndex = 25;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFirstName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblFirstName.Location = new System.Drawing.Point(6, 40);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(139, 37);
            this.LblFirstName.TabIndex = 24;
            this.LblFirstName.Text = "First name";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 30;
            this.TeamMembersListBox.Location = new System.Drawing.Point(433, 85);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(308, 574);
            this.TeamMembersListBox.TabIndex = 24;
            // 
            // BtnRemoveSelectedPlayer
            // 
            this.BtnRemoveSelectedPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnRemoveSelectedPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnRemoveSelectedPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnRemoveSelectedPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveSelectedPlayer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRemoveSelectedPlayer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRemoveSelectedPlayer.Location = new System.Drawing.Point(764, 232);
            this.BtnRemoveSelectedPlayer.Name = "BtnRemoveSelectedPlayer";
            this.BtnRemoveSelectedPlayer.Size = new System.Drawing.Size(133, 69);
            this.BtnRemoveSelectedPlayer.TabIndex = 25;
            this.BtnRemoveSelectedPlayer.Text = "Remove selected";
            this.BtnRemoveSelectedPlayer.UseVisualStyleBackColor = true;
            this.BtnRemoveSelectedPlayer.Click += new System.EventHandler(this.BtnRemoveSelectedPlayer_Click);
            // 
            // BtnCancelCreateTeam
            // 
            this.BtnCancelCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCancelCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnCancelCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnCancelCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelCreateTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelCreateTeam.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCancelCreateTeam.Location = new System.Drawing.Point(477, 719);
            this.BtnCancelCreateTeam.Name = "BtnCancelCreateTeam";
            this.BtnCancelCreateTeam.Size = new System.Drawing.Size(197, 55);
            this.BtnCancelCreateTeam.TabIndex = 27;
            this.BtnCancelCreateTeam.Text = "Cancel";
            this.BtnCancelCreateTeam.UseVisualStyleBackColor = true;
            // 
            // BtnCreateTeam
            // 
            this.BtnCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateTeam.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCreateTeam.Location = new System.Drawing.Point(196, 719);
            this.BtnCreateTeam.Name = "BtnCreateTeam";
            this.BtnCreateTeam.Size = new System.Drawing.Size(197, 55);
            this.BtnCreateTeam.TabIndex = 26;
            this.BtnCreateTeam.Text = "Create team";
            this.BtnCreateTeam.UseVisualStyleBackColor = true;
            this.BtnCreateTeam.Click += new System.EventHandler(this.BtnCreateTeam_Click);
            // 
            // FrmCreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 821);
            this.Controls.Add(this.BtnCancelCreateTeam);
            this.Controls.Add(this.BtnCreateTeam);
            this.Controls.Add(this.BtnRemoveSelectedPlayer);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.PlayerGroupBox);
            this.Controls.Add(this.BtnAddPlayer);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.LblSelectTeamMember);
            this.Controls.Add(this.TxtTeamName);
            this.Controls.Add(this.LblTeamName);
            this.Controls.Add(this.LblCreateTeam);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmCreateTeam";
            this.Text = "Create team";
            this.PlayerGroupBox.ResumeLayout(false);
            this.PlayerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtTeamName;
        private Label LblTeamName;
        private Label LblCreateTeam;
        private Button BtnAddPlayer;
        private ComboBox SelectTeamMemberDropDown;
        private Label LblSelectTeamMember;
        private GroupBox PlayerGroupBox;
        private TextBox TxtFirstName;
        private Label LblFirstName;
        private TextBox TxtPhoneNumber;
        private Label LblPhoneNumber;
        private TextBox TxtEmail;
        private Label LblEmail;
        private TextBox TxtLastName;
        private Label LblLastName;
        private Button BtnCreatePlayer;
        private ListBox TeamMembersListBox;
        private Button BtnRemoveSelectedPlayer;
        private Button BtnCancelCreateTeam;
        private Button BtnCreateTeam;
    }
}