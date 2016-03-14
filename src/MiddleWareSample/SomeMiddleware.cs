using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace MiddleWareSample
{
	public class SomeMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly CurrentGeneralPractitionerService _service;

		public SomeMiddleware(RequestDelegate next,
			CurrentGeneralPractitionerService service)
		{
			if (next == null) throw new ArgumentNullException(nameof(next));
			if (service == null) throw new ArgumentNullException(nameof(service));
			_next = next;
			_service = service;
		}

		public async Task Invoke(HttpContext context)
		{

			context.Response.Headers.Add("Current-User-Id", _service.GetId());
			await _next.Invoke(context);
		}
	}
}
