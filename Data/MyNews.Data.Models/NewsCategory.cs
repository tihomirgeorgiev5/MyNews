namespace MyNews.Data.Models
{
    using System.Collections.Generic;

    using MyNews.Data.Common.Models;

    public class NewsCategory : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<NewsArticle> Articles { get; set; }
    }
}
