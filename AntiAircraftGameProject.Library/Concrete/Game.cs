using AntiAircraftGameProject.Library.Enum;
using AntiAircraftGameProject.Library.Interface;
using System;
using System.Windows.Forms;

namespace AntiAircraftGameProject.Library.Concrete
{
    public class Game : IGame
    {

        private readonly Timer _passedTimeTimer = new Timer { Interval = 1000 };

        private TimeSpan _passedTime;

        public event EventHandler PassedTimeChanged;

        public Game()
        {
            _passedTimeTimer.Tick += PassedTime_Tick;
        }

        public TimeSpan PassedTime
        {
            get => _passedTime;
            private set
            {
                _passedTime = value;
                PassedTimeChanged.Invoke(this, EventArgs.Empty);
            }
        }

        private void PassedTime_Tick(object sender, EventArgs e)
        {
            PassedTime += TimeSpan.FromSeconds(1);
        }

        public bool IsGameContinue { get; private set; }


        public void Fire()
        {
            throw new NotImplementedException();
        }

        public void MoveAircraft(Direction direction)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            if (IsGameContinue) return;

            IsGameContinue = true;
            _passedTimeTimer.Start();
        }

        private void Stop()
        {
            if (!IsGameContinue) return;

            IsGameContinue = false;
            _passedTimeTimer.Stop();
        }

    }
}
