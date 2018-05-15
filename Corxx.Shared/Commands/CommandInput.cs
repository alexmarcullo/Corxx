using Flunt.Notifications;
using System;

namespace Corxx.Shared.Commands
{
    public abstract class CommandInput : Notifiable
    {
        public CommandInput()
        {
            Timespan = DateTime.Now;
        }

        public DateTime Timespan { get; private set; }

        public abstract bool IsValid();
    }
}
