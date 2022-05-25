namespace WeightApp
{
    partial class Form1
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
            this.WelcomeTextbox = new System.Windows.Forms.TextBox();
            this.SelfWeightBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.earthWeight = new System.Windows.Forms.Label();
            this.marsWeight = new System.Windows.Forms.Label();
            this.clearWeight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeTextbox
            // 
            this.WelcomeTextbox.Location = new System.Drawing.Point(83, 12);
            this.WelcomeTextbox.Name = "WelcomeTextbox";
            this.WelcomeTextbox.Size = new System.Drawing.Size(629, 20);
            this.WelcomeTextbox.TabIndex = 0;
            this.WelcomeTextbox.Text = "Check your weight on Mars!";
            this.WelcomeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WelcomeTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SelfWeightBox
            // 
            this.SelfWeightBox.Location = new System.Drawing.Point(320, 150);
            this.SelfWeightBox.Multiline = true;
            this.SelfWeightBox.Name = "SelfWeightBox";
            this.SelfWeightBox.Size = new System.Drawing.Size(195, 31);
            this.SelfWeightBox.TabIndex = 1;
            this.SelfWeightBox.TextChanged += new System.EventHandler(this.SelfWeightBox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(320, 288);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(195, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Click to Calculate Weight!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // earthWeight
            // 
            this.earthWeight.AutoSize = true;
            this.earthWeight.Location = new System.Drawing.Point(135, 168);
            this.earthWeight.Name = "earthWeight";
            this.earthWeight.Size = new System.Drawing.Size(179, 13);
            this.earthWeight.TabIndex = 4;
            this.earthWeight.Text = "Enter Your Weight (On Earth in LBS)";
            this.earthWeight.Click += new System.EventHandler(this.earthWeight_Click);
            // 
            // marsWeight
            // 
            this.marsWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marsWeight.AutoSize = true;
            this.marsWeight.Location = new System.Drawing.Point(162, 298);
            this.marsWeight.Name = "marsWeight";
            this.marsWeight.Size = new System.Drawing.Size(123, 13);
            this.marsWeight.TabIndex = 5;
            this.marsWeight.Text = "Your Weight On Mars Is:";
            this.marsWeight.Click += new System.EventHandler(this.marsWeight_Click);
            // 
            // clearWeight
            // 
            this.clearWeight.Location = new System.Drawing.Point(365, 187);
            this.clearWeight.Name = "clearWeight";
            this.clearWeight.Size = new System.Drawing.Size(98, 23);
            this.clearWeight.TabIndex = 6;
            this.clearWeight.Text = "Clear Weight";
            this.clearWeight.UseVisualStyleBackColor = true;
            this.clearWeight.Click += new System.EventHandler(this.clearWeight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearWeight);
            this.Controls.Add(this.marsWeight);
            this.Controls.Add(this.earthWeight);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.SelfWeightBox);
            this.Controls.Add(this.WelcomeTextbox);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WelcomeTextbox;
        private System.Windows.Forms.TextBox SelfWeightBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label earthWeight;
        private System.Windows.Forms.Label marsWeight;
        private System.Windows.Forms.Button clearWeight;
    }
}

