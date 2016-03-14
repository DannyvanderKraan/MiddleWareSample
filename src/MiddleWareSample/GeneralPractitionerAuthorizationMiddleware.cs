using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace MiddleWareSample
{
	public class GeneralPractitionerAuthorizationMiddleware
	{
		private RequestDelegate Next { get; }
		private IGeneralPractitionerAuthorizationRepository Repository { get; }
		private CurrentGeneralPractitionerService Service { get; }
		private CurrentGeneralPractitionerAuthorizationsService AuthorizationService { get; }

		public GeneralPractitionerAuthorizationMiddleware(RequestDelegate next, 
			IGeneralPractitionerAuthorizationRepository repository,
			CurrentGeneralPractitionerService service,
			CurrentGeneralPractitionerAuthorizationsService authorizationService)
		{
			if (next == null) throw new ArgumentNullException(nameof(next));
			if (repository == null) throw new ArgumentNullException(nameof(repository));
			if (service == null) throw new ArgumentNullException(nameof(service));
			if (authorizationService == null) throw new ArgumentNullException(nameof(authorizationService));
			Next = next;
			Repository = repository;
			Service = service;
			AuthorizationService = authorizationService;

		}

		public async Task Invoke(HttpContext context)
		{
			var generalPractitionerAuthorizations = Repository.GetAuthorizationsForGeneralPractitioner(Service.GetId());
			AuthorizationService.Authorizations = generalPractitionerAuthorizations;
			await Next.Invoke(context);
		}
	}
}
