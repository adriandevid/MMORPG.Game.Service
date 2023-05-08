using MediatR;
using MMORPG.Game.Service.Application.UseCases.Abilitie.Requests;
using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;
using MMORPG.Game.Service.Application.UseCases.Item.Requests;
using MMORPG.Game.Service.Application.UseCases.Person.Requests;
using MMORPG.Game.Service.Infrastructure.IOC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapperConfiguration();
builder.Services.AddRepositoriesConfiguration();
builder.Services.AddMediatrConfiguration();
builder.Services.AddContextConfiguration();
builder.Services.AddMartenConfiguration();
builder.Services.AddCors((options) => {
        options.AddPolicy("Total", optionPolicy =>
            {
                optionPolicy.AllowAnyOrigin();
                optionPolicy.AllowAnyMethod();
                optionPolicy.AllowAnyHeader();
            }
        );;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("Total");

app.MapPost("api/person", async (CreatePersonRequest request, IMediator mediator) =>
{
    return await mediator.Send<ApiResponse>(request);
})
.WithName("Person");

app.MapPost("api/person/append-abilities-person/", async (AppendAbilitiesPersonRequest request, IMediator mediator) =>
{
    return await mediator.Send<ApiResponse>(request);
})
.WithName("Person/append-abilities-person/");

app.MapPost("api/person/append-item-person/", async (AppendItemPersonRequest request, IMediator mediator) =>
{
    return await mediator.Send<ApiResponse>(request);
})
.WithName("Person/append-item-person/");


////
///<summary>
/// Item
/// </summary>
///
app.MapPost("api/item", async (CreateItemRequest request, IMediator mediator) =>
{
    return await mediator.Send<ApiResponse>(request);
})
.WithName("api/item");


app.MapPost("api/item/append-abilitie-item", async (AppendAbilitieItemRequest request, IMediator mediator) =>
{
    return await mediator.Send<ApiResponse>(request);
})
.WithName("api/item/append-abilitie-item");

////
///<summary>
/// Abilitie
/// </summary>
///
app.MapPost("api/abilitie", async (CreateAbilitieRequest request, IMediator mediator) =>
{
    return await mediator.Send<ApiResponse>(request);
})
.WithName("api/abilitie");

app.Run();