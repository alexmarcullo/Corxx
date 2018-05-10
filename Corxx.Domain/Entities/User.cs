using Corxx.Domain.ValueObjects;
using Corxx.Shared.Entities;

namespace Corxx.Domain.Entities
{
    public class User : Entity
    {
        public User(Name name, Email email)
        {
            Name = name;
            Email = email;
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }

    }
}
