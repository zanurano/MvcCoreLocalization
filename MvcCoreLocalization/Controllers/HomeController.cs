using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCoreLocalization.Models;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace MvcCoreLocalization.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewData["Welcome"] = _localizer["Welcome"];
            ViewData["Learn"] = _localizer["Learn about"];
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = _localizer["This is my message"];
            ViewData["Cookies"] = HttpContext.Request.Cookies[CookieRequestCultureProvider.DefaultCookieName];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SetCulture(string culture)
        {
            //RequestCulture requestCulture = new RequestCulture(culture);
            //string cookieCulture = CookieRequestCultureProvider.MakeCookieValue(requestCulture);
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, culture);
            return RedirectToAction("Index");
            //return Ok("Return:" + culture);
        }

        //public JsonResult SetCulture(string culture)
        //{

        //    return Json();
        //}
    }
}
