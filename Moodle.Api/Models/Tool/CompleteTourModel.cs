using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class CompleteTourModel : IModel 
	{


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			return keyValuePairs;
		}

	}
}