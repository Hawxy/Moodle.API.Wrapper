using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UserDeviceModel : IModel 
	{
		public string item {get;set;}
		public int itemid {get;set;}
		public string message {get;set;}
		public string warningcode {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("item",prefix),item));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemid",prefix),itemid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("message",prefix),message));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("warningcode",prefix),warningcode));
			return keyValuePairs;
		}

	}
}