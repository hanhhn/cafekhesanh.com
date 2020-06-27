namespace Coffee.Libs.Common.Types
{
	public class TResponse<T> : IResponse
	{
		public string Status { get; set; }
		public string[] Errors { get; set; }
		public bool Succeed { get; set; }

		public T Data { get; set; }

		public TResponse()
		{
		}

		public TResponse(T data)
		{
			Status = Common.ErrorCode.Success;
			Data = data;
			Succeed = true;
		}

		public TResponse(string errorCode, string message)
		{
			Status = errorCode;
			Errors = new[] { message };
			Succeed = false;
		}

		public TResponse(string errorCode, string[] messages)
		{
			Status = errorCode;
			Errors = messages;
			Succeed = false;
		}
	}
}