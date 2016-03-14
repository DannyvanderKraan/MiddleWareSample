using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;

namespace MiddleWareSample
{
    public static class GeneralPractitionerAuthorizationMiddlewareExtensions
    {
		public static IApplicationBuilder UseGeneralPractitionerAuthorizationMiddleware(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<GeneralPractitionerAuthorizationMiddleware>();
		}
	}
}
