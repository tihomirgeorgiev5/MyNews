namespace MyNews.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using MyNews.Data;
    using MyNews.Data.Common.Repositories;
    using MyNews.Data.Models;
    using MyNews.Web.ViewModels;
    using MyNews.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IDeletableEntityRepository<NewsCategory> categoriesRepository;
        private readonly IRepository<Image> imageRepository;
        private readonly IDeletableEntityRepository<NewsTag> tagsRepository;
        private readonly IDeletableEntityRepository<NewsArticle> articlesRepository;

        public HomeController(
            IDeletableEntityRepository<NewsCategory> categoriesRepository,
            IRepository<Image> imageRepository,
            IDeletableEntityRepository<NewsTag> tagsRepository,
            IDeletableEntityRepository<NewsArticle> articlesRepository)
        {
            this.categoriesRepository = categoriesRepository;
            this.imageRepository = imageRepository;
            this.tagsRepository = tagsRepository;
            this.articlesRepository = articlesRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                CategoriesCount = this.categoriesRepository.All().Count(),
                ImagesCount = this.imageRepository.All().Count(),
                TagsCount = this.tagsRepository.All().Count(),
                ArticlesCount = this.articlesRepository.All().Count(),
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
