using Corxx.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Corxx.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<ICollection<User>> GetAllAsync();

        Task<User> GetByIdAsync(Guid id);

        Task<User> GetByEmailAsync(Guid id);

        Task SaveAsync(User entity);

        Task UpdateAsync(User entity);

        Task DeleteAsync(User entity);

    }
}
