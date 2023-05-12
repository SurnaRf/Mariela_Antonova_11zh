using BusinessLayer;
using DataLayer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
	[TestFixture]
	public class GameContextTest
	{
		private GameContext context = new(SetupFixture.dbContext);
		private Game game;
		private Genre g1, g2;
		private User u1, u2;

		[SetUp]
		public void Setup()
		{
			game = new("Cats And Soup");

			u1 = new("Ralitsa", "Toteva", "Ralitsa2008", 17, "AReallyCoolPassword3", "ralitsatoteva_zh19@schoolmath.eu");
			u2 = new("Maria", "Petrova", "mariika62", 17, "AReallyCoolPassword2", "mariapetrova_zh19@schoolmath.eu");
			g1 = new("RPG");
			g2 = new("Shooter");

			game.Users.Add(u1);
			game.Users.Add(u2);
			game.Genres.Add(g1);
			game.Genres.Add(g2);

			context.Create(game);
		}

		[TearDown]
		public void DropGames()
		{
			foreach (Game item in SetupFixture.dbContext.Games.ToList())
			{
				SetupFixture.dbContext.Games.Remove(item);
			}

			SetupFixture.dbContext.SaveChanges();
		}

		[Test]
		public void Create()
		{
			Game testGame = new("League Of Legends");			

			int gamesBefore = SetupFixture.dbContext.Games.Count();

			context.Create(testGame);

			int gamesAfter = SetupFixture.dbContext.Games.Count();

			Assert.That(gamesBefore + 1 == gamesAfter, "Create() does not work!");
		}

		[Test]
		public void Read()
		{
			Game readGame = context.Read(game.Id);

			Assert.AreEqual(game, readGame, "Read does not return the same object!");
		}

		[Test]
		public void ReadWithNavigationalProperties()
		{
			Game readGame = context.Read(game.Id, true);

			Assert.That(readGame.Users.Contains(u1)
				&& readGame.Users.Contains(u2)
				&& readGame.Genres.Contains(g1)
				&& readGame.Genres.Contains(g2),
				"U1 and u2 and g1 and g2 are not in the Users and Genres lists!");
		}

		[Test]
		public void ReadAll()
		{
			List<Game> games = (List<Game>)context.ReadAll();

			Assert.That(games.Count != 0, "ReadAll() does not return users!");
		}


		[Test]
		public void Update()
		{
			Game changedGame = context.Read(game.Id);

			game.Name = "Updated " + game.Name;

			context.Update(changedGame);

			game = context.Read(game.Id);

			Assert.AreEqual(changedGame, game, "Update() does not work!");
		}

		[Test]
		public void Delete()
		{
			int gamesBefore = SetupFixture.dbContext.Games.Count();

			context.Delete(game.Id);
			int gamesAfter = SetupFixture.dbContext.Games.Count();

			Assert.IsTrue(gamesBefore - 1 == gamesAfter, "Delete() does not work!");
		}
	}
}
