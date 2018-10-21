using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace SupermodelUI
{
    public partial class AudioSettingsForm : Form
    {
        private bool global = true;

        public AudioSettingsForm()
        {
            InitializeComponent();
        }

        #region Events

        private void AudioSettings_Load(object sender, EventArgs e)
        {
            Facade.Load(this);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (global == true)
            {
                Facade.Save(this);
                Facade.Load(this);
            }
            else
            {
                Facade.Save(this, MainForm.rom);
                Facade.Load(this, MainForm.rom);
            }

            Facade.ShowMessageBox(this, "Settings saved");
        }

        private void emulateSoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (emulateSoundCheckBox.Checked == true)
            {
                soundVolumeLabel.Enabled = true;
                soundVolumeTrackBar.Enabled = true;
            }
            else if (emulateSoundCheckBox.Checked == false)
            {
                soundVolumeLabel.Enabled = false;
                soundVolumeTrackBar.Enabled = false;
            }
        }

        private void enableDSBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableDSBCheckBox.Checked == true)
            {
                musicVolumelabel.Enabled = true;
                musicVolumeTrackBar.Enabled = true;
            }
            else if (enableDSBCheckBox.Checked == false)
            {
                musicVolumelabel.Enabled = false;
                musicVolumeTrackBar.Enabled = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void sectionButton_Click(object sender, EventArgs e)
        {
            if (global == true)
            {
                sectionButton.Text = MainForm.rom;
                global = false;
                Facade.Load(this, MainForm.rom);
            }
            else if (global == false)
            {
                sectionButton.Text = "Global";
                global = true;
                Facade.Load(this);
            }
        }

        #endregion
    }
}
