namespace RhythmGame
{
    partial class SettingsForm
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
            this.settingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.settingsCenterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.keyButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lane4KeyButton = new System.Windows.Forms.Button();
            this.lane3KeyButton = new System.Windows.Forms.Button();
            this.lane2KeyButton = new System.Windows.Forms.Button();
            this.lane1KeyButton = new System.Windows.Forms.Button();
            this.keyboardLabel = new System.Windows.Forms.Label();
            this.musicTrackBar = new System.Windows.Forms.TrackBar();
            this.musicLabel = new System.Windows.Forms.Label();
            this.settingsTableLayoutPanel.SuspendLayout();
            this.settingsCenterTableLayoutPanel.SuspendLayout();
            this.keyButtonTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsTableLayoutPanel
            // 
            this.settingsTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsTableLayoutPanel.ColumnCount = 1;
            this.settingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsTableLayoutPanel.Controls.Add(this.backButton, 0, 2);
            this.settingsTableLayoutPanel.Controls.Add(this.settingsLabel, 0, 0);
            this.settingsTableLayoutPanel.Controls.Add(this.settingsCenterTableLayoutPanel, 0, 1);
            this.settingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsTableLayoutPanel.Name = "settingsTableLayoutPanel";
            this.settingsTableLayoutPanel.RowCount = 3;
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsTableLayoutPanel.Size = new System.Drawing.Size(464, 681);
            this.settingsTableLayoutPanel.TabIndex = 5;
            this.settingsTableLayoutPanel.Click += new System.EventHandler(this.LaneKeyButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Image = global::RhythmGame.Properties.Resources.back;
            this.backButton.Location = new System.Drawing.Point(168, 627);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 39);
            this.backButton.TabIndex = 6;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.settingsLabel.Location = new System.Drawing.Point(142, 49);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(179, 37);
            this.settingsLabel.TabIndex = 2;
            this.settingsLabel.Text = "SETTINGS";
            this.settingsLabel.Click += new System.EventHandler(this.LaneKeyButton_Click);
            // 
            // settingsCenterTableLayoutPanel
            // 
            this.settingsCenterTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsCenterTableLayoutPanel.ColumnCount = 2;
            this.settingsCenterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.settingsCenterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.settingsCenterTableLayoutPanel.Controls.Add(this.keyButtonTableLayoutPanel, 1, 1);
            this.settingsCenterTableLayoutPanel.Controls.Add(this.keyboardLabel, 0, 1);
            this.settingsCenterTableLayoutPanel.Controls.Add(this.musicTrackBar, 1, 0);
            this.settingsCenterTableLayoutPanel.Controls.Add(this.musicLabel, 0, 0);
            this.settingsCenterTableLayoutPanel.Location = new System.Drawing.Point(3, 239);
            this.settingsCenterTableLayoutPanel.Name = "settingsCenterTableLayoutPanel";
            this.settingsCenterTableLayoutPanel.RowCount = 2;
            this.settingsCenterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settingsCenterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settingsCenterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.settingsCenterTableLayoutPanel.Size = new System.Drawing.Size(457, 269);
            this.settingsCenterTableLayoutPanel.TabIndex = 5;
            this.settingsCenterTableLayoutPanel.Click += new System.EventHandler(this.LaneKeyButton_Click);
            // 
            // keyButtonTableLayoutPanel
            // 
            this.keyButtonTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keyButtonTableLayoutPanel.ColumnCount = 4;
            this.keyButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keyButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keyButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keyButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keyButtonTableLayoutPanel.Controls.Add(this.lane4KeyButton, 3, 0);
            this.keyButtonTableLayoutPanel.Controls.Add(this.lane3KeyButton, 2, 0);
            this.keyButtonTableLayoutPanel.Controls.Add(this.lane2KeyButton, 1, 0);
            this.keyButtonTableLayoutPanel.Controls.Add(this.lane1KeyButton, 0, 0);
            this.keyButtonTableLayoutPanel.Location = new System.Drawing.Point(140, 159);
            this.keyButtonTableLayoutPanel.Name = "keyButtonTableLayoutPanel";
            this.keyButtonTableLayoutPanel.RowCount = 1;
            this.keyButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.keyButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.keyButtonTableLayoutPanel.Size = new System.Drawing.Size(314, 85);
            this.keyButtonTableLayoutPanel.TabIndex = 9;
            this.keyButtonTableLayoutPanel.Click += new System.EventHandler(this.LaneKeyButton_Click);
            // 
            // lane4KeyButton
            // 
            this.lane4KeyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lane4KeyButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lane4KeyButton.Location = new System.Drawing.Point(249, 17);
            this.lane4KeyButton.Name = "lane4KeyButton";
            this.lane4KeyButton.Size = new System.Drawing.Size(50, 50);
            this.lane4KeyButton.TabIndex = 3;
            this.lane4KeyButton.Text = "F";
            this.lane4KeyButton.UseVisualStyleBackColor = true;
            this.lane4KeyButton.Click += new System.EventHandler(this.LaneKeyButton_Click);
            // 
            // lane3KeyButton
            // 
            this.lane3KeyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lane3KeyButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lane3KeyButton.Location = new System.Drawing.Point(170, 17);
            this.lane3KeyButton.Name = "lane3KeyButton";
            this.lane3KeyButton.Size = new System.Drawing.Size(50, 50);
            this.lane3KeyButton.TabIndex = 2;
            this.lane3KeyButton.Text = "D";
            this.lane3KeyButton.UseVisualStyleBackColor = true;
            this.lane3KeyButton.Click += new System.EventHandler(this.LaneKeyButton_Click);
            // 
            // lane2KeyButton
            // 
            this.lane2KeyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lane2KeyButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lane2KeyButton.Location = new System.Drawing.Point(92, 17);
            this.lane2KeyButton.Name = "lane2KeyButton";
            this.lane2KeyButton.Size = new System.Drawing.Size(50, 50);
            this.lane2KeyButton.TabIndex = 1;
            this.lane2KeyButton.Text = "S";
            this.lane2KeyButton.UseVisualStyleBackColor = true;
            this.lane2KeyButton.Click += new System.EventHandler(this.LaneKeyButton_Click);
            // 
            // lane1KeyButton
            // 
            this.lane1KeyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lane1KeyButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lane1KeyButton.Location = new System.Drawing.Point(14, 17);
            this.lane1KeyButton.Name = "lane1KeyButton";
            this.lane1KeyButton.Size = new System.Drawing.Size(50, 50);
            this.lane1KeyButton.TabIndex = 0;
            this.lane1KeyButton.Text = "A";
            this.lane1KeyButton.UseVisualStyleBackColor = true;
            this.lane1KeyButton.Click += new System.EventHandler(this.LaneKeyButton_Click);
            // 
            // keyboardLabel
            // 
            this.keyboardLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keyboardLabel.AutoSize = true;
            this.keyboardLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.keyboardLabel.ForeColor = System.Drawing.Color.White;
            this.keyboardLabel.Location = new System.Drawing.Point(3, 189);
            this.keyboardLabel.Name = "keyboardLabel";
            this.keyboardLabel.Size = new System.Drawing.Size(131, 24);
            this.keyboardLabel.TabIndex = 8;
            this.keyboardLabel.Text = "KEYBOARD";
            this.keyboardLabel.Click += new System.EventHandler(this.LaneKeyButton_Click);
            // 
            // musicTrackBar
            // 
            this.musicTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musicTrackBar.Location = new System.Drawing.Point(149, 44);
            this.musicTrackBar.Name = "musicTrackBar";
            this.musicTrackBar.Size = new System.Drawing.Size(295, 45);
            this.musicTrackBar.TabIndex = 7;
            // 
            // musicLabel
            // 
            this.musicLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musicLabel.AutoSize = true;
            this.musicLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.musicLabel.ForeColor = System.Drawing.Color.White;
            this.musicLabel.Location = new System.Drawing.Point(28, 55);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(80, 24);
            this.musicLabel.TabIndex = 6;
            this.musicLabel.Text = "MUSIC";
            this.musicLabel.Click += new System.EventHandler(this.LaneKeyButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.settingsTableLayoutPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Rhythm Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.settingsTableLayoutPanel.ResumeLayout(false);
            this.settingsTableLayoutPanel.PerformLayout();
            this.settingsCenterTableLayoutPanel.ResumeLayout(false);
            this.settingsCenterTableLayoutPanel.PerformLayout();
            this.keyButtonTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel settingsTableLayoutPanel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TableLayoutPanel settingsCenterTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel keyButtonTableLayoutPanel;
        private System.Windows.Forms.Button lane4KeyButton;
        private System.Windows.Forms.Button lane3KeyButton;
        private System.Windows.Forms.Button lane2KeyButton;
        private System.Windows.Forms.Button lane1KeyButton;
        private System.Windows.Forms.Label keyboardLabel;
        private System.Windows.Forms.TrackBar musicTrackBar;
        private System.Windows.Forms.Label musicLabel;
    }
}