namespace Shared;

public abstract class QueryRequest
{
    protected QueryRequest(string requestId)
    {
        RequestId = requestId;
    }

    public string RequestId { get; }
}