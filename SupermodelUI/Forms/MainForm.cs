using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using IniParser;
using IniParser.Model;
using System.IO;

namespace SupermodelUI
{
    public partial class MainForm : Form
    {
        public static string rom { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            Facade.Load(this, "game");
            rom = GetRomName();
            fullScreenCheckBox.Checked = false;
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            this.Launch();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Launch();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoSettingsForm videoSettingsForm = new VideoSettingsForm();
            videoSettingsForm.Location = CalculateStartPosition(videoSettingsForm);
            videoSettingsForm.ShowDialog();
        }

        private void audioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AudioSettingsForm audioSettingsForm = new AudioSettingsForm();
            audioSettingsForm.Location = CalculateStartPosition(audioSettingsForm);
            audioSettingsForm.ShowDialog();
        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSettingsForm systemSettingsForm = new SystemSettingsForm(rom);
            systemSettingsForm.Location = CalculateStartPosition(systemSettingsForm);
            systemSettingsForm.ShowDialog();
        }

        private void globalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalControls globalControlsForm = new GlobalControls();
            globalControlsForm.Location = CalculateStartPosition(globalControlsForm);
            globalControlsForm.ShowDialog();
        }

        private void gameSpecificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainDataGridView.CurrentCell is null)
            {
                MessageBox.Show("No game selected");
                return;
            }

            GameControls gameControlsForm = new GameControls(rom);
            gameControlsForm.Location = CalculateStartPosition(gameControlsForm);
            gameControlsForm.Show();
        }

        private void quickSettingsButton_Click(object sender, EventArgs e)
        {
            if (enableNetworkCheckBox.Visible == false && fullScreenCheckBox.Visible == false)
            {
                enableNetworkCheckBox.Visible = true;
                enableNetworkCheckBox.Checked = false;
                fullScreenCheckBox.Visible = true;
                fullScreenCheckBox.Checked = false;
            }
            else
            {
                enableNetworkCheckBox.Visible = false;
                fullScreenCheckBox.Visible = false;
            }
        }

        private void mainDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            rom = GetRomName();
        }

        #endregion

        #region Methods

        private string GetRomName()
        {
            Game game = (Game)mainDataGridView.CurrentRow.DataBoundItem;
            string romName = game.romName;

            return romName;
        }

        private void Launch()
        {
            if (mainDataGridView.CurrentCell is null)
            {
                MessageBox.Show("No game selected");
                return;
            }

            string directory = System.Environment.CurrentDirectory + "\\Supermodel.exe";
            string romName = GetRomName();
            string rom = System.Environment.CurrentDirectory + "\\" + romName + ".zip";
           
            //does rom exist in directory?
            bool exists = File.Exists(rom);
            if (!exists)
            {
                Facade.ShowMessageBox(this, "Rom not found");
            }
            else
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();

                // Stop the process from opening a new window
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;

                string arguments = romName + ".zip";

                if (fullScreenCheckBox.Checked == true)
                {
                    arguments = arguments + " -fullscreen";
                }

                startInfo.Arguments = arguments;
                startInfo.FileName = directory;
                using (Process proc = Process.Start(startInfo))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    proc.WaitForExit();
                }
            }

        }

        private Point CalculateStartPosition(Form childForm)
        {
            Point startPosition = new Point();

            startPosition.X = this.Location.X + (this.Width - childForm.Width) / 2;
            startPosition.Y = this.Location.Y + (this.Height - childForm.Height) / 2;

            return startPosition;
        }


        #endregion

    }
}
