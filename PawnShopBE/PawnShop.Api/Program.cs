using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using PawnShop.Api.Errors;
using PawnShop.Api.Filters;
using PawnShop.Application;
using PawnShop.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication().AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddSingleton<ProblemDetailsFactory, PawnShopProblemDetailsFactory>();

//builder.Services.AddControllers(options => 
//options.Filters.Add<ErrorHandlingFilterAttribute>());

var app = builder.Build();
//app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseExceptionHandler("/error");

app.Map("/error", (HttpContext httpContext) =>
{
    Exception? exception = httpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
    
    return Results.Problem();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
