using System.Threading.Tasks;

namespace Corxx.Infra
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Rollback();
    }
}
