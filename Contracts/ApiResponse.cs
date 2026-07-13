namespace FirstMinimalApi;

public class ApiResponse<T>
{
    public T? Data { get; set; }
    public int StatusCode { get; set; }
    public string Message { get; set; }

    public static ApiResponse<T> Response(T data, int statusCode, string message)
    {
        return new ApiResponse<T>
        {
            Data = data,
            StatusCode = statusCode,
            Message = message
        };
    }
}