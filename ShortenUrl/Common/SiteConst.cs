using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShortenUrl.Common
{
    public class SiteConst
    {
        public static string TopUrl = System.Configuration.ConfigurationManager.AppSettings["TopUrl"];
    }
}