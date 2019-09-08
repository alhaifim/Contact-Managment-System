namespace ContactsManager
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.aboutOKButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contactManagmentLabel = new System.Windows.Forms.Label();
            this.helpCopyRightlablel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutOKButton
            // 
            this.aboutOKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutOKButton.Location = new System.Drawing.Point(490, 377);
            this.aboutOKButton.Name = "aboutOKButton";
            this.aboutOKButton.Size = new System.Drawing.Size(71, 20);
            this.aboutOKButton.TabIndex = 0;
            this.aboutOKButton.Text = "OK";
            this.aboutOKButton.UseVisualStyleBackColor = true;
            this.aboutOKButton.Click += new System.EventHandler(this.aboutOKButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(21, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(529, 246);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // contactManagmentLabel
            // 
            this.contactManagmentLabel.AutoSize = true;
            this.contactManagmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactManagmentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.contactManagmentLabel.Location = new System.Drawing.Point(37, 19);
            this.contactManagmentLabel.Name = "contactManagmentLabel";
            this.contactManagmentLabel.Size = new System.Drawing.Size(171, 20);
            this.contactManagmentLabel.TabIndex = 2;
            this.contactManagmentLabel.Text = "Contact Managment";
            // 
            // helpCopyRightlablel
            // 
            this.helpCopyRightlablel.AutoSize = true;
            this.helpCopyRightlablel.Location = new System.Drawing.Point(21, 339);
            this.helpCopyRightlablel.Name = "helpCopyRightlablel";
            this.helpCopyRightlablel.Size = new System.Drawing.Size(178, 13);
            this.helpCopyRightlablel.TabIndex = 3;
            this.helpCopyRightlablel.Text = "Copy rights @ 2019 Qualitywebapps";
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 409);
            this.Controls.Add(this.helpCopyRightlablel);
            this.Controls.Add(this.contactManagmentLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.aboutOKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "aboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aboutOKButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label contactManagmentLabel;
        private System.Windows.Forms.Label helpCopyRightlablel;
    }
}