﻿using Corxx.Shared.ValueObjects;

namespace Corxx.Domain.ValueObjects
{
    public class Email : VO
    {
        protected Email() { }
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }

    }
}
