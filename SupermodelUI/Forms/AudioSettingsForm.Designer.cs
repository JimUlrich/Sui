namespace SupermodelUI
{
    partial class AudioSettingsForm
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
            this.emulateSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.enableDSBCheckBox = new System.Windows.Forms.CheckBox();
            this.flipStereoCheckBox = new System.Windows.Forms.CheckBox();
            this.soundVolumeLabel = new System.Windows.Forms.Label();
            this.musicVolumelabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.soundVolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.musicVolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.balanceTrackBar = new System.Windows.Forms.TrackBar();
            this.sectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.soundVolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // emulateSoundCheckBox
            // 
            this.emulateSoundCheckBox.AutoSize = true;
            this.emulateSoundCheckBox.Location = new System.Drawing.Point(50, 50);
            this.emulateSoundCheckBox.Name = "emulateSoundCheckBox";
            this.emulateSoundCheckBox.Size = new System.Drawing.Size(190, 29);
            this.emulateSoundCheckBox.TabIndex = 0;
            this.emulateSoundCheckBox.Text = "Emulate Sound";
            this.emulateSoundCheckBox.UseVisualStyleBackColor = true;
            this.emulateSoundCheckBox.CheckedChanged += new System.EventHandler(this.emulateSoundCheckBox_CheckedChanged);
            // 
            // enableDSBCheckBox
            // 
            this.enableDSBCheckBox.AutoSize = true;
            this.enableDSBCheckBox.Location = new System.Drawing.Point(50, 100);
            this.enableDSBCheckBox.Name = "enableDSBCheckBox";
            this.enableDSBCheckBox.Size = new System.Drawing.Size(160, 29);
            this.enableDSBCheckBox.TabIndex = 1;
            this.enableDSBCheckBox.Text = "Enable DSB";
            this.enableDSBCheckBox.UseVisualStyleBackColor = true;
            this.enableDSBCheckBox.CheckedChanged += new System.EventHandler(this.enableDSBCheckBox_CheckedChanged);
            // 
            // flipStereoCheckBox
            // 
            this.flipStereoCheckBox.AutoSize = true;
            this.flipStereoCheckBox.Location = new System.Drawing.Point(50, 150);
            this.flipStereoCheckBox.Name = "flipStereoCheckBox";
            this.flipStereoCheckBox.Size = new System.Drawing.Size(148, 29);
            this.flipStereoCheckBox.TabIndex = 2;
            this.flipStereoCheckBox.Text = "Flip Stereo";
            this.flipStereoCheckBox.UseVisualStyleBackColor = true;
            // 
            // soundVolumeLabel
            // 
            this.soundVolumeLabel.AutoSize = true;
            this.soundVolumeLabel.Enabled = false;
            this.soundVolumeLabel.Location = new System.Drawing.Point(270, 50);
            this.soundVolumeLabel.Name = "soundVolumeLabel";
            this.soundVolumeLabel.Size = new System.Drawing.Size(152, 25);
            this.soundVolumeLabel.TabIndex = 3;
            this.soundVolumeLabel.Text = "Sound Volume";
            // 
            // musicVolumelabel
            // 
            this.musicVolumelabel.AutoSize = true;
            this.musicVolumelabel.Enabled = false;
            this.musicVolumelabel.Location = new System.Drawing.Point(270, 101);
            this.musicVolumelabel.Name = "musicVolumelabel";
            this.musicVolumelabel.Size = new System.Drawing.Size(147, 25);
            this.musicVolumelabel.TabIndex = 4;
            this.musicVolumelabel.Text = "Music Volume";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(270, 151);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(90, 25);
            this.balanceLabel.TabIndex = 5;
            this.balanceLabel.Text = "Balance";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(48, 238);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 50);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(522, 238);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 50);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // soundVolumeTrackBar
            // 
            this.soundVolumeTrackBar.Enabled = false;
            this.soundVolumeTrackBar.Location = new System.Drawing.Point(428, 50);
            this.soundVolumeTrackBar.Maximum = 200;
            this.soundVolumeTrackBar.Name = "soundVolumeTrackBar";
            this.soundVolumeTrackBar.Size = new System.Drawing.Size(265, 90);
            this.soundVolumeTrackBar.TabIndex = 14;
            this.soundVolumeTrackBar.Value = 100;
            // 
            // musicVolumeTrackBar
            // 
            this.musicVolumeTrackBar.Enabled = false;
            this.musicVolumeTrackBar.Location = new System.Drawing.Point(428, 100);
            this.musicVolumeTrackBar.Maximum = 200;
            this.musicVolumeTrackBar.Name = "musicVolumeTrackBar";
            this.musicVolumeTrackBar.Size = new System.Drawing.Size(265, 90);
            this.musicVolumeTrackBar.TabIndex = 15;
            this.musicVolumeTrackBar.Value = 100;
            // 
            // balanceTrackBar
            // 
            this.balanceTrackBar.Location = new System.Drawing.Point(428, 151);
            this.balanceTrackBar.Maximum = 100;
            this.balanceTrackBar.Minimum = -100;
            this.balanceTrackBar.Name = "balanceTrackBar";
            this.balanceTrackBar.Size = new System.Drawing.Size(265, 90);
            this.balanceTrackBar.TabIndex = 16;
            // 
            // sectionButton
            // 
            this.sectionButton.Location = new System.Drawing.Point(297, 238);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Size = new System.Drawing.Size(139, 50);
            this.sectionButton.TabIndex = 17;
            this.sectionButton.Text = "Global";
            this.sectionButton.UseVisualStyleBackColor = true;
            this.sectionButton.Click += new System.EventHandler(this.sectionButton_Click);
            // 
            // AudioSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 326);
            this.Controls.Add(this.sectionButton);
            this.Controls.Add(this.balanceTrackBar);
            this.Controls.Add(this.musicVolumeTrackBar);
            this.Controls.Add(this.soundVolumeTrackBar);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.musicVolumelabel);
            this.Controls.Add(this.soundVolumeLabel);
            this.Controls.Add(this.flipStereoCheckBox);
            this.Controls.Add(this.enableDSBCheckBox);
            this.Controls.Add(this.emulateSoundCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AudioSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Audio Settings";
            this.Load += new System.EventHandler(this.AudioSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soundVolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox emulateSoundCheckBox;
        private System.Windows.Forms.CheckBox enableDSBCheckBox;
        private System.Windows.Forms.CheckBox flipStereoCheckBox;
        private System.Windows.Forms.Label soundVolumeLabel;
        private System.Windows.Forms.Label musicVolumelabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TrackBar soundVolumeTrackBar;
        private System.Windows.Forms.TrackBar musicVolumeTrackBar;
        private System.Windows.Forms.TrackBar balanceTrackBar;
        private System.Windows.Forms.Button sectionButton;
    }
}