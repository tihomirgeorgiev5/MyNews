namespace MyNews.Data.Models
{
    using MyNews.Data.Common.Models;

    public class NewsCategory : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
