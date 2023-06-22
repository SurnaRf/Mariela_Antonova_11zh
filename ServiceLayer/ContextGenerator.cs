using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
	public class ContextGenerator
	{
		private static GameWorldDbContext dbContext;
		private static GameContext gameContext;
		private static GenreContext genreContext;
		private static UserContext userContext;

		public static GameWorldDbContext GetDbContext()
		{
			if (dbContext == null)
			{
				SetDbContext();
			}
			return dbContext;
		}

		public static void SetDbContext()
		{
			if (dbContext != null)
			{
				dbContext.Dispose();
			}
			dbContext = new GameWorldDbContext();
		}

		public static GameContext GetGameContext()
		{
			if (gameContext == null)
			{
				SetGameContext();
			}
			return gameContext;
		}

		private static void SetGameContext()
		{
			gameContext = new GameContext(GetDbContext());
		}
		public static GenreContext GetGenreContext()
		{
			if (genreContext == null)
			{
				SetGenreContext();
			}
			return genreContext;
		}

		private static void SetGenreContext()
		{
			genreContext = new GenreContext(GetDbContext());
		}
		public static UserContext GetUserContext()
		{
			if (userContext == null)
			{
				SetUserContext();
			}
			return userContext;
		}

		private static void SetUserContext()
		{
			userContext = new UserContext(GetDbContext());
		}
	}
}
