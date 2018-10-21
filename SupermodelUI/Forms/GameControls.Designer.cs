namespace SupermodelUI
{
    partial class GameControls
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
            this.gameControlsDataGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameControlsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gameControlsDataGridView
            // 
            this.gameControlsDataGridView.AllowUserToAddRows = false;
            this.gameControlsDataGridView.AllowUserToDeleteRows = false;
            this.gameControlsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gameControlsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gameControlsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameControlsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameControlsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.gameControlsDataGridView.Name = "gameControlsDataGridView";
            this.gameControlsDataGridView.RowHeadersVisible = false;
            this.gameControlsDataGridView.RowTemplate.Height = 33;
            this.gameControlsDataGridView.Size = new System.Drawing.Size(897, 468);
            this.gameControlsDataGridView.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(126, 508);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(156, 63);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(570, 508);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(166, 67);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // GameControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(897, 619);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.gameControlsDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Controls";
            this.Load += new System.EventHandler(this.GameControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameControlsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gameControlsDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
    }
}