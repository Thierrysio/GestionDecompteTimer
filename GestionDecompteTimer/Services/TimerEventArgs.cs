using System;

namespace GestionDecompteTimer.Services
{
    public class TimerEventArgs : EventArgs
    {
        public TimeSpan TempsRestant { get; set; }

    }

}
