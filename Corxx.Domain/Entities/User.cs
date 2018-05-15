using Corxx.Domain.ValueObjects;
using Corxx.Shared.Entities;

namespace Corxx.Domain.Entities
{
    public class User : Entity
    {
        protected User() { }
        public User(Email email, Name name)
        {
            Name = name;
            Email = email;
        }

        public Email Email { get; private set; }
        public Name Name { get; private set; }
    }
}
