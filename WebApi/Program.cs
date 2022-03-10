using ContextA.Infrastructure;
using Infrastructure;
using MassTransit;
using Shared;

var builder = WebApplication.CreateBuilder(args);

var setups = new List<IContextSetup>
{
    new ContextASetup()
};

setups.ForEach(setup => setup.RegisterServices(builder.Services));
builder.Services.AddTransient(typeof(IRequester<,>), typeof(MassTransitRequester<,>));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddMassTransit(x =>
    {
        setups.ForEach(setup =>
        {
            setup.ProvidedQueries.ToList().ForEach(providedQuery =>
            {
                x.AddConsumer(providedQuery.HandlerType);
                x.AddRequestClient(providedQuery.RequestType);
            });
        });

        x.UsingInMemory((context, cfg) =>
        {
            cfg.ConfigureEndpoints(context);
        });

    })
    .AddMassTransitHostedService();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
