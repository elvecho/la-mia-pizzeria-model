using laMiaPizzeria.Models;
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
        [HttpGet]
        public IActionResult Details(int id)
        {
            Post postTrovato = null;

            foreach(Post post in PostData.GetPosts())
            {
                if(post.Id == id)
                {
                    postTrovato = post;
                    break;
                }
            }
            if (postTrovato != null)
            {
                return View("details", postTrovato);
            }
            else
            {
                return View("il post con l id " + id + " non è stato trovato");
            }

        }
    }
}
