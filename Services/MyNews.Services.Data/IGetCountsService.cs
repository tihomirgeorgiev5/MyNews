namespace MyNews.Services.Data
{
    using MyNews.Services.Data.Models;
    using MyNews.Web.ViewModels.Home;

    public interface IGetCountsService
    {
        CountsDto GetCounts();
    }
}
