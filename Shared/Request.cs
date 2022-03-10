namespace Shared;

public abstract class Request
{
    protected Request(string requestId)
    {
        RequestId = requestId;
    }

    public string RequestId { get; }
}