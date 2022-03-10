using Shared;

namespace ContextA.Contracts;

public class ExampleResponse : Response
{
    public string ResponseContent { get; }

    public ExampleResponse(
        string requestId, 
        string responseContent) 
        : base(requestId)
    {
        ResponseContent = responseContent;
    }
}