namespace Shared;

public abstract class QueryResponse
{
    protected QueryResponse(string requestId)
    {
        RequestId = requestId;
    }

    public string RequestId { get; }
}