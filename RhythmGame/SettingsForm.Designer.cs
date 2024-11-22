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
            this.settingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.musicTrackBar = new System.Windows.Forms.TrackBar();
            this.soundLabel = new System.Windows.Forms.Label();
            this.musicLabel = new System.Windows.Forms.Label();
            this.keyboardLabel = new System.Windows.Forms.Label();
            this.keyButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.key4Button = new System.Windows.Forms.Button();
            this.key3Button = new System.Windows.Forms.Button();
            this.key2Button = new System.Windows.Forms.Button();
            this.key1Button = new System.Windows.Forms.Button();
            this.soundTrackBar = new System.Windows.Forms.TrackBar();
            this.settingsTableLayoutPanel.SuspendLayout();
            this.settingTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).BeginInit();
            this.keyButtonTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsTableLayoutPanel
            // 
            this.settingsTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsTableLayoutPanel.ColumnCount = 1;
            this.settingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsTableLayoutPanel.Controls.Add(this.backButton, 0, 2);
            this.settingsTableLayoutPanel.Controls.Add(this.settingsLabel, 0, 0);
            this.settingsTableLayoutPanel.Controls.Add(this.settingTableLayoutPanel, 0, 1);
            this.settingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsTableLayoutPanel.Name = "settingsTableLayoutPanel";
            this.settingsTableLayoutPanel.RowCount = 3;
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsTableLayoutPanel.Size = new System.Drawing.Size(464, 681);
            this.settingsTableLayoutPanel.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Image = global::RhythmGame.Properties.Resources.back;
            this.backButton.Location = new System.Drawing.Point(207, 627);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 39);
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
            // 
            // settingTableLayoutPanel
            // 
            this.settingTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingTableLayoutPanel.ColumnCount = 2;
            this.settingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.settingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.settingTableLayoutPanel.Controls.Add(this.musicTrackBar, 1, 1);
            this.settingTableLayoutPanel.Controls.Add(this.soundLabel, 0, 0);
            this.settingTableLayoutPanel.Controls.Add(this.musicLabel, 0, 1);
            this.settingTableLayoutPanel.Controls.Add(this.keyboardLabel, 0, 2);
            this.settingTableLayoutPanel.Controls.Add(this.keyButtonTableLayoutPanel, 1, 2);
            this.settingTableLayoutPanel.Controls.Add(this.soundTrackBar, 1, 0);
            this.settingTableLayoutPanel.Location = new System.Drawing.Point(3, 239);
            this.settingTableLayoutPanel.Name = "settingTableLayoutPanel";
            this.settingTableLayoutPanel.RowCount = 3;
            this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.settingTableLayoutPanel.Size = new System.Drawing.Size(457, 269);
            this.settingTableLayoutPanel.TabIndex = 5;
            // 
            // musicTrackBar
            // 
            this.musicTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musicTrackBar.Location = new System.Drawing.Point(149, 111);
            this.musicTrackBar.Name = "musicTrackBar";
            this.musicTrackBar.Size = new System.Drawing.Size(295, 45);
            this.musicTrackBar.TabIndex = 4;
            // 
            // soundLabel
            // 
            this.soundLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soundLabel.AutoSize = true;
            this.soundLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.soundLabel.ForeColor = System.Drawing.Color.White;
            this.soundLabel.Location = new System.Drawing.Point(24, 32);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(89, 24);
            this.soundLabel.TabIndex = 0;
            this.soundLabel.Text = "SOUND";
            // 
            // musicLabel
            // 
            this.musicLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musicLabel.AutoSize = true;
            this.musicLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.musicLabel.ForeColor = System.Drawing.Color.White;
            this.musicLabel.Location = new System.Drawing.Point(28, 121);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(80, 24);
            this.musicLabel.TabIndex = 1;
            this.musicLabel.Text = "MUSIC";
            // 
            // keyboardLabel
            // 
            this.keyboardLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keyboardLabel.AutoSize = true;
            this.keyboardLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.keyboardLabel.ForeColor = System.Drawing.Color.White;
            this.keyboardLabel.Location = new System.Drawing.Point(3, 211);
            this.keyboardLabel.Name = "keyboardLabel";
            this.keyboardLabel.Size = new System.Drawing.Size(131, 24);
            this.keyboardLabel.TabIndex = 2;
            this.keyboardLabel.Text = "KEYBOARD";
            // 
            // keyButtonTableLayoutPanel
            // 
            this.keyButtonTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keyButtonTableLayoutPanel.ColumnCount = 4;
            this.keyButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keyButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keyButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keyButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keyButtonTableLayoutPanel.Controls.Add(this.key4Button, 3, 0);
            this.keyButtonTableLayoutPanel.Controls.Add(this.key3Button, 2, 0);
            this.keyButtonTableLayoutPanel.Controls.Add(this.key2Button, 1, 0);
            this.keyButtonTableLayoutPanel.Controls.Add(this.key1Button, 0, 0);
            this.keyButtonTableLayoutPanel.Location = new System.Drawing.Point(140, 181);
            this.keyButtonTableLayoutPanel.Name = "keyButtonTableLayoutPanel";
            this.keyButtonTableLayoutPanel.RowCount = 1;
            this.keyButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.keyButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.keyButtonTableLayoutPanel.Size = new System.Drawing.Size(314, 85);
            this.keyButtonTableLayoutPanel.TabIndex = 5;
            // 
            // key4Button
            // 
            this.key4Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key4Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key4Button.Location = new System.Drawing.Point(249, 17);
            this.key4Button.Name = "key4Button";
            this.key4Button.Size = new System.Drawing.Size(50, 50);
            this.key4Button.TabIndex = 3;
            this.key4Button.Text = "F";
            this.key4Button.UseVisualStyleBackColor = true;
            // 
            // key3Button
            // 
            this.key3Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key3Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key3Button.Location = new System.Drawing.Point(170, 17);
            this.key3Button.Name = "key3Button";
            this.key3Button.Size = new System.Drawing.Size(50, 50);
            this.key3Button.TabIndex = 2;
            this.key3Button.Text = "D";
            this.key3Button.UseVisualStyleBackColor = true;
            // 
            // key2Button
            // 
            this.key2Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key2Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key2Button.Location = new System.Drawing.Point(92, 17);
            this.key2Button.Name = "key2Button";
            this.key2Button.Size = new System.Drawing.Size(50, 50);
            this.key2Button.TabIndex = 1;
            this.key2Button.Text = "S";
            this.key2Button.UseVisualStyleBackColor = true;
            // 
            // key1Button
            // 
            this.key1Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key1Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key1Button.Location = new System.Drawing.Point(14, 17);
            this.key1Button.Name = "key1Button";
            this.key1Button.Size = new System.Drawing.Size(50, 50);
            this.key1Button.TabIndex = 0;
            this.key1Button.Text = "A";
            this.key1Button.UseVisualStyleBackColor = true;
            // 
            // soundTrackBar
            // 
            this.soundTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soundTrackBar.Location = new System.Drawing.Point(151, 22);
            this.soundTrackBar.Name = "soundTrackBar";
            this.soundTrackBar.Size = new System.Drawing.Size(292, 45);
            this.soundTrackBar.TabIndex = 3;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Rhythm Game";
            this.settingsTableLayoutPanel.ResumeLayout(false);
            this.settingsTableLayoutPanel.PerformLayout();
            this.settingTableLayoutPanel.ResumeLayout(false);
            this.settingTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).EndInit();
            this.keyButtonTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soundTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel settingsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel settingTableLayoutPanel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label soundLabel;
        private System.Windows.Forms.Label musicLabel;
        private System.Windows.Forms.Label keyboardLabel;
        private System.Windows.Forms.TrackBar soundTrackBar;
        private System.Windows.Forms.TableLayoutPanel keyButtonTableLayoutPanel;
        private System.Windows.Forms.Button key1Button;
        private System.Windows.Forms.Button key4Button;
        private System.Windows.Forms.Button key3Button;
        private System.Windows.Forms.Button key2Button;
        private System.Windows.Forms.TrackBar musicTrackBar;
        private System.Windows.Forms.Button backButton;
    }
}