namespace SubtitlesFixUI
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.selectFileLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.newFileLabel = new System.Windows.Forms.Label();
            this.newFileNameTextBox = new System.Windows.Forms.TextBox();
            this.selectNewFileLabel = new System.Windows.Forms.Label();
            this.fixButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.headerLabel.Location = new System.Drawing.Point(303, 27);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(275, 65);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Subtitles Fix!";
            // 
            // browseButton
            // 
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.browseButton.Location = new System.Drawing.Point(708, 172);
            this.browseButton.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(122, 42);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.fileLabel.Location = new System.Drawing.Point(30, 178);
            this.fileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(51, 30);
            this.fileLabel.TabIndex = 7;
            this.fileLabel.Text = "File:";
            // 
            // fileTextBox
            // 
            this.fileTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileTextBox.Location = new System.Drawing.Point(87, 175);
            this.fileTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(600, 34);
            this.fileTextBox.TabIndex = 6;
            // 
            // selectFileLabel
            // 
            this.selectFileLabel.AutoSize = true;
            this.selectFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.selectFileLabel.Location = new System.Drawing.Point(30, 127);
            this.selectFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectFileLabel.Name = "selectFileLabel";
            this.selectFileLabel.Size = new System.Drawing.Size(325, 30);
            this.selectFileLabel.TabIndex = 5;
            this.selectFileLabel.Text = "Select subtitle file to fix (.srt, .txt)";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Subtitle files (*.srt)|*.srt|Text files (*.txt)|*.txt";
            // 
            // newFileLabel
            // 
            this.newFileLabel.AutoSize = true;
            this.newFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.newFileLabel.Location = new System.Drawing.Point(30, 336);
            this.newFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newFileLabel.Name = "newFileLabel";
            this.newFileLabel.Size = new System.Drawing.Size(157, 30);
            this.newFileLabel.TabIndex = 11;
            this.newFileLabel.Text = "New file name:";
            // 
            // newFileNameTextBox
            // 
            this.newFileNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newFileNameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newFileNameTextBox.Location = new System.Drawing.Point(197, 333);
            this.newFileNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newFileNameTextBox.Name = "newFileNameTextBox";
            this.newFileNameTextBox.ReadOnly = true;
            this.newFileNameTextBox.Size = new System.Drawing.Size(493, 34);
            this.newFileNameTextBox.TabIndex = 10;
            // 
            // selectNewFileLabel
            // 
            this.selectNewFileLabel.AutoSize = true;
            this.selectNewFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.selectNewFileLabel.Location = new System.Drawing.Point(30, 285);
            this.selectNewFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectNewFileLabel.Name = "selectNewFileLabel";
            this.selectNewFileLabel.Size = new System.Drawing.Size(660, 30);
            this.selectNewFileLabel.TabIndex = 9;
            this.selectNewFileLabel.Text = "New file name to write fixed subtitles (override if file already exists)";
            // 
            // fixButton
            // 
            this.fixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fixButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.fixButton.Location = new System.Drawing.Point(314, 416);
            this.fixButton.Margin = new System.Windows.Forms.Padding(2);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(252, 61);
            this.fixButton.TabIndex = 12;
            this.fixButton.Text = "Fix Subtitles";
            this.fixButton.UseVisualStyleBackColor = true;
            this.fixButton.Click += new System.EventHandler(this.fixButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(880, 498);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.newFileLabel);
            this.Controls.Add(this.newFileNameTextBox);
            this.Controls.Add(this.selectNewFileLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.selectFileLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subtitle Fix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Button browseButton;
        private Label fileLabel;
        private TextBox fileTextBox;
        private Label selectFileLabel;
        private OpenFileDialog openFileDialog;
        private Label newFileLabel;
        private TextBox newFileNameTextBox;
        private Label selectNewFileLabel;
        private Button fixButton;
    }
}