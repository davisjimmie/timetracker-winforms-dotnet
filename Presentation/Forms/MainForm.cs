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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadStartControl();
        }

        private void LoadStartControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new StartControl());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
