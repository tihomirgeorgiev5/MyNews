namespace MyNews.Services.Data
{
    using MyNews.Web.ViewModels.Home;

    public interface IGetCountsService
    {
        IndexViewModel GetCounts();
    }
}
