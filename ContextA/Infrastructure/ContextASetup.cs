using ContextA.Contracts;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace ContextA.Infrastructure;

public class ContextASetup : IContextSetup
{
    public void RegisterServices(IServiceCollection serviceCollection)
    {
    }

    public IEnumerable<IRequestRegistration> RequestRegistrations { get; } =
        new List<IRequestRegistration>
        {
            new RequestRegistration<ExampleRequestHandler, ExampleRequest>()
        };
}