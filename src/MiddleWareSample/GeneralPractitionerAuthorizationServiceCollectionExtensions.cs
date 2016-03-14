using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MiddleWareSample
{
    public static class GeneralPractitionerAuthorizationServiceCollectionExtensions
    {
		public static IServiceCollection AddGeneralPractitionerAuthorization(this IServiceCollection services)
		{
			services.AddSingleton<IGeneralPractitionerAuthorizationRepository, GeneralPractitionerAuthorizationRepository>();
			services.AddSingleton<CurrentGeneralPractitionerService>();
			services.AddSingleton<CurrentGeneralPractitionerAuthorizationsService>();
			return services;
		}
	}
}
