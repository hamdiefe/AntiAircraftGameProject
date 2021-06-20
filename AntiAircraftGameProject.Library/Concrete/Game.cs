using AntiAircraftGameProject.Library.Enum;
using AntiAircraftGameProject.Library.Interface;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace AntiAircraftGameProject.Library.Concrete
{
    public class Game : IGame
    {

        private readonly Timer _passedTimeTimer = new Timer { Interval = 1000 };

        private TimeSpan _passedTime;

        public event EventHandler PassedTimeChanged;

        private readonly Panel _antiAircraftPnl;

        public Game(Panel antiAirCraftPnl)
        {
            _antiAircraftPnl = antiAirCraftPnl;
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

            CreateAntiAirCraft();
        }

        private void CreateAntiAirCraft()
        {
            var antiAircraft = new AntiAircraft(_antiAircraftPnl.Width)
            {
                Image = Image.FromFile(@"images\antiaircraft.png")
            };
            _antiAircraftPnl.Controls.Add(antiAircraft);
        }

        private void Stop()
        {
            if (!IsGameContinue) return;

            IsGameContinue = false;
            _passedTimeTimer.Stop();
        }

    }
}
