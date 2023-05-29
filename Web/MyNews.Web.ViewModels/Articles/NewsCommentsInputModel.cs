namespace MyNews.Web.ViewModels.Articles
{
    using System.ComponentModel.DataAnnotations;

    public class NewsCategoryInputModel
    {
        public int Id { get; init; }

        [Required]
        [MinLength(4)]
        public string Name { get; init; }
    }
}
