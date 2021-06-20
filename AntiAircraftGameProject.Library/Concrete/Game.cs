using AntiAircraftGameProject.Library.Enum;
using AntiAircraftGameProject.Library.Interface;
using System;

namespace AntiAircraftGameProject.Library.Concrete
{
    public class Game : IGame
    {
        public bool IsGameContinue { get; private set; }

        public TimeSpan Passedtime { get; }

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
        }

        private void Finish()
        {
            if (!IsGameContinue) return;

            IsGameContinue = false;
        }

    }
}
