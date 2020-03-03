namespace Request
{
    public class Response<T>
    {
        public T Data { get; }
        public bool IsSuccess { get; }
        public string ErrorMessage { get; }
        public int ErrorCode { get; }
    }
}