using ShortenUrl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShortenUrl.Repository
{
    public class UrlRepository
    {
        private MyContext context = new MyContext();

        public Url Save(Url url)
        {
            context.Urls.Add(url);
            context.SaveChanges();
            return url;
        }

        public Url GetByOriginUrl(string originUrl)
        {
            Url url = context.Urls.FirstOrDefault(u => u.OriginUrl == originUrl);
            return url;
        }

        public Url GetByShortenedUrl(string shortenedUrl)
        {
            Url url = context.Urls.Where(u => u.ShortenedUrl == shortenedUrl).SingleOrDefault();
            return url;
        }


    }
}