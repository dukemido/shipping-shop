namespace Shop
{
    partial class CustomerResults
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
            this.Results = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.Location = new System.Drawing.Point(12, 8);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(917, 303);
            this.Results.TabIndex = 0;
            this.Results.SelectedIndexChanged += new System.EventHandler(this.Results_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(917, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(941, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Results);
            this.MaximizeBox = false;
            this.Name = "CustomerResults";
            this.Text = "CustomerResults";
            this.Load += new System.EventHandler(this.CustomerResults_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Button button1;
    }
}