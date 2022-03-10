namespace Shared;

public abstract class Response
{
    protected Response(string requestId)
    {
        RequestId = requestId;
    }

    public string RequestId { get; }
}