using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Mvc.Routes;

namespace Backbone.Sample
{
    public class Routes : IRouteProvider {
        public IEnumerable<RouteDescriptor> GetRoutes() {
            return new[] {
	            new RouteDescriptor {
		            Route = new Route(
			            "Speakers",
			            new RouteValueDictionary {
				            {"area", "Backbone.Sample"},
				            {"controller", "Speakers"},
				            {"action", "Index"}
			            },
			            new RouteValueDictionary(),
			            new RouteValueDictionary {
				            {"area", "Backbone.Sample"}
			            },
			            new MvcRouteHandler())
	            },
                new RouteDescriptor {
		            Route = new Route(
			            "Cast",
			            new RouteValueDictionary {
				            {"area", "Backbone.Sample"},
				            {"controller", "Cast"},
				            {"action", "Index"}
			            },
			            new RouteValueDictionary(),
			            new RouteValueDictionary {
				            {"area", "Backbone.Sample"}
			            },
			            new MvcRouteHandler())
	            }
            };
        }

        public void GetRoutes(ICollection<RouteDescriptor> routes) {
            foreach (var route in GetRoutes()) {
                routes.Add(route);
            }
        }
    }
}