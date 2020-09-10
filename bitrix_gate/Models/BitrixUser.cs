using System;
using System.Collections.Generic;
using System.Text;

namespace bitrix_gate.Models
{
	class BitrixUser
	{
		public string id { get; set; }
		public string name { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string work_position { get; set; }
		public string color { get; set; }
		public string avatar { get; set; }
		public string gender { get; set; }
		public string birthday { get; set; }
		public string extranet { get; set; }
		public string network { get; set; }
		public string bot { get; set; }
		public string connector { get; set; }
		public string external_auth_id { get; set; }
		public string status { get; set; }
		public string idle { get; set; }
		public string last_activity_date { get; set; }
		public string mobile_last_date { get; set; }
		public long[] departments { get; set; }
		public string absent { get; set; }
		public UserPhone phones { get; set; }
	}

	class UserPhone
	{
		public string work_phone { get; set; }
		public string personal_mobile { get; set; }
		public string personal_phone { get; set; }
	}
}


