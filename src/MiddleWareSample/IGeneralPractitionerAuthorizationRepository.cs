using System.Collections.Generic;

namespace MiddleWareSample
{
	public interface IGeneralPractitionerAuthorizationRepository
	{
		IEnumerable<IGeneralPractitionerAuthorizationModel> GetAuthorizationsForGeneralPractitioner(string Id);
	}
}