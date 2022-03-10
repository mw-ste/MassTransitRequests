using ContextA.Contracts;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace ContextA.Infrastructure;

public class ContextASetup : IContextSetup
{
    public void RegisterServices(IServiceCollection serviceCollection)
    {
    }

    public IEnumerable<IProvidedQuery> ProvidedQueries { get; } =
        new List<IProvidedQuery>
        {
            new ProvidedQuery<DummyQueryHandler, DummyRequest>()
        };
}