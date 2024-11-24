namespace RhythmGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.linePictureBox = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.judgmentPictureBox = new System.Windows.Forms.PictureBox();
            this.key4Button = new System.Windows.Forms.Button();
            this.key3Button = new System.Windows.Forms.Button();
            this.key2Button = new System.Windows.Forms.Button();
            this.key1Button = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linePictureBox)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.judgmentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.scoreLabel);
            this.topPanel.Controls.Add(this.linePictureBox);
            this.topPanel.Controls.Add(this.homeButton);
            this.topPanel.Controls.Add(this.settingsButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(464, 86);
            this.topPanel.TabIndex = 5;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.scoreLabel.Location = new System.Drawing.Point(119, 20);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(226, 37);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "99999999999";
            // 
            // linePictureBox
            // 
            this.linePictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("linePictureBox.Image")));
            this.linePictureBox.Location = new System.Drawing.Point(0, 81);
            this.linePictureBox.Name = "linePictureBox";
            this.linePictureBox.Size = new System.Drawing.Size(464, 5);
            this.linePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.linePictureBox.TabIndex = 7;
            this.linePictureBox.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.homeButton.BackColor = System.Drawing.Color.White;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.homeButton.ForeColor = System.Drawing.Color.Transparent;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(391, 18);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(50, 39);
            this.homeButton.TabIndex = 6;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.settingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.settingsButton.ForeColor = System.Drawing.Color.Transparent;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(22, 18);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(50, 39);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.judgmentPictureBox);
            this.bottomPanel.Controls.Add(this.key4Button);
            this.bottomPanel.Controls.Add(this.key3Button);
            this.bottomPanel.Controls.Add(this.key2Button);
            this.bottomPanel.Controls.Add(this.key1Button);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 694);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(464, 67);
            this.bottomPanel.TabIndex = 6;
            // 
            // judgmentPictureBox
            // 
            this.judgmentPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.judgmentPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("judgmentPictureBox.Image")));
            this.judgmentPictureBox.Location = new System.Drawing.Point(0, 0);
            this.judgmentPictureBox.Name = "judgmentPictureBox";
            this.judgmentPictureBox.Size = new System.Drawing.Size(464, 5);
            this.judgmentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.judgmentPictureBox.TabIndex = 16;
            this.judgmentPictureBox.TabStop = false;
            // 
            // key4Button
            // 
            this.key4Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key4Button.Location = new System.Drawing.Point(351, 10);
            this.key4Button.Name = "key4Button";
            this.key4Button.Size = new System.Drawing.Size(110, 53);
            this.key4Button.TabIndex = 15;
            this.key4Button.Text = "F";
            this.key4Button.UseVisualStyleBackColor = true;
            // 
            // key3Button
            // 
            this.key3Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key3Button.Location = new System.Drawing.Point(235, 10);
            this.key3Button.Name = "key3Button";
            this.key3Button.Size = new System.Drawing.Size(110, 53);
            this.key3Button.TabIndex = 11;
            this.key3Button.Text = "D";
            this.key3Button.UseVisualStyleBackColor = true;
            // 
            // key2Button
            // 
            this.key2Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key2Button.Location = new System.Drawing.Point(119, 10);
            this.key2Button.Name = "key2Button";
            this.key2Button.Size = new System.Drawing.Size(110, 53);
            this.key2Button.TabIndex = 10;
            this.key2Button.Text = "S";
            this.key2Button.UseVisualStyleBackColor = true;
            // 
            // key1Button
            // 
            this.key1Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key1Button.Location = new System.Drawing.Point(3, 10);
            this.key1Button.Name = "key1Button";
            this.key1Button.Size = new System.Drawing.Size(110, 53);
            this.key1Button.TabIndex = 9;
            this.key1Button.Text = "A";
            this.key1Button.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 761);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.Text = "Rhythm Game";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linePictureBox)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.judgmentPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.PictureBox linePictureBox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button key1Button;
        private System.Windows.Forms.Button key4Button;
        private System.Windows.Forms.Button key3Button;
        private System.Windows.Forms.Button key2Button;
        private System.Windows.Forms.PictureBox judgmentPictureBox;
    }
}