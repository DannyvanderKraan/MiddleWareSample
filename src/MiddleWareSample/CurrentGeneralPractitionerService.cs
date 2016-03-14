using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWareSample
{
	public class CurrentGeneralPractitionerService
	{
		private string _id;
		public string GetId()
		{
			if (string.IsNullOrEmpty(_id))
			{
				_id = Guid.NewGuid().ToString();
			}
			return _id;
		}
	}
}
