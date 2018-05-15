using System;

namespace Corxx.Shared.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            DateTimeInserted = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime DateTimeInserted { get; private set; }
    }
}
