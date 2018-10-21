namespace SupermodelUI
{
    partial class VideoSettingsForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.new3dEngineCheckBox = new System.Windows.Forms.CheckBox();
            this.vSyncCheckBox = new System.Windows.Forms.CheckBox();
            this.throttleCheckBox = new System.Windows.Forms.CheckBox();
            this.showFrameRateCheckBox = new System.Windows.Forms.CheckBox();
            this.quadRenderingCheckBox = new System.Windows.Forms.CheckBox();
            this.crosshairsCheckBox = new System.Windows.Forms.CheckBox();
            this.fullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.wideScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.sectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(55, 327);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 50);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(529, 327);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 50);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // new3dEngineCheckBox
            // 
            this.new3dEngineCheckBox.AutoSize = true;
            this.new3dEngineCheckBox.Location = new System.Drawing.Point(55, 44);
            this.new3dEngineCheckBox.Name = "new3dEngineCheckBox";
            this.new3dEngineCheckBox.Size = new System.Drawing.Size(265, 29);
            this.new3dEngineCheckBox.TabIndex = 28;
            this.new3dEngineCheckBox.Text = "Enable New 3D Engine";
            this.new3dEngineCheckBox.UseVisualStyleBackColor = true;
            // 
            // vSyncCheckBox
            // 
            this.vSyncCheckBox.AutoSize = true;
            this.vSyncCheckBox.Location = new System.Drawing.Point(55, 150);
            this.vSyncCheckBox.Name = "vSyncCheckBox";
            this.vSyncCheckBox.Size = new System.Drawing.Size(179, 29);
            this.vSyncCheckBox.TabIndex = 29;
            this.vSyncCheckBox.Text = "Enable VSync";
            this.vSyncCheckBox.UseVisualStyleBackColor = true;
            // 
            // throttleCheckBox
            // 
            this.throttleCheckBox.AutoSize = true;
            this.throttleCheckBox.Location = new System.Drawing.Point(55, 204);
            this.throttleCheckBox.Name = "throttleCheckBox";
            this.throttleCheckBox.Size = new System.Drawing.Size(235, 29);
            this.throttleCheckBox.TabIndex = 30;
            this.throttleCheckBox.Text = "Throttle Frame Rate";
            this.throttleCheckBox.UseVisualStyleBackColor = true;
            // 
            // showFrameRateCheckBox
            // 
            this.showFrameRateCheckBox.AutoSize = true;
            this.showFrameRateCheckBox.Location = new System.Drawing.Point(55, 256);
            this.showFrameRateCheckBox.Name = "showFrameRateCheckBox";
            this.showFrameRateCheckBox.Size = new System.Drawing.Size(215, 29);
            this.showFrameRateCheckBox.TabIndex = 31;
            this.showFrameRateCheckBox.Text = "Show Frame Rate";
            this.showFrameRateCheckBox.UseVisualStyleBackColor = true;
            // 
            // quadRenderingCheckBox
            // 
            this.quadRenderingCheckBox.AutoSize = true;
            this.quadRenderingCheckBox.Location = new System.Drawing.Point(55, 96);
            this.quadRenderingCheckBox.Name = "quadRenderingCheckBox";
            this.quadRenderingCheckBox.Size = new System.Drawing.Size(274, 29);
            this.quadRenderingCheckBox.TabIndex = 32;
            this.quadRenderingCheckBox.Text = "Enable Quad Rendering";
            this.quadRenderingCheckBox.UseVisualStyleBackColor = true;
            // 
            // crosshairsCheckBox
            // 
            this.crosshairsCheckBox.AutoSize = true;
            this.crosshairsCheckBox.Location = new System.Drawing.Point(473, 44);
            this.crosshairsCheckBox.Name = "crosshairsCheckBox";
            this.crosshairsCheckBox.Size = new System.Drawing.Size(206, 29);
            this.crosshairsCheckBox.TabIndex = 33;
            this.crosshairsCheckBox.Text = "Show Crosshairs";
            this.crosshairsCheckBox.UseVisualStyleBackColor = true;
            // 
            // fullScreenCheckBox
            // 
            this.fullScreenCheckBox.AutoSize = true;
            this.fullScreenCheckBox.Location = new System.Drawing.Point(473, 96);
            this.fullScreenCheckBox.Name = "fullScreenCheckBox";
            this.fullScreenCheckBox.Size = new System.Drawing.Size(147, 29);
            this.fullScreenCheckBox.TabIndex = 34;
            this.fullScreenCheckBox.Text = "FullScreen";
            this.fullScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // wideScreenCheckBox
            // 
            this.wideScreenCheckBox.AutoSize = true;
            this.wideScreenCheckBox.Location = new System.Drawing.Point(473, 150);
            this.wideScreenCheckBox.Name = "wideScreenCheckBox";
            this.wideScreenCheckBox.Size = new System.Drawing.Size(161, 29);
            this.wideScreenCheckBox.TabIndex = 35;
            this.wideScreenCheckBox.Text = "WideScreen";
            this.wideScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Location = new System.Drawing.Point(473, 256);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.Size = new System.Drawing.Size(178, 33);
            this.resolutionComboBox.TabIndex = 36;
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(468, 205);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(114, 25);
            this.resolutionLabel.TabIndex = 37;
            this.resolutionLabel.Text = "Resolution";
            // 
            // sectionButton
            // 
            this.sectionButton.Location = new System.Drawing.Point(298, 327);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Size = new System.Drawing.Size(140, 50);
            this.sectionButton.TabIndex = 38;
            this.sectionButton.Text = "Global";
            this.sectionButton.UseVisualStyleBackColor = true;
            this.sectionButton.Click += new System.EventHandler(this.sectionButton_Click);
            // 
            // VideoSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 410);
            this.Controls.Add(this.sectionButton);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.resolutionComboBox);
            this.Controls.Add(this.wideScreenCheckBox);
            this.Controls.Add(this.fullScreenCheckBox);
            this.Controls.Add(this.crosshairsCheckBox);
            this.Controls.Add(this.quadRenderingCheckBox);
            this.Controls.Add(this.showFrameRateCheckBox);
            this.Controls.Add(this.throttleCheckBox);
            this.Controls.Add(this.vSyncCheckBox);
            this.Controls.Add(this.new3dEngineCheckBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Video Settings";
            this.Load += new System.EventHandler(this.VideoSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox new3dEngineCheckBox;
        private System.Windows.Forms.CheckBox vSyncCheckBox;
        private System.Windows.Forms.CheckBox throttleCheckBox;
        private System.Windows.Forms.CheckBox showFrameRateCheckBox;
        private System.Windows.Forms.CheckBox quadRenderingCheckBox;
        private System.Windows.Forms.CheckBox crosshairsCheckBox;
        private System.Windows.Forms.CheckBox fullScreenCheckBox;
        private System.Windows.Forms.CheckBox wideScreenCheckBox;
        private System.Windows.Forms.ComboBox resolutionComboBox;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.Button sectionButton;
    }
}