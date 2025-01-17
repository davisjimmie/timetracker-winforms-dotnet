using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Presentation.Components;

public class TimerComponent
{
    private int totalMilliseconds = 0;
    private bool _isTimerPaused = true;
    private bool _isNewTimer = true;
    private string _elapsedTime;
    private readonly Label timeDisplay;



    public TimerComponent(Label timeDisplay)
    {
        this.timeDisplay = timeDisplay;
    }



    public async Task UpdateTimeDisplay()
    {
        while (true)
        {
            while (_isTimerPaused)
            {
                await Task.Delay(100);
            }

            int milliseconds = totalMilliseconds % 1000;
            int seconds = totalMilliseconds / 1000 % 60;
            int minutes = totalMilliseconds / 1000 / 60;
            int hours = totalMilliseconds / 1000 / 60 / 60;

            timeDisplay.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}.{milliseconds / 10:D2}";

            await Task.Delay(10);
            totalMilliseconds += 10;
        }
    }



    public void StartTimer()
    {
        if (_isNewTimer == true)
        {
            _isNewTimer = false;
            UpdateTimeDisplay();
        }

        _isTimerPaused = false;
    }



    public void StopTimer()
    {
        _isTimerPaused = true;
    }
}
