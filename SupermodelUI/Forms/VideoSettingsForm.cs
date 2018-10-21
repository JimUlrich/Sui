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
    public partial class VideoSettingsForm : Form
    {
        #region Properties

        private bool global = true;

        #endregion

        public VideoSettingsForm()
        {
            InitializeComponent();
        }

        #region Events

        private void VideoSettingsForm_Load(object sender, EventArgs e)
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

        #region Methods   

        private void Reload()
        {
            Cursor.Current = Cursors.WaitCursor;

            if (global == true)
            {
        //        Facade.BindControls(this, globalSettings);
            }
            else if (global == false)
            {
       //         Facade.BindControls(this, gameSettings, rom);
            }

            Cursor.Current = Cursors.Default;
        }

        private void Save()
        {
            //videoConfig.Save(new3dEngine, new3dEngineCheckBox.Checked.ToString(), "bool");
            //videoConfig.Save(vSync, vSyncCheckBox.Checked.ToString(), "bool");
            //videoConfig.Save(throttle, throttleCheckBox.Checked.ToString(), "bool");
            //videoConfig.Save(showFrameRate, showFrameRateCheckBox.Checked.ToString(), "bool");
            //videoConfig.Save(crosshairs, crosshairsCheckBox.Checked.ToString(), "bool");
            //videoConfig.Save(fullScreen, fullScreenCheckBox.Checked.ToString(), "bool");
            //videoConfig.Save(wideScreen, wideScreenCheckBox.Checked.ToString(), "bool");
            //videoConfig.Save(xResolution, xResolutionUpDown.Value.ToString());
            //videoConfig.Save(yResolution, yResolutionUpDown.Value.ToString());

            //try 
            //{
            //    videoConfig.WriteToFile();
            //    MessageBox.Show("Settings saved");
            //    videoConfig.Refresh();
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }



        #endregion

    }
}
