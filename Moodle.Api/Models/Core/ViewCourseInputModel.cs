using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ViewCourseInputModel : IModel 
	{
		public int courseid {get;set;}
		public int sectionnumber {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sectionnumber",prefix),sectionnumber.ToString()));
			return keyValuePairs;
		}

	}
}