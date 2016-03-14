using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWareSample
{
	public class GeneralPractitionerAuthorizationRepository : IGeneralPractitionerAuthorizationRepository
	{
		public IEnumerable<IGeneralPractitionerAuthorizationModel> GetAuthorizationsForGeneralPractitioner(string Id)
		{
			return new List<IGeneralPractitionerAuthorizationModel>()
			{
				new GeneralPractitionerAuthorizationModel()
				{
					GeneralPractitionerId = Id,
					Server = "Server1",
					Database = "Database1"
				},
				new GeneralPractitionerAuthorizationModel()
				{
					GeneralPractitionerId = Id,
					Server = "Server1",
					Database = "Database2"
				},
				new GeneralPractitionerAuthorizationModel()
				{
					GeneralPractitionerId = Id,
					Server = "Server2",
					Database = "Database1"
				}
			};
		}
	}
}
