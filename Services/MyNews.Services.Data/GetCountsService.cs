namespace MyNews.Services.Data
{
    using System.Linq;

    using MyNews.Data.Common.Repositories;
    using MyNews.Data.Models;
    using MyNews.Web.ViewModels.Home;

    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<NewsCategory> categoriesRepository;
        private readonly IRepository<Image> imageRepository;
        private readonly IDeletableEntityRepository<NewsTag> tagsRepository;
        private readonly IDeletableEntityRepository<NewsArticle> articlesRepository;

        public GetCountsService(
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

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel
            {
                CategoriesCount = this.categoriesRepository.All().Count(),
                ImagesCount = this.imageRepository.All().Count(),
                TagsCount = this.tagsRepository.All().Count(),
                ArticlesCount = this.articlesRepository.All().Count(),
            };

            return data;
        }
    }
}
