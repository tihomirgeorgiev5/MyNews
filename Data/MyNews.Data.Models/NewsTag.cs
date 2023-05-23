namespace MyNews.Data.Models
{
    using System.Collections.Generic;

    using MyNews.Data.Common.Models;

    public class NewsTag : BaseDeletableModel<int>
    {
        public NewsTag()
        {
            this.Articles = new HashSet<ArticleTag>();
        }

        public string Name { get; set; }

        public ICollection<ArticleTag> Articles { get; set; }
    }
}
