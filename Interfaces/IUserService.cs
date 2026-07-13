namespace FirstMinimalApi;
public interface IUserService
{
    Task<ApiResponse<User>> RegisterUser(RegisterRequest request);
    ApiResponse<User> LoginUser(LoginRequest request);
    Task<ApiResponse<User[]>> AllUsers();
}