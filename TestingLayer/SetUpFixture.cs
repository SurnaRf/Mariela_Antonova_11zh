﻿using DataLayer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
	[SetUpFixture]
	public class SetupFixture
	{
		public static GameWorldDbContext dbContext;

		[OneTimeSetUp]
		public static void OneTimeSetUp()
		{
			DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
			builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
			dbContext = new GameWorldDbContext(builder.Options);
		}

		[OneTimeTearDown]
		public static void OneTimeTearDown()
		{
			dbContext.Dispose();
		}
	}
}
