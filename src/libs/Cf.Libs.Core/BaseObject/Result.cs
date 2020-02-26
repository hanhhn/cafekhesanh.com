using Cf.Libs.Core.Enums;
using System.Collections.Generic;

namespace Cf.Libs.Core.BaseObject
{
    public class Result<T>
    {
        public StatusCode Code { get; set; } 
        public List<Message> Messages { get; set; }
        public T Data { get; set; }

        public Result()
        {
            Code = StatusCode.OK;
            Messages = new List<Message>();
        }
    }
}