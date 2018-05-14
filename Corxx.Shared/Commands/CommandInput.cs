using System;
using FluentValidation.Results;
using MediatR;

namespace Corxx.Shared.Commands
{
    public abstract class CommandInput : INotification
    {
        public CommandInput()
        {
            Timespan = DateTime.Now;
        }

        public ValidationResult ValidationResult { get; set; }

        public DateTime Timespan { get; private set; }

        public abstract bool IsValid();
    }
}
