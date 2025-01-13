namespace items
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;

        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.rvalueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(148, 203);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 67);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(148, 94);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(200, 26);
            this.usernameText.TabIndex = 1;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(148, 146);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(200, 26);
            this.passwordText.TabIndex = 2;
            // 
            // rvalueLabel
            // 
            this.rvalueLabel.AutoSize = true;
            this.rvalueLabel.Location = new System.Drawing.Point(31, 97);
            this.rvalueLabel.Name = "rvalueLabel";
            this.rvalueLabel.Size = new System.Drawing.Size(97, 20);
            this.rvalueLabel.TabIndex = 3;
            this.rvalueLabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rvalueLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.passwordText);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label rvalueLabel;
        private System.Windows.Forms.Label label1;
    }
}
