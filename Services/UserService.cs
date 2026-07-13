namespace FirstMinimalApi;

public class UserService : IUserService
{
    public ApiResponse<User> RegisterUser(RegisterRequest request)
    {
        var user = new User { Username = request.Username, Password = request.Password };
        return ApiResponse<User>.Response(user, 200);
    }
    public ApiResponse<User> LoginUser(RegisterRequest request)
    {
        var user = new User { Username = request.Username, Password = request.Password };
        return ApiResponse<User>.Response(user, 200);
    }
}