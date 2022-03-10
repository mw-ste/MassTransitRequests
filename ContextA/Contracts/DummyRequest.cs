using Shared;

namespace ContextA.Contracts;

public class DummyRequest : QueryRequest
{
    public string RequestContent { get; }

    public DummyRequest(
        string requestId, 
        string requestContent) 
        : base(requestId)
    {
        RequestContent = requestContent;
    }
}