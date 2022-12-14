using GestionDecompteTimer.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDecompteTimer.Interfaces
{
    interface IDecompteTimer
    {
        void Start(TimeSpan CountdownTime);
        void Stop();

        event EventHandler<TimerEventArgs> TicTac;
        event EventHandler Complet;
        event EventHandler Avorte;
    }
}