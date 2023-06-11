using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLibrary
{
	public class UserProfile
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public Roles Role { get; set; }
		public int Id { get; set; }
	}
}
