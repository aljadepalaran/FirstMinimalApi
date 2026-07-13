namespace FirstMinimalApi;
public interface IUserService
{
    ApiResponse<User> RegisterUser(RegisterRequest request);
    ApiResponse<User> LoginUser(LoginRequest request);
    Task<ApiResponse<User[]>> AllUsers();
}