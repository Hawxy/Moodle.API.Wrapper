using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class PreflightdataInputModel : IModel 
	{

		public string name {get;set;}
		public string value {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("value",prefix),value));
			return keyValuePairs;
		}

	}
}