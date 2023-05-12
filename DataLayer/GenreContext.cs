using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
	public class GenreContext : IDb<Genre, int>
	{
		private readonly GameWorldDbContext dbContext;

        public GenreContext(GameWorldDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Genre item)
		{
			try
			{
				List<Game> games = new();
				List<User> users = new();

				foreach (User user in item.Users)
				{
					User userFromDb = dbContext.Users.Find(user.Id);

					if (userFromDb != null)
					{
						users.Add(userFromDb);
					}
					else
					{
						users.Add(user);
					}
				}

				foreach (Game game in item.Games)
				{
					Game gameFromDb = dbContext.Games.Find(game.Id);

					if (gameFromDb != null)
					{
						games.Add(gameFromDb);
					}
					else
					{
						games.Add(game);
					}
				}
				item.Games = games;
				item.Users = users;
				
				dbContext.Genres.Add(item);
				dbContext.SaveChanges();
			}
			catch (Exception)
			{

				throw;
			}
		}

		public Genre Read(int key, bool useNavigationalProperties = false)
		{
			try
			{
				IQueryable<Genre> query = dbContext.Genres;

				if (useNavigationalProperties)
				{
					query = query.Include(g => g.Games).Include(g => g.Users);
				}

				return query.FirstOrDefault(g => g.Id == key);
			}
			catch (Exception)
			{

				throw;
			}
		}

		public IEnumerable<Genre> ReadAll(bool useNavigationalProperties = false)
		{
			try
			{
				IQueryable<Genre> query = dbContext.Genres;

				if (useNavigationalProperties)
				{
					query = query.Include(g => g.Games).Include(g => g.Users);
				}

				return query.ToList();
			}
			catch (Exception)
			{

				throw;
			}
		}

		public void Update(Genre item, bool useNavigationalProperties = false)
		{
			try
			{
				Genre genre = Read(item.Id, useNavigationalProperties);

				if (genre == null)
				{
					Create(item);
					return;
				}

				genre.Name = item.Name;

				if (useNavigationalProperties)
				{
					List<User> users = new();
					List<Game> games = new();

					foreach (User user in item.Users)
					{
						User userFromDb = dbContext.Users.Find(user.Id);

						if (userFromDb != null)
						{
							users.Add(userFromDb);
						}

						else
						{
							users.Add(user);
						}
					}

					foreach (Game game in item.Games)
					{
						Game gameFromDb = dbContext.Games.Find(game.Id);

						if (gameFromDb != null)
						{
							games.Add(gameFromDb);
						}

						else
						{
							games.Add(game);
						}
					}

					genre.Users = users;
					genre.Games = games;
				}
				dbContext.SaveChanges();
			}
			catch (Exception)
			{

				throw;
			}
		}

		public void Delete(int key)
		{
			try
			{
				Genre genre = Read(key);

				if (genre != null)
				{
					dbContext.Genres.Remove(genre);
					dbContext.SaveChanges();
				}
				else
				{
					throw new InvalidOperationException("A genre with that key does not exist!");
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
