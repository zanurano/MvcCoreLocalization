using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCoreLocalization.Models;
using Microsoft.Extensions.Localization;

namespace MvcCoreLocalization.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IStringLocalizer<RegistrationController> _localizer;

        public RegistrationController(IStringLocalizer<RegistrationController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            //ViewData["Title"] = _localizer["Registration"];
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}