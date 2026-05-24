var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

//REST api => GET, POST, PUT, DELETE
app.MapGet("/Hello", () =>
{
    return "This is from mapGet function";
});

app.Run();
