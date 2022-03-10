using Shared;

namespace Infrastructure;

public interface IProvidedQuery
{
    public Type RequestType { get; }
    public Type HandlerType { get; }
}

public class ProvidedQuery<THandler, TRequest>
    : IProvidedQuery
    where THandler : IQueryHandler
    where TRequest : QueryRequest
{
    public Type RequestType => typeof(TRequest);
    public Type HandlerType => typeof(THandler);
}