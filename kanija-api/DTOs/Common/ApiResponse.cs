namespace kanija_api.DTOs.Common
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; } // Dữ liệu trả về
        public List<string> Errors { get; set; } = new();

        public ApiResponse(bool success, string message, T data, List<string> errors = null)
        {
            Success = success;
            Message = message;
            Data = data;
            Errors = errors ?? new List<string>();
        }

        public static ApiResponse<T> SuccessResponse(T data, string message = "Request successful")
        {
            return new ApiResponse<T>(true, message, data);
        }

        public static ApiResponse<T> ErrorResponse(string message, List<string> errors = null)
        {
            return new ApiResponse<T>(false, message, default, errors);
        }
    }
}