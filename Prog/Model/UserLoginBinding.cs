﻿using System.ComponentModel.DataAnnotations;

namespace Prog.Model
{
	public class UserLoginBinding
	{
		[Display(Name = "Login")]
		[Required(ErrorMessage = "Login is required")]
		public string Login { get; set;}

		[Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,20}$", ErrorMessage = "Password is between 6 and 20 characters long, contains at least one uppercase letter, one lowercase letter, one digit")]
        [Display(Name = "Password")]
		[UIHint("Password")]
		public string Password { get; set;}
	}
}
