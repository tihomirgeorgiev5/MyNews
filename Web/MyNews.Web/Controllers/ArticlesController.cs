namespace MyNews.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MyNews.Web.ViewModels.Articles;

    public class ArticlesController : Controller
    {
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(CreateArticleInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            return this.Redirect("/");
        }
    }
}
