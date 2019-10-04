namespace HumanResource.Utils
{
    public class SessionLoginResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public SessionLoginResult(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}