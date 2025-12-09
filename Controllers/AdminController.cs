using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Posts() // Метод отображения всех постов
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreatePost() // Метод создания поста

        { 
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost() // Метод создания поста

        {
            return View();
        }
    }

   
}
