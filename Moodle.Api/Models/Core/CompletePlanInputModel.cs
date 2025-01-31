using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CompletePlanInputModel : IModel 
	{
		public int planid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("planid",prefix),planid.ToString()));
			return keyValuePairs;
		}

	}
}