using System.Threading.Tasks;

namespace Corxx.Domain.Services
{
    public interface IEmailService
    {
        Task SendAsync(string from, string displayName, string to, string subject, string body);
    }
}
