using System;

namespace OnlineShop.Model.Models
{
    public class VisitorStatistic
    {
        public Guid ID { set; get; }

        public DateTime VisitedDate { set; get; }

        public string IPAddress { set; get; }
    }
}