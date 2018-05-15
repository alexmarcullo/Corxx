using System.Threading.Tasks;

namespace Corxx.Shared.Commands
{
    public interface ICommandHandler<T> where T : CommandInput
    {
        Task<ICommandOutput> Handler(T command);
    }
}
