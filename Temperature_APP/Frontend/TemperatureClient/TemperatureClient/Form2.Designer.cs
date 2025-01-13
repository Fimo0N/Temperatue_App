namespace TemperatureClient
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.thresholdTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.buttonThreshold = new System.Windows.Forms.Button();
            this.buttonMinMax = new System.Windows.Forms.Button();
            this.buttonMinTempsYear = new System.Windows.Forms.Button();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // listBox1
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(30, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 320);
            this.listBox1.TabIndex = 0;

            // thresholdTextBox
            this.thresholdTextBox.Location = new System.Drawing.Point(500, 50);
            this.thresholdTextBox.Name = "thresholdTextBox";
            this.thresholdTextBox.Size = new System.Drawing.Size(100, 22);
            this.thresholdTextBox.TabIndex = 1;

            // yearTextBox
            this.yearTextBox.Location = new System.Drawing.Point(500, 100);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 22);
            this.yearTextBox.TabIndex = 2;

            // buttonThreshold
            this.buttonThreshold.Location = new System.Drawing.Point(500, 150);
            this.buttonThreshold.Name = "buttonThreshold";
            this.buttonThreshold.Size = new System.Drawing.Size(150, 30);
            this.buttonThreshold.TabIndex = 3;
            this.buttonThreshold.Text = "Get Records Above Threshold";
            this.buttonThreshold.UseVisualStyleBackColor = true;
            this.buttonThreshold.Click += new System.EventHandler(this.buttonThreshold_Click);

            // buttonMinMax
            this.buttonMinMax.Location = new System.Drawing.Point(500, 200);
            this.buttonMinMax.Name = "buttonMinMax";
            this.buttonMinMax.Size = new System.Drawing.Size(150, 30);
            this.buttonMinMax.TabIndex = 4;
            this.buttonMinMax.Text = "Get Min and Max Temp";
            this.buttonMinMax.UseVisualStyleBackColor = true;
            this.buttonMinMax.Click += new System.EventHandler(this.buttonMinMax_Click);

            // buttonMinTempsYear
            this.buttonMinTempsYear.Location = new System.Drawing.Point(500, 250);
            this.buttonMinTempsYear.Name = "buttonMinTempsYear";
            this.buttonMinTempsYear.Size = new System.Drawing.Size(150, 30);
            this.buttonMinTempsYear.TabIndex = 5;
            this.buttonMinTempsYear.Text = "Get Min Temps by Year";
            this.buttonMinTempsYear.UseVisualStyleBackColor = true;
            this.buttonMinTempsYear.Click += new System.EventHandler(this.buttonMinTempsYear_Click);

            // labelThreshold
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Location = new System.Drawing.Point(500, 30);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(114, 17);
            this.labelThreshold.TabIndex = 6;
            this.labelThreshold.Text = "Temperature Threshold:";

            // labelYear
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(500, 80);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(94, 17);
            this.labelYear.TabIndex = 7;
            this.labelYear.Text = "Enter Year:";

            // Form2
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelThreshold);
            this.Controls.Add(this.buttonMinTempsYear);
            this.Controls.Add(this.buttonMinMax);
            this.Controls.Add(this.buttonThreshold);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.thresholdTextBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Temperature Data";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox thresholdTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button buttonThreshold;
        private System.Windows.Forms.Button buttonMinMax;
        private System.Windows.Forms.Button buttonMinTempsYear;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.Label labelYear;
    }
}
