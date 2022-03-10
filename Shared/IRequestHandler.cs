namespace Shared;

public interface IQueryHandler
{
}

public interface IRequestHandler<TRequest, TResponse>
    : IQueryHandler
    where TRequest : Request
    where TResponse : Response
{
    Task<TResponse> HandleQuery(TRequest request);
}