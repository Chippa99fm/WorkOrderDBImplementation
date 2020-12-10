using System;
using System.Collections.Generic;

namespace DBImplementation
{
	public class UsersInfo
	{
		private Dictionary<String, String> userAndPassword = new Dictionary<String, String>();

		public UsersInfo()
		{
			userAndPassword.Add("WORKER", "work_pass");
			userAndPassword.Add("HR", "hr_pass");
			userAndPassword.Add("MANAGER", "man_pass");
			userAndPassword.Add("ADMIN", "admin_pass");
		}

		public String getPassword(String username)
		{
			return userAndPassword[username];
		}
	}
}
