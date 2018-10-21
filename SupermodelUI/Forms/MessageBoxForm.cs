using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermodelUI.Forms
{
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm(Form parent, string message)
        {
            InitializeComponent();

            this.Location = Facade.CalculateStartPosition(parent, this);
            textLabel.Text = message;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
