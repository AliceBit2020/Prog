using System.ComponentModel.DataAnnotations;

namespace Prog.Model
{
    public class UserRegBinding
    {
		
		[Display(Name ="Login")]
		[Required(ErrorMessage = "Login is required")]
		public string Login { get; set; } = string.Empty;

		[Required(ErrorMessage = "Email is required")]
		[EmailAddress]
		[Display(Name ="Email")]
		[UIHint("Email")]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = "Password is required")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,20}$", ErrorMessage = "Password is between 6 and 20 characters long, contains at least one uppercase letter, one lowercase letter, one digit")]
		[Compare("PasswordConfirm", ErrorMessage = "Password must confirm")]
		[Display(Name = "Password")]
        [UIHint("Password")]
		public string Password { get; set; } = string.Empty;

		[Required(ErrorMessage = "PasswordConfirm is required")]
		[Display(Name = "Confirm password")]
        [UIHint("Password")]
        public string PasswordConfirm { get; set; } = string.Empty;
		

	}
}
