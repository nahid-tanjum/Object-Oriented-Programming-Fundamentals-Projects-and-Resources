using CounterTask;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Clock
{
    public class Clock
    {
        private Counter _hourCounter;
        private Counter _minuteCounter;
        private Counter _secondCounter;

        public Clock()
        {
            _hourCounter = new Counter("hour");
            _minuteCounter = new Counter("minute");
            _secondCounter = new Counter("second");
            Reset();
        }
        public int Hours
        {
            get { return _hourCounter.Ticks; }
        }

        public int Minutes
        {
            get { return _minuteCounter.Ticks; }
        }

        public int Seconds
        {
            get { return _secondCounter.Ticks; }
        }

        public void Tick()
        {
            _secondCounter.Increment();

            if (_secondCounter.Ticks == 60)
            {
                _secondCounter.Reset();
                _minuteCounter.Increment();

                if (_minuteCounter.Ticks == 60)
                {
                    _minuteCounter.Reset();
                    _hourCounter.Increment();

                    if (_hourCounter.Ticks == 24)
                    {
                        _hourCounter.Reset();
                    }
                }
            }
        }
        public string PrintTime()
        {
            return _hourCounter.Ticks.ToString("D2") + ":" + _minuteCounter.Ticks.ToString("D2") + ":" + _secondCounter.Ticks.ToString("D2");
        }

            public void Reset()
        {
            _hourCounter.Reset();
            _minuteCounter.Reset();
            _secondCounter.Reset();
        }

    }
}

