namespace MyNews.Data.Models
{
    public class ArticleTag
    {
        public int Id { get; set; }

        public int ArticleId { get; set; }

        public virtual NewsArticle Article { get; set; }

        public int TagsId { get; set; }

        public virtual NewsTag Tag { get; set; }
    }
}
