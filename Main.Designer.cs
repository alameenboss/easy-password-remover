namespace PdfPasswordRemover
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonRemovePassword = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.labelTypePassword = new System.Windows.Forms.Label();
            this.saveInSameFolderCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
           
            this.buttonRemovePassword.Enabled = false;
            this.buttonRemovePassword.Location = new System.Drawing.Point(12, 188);
            this.buttonRemovePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemovePassword.Name = "buttonRemovePassword";
            this.buttonRemovePassword.Size = new System.Drawing.Size(267, 36);
            this.buttonRemovePassword.TabIndex = 0;
            this.buttonRemovePassword.Text = "Remove password from PDF file";
            this.buttonRemovePassword.UseVisualStyleBackColor = true;
            this.buttonRemovePassword.Click += new System.EventHandler(this.buttonRemovePassword_Click);
           
            this.textBoxPassword.Location = new System.Drawing.Point(13, 41);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(267, 27);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
           
            this.buttonShowPassword.Location = new System.Drawing.Point(13, 92);
            this.buttonShowPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(267, 36);
            this.buttonShowPassword.TabIndex = 4;
            this.buttonShowPassword.Text = "Show password";
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.Click += new System.EventHandler(this.buttonShowPassword_Click);
         
            this.labelTypePassword.AutoSize = true;
            this.labelTypePassword.Location = new System.Drawing.Point(13, 9);
            this.labelTypePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypePassword.Name = "labelTypePassword";
            this.labelTypePassword.Size = new System.Drawing.Size(126, 20);
            this.labelTypePassword.TabIndex = 6;
            this.labelTypePassword.Text = "Type in password:";
          
            this.saveInSameFolderCheckbox.AutoSize = true;
            this.saveInSameFolderCheckbox.Checked = true;
            this.saveInSameFolderCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveInSameFolderCheckbox.Location = new System.Drawing.Point(12, 136);
            this.saveInSameFolderCheckbox.Name = "saveInSameFolderCheckbox";
            this.saveInSameFolderCheckbox.Size = new System.Drawing.Size(261, 44);
            this.saveInSameFolderCheckbox.TabIndex = 7;
            this.saveInSameFolderCheckbox.Text = "Save in the same folder \r\nand append \"_unlocked\" to the file";
            this.saveInSameFolderCheckbox.UseVisualStyleBackColor = true;
        
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 238);
            this.Controls.Add(this.saveInSameFolderCheckbox);
            this.Controls.Add(this.buttonRemovePassword);
            this.Controls.Add(this.buttonShowPassword);
            this.Controls.Add(this.labelTypePassword);
            this.Controls.Add(this.textBoxPassword);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PdfPasswordRemover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonRemovePassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonShowPassword;
        private System.Windows.Forms.Label labelTypePassword;
        private CheckBox saveInSameFolderCheckbox;
    }
}