using System.Diagnostics;
using TimeTracker.Presentation.Components;

namespace TimeTracker
{
    public partial class Form1 : Form
    {
        private readonly TimerComponent _timer;
        private readonly NewProjectComponent _projectComponent;

        public Form1()
        {
            InitializeComponent();
            _timer = new TimerComponent(TimeDisplay);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startTimeButton_Click(object sender, EventArgs e)
        {
            _timer.StartTimer();
        }

        private void stopTimeButton_Click(object sender, EventArgs e)
        {
            _timer.StopTimer();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
        }
    }
}