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
	public class UserContext : IDb<User, int>
	{
		private readonly GameWorldDbContext dbContext;

		public UserContext(GameWorldDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public void Create(User item)
		{
			try
			{
				List<User> friends = new();
				List<Game> games = new();

				foreach (User friend in item.Friends)
				{
					User friendFromDb = dbContext.Users.Find(friend.Id);

					if (friendFromDb != null)
					{
						friends.Add(friendFromDb);
					}
					else
					{
						friends.Add(friend);
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
				item.Friends = friends;
				item.Games = games;

				dbContext.Users.Add(item);
				dbContext.SaveChanges();
			}
			catch (Exception)
			{

				throw;
			}
			
		}

		public User Read(int key, bool useNavigationalProperties = false)
		{
			try
			{
				IQueryable<User> query = dbContext.Users;

				if (useNavigationalProperties)
				{
					query = query.Include(u => u.Games).Include(u => u.Friends);
				}

				return query.FirstOrDefault(u => u.Id == key);
			}
			catch (Exception)
			{

				throw;
			}
		}

		public IEnumerable<User> ReadAll(bool useNavigationalProperties = false)
		{
			try
			{
				IQueryable<User> query = dbContext.Users;

				if (useNavigationalProperties)
				{
					query = query.Include(u => u.Games).Include(u => u.Friends);
				}

				return query.ToList();
			}
			catch (Exception)
			{

				throw;
			}
		}

		public void Update(User item, bool useNavigationalProperties = false)
		{
			try
			{
				User user = Read(item.Id, useNavigationalProperties);

				if (user == null)
				{
					Create(user);
					return;
				}

				user.FirstName = item.FirstName;
				user.LastName = item.LastName;
				user.Username = item.Username;
				user.Age = item.Age;
				user.Password = item.Password;
				user.Email = item.Email;

				if (useNavigationalProperties)
				{
					List<User> friends = new();
					List<Game> games = new();

					foreach (User friend in item.Friends)
					{
						User friendFromDb = dbContext.Users.Find(friend.Id);

						if (friendFromDb != null)
						{
							friends.Add(friendFromDb);
						}
						else
						{
							friends.Add(friend);
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
					item.Friends = friends;
					item.Games = games;
				}
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
				User user = Read(key);

				if (user != null)
				{
					dbContext.Users.Remove(user);
					dbContext.SaveChanges();
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
