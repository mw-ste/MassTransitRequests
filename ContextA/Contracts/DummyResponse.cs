using Shared;

namespace ContextA.Contracts;

public class DummyResponse : QueryResponse
{
    public string ResponseContent { get; }

    public DummyResponse(
        string requestId, 
        string responseContent) 
        : base(requestId)
    {
        ResponseContent = responseContent;
    }
}