﻿using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public interface IContextSetup
{
    void RegisterServices(IServiceCollection serviceCollection);

    IEnumerable<IProvidedQuery> ProvidedQueries { get; }
}