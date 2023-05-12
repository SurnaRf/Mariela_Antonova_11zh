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
	public class GenreContextTest
	{
		private GenreContext context = new(SetupFixture.dbContext);
		private Genre genre;
		private Game game;
		private User user;

		[SetUp]
		public void Setup()
		{
			genre = new("Puzzle");

			user = new("Mariela", "Antonova", "SurnaRf", 17, "AReallyCoolPassword", "antonovamemi22@gmail.com");
			game = new("My Little Pony Magical Princess");

			genre.Users.Add(user);
			genre.Games.Add(game);

			context.Create(genre);
		}

		[TearDown]
		public void DropGenres()
		{
			foreach (Genre item in SetupFixture.dbContext.Genres.ToList())
			{
				SetupFixture.dbContext.Genres.Remove(item);
			}

			SetupFixture.dbContext.SaveChanges();
		}

		[Test]
		public void Create()
		{
			Genre testGenre = new("Adventure");

			int genresBefore = SetupFixture.dbContext.Genres.Count();

			context.Create(testGenre);

			int genresAfter = SetupFixture.dbContext.Genres.Count();

			Assert.That(genresBefore + 1 == genresAfter, "Create() does not work!");
		}

		[Test]
		public void Read()
		{
			Genre readGenre = context.Read(genre.Id);

			Assert.AreEqual(genre, readGenre, "Read does not return the same object!");
		}

		[Test]
		public void ReadWithNavigationalProperties()
		{
			Genre readCupboard = context.Read(genre.Id, true);

			Assert.That(readCupboard.Users.Contains(user)
				&& readCupboard.Games.Contains(game),
				"User and game are not in the Users and Games lists!");
		}

		[Test]
		public void ReadAll()
		{
			List<Genre> genres = (List<Genre>)context.ReadAll();

			Assert.That(genres.Count != 0, "ReadAll() does not return genres!");
		}


		[Test]
		public void Update()
		{
			Genre changedGenre = context.Read(genre.Id);

			changedGenre.Name = "Updated " + genre.Name;

			context.Update(changedGenre);

			genre = context.Read(genre.Id);

			Assert.AreEqual(changedGenre, genre, "Update() does not work!");
		}

		[Test]
		public void Delete()
		{
			int genresBefore = SetupFixture.dbContext.Genres.Count();

			context.Delete(genre.Id);
			int genresAfter = SetupFixture.dbContext.Genres.Count();

			Assert.IsTrue(genresBefore - 1 == genresAfter, "Delete() does not work!");
		}
	}
}
