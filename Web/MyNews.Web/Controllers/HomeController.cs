namespace MyNews.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;
    using MyNews.Services.Data;
    using MyNews.Web.ViewModels;
    using MyNews.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IGetCountsService countService;

        public HomeController(IGetCountsService countService)
        {
            this.countService = countService;
        }

        public IActionResult Index()
        {
            var countsDto = this.countService.GetCounts();
            var viewModel = new IndexViewModel
            {
                CategoriesCount = countsDto.CategoriesCount,
                ImagesCount = countsDto.ImagesCount,
                TagsCount = countsDto.TagsCount,
                ArticlesCount = countsDto.ArticlesCount,
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
