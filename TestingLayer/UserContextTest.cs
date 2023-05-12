using BusinessLayer;
using DataLayer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
	[TestFixture]
	public class UserContextTest
	{
		private UserContext context = new(SetupFixture.dbContext);
		private Game game1, game2;
		private User user, f1, f2;

		[SetUp]
		public void Setup()
		{
			user = new("Mariela", "Antonova", "SurnaRf", 17, "AReallyCoolPassword", "antonovamemi22@gmail.com");

			f1 = new("Ralitsa", "Toteva", "Ralitsa2008", 17, "AReallyCoolPassword3", "ralitsatoteva_zh19@schoolmath.eu");
			f2 = new("Maria", "Petrova", "mariika62", 17, "AReallyCoolPassword2", "mariapetrova_zh19@schoolmath.eu");
			game1 = new("My Little Pony Magical Princess");
			game2 = new("Minecraft");

			user.Friends.Add(f1);
			user.Friends.Add(f2);
			user.Games.Add(game1);
			user.Games.Add(game2);

			context.Create(user);
		}

		[TearDown]
		public void DropUsers()
		{
			foreach (User item in SetupFixture.dbContext.Users.ToList())
			{
				SetupFixture.dbContext.Users.Remove(item);
			}

			SetupFixture.dbContext.SaveChanges();
		}

		[Test]
		public void Create()
		{
			User testUser = new("Mariela", "Antonova", "SurnaRf", 17, "AReallyCoolPassword", "antonovamemi22@gmail.com");
			
			int usersBefore = SetupFixture.dbContext.Users.Count();

			context.Create(testUser);

			int usersAfter = SetupFixture.dbContext.Users.Count();

			Assert.That(usersBefore + 1 == usersAfter, "Create() does not work!");
		}

		[Test]
		public void Read()
		{
			User readUser = context.Read(user.Id);

			Assert.AreEqual(user, readUser, "Read does not return the same object!");
		}

		[Test]
		public void ReadWithNavigationalProperties()
		{
			User readUser = context.Read(user.Id, true);

			Assert.That(readUser.Friends.Contains(f1)
				&& readUser.Friends.Contains(f2)
				&& readUser.Games.Contains(game1)
				&& readUser.Games.Contains(game2),
				"User1 and user2 and game1 and game2 are not in the Users and Games lists!");
		}

		[Test]
		public void ReadAll()
		{
			List<User> users = (List<User>)context.ReadAll();

			Assert.That(users.Count != 0, "ReadAll() does not return users!");
		}


		[Test]
		public void Update()
		{
			User changedUser = context.Read(user.Id);

			user.FirstName = "Updated " + user.FirstName;

			context.Update(changedUser);

			user = context.Read(user.Id);

			Assert.AreEqual(changedUser, user, "Update() does not work!");
		}

		[Test]
		public void Delete()
		{
			int usersBefore = SetupFixture.dbContext.Users.Count();

			context.Delete(user.Id);
			int usersAfter = SetupFixture.dbContext.Users.Count();

			Assert.IsTrue(usersBefore - 1 == usersAfter, "Delete() does not work!");
		}
	}
}
