namespace digitalAgency.Application.Wrappers
{

    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }

        public Result()
        {
            Errors = new List<string>();
        }

        public Result(bool success, string message = null)
        {
            Success = success;
            Message = message;
            Errors = new List<string>();
        }

        public static Result SuccessResult(string message = "Operation successful")
        {
            return new Result(true, message);
        }

        public static Result FailureResult(string message)
        {
            return new Result(false, message);
        }

        public static Result FailureResult(List<string> errors)
        {
            return new Result
            {
                Success = false,
                Errors = errors
            };
        }
    }

    public class Result<T> : Result
    {
        public T Data { get; set; }

        public Result()
        {
        }

        public Result(T data, string message = null) : base(true, message)
        {
            Data = data;
        }

        public static Result<T> SuccessResult(T data, string message = "Operation successful")
        {
            return new Result<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        public new static Result<T> FailureResult(string message)
        {
            return new Result<T>
            {
                Success = false,
                Message = message
            };
        }

        public new static Result<T> FailureResult(List<string> errors)
        {
            return new Result<T>
            {
                Success = false,
                Errors = errors
            };
        }
    }
}


