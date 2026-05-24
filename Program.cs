var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

//REST api => GET, POST, PUT, DELETE
app.MapGet("/", () =>
{
    return "Api is working....";
});

app.MapGet("/hello", () =>
{
    return "Api is working....";
});

app.MapPost("/hello", () =>
{
    return "Api is working....";
});

app.Run();
