using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

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
    return "PUT: api is working....";
});

app.MapDelete("/hello", () =>
{
    return "DELETE: api is working....";
});

app.Run();
