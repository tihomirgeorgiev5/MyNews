namespace MyNews.Data.Models
{
    using System;

    using MyNews.Data.Common.Models;

    public class News : BaseDeletableModel<int>
    {
        private int writerCount;

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public int WriterCount
        {
            get { return this.writerCount; }
            set { this.writerCount = value; }
        }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }
    }
}
