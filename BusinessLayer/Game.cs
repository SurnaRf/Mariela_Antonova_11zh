using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class Game
	{
        [Key]
		public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Name should be less than 20 symbols")]
        public string Name { get; set; }

        public List<User> Users { get; set; }

        public List<Genre> Genres { get; set; }

        private Game()
        {
            Users = new List<User>();
            Genres = new List<Genre>();
        }
        public Game(string name)
		{
			Name = name;
            Genres = new List<Genre>();
			Users = new List<User>();
		}
	}
}
