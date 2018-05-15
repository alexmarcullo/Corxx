using Corxx.Infra.Data;
using System.Threading.Tasks;

namespace Corxx.Infra
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CorxxDataContext _context;

        public UnitOfWork(CorxxDataContext context)
        {
            _context = context;
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Rollback()
        {
        }
    }
}
