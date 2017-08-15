using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CityWebSite
{
    //http://blogs.microsoft.co.il/oric/2011/10/28/exclude-a-filter/

    public class ExcludeFilterAttribute : FilterAttribute
    {
        private Type filterType;

        public ExcludeFilterAttribute(Type filterType)
        {
            this.filterType = filterType;
        }

        public Type FilterType
        {
            get
            {
                return this.filterType;
            }
        }
    }
}