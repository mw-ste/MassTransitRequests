using Shared;

namespace Infrastructure;

public interface IRequestRegistration
{
    public Type RequestType { get; }
    public Type HandlerType { get; }
}

public class RequestRegistration<THandler, TRequest>
    : IRequestRegistration
    where THandler : IQueryHandler
    where TRequest : Request
{
    public Type RequestType => typeof(TRequest);
    public Type HandlerType => typeof(THandler);
}