using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermodelUI
{
    public partial class SystemSettingsForm : Form
    {
        #region Properties

        private bool global = true;

        #endregion

        public SystemSettingsForm(string romName)
        {
            InitializeComponent();
        }

        #region Events

        private void SystemSettings_Load(object sender, EventArgs e)
        {
            Facade.Load(this);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
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
