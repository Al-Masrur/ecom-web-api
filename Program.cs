var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/Hello", () =>
{
    return "This is from mapGet function";
});

app.Run();
