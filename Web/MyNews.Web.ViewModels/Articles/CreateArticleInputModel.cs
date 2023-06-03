namespace MyNews.Web.ViewModels.Articles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateArticleInputModel
    {
        [Required]
        [MinLength(5)]
        public string Title { get; set; }

        [Required]
        [MinLength(20)]
        public string Content { get; set; }

        [Required]
        [MinLength(2)]
        public string Author { get; set; }

        public TimeSpan TimeForReading { get; set; }

        public DateTime PublishDate { get; set; }

        [Display(Name = "Image URL")]
        [Required]
        [Url]
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<NewsCategoryInputModel> Categories { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
    }
}
