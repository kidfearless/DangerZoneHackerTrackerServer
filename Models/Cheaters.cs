using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackerTrackerServer.Models
{
	public class Cheater
	{
		[Key]
		public int ID { get; set; }
		[Index(IsUnique = true)]
		public uint AccountID { get; set; }
		public short ThreatLevel { get; set; }
		[MaxLength(128)]
		public string CheatList { get; set; }
		[MaxLength(64)]
		public string LastKnownName { get; set; }
		public User Submitter { get; set; }
	}
}
