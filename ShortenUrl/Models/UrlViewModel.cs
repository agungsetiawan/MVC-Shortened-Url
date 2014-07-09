using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShortenUrl.Models
{
    public class UrlViewModel
    {
        [Required(ErrorMessage="Blank url, seriously?")]
        [Url(ErrorMessage="Valid Url format dude")]
        public string LongUrl { get; set; }
    }
}