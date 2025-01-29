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
            LoadHomeScreen();
        }

        private void LoadHomeScreen()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new HomeScreenUserControl());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
