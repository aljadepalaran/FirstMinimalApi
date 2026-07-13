using Microsoft.EntityFrameworkCore;

namespace FirstMinimalApi;

public class UserService(AppDbContext _context) : IUserService
{
    public ApiResponse<User> RegisterUser(RegisterRequest request)
    {
        var user = new User {
            Username = request.Username,
            Password = request.Password,
            FirstName = request.FirstName,
            LastName = request.LastName
        };
        var result = _context.Add<User>(user);
        Console.WriteLine($"Creating User Result: {result}");
        _context.SaveChanges();
        return ApiResponse<User>.Response(user, 200, "User has been registered.");
    }
    public ApiResponse<User> LoginUser(LoginRequest request)
    {
        var user = new User { Username = request.Username, Password = request.Password };
        return ApiResponse<User>.Response(user, 200, "User has been logged in");
    }
    public async Task<ApiResponse<User[]>> AllUsers()
    {
        var users = await _context.User.ToArrayAsync();
        return ApiResponse<User[]>.Response(users, 200, "All users!");
    }
}