﻿using laMiaPizzeria.Models;
using laMiaPizzeria.Models.Utils;
using Microsoft.AspNetCore.Mvc;

namespace laMiaPizzeria.Controllers
{
    public class PostController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Post> posts = PostData.GetPosts();
            return View("Homepage", posts);
        }
    }
}
