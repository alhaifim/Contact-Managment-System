namespace ContactsManager
{
    partial class searchForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.searchLastNameTextBox = new System.Windows.Forms.TextBox();
            this.searchFirstNameLabel = new System.Windows.Forms.Label();
            this.searchLastNameLabel = new System.Windows.Forms.Label();
            this.searchFormCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(229, 121);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(97, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchFirstNameTextBox
            // 
            this.searchFirstNameTextBox.Location = new System.Drawing.Point(134, 21);
            this.searchFirstNameTextBox.Name = "searchFirstNameTextBox";
            this.searchFirstNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.searchFirstNameTextBox.TabIndex = 1;
            this.searchFirstNameTextBox.TextChanged += new System.EventHandler(this.searchFirstNameTextBox_TextChanged);
            // 
            // searchLastNameTextBox
            // 
            this.searchLastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLastNameTextBox.Location = new System.Drawing.Point(134, 62);
            this.searchLastNameTextBox.Name = "searchLastNameTextBox";
            this.searchLastNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.searchLastNameTextBox.TabIndex = 2;
            this.searchLastNameTextBox.TextChanged += new System.EventHandler(this.searchLastNameTextBox_TextChanged);
            // 
            // searchFirstNameLabel
            // 
            this.searchFirstNameLabel.AutoSize = true;
            this.searchFirstNameLabel.Location = new System.Drawing.Point(39, 21);
            this.searchFirstNameLabel.Name = "searchFirstNameLabel";
            this.searchFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.searchFirstNameLabel.TabIndex = 3;
            this.searchFirstNameLabel.Text = "First Name";
            // 
            // searchLastNameLabel
            // 
            this.searchLastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchLastNameLabel.AutoSize = true;
            this.searchLastNameLabel.Location = new System.Drawing.Point(39, 69);
            this.searchLastNameLabel.Name = "searchLastNameLabel";
            this.searchLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.searchLastNameLabel.TabIndex = 4;
            this.searchLastNameLabel.Text = "Last Name";
            // 
            // searchFormCancelButton
            // 
            this.searchFormCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFormCancelButton.Location = new System.Drawing.Point(117, 121);
            this.searchFormCancelButton.Name = "searchFormCancelButton";
            this.searchFormCancelButton.Size = new System.Drawing.Size(97, 23);
            this.searchFormCancelButton.TabIndex = 5;
            this.searchFormCancelButton.Text = "Cancel";
            this.searchFormCancelButton.UseVisualStyleBackColor = true;
            this.searchFormCancelButton.Click += new System.EventHandler(this.searchFormCancelButton_Click);
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 171);
            this.Controls.Add(this.searchFormCancelButton);
            this.Controls.Add(this.searchLastNameLabel);
            this.Controls.Add(this.searchFirstNameLabel);
            this.Controls.Add(this.searchLastNameTextBox);
            this.Controls.Add(this.searchFirstNameTextBox);
            this.Controls.Add(this.searchButton);
            this.Name = "searchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchForm";
            this.Load += new System.EventHandler(this.searchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchFirstNameTextBox;
        private System.Windows.Forms.TextBox searchLastNameTextBox;
        private System.Windows.Forms.Label searchFirstNameLabel;
        private System.Windows.Forms.Label searchLastNameLabel;
        private System.Windows.Forms.Button searchFormCancelButton;
    }
}