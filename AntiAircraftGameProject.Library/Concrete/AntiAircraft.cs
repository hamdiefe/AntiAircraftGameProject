namespace AntiAircraftGameProject.Library.Concrete
{
    internal class AntiAircraft : Mass
    {
        public AntiAircraft(int pnlWith)
        {
            Left = (pnlWith / 2) - (Width / 2);
        }
    }
}
