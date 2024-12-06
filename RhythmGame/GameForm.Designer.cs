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
            this.lane4KeyButton = new System.Windows.Forms.Button();
            this.lane3KeyButton = new System.Windows.Forms.Button();
            this.lane2KeyButton = new System.Windows.Forms.Button();
            this.lane1KeyButton = new System.Windows.Forms.Button();
            this.judgmentTopPictureBox = new System.Windows.Forms.PictureBox();
            this.judgmentBottomPictureBox = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linePictureBox)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.judgmentTopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgmentBottomPictureBox)).BeginInit();
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
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.scoreLabel.Location = new System.Drawing.Point(119, 20);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(226, 37);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "99999999999";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Controls.Add(this.lane4KeyButton);
            this.bottomPanel.Controls.Add(this.lane3KeyButton);
            this.bottomPanel.Controls.Add(this.lane2KeyButton);
            this.bottomPanel.Controls.Add(this.lane1KeyButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 690);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(464, 71);
            this.bottomPanel.TabIndex = 6;
            // 
            // lane4KeyButton
            // 
            this.lane4KeyButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lane4KeyButton.Location = new System.Drawing.Point(351, 10);
            this.lane4KeyButton.Name = "lane4KeyButton";
            this.lane4KeyButton.Size = new System.Drawing.Size(110, 53);
            this.lane4KeyButton.TabIndex = 15;
            this.lane4KeyButton.Text = "F";
            this.lane4KeyButton.UseVisualStyleBackColor = true;
            // 
            // lane3KeyButton
            // 
            this.lane3KeyButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lane3KeyButton.Location = new System.Drawing.Point(235, 10);
            this.lane3KeyButton.Name = "lane3KeyButton";
            this.lane3KeyButton.Size = new System.Drawing.Size(110, 53);
            this.lane3KeyButton.TabIndex = 11;
            this.lane3KeyButton.Text = "D";
            this.lane3KeyButton.UseVisualStyleBackColor = true;
            // 
            // lane2KeyButton
            // 
            this.lane2KeyButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lane2KeyButton.Location = new System.Drawing.Point(119, 10);
            this.lane2KeyButton.Name = "lane2KeyButton";
            this.lane2KeyButton.Size = new System.Drawing.Size(110, 53);
            this.lane2KeyButton.TabIndex = 10;
            this.lane2KeyButton.Text = "S";
            this.lane2KeyButton.UseVisualStyleBackColor = true;
            // 
            // lane1KeyButton
            // 
            this.lane1KeyButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lane1KeyButton.Location = new System.Drawing.Point(3, 10);
            this.lane1KeyButton.Name = "lane1KeyButton";
            this.lane1KeyButton.Size = new System.Drawing.Size(110, 53);
            this.lane1KeyButton.TabIndex = 9;
            this.lane1KeyButton.Text = "A";
            this.lane1KeyButton.UseVisualStyleBackColor = true;
            // 
            // judgmentTopPictureBox
            // 
            this.judgmentTopPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("judgmentTopPictureBox.Image")));
            this.judgmentTopPictureBox.Location = new System.Drawing.Point(0, 650);
            this.judgmentTopPictureBox.Name = "judgmentTopPictureBox";
            this.judgmentTopPictureBox.Size = new System.Drawing.Size(464, 5);
            this.judgmentTopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.judgmentTopPictureBox.TabIndex = 11;
            this.judgmentTopPictureBox.TabStop = false;
            // 
            // judgmentBottomPictureBox
            // 
            this.judgmentBottomPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.judgmentBottomPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("judgmentBottomPictureBox.Image")));
            this.judgmentBottomPictureBox.Location = new System.Drawing.Point(0, 685);
            this.judgmentBottomPictureBox.Name = "judgmentBottomPictureBox";
            this.judgmentBottomPictureBox.Size = new System.Drawing.Size(464, 5);
            this.judgmentBottomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.judgmentBottomPictureBox.TabIndex = 10;
            this.judgmentBottomPictureBox.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 761);
            this.Controls.Add(this.judgmentTopPictureBox);
            this.Controls.Add(this.judgmentBottomPictureBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.Text = "Rhythm Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linePictureBox)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.judgmentTopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgmentBottomPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.PictureBox linePictureBox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button lane1KeyButton;
        private System.Windows.Forms.Button lane4KeyButton;
        private System.Windows.Forms.Button lane3KeyButton;
        private System.Windows.Forms.Button lane2KeyButton;
        private System.Windows.Forms.PictureBox judgmentBottomPictureBox;
        private System.Windows.Forms.PictureBox judgmentTopPictureBox;
    }
}