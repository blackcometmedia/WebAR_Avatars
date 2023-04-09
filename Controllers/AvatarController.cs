using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAR_Avatars.Models;

namespace WebAR_Avatars.Controllers
{
    public class AvatarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PlayerLoadScreen([Bind("avatar_url")] string avatar_url)
        {
            TempData["Avatar_src"] = avatar_url;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Load([Bind("avatar_url")] string avatar_url)
        {
            TempData["Avatar_src"] = avatar_url;
            return View();
        }

        public IActionResult LoadAvatar()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
