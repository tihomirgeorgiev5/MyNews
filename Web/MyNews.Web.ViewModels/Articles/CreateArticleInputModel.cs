namespace MyNews.Web.ViewModels.Articles
{
    using System;
    using System.Collections.Generic;

    using MyNews.Data.Models;

    public class CreateArticleInputModel
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime PublishDate { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<NewsCommentsInputModel> NewsComments { get; set; }
    }
}
