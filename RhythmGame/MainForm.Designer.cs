namespace RhythmGame
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.RhythmGameLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.buttonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RhythmGameLabel
            // 
            this.RhythmGameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RhythmGameLabel.AutoSize = true;
            this.RhythmGameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RhythmGameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.RhythmGameLabel.Location = new System.Drawing.Point(38, 108);
            this.RhythmGameLabel.Name = "RhythmGameLabel";
            this.RhythmGameLabel.Size = new System.Drawing.Size(388, 55);
            this.RhythmGameLabel.TabIndex = 2;
            this.RhythmGameLabel.Text = "RHYTHM GAME";
            // 
            // startGameButton
            // 
            this.startGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startGameButton.AutoSize = true;
            this.startGameButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.Location = new System.Drawing.Point(45, 16);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(230, 64);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "START GAME";
            this.startGameButton.UseVisualStyleBackColor = true;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.RhythmGameLabel, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(464, 681);
            this.mainTableLayoutPanel.TabIndex = 4;
            // 
            // buttonTableLayoutPanel
            // 
            this.buttonTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTableLayoutPanel.ColumnCount = 1;
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonTableLayoutPanel.Controls.Add(this.settingsButton, 0, 1);
            this.buttonTableLayoutPanel.Controls.Add(this.startGameButton, 0, 0);
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(72, 311);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 2;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(320, 193);
            this.buttonTableLayoutPanel.TabIndex = 5;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsButton.AutoSize = true;
            this.settingsButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(45, 112);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(230, 64);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Rhythm Game";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.buttonTableLayoutPanel.ResumeLayout(false);
            this.buttonTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label RhythmGameLabel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
    }
}

