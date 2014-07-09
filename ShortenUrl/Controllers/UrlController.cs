using ShortenUrl.Models;
using ShortenUrl.Repository;
using ShortenUrl.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShortenUrl.Controllers
{
    public class UrlController : Controller
    {
        private UrlService service = new UrlService();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UrlViewModel urlViewModel)
        {

            if(!ModelState.IsValid)
            {
                return View("Index");
            }

            var result = service.GetByOriginUrl(urlViewModel.LongUrl);

            if(result!=null)
            {
                return View("Result", result);
            }

            Url url = new Url();
            url.OriginUrl = urlViewModel.LongUrl;
            url.ShortenedUrl = service.GetUniqueCharacter();

            Url urlSaved = service.Save(url);
            return View("Result", urlSaved);
            
        }

        public ActionResult GetSite(string site)
        {
            var url = service.GetByShortenedUrl(site);
            if(url!=null)
            return Redirect(url.OriginUrl);

            return RedirectToAction("Index");
        }

    }
}
