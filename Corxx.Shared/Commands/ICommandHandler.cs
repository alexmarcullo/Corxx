namespace Corxx.Shared.Commands
{
    public interface ICommandHandler<T> where T : CommandInput
    {
        CommandOutput Handler(T command);
    }
}
