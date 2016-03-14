namespace MiddleWareSample
{
	public class GeneralPractitionerAuthorizationModel : IGeneralPractitionerAuthorizationModel
	{
		public string Server { get; set; }
		public string GeneralPractitionerId { get; set; }
		public string Database { get; set; }
	}
}