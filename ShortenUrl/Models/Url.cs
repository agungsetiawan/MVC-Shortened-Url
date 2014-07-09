using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShortenUrl.Models
{
    public class Url
    {
        public int UrlId { get; set; }
        public string OriginUrl { get; set; }
        public string ShortenedUrl { get; set; }
    }
}