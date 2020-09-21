using HackerTrackerServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DangerHackerTrackerServer.Controllers
{
	public class TestController : ApiController
	{
		/*Can let the controller figure it out, or defined methods like Test Below*/
		//// GET api/values
		//public IEnumerable<string> Get()
		//{
		//	return new string[] { "value1", "value2" };
		//}

		//// GET api/values/5
		//public string Get(int id)
		//{
		//	return "value";
		//}

		//// POST api/values
		//public void Post([FromBody] string value)
		//{
		//}

		//// PUT api/values/5
		//public void Put(int id, [FromBody] string value)
		//{
		//}

		//// DELETE api/values/5
		//public void Delete(int id)
		//{
		//}

		[HttpGet]
		public void Test()
		{
			var context = new DBContext();
			context.Cheaters.Add(new Cheater()
			{
				AccountID = 10,
				CheatList = "test",
				LastKnownName = "KiD Fearless",
				Submitter = new User()
				{
					UserName = "KiD Fearless"
				},
				ThreatLevel = -1
			});
			context.SaveChanges();

		}
	}
}
