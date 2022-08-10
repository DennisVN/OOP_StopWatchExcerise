using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyStopwatch
{
    public class Stopwatch
    {
        private DateTime _startCount;
        private DateTime _stopCount;
        private TimeSpan _totalTime;
        private bool _isRunning;

        public void StartWatch()
        {   if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }
            _startCount = DateTime.Now;
            _isRunning = true;

            Console.WriteLine("stopwatch started ");
        }

        public TimeSpan StopWatch()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running");
            }

            _stopCount = DateTime.Now;
            _isRunning = false;
            _totalTime = _stopCount - _startCount;

            Console.WriteLine("stopwatch stopped : " + _totalTime);

            return _totalTime;
        }
    }
}


