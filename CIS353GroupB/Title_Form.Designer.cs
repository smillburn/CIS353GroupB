
namespace CIS353GroupB
{
    partial class Title_Form
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
            this.Import_btn = new System.Windows.Forms.Button();
            this.StartNew_button = new System.Windows.Forms.Button();
            this.Title_label = new System.Windows.Forms.Label();
            this.Display_btn = new System.Windows.Forms.Button();
            this.Export_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Import_btn
            // 
            this.Import_btn.Location = new System.Drawing.Point(352, 150);
            this.Import_btn.Name = "Import_btn";
            this.Import_btn.Size = new System.Drawing.Size(112, 23);
            this.Import_btn.TabIndex = 3;
            this.Import_btn.Text = "Import Teams";
            this.Import_btn.UseVisualStyleBackColor = true;
            this.Import_btn.Click += new System.EventHandler(this.Import_btn_Click);
            // 
            // StartNew_button
            // 
            this.StartNew_button.Location = new System.Drawing.Point(352, 100);
            this.StartNew_button.Name = "StartNew_button";
            this.StartNew_button.Size = new System.Drawing.Size(112, 23);
            this.StartNew_button.TabIndex = 2;
            this.StartNew_button.Text = "Start New Teams";
            this.StartNew_button.UseVisualStyleBackColor = true;
            this.StartNew_button.Click += new System.EventHandler(this.StartNew_button_Click);
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Title_label.Location = new System.Drawing.Point(338, 59);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(137, 15);
            this.Title_label.TabIndex = 1;
            this.Title_label.Text = "Golf League Tournament";
            // 
            // Display_btn
            // 
            this.Display_btn.Location = new System.Drawing.Point(352, 200);
            this.Display_btn.Name = "Display_btn";
            this.Display_btn.Size = new System.Drawing.Size(112, 23);
            this.Display_btn.TabIndex = 4;
            this.Display_btn.Text = "Display Teams";
            this.Display_btn.UseVisualStyleBackColor = true;
            this.Display_btn.Click += new System.EventHandler(this.Display_btn_Click);
            // 
            // Export_btn
            // 
            this.Export_btn.Location = new System.Drawing.Point(352, 250);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(112, 23);
            this.Export_btn.TabIndex = 5;
            this.Export_btn.Text = "Export Teams";
            this.Export_btn.UseVisualStyleBackColor = true;
            this.Export_btn.Click += new System.EventHandler(this.Export_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(352, 300);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(112, 23);
            this.Exit_btn.TabIndex = 6;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Title_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 487);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Export_btn);
            this.Controls.Add(this.Display_btn);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.StartNew_button);
            this.Controls.Add(this.Import_btn);
            this.Name = "Title_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Title_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Import_btn;
        private System.Windows.Forms.Button StartNew_button;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Button Display_btn;
        private System.Windows.Forms.Button Export_btn;
        private System.Windows.Forms.Button Exit_btn;
    }
}

