using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;

namespace MiddleWareSample
{
    public static class SomeMiddlewareExtensions
    {
	    public static IApplicationBuilder UseSomeMiddleware(this IApplicationBuilder builder)
	    {
		    return builder.UseMiddleware<SomeMiddleware>();
	    }
    }
}
