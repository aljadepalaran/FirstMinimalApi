namespace FirstMinimalApi;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this WebApplication app)
    {
        app.MapPost("/register", (RegisterRequest request, IUserService userService) =>
        {
            var response = userService.RegisterUser(request);
            return response;
        });
    }
}