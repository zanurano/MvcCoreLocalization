using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace MvcCoreLocalization.Controllers
{
    public class HelperController : Controller
    {
        //private readonly IHttpContextAccessor _httpContextAccessor;
        //private readonly IHostingEnvironment _hostingEnvironment;
        //public Helper(IHttpContextAccessor httpContextAccessor, IHostingEnvironment _hostingEnvironment)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //    this._hostingEnvironment = hostingEnvironment;
        //}
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public string Index()
        //{
        //    return "This is my default action...";
        //}
        //private readonly IStringLocalizer<HomeController> _localizer;
        //public HelperController(IStringLocalizer<HomeController> localizer)
        //{
        //    _localizer = localizer;
        //    ViewData["Message"] = _localizer["This is my message"];
        //}

        public HelperController()
        {
            
        }

        public ActionResult<string> SetCulture(string culture)
        {
            //RequestCulture requestCulture = new RequestCulture(culture);
            //string cookieCulture = CookieRequestCultureProvider.MakeCookieValue(requestCulture);
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(30);
            cookieOptions.IsEssential = true;
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, culture);
            //string cookieValueFromContext = _httpContextAccessor.HttpContext.Request.Cookies["MyOwnKey"];
            //_httpContextAccessor.HttpContext.Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, culture);

            //return RedirectToAction("Index");
            return "Result:"+ culture;
        }
    }
}