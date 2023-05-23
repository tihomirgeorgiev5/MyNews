namespace MyNews.Data.Models
{
    using MyNews.Data.Common.Models;

    public class NewsTag : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
