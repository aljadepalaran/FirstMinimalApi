using FirstMinimalApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddOpenApi()
    .AddScoped<IUserService, UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapUserEndpoints();
app.MapGet("/", () =>
{
    return("Welcome to the homepage");
}).WithName("Homepage");

app.Run();