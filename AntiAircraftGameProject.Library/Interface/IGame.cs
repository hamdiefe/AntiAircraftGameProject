using AntiAircraftGameProject.Library.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGameProject.Library.Interface
{
    internal interface IGame
    {
        event EventHandler PassedTimeChanged;

        bool IsGameContinue { get; }

        TimeSpan PassedTime { get; }

        void Start();

        void Fire();

        void MoveAircraft(Direction direction);
    }
}
