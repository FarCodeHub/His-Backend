using System.Collections.Generic;

namespace Core.His.Models
{
    public interface IResponseResult
    {
        ResponseStatus Status { get; set; }
        string Message { get; set; }
        IEnumerable<string> Errors { get; set; }
        int Page { get; set; }
        int TotalItems { get; set; }
        object Data { get; set; }
    }
    public class ResponseResult : IResponseResult
    {
        public ResponseStatus Status { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public int Page { get; set; }
        public int TotalItems { get; set; }
        public object Data { get; set; }
        public static ResponseResult Success(string message)
        {
            return new ResponseResult
            {
                Message = message,
                Status = ResponseStatus.Success
            };
        }

        public static ResponseResult NoTValid(string message)
        {
            return new ResponseResult
            {
                Message = message,
                Status = ResponseStatus.NotValid
            };
        }

        public static ResponseResult Unknow(string message)
        {
            return new ResponseResult
            {
                Message = message,
                Status = ResponseStatus.Unknow
            };
        }

        public static ResponseResult Fail(string message)
        {
            return new ResponseResult
            {
                Message = message,
                Status = ResponseStatus.Fail
            };
        }
    }

    public enum ResponseStatus
    {
        Unknow,
        Fail,
        Success,
        NotValid,
        NotFound
    }

}
