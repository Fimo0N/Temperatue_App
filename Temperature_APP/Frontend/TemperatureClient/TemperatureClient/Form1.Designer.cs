namespace items
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox rvalueTextBox;
        private System.Windows.Forms.TextBox rtypeTextBox;
        private System.Windows.Forms.TextBox rdateTextBox;
        private System.Windows.Forms.TextBox placeidTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonFetchRecords;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label rvalueLabel;
        private System.Windows.Forms.Label rtypeLabel;
        private System.Windows.Forms.Label rdateLabel;
        private System.Windows.Forms.Label placeidLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;

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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.rvalueTextBox = new System.Windows.Forms.TextBox();
            this.rtypeTextBox = new System.Windows.Forms.TextBox();
            this.rdateTextBox = new System.Windows.Forms.TextBox();
            this.placeidTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonFetchRecords = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.rvalueLabel = new System.Windows.Forms.Label();
            this.rtypeLabel = new System.Windows.Forms.Label();
            this.rdateLabel = new System.Windows.Forms.Label();
            this.placeidLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(20, 20);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 30);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // rvalueTextBox
            // 
            this.rvalueTextBox.Location = new System.Drawing.Point(20, 90);
            this.rvalueTextBox.Name = "rvalueTextBox";
            this.rvalueTextBox.Size = new System.Drawing.Size(200, 26);
            this.rvalueTextBox.TabIndex = 2;
            // 
            // rtypeTextBox
            // 
            this.rtypeTextBox.Location = new System.Drawing.Point(20, 150);
            this.rtypeTextBox.Name = "rtypeTextBox";
            this.rtypeTextBox.Size = new System.Drawing.Size(200, 26);
            this.rtypeTextBox.TabIndex = 4;
            // 
            // rdateTextBox
            // 
            this.rdateTextBox.Location = new System.Drawing.Point(20, 210);
            this.rdateTextBox.Name = "rdateTextBox";
            this.rdateTextBox.Size = new System.Drawing.Size(200, 26);
            this.rdateTextBox.TabIndex = 6;
            // 
            // placeidTextBox
            // 
            this.placeidTextBox.Location = new System.Drawing.Point(20, 270);
            this.placeidTextBox.Name = "placeidTextBox";
            this.placeidTextBox.Size = new System.Drawing.Size(200, 26);
            this.placeidTextBox.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(250, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 184);
            this.listBox1.TabIndex = 9;
            // 
            // buttonFetchRecords
            // 
            this.buttonFetchRecords.Location = new System.Drawing.Point(20, 310);
            this.buttonFetchRecords.Name = "buttonFetchRecords";
            this.buttonFetchRecords.Size = new System.Drawing.Size(120, 30);
            this.buttonFetchRecords.TabIndex = 10;
            this.buttonFetchRecords.Text = "Fetch Records";
            this.buttonFetchRecords.UseVisualStyleBackColor = true;
            this.buttonFetchRecords.Click += new System.EventHandler(this.buttonFetchRecords_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(20, 350);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(120, 30);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "Create Record";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(20, 390);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(120, 30);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update Record";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(20, 430);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 30);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete Record";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // rvalueLabel
            // 
            this.rvalueLabel.AutoSize = true;
            this.rvalueLabel.Location = new System.Drawing.Point(20, 70);
            this.rvalueLabel.Name = "rvalueLabel";
            this.rvalueLabel.Size = new System.Drawing.Size(97, 20);
            this.rvalueLabel.TabIndex = 1;
            this.rvalueLabel.Text = "Enter Value:";
            // 
            // rtypeLabel
            // 
            this.rtypeLabel.AutoSize = true;
            this.rtypeLabel.Location = new System.Drawing.Point(20, 130);
            this.rtypeLabel.Name = "rtypeLabel";
            this.rtypeLabel.Size = new System.Drawing.Size(90, 20);
            this.rtypeLabel.TabIndex = 3;
            this.rtypeLabel.Text = "Enter Type:";
            // 
            // rdateLabel
            // 
            this.rdateLabel.AutoSize = true;
            this.rdateLabel.Location = new System.Drawing.Point(20, 190);
            this.rdateLabel.Name = "rdateLabel";
            this.rdateLabel.Size = new System.Drawing.Size(91, 20);
            this.rdateLabel.TabIndex = 5;
            this.rdateLabel.Text = "Enter Date:";
            // 
            // placeidLabel
            // 
            this.placeidLabel.AutoSize = true;
            this.placeidLabel.Location = new System.Drawing.Point(20, 250);
            this.placeidLabel.Name = "placeidLabel";
            this.placeidLabel.Size = new System.Drawing.Size(116, 20);
            this.placeidLabel.TabIndex = 7;
            this.placeidLabel.Text = "Enter Place ID:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(160, 20);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 20);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(180, 20);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 125);
            this.button1.TabIndex = 14;
            this.button1.Text = "Queries";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.rvalueTextBox);
            this.Controls.Add(this.rtypeTextBox);
            this.Controls.Add(this.rdateTextBox);
            this.Controls.Add(this.placeidTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonFetchRecords);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.rvalueLabel);
            this.Controls.Add(this.rtypeLabel);
            this.Controls.Add(this.rdateLabel);
            this.Controls.Add(this.placeidLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "Form1";
            this.Text = "CRUD Operations Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}
