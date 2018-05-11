using Corxx.Domain.Entities;
using Corxx.Domain.Repositories;
using Corxx.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corxx.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CorxxDataContext _context;

        public UserRepository(CorxxDataContext context)
        {
            _context = context;
        }

        public async Task<ICollection<User>> GetAllAsync()
        {
            var query = _context
                    .Users
                    .AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            var query = _context
                    .Users
                    .AsNoTracking()
                    .Where(x => x.Email.Address == email);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            var query = _context
                    .Users
                    .AsNoTracking()
                    .Where(x => x.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task SaveAsync(User entity)
        {
            await _context.Users.AddAsync(entity);
        }

        public void Update(User entity)
        {
            _context.Entry<User>(entity).State = EntityState.Modified;
        }
        public void Delete(User entity)
        {
            _context.Users.Remove(entity);
        }
    }
}
