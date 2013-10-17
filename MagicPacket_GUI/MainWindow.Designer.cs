namespace MagicPacket_GUI
{
    partial class MainWindow
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
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.wakeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(15, 29);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(213, 20);
            this.destinationTextBox.TabIndex = 0;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(12, 13);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(130, 13);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Destination MAC Address:";
            // 
            // wakeButton
            // 
            this.wakeButton.Location = new System.Drawing.Point(234, 27);
            this.wakeButton.Name = "wakeButton";
            this.wakeButton.Size = new System.Drawing.Size(75, 23);
            this.wakeButton.TabIndex = 2;
            this.wakeButton.Text = "Wake";
            this.wakeButton.UseVisualStyleBackColor = true;
            this.wakeButton.Click += new System.EventHandler(this.wakeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(233, 89);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(13, 56);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(56, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "statusText";
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(320, 124);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.wakeButton);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Name = "MainWindow";
            this.Text = "Magic Packet";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Button wakeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label statusLabel;
    }
}

