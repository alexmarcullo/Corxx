using Corxx.Shared.ValueObjects;

namespace Corxx.Domain.ValueObjects
{
    public class Name : VO
    {
        protected Name() { }
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

    }
}
