using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
	public class User
	{

		[Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Name should be less than 20 symbols")]
        public string FirstName{ get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Last name should be less than 20 symbols")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Username should be less than 20 symbols")]
        public string Username { get; set; }

        [Range(0, 80, ErrorMessage = "Age should be between 0 and 80")]
        public int Age { get; set; }

        [Required]
        [MaxLength(70, ErrorMessage = "Password should be less than 70 symbols")]
        public string Password { get; set; }

        [Required]
        [MaxLength (20, ErrorMessage = "Email should be less than 20 symbols")]
        public string Email { get; set; }

        public List<User> Friends { get; set; }

        public List<Game> Games { get; set; }

		public User(string firstName,
            string lastName,
            string username, 
            int age,
            string password,
            string email)
		{
			FirstName = firstName;
			LastName = lastName;
			Username = username;
			Age = age;
			Password = password;
			Email = email;
            Friends = new List<User>();
            Games = new List<Game>();
		}
	}
}
