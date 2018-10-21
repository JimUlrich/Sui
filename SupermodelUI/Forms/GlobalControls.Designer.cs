namespace SupermodelUI
{
    partial class GlobalControls
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
            this.components = new System.ComponentModel.Container();
            this.iniSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globalControlsDataGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iniSettingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalControlsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iniSettingBindingSource
            // 
            this.iniSettingBindingSource.DataSource = typeof(SupermodelUI.IniSetting);
            // 
            // globalControlsDataGridView
            // 
            this.globalControlsDataGridView.AllowUserToAddRows = false;
            this.globalControlsDataGridView.AllowUserToDeleteRows = false;
            this.globalControlsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.globalControlsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.globalControlsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.globalControlsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.globalControlsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.globalControlsDataGridView.Name = "globalControlsDataGridView";
            this.globalControlsDataGridView.RowHeadersVisible = false;
            this.globalControlsDataGridView.RowTemplate.Height = 33;
            this.globalControlsDataGridView.Size = new System.Drawing.Size(906, 352);
            this.globalControlsDataGridView.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(150, 385);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(161, 64);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(610, 385);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(167, 64);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // GlobalControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 473);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.globalControlsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalControls";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Controls";
            this.Load += new System.EventHandler(this.MainControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iniSettingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalControlsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource iniSettingBindingSource;
        private System.Windows.Forms.DataGridView globalControlsDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
    }
}