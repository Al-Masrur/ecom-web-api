var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

//REST api => GET, POST, PUT, DELETE
app.MapGet("/", () =>
{
    return "GET: api is working.";
});

app.MapGet("/hello", () =>
{
    return "GET: api is working....";
});

app.MapPost("/hello", () =>
{
    return "POST: api is working.....";
});

app.MapPut("/hello", () =>
{
    return "PUT: api is working"
});

app.Run();
