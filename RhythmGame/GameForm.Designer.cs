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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.bottomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.key4 = new System.Windows.Forms.PictureBox();
            this.key3 = new System.Windows.Forms.PictureBox();
            this.key2 = new System.Windows.Forms.PictureBox();
            this.key4Button = new System.Windows.Forms.Button();
            this.key3Button = new System.Windows.Forms.Button();
            this.key2Button = new System.Windows.Forms.Button();
            this.key1 = new System.Windows.Forms.PictureBox();
            this.key1Button = new System.Windows.Forms.Button();
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.linePictureBox = new System.Windows.Forms.PictureBox();
            this.noteTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bottomTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key1)).BeginInit();
            this.topTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.scoreLabel.Location = new System.Drawing.Point(118, 4);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(226, 37);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "99999999999";
            // 
            // bottomTableLayoutPanel
            // 
            this.bottomTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomTableLayoutPanel.ColumnCount = 4;
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bottomTableLayoutPanel.Controls.Add(this.key4, 3, 0);
            this.bottomTableLayoutPanel.Controls.Add(this.key3, 2, 0);
            this.bottomTableLayoutPanel.Controls.Add(this.key2, 1, 0);
            this.bottomTableLayoutPanel.Controls.Add(this.key4Button, 3, 1);
            this.bottomTableLayoutPanel.Controls.Add(this.key3Button, 2, 1);
            this.bottomTableLayoutPanel.Controls.Add(this.key2Button, 1, 1);
            this.bottomTableLayoutPanel.Controls.Add(this.key1, 0, 0);
            this.bottomTableLayoutPanel.Controls.Add(this.key1Button, 0, 1);
            this.bottomTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomTableLayoutPanel.Location = new System.Drawing.Point(0, 663);
            this.bottomTableLayoutPanel.Name = "bottomTableLayoutPanel";
            this.bottomTableLayoutPanel.RowCount = 2;
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.bottomTableLayoutPanel.Size = new System.Drawing.Size(464, 98);
            this.bottomTableLayoutPanel.TabIndex = 0;
            // 
            // key4
            // 
            this.key4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key4.Image = global::RhythmGame.Properties.Resources.Key;
            this.key4.Location = new System.Drawing.Point(351, 3);
            this.key4.Name = "key4";
            this.key4.Size = new System.Drawing.Size(110, 33);
            this.key4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key4.TabIndex = 14;
            this.key4.TabStop = false;
            // 
            // key3
            // 
            this.key3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key3.Image = global::RhythmGame.Properties.Resources.Key;
            this.key3.Location = new System.Drawing.Point(235, 3);
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(110, 33);
            this.key3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key3.TabIndex = 13;
            this.key3.TabStop = false;
            // 
            // key2
            // 
            this.key2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key2.Image = global::RhythmGame.Properties.Resources.Key;
            this.key2.Location = new System.Drawing.Point(119, 3);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(110, 33);
            this.key2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key2.TabIndex = 12;
            this.key2.TabStop = false;
            // 
            // key4Button
            // 
            this.key4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key4Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key4Button.Location = new System.Drawing.Point(351, 42);
            this.key4Button.Name = "key4Button";
            this.key4Button.Size = new System.Drawing.Size(110, 53);
            this.key4Button.TabIndex = 11;
            this.key4Button.Text = "F";
            this.key4Button.UseVisualStyleBackColor = true;
            // 
            // key3Button
            // 
            this.key3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key3Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key3Button.Location = new System.Drawing.Point(235, 42);
            this.key3Button.Name = "key3Button";
            this.key3Button.Size = new System.Drawing.Size(110, 53);
            this.key3Button.TabIndex = 10;
            this.key3Button.Text = "D";
            this.key3Button.UseVisualStyleBackColor = true;
            // 
            // key2Button
            // 
            this.key2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key2Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key2Button.Location = new System.Drawing.Point(119, 42);
            this.key2Button.Name = "key2Button";
            this.key2Button.Size = new System.Drawing.Size(110, 53);
            this.key2Button.TabIndex = 9;
            this.key2Button.Text = "S";
            this.key2Button.UseVisualStyleBackColor = true;
            // 
            // key1
            // 
            this.key1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key1.Image = global::RhythmGame.Properties.Resources.Key;
            this.key1.Location = new System.Drawing.Point(3, 3);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(110, 33);
            this.key1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key1.TabIndex = 4;
            this.key1.TabStop = false;
            // 
            // key1Button
            // 
            this.key1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key1Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.key1Button.Location = new System.Drawing.Point(3, 42);
            this.key1Button.Name = "key1Button";
            this.key1Button.Size = new System.Drawing.Size(110, 53);
            this.key1Button.TabIndex = 8;
            this.key1Button.Text = "A";
            this.key1Button.UseVisualStyleBackColor = true;
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.topTableLayoutPanel.ColumnCount = 3;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.topTableLayoutPanel.Controls.Add(this.scoreLabel, 1, 0);
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 1;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(464, 45);
            this.topTableLayoutPanel.TabIndex = 2;
            // 
            // linePictureBox
            // 
            this.linePictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.linePictureBox.Image = global::RhythmGame.Properties.Resources.Line;
            this.linePictureBox.Location = new System.Drawing.Point(0, 45);
            this.linePictureBox.Name = "linePictureBox";
            this.linePictureBox.Size = new System.Drawing.Size(464, 5);
            this.linePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.linePictureBox.TabIndex = 3;
            this.linePictureBox.TabStop = false;
            // 
            // noteTableLayoutPanel
            // 
            this.noteTableLayoutPanel.ColumnCount = 4;
            this.noteTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.noteTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.noteTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.noteTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.noteTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteTableLayoutPanel.Location = new System.Drawing.Point(0, 50);
            this.noteTableLayoutPanel.Name = "noteTableLayoutPanel";
            this.noteTableLayoutPanel.RowCount = 1;
            this.noteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.noteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 615F));
            this.noteTableLayoutPanel.Size = new System.Drawing.Size(464, 613);
            this.noteTableLayoutPanel.TabIndex = 4;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 761);
            this.Controls.Add(this.noteTableLayoutPanel);
            this.Controls.Add(this.linePictureBox);
            this.Controls.Add(this.topTableLayoutPanel);
            this.Controls.Add(this.bottomTableLayoutPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.Text = "Rhythm Game";
            this.bottomTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.key4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key1)).EndInit();
            this.topTableLayoutPanel.ResumeLayout(false);
            this.topTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TableLayoutPanel bottomTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.Button key1Button;
        private System.Windows.Forms.Button key4Button;
        private System.Windows.Forms.Button key3Button;
        private System.Windows.Forms.Button key2Button;
        private System.Windows.Forms.PictureBox key1;
        private System.Windows.Forms.PictureBox key4;
        private System.Windows.Forms.PictureBox key3;
        private System.Windows.Forms.PictureBox key2;
        private System.Windows.Forms.PictureBox linePictureBox;
        private System.Windows.Forms.TableLayoutPanel noteTableLayoutPanel;
    }
}