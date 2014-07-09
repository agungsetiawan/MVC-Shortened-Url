using ShortenUrl.Models;
using ShortenUrl.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShortenUrl.Service
{
    public class UrlService
    {
        private UrlRepository repository = new UrlRepository();

        public string GetUniqueCharacter()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            if(repository.GetByShortenedUrl(finalString)!=null)
            {
                return GetUniqueCharacter();
            }

            return finalString;
        }

        public Url GetByOriginUrl(string originUrl)
        {
            Url urlFound = repository.GetByOriginUrl(originUrl);
            return urlFound;
        }

        public Url GetByShortenedUrl(string url)
        {
            Url urlFound = repository.GetByShortenedUrl(url);
            return urlFound;
        }

        public Url Save(Url url)
        {
            var savedUrl = repository.Save(url);
            return savedUrl;
        }
    }
}