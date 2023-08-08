namespace MyNews.Web.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using MyNews.Services.Data;
    using MyNews.Web.ViewModels.Articles;

    public class ArticlesController : Controller
    {
        private readonly ICategoriesService categoriesService;

        public ArticlesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateArticleInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();

            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateArticleInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            return this.Json(input);

            return this.Redirect("/");

        }
    }
}
