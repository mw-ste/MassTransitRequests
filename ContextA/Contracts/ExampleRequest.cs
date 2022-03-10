using Shared;

namespace ContextA.Contracts;

public class ExampleRequest : Request
{
    public string RequestContent { get; }

    public ExampleRequest(
        string requestId, 
        string requestContent) 
        : base(requestId)
    {
        RequestContent = requestContent;
    }
}