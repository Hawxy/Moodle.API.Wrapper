using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ViewUrlInputModel : IModel 
	{
		public int urlid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("urlid",prefix),urlid.ToString()));
			return keyValuePairs;
		}

	}
}