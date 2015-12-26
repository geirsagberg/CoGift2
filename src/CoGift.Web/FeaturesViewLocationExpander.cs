using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc.Razor;

namespace CoGift.Web
{
    public class FeaturesViewLocationExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context) {}

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations) 
            => viewLocations.Select(vl => vl.Replace("/Views/", "/Features/"));
    }
}