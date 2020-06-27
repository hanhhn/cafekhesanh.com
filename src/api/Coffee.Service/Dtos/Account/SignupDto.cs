namespace Coffee.Service.Dtos.Account
{
	public class SignupDto
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public string MatchPassword { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Phone { get; set; }
	}
}