
namespace CIS353GroupB
{
    partial class GolfLeague_Form
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
            this.Tab_Control = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.tabCreateTeam = new System.Windows.Forms.TabPage();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtG4Rank = new System.Windows.Forms.TextBox();
            this.txtG4GameScore = new System.Windows.Forms.TextBox();
            this.txtG4Handicap = new System.Windows.Forms.TextBox();
            this.txtG4LName = new System.Windows.Forms.TextBox();
            this.txtG4FName = new System.Windows.Forms.TextBox();
            this.txtG3Rank = new System.Windows.Forms.TextBox();
            this.txtG3GameScore = new System.Windows.Forms.TextBox();
            this.txtG3Handicap = new System.Windows.Forms.TextBox();
            this.txtG3LName = new System.Windows.Forms.TextBox();
            this.txtG3FName = new System.Windows.Forms.TextBox();
            this.txtG2Rank = new System.Windows.Forms.TextBox();
            this.txtG2GameScore = new System.Windows.Forms.TextBox();
            this.txtG2Handicap = new System.Windows.Forms.TextBox();
            this.txtG2LName = new System.Windows.Forms.TextBox();
            this.txtG2FName = new System.Windows.Forms.TextBox();
            this.txtG1Rank = new System.Windows.Forms.TextBox();
            this.txtG1GameScore = new System.Windows.Forms.TextBox();
            this.txtG1Handicap = new System.Windows.Forms.TextBox();
            this.txtG1LName = new System.Windows.Forms.TextBox();
            this.txtG1FName = new System.Windows.Forms.TextBox();
            this.lblPlayerRank = new System.Windows.Forms.Label();
            this.lblGameScore = new System.Windows.Forms.Label();
            this.lblHandicap = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblTeamRank = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.txtTeamRank = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.cboxTeams = new System.Windows.Forms.ComboBox();
            this.tabDisplayTeam = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Tab_Control.SuspendLayout();
            this.tabCreateTeam.SuspendLayout();
            this.tabDisplayTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Control
            // 
            this.Tab_Control.Controls.Add(this.tabWelcome);
            this.Tab_Control.Controls.Add(this.tabCreateTeam);
            this.Tab_Control.Controls.Add(this.tabDisplayTeam);
            this.Tab_Control.Location = new System.Drawing.Point(13, 13);
            this.Tab_Control.Name = "Tab_Control";
            this.Tab_Control.SelectedIndex = 0;
            this.Tab_Control.Size = new System.Drawing.Size(566, 326);
            this.Tab_Control.TabIndex = 0;
            // 
            // tabWelcome
            // 
            this.tabWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(558, 300);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "Welcome";
            this.tabWelcome.UseVisualStyleBackColor = true;
            // 
            // tabCreateTeam
            // 
            this.tabCreateTeam.Controls.Add(this.btnExport);
            this.tabCreateTeam.Controls.Add(this.btnClear);
            this.tabCreateTeam.Controls.Add(this.btnImport);
            this.tabCreateTeam.Controls.Add(this.btnDelete);
            this.tabCreateTeam.Controls.Add(this.btnUpdate);
            this.tabCreateTeam.Controls.Add(this.txtG4Rank);
            this.tabCreateTeam.Controls.Add(this.txtG4GameScore);
            this.tabCreateTeam.Controls.Add(this.txtG4Handicap);
            this.tabCreateTeam.Controls.Add(this.txtG4LName);
            this.tabCreateTeam.Controls.Add(this.txtG4FName);
            this.tabCreateTeam.Controls.Add(this.txtG3Rank);
            this.tabCreateTeam.Controls.Add(this.txtG3GameScore);
            this.tabCreateTeam.Controls.Add(this.txtG3Handicap);
            this.tabCreateTeam.Controls.Add(this.txtG3LName);
            this.tabCreateTeam.Controls.Add(this.txtG3FName);
            this.tabCreateTeam.Controls.Add(this.txtG2Rank);
            this.tabCreateTeam.Controls.Add(this.txtG2GameScore);
            this.tabCreateTeam.Controls.Add(this.txtG2Handicap);
            this.tabCreateTeam.Controls.Add(this.txtG2LName);
            this.tabCreateTeam.Controls.Add(this.txtG2FName);
            this.tabCreateTeam.Controls.Add(this.txtG1Rank);
            this.tabCreateTeam.Controls.Add(this.txtG1GameScore);
            this.tabCreateTeam.Controls.Add(this.txtG1Handicap);
            this.tabCreateTeam.Controls.Add(this.txtG1LName);
            this.tabCreateTeam.Controls.Add(this.txtG1FName);
            this.tabCreateTeam.Controls.Add(this.lblPlayerRank);
            this.tabCreateTeam.Controls.Add(this.lblGameScore);
            this.tabCreateTeam.Controls.Add(this.lblHandicap);
            this.tabCreateTeam.Controls.Add(this.lblLastName);
            this.tabCreateTeam.Controls.Add(this.lblFirstName);
            this.tabCreateTeam.Controls.Add(this.lblTeamRank);
            this.tabCreateTeam.Controls.Add(this.lblTeamName);
            this.tabCreateTeam.Controls.Add(this.txtTeamRank);
            this.tabCreateTeam.Controls.Add(this.txtTeamName);
            this.tabCreateTeam.Controls.Add(this.cboxTeams);
            this.tabCreateTeam.Location = new System.Drawing.Point(4, 22);
            this.tabCreateTeam.Name = "tabCreateTeam";
            this.tabCreateTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateTeam.Size = new System.Drawing.Size(558, 300);
            this.tabCreateTeam.TabIndex = 1;
            this.tabCreateTeam.Text = "Create/Update Team";
            this.tabCreateTeam.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(245, 17);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(90, 29);
            this.btnImport.TabIndex = 32;
            this.btnImport.Text = "Import Team";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(124, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 29);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete Team";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(240, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 29);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Add Team";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtG4Rank
            // 
            this.txtG4Rank.Location = new System.Drawing.Point(442, 216);
            this.txtG4Rank.Name = "txtG4Rank";
            this.txtG4Rank.Size = new System.Drawing.Size(100, 20);
            this.txtG4Rank.TabIndex = 29;
            // 
            // txtG4GameScore
            // 
            this.txtG4GameScore.Location = new System.Drawing.Point(336, 216);
            this.txtG4GameScore.Name = "txtG4GameScore";
            this.txtG4GameScore.Size = new System.Drawing.Size(100, 20);
            this.txtG4GameScore.TabIndex = 28;
            // 
            // txtG4Handicap
            // 
            this.txtG4Handicap.Location = new System.Drawing.Point(230, 216);
            this.txtG4Handicap.Name = "txtG4Handicap";
            this.txtG4Handicap.Size = new System.Drawing.Size(100, 20);
            this.txtG4Handicap.TabIndex = 27;
            // 
            // txtG4LName
            // 
            this.txtG4LName.Location = new System.Drawing.Point(124, 216);
            this.txtG4LName.Name = "txtG4LName";
            this.txtG4LName.Size = new System.Drawing.Size(100, 20);
            this.txtG4LName.TabIndex = 26;
            // 
            // txtG4FName
            // 
            this.txtG4FName.Location = new System.Drawing.Point(18, 216);
            this.txtG4FName.Name = "txtG4FName";
            this.txtG4FName.Size = new System.Drawing.Size(100, 20);
            this.txtG4FName.TabIndex = 25;
            // 
            // txtG3Rank
            // 
            this.txtG3Rank.Location = new System.Drawing.Point(442, 190);
            this.txtG3Rank.Name = "txtG3Rank";
            this.txtG3Rank.Size = new System.Drawing.Size(100, 20);
            this.txtG3Rank.TabIndex = 24;
            // 
            // txtG3GameScore
            // 
            this.txtG3GameScore.Location = new System.Drawing.Point(336, 190);
            this.txtG3GameScore.Name = "txtG3GameScore";
            this.txtG3GameScore.Size = new System.Drawing.Size(100, 20);
            this.txtG3GameScore.TabIndex = 23;
            // 
            // txtG3Handicap
            // 
            this.txtG3Handicap.Location = new System.Drawing.Point(230, 190);
            this.txtG3Handicap.Name = "txtG3Handicap";
            this.txtG3Handicap.Size = new System.Drawing.Size(100, 20);
            this.txtG3Handicap.TabIndex = 22;
            // 
            // txtG3LName
            // 
            this.txtG3LName.Location = new System.Drawing.Point(124, 190);
            this.txtG3LName.Name = "txtG3LName";
            this.txtG3LName.Size = new System.Drawing.Size(100, 20);
            this.txtG3LName.TabIndex = 21;
            // 
            // txtG3FName
            // 
            this.txtG3FName.Location = new System.Drawing.Point(18, 190);
            this.txtG3FName.Name = "txtG3FName";
            this.txtG3FName.Size = new System.Drawing.Size(100, 20);
            this.txtG3FName.TabIndex = 20;
            // 
            // txtG2Rank
            // 
            this.txtG2Rank.Location = new System.Drawing.Point(442, 164);
            this.txtG2Rank.Name = "txtG2Rank";
            this.txtG2Rank.Size = new System.Drawing.Size(100, 20);
            this.txtG2Rank.TabIndex = 19;
            // 
            // txtG2GameScore
            // 
            this.txtG2GameScore.Location = new System.Drawing.Point(336, 164);
            this.txtG2GameScore.Name = "txtG2GameScore";
            this.txtG2GameScore.Size = new System.Drawing.Size(100, 20);
            this.txtG2GameScore.TabIndex = 18;
            // 
            // txtG2Handicap
            // 
            this.txtG2Handicap.Location = new System.Drawing.Point(230, 164);
            this.txtG2Handicap.Name = "txtG2Handicap";
            this.txtG2Handicap.Size = new System.Drawing.Size(100, 20);
            this.txtG2Handicap.TabIndex = 17;
            // 
            // txtG2LName
            // 
            this.txtG2LName.Location = new System.Drawing.Point(124, 164);
            this.txtG2LName.Name = "txtG2LName";
            this.txtG2LName.Size = new System.Drawing.Size(100, 20);
            this.txtG2LName.TabIndex = 16;
            // 
            // txtG2FName
            // 
            this.txtG2FName.Location = new System.Drawing.Point(18, 164);
            this.txtG2FName.Name = "txtG2FName";
            this.txtG2FName.Size = new System.Drawing.Size(100, 20);
            this.txtG2FName.TabIndex = 15;
            // 
            // txtG1Rank
            // 
            this.txtG1Rank.Location = new System.Drawing.Point(442, 138);
            this.txtG1Rank.Name = "txtG1Rank";
            this.txtG1Rank.Size = new System.Drawing.Size(100, 20);
            this.txtG1Rank.TabIndex = 14;
            // 
            // txtG1GameScore
            // 
            this.txtG1GameScore.Location = new System.Drawing.Point(336, 138);
            this.txtG1GameScore.Name = "txtG1GameScore";
            this.txtG1GameScore.Size = new System.Drawing.Size(100, 20);
            this.txtG1GameScore.TabIndex = 13;
            // 
            // txtG1Handicap
            // 
            this.txtG1Handicap.Location = new System.Drawing.Point(230, 138);
            this.txtG1Handicap.Name = "txtG1Handicap";
            this.txtG1Handicap.Size = new System.Drawing.Size(100, 20);
            this.txtG1Handicap.TabIndex = 12;
            // 
            // txtG1LName
            // 
            this.txtG1LName.Location = new System.Drawing.Point(124, 138);
            this.txtG1LName.Name = "txtG1LName";
            this.txtG1LName.Size = new System.Drawing.Size(100, 20);
            this.txtG1LName.TabIndex = 11;
            // 
            // txtG1FName
            // 
            this.txtG1FName.Location = new System.Drawing.Point(18, 138);
            this.txtG1FName.Name = "txtG1FName";
            this.txtG1FName.Size = new System.Drawing.Size(100, 20);
            this.txtG1FName.TabIndex = 10;
            // 
            // lblPlayerRank
            // 
            this.lblPlayerRank.AutoSize = true;
            this.lblPlayerRank.Location = new System.Drawing.Point(457, 110);
            this.lblPlayerRank.Name = "lblPlayerRank";
            this.lblPlayerRank.Size = new System.Drawing.Size(65, 13);
            this.lblPlayerRank.TabIndex = 9;
            this.lblPlayerRank.Text = "Player Rank";
            // 
            // lblGameScore
            // 
            this.lblGameScore.AutoSize = true;
            this.lblGameScore.Location = new System.Drawing.Point(344, 110);
            this.lblGameScore.Name = "lblGameScore";
            this.lblGameScore.Size = new System.Drawing.Size(89, 13);
            this.lblGameScore.TabIndex = 8;
            this.lblGameScore.Text = "Last Game Score";
            // 
            // lblHandicap
            // 
            this.lblHandicap.AutoSize = true;
            this.lblHandicap.Location = new System.Drawing.Point(246, 110);
            this.lblHandicap.Name = "lblHandicap";
            this.lblHandicap.Size = new System.Drawing.Size(53, 13);
            this.lblHandicap.TabIndex = 7;
            this.lblHandicap.Text = "Handicap";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(144, 110);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(36, 110);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // lblTeamRank
            // 
            this.lblTeamRank.AutoSize = true;
            this.lblTeamRank.Location = new System.Drawing.Point(269, 69);
            this.lblTeamRank.Name = "lblTeamRank";
            this.lblTeamRank.Size = new System.Drawing.Size(66, 13);
            this.lblTeamRank.TabIndex = 4;
            this.lblTeamRank.Text = "Team Rank:";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(65, 69);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(68, 13);
            this.lblTeamName.TabIndex = 3;
            this.lblTeamName.Text = "Team Name:";
            // 
            // txtTeamRank
            // 
            this.txtTeamRank.Location = new System.Drawing.Point(341, 66);
            this.txtTeamRank.Name = "txtTeamRank";
            this.txtTeamRank.Size = new System.Drawing.Size(100, 20);
            this.txtTeamRank.TabIndex = 2;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(139, 66);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(100, 20);
            this.txtTeamName.TabIndex = 1;
            // 
            // cboxTeams
            // 
            this.cboxTeams.FormattingEnabled = true;
            this.cboxTeams.Location = new System.Drawing.Point(118, 22);
            this.cboxTeams.Name = "cboxTeams";
            this.cboxTeams.Size = new System.Drawing.Size(121, 21);
            this.cboxTeams.TabIndex = 0;
            this.cboxTeams.SelectedIndexChanged += new System.EventHandler(this.cboxTeams_SelectedIndexChanged);
            // 
            // tabDisplayTeam
            // 
            this.tabDisplayTeam.Controls.Add(this.treeView1);
            this.tabDisplayTeam.Location = new System.Drawing.Point(4, 22);
            this.tabDisplayTeam.Name = "tabDisplayTeam";
            this.tabDisplayTeam.Size = new System.Drawing.Size(558, 300);
            this.tabDisplayTeam.TabIndex = 2;
            this.tabDisplayTeam.Text = "Display Teams";
            this.tabDisplayTeam.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(346, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 29);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(341, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 29);
            this.btnExport.TabIndex = 34;
            this.btnExport.Text = "Export Team";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(552, 294);
            this.treeView1.TabIndex = 0;
            // 
            // GolfLeague_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 344);
            this.Controls.Add(this.Tab_Control);
            this.Name = "GolfLeague_Form";
            this.Text = "CreateTeam_Form";
            this.Tab_Control.ResumeLayout(false);
            this.tabCreateTeam.ResumeLayout(false);
            this.tabCreateTeam.PerformLayout();
            this.tabDisplayTeam.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Control;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.TabPage tabCreateTeam;
        private System.Windows.Forms.TabPage tabDisplayTeam;
        private System.Windows.Forms.ComboBox cboxTeams;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTeamRank;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox txtTeamRank;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblPlayerRank;
        private System.Windows.Forms.Label lblGameScore;
        private System.Windows.Forms.Label lblHandicap;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtG4Rank;
        private System.Windows.Forms.TextBox txtG4GameScore;
        private System.Windows.Forms.TextBox txtG4Handicap;
        private System.Windows.Forms.TextBox txtG4LName;
        private System.Windows.Forms.TextBox txtG4FName;
        private System.Windows.Forms.TextBox txtG3Rank;
        private System.Windows.Forms.TextBox txtG3GameScore;
        private System.Windows.Forms.TextBox txtG3Handicap;
        private System.Windows.Forms.TextBox txtG3LName;
        private System.Windows.Forms.TextBox txtG3FName;
        private System.Windows.Forms.TextBox txtG2Rank;
        private System.Windows.Forms.TextBox txtG2GameScore;
        private System.Windows.Forms.TextBox txtG2Handicap;
        private System.Windows.Forms.TextBox txtG2LName;
        private System.Windows.Forms.TextBox txtG2FName;
        private System.Windows.Forms.TextBox txtG1Rank;
        private System.Windows.Forms.TextBox txtG1GameScore;
        private System.Windows.Forms.TextBox txtG1Handicap;
        private System.Windows.Forms.TextBox txtG1LName;
        private System.Windows.Forms.TextBox txtG1FName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TreeView treeView1;
    }
}