﻿using System.ComponentModel.DataAnnotations;

namespace LAllermannWebsite.Models.ViewModels
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Username is required")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }
	}
}
