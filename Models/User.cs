using MySql.Data.Entity;
using MySql.Data.Types;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HackerTrackerServer.Models
{
	public class User
	{
		[Key]
		public int ID { get; set; }
		[Index(IsUnique = true)]
		[MaxLength(64)]
		public string UserName { get; set; }
	}
}