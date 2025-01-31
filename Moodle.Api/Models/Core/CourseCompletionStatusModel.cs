using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CourseCompletionStatusModel : IModel 
	{
		public Completionstatu completionstatus {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var completionstatusItems = completionstatus.ToKeyValuePairs("completionstatus");
			keyValuePairs.AddRange(completionstatusItems);

			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}