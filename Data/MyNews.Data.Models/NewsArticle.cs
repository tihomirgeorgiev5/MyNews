namespace MyNews.Data.Models
{
    using System;
    using System.Collections.Generic;

    using MyNews.Data.Common.Models;

    public class NewsArticle : BaseDeletableModel<int>
    {
        private int tags;

        public NewsArticle()
        {
            this.Tags = new HashSet<ArticleTag>();
            this.Images = new HashSet<Image>();
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime PublishDate { get; set; }

        public int TagsCount
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        public string ImageUrl { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public int CategoryId { get; set; }

        public virtual NewsCategory Category { get; set; }

        public virtual ICollection<ArticleTag> Tags { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
