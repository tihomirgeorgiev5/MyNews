namespace MyNews.Data.Models
{
    using System;

    using MyNews.Data.Common.Models;

    public class NewsArticle : BaseDeletableModel<int>
    {
        private int tags;

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime PublishDate { get; set; }

        public int Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        public string ImageUrl { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }
    }
}
