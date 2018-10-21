namespace SupermodelUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameSpecificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchButton = new System.Windows.Forms.Button();
            this.quickSettingsButton = new System.Windows.Forms.Button();
            this.enableNetworkCheckBox = new System.Windows.Forms.CheckBox();
            this.fullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.controlsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(156, 38);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.audioToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.networkToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.videoToolStripMenuItem.Text = "Video";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.audioToolStripMenuItem.Text = "Audio";
            this.audioToolStripMenuItem.Click += new System.EventHandler(this.audioToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.systemToolStripMenuItem.Text = "System";
            this.systemToolStripMenuItem.Click += new System.EventHandler(this.systemToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.Enabled = false;
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalToolStripMenuItem,
            this.gameSpecificToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(116, 36);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // globalToolStripMenuItem
            // 
            this.globalToolStripMenuItem.Name = "globalToolStripMenuItem";
            this.globalToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.globalToolStripMenuItem.Text = "Global";
            this.globalToolStripMenuItem.Click += new System.EventHandler(this.globalToolStripMenuItem_Click);
            // 
            // gameSpecificToolStripMenuItem
            // 
            this.gameSpecificToolStripMenuItem.Name = "gameSpecificToolStripMenuItem";
            this.gameSpecificToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.gameSpecificToolStripMenuItem.Text = "Game-Specific";
            this.gameSpecificToolStripMenuItem.Click += new System.EventHandler(this.gameSpecificToolStripMenuItem_Click);
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(734, 77);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(180, 64);
            this.launchButton.TabIndex = 3;
            this.launchButton.Text = "Launch Game";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // quickSettingsButton
            // 
            this.quickSettingsButton.Location = new System.Drawing.Point(734, 182);
            this.quickSettingsButton.Name = "quickSettingsButton";
            this.quickSettingsButton.Size = new System.Drawing.Size(180, 62);
            this.quickSettingsButton.TabIndex = 4;
            this.quickSettingsButton.Text = "Quick Settings";
            this.quickSettingsButton.UseVisualStyleBackColor = true;
            this.quickSettingsButton.Click += new System.EventHandler(this.quickSettingsButton_Click);
            // 
            // enableNetworkCheckBox
            // 
            this.enableNetworkCheckBox.AutoSize = true;
            this.enableNetworkCheckBox.Checked = true;
            this.enableNetworkCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableNetworkCheckBox.Enabled = false;
            this.enableNetworkCheckBox.Location = new System.Drawing.Point(734, 280);
            this.enableNetworkCheckBox.Name = "enableNetworkCheckBox";
            this.enableNetworkCheckBox.Size = new System.Drawing.Size(195, 29);
            this.enableNetworkCheckBox.TabIndex = 5;
            this.enableNetworkCheckBox.Text = "Enable Network";
            this.enableNetworkCheckBox.UseVisualStyleBackColor = true;
            this.enableNetworkCheckBox.Visible = false;
            // 
            // fullScreenCheckBox
            // 
            this.fullScreenCheckBox.AutoSize = true;
            this.fullScreenCheckBox.Checked = true;
            this.fullScreenCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fullScreenCheckBox.Location = new System.Drawing.Point(734, 344);
            this.fullScreenCheckBox.Name = "fullScreenCheckBox";
            this.fullScreenCheckBox.Size = new System.Drawing.Size(147, 29);
            this.fullScreenCheckBox.TabIndex = 6;
            this.fullScreenCheckBox.Text = "FullScreen";
            this.fullScreenCheckBox.UseVisualStyleBackColor = true;
            this.fullScreenCheckBox.Visible = false;
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(39, 77);
            this.mainDataGridView.MultiSelect = false;
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowHeadersVisible = false;
            this.mainDataGridView.RowTemplate.Height = 33;
            this.mainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDataGridView.Size = new System.Drawing.Size(652, 544);
            this.mainDataGridView.TabIndex = 7;
            this.mainDataGridView.SelectionChanged += new System.EventHandler(this.mainDataGridView_SelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(958, 670);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.fullScreenCheckBox);
            this.Controls.Add(this.enableNetworkCheckBox);
            this.Controls.Add(this.quickSettingsButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sui";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Button quickSettingsButton;
        private System.Windows.Forms.CheckBox enableNetworkCheckBox;
        private System.Windows.Forms.CheckBox fullScreenCheckBox;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameSpecificToolStripMenuItem;
        private System.Windows.Forms.DataGridView mainDataGridView;
    }
}

