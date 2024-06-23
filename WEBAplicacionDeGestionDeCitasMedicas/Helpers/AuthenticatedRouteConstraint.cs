using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace WEBAplicacionDeGestionDeCitasMedicas.Helpers
{
    public class AuthenticatedRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.User.Identity.IsAuthenticated;
        }
    }
}
