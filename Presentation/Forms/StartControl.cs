using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class StartControl : UserControl
    {
        public StartControl()
        {
            InitializeComponent();
        }

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Project Button Clicked!!!!!!!!!!!!!");
            if (this.Parent is Panel MainPanel)
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(new NewProjectControl());
            }
        }

        private void LoadProjectButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Load Project Button Clicked!!!!!!!!!!!");
        }
    }
}
