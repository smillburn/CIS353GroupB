
namespace CIS353GroupB
{
    partial class Form1
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
            this.cboxTeams = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstTeam = new System.Windows.Forms.ListView();
            this.Rank = new System.Windows.Forms.ColumnHeader();
            this.fname = new System.Windows.Forms.ColumnHeader();
            this.lname = new System.Windows.Forms.ColumnHeader();
            this.handicap = new System.Windows.Forms.ColumnHeader();
            this.total = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // cboxTeams
            // 
            this.cboxTeams.DisplayMember = "Name";
            this.cboxTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTeams.FormattingEnabled = true;
            this.cboxTeams.Location = new System.Drawing.Point(323, 56);
            this.cboxTeams.Name = "cboxTeams";
            this.cboxTeams.Size = new System.Drawing.Size(121, 23);
            this.cboxTeams.TabIndex = 0;
            this.cboxTeams.SelectedIndexChanged += new System.EventHandler(this.DisplayTeam);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(450, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstTeam
            // 
            this.lstTeam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fname,
            this.lname,
            this.handicap,
            this.total,
            this.Rank});
            this.lstTeam.HideSelection = false;
            this.lstTeam.Location = new System.Drawing.Point(21, 106);
            this.lstTeam.Name = "lstTeam";
            this.lstTeam.Size = new System.Drawing.Size(793, 212);
            this.lstTeam.TabIndex = 2;
            this.lstTeam.UseCompatibleStateImageBehavior = false;
            this.lstTeam.View = System.Windows.Forms.View.Details;
            // 
            // Rank
            // 
            this.Rank.Text = "Rank";
            // 
            // fname
            // 
            this.fname.Text = "First Name";
            // 
            // lname
            // 
            this.lname.Text = "Last Name";
            // 
            // handicap
            // 
            this.handicap.Text = "Handicap";
            // 
            // total
            // 
            this.total.Text = "Last Game Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 487);
            this.Controls.Add(this.lstTeam);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboxTeams);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxTeams;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstTeam;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.ColumnHeader fname;
        private System.Windows.Forms.ColumnHeader lname;
        private System.Windows.Forms.ColumnHeader handicap;
        private System.Windows.Forms.ColumnHeader total;
    }
}

