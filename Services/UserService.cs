using Microsoft.EntityFrameworkCore;
using FirstMinimalApi.Utilities;

namespace FirstMinimalApi;

public class UserService(AppDbContext _context) : IUserService
{
    public async Task<ApiResponse<User>> RegisterUser(RegisterRequest request)
    {
        var user = new User {
            Username = request.Username,
            Password = PWHasher.Hash(request.Password),
            FirstName = request.FirstName,
            LastName = request.LastName
        };
        _context.Add<User>(user);
        await _context.SaveChangesAsync();
        return ApiResponse<User>.Response(user, 200, "User has been registered.");
    }
    public ApiResponse<User> LoginUser(LoginRequest request)
    {
        var user = _context.User.FirstOrDefault<User>(dbUser => dbUser.Username == request.Username);

        if (user != null)
        {
            var validCredentials = PWHasher.ValidateHash(user.Password, request.Password);
            if (validCredentials)
            {
                return ApiResponse<User>.Response(user, 200, "User has been logged in.");
            }
            else
            {
                return ApiResponse<User>.Response(new User(), 422, "Invalid credentials.");
            }
        }
        else
        {
            return ApiResponse<User>.Response(new User(), 404, "User not found.");
        }
    }
    public async Task<ApiResponse<User[]>> AllUsers()
    {
        var users = await _context.User.ToArrayAsync();
        return ApiResponse<User[]>.Response(users, 200, "All users!");
    }
}