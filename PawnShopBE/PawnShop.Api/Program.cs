using PawnShop.Application;
using PawnShop.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication().AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();

