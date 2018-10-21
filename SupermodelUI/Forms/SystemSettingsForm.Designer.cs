namespace SupermodelUI
{
    partial class SystemSettingsForm
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
            this.cpuMultiThreadedCheckBox = new System.Windows.Forms.CheckBox();
            this.gpuMultiThreadedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.powerPCFrequencyUpDown = new System.Windows.Forms.NumericUpDown();
            this.multiTextureCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.sectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.powerPCFrequencyUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuMultiThreadedCheckBox
            // 
            this.cpuMultiThreadedCheckBox.AutoSize = true;
            this.cpuMultiThreadedCheckBox.Location = new System.Drawing.Point(50, 50);
            this.cpuMultiThreadedCheckBox.Name = "cpuMultiThreadedCheckBox";
            this.cpuMultiThreadedCheckBox.Size = new System.Drawing.Size(327, 29);
            this.cpuMultiThreadedCheckBox.TabIndex = 0;
            this.cpuMultiThreadedCheckBox.Text = "Enable Multiple CPU Threads";
            this.cpuMultiThreadedCheckBox.UseVisualStyleBackColor = true;
            // 
            // gpuMultiThreadedCheckBox
            // 
            this.gpuMultiThreadedCheckBox.AutoSize = true;
            this.gpuMultiThreadedCheckBox.Location = new System.Drawing.Point(411, 50);
            this.gpuMultiThreadedCheckBox.Name = "gpuMultiThreadedCheckBox";
            this.gpuMultiThreadedCheckBox.Size = new System.Drawing.Size(328, 29);
            this.gpuMultiThreadedCheckBox.TabIndex = 1;
            this.gpuMultiThreadedCheckBox.Text = "Enable Multiple GPU Threads";
            this.gpuMultiThreadedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "PPC Frequency";
            // 
            // powerPCFrequencyUpDown
            // 
            this.powerPCFrequencyUpDown.Location = new System.Drawing.Point(243, 96);
            this.powerPCFrequencyUpDown.Name = "powerPCFrequencyUpDown";
            this.powerPCFrequencyUpDown.Size = new System.Drawing.Size(120, 31);
            this.powerPCFrequencyUpDown.TabIndex = 3;
            this.powerPCFrequencyUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // multiTextureCheckBox
            // 
            this.multiTextureCheckBox.AutoSize = true;
            this.multiTextureCheckBox.Location = new System.Drawing.Point(411, 101);
            this.multiTextureCheckBox.Name = "multiTextureCheckBox";
            this.multiTextureCheckBox.Size = new System.Drawing.Size(169, 29);
            this.multiTextureCheckBox.TabIndex = 4;
            this.multiTextureCheckBox.Text = "Multi Texture";
            this.multiTextureCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(50, 187);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(160, 59);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(577, 187);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(162, 59);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sectionButton
            // 
            this.sectionButton.Location = new System.Drawing.Point(313, 187);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Size = new System.Drawing.Size(159, 59);
            this.sectionButton.TabIndex = 7;
            this.sectionButton.Text = "Global";
            this.sectionButton.UseVisualStyleBackColor = true;
            this.sectionButton.Click += new System.EventHandler(this.sectionButton_Click);
            // 
            // SystemSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 283);
            this.Controls.Add(this.sectionButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.multiTextureCheckBox);
            this.Controls.Add(this.powerPCFrequencyUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpuMultiThreadedCheckBox);
            this.Controls.Add(this.cpuMultiThreadedCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "System Settings";
            this.Load += new System.EventHandler(this.SystemSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.powerPCFrequencyUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cpuMultiThreadedCheckBox;
        private System.Windows.Forms.CheckBox gpuMultiThreadedCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown powerPCFrequencyUpDown;
        private System.Windows.Forms.CheckBox multiTextureCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button sectionButton;
    }
}