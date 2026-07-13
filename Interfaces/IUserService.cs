namespace FirstMinimalApi;
public interface IUserService
{
    ApiResponse<User> RegisterUser(RegisterRequest request);
    ApiResponse<User> LoginUser(RegisterRequest request);
}