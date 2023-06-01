namespace MyNews.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MyNews.Data.Common.Repositories;
    using MyNews.Data.Models;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<NewsCategory> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<NewsCategory> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.categoriesRepository.All().Select(x => new
            { 
                x.Id,
                x.Name,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
