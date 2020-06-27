namespace Coffee.Service.Dtos
{
	public class SigninDto
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}