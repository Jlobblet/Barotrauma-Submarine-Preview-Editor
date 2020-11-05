namespace Barotrauma_Submarine_Preview_Editor
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubmarineGroupBox = new System.Windows.Forms.GroupBox();
            this.SubLocationButton = new System.Windows.Forms.Button();
            this.SubLocationTextBox = new System.Windows.Forms.TextBox();
            this.ImageGroupBox = new System.Windows.Forms.GroupBox();
            this.ImageBrowseButton = new System.Windows.Forms.Button();
            this.ImageLocationTextBox = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.RemoveMainButton = new System.Windows.Forms.Button();
            this.RemoveLinkedButton = new System.Windows.Forms.Button();
            this.SubmarineGroupBox.SuspendLayout();
            this.ImageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmarineGroupBox
            // 
            this.SubmarineGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmarineGroupBox.Controls.Add(this.SubLocationButton);
            this.SubmarineGroupBox.Controls.Add(this.SubLocationTextBox);
            this.SubmarineGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SubmarineGroupBox.Name = "SubmarineGroupBox";
            this.SubmarineGroupBox.Size = new System.Drawing.Size(577, 59);
            this.SubmarineGroupBox.TabIndex = 0;
            this.SubmarineGroupBox.TabStop = false;
            this.SubmarineGroupBox.Text = "Submarine Selection";
            // 
            // SubLocationButton
            // 
            this.SubLocationButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubLocationButton.Location = new System.Drawing.Point(478, 21);
            this.SubLocationButton.Name = "SubLocationButton";
            this.SubLocationButton.Size = new System.Drawing.Size(93, 22);
            this.SubLocationButton.TabIndex = 1;
            this.SubLocationButton.Text = "Browse";
            this.SubLocationButton.UseVisualStyleBackColor = true;
            this.SubLocationButton.Click += new System.EventHandler(this.SubLocationButton_Click);
            // 
            // SubLocationTextBox
            // 
            this.SubLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SubLocationTextBox.Location = new System.Drawing.Point(6, 21);
            this.SubLocationTextBox.Name = "SubLocationTextBox";
            this.SubLocationTextBox.Size = new System.Drawing.Size(466, 22);
            this.SubLocationTextBox.TabIndex = 0;
            // 
            // ImageGroupBox
            // 
            this.ImageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageGroupBox.Controls.Add(this.ImageBrowseButton);
            this.ImageGroupBox.Controls.Add(this.ImageLocationTextBox);
            this.ImageGroupBox.Location = new System.Drawing.Point(12, 77);
            this.ImageGroupBox.Name = "ImageGroupBox";
            this.ImageGroupBox.Size = new System.Drawing.Size(577, 59);
            this.ImageGroupBox.TabIndex = 1;
            this.ImageGroupBox.TabStop = false;
            this.ImageGroupBox.Text = "Image Selection";
            // 
            // ImageBrowseButton
            // 
            this.ImageBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBrowseButton.Location = new System.Drawing.Point(478, 21);
            this.ImageBrowseButton.Name = "ImageBrowseButton";
            this.ImageBrowseButton.Size = new System.Drawing.Size(93, 22);
            this.ImageBrowseButton.TabIndex = 3;
            this.ImageBrowseButton.Text = "Browse";
            this.ImageBrowseButton.UseVisualStyleBackColor = true;
            this.ImageBrowseButton.Click += new System.EventHandler(this.ImageBrowseButton_Click);
            // 
            // ImageLocationTextBox
            // 
            this.ImageLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageLocationTextBox.Location = new System.Drawing.Point(6, 21);
            this.ImageLocationTextBox.Name = "ImageLocationTextBox";
            this.ImageLocationTextBox.Size = new System.Drawing.Size(466, 22);
            this.ImageLocationTextBox.TabIndex = 2;
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.GoButton.Location = new System.Drawing.Point(12, 142);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(188, 41);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Set Main Sub Image";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // RemoveMainButton
            // 
            this.RemoveMainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveMainButton.Location = new System.Drawing.Point(206, 142);
            this.RemoveMainButton.Name = "RemoveMainButton";
            this.RemoveMainButton.Size = new System.Drawing.Size(189, 41);
            this.RemoveMainButton.TabIndex = 5;
            this.RemoveMainButton.Text = "Remove Main Sub Image";
            this.RemoveMainButton.UseVisualStyleBackColor = true;
            this.RemoveMainButton.Click += new System.EventHandler(this.RemoveMainButton_Click);
            // 
            // RemoveLinkedButton
            // 
            this.RemoveLinkedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveLinkedButton.Location = new System.Drawing.Point(401, 142);
            this.RemoveLinkedButton.Name = "RemoveLinkedButton";
            this.RemoveLinkedButton.Size = new System.Drawing.Size(188, 41);
            this.RemoveLinkedButton.TabIndex = 6;
            this.RemoveLinkedButton.Text = "Remove LinkedSub Images";
            this.RemoveLinkedButton.UseVisualStyleBackColor = true;
            this.RemoveLinkedButton.Click += new System.EventHandler(this.RemoveLinkedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 193);
            this.Controls.Add(this.RemoveLinkedButton);
            this.Controls.Add(this.RemoveMainButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.ImageGroupBox);
            this.Controls.Add(this.SubmarineGroupBox);
            this.MinimumSize = new System.Drawing.Size(619, 240);
            this.Name = "Form1";
            this.Text = "Barotrauma Submarine Preview Editor";
            this.SubmarineGroupBox.ResumeLayout(false);
            this.SubmarineGroupBox.PerformLayout();
            this.ImageGroupBox.ResumeLayout(false);
            this.ImageGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button RemoveLinkedButton;
        private System.Windows.Forms.Button RemoveMainButton;

        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button ImageBrowseButton;
        private System.Windows.Forms.GroupBox ImageGroupBox;
        private System.Windows.Forms.TextBox ImageLocationTextBox;
        private System.Windows.Forms.Button SubLocationButton;
        private System.Windows.Forms.TextBox SubLocationTextBox;
        private System.Windows.Forms.GroupBox SubmarineGroupBox;

#endregion
    }
}
