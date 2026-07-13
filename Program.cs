var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/register", () =>
{
    return("You are now registered");
}).WithName("Register");

app.MapGet("/", () =>
{
    return("Welcome to the homepage");
}).WithName("Homepage");

app.Run();