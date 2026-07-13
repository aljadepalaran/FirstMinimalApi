using Microsoft.AspNetCore.StaticAssets;

namespace FirstMinimalApi;

public class ApiResponse<T>
{
    public T? Data {get;set;}
    public int StatusCode { get;set; }

    public static ApiResponse<T> Response(T data, int statusCode)
    {
        return new ApiResponse<T>
        {
            Data = data,
            StatusCode = statusCode
        };
    }
}