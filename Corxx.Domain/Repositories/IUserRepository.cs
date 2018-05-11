using Corxx.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Corxx.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<ICollection<User>> GetAllAsync();

        Task<User> GetByIdAsync(Guid id);

        Task<User> GetByEmailAsync(string email);

        Task SaveAsync(User entity);

        void Update(User entity);

        void Delete(User entity);

    }
}
