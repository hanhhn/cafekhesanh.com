using Cf.Libs.Core.Enums;

namespace Cf.Libs.Core.BaseObject
{
    public class Message
    {
        public MsgType Type { get; set; }
        public string Content { get; set; }
    }
}