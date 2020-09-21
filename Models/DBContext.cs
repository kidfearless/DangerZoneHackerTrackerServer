using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.Entity;
using System.Configuration;
using HackerTrackerServer.Models;

namespace DangerHackerTrackerServer
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class DBContext : DbContext
	{
		public DbSet<Cheater> Cheaters	{ get; set;	}
		public DbSet<User> Users { get; set; }
		public DBContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
		{
			
		}
	}
}
