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
    public partial class GlobalControls : Form
    {
        public List<IniSetting> controlSettings { get; set; }

        public GlobalControls()
        {
            InitializeComponent();
        }

        private void MainControls_Load(object sender, EventArgs e)
        {
            controlSettings = Facade.GetIniSettings();
            Facade.BindControls(this, controlSettings, "sys");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Facade.Save(this, "Global", controlSettings);
            Facade.ShowMessageBox(this, "Settings saved");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
